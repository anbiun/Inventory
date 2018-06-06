Option Explicit On
Option Strict On
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
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
    Public Sub SetFormatNumber(ColumnsList As String(), Optional FormatString As String = "")

        For Each items As String In ColumnsList
            GridViewName.Columns(items).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        End Sub
        Public Overloads Sub SetFormat()
            If Grid.RowCount <= 0 Then Return
            gridInfo = New GridCaption(Grid)
            With gridInfo
                .HIDE.Columns("QCWarn")
                .HIDE.Columns("matid")
                .HIDE.Columns("AllowColor")
                .HIDE.Columns("Indexs")
                .HIDE.Columns("Minimum")
                .HIDE.Columns("SubMatName")
                .SetCaption()
                Dim ColList As String() = {"Unit1", "Unit3", "Dozen", "Warn"}
                .SetFormatNumber(ColList)
                For i As Integer = 1 To 12
                    .SetFormatNumber({MonthName(i)}, "{0:n0}")
                Next
            End With
            With Grid
                .Columns("SubCatName").Group()
                .ExpandAllGroups()
                .OptionsBehavior.AllowPartialGroups = DefaultBoolean.True
                .Columns("SubCatName").Fixed = Columns.FixedStyle.Left
                .Columns("ProductName").Fixed = Columns.FixedStyle.Left
                .Columns("Warn").Fixed = Columns.FixedStyle.Left
                .Columns("ReqToday").Fixed = Columns.FixedStyle.Left
                .BestFitColumns()
                .OptionsView.ShowAutoFilterRow = True
            End With
            TestCode()
        End Sub
        Private Sub TestCode()
            Return
            For Row As Integer = 0 To Grid.RowCount - 1
                Dim vInfo As ViewInfo.GridViewInfo = TryCast(Grid.GetViewInfo(), ViewInfo.GridViewInfo)
                Dim cInfo As ViewInfo.GridCellInfo = vInfo.GetGridCellInfo(Row, Grid.Columns(0))

                '-----Master Detail Remove [+] if onerow
                If cInfo Is Nothing Then Continue For
                Dim subView As DataView = CType(Grid.GetRow(Row), DataRowView).CreateChildView("Relation")
                Dim isMasterRow As Boolean = False

                If subView.Count = 1 Then
                    TryCast(cInfo, ViewInfo.GridCellInfo).CellButtonRect = Rectangle.Empty
                End If
            Next
        End Sub
        Protected Overloads Sub CustomDrawCell(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs)
            'Return
            If e.CellValue Is Nothing Or e.Column.VisibleIndex <> 0 Then Return
            Dim view As GridView = TryCast(sender, GridView)
            '-----Master Detail Remove [+] if onerow
            Dim subView As DataView = CType(Grid.GetRow(e.RowHandle), DataRowView).CreateChildView("Relation")

            If e.Column.VisibleIndex = 0 Then
                If subView.Count = 1 Then
                    TryCast(e.Cell, ViewInfo.GridCellInfo).CellButtonRect = Rectangle.Empty
                Else
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
                .HIDE.Columns("Indexs")
                .HIDE.Columns("Minimum")
                .HIDE.Columns("SubCatName")
                .HIDE.Columns("SubMatName")
                .HIDE.Columns("ProductID")
                .HIDE.Columns("ProductName")
                .SetCaption()
                Dim ColList As String() = {"Unit1", "Unit3", "Dozen", "Warn"}
                .SetFormatNumber(ColList)
                For i As Integer = 1 To 12
                    .SetFormatNumber({MonthName(i)}, "{0:n0}")
                Next
            End With
            With Grid
                .Columns("MatName").Fixed = Columns.FixedStyle.Left
                .Columns("Warn").Fixed = Columns.FixedStyle.Left
                .Columns("ReqToday").Fixed = Columns.FixedStyle.Left
                .BestFitColumns()
                .OptionsView.ShowAutoFilterRow = True
            End With

        End Sub
        Protected Sub CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            If e.CellValue Is Nothing Then Exit Sub
            Dim gcix As ViewInfo.GridCellInfo = TryCast(e.Cell, ViewInfo.GridCellInfo)
            Dim infox As ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, ViewInfo.TextEditViewInfo)

            If e.Column.FieldName = "ReqToday" Then
                e.DisplayText = String.Empty
                If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "ReqToday" Then
                    If CInt(TryCast(sender, GridView).GetRowCellValue(e.RowHandle, "AllowColor")) = 0 Then
                        infox.ContextImage = My.Resources.opportunities_16x16
                    ElseIf e.CellValue.ToString = "1" Then
                        infox.ContextImage = My.Resources.apply_16x16
                    ElseIf e.CellValue.ToString = "2" Then
                        infox.ContextImage = My.Resources.about_16x16
                    ElseIf e.CellValue.ToString = "0" Then
                        infox.ContextImage = Nothing
                    End If
                    infox.CalcViewInfo()
                End If
            End If

            If e.Column.FieldName = "qcnote" Then
                e.DisplayText = "เป้าQC"
                If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "qcnote" Then
                    infox.ContextImage = My.Resources.qcnote
                    infox.ContextImageAlignment = ContextImageAlignment.Far
                    infox.CalcViewInfo()
                End If
            End If
            If e.Column.FieldName = "Warn" Then
                e.DisplayText = e.CellValue.ToString & " เดือน"
            End If

        End Sub
        Protected Sub RowStyle(ByVal sender As Object, ByVal e As RowStyleEventArgs)
            Dim View As GridView = TryCast(sender, GridView)
            Dim Warn As Double = CDbl(View.GetRowCellValue(e.RowHandle, "Warn"))
            Dim Minimum As Integer = CInt(View.GetRowCellValue(e.RowHandle, "Minimum"))
            Dim AllowColor As Integer = CInt(View.GetRowCellValue(e.RowHandle, "AllowColor"))
            If (e.RowHandle >= 0) Then
                If IsDBNull(Warn) Then
                    Warn = 0
                Else
                    Warn = If(IsDBNull(Warn), 0, CDbl(Warn))
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

        'Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs, Optional RowHandle As Integer = -1) Handles gvAdjust.RowCellClick, gvMain.RowCellClick
        '    Dim GV As GridView = CType(sender, GridView)
        '    If GV.FocusedRowHandle < 0 Then Exit Sub
        '    With GV
        '        Dim getCellVal As Func(Of String, String) = Function(cells)
        '                                                        Return .GetRowCellValue(
        '                                                        If(RowHandle >= 0, RowHandle, e.RowHandle),
        '                                                        cells)
        '                                                    End Function
        '        Select Case .Name
        '            Case gvMain.Name
        '                Dim MatID As String = getCellVal("MatID")
        '                SQL = "SELECT * FROM vwAdjust"
        '                SQL &= " WHERE MatID = '" & MatID & "'"
        '                SQL &= " AND " & LocExpr(clbLoc.CheckedItems).Replace("OR", "OR MatID='" & MatID & "' AND")

        '                If clbLoc.CheckedItems.Count <= 0 Then Exit Sub
        '                gcAdjust.DataSource = dsTbl("AJStock")
        '                If gvAdjust.RowCount > 0 Then
        '                    gridInfo = New GridCaption(gvAdjust)
        '                    With gridInfo
        '                        .SetCaption()
        '                        .SetFormatNumber({"Unit1", "Unit3"})
        '                    End With
        '                    With gvAdjust
        '                        .Columns("MatName").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        '                        .BestFitColumns()
        '                    End With
        '                End If

        '            Case gvAdjust.Name
        '                Dim Unit1 As Double = getCellVal("Unit1")
        '                Dim Unit3 As Double = getCellVal("Unit3")
        '                Unit1 = Math.Round(Unit1, 2)
        '                Unit3 = Math.Round(Unit3, 2)
        '                lbMatName.Text = getCellVal("MatName")
        '                lbTagID.Text = getCellVal("TagID")
        '                lbRatio.Text = getCellVal("Ratio")
        '                lbQtyPerUnit.Text = getCellVal("QtyPerUnit")


        '                lbUnit1.Text = Unit1
        '                lbUnit3.Text = Unit3
        '                txtUnit1.EditValue = Unit1
        '                txtUnit2.EditValue = Unit3

        '                lbUnit1_Name.Text = getCellVal("Unit1_Name")
        '                lbUnit3_Name.Text = getCellVal("Unit3_Name")
        '                LocID = getCellVal("LocID")
        '        End Select
        '    End With
        'End Sub
    End Class
End Namespace