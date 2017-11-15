Imports ConDB.Main
Public Class FrmLogs_Tag
    Dim LogsInfo As New Logs
    Private Sub FrmLogs_Tag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogsInfo.Qry("SELECT SubCatName, CatID+SubCatID as catvalue FROM tbSubCategory")
        With slSubCat.Properties
            .DataSource = LogsInfo.DataSource
            .DisplayMember = "SubCatName"
            .ValueMember = "catvalue"
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SQL = "SELECT * from vwLogs_Tag "
        SQL &= "WHERE CatID+SubcatID ='" & slSubCat.EditValue & "'"
        LogsInfo.Qry(SQL)
        gcMain.DataSource = LogsInfo.DataSource
    End Sub

End Class

Public Class Logs
    Public DataSource As DataTable
    Sub Qry(SQLString As String)
        SQL = SQLString
        DataSource = dsTbl("logstag")
    End Sub
End Class