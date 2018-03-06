Option Explicit On
Option Strict On
Imports DevExpress.XtraGrid.Views.Grid

Public Class GridCaption
    Public HIDE As New selectColum
    Public ONLY As New selectColum
    Public SHOW As New selectColum
    Public Sub SetCaption(GridViewName As GridView)
        If ONLY.getColum.Count > 0 Then
            For Each colum As DevExpress.XtraGrid.Columns.GridColumn In GridViewName.Columns
                If ONLY.getColum.Contains(colum.FieldName, StringComparer.OrdinalIgnoreCase) _
                    Or ONLY.getColum.Contains(colum.Caption, StringComparer.OrdinalIgnoreCase) Then
                    colum.Caption = getString(colum.FieldName)
                    colum.Visible = True
                Else
                    colum.Visible = False
                End If
            Next
            Exit Sub
        End If

        'def
        For Each colum As DevExpress.XtraGrid.Columns.GridColumn In GridViewName.Columns
            colum.Caption = getString(colum.FieldName)
            colum.Visible = True
        Next
        'end def
        If HIDE.getColum.Count > 0 Then
            For Each colum As DevExpress.XtraGrid.Columns.GridColumn In GridViewName.Columns
                If HIDE.getColum.Contains(colum.FieldName, StringComparer.OrdinalIgnoreCase) _
                    Or HIDE.getColum.Contains(colum.Caption, StringComparer.OrdinalIgnoreCase) Then
                    colum.Visible = False
                End If
            Next
        End If
        If SHOW.getColum.Count > 0 Then
            For Each colum As DevExpress.XtraGrid.Columns.GridColumn In GridViewName.Columns
                If SHOW.getColum.Contains(colum.FieldName, StringComparer.OrdinalIgnoreCase) _
                    Or SHOW.getColum.Contains(colum.Caption, StringComparer.OrdinalIgnoreCase) Then
                    colum.Visible = True
                End If
            Next
        End If
        With GridViewName.Appearance
            'Dim newFont As New Font("Tahoma", 10, FontStyle.Regular)
            '.Row.Font = newFont
            '.GroupRow.Font = newFont

            .GroupRow.ForeColor = ColorTranslator.FromHtml("#0072C6")
            '.GroupRow.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
            '.GroupRow.BackColor = ColorTranslator.FromHtml("#F2F2F2")
            .GroupRow.BackColor = ColorTranslator.FromHtml("#F0F0F0")
        End With
    End Sub
    Public Class selectColum
        Private _enable As Boolean = False
        Protected StringKey As New List(Of String)
        Public ReadOnly Property getColum As List(Of String)
            Get
                Return StringKey
            End Get
        End Property
        Public Sub Columns(Keys As String)
            StringKey.Add(Keys)
        End Sub
    End Class

End Class
