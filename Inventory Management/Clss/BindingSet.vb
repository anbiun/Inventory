Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.BaseCheckedListBoxControl

Public Class BindingSet
    Private BindingArray As New Dictionary(Of String, BindingSource)
    Private _BindingName As String
    Property Name
        Set(value)
            _BindingName = value
        End Set
        Get
            Return _BindingName
        End Get
    End Property
    Function Result() As BindingSource
        Return BindingArray(Name)
    End Function
    Sub Add(BindingName As String)
        BindingArray.Add(BindingName, New BindingSource)
    End Sub
    Sub Qry(sqlstring As String)
        Dim DTResult As New DataTable
        DA = New SqlDataAdapter(sqlstring, CONN)
        DA.Fill(DTResult)

        If Not BindingArray.ContainsKey(Name) Then
            BindingArray.Add(Name, New BindingSource)
        End If
        BindingArray(Name).DataSource = DTResult
    End Sub
    Function Find(BindingName As String) As Boolean
        If BindingArray.ContainsKey(BindingName) Then Return True
        Return False
    End Function
#Region "StockProcedure"
    Private _LocList As CheckedItemCollection
    Private _CatList As CheckedItemCollection
    Property LocCheked
        Set(value)
            _LocList = value
        End Set
        Get
            Return _LocList
        End Get
    End Property
    Property CatChecked
        Set(value)
            _CatList = value
        End Set
        Get
            Return _CatList
        End Get
    End Property
    Public Sub Excute()

        If _LocList.Count <= 0 Or
                _CatList.Count <= 0 Then
            Exit Sub
        End If

        Dim LocExpr As String = String.Empty
        Dim DTResult As New DataTable
        'เลือก Location
        Dim LocSelect As New List(Of String)
        For Each item As DataRowView In _LocList
            LocSelect.Add(item.Row(0))
        Next
        For Each item In LocSelect
            If item IsNot LocSelect.Last Then
                LocExpr += " LocID = '" + item + "' OR" + ""
            Else
                LocExpr += " LocID = '" + item + "'"
            End If
        Next

        'เลือกประเภท

        For Each item As DataRowView In _CatList
            If _CatList.Count = 1 Then
                ParamList.Clear()
                ParamList.Add(New SqlParameter("@CatExpr", item(0)))
                ParamList.Add(New SqlParameter("@LocExpr", LocExpr))
                DTResult = CallSP("GetStock", ParamList)
            Else
                ParamList.Clear()
                ParamList.Add(New SqlParameter("@CatExpr", item(0)))
                ParamList.Add(New SqlParameter("@LocExpr", LocExpr))
                If DTResult.Rows.Count = 0 Then
                    DTResult = CallSP("GetStock", ParamList)
                Else
                    For Each items As DataRow In CallSP("GetStock", ParamList).Rows
                        DTResult.ImportRow(items)
                    Next
                End If
            End If
        Next

        If Not BindingArray.ContainsKey(Name) Then
            BindingArray.Add(Name, New BindingSource)
        End If
        BindingArray(Name).DataSource = DTResult
    End Sub
#End Region
End Class


