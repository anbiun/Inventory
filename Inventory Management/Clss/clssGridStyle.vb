Imports DevExpress.XtraGrid.Views.Grid

Public Class clssGridStyle

    Public lacking As String
    Public Sub GVRowStyle(ByVal sender As Object, _
                                  ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs _
                                  )
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            lacking = If(String.IsNullOrWhiteSpace(lacking), 0, CDbl(lacking))
            If lacking >= 0 Then
                e.Appearance.BackColor = Color.IndianRed
                e.Appearance.BackColor2 = Color.OrangeRed
            End If
        End If
    End Sub

End Class
