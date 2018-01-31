﻿Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
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
        Sql = "Select CatID,CatName FROM tbCategory"
        dsTbl("category")
        With slCat.Properties
            .DataSource = DS.Tables("category")
            .ValueMember = "CatID"
            .DisplayMember = "CatName"
            .PopulateViewColumns()
            .View.Columns("CatID").Visible = False
            .View.Columns("CatName").Caption = "หมวดวัสดุ"
        End With

        Sql = "Select LocID,LocName FROM tbLocation"
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
        Sql = "IF OBJECT_ID('tempdb..#Loc') IS NOT NULL DROP table #Loc
                If OBJECT_ID('tempdb..#Cat') IS NOT NULL DROP table #Cat
                SELECT * INTO #Loc FROM vwLogs_Import"
        Sql &= " WHERE " & getExpr(clbLoc, "LocID") & ""
        Sql &= "SELECT * INTO #Cat FROM #Loc"
        Sql &= " WHERE " & getExpr(clbSubCat, "CatID+SubCatID") & ""

        If rdDate_By.Checked = True Then
            Sql &= "SELECT * FROM #Cat"
            SQL &= " WHERE ImportDate >='" & convertDate(deSDate.EditValue) & "'"
            SQL &= " AND ImportDate <='" & convertDate(deEDate.EditValue) & "'"
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
        Sql = "Select CatID+SubCatID As IDValue,SubCatName FROM tbSubcategory"
        Sql &= " WHERE CatID='" & slClick(sender, "CatID") & "'"
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
    Private Sub GVFormat()
        Dim DisableCol As String() = {"LocID", "CatID", "SubCatID", "SupplierID"}
        With gvList
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In .Columns
                If DisableCol.Contains(col.FieldName) Then
                    col.Visible = False
                End If
            Next
            .Columns("Notation").Caption = "หมายเหตุ"
            .Columns("BillNo").Caption = "เลขที่บิล"
            .Columns("LocName").Caption = "สถานที่"
            .Columns("MatName").Caption = "ชื่อวัสดุ"
            .Columns("Unit1").Caption = "จำนวน"
            .Columns("Unit1_Name").Caption = " "
            .Columns("Unit3").Caption = "เป็นปริมาณ"
            .Columns("Unit3_Name").Caption = " "
            .Columns("ImportDate").Caption = "วันที่นำเข้า"
            .Columns("UserName").Caption = "ผู้บันทึกรายการ"
            .Columns("SupplierName").Caption = "ผู้ขาย"
            .Columns("SaveDate").Caption = "วันที่บันทึกข้อมูล"
            .Columns("SaveDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("SaveDate").DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss"
            .BestFitColumns()
            gvList.Columns("Unit1").Summary.Clear()
            gvList.Columns("Unit1").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Unit1", "รวม : {0}")
            gvList.Columns("Unit3").Summary.Clear()
            gvList.Columns("Unit3").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Unit3", "รวม : {0}")
            .Columns("ImportDate").Group()
            .Columns("ImportDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            .ExpandAllGroups()
            .OptionsView.ShowAutoFilterRow = True
        End With
    End Sub
    Private Sub gcList_Click(sender As Object, e As EventArgs) Handles gcList.Click
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
#End Region

End Class
