Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Public Class FrmApprove

    Dim TagID As String, TransferNo As String,
        LocID_Src As String, LocID_Dest As String,
        UserStock As String,
        MatName As String, MatID As String,
        Unit1_Num As Double, Unit3_Num As Double, PerUnit1 As Double,
        Unit1_Name As String, Unit3_Name As String,
        Unit1_ID As String, Unit3_ID As String,
        TransferID As String, dtList As New DataTable,
        TransferDate As Date, ApproveTB As New ApproveInfo

#Region "FUNC."
    Private Sub FirstQry()
        SQL = "SELECT TF.TransferID,TF.TransferNo, TF.TransferDate,"
        SQL &= " LCSrc.LocName AS LocID_Src_Name, LCDest.LocName AS LocID_Dest_Name"
        SQL &= " FROM tbTransfer TF INNER JOIN tbLocation LCSrc ON TF.LocID_Src = LCSrc.LocID"
        SQL &= " INNER JOIN tbLocation LCDest ON TF.LocID_Dest = LCDest.LocID"
        SQL &= " WHERE TF.LocID_Dest='" & UserInfo.SelectLoc & "' AND TF.Stat = 0"
        dsTbl("transfer")

        dtList = getTable("")
        dtList.Clear()
    End Sub
    Private Function getTable(TransferID) As DataTable
        Dim tbResult As New DataTable
        SQL = "SELECT TFDE.TagID, M.MatName,"
        SQL &= " TFDE.Unit1_Num,U1.UnitName Unit1_Name,"
        SQL &= " TFDE.Unit3_Num,U3.UnitName Unit3_Name"
        SQL &= " FROM tbTransfer_Detail TFDE"
        SQL &= " INNER JOIN tbUnit U1 ON TFDE.Unit1_ID = U1.UnitID"
        SQL &= " INNER JOIN tbMat M ON TFDE.MatID = M.MatID"
        SQL &= " INNER JOIN tbSubCategory SC ON M.SubCatID = SC.SubCatID"
        SQL &= " INNER JOIN tbUnit U3 ON SC.Unit3_ID = U3.UnitID"
        SQL &= " WHERE TFDE.TransferID = '" & TransferID & "'"
        SQL &= " ORDER BY M.MatName "
        tbResult = dsTbl("transfer_detail")

        'Create TBApprove Field
        Dim Col As New DataColumn("ApproveID")
        Col.DefaultValue = genID()
        tbResult.Columns.Add(Col)
        Col = New DataColumn("ApproveDate")
        Col.DefaultValue = CDate(deDate.EditValue).ToShortDateString
        tbResult.Columns.Add(Col)
        Col = New DataColumn("UserApprove")
        Col.DefaultValue = UserInfo.UserID
        tbResult.Columns.Add(Col)
        Col = New DataColumn("TransferID")
        Col.DefaultValue = TransferID
        tbResult.Columns.Add(Col)
        Col = New DataColumn("LocID")
        Col.DefaultValue = UserInfo.SelectLoc
        tbResult.Columns.Add(Col)
        tbResult.Columns.Add(ApproveTB.FStat)
        tbResult.Columns.Add(ApproveTB.FNote)
        Return tbResult
    End Function
    Private Sub LoadDef()
        With slTransferNo.Properties
            .DataSource = DS.Tables("transfer")
            .DisplayMember = "TransferNo"
            .ValueMember = "TransferID"
            .PopulateViewColumns()

            .View.Columns("TransferNo").Visible = False
            .View.Columns("TransferID").Caption = "รหัสเอกสาร"
            .View.Columns("TransferDate").Caption = "วันที่โอนย้าย"
            .View.Columns("LocID_Src_Name").Caption = "คลังวัสดุต้นทาง"
            .View.Columns("LocID_Dest_Name").Caption = "คลังวัสดุปลายทาง"
            .View.ExpandAllGroups()
            .View.BestFitColumns()
        End With
        slTransferNo.Properties.NullText = ""
        deDate.EditValue = Today
    End Sub
    Private Sub SumUnit()
        Dim Unit1_Sum, Unit3_Sum As Double

        For rw As Integer = 0 To gvList.RowCount - 1
            If TagID = gvList.GetRowCellValue(rw, "TagID") Then
                'PriceSum = PriceSum + CDbl(gvDes.GetRowCellValue(rw, "Price"))
                Unit1_Sum = CDbl(gvList.GetRowCellValue(rw, "Unit1_Num")) + Unit1_Num
                Unit3_Sum = CDbl(gvList.GetRowCellValue(rw, "Unit3_Num")) + Unit3_Num
            End If
        Next

        For rw As Integer = 0 To gvList.RowCount - 1
            If TagID = gvList.GetRowCellValue(rw, "TagID") Then
                With gvList
                    '.SetRowCellValue(rw, "PriceSum", unit3Sum * gvDes.GetRowCellValue(rw, "Price"))
                    .SetRowCellValue(rw, "Unit1_Num", Unit1_Sum)
                    .SetRowCellValue(rw, "Unit3_Num", Unit3_Sum)
                End With
            End If
        Next
    End Sub
    Private Sub GVFomat()

        With gvList
            .PopulateColumns()
            .Columns("MatName").Caption = getString("matname")
            .Columns("Unit1_Num").Caption = getString("unit1_num")
            .Columns("Unit1_Name").Caption = getString("unit1_name")
            .Columns("Unit3_Num").Caption = getString("Unit3_num")
            .Columns("Unit3_Name").Caption = getString("unit3_name")
            .Columns("ApproveDate").Caption = getString("approvedate")
            .Columns("UserApprove").Caption = getString("userapprove")
            .Columns("ApproveNote").Caption = getString("approvenote")
            .Columns("TransferID").Visible = False
            .Columns("LocID").Visible = False
            .Columns("ApproveID").Visible = False
            .Columns("ApproveStat").Visible = False
            .BestFitColumns()
        End With
    End Sub
    Private Sub cancelFunc()
        grpRequest.Enabled = True
        PnlSave.Visible = False
        dtList.Clear()
        gcList.DataSource = Nothing
        FirstQry()
    End Sub
#End Region

#Region "FormLoad"
    Private Sub FrmApprove_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ApproveTB
            .FAccept = "รับของ"
            .FNotFound = "ไม่พบ"
            .FStat = "ApproveStat"
            .FNote = "ApproveNote"
        End With

        FirstQry()
        LoadDef()
        gcList.DataSource = dtList
        GVFomat()
        lbUserStock.Text = UserInfo.UserName
        UserStock = UserInfo.UserID
        'CreateCheckCol(gcList, gvList)
        gvList.OptionsSelection.EnableAppearanceFocusedRow = False
    End Sub
#End Region

#Region "Button Control"
    Private Sub btnRemove_Click(sender As Object, e As EventArgs)
        If gvList.FocusedRowHandle >= 0 Then
            dtList.Rows(gvList.FocusedRowHandle).Delete()
        End If
        dtList.AcceptChanges()
        gcList.Refresh()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fieldList() As String = Nothing
        fieldList = {"ApproveID", "TransferID", "UserApprove", "ApproveDate", "TagID", "ApproveStat",
                     "ApproveNote", "LocID"}
        blkCpy("tbApprove", gcList.DataSource, fieldList)
        MsgBox("successfully", MsgBoxStyle.Information)
        btnCancel.PerformClick()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelFunc()
        LoadDef()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        grpRequest.Enabled = False
        PnlSave.Visible = True

        gcList.DataSource = getTable(TransferID)
        gcList.Refresh()
        gvList.PopulateColumns()
        GVFomat()
        ApproveTB.CreateCheckCol(gcList, gvList)

        For Each col As GridColumn In gvList.Columns
            col.OptionsColumn.AllowEdit = If(col.FieldName = "ApproveNote", True, False)
        Next
    End Sub
#End Region

#Region "Other Control"
    Private Sub deDate_EditValueChanged(sender As Object, e As EventArgs) Handles deDate.EditValueChanged
        TransferDate = deDate.EditValue
    End Sub
    Private Sub slTagID_EditValueChanged(sender As Object, e As EventArgs) Handles slTransferNo.EditValueChanged
        slTransferNo.Properties.View.ExpandAllGroups()
        TransferID = slClick(sender, "TransferID")
    End Sub
    Private Sub txtTransferNo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = "-" Then
            Exit Sub
        Else
            numOnly(e)
        End If
    End Sub

    Private Sub RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvList.RowCellClick
        ApproveTB.CellClick(sender, e)
    End Sub
    Private Sub GVCellChange(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvList.CellValueChanged
        ApproveTB.CellChange(sender, e)
    End Sub

    Public Sub GVRowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle
        ApproveTB.RowStyle(sender, e)
    End Sub
#End Region

End Class