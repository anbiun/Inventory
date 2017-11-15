Imports ConDB.Main
Imports System.Data.SqlClient

Public Class BindingSet
    Private _BindingName As String
    Private _SQLString As String
    Private _Select As String
    Private BindingArray As New Dictionary(Of String, BindingSource)
    Property Name
        Get
            Return _BindingName
        End Get
        Set(value)
            _BindingName = value
        End Set
    End Property
    Property SQL
        Get
            Return _SQLString
        End Get
        Set(value)
            _SQLString = value
        End Set
    End Property
    Property GetData
        Get
            Return _Select
        End Get
        Set(value)
            _Select = value
        End Set
    End Property
    ReadOnly Property GetStock
        Get
            Return BindingArray(Name)
        End Get
    End Property
    Private Sub Qry(SQLString)
        DA = New SqlDataAdapter(SQLString, CONN)
        Dim commandBuild As New SqlCommandBuilder(DA)
        Dim retTable As New DataTable
        DA.Fill(retTable)

        If BindingArray.ContainsKey(_BindingName) Then
            BindingArray(_BindingName).DataSource = retTable
        Else
            Dim retBinding As New BindingSource
            retBinding.DataSource = retTable
            BindingArray.Add(_BindingName, retBinding)
        End If
    End Sub
    Function Result() As BindingSource
        If _SQLString IsNot String.Empty AndAlso _SQLString IsNot Nothing Then
            Qry(_SQLString)
            Qry(_Select)
        Else
            Qry(_Select)
        End If
        _SQLString = String.Empty
        Return BindingArray(Name)
    End Function

    Sub Add(Table As DataTable)
        Dim retBinding As New BindingSource
        If BindingArray.ContainsKey(Name) Then
            BindingArray.Remove(Name)
        End If
        retBinding.DataSource = Table
        BindingArray.Add(Name, retBinding)
    End Sub
End Class

