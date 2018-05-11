Option Explicit On
Option Strict On
Imports ConDB.Main
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmQCTarget
    Friend dtQCTarget As DataTable
    Private Sub LoadDef()
        pnlSave.Enabled = False

        FirstQry()
        'assign datasource
        gcList.DataSource = dtQCTarget
        'set caption
        gridInfo = New GridCaption(gvList)
        gridInfo.HIDE.Columns("qcname")
        gridInfo.SetCaption()
        'set Monthname
        If gvList.RowCount <= 0 Then Return
        Dim NumberColList As New List(Of String)
        For month As Integer = 1 To 12
            gvList.Columns(month + 1).Caption = MonthName(month)
            NumberColList.Add(gvList.Columns(month + 1).FieldName)
        Next
        gridInfo.SetFormat(NumberColList.ToArray)
        gvList.OptionsView.ShowAutoFilterRow = True

    End Sub
    Private Sub FirstQry()
        SQL = "SELECT * FROM tbQCTarget"
        dsTbl("vwqctarget")
        dtQCTarget = DS.Tables("vwqctarget").Copy
    End Sub
    Private Sub FrmQCTarget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False

        LoadDef()
        loadSuccess = True
    End Sub

#Region "ButtonControl"
    Dim AllowEdit As Boolean = False
    Private Sub Cancel()
        pnlMenu.Enabled = True
        pnlSave.Enabled = False
        FirstQry()
        gcList.DataSource = dtQCTarget
        gvList.OptionsView.NewItemRowPosition = NewItemRowPosition.None
        AllowEdit = False
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        pnlMenu.Enabled = False
        pnlSave.Enabled = True
        gvList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
        gvList.TopRowIndex = gvList.RowCount
        gvList.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle
        gvList.FocusedColumn = gvList.VisibleColumns(1)
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        pnlMenu.Enabled = False
        pnlSave.Enabled = True
        AllowEdit = True
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MessageBox.Show("ยืนยันการลบรายการที่เลือก", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            SQL = "DELETE FROM tbQCTarget WHERE ProductID='" & gvList.GetFocusedRowCellValue("ProductID").ToString & "'"
            dsTbl("delqc")
            Cancel()
        End If
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exinfo As New export.ExcelExport
        With exinfo
            .Columns.Clear()
            .Columns.Add("A3", "ProductID")
            .Columns.Add("B3", "ProductName")
            .Columns.Add("C3", gvList.Columns(2).FieldName)
            .Columns.Add("D3", gvList.Columns(3).FieldName)
            .Columns.Add("E3", gvList.Columns(4).FieldName)
            .Columns.Add("F3", gvList.Columns(5).FieldName)
            .Columns.Add("G3", gvList.Columns(6).FieldName)
            .Columns.Add("H3", gvList.Columns(7).FieldName)
            .Columns.Add("I3", gvList.Columns(8).FieldName)
            .Columns.Add("J3", gvList.Columns(9).FieldName)
            .Columns.Add("K3", gvList.Columns(10).FieldName)
            .Columns.Add("L3", gvList.Columns(11).FieldName)
            .Columns.Add("M3", gvList.Columns(12).FieldName)
            .Columns.Add("N3", gvList.Columns(13).FieldName)
            .Datasource = dtQCTarget
            .Gridsource = gvList
            .FilterSet = export.ExcelExport.FilterOption.Excel_97
            .TemplateFile = "template_qc12month.xls"
        End With
        exinfo.Export()
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        pnlMenu.Enabled = False
        pnlSave.Enabled = True
        Dim exinfo As New export.ExcelExport
        With exinfo
            'นำข้อมูลเข้า        
            If exinfo.Import() = True Then
                Dim dtCurrent As DataTable = DS.Tables("vwqctarget").Copy
                For i As Integer = 0 To gvList.RowCount - 1
                    With dtCurrent
                        For Each item As DataRow In exinfo.Table_Import.Rows
                            Try
                                If .Rows(i)("ProductID").Equals(item(0)) Then
                                    .Rows(i)("ProductName") = item(1)
                                    .Rows(i)(gvList.Columns(2).FieldName) = item(2)
                                    .Rows(i)(gvList.Columns(3).FieldName) = item(3)
                                    .Rows(i)(gvList.Columns(4).FieldName) = item(4)
                                    .Rows(i)(gvList.Columns(5).FieldName) = item(5)
                                    .Rows(i)(gvList.Columns(6).FieldName) = item(6)
                                    .Rows(i)(gvList.Columns(7).FieldName) = item(7)
                                    .Rows(i)(gvList.Columns(8).FieldName) = item(8)
                                    .Rows(i)(gvList.Columns(9).FieldName) = item(9)
                                    .Rows(i)(gvList.Columns(10).FieldName) = item(10)
                                    .Rows(i)(gvList.Columns(11).FieldName) = item(11)
                                    .Rows(i)(gvList.Columns(12).FieldName) = item(12)
                                    .Rows(i)(gvList.Columns(13).FieldName) = item(13)
                                    Exit For
                                End If

                            Catch ex As Exception
                                MessageBox.Show("ไฟล์ไม่ถูกต้อง กรุณาตรวจเชคไฟล์ Excel สำหรับนำเข้า", "ไฟล์ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End Try
                        Next
                    End With
                Next
                dtCurrent.AcceptChanges()
                gcList.DataSource = dtCurrent
            End If
        End With
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Cancel()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DS.Tables("vwqctarget").Rows.Count = gvList.RowCount - 1 Then Return
        For row As Integer = 0 To gvList.RowCount - 2
            Dim proID As String = gvList.GetRowCellValue(row, "ProductID").ToString
            Dim proName As String = gvList.GetRowCellValue(row, "ProductName").ToString
            If Not String.IsNullOrWhiteSpace(proID) AndAlso String.IsNullOrWhiteSpace(proName) Then Return
        Next


        If MessageBox.Show("ยืนยันการลบรายการบันทึกข้อมูล", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            SQL = "DELETE FROM tbQCTarget"
            dsTbl("delall")
            Dim FieldList As New List(Of String)
            For i As Integer = 0 To gvList.Columns.Count - 1
                FieldList.Add(gvList.Columns(i).FieldName)
            Next
            blkCpy("tbQCTarget", CType(gcList.DataSource, DataTable), FieldList.ToArray)
            Cancel()
        End If

    End Sub

#End Region
#Region "GridView Control"
    Private Sub gvList_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvList.CellValueChanging
        Dim V = CType(sender, GridView)
        If e.RowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
            Dim newID As Func(Of String) = Function()
                                               Dim result As Integer = 0
                                               'result = CInt(V.GetRowCellValue(V.RowCount - 1, "ProductID").ToString.Replace("P", ""))
                                               result = V.RowCount
                                               Return result.ToString("P#")
                                           End Function
            V.SetFocusedRowCellValue("ProductID", newID())
        End If
    End Sub
    Private Sub gvList_KeyDown(sender As Object, e As KeyEventArgs) Handles gvList.KeyDown
        Dim v As GridView = gvList
        If e.KeyCode = Keys.Delete Then
            If v.GetFocusedDataRow IsNot Nothing AndAlso v.GetFocusedDataRow.RowState = DataRowState.Added Then
                v.DeleteRow(v.FocusedRowHandle)
            End If
        End If
    End Sub
    Private Sub gvList_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvList.CustomDrawCell
        Dim v As GridView = gvList
        If e.RowHandle < 0 And e.RowHandle <> DevExpress.XtraGrid.GridControl.NewItemRowHandle Then Return
        If e.RowHandle <> DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
            If v.GetDataRow(e.RowHandle).RowState = DataRowState.Added Then
                e.Appearance.ForeColor = Color.Green
            ElseIf v.GetRowCellValue(e.RowHandle, e.Column.FieldName).ToString <> DS.Tables("vwqctarget")(v.GetDataSourceRowIndex(e.RowHandle))(e.Column.FieldName).ToString Then
                e.Appearance.ForeColor = Color.CornflowerBlue
            Else
                If AllowEdit = False Then e.Column.OptionsColumn.AllowEdit = False : Return
            End If
        End If
        If e.Column.FieldName <> "ProductID" Then e.Column.OptionsColumn.AllowEdit = True
    End Sub
    Private Sub gvList_Click(sender As Object, e As EventArgs) Handles gvList.Click
        CType(sender, GridView).ShowEditor()
    End Sub

    Private Sub gvList_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        FrmMain.bsiDebug.Caption = "Handle : " & e.RowHandle
    End Sub

#End Region
End Class

