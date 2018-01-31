Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid

Public Class FmgRequisition

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
        dsTbl("location")
        With clbLoc
            .DataSource = DS.Tables("location")
            .ValueMember = "LocID"
            .DisplayMember = "LocName"
        End With

        'clsDS({"requisition"})
        'SQL = "Select * FROM vwFmgRequisition ORDER BY SaveDate"
        'dsTbl("requisition")
    End Sub
    Private Sub LoadDef()
        clbLoc.CheckAll()
        rdDate_All.Checked = True
        deSDate.EditValue = Today
        deEDate.EditValue = Today
        deSDate.Enabled = False
        deEDate.Enabled = False
    End Sub
    Private Sub Find()
        SQL = "IF OBJECT_ID('tempdb..#Loc') IS NOT NULL DROP table #Loc
                If OBJECT_ID('tempdb..#Cat') IS NOT NULL DROP table #Cat
                SELECT * INTO #Loc FROM vwFmgRequisition"
        SQL &= " WHERE " & getExpr(clbLoc, "LocID") & ""
        SQL &= "SELECT * INTO #Cat FROM #Loc"
        SQL &= " WHERE " & getExpr(clbSubCat, "CatID+SubCatID") & ""

        If rdDate_By.Checked = True Then
            SQL &= "SELECT * FROM #Cat"
            SQL &= " WHERE RequestDate >='" & convertDate(deSDate.EditValue) & "'"
            SQL &= " AND RequestDate <='" & convertDate(deEDate.EditValue) & "'"
        End If
        SQL &= "SELECT * FROM #Cat ORDER By SaveDate"
        gcList.DataSource = dsTbl("requisition")
    End Sub
#End Region
#Region "Common Controls"
    Private Sub FmgRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False
        FirstQry()
        LoadDef()
        loadSuccess = True
    End Sub
    Private Sub slCat_EditValueChanged(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        If loadSuccess = False Then Exit Sub
        SQL = "Select CatID+SubCatID As IDValue,SubCatName FROM tbSubcategory"
        SQL &= " WHERE CatID='" & slClick(sender, "CatID") & "'"
        dsTbl("subcat")

        With clbSubCat
            .DataSource = DS.Tables("subcat")
            .ValueMember = "IDvalue"
            .DisplayMember = "SubCatName"
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
#End Region

    Dim RequestNo As String

    Private Sub GVFormat()
        With gvList
            .Columns("LocID").Visible = False
            .Columns("SubCatID").Visible = False
            .Columns("CatID").Visible = False
            .Columns("Stat").Visible = False
            .Columns("MatID").Visible = False
            .Columns("RequestNo").Caption = "เลขที่ใบเบิก"
            .Columns("MatName").Caption = "ชื่อวัสดุ"
            .Columns("Unit1_Num").Caption = "จำนวน"
            .Columns("Unit1_Name").Caption = " "
            .Columns("Unit3_Num").Caption = "เป็นปริมาณ"
            .Columns("Unit3_Name").Caption = " "
            .Columns("RequestDate").Caption = "วันที่เบิกวัสดุ"
            .Columns("UserRequest").Caption = "ผู้เบิกวัสดุ"
            .Columns("UserStock").Caption = "ผู้จ่ายวัสดุ"
            .Columns("SaveDate").Caption = "วันที่บันทึกข้อมูล"
            .Columns("SaveDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("SaveDate").DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss"
            .BestFitColumns()
            gvList.Columns("Unit1_Num").Summary.Clear()
            gvList.Columns("Unit1_Num").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Unit1_Num", "รวม : {0}")
            gvList.Columns("Unit3_Num").Summary.Clear()
            gvList.Columns("Unit3_Num").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Unit3_Num", "รวม : {0}")
            .Columns("RequestDate").Group()
            .Columns("RequestDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            .ExpandAllGroups()
            .OptionsView.ShowAutoFilterRow = True
        End With
    End Sub
    'Private Sub txtFind_EditValueChanged(sender As Object, e As EventArgs)
    '    gcList.DataSource = Find("requisition", "TagID Like '%" & txtFind.Text & "%'")
    'End Sub
    Private Sub gcList_Click(sender As Object, e As EventArgs) Handles gcList.Click
        Dim rw As Integer = gvList.FocusedRowHandle
        If rw >= 0 Then
            RequestNo = gvList.GetRowCellValue(rw, "RequestNo")
        Else
            RequestNo = gvList.GetFocusedValue
        End If
    End Sub

    Private Sub txtTagID_EditValueChanged(sender As Object, e As EventArgs)
        'gcList.DataSource = Find("requisition", "TagID Like '%" & Trim(txtTagID.Text) & "%'")
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
        End If
        FirstQry()
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs)

        'FirstQry()
        'Dim dtRequisition As DataTable = DS.Tables("requisition").Copy
        'gcList.DataSource = dtRequisition
        'gvList.Columns("RequestNo").Group()
        'gvList.ExpandAllGroups()
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

End Class