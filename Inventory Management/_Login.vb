Imports System.Data.SqlClient
Imports ConDB.Main
Public Class _Login
    Private Sub _Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Binding.Name = "login"
        Binding.GetData = "select * from tblogin"
        GridControl1.DataSource = Binding.Result
        'GetData("select * from tbLogin")

        'Me.DGShow.DataSource = Me.bindingSource1
        'GetData("Select Name  , NameMachine as 'Computer Name', MacAddress as 'Mac Address' From TblMacAddress order by Name")

        'GetData(Me.dataAdapter.SelectCommand.CommandText)
    End Sub

    Private Sub sGetData(ByVal selectCommand As String)
        ''' Specify a connection string. Replace the given value with a 
        ''' valid connection string for a Northwind SQL Server sample
        ''' database accessible to your system.
        ''Dim connectionString As String = _
        ''    "Integrated Security=SSPI;Persist Security Info=False;" + _
        ''    "Initial Catalog=Northwind;Data Source=localhost"

        '' Create a new data adapter based on the specified query.
        'Me.dataAdapter = New SqlDataAdapter(selectCommand, Cls_Connect.ConnStr)

        '' Create a command builder to generate SQL update, insert, and
        '' delete commands based on selectCommand. These are used to
        '' update the database.
        'Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)

        '' Populate a new data table and bind it to the BindingSource.
        'Dim table As New DataTable()
        'table.Locale = System.Globalization.CultureInfo.InvariantCulture
        'Me.dataAdapter.Fill(table)
        'Me.bindingSource1.DataSource = table

    End Sub
    Private _UserID As Integer = 1
    Property UserID
        Get
            _UserID += 1
            Return _UserID.ToString("0000")
        End Get
        Set(value)
            _UserID = value
        End Set
    End Property
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SQL = "insert into tbLogin (UserID,UserName,UserPwd,Permis) values 
('" & UserID & "','" & txtUser.Text & "','" & txtPass.Text & "','5')"
        Binding.SQL = SQL
        Binding.Result()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SQL = "delete from tbLogin where UserName='" & txtUser.Text & "'"
        Binding.SQL = SQL
        Binding.Result()
    End Sub
End Class