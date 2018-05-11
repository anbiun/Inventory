Option Explicit On
Option Strict On
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Class GridCaption
    Public HIDE As New SelectColum
    Public ONLY As New SelectColum
    Public SHOW As New SelectColum
    Private GridViewName As GridView
    Sub New(Gridview As GridView)
        GridViewName = Gridview
    End Sub
    Public Sub SetCaption()
        If GridViewName Is Nothing Then MsgBox("set gridview first") : Exit Sub

        If ONLY.GetColum.Count > 0 Then
            For Each colum As DevExpress.XtraGrid.Columns.GridColumn In GridViewName.Columns
                If ONLY.GetColum.Contains(colum.FieldName, StringComparer.OrdinalIgnoreCase) _
                    Or ONLY.GetColum.Contains(colum.Caption, StringComparer.OrdinalIgnoreCase) Then
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
        If HIDE.GetColum.Count > 0 Then
            For Each colum As DevExpress.XtraGrid.Columns.GridColumn In GridViewName.Columns
                If HIDE.GetColum.Contains(colum.FieldName, StringComparer.OrdinalIgnoreCase) _
                    Or HIDE.GetColum.Contains(colum.Caption, StringComparer.OrdinalIgnoreCase) Then
                    colum.Visible = False
                End If
            Next
        End If
        If SHOW.GetColum.Count > 0 Then
            For Each colum As DevExpress.XtraGrid.Columns.GridColumn In GridViewName.Columns
                If SHOW.GetColum.Contains(colum.FieldName, StringComparer.OrdinalIgnoreCase) _
                    Or SHOW.GetColum.Contains(colum.Caption, StringComparer.OrdinalIgnoreCase) Then
                    colum.Visible = True
                End If
            Next
        End If
        With GridViewName.Appearance
            .Row.BackColor = Color.GhostWhite
            .GroupRow.ForeColor = ColorTranslator.FromHtml("#0072C6")
            .GroupRow.BackColor = ColorTranslator.FromHtml("#f0f0f0")
            GridViewName.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
        End With
    End Sub
    Public Class SelectColum
        Private _enable As Boolean = False
        Protected StringKey As New List(Of String)
        Public ReadOnly Property GetColum As List(Of String)
            Get
                Return StringKey
            End Get
        End Property
        Public Sub Columns(Keys As String)
            StringKey.Add(Keys)
        End Sub
    End Class
    Public Sub SetFormat(ColumnsList As String(),
                         Optional Format As FormatType = Nothing,
                         Optional FormatString As String = "")

        For Each items As String In ColumnsList
            GridViewName.Columns(items).DisplayFormat.FormatType = If(Format = Nothing, FormatType.Numeric, Format)
            GridViewName.Columns(items).DisplayFormat.FormatString = If(String.IsNullOrEmpty(FormatString), "{0:n1}", FormatString)
        Next

    End Sub

End Class
