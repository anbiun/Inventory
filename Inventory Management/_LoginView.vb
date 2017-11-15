Public Class _LoginView
    Private Sub _LoginView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Binding.GetData = "select * from tbLogin"
        Binding.Name = "login"
        GridControl1.DataSource = Binding.Result

    End Sub
End Class