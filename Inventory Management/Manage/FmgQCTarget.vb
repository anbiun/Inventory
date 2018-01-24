Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports System.ComponentModel

Public Class FmgQCTarget

    Dim dtQCTarget As New DataTable
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
        dtQCTarget = DS.Tables("product").Copy
        gcList.DataSource = dtQCTarget
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
        btnDelList.Click, btnSave.Click, btnCancel.Click, btnAddList.Click, btnOK.Click

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
                    dtQCTarget.Rows.Remove(gvList.GetFocusedDataRow)
                Case = btnEdit.Name
                    btnOK.Visible = True
                    grpMenu.Enabled = False
                    btnDelList.Enabled = False
                    grpImport.Enabled = True
                    grpSave.Enabled = True
                Case = btnRemove.Name
                    Dim dlg_string As String
                    With gvList
                        dlg_string = vbNewLine
                        dlg_string += .Columns("ProductName").GetCaption & " : "
                        dlg_string += .GetRowCellDisplayText(.FocusedRowHandle, "ProductName")
                        dlg_string += vbNewLine
                        dlg_string += .Columns("ProductID").GetCaption & " : "
                        dlg_string += .GetRowCellDisplayText(.FocusedRowHandle, "ProductID")
                    End With
                    If MessageBox.Show("ยืนยันการลบข้อมูล" & dlg_string, "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        SQL = "delete from tbProduct"
                        SQL &= " where ProductID='" & ProductID & "'"
                        dsTbl("del")
                        LoadDef()
                    End If
                Case = btnOK.Name
                    With dtQCTarget
                        Dim row As Integer = gvList.GetDataSourceRowIndex(gvList.FocusedRowHandle)
                        .Rows(row)("ProductName") = txtProduct.Text
                        .Rows(row)("QCTarget") = txtTarget.Text
                        .AcceptChanges()
                    End With
                Case = btnSave.Name
                    'If String.IsNullOrWhiteSpace(txtQuatername.Text) Then
                    '    txtQuatername.Text = InputBox("โปรดตั้งชื่อเป้าผลิต", "Quatername")
                    'End If
                    If Not String.IsNullOrWhiteSpace(txtQuatername.Text) AndAlso
                        MessageBox.Show("ยืนยันบันทึกข้อมูล", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then Exit Sub
                    Dim field As String() = {"ProductID", "ProductName", "QCTarget"}
                    SQL = "delete from tbProduct"
                    dsTbl("del")
                    blkCpy("tbProduct", dtQCTarget, field)
                    LoadDef()
            End Select
        End With

    End Sub
    Private Sub AddList()
        With dtQCTarget
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
#Region "Button Excel"

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exinfo As New export.ExcelExport
        With exinfo
            .Columns.Clear()
            .Columns.Add("A4", "ProductID")
            .Columns.Add("B4", "ProductName")
            .Columns.Add("C4", "QCTarget")
            .Columns.Add("D4", "Unit")
            .Datasource = dtQCTarget
            .Gridsource = gvList
            .FilterSet = export.ExcelExport.FilterOption.Excel_97
            .TemplateFile = "template_qctarget.xls"
        End With
        exinfo.Export()
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim exinfo As New export.ExcelExport
        With exinfo
            'นำข้อมูลเข้า        
            If exinfo.Import() = True Then
                Dim dtCurrent As DataTable = dtQCTarget
                For i As Integer = 0 To gvList.RowCount - 1
                    With dtCurrent
                        For Each item As DataRow In exinfo.Table_Import.Rows
                            Try
                                If .Rows(i)("ProductID").Equals(item(0)) Then
                                    .Rows(i)("ProductName") = item(1)
                                    .Rows(i)("QCTarget") = item(2)
                                    Exit For
                                End If

                            Catch ex As Exception
                                MessageBox.Show("ไฟล์ไม่ถูกต้อง กรุณาตรวจเชคไฟล์ Excel สำหรับนำเข้า", "ไฟล์ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End Try
                        Next
                    End With
                Next
                'ลบรายการที่ไม่มีจาก excel
                'For i As Integer = 0 To dtCurrent.Rows.Count - 1
                '        With dtCurrent
                '        FoundRow = exinfo.Table_Import.Select("เบอร์มีด ='" + .Rows(i)("ProductID") + "'")
                '        If FoundRow.Count = 0 Then .Rows(i).Delete()
                '        End With
                '    Next

                dtCurrent.AcceptChanges()
                gcList.DataSource = dtCurrent
                grpSave.Enabled = True
            End If

            'GVMain.RefreshData
            'Do Import Data Togrid
            'If Fin btnSave.enable
        End With
    End Sub

#End Region
End Class
