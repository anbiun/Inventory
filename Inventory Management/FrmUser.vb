Option Explicit On
Option Strict On
Imports ConDB.Main
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Public Class FmgUser
    Private GridSelect As GridView
    Private AllowEdit As Boolean = False
    Private dtUser As DataTable
    Private dtLoc As DataTable
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub loadDef()
        'set caption
        gvUser.OptionsView.ShowAutoFilterRow = True

        SQL = "SELECT *,'' ID FROM tbLogin"
        dsTbl("Login")
        SQL = "SELECT *,'' ID FROM tbLocation LC
                INNER JOIN tbLocation_Permis PM ON LC.LocID = PM.LocID_Src"
        dsTbl("Permis")
        genID()

        'Preparing data for Assing
        dtUser = DS.Tables("Login").Copy
        dtLoc = DS.Tables("Permis").Copy
        'genID for dtUser
        For Each rw As DataRow In dtUser.Rows
            Dim newID As Func(Of String) = Function()
                                               Dim result As String = String.Empty
                                               Do Until result <> "" AndAlso FoundRow.Count = 0
                                                   result = CType(genID(), String)
                                                   FoundRow = dtUser.Select("ID LIKE '%" & result & "'")
                                               Loop
                                               Return result
                                           End Function
            rw("id") = newID()
        Next
        'Assign ID from dtUser
        For Each rw As DataRow In dtLoc.Rows
            FoundRow = dtUser.Select("UserID='" & rw("UserID").ToString & "'")
            If FoundRow.Count > 0 Then
                rw("ID") = FoundRow(0)("ID")
            End If
        Next


        'Assign Datasource
        gcUser.DataSource = dtUser
        gcLoc.DataSource = dtLoc
    End Sub
    Private Sub Frmuser_Load(sender As Object, e As EventArgs) Handles Me.Load
        TopMost = False
        loadDef()
    End Sub
    Private Sub WinUIPanel_ButtonClick(sender As Object, e As ButtonEventArgs) Handles WinUIPanel.ButtonClick
        Dim btn As WindowsUIButton = CType(e.Button, WindowsUIButton)
        Select Case btn.Tag.ToString
            Case "btnNew"
                gvUser.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
                gvUser.TopRowIndex = gvUser.RowCount
                gvUser.FocusedRowHandle = GridControl.NewItemRowHandle
                gvUser.FocusedColumn = gvUser.VisibleColumns(1)

                gvLoc.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
                gvLoc.TopRowIndex = gvLoc.RowCount
                gvLoc.FocusedRowHandle = GridControl.NewItemRowHandle
                gvLoc.FocusedColumn = gvLoc.VisibleColumns(1)
            Case "btnDel"
                If GridSelect.Equals(gvUser) Then
                    Dim keys(0) As DataColumn
                    keys(0) = dtLoc.Columns("ID")
                    keys(1) = dtLoc.Columns("LocID")

                    dtLoc.Rows.Find(keys).Delete()
                Else

                    dtLoc.Rows(gvLoc.GetFocusedDataSourceRowIndex).Delete()
                End If
                AllowEdit = True
            Case "btnEdit"
                'pnlMenu.Enabled = True
                'pnlSave.Enabled = False
                'FirstQry()
                'gcList.DataSource = dtQCTarget
                gvUser.OptionsView.NewItemRowPosition = NewItemRowPosition.None
                AllowEdit = False
            Case "btnCancel"
                loadDef()
            Case "btnSave"
        End Select
    End Sub
#Region "GridView Control"
    Private Sub gvList_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvUser.CellValueChanging
        'If e.RowHandle = GridControl.NewItemRowHandle Then
        '    gvLoc.SetRowCellValue(GridControl.NewItemRowHandle, "UserID", e.Value.ToString)
        'End If
    End Sub
    Private Sub gvList_KeyDown(sender As Object, e As KeyEventArgs) Handles gvUser.KeyDown
        Dim v As GridView = gvUser
        If e.KeyCode = Keys.Delete Then
            If v.GetFocusedDataRow IsNot Nothing AndAlso v.GetFocusedDataRow.RowState = DataRowState.Added Then
                v.DeleteRow(v.FocusedRowHandle)
            End If
        End If
    End Sub
    Private Sub gvList_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvUser.CustomDrawCell
        Dim v As GridView = gvUser
        If e.RowHandle < 0 And e.RowHandle <> DevExpress.XtraGrid.GridControl.NewItemRowHandle Then Return
        Return
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
    Private Sub gvList_Click(sender As Object, e As EventArgs) Handles gvUser.Click
        CType(sender, GridView).ShowEditor()
    End Sub
    Private Sub gvList_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvUser.RowCellClick, gvLoc.RowCellClick
        GridSelect = CType(sender, GridView)
        If GridSelect.Equals(gvUser) Then
            Dim filterView As New DataView(dtLoc)
            filterView.RowFilter = "ID = '" & GridSelect.GetFocusedRowCellDisplayText("ID") & "'"
            filterView.Sort = "ID"
            gcLoc.DataSource = filterView
        End If
    End Sub

    Private Sub gvLoc_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvLoc.CellValueChanged, gvUser.CellValueChanged
        If GridSelect.Equals(gvLoc) Then
            If String.IsNullOrEmpty(GridSelect.GetFocusedRowCellDisplayText("UserID")) Then
                Dim UID As String = CStr(gvUser.GetFocusedRowCellValue("UserID"))
                Dim ID As String = CStr(gvUser.GetFocusedRowCellValue("ID"))
                If String.IsNullOrEmpty(UID) Then Return
                gvLoc.SetFocusedRowCellValue("UserID", UID)
                gvLoc.SetFocusedRowCellValue("ID", ID)

                Dim filterView As New DataView(dtLoc)
                filterView.RowFilter = "UserID = '" & GridSelect.GetFocusedRowCellDisplayText("UserID") & "'"
                filterView.Sort = "UserID"
                gcLoc.DataSource = filterView
            End If
        ElseIf GridSelect.Equals(gvUser) Then
            If e.Column.FieldName = "UserID" AndAlso Not String.IsNullOrEmpty(e.Value.ToString) Then
                FoundRow = dtLoc.Select("ID='" & GridSelect.GetFocusedRowCellDisplayText("ID") & "'")
                For Each rw As DataRow In FoundRow
                    rw("UserID") = e.Value.ToString
                Next
            End If
        End If
    End Sub

#End Region

End Class