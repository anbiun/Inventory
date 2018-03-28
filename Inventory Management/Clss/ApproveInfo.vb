Option Explicit On
Option Strict On
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Public Class ApproveInfo
    Public FAccept$ = "รับของ",
        FStat$ = "Stat",
        FReject$ = "ตีกลับ",
        FNote$ = "Notation",
        FUnit1$ = "Unit1_Num",
        FUnit3$ = "Unit3_Num"
    Public StatVal As Integer = 0
    Dim OldStat As Integer = 0
    Public EnableEditCol As New List(Of String)
    Public DataSource As New DataTable
    Private DBUnit1, DBUnit3 As Double
    Public Editing As Boolean = True
    Private Enum Stat
        Transfer = 0
        Accept = 1
        Reject = 2
        Note = 3
    End Enum
    Friend Sub CreateCheckCol(ByVal GridControl As DevExpress.XtraGrid.GridControl, ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim buttonDelete As RepositoryItemButtonEdit
        buttonDelete = New RepositoryItemButtonEdit
        buttonDelete.TextEditStyle = TextEditStyles.HideTextEditor

        'AddHandler buttonDelete.ButtonPressed, AddressOf RepositoryItemButtonEdit_Pressed

        Dim EdtrBtn As EditorButton
        EdtrBtn = New EditorButton()
        EdtrBtn.Kind = ButtonPredefines.Glyph
        EdtrBtn.Image = CType(My.Resources.apply_16x16, System.Drawing.Image)
        'lObj_EdtrBtn.Image = CType(My.Resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        EdtrBtn.Appearance.BackColor = Color.Azure
        EdtrBtn.Caption = "Accept"
        EdtrBtn.ToolTip = FAccept
        EdtrBtn.Appearance.Options.UseTextOptions = True

        buttonDelete.Buttons.Clear()
        buttonDelete.Buttons.Add(EdtrBtn)
        buttonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        GridControl.RepositoryItems.Add(buttonDelete)

        Dim col As GridColumn
        col = New GridColumn
        col = GridView.Columns.AddVisible(FAccept, "")
        col.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        col.ColumnEdit = buttonDelete
        col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways

        buttonDelete = New RepositoryItemButtonEdit

        buttonDelete.TextEditStyle = TextEditStyles.HideTextEditor

        'AddHandler buttonDelete.ButtonPressed, AddressOf RepositoryItemButtonEdit_Pressed

        EdtrBtn = New EditorButton()
        EdtrBtn.Kind = ButtonPredefines.Glyph
        EdtrBtn.Image = CType(My.Resources.delete_16x16, System.Drawing.Image)
        'lObj_EdtrBtn.Image = CType(My.Resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        EdtrBtn.Appearance.BackColor = Color.Azure
        EdtrBtn.Caption = "Reject"
        EdtrBtn.ToolTip = FReject
        EdtrBtn.Appearance.Options.UseTextOptions = True

        buttonDelete.Buttons.Clear()

        buttonDelete.Buttons.Add(EdtrBtn)

        buttonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

        GridControl.RepositoryItems.Add(buttonDelete)

        col = New GridColumn
        col = GridView.Columns.AddVisible(FReject, "")
        col.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        col.ColumnEdit = buttonDelete
        col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    End Sub
    Friend Sub CellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs)
        Dim view As GridView = CType(sender, GridView)
        If view.FocusedColumn.FieldName = FAccept Then
            StatVal = Stat.Accept
            view.SetRowCellValue(e.RowHandle, FStat, StatVal)
            view.SetRowCellValue(e.RowHandle, FNote, String.Empty)
        ElseIf view.FocusedColumn.FieldName = FReject Then
            StatVal = Stat.Reject
            view.SetRowCellValue(e.RowHandle, FStat, StatVal)
            view.SetRowCellValue(e.RowHandle, FNote, String.Empty)
        End If
        If view.FocusedColumn.FieldName = FAccept Or view.FocusedColumn.FieldName = FReject Then
            view.SetRowCellValue(e.RowHandle, FUnit1, DataSource(view.GetDataSourceRowIndex(e.RowHandle))(FUnit1))
            view.SetRowCellValue(e.RowHandle, FUnit3, DataSource(view.GetDataSourceRowIndex(e.RowHandle))(FUnit3))
        End If

        view.RefreshData()
    End Sub
    Friend Sub CellChange(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        Dim view As GridView = CType(sender, GridView)
        If view Is Nothing Then
            Return
        End If
        If Not EnableEditCol.Contains(e.Column.FieldName) Then
            Return
        End If
        DBUnit1 = CDbl(DataSource(view.GetDataSourceRowIndex(e.RowHandle))(FUnit1))
        DBUnit3 = CDbl(DataSource(view.GetDataSourceRowIndex(e.RowHandle))(FUnit3))
        If e.Column.FieldName = FUnit1 Or e.Column.FieldName = FUnit3 Then
            If CDbl(view.GetRowCellValue(e.RowHandle, FUnit1)) <> DBUnit1 Or
                    CDbl(view.GetRowCellValue(e.RowHandle, FUnit3)) <> DBUnit3 Then
                view.SetRowCellValue(e.RowHandle, view.Columns(FStat), Stat.Note)
            Else
                view.SetRowCellValue(e.RowHandle, view.Columns(FStat), StatVal)
            End If
            Return
        End If

        If Not IsDBNull(view.GetRowCellValue(e.RowHandle, FNote)) AndAlso String.IsNullOrWhiteSpace(CType(view.GetRowCellValue(e.RowHandle, FNote), String)) Then
            If StatVal = Stat.Transfer Then
                Editing = True
                view.SetRowCellValue(e.RowHandle, FUnit1, DBUnit1)
                view.SetRowCellValue(e.RowHandle, FUnit3, DBUnit3)
                Editing = False
            End If
            view.SetRowCellValue(e.RowHandle, view.Columns(FStat), StatVal)
        Else
            view.SetRowCellValue(e.RowHandle, view.Columns(FStat), Stat.Note)
        End If
    End Sub
    Friend Sub RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Dim View As GridView = CType(sender, GridView)
        If (e.RowHandle >= Stat.Transfer) Then
            Dim ApproveStat As Integer = CInt(If(IsDBNull(View.GetRowCellValue(e.RowHandle, FStat)), Stat.Transfer, View.GetRowCellValue(e.RowHandle, FStat)))
            If ApproveStat = Stat.Accept Then
                e.Appearance.BackColor = Color.White
                e.Appearance.BackColor2 = ColorInfo.SoftGreen
            ElseIf ApproveStat = Stat.Note Then
                e.Appearance.BackColor = Color.White
                e.Appearance.BackColor2 = ColorInfo.SoftYellow
            ElseIf ApproveStat = Stat.Reject Then
                e.Appearance.BackColor = Color.White
                e.Appearance.BackColor2 = ColorInfo.SoftRed
            End If
        End If
    End Sub
End Class
