Imports ConDB.Main
Public Class FrmLogs_Transfer
    Dim locExpr As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SQL = "SELECT * from vwLogs_Transfer "
        SQL &= locExpr
        gcMain.DataSource = dsTbl("logstransfer")
    End Sub
End Class