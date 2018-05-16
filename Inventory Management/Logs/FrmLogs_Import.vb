Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmLogs_Import
#Region "Code Sub Func."
    Private Function getExpr(control As DevExpress.XtraEditors.CheckedListBoxControl, field As String)
        Dim chkList As New List(Of String)
        Dim ret As String = String.Empty
        For Each item As DataRowView In control.CheckedItems
            chkList.Add(item(0))
        Next
        For Each item As String In chkList
            If item = chkList.Last Then
                ret &= " " & field & "='" & item & "'"
            Else
                ret &= " " & field & "='" & item & "' OR"
            End If
        Next
        Return ret
    End Function
    Private Sub FirstQry()
        SQL = "Select CatID,CatName FROM tbCategory"
        dsTbl("category")
        With slCat.Properties
            .DataSource = DS.Tables("category")
            .ValueMember = "CatID"
            .DisplayMember = "CatName"
            .PopulateViewColumns()
            .View.Columns("CatID").Visible = False
            .View.Columns("CatName").Caption = "หมวดวัสดุ"
        End With

        SQL = "Select LocID,LocName FROM tbLocation"
        SQL &= If(User.Permission <= UserInfo.UserGroup.Manger, " WHERE LocID='" & User.SelectLoc & "'", "")
        dsTbl("location")
        With clbInfo
            .setControl = clbLoc
            .ValueMember = "LocID"
            .DisplayMember = "LocName"
            .Datasource = DS.Tables("location")
        End With

        'clsDS({"requisition"})
        'SQL = "Select * FROM vwFmgRequisition ORDER BY SaveDate"
        'dsTbl("requisition")
    End Sub
    Private Sub LoadDef()
        clbLoc.CheckAll()
        rdDate_All.Checked = True
        deSDate.EditValue = DateAdd(DateInterval.Day, -7, Today)
        deEDate.EditValue = Today
        deSDate.Enabled = False
        deEDate.Enabled = False
    End Sub
    Private Sub Find()
        SQL = "IF OBJECT_ID('tempdb..#Loc') IS NOT NULL DROP table #Loc
                If OBJECT_ID('tempdb..#Cat') IS NOT NULL DROP table #Cat
                SELECT * INTO #Loc FROM vwLogs_Import"
        SQL &= " WHERE " & getExpr(clbLoc, "LocID") & ""
        SQL &= "SELECT * INTO #Cat FROM #Loc"
        SQL &= " WHERE " & getExpr(clbSubCat, "CatID+SubCatID") & ""

        If rdDate_By.Checked = True Then
            SQL &= "SELECT * FROM #Cat"
            SQL &= " WHERE ImportDate >='" & ConvertDate(deSDate.EditValue) & "'"
            SQL &= " AND ImportDate <='" & ConvertDate(deEDate.EditValue) & "'"
        End If
        SQL &= "SELECT * FROM #Cat ORDER By ImportDate"
        Dim SQ As String = SQL

        gcList.DataSource = dsTbl("logs_import")
    End Sub
#End Region
#Region "Common Controls"
    Dim RequestNo As String
    Private Sub FmgRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False
        FirstQry()
        LoadDef()
        loadSuccess = True
    End Sub
    Private Sub slCat_EditValueChanged(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        If loadSuccess = False Then Exit Sub
        SQL = "Select CatID+SubCatID As IDValue,SubCatName FROM tbSubcategory"
        SQL &= " WHERE CatID='" & SlClick(sender, "CatID") & "'"
        dsTbl("subcat")

        With clbInfo
            .setControl = clbSubCat
            .ValueMember = "IDvalue"
            .DisplayMember = "SubCatName"
            .Datasource = DS.Tables("subcat")
        End With
    End Sub
    Private Sub rdDate_All_CheckedChanged(sender As Object, e As EventArgs) Handles rdDate_All.CheckedChanged
        If loadSuccess = False Then Exit Sub
        Dim rd As RadioButton = CType(sender, RadioButton)
        deSDate.Enabled = If(rd.Checked <> True, True, False)
        deEDate.Enabled = If(rd.Checked <> True, True, False)
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If clbSubCat.CheckedItemsCount = 0 Or clbLoc.CheckedItemsCount = 0 Then Exit Sub
        Find()
        GVFormat()
    End Sub
    Private Sub GVFormat()
        gridInfo = New GridCaption(gvList)
        With gridInfo
            .HIDE.Columns("LocID")
            .HIDE.Columns("CatID")
            .HIDE.Columns("SubCatID")
            .HIDE.Columns("SupplierID")
            .SetCaption()
            .SetFormat({"Unit1", "Unit3"})
        End With
        With gvList
            If gvList.RowCount < 1 Then Exit Sub
            .Columns("SaveDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("SaveDate").DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss"

            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unit1", .Columns("Unit1"), "รวม {0:n1}"))
            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "Unit1_Name", .Columns("Unit1_Name"), ""))
            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "Unit3_Name", .Columns("Unit3_Name"), ""))
            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unit3", .Columns("Unit3"), " {0:n1}"))
            .OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True
            .Columns("SubCatName").Group()
            .Columns("ImportDate").Group()
            .Columns("ImportDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            .Columns("ImportDate").GroupInterval = ColumnGroupInterval.DateRange

            .ExpandAllGroups()
            .BestFitColumns()
            .TopRowIndex = 0
        End With
    End Sub
    Private Sub gcList_Click(sender As Object, e As EventArgs)
        Dim rw As Integer = gvList.FocusedRowHandle
        If rw >= 0 Then
            RequestNo = gvList.GetRowCellValue(rw, "RequestNo")
        Else
            RequestNo = gvList.GetFocusedValue
        End If
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs)
        SQL = "SELECT RequestNo From tbRequisition WHERE RequestNo='" & RequestNo & "'"
        SQL &= " AND Stat='1'"
        dsTbl("find")
        If DS.Tables("find").Rows.Count > 0 Then
            If MsgBox("RequestNo. " & RequestNo & " Cancle Confirm", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                SQL = "UPDATE tbRequisition SET Stat=0 WHERE RequestNo='" & RequestNo & "'"
                SQL &= "AND Stat = '1'"
                dsTbl("update")
                SQL = "DELETE FROM tbRequisition WHERE RequestNo='" & RequestNo & "' AND Stat = '0'"
                dsTbl("del")
                'LoadDef()
                'btnCancel.PerformClick()
            End If
        Else
            MsgBox("เลขที่ใบเบิกไม่ถูกต้อง (" & RequestNo & ")", MsgBoxStyle.Critical)
        End If
        FirstQry()
    End Sub
    Private Sub btnLogs_Click(sender As Object, e As EventArgs)
        SQL = "select L.*,M.MatName from Logs_Requisition L INNER JOIN tbMat M ON L.MatID = M.MatID ORDER BY LogNo"
        gcList.DataSource = dsTbl("logsrequisiton")
        gvList.PopulateColumns()
        gvList.Columns("RequestNo").Group()
        gvList.ExpandAllGroups()
    End Sub
    Private Sub btnExPortExcel_Click(sender As Object, e As EventArgs)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel xlsx |*.xlsx"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            gcList.ExportToXlsx(saveFileDialog1.FileName)
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        gvList.Columns.Clear()
        SQL = "select * from vwRequisition"
        gcList.DataSource = Nothing
        gcList.DataSource = dsTbl("requisition")
        gvList.PopulateColumns()
    End Sub

    Private Sub clbLoc_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbSubCat.ItemCheck, clbLoc.ItemCheck
        clbInfo.SelectAllCheck(sender, e)
    End Sub

    Private Sub gvList_MouseDown(sender As Object, e As MouseEventArgs) Handles gvList.MouseDown
        Dim view As GridView = CType(sender, GridView)
        If e.Button = MouseButtons.Right Then
            'If String.IsNullOrEmpty(GetGroupValue(_gView, gControl, "PoNo", "PoNo")) Then Return
            'ShowMenu(view.CalcHitInfo(New Point(e.X, e.Y)))

        End If
    End Sub
    'Private Sub ShowMenu(ByVal hi As GridHitInfo)
    '    Dim menu As GridViewMenu = Nothing
    '    If hi.HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Row Then
    '        menu = New GridViewColumnButtonMenu(hi.View)
    '        menu.Init(hi)
    '        menu.Show(hi.HitPoint)
    '    End If
    'End Sub

#End Region
End Class

