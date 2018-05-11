Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmLogs_Requisition
    Dim pgcontrol As New ClsPaging
    Private dtResult As New DataTable
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
            .View.Columns("CatName").Caption = getString("catname")
        End With

        SQL = "Select LocID,LocName FROM tbLocation"
        SQL &= If(UserInfo.Permis <= UserGroup.ApproveUser, " WHERE LocID='" & UserInfo.SelectLoc & "'", "")
        Dim abc = SQL
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
                SELECT * INTO #Loc FROM vwFmgRequisition"
        SQL &= " WHERE " & getExpr(clbLoc, "LocID") & ""
        SQL &= " SELECT * INTO #Cat FROM #Loc"
        SQL &= " WHERE " & getExpr(clbSubCat, "CatID+SubCatID") & ""

        If rdDate_By.Checked = True Then
            SQL &= "SELECT * FROM #Cat"
            SQL &= " WHERE RequestDate >='" & convertDate(deSDate.EditValue) & "'"
            SQL &= " AND RequestDate <='" & convertDate(deEDate.EditValue) & "'"
        End If
        SQL &= "SELECT * FROM #Cat ORDER By SaveDate DESC"
        Dim Sq As String = SQL
        dtResult = dsTbl("requisition")
        'gcList.DataSource = dsTbl("requisition")
    End Sub
#End Region
#Region "Common Controls"
    Private Sub FmgRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False

        With pgcontrol
            .setControl.PageDisplayCtrl = txtDisplayPageNo
            .setControl.GridCtrl = gcList
            .setSource = Nothing
        End With

        FirstQry()
        LoadDef()
        loadSuccess = True
    End Sub
    Private Sub slCat_EditValueChanged(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        If loadSuccess = False Then Exit Sub
        SQL = "Select CatID+SubCatID As IDValue,SubCatName FROM tbSubcategory"
        SQL &= " WHERE CatID='" & slClick(sender, "CatID") & "'"
        dsTbl("subcat")

        With clbInfo
            .setControl = clbSubCat
            .ValueMember = "IDValue"
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
        pgcontrol.setSource = dtResult
        pgcontrol.setPageNum = cbPageSize.EditValue
        If pgcontrol.getCurrentPage = 1 Then
            pgcontrol.LoadPage()
        Else
            pgcontrol.FirstPage()
        End If
        GVFormat()
    End Sub
#End Region
    Dim RequestNo As String
    Private Sub GVFormat()
        gridInfo = New GridCaption(gvList)
        With gridInfo
            .HIDE.Columns("Stat")
            .HIDE.Columns("locid")
            .HIDE.Columns("subcatID")
            .HIDE.Columns("catid")
            .SetCaption()
            .SetFormat({"Unit1_Num", "Unit3_Num"})
        End With
        With gvList
            If dtResult.Rows.Count < 1 Then Exit Sub
            .Columns("SaveDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("SaveDate").DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss"
            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unit1_Num", .Columns("Unit1_Num"), "รวม {0:n1}"))
            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "Unit1_Name", .Columns("Unit1_Name"), ""))
            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "Unit3_Name", .Columns("Unit3_Name"), ""))
            .GroupSummary.Add(New GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unit3_Num", .Columns("Unit3_Num"), " {0:n1}"))
            .OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True

            .Columns("SubCatName").Group()
            .Columns("RequestDate").Group()
            .Columns("RequestDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            .Columns("RequestDate").GroupInterval = ColumnGroupInterval.DateRange

            .ExpandAllGroups()
            .BestFitColumns()
            .TopRowIndex = 0
        End With
    End Sub
    Private Sub customDraw(sender As Object, e As FooterCellCustomDrawEventArgs) Handles gvList.CustomDrawFooterCell
        If e.Column.FieldName = "Unit1" Then
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        End If
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
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
            Return
        End If
        Find()
        pgcontrol.setSource = dtResult
        pgcontrol.LoadPage()
        gvList.ExpandAllGroups()

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
    Private Sub cbPageSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPageSize.SelectedIndexChanged
        If loadSuccess = False Or dtResult.Rows.Count <= 0 Then Exit Sub
        If pgcontrol.getCurrentPage = 1 Then
            pgcontrol.setPageNum = cbPageSize.EditValue
            pgcontrol.LoadPage()
        Else
            pgcontrol.setPageNum = cbPageSize.EditValue
            pgcontrol.FirstPage()
        End If
        GVFormat()

    End Sub
    Private Sub PGControl_ButtonClick(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click, BtnNextPage.Click, BtnLastPage.Click, BtnFirstPage.Click
        Dim btn As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)
        If dtResult.Rows.Count <= 0 Then Exit Sub
        With pgcontrol
            Select Case btn.Name
                Case BtnFirstPage.Name
                    .FirstPage()
                Case BtnLastPage.Name
                    .LastPage()
                Case BtnNextPage.Name
                    .NextPage()
                Case BtnPreviousPage.Name
                    .PreviousPage()
            End Select
        End With
        GVFormat()

    End Sub
    Private Sub clbSubCat_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbSubCat.ItemCheck, clbLoc.ItemCheck
        clbInfo.SelectAllCheck(sender, e)
    End Sub
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        If e.RowHandle < 0 Then Exit Sub
        RequestNo = gvList.GetRowCellValue(e.RowHandle, "RequestNo")
    End Sub

End Class