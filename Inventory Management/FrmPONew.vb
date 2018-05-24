Option Explicit On
Option Strict On
Imports ConDB.Main
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmPONew
    Dim dtSupplier, dtMat, dtResult, dtSubCat As New DataTable
    Dim PoID As String
    Property Edit As Boolean = False
    Dim SubCatID As String
    Sub New()
        loadSuccess = False
        InitializeComponent()
        AddHandler txtPO.KeyPress, Sub(sender As Object, e As KeyPressEventArgs)
                                       NumOnly(e)
                                   End Sub
    End Sub
#Region "Code"
    Private Sub Qry()
        Dim QryList As New Dictionary(Of String, String)
        QryList.Add("Supplier", "SELECT SupplierID,SupplierName FROM tbSupplier ORDER BY SupplierName")
        QryList.Add("Mat", "SELECT MatID,MatName,Ratio,Ratio_Name Unit3_Name,CatID+SubCatID SubCatID FROM vwMat WHERE Stat <> 0 ORDER BY MatName")
        QryList.Add("SubCat", "SELECT DISTINCT SD.SubCatID,SC.SubCatName,SD.SupplierID,SD.Ratio FROM tbSupplier_Detail SD
                               INNER JOIN tbSubCategory SC ON SC.CatID+SC.SubCatID = SD.SubCatID ORDER BY SC.SubCatName")
        QryList.Add("PoDetail", "SELECT * FROM tbPo_Detail")

        For Each tbName As String In QryList.Keys
            SQL = QryList(tbName)
            dsTbl(tbName)
        Next

        dtSupplier = DS.Tables("Supplier").Copy
        dtMat = DS.Tables("Mat").Copy
        dtSubCat = DS.Tables("SubCat").Copy
        dtResult = DS.Tables("PoDetail").Clone
        dtResult.Columns.Add("MatName").SetOrdinal(1)
        dtResult.Columns.Add("Unit3_Name").SetOrdinal(4)
        dtResult.Columns.Add("SubCatName").SetOrdinal(0)

    End Sub
    Private Sub LoadDef()
        grpPoList.Enabled = True
        grpPoOrder.Enabled = False
        PnlSave.Visible = False
        btnNewOrder.Enabled = True
        dtResult.Clear()
        txtPO.Text = String.Empty
        deDate.EditValue = Date.Now
        deDelivery.EditValue = Date.Now
        gcList.DataSource = dtResult
    End Sub
    Private Sub LoadComBo()
        With sluSupplier.Properties
            .DataSource = dtSupplier
            .View.PopulateColumns(dtSupplier)
            .DisplayMember = "SupplierName"
            .ValueMember = "SupplierID"
            gridInfo = New GridCaption(.View)
            gridInfo.HIDE.Columns("SupplierID")
            gridInfo.SetCaption()
        End With
    End Sub
    Private Sub AddRow()
        Dim MatID As String = sluMat.EditValue.ToString
        Dim findValue As Integer = 0
        For rw As Integer = 0 To gvList.RowCount - 1
            Dim gvValues As String = gvList.GetRowCellValue(rw, "MatID").ToString
            If MatID = gvValues Then findValue = +1
            If findValue >= 1 Then Exit For
        Next
        Dim dr As DataRow
        If findValue <= 0 Then
            With dtResult
                dr = .NewRow
                dr = dtResult.NewRow
                dr("PoDetailID") = GenID().ToString
                dr("MatID") = sluMat.EditValue
                dr("MatName") = sluMat.Text
                dr("Unit3") = txtUnit1.Text
                dr("Unit3_Name") = lblUnit3_name.Text
                dr("SubCatName") = sluSubCat.Text
                dr("PoID") = PoID
                dr("Stat") = 0
                .Rows.Add(dr)
                .AcceptChanges()
                gcList.Refresh()
            End With
        Else
            'SumRow
            FoundRow = dtResult.Select("MatID='" & MatID & "'")
            For rw As Integer = 0 To dtResult.Rows.Count - 1
                If dtResult.Rows(rw)("MatID").ToString = MatID Then
                    Dim val As Integer = CInt(dtResult.Rows(rw)("Unit3")) + CInt(txtUnit1.Text)
                    dtResult.Rows(rw)("Unit3") = val
                End If
            Next
            dtResult.AcceptChanges()
            gcList.Refresh()
        End If
    End Sub
    Private Sub GVFormat()
        Dim gCaption As New GridCaption(gvList)
        With gCaption
            .ONLY.Columns("PoNo")
            .ONLY.Columns("SubCatName")
            .ONLY.Columns("MatName")
            .ONLY.Columns("Unit3")
            .ONLY.Columns("Unit3_Name")
            .ONLY.Columns("Del")
            .SetCaption()
        End With
        gvList.BestFitColumns()
    End Sub
#End Region

#Region "Other Control"
    Private Sub FrmPOInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Qry()
        LoadDef()
        GVFormat()
        Dim btnDel As New ColumnButton.Editor With {
                         .Caption = " ",
                         .ToolTip = "ลบรายการนี้",
                         .Field = "del",
                         .Image = My.Resources.remove_16x16
                         }
        Dim Buttons As New ColumnButton.Main With {.gControl = gcList, .gView = gvList}
        Buttons.Add(btnDel)
        LoadComBo()
        loadSuccess = True

        If Edit Then
            With EditorPO.setControl
                .PoNo = txtPO
                .Supplier = sluSupplier
                .PoDate = deDate
                .DelivDate = deDelivery
                .gvResult = gvList
                .gcResult = gcList
                .SubCat = sluSubCat
            End With
            PoID = EditorPO.PoID
            dtResult = EditorPO.dtResult
            EditorPO.LoadEdit()
            gvList.BestFitColumns()
            grpPoList.Enabled = False
            grpPoOrder.Enabled = True
            PnlSave.Visible = True
        End If

    End Sub
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        If txtPO.TextLength <> 5 Or ChkInput(grpPoList) = False Then Return
        SQL = "SELECT PoNo FROM tbPo WHERE PoNo='" & txtPO.Text & "'"
        dsTbl("findPO")
        If DS.Tables("findPO").Rows.Count > 0 Then
            MessageBox.Show("เลขที่ PO นี้มีการสั่งซื้อไปแล้ว กรุณาแก้ไข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        txtUnit1.EditValue = 0
        grpPoOrder.Enabled = True
        grpPoList.Enabled = False
        PnlSave.Visible = True
        dtResult.Clear()
        PoID = GenID().ToString
        GVFormat()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If CInt(txtUnit1.EditValue) <= 0 Or String.IsNullOrEmpty(sluMat.EditValue.ToString) Then Return
        AddRow()
        gvList.BestFitColumns()
    End Sub
    Private Sub txtUnit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnit1.EditValueChanged
        txtUnit1.EditValue = If(CInt(txtUnit1.EditValue) < 0, 0, txtUnit1.EditValue)
    End Sub
    Private Sub sluSupplier_EditValueChanged(sender As Object, e As EventArgs) Handles sluSupplier.EditValueChanged
        If sluSupplier.EditValue Is Nothing Or String.IsNullOrEmpty(sluSupplier.EditValue.ToString) Then Return

        FoundRow = dtSubCat.Select("SupplierID = '" & sluSupplier.EditValue.ToString & "'")
        With sluSubCat.Properties
            If FoundRow.Count > 0 Then
                .DataSource = FoundRow.CopyToDataTable
                .View.PopulateColumns(dtSubCat)
                .DisplayMember = "SubCatName"
                .ValueMember = "Ratio"
                gridInfo = New GridCaption(.View)
                gridInfo.HIDE.Columns("SubCatID")
                gridInfo.HIDE.Columns("SupplierID")
                gridInfo.SetCaption()
                .View.Columns("Ratio").Caption = getString("RatioPO")
            Else
                .DataSource = Nothing
            End If
        End With
    End Sub
    Private Sub sluSubCat_EditValueChanged(sender As Object, e As EventArgs) Handles sluSubCat.EditValueChanged
        If sluSubCat.EditValue Is Nothing Or String.IsNullOrEmpty(sluSubCat.EditValue.ToString) Then Return
        SubCatID = SlClick(sluSubCat, "SubCatID")
        FoundRow = dtMat.Select("SubCatID = '" & SubCatID & "' AND Ratio='" & sluSubCat.EditValue.ToString & "'")
        With sluMat.Properties
            If FoundRow.Count > 0 Then
                .DataSource = FoundRow.CopyToDataTable
                .View.PopulateColumns(dtMat)
                .DisplayMember = "MatName"
                .ValueMember = "MatID"
                gridInfo = New GridCaption(.View)
                gridInfo.HIDE.Columns("MatID")
                gridInfo.HIDE.Columns("SubCatID")
                gridInfo.SetCaption()
                .View.Columns("Ratio").Caption = getString("RatioPO")
                lblUnit3_name.Text = FoundRow(0)("Unit3_Name").ToString
            Else
                .DataSource = Nothing
            End If
        End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If dtResult.Rows.Count <= 0 Then Return
        If MessageBox.Show("ยืนยันการบันทึกข้อมุล", "บันทึกข้อมูล PO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.No Then Return
        SQL = "DELETE FROM tbPO WHERE PoID = '" & PoID & "'
               DELETE FROM tbPo_Detail WHERE PoID = '" & PoID & "'
                INSERT INTO tbPO (PoID,PoNo,SupplierID,PoDate,DeliveryDate,UserID)
                VALUES ('" & PoID & "',
                        '" & txtPO.Text & "',
                        '" & sluSupplier.EditValue.ToString & "',
                        '" & ConvertDate(CDate(deDate.EditValue)).ToString & "',
                        '" & ConvertDate(CDate(deDelivery.EditValue)).ToString & "',
                        '" & User.UserID & "'
                        )"
        dsTbl("InsertPO")
        blkCpy("tbPo_Detail", dtResult, {"PoDetailID", "MatID", "Unit3", "PoID", "Stat"})
        MessageBox.Show("บันทึกข้อมุล PO เรียบร้อยแล้ว", "บันทึกข้อมูล PO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BindInfo.Name = "logpo"
        BindInfo.Refresh()
        LoadDef()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        LoadDef()
    End Sub
    Friend Sub CellClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        Dim view As GridView = CType(sender, GridView)
        If view.FocusedColumn.FieldName = "del" Then
            If view.GetFocusedRowCellValue("Stat").ToString = "1" Then MessageBox.Show("ไม่สามารถแก้ไขได้ เนื่องจากรายการนี้มีการส่งของแล้ว", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Return
            dtResult.Rows(gvList.GetDataSourceRowIndex(e.RowHandle)).Delete()
            dtResult.AcceptChanges()
        End If
        view.RefreshData()
    End Sub
#End Region


End Class

