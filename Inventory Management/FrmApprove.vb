Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmApprove

    Dim TagID As String, TransferNo As String,
        LocID_Src As String, LocID_Dest As String,
        UserStock As String,
        MatName As String, MatID As String,
        Unit1_Num As Double, Unit3_Num As Double, PerUnit1 As Double,
        Unit1_Name As String, Unit3_Name As String,
        Unit1_ID As String, Unit3_ID As String,
        TransferID As String, dtList As New DataTable,
        TransferDate As Date,
        Approve As New ApproveInfo With {
        .FAccept = "รับของ",
        .FReject = "ตีกลับ"
        }

#Region "FUNC."
    Private Sub FirstQry(Optional All As Boolean = False)
        SQL = "SELECT DISTINCT TF.TransferID,TF.TransferNo, TF.DateTransfer,"
        SQL &= " LCSrc.LocName AS LocID_SrcName, LCDest.LocName AS LocID_DestName"
        SQL &= " FROM tbTransfer TF 
                 INNER JOIN tbTransfer_Detail TFDE ON TFDE.TransferID = TF.TransferID
                 INNER JOIN tbLocation LCSrc ON TF.LocID_Src = LCSrc.LocID
                 INNER JOIN tbLocation LCDest ON TF.LocID_Dest = LCDest.LocID"
        If All = True Then
            SQL &= " WHERE TFDE.Stat = 0"
            dsTbl("alltransfer")
            Exit Sub
        Else
            SQL &= " WHERE TF.LocID_Dest='" & User.SelectLoc & "' AND TFDE.Stat = 0"
        End If

        dsTbl("transfer")

        dtList = getTable("")
        dtList.Clear()
    End Sub
    Private Function getTable(TransferID) As DataTable
        Dim tbResult As New DataTable
        SQL = "SELECT TFDE.TagID,SC.SubCatName,M.MatName,TFDE.Unit1_Num,U1.UnitName Unit1_Name,
                TFDE.Unit3_Num,U3.UnitName Unit3_Name,
                TFDE.Stat,TFDE.Notation,'" & TransferID & "' TransferID
                ,O.Ratio,SC.Grouptag

                From tbTransfer_Detail TFDE 
	                INNER JOIN tbImportOrder O ON TFDE.TagID = O.TagID
	                INNER JOIN tbUnit U1 ON O.Unit1_ID = U1.UnitID 
	                INNER JOIN tbMat M ON O.MatID = M.MatID 
	                INNER JOIN tbSubCategory SC ON M.SubCatID = SC.SubCatID 
	                INNER JOIN tbUnit U3 ON SC.Unit3_ID = U3.UnitID
                WHERE TFDE.TransferID = '" & TransferID & "' 
                ORDER BY M.MatName "
        tbResult = dsTbl("transfer_detail")
        Return tbResult
    End Function
    Private Sub LoadDef()
        With slTransferNo.Properties
            .DataSource = DS.Tables("transfer")
            .DisplayMember = "TransferNo"
            .ValueMember = "TransferID"
            .PopulateViewColumns()
            gridInfo = New GridCaption(.View)
            gridInfo.HIDE.Columns("TransferID")
            gridInfo.SetCaption()

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
        gridInfo = New GridCaption(gvList)
        With gridInfo
            .HIDE.Columns("ApproveID")
            .HIDE.Columns("TransferID")
            .HIDE.Columns("Stat")
            .HIDE.Columns("GroupTag")
            .HIDE.Columns("LocID")
            .HIDE.Columns("Ratio")
            .SetCaption()

        End With
        gvList.Columns("MatName").BestFit()
        With gvList
            For Each colname As String In {"Unit1_Num", "Unit3_Num", "Notation"}
                .Columns(colname).Image = My.Resources.edit_16x16
                .Columns(colname).ImageAlignment = StringAlignment.Far
            Next
            For Each col As GridColumn In .Columns
                If col.FieldName <> "Notation" Then
                    col.BestFit()
                Else
                    col.Width = col.Width * 2
                End If
            Next
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
        With Approve
            .EnableEditCol.Add("Unit1_Num")
            .EnableEditCol.Add("Unit3_Num")
            .EnableEditCol.Add("Notation")
        End With

        FirstQry()
        LoadDef()
        gcList.DataSource = dtList
        GVFomat()
        lbUserStock.Text = User.UserName
        UserStock = User.UserID
        'CreateCheckCol(gcList, gvList)
        gvList.OptionsSelection.EnableAppearanceFocusedRow = False
        SQL = "SELECT * FROM tbApprove"

        FirstQry(True)
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

        For i As Integer = 0 To gvList.RowCount - 1
            Dim Notation As String
            Notation = If(IsDBNull(gvList.GetRowCellValue(i, "Notation")), "", gvList.GetRowCellValue(i, "Notation"))
            If gvList.GetRowCellValue(i, "Stat") = 3 AndAlso String.IsNullOrWhiteSpace(Notation) Then
                MessageBox.Show("กรุณากรอกหมายเหตุ ในแถวที่เป็นสีเหลือง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                gvList.FocusedRowHandle = i
                gvList.FocusedColumn = gvList.Columns("Notation")
                gvList.ShowEditor()
                Return
            End If
        Next
        Dim fieldList() As String = Nothing
        SQL = "DELETE FROM tbTransfer_Detail
               WHERE TransferID = '" & TransferID & "'"
        'update ApproveUser
        SQL &= "UPDATE tbTransfer SET UserApprove='" & User.UserID & "'
                WHERE TransferID ='" & TransferID & "'"
        dsTbl("delOld")


        fieldList = {"TransferID", "TagID", "Unit1_Num", "Unit3_Num", "Stat", "Notation"}
        blkCpy("tbTransfer_Detail", gcList.DataSource, fieldList)
        MsgBox("successfully", MsgBoxStyle.Information)
        btnCancel.PerformClick()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelFunc()
        LoadDef()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If String.IsNullOrEmpty(TransferID) Then Return
        grpRequest.Enabled = False
        PnlSave.Visible = True

        gcList.DataSource = getTable(TransferID)
        gcList.Refresh()
        gvList.PopulateColumns()
        GVFomat()

        Approve.DataSource = getTable(TransferID).Copy
        Approve.CreateCheckCol(gcList, gvList)
        Approve.StatVal = 0
        For Each col As GridColumn In gvList.Columns
            col.OptionsColumn.AllowEdit = If(Approve.EnableEditCol.Contains(col.FieldName, StringComparer.OrdinalIgnoreCase), True, False)
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
        Approve.CellClick(sender, e)
    End Sub
    Public editing As Boolean = False
    Private Sub GVCellChange(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvList.CellValueChanged
        Approve.CellChange(sender, e)
        If editing = True Or Approve.Editing = True Then Return
        If IsNumeric(e.Value) AndAlso e.Value > 0 Then
            Dim v As GridView = CType(sender, GridView)
            Dim UnitCal As New InOutFunc With {
            .Unit1 = v.GetRowCellValue(e.RowHandle, "Unit1_Num"),
            .Unit3 = v.GetRowCellValue(e.RowHandle, "Unit3_Num"),
            .Ratio = v.GetRowCellValue(e.RowHandle, "Ratio"),
            .GroupTag = v.GetRowCellValue(e.RowHandle, "GroupTag")}

            If e.Column.FieldName = "Unit1_Num" Then
                editing = True
                UnitCal.Unit3 = 0
                UnitCal.Result()
                v.SetRowCellValue(e.RowHandle, "Unit3_Num", UnitCal.Unit3)
                editing = False
            ElseIf e.Column.FieldName = "Unit3_Num" Then
                editing = True
                UnitCal.Unit1 = 0
                UnitCal.Result()
                v.SetRowCellValue(e.RowHandle, "Unit1_Num", UnitCal.Unit1)
                editing = False
            End If
        End If
    End Sub
    Public Sub GVRowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle
        Approve.RowStyle(sender, e)
    End Sub
#End Region

End Class