Imports ConDB.Main
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmLogs_Transfer
    Dim locExpr As String
    Dim ApInfo As New ApproveInfo With {.FStat = "ApproveStat"}
    Private Sub FrmLogs_Transfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDef()
    End Sub
    Private Sub LoadDef()
        With slCat.Properties
            SQL = "SELECT CatID,CatName FROM tbCategory"
            .DataSource = dsTbl("slcat")
            .ValueMember = "CatID"
            .DisplayMember = "CatName"
            .PopulateViewColumns()
            .View.Columns("CatID").Visible = False
            .View.Columns("CatName").Caption = getString("catname")
        End With

        With clbInfo
            .setControl = clbLoc
            SQL = "SELECT LocID,LocName FROM tbLocation"
            SQL &= If(UserInfo.Permis <= UserGroup.ApproveUser, " WHERE LocID='" & UserInfo.SelectLoc & "'", "")
            .ValueMember = "LocID"
            .DisplayMember = "LocName"
            .Datasource = dsTbl("clbloc")
        End With
        rdDate_All.Checked = True
        deSDate.EditValue = DateAdd(DateInterval.Day, -7, Today)
        deEDate.EditValue = Today
        clbLoc.CheckAll()

    End Sub
    Private Sub Radio_Checked(sender As Object, e As EventArgs) Handles rdDate_All.CheckedChanged
        deSDate.Enabled = If(rdDate_All.Checked = False, True, False)
        deEDate.Enabled = If(rdDate_All.Checked = False, True, False)
    End Sub
    Private Sub slCat_valuechange(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        With clbInfo
            .setControl = clbSubCat
            SQL = "SELECT CatID+SubCatID IDValue,SubCatName FROM tbSubcategory"
            SQL &= " WHERE CatID ='" & slCat.EditValue & "'"
            .ValueMember = "IDValue"
            .DisplayMember = "SubCatName"
            .Datasource = dsTbl("clbsubcat")
        End With
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim getList As Func(Of CheckedListBoxControl, String) = Function(clbControl As CheckedListBoxControl)
                                                                    Dim Result As String = String.Empty
                                                                    Dim List_ItemCheck As New List(Of String)
                                                                    For Each item As DataRowView In clbControl.CheckedItems
                                                                        List_ItemCheck.Add(item(0))
                                                                    Next
                                                                    For Each list As String In List_ItemCheck
                                                                        If List_ItemCheck.Last = list Then
                                                                            Result += "'" & list & "'"
                                                                        Else
                                                                            Result += "'" & list & "',"
                                                                        End If
                                                                    Next
                                                                    Return Result
                                                                End Function

        If clbSubCat.CheckedItemsCount = 0 Or clbLoc.CheckedItemsCount = 0 Then Exit Sub

        With gcList
            SQL = "SELECT * FROM Logs_Transfer"
            SQL &= " WHERE IDValue IN (" & getList(clbSubCat) & ")"
            SQL &= " AND LocID_Src IN (" & getList(clbLoc) & ")"
            If rdDate_By.Checked = True Then
                SQL &= " AND DateTransfer"
                SQL &= " Between '" & convertDate(deSDate.EditValue) & "'"
                SQL &= " AND '" & convertDate(deEDate.EditValue) & "'"
            End If
            SQL &= " ORDER BY DateTransfer DESC"
            .DataSource = dsTbl("gclist")
        End With
        locExpr = String.Empty
        GVFormat()
    End Sub
    Private Sub GVFormat()
        gridInfo = New GridCaption(gvList)
        With gridInfo
            .HIDE.Columns("idvalue")
            .HIDE.Columns("LocID_Src")
            .SetCaption()
            .SetFormat({"Unit1_Num", "Unit3_Num"})
        End With
        With gvList
            If gvList.RowCount < 1 Then Exit Sub
            .OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True
            .Columns("DateTransfer").Group()
            .Columns("LocSrc_Name").Group()
            .Columns("LocSrc_Name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            .Columns("DateTransfer").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            .Columns("DateTransfer").GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            For Each Colname As String In {"DateSave", "DateApprove"}
                .Columns(Colname).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                .Columns(Colname).DisplayFormat.FormatString = "{d:0}"
            Next

            .ExpandAllGroups()
            .BestFitColumns()
            .TopRowIndex = 0
        End With
    End Sub
    Private Sub Cell_CustomDraw(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvList.CustomDrawCell
        If e.Column.FieldName = "LocDest_Name" Then
            If e.CellValue Is Nothing Then Exit Sub
            If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "LocDest_Name" Then
                Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
                Dim infox As ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, ViewInfo.TextEditViewInfo)
                infox.ContextImage = My.Resources.forward_16x16
                infox.ContextImageAlignment = ContextImageAlignment.Near
                infox.CalcViewInfo()
            End If
        End If

        If e.Column.FieldName = "ApproveStat" Then
            If IsNumeric(e.CellValue) AndAlso e.CellValue = 1 Then
                e.DisplayText = getString("apvstat1")
            ElseIf IsNumeric(e.CellValue) AndAlso e.CellValue = 2 Then
                e.DisplayText = getString("apvstat2")
            ElseIf IsNumeric(e.CellValue) AndAlso e.CellValue = 3 Then
                e.DisplayText = getString("apvstat3")
            ElseIf IsNumeric(e.CellValue) AndAlso e.CellValue = 0 Then
                e.DisplayText = getString("apvstat0")
            End If
        End If
    End Sub
    Public Sub Cell_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle
        If Not IsNumeric(CType(sender, GridView).GetRowCellValue(e.RowHandle, "ApproveStat")) Then Return
        Dim ApproveStat As Integer = CInt(If(IsDBNull(sender.GetRowCellValue(e.RowHandle, "ApproveStat")), 0, sender.GetRowCellValue(e.RowHandle, "ApproveStat")))
        If ApproveStat = 1 Then
            Return
        ElseIf ApproveStat = 0 Then
            Dim MyCol As New Colorlist
            e.Appearance.ForeColor = MyCol.SoftBlue
            Return
        End If
        ApInfo.RowStyle(sender, e)

    End Sub
    Private Sub clbLoc_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbSubCat.ItemCheck, clbLoc.ItemCheck
        clbInfo.SelectAllCheck(sender, e)
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim v As GridView = gvList
        Dim TransferNo As String = v.GetRowCellValue(v.FocusedRowHandle, "TransferNo")
        Dim Stat As String = v.GetRowCellValue(v.FocusedRowHandle, "ApproveStat")
        If IsNumeric(Stat) AndAlso Stat = 0 AndAlso Not String.IsNullOrEmpty(TransferNo) Then
            If MessageBox.Show("ยืนยันการลบรายการโอนย้ายเลขที่ " & TransferNo & " หรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                SQL = "DELETE FROM tbTransfer_Detail
                        FROM tbTransfer_Detail tfde 
                        INNER JOIN tbTransfer tf ON tf.TransferID = tfde.TransferID
                        WHERE tf.TransferNo = '" & TransferNo & "'"
                SQL &= " DELETE FROM tbTransfer WHERE TransferNo ='" & TransferNo & "'"
                dsTbl("delTransfer")
            Else
                Return
            End If
            btnSearch.PerformClick()
        Else
            MessageBox.Show("ไม่สามารถยกเลิกรายการที่ตรวจรับแล้ว กรุณาทำการโอนย้ายกลับหรือติดต่อผู้ดูแล", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
End Class