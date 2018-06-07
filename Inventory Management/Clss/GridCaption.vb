Option Explicit On
Option Strict On
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class GridCaption
    Public HIDE As New SelectColum
    Public ONLY As New SelectColum
    Public SHOW As New SelectColum
    Private GridViewName As GridView
    Sub New(Gridview As GridView)
        GridViewName = Gridview
    End Sub
    Public Sub SetCaption()
        If GridViewName Is Nothing Then MsgBox("Function GridCaption set gridview first") : Return
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
    Public Sub SetFormat(ColumnsList As String(), Optional FormatType As FormatType = FormatType.Numeric, Optional FormatString As String = "")

        For Each items As String In ColumnsList
            GridViewName.Columns(items).DisplayFormat.FormatType = FormatType
            GridViewName.Columns(items).DisplayFormat.FormatString = If(String.IsNullOrEmpty(FormatString), "{0:n1}", FormatString)
        Next

    End Sub

End Class

'Code สำหรับ GridView หน้า Stock
Namespace GridStyle
    Public Class MasterGrid
        Inherits DetailGrid
        Sub New(val As GridView)
            MyBase.New(val)
            AddHandler Grid.CustomDrawCell, AddressOf CustomDrawCell
            'AddHandler Grid.RowStyle, AddressOf mybase.RowStyle
        End Sub
        Public Overloads Sub SetFormat()
            If Grid.RowCount <= 0 Then Return
            gridInfo = New GridCaption(Grid)
            With gridInfo
                .HIDE.Columns("QCWarn")
                .HIDE.Columns("matid")
                .HIDE.Columns("AllowColor")
                .HIDE.Columns("RelaID")
                .HIDE.Columns("Minimum")
                .HIDE.Columns("SubMatName")
                .SetCaption()
                Dim ColList As String() = {"Unit1", "Unit3", "Dozen", "Warn"}
                .SetFormat(ColList)
                For i As Integer = 1 To 12
                    .SetFormat({MonthName(i)}, FormatType.Numeric, "{0:n0}")
                Next
            End With
            With Grid
                .Columns("SubCatName").Group()
                .ExpandAllGroups()
                .OptionsBehavior.AllowPartialGroups = DefaultBoolean.True
                .Columns("SubCatName").Fixed = Columns.FixedStyle.Left
                .Columns("ProductName").Fixed = Columns.FixedStyle.Left
                .Columns("Warn").Fixed = Columns.FixedStyle.Left
                .Columns("Warn_Name").Fixed = Columns.FixedStyle.Left
                .Columns("PoStat").Fixed = Columns.FixedStyle.Left
                .BestFitColumns()
                .OptionsView.ShowAutoFilterRow = True
            End With
        End Sub
        Protected Overloads Sub CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs)
            If e.RowHandle = GridControl.NewItemRowHandle Or e.RowHandle = GridControl.AutoFilterRowHandle Then Return
            Dim gcix As ViewInfo.GridCellInfo = TryCast(e.Cell, ViewInfo.GridCellInfo)
            Dim infox As ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, ViewInfo.TextEditViewInfo)

            Dim v As GridView = TryCast(sender, GridView)
            If e.Column.VisibleIndex = 0 AndAlso v.IsMasterRowEmpty(e.RowHandle) Then
                Dim Info As GridCellInfo = CType(e.Cell, GridCellInfo)
                If Info.CellButtonRect <> Rectangle.Empty Then
                    Info.CellValueRect.X = TryCast(e.Cell, GridCellInfo).CellButtonRect.X
                    Info.CellValueRect.Width += TryCast(e.Cell, GridCellInfo).CellButtonRect.Width
                    Info.CellButtonRect = Rectangle.Empty
                    e = New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs(e.Cache, Info.CellValueRect, e.Appearance, e.RowHandle, e.Column, e.CellValue, e.DisplayText)
                End If


            End If
        End Sub
    End Class

    Public Class DetailGrid
        Sub New(val As GridView)
            If val Is Nothing Then Return
            Grid = val
            AddHandler val.CustomDrawCell, AddressOf CustomDrawCell
            AddHandler val.RowStyle, AddressOf RowStyle
        End Sub
        Protected Grid As GridView
        Public Sub SetFormat()
            If Grid.RowCount <= 0 Then Return
            gridInfo = New GridCaption(Grid)
            With gridInfo
                .HIDE.Columns("QCWarn")
                .HIDE.Columns("matid")
                .HIDE.Columns("AllowColor")
                .HIDE.Columns("RelaID")
                .HIDE.Columns("Minimum")
                .HIDE.Columns("SubCatName")
                .HIDE.Columns("SubMatName")
                .HIDE.Columns("ProductID")
                .HIDE.Columns("ProductName")
                .SetCaption()
                Dim ColList As String() = {"Unit1", "Unit3", "Dozen", "Warn"}
                .SetFormat(ColList)
                For i As Integer = 1 To 12
                    .SetFormat({MonthName(i)}, FormatType.Numeric, "{0:n0}")
                Next
            End With
            With Grid
                .Columns("MatName").Fixed = Columns.FixedStyle.Left
                .Columns("Warn").Fixed = Columns.FixedStyle.Left
                .Columns("Warn_Name").Fixed = Columns.FixedStyle.Left
                .Columns("PoStat").Fixed = Columns.FixedStyle.Left
                .BestFitColumns()
                .OptionsView.ShowAutoFilterRow = True
            End With

        End Sub
        Protected Sub CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            If e.RowHandle = GridControl.NewItemRowHandle Or e.RowHandle = GridControl.AutoFilterRowHandle Then Return
            If e.CellValue Is Nothing Then Return
            Dim gcix As ViewInfo.GridCellInfo = TryCast(e.Cell, ViewInfo.GridCellInfo)
            Dim infox As ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, ViewInfo.TextEditViewInfo)

            If e.Column.FieldName = "PoStat" Then
                e.DisplayText = String.Empty
                If CType(sender, GridView).GetRowCellValue(e.RowHandle, "AllowColor").ToString = "0" Then
                    infox.ContextImage = My.Resources.opportunities_16x16
                ElseIf e.CellValue.ToString = "1" Then
                    infox.ContextImage = Nothing
                ElseIf e.CellValue.ToString = "2" Then
                    infox.ContextImage = My.Resources.postat2_16x16
                ElseIf e.CellValue.ToString = "0" Then
                    infox.ContextImage = My.Resources.sales_16x16
                End If
                infox.CalcViewInfo()
            End If
            If e.Column.FieldName = "qcnote" Then
                e.DisplayText = "เป้าQC"
                If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "qcnote" Then
                    infox.ContextImage = My.Resources.qcnote
                    infox.ContextImageAlignment = ContextImageAlignment.Far
                    infox.CalcViewInfo()
                End If
            End If
        End Sub

        Protected Sub RowStyle(ByVal sender As Object, ByVal e As RowStyleEventArgs)
            Dim View As GridView = TryCast(sender, GridView)
            If View.GetRowCellValue(e.RowHandle, "Warn") Is DBNull.Value Then Return
            Dim Warn As Double = CDbl(View.GetRowCellValue(e.RowHandle, "Warn"))
            Dim Minimum As Integer = CInt(View.GetRowCellValue(e.RowHandle, "Minimum"))
            Dim AllowColor As Integer = CInt(View.GetRowCellValue(e.RowHandle, "AllowColor"))
            If (e.RowHandle >= 0) Then
                If IsDBNull(Warn) Then
                    Warn = Nothing
                Else
                    Warn = If(IsDBNull(Warn), Nothing, CDbl(Warn))
                End If
                If IsDBNull(Minimum) Then
                    Minimum = 0
                End If

                If Warn <= 1 AndAlso AllowColor = 1 Then
                    e.Appearance.BackColor = ColorTranslator.FromHtml("#fc9797")
                    e.Appearance.BackColor2 = Color.WhiteSmoke
                ElseIf Warn <= Minimum AndAlso AllowColor = 1 Then
                    e.Appearance.BackColor = Color.LightGoldenrodYellow
                    e.Appearance.BackColor2 = Color.LightYellow
                Else
                    e.Appearance.BackColor = Nothing
                    e.Appearance.BackColor2 = Nothing
                End If
            End If
        End Sub
    End Class
End Namespace