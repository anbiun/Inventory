Imports ConDB.Main
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmLogs_Transfer
    Dim locExpr As String
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
                SQL &= " AND TransferDate"
                SQL &= " Between '" & convertDate(deSDate.EditValue) & "'"
                SQL &= " AND '" & convertDate(deEDate.EditValue) & "'"
            End If
            SQL &= " ORDER BY TransferDate DESC"
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
            .SetFormatNumber({"Unit1_Num", "Unit3_Num"})
        End With
        With gvList
            If gvList.RowCount < 1 Then Exit Sub
            '.Columns("SaveDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            '.Columns("SaveDate").DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss"
            .OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True
            .Columns("TransferDate").Group()
            .Columns("LocSrc_Name").Group()
            .Columns("LocSrc_Name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            .Columns("TransferDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            .Columns("TransferDate").GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange

            .ExpandAllGroups()
            .BestFitColumns()
            .TopRowIndex = 0
        End With
        gvList.BestFitColumns()
    End Sub
    Private Sub Cell_CustomDraw(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvList.CustomDrawCell
        If e.Column.FieldName = "LocSrc_Name" Then
            If e.CellValue Is Nothing Then Exit Sub
            If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "LocSrc_Name" Then
                Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
                Dim infox As ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, ViewInfo.TextEditViewInfo)
                infox.ContextImage = My.Resources.forward_16x16
                infox.ContextImageAlignment = ContextImageAlignment.Far
                infox.CalcViewInfo()
            End If
        End If
    End Sub
    Private Sub Cell_CustomColumnDisplay(ByVal sender As Object,
 ByVal e As CustomColumnDisplayTextEventArgs) Handles gvList.CustomColumnDisplayText
        If e.Column.FieldName = "ApproveStat" Then
            If IsNumeric(e.Value) AndAlso e.Value = 1 Then
                e.DisplayText = getString("apvstat1")
            ElseIf IsNumeric(e.Value) AndAlso e.Value = 2 Then
                e.DisplayText = getString("apvstat2")
            ElseIf IsNumeric(e.Value) AndAlso e.Value = 0 Then
                e.DisplayText = getString("apvstat0")
            End If
        End If
    End Sub
    Public Sub Cell_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle
        Dim View As GridView = sender
        Dim Warn = View.GetRowCellValue(e.RowHandle, "ApproveStat")
        If (e.RowHandle >= 0) Then
            If IsDBNull(Warn) Then
                Warn = 0
            Else
                Warn = If(String.IsNullOrWhiteSpace(Warn), 0, CDbl(Warn))
            End If
            Select Case Warn
                Case = 0
                    e.Appearance.BackColor = Color.IndianRed
                    e.Appearance.BackColor2 = Color.WhiteSmoke
                Case 2
                    e.Appearance.BackColor = Color.LightYellow
                    e.Appearance.BackColor2 = Color.WhiteSmoke
            End Select
        End If
    End Sub
    Private Sub clbLoc_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbSubCat.ItemCheck, clbLoc.ItemCheck
        clbInfo.SelectAllCheck(sender, e)
    End Sub

End Class