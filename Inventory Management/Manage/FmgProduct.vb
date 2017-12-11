Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Public Class FmgProduct
    Dim dtProduct As New DataTable
    Dim dtRow As DataRow
    Dim ProductID As String
    Dim _pdname As String
    Dim _qctarget As Double
    Property ProductName As String
        Set(value As String)
            _pdname = value
            txtProduct.Text = value
        End Set
        Get
            Return _pdname
        End Get
    End Property
    Property QCTarget As Double
        Set(value As Double)
            _qctarget = value
            txtTarget.EditValue = _qctarget
        End Set
        Get
            Return _qctarget
        End Get
    End Property
    Private Sub ShowDB()
        SQL = "SELECT *,'โหล' Unit FROM tbProduct"
        dsTbl("product")
        dtProduct = DS.Tables("product").Copy
        gcList.DataSource = dtProduct
        With List_Caption
            .Clear()
            .Add("QCTarget", "เป้าผลิต")
            .Add("ProductID", "รหัสแก้ไข")
            .Add("ProductName", "เบอร์มืด")
            .Add("Unit", " ")
        End With
        Grid_Caption(gvList)
        With gvList.Columns("QCTarget").DisplayFormat
            .FormatType = FormatType.Numeric
            .FormatString = "#,0"
        End With
        gvList.OptionsView.ShowAutoFilterRow = True
        gvList.Columns("ProductID").MaxWidth = gvList.Columns("ProductID").GetBestWidth
    End Sub
    Private Sub LoadDef()
        ShowDB()
        grpMenu.Enabled = True
        btnDelList.Enabled = True
        btnOK.Visible = False
        grpImport.Enabled = False
        grpSave.Enabled = False
        btnEdit.Enabled = False
        btnRemove.Enabled = False

    End Sub
    Private Sub FmgProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDef()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Save ??", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then Exit Sub
        Dim field As String() = {"ProductID", "ProductName", "QCTarget"}
        'blkCpy("tbProduct", dtProduct, field)
    End Sub
    Private Sub RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        If e.RowHandle < 0 Then Exit Sub
        ProductName = gvList.GetRowCellValue(e.RowHandle, "ProductName")
        QCTarget = gvList.GetRowCellValue(e.RowHandle, "QCTarget")
        ProductID = gvList.GetRowCellValue(e.RowHandle, "ProductID")

        btnRemove.Enabled = True
        btnEdit.Enabled = True
    End Sub
#Region "BUTTON"
    Private Sub BtnClick(sender As Object, e As EventArgs) Handles btnNew.Click, btnEdit.Click, btnRemove.Click,
        btnDelList.Click, btnSave.Click, btnImport.Click, btnExport.Click, btnCancel.Click, btnAddList.Click, btnOK.Click

        Dim btn As SimpleButton = CType(sender, SimpleButton)
        With btn
            Select Case .Name
                Case = btnNew.Name
                    grpImport.Enabled = True
                    grpSave.Enabled = True
                    grpMenu.Enabled = False
                Case = btnCancel.Name
                    LoadDef()
                Case = btnAddList.Name
                    AddList()
                Case = btnDelList.Name
                    dtProduct.Rows.Remove(gvList.GetFocusedDataRow)
                Case = btnEdit.Name
                    btnOK.Visible = True
                    grpMenu.Enabled = False
                    btnDelList.Enabled = False
                    grpImport.Enabled = True
                    grpSave.Enabled = True
                Case = btnRemove.Name
                Case = btnOK.Name
                    With dtProduct
                        .Rows(gvList.FocusedRowHandle)("ProductName") = txtProduct.Text
                        .Rows(gvList.FocusedRowHandle)("QCTarget") = txtTarget.Text
                        .AcceptChanges()
                    End With
                Case = btnSave.Name
                    If MessageBox.Show("ยืนยันบันทึกข้อมูล", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then Exit Sub
                    Dim field As String() = {"ProductID", "ProductName", "QCTarget"}
                    SQL = "delete from tbProduct"
                    dsTbl("del")
                    blkCpy("tbProduct", dtProduct, field)
                    LoadDef()
            End Select
        End With

    End Sub
    Private Sub AddList()
        With dtProduct
            dtRow = .NewRow
            dtRow("ProductID") = genID()
            dtRow("ProductName") = txtProduct.Text
            dtRow("QCTarget") = txtTarget.EditValue
            dtRow("Unit") = "โหล"
            .Rows.Add(dtRow)
            .AcceptChanges()
        End With
    End Sub
#End Region
End Class