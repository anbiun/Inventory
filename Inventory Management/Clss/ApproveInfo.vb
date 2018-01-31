Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Public Class ApproveInfo
    Public FAccept,
        FStat,
        FNotFound,
        FNote As String
    Dim StatVal As Integer = 0
    Dim OldStat As Integer = 0
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
        EdtrBtn.ToolTip = "ถูกต้อง"
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
        EdtrBtn.Caption = "NotFond"
        EdtrBtn.ToolTip = "ไม่เจอรายการนี้"
        EdtrBtn.Appearance.Options.UseTextOptions = True

        buttonDelete.Buttons.Clear()

        buttonDelete.Buttons.Add(EdtrBtn)

        buttonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor

        GridControl.RepositoryItems.Add(buttonDelete)

        col = New GridColumn
        col = GridView.Columns.AddVisible(FNotFound, "")
        col.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        col.ColumnEdit = buttonDelete
        col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
    End Sub
    Friend Sub CellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs)
        Dim view As GridView = sender
        If view.FocusedColumn.FieldName = FAccept Then
            StatVal = 1
            view.SetRowCellValue(e.RowHandle, FStat, StatVal)
            view.SetRowCellValue(e.RowHandle, FNote, String.Empty)
        ElseIf view.FocusedColumn.FieldName = FNotFound Then
            StatVal = 0
            view.SetRowCellValue(e.RowHandle, FStat, StatVal)
            view.SetRowCellValue(e.RowHandle, FNote, String.Empty)
        End If
        view.RefreshData()
    End Sub
    Friend Sub CellChange(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        Dim view As GridView = sender
        If view Is Nothing Then
            Return
        End If
        If e.Column.FieldName <> FNote Then
            Return
        End If
        If String.IsNullOrWhiteSpace(view.GetRowCellValue(e.RowHandle, FNote)) Then
            view.SetRowCellValue(e.RowHandle, view.Columns(FStat), StatVal)
        Else
            view.SetRowCellValue(e.RowHandle, view.Columns(FStat), 2)
        End If
    End Sub
    Friend Sub RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim ApproveStat As Integer = If(IsDBNull(View.GetRowCellValue(e.RowHandle, FStat)), 0, View.GetRowCellValue(e.RowHandle, "ApproveStat"))
            If ApproveStat = 1 Then
                e.Appearance.BackColor = Color.Green
                e.Appearance.BackColor2 = Color.LightGreen
            ElseIf ApproveStat = 2 Then
                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.LightYellow
            ElseIf ApproveStat = 0 Then
                e.Appearance.BackColor = Color.IndianRed
                e.Appearance.BackColor2 = Color.OrangeRed
            End If
        End If
    End Sub
End Class
