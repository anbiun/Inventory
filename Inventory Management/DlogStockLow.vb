Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Class dlgAlert
    Public Datasource As DataTable
    Private Sub DlogStockLow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcList.DataSource = Datasource
        With gridInfo
            .SetCaption(gvList)
        End With
    End Sub

    Public Sub GridViews(ByVal sender As Object, _
                                 ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle
        Dim View As GridView = sender
        'Dim lacking As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Lacking"))
        'If (e.RowHandle >= 0) Then
        '    lacking = If(String.IsNullOrWhiteSpace(lacking), 0, CDbl(lacking))
        '    If lacking >= 0 Then
        '        e.Appearance.BackColor = Color.IndianRed
        '        e.Appearance.BackColor2 = Color.OrangeRed
        '    End If
        'End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class
