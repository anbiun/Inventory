Option Strict On
Option Explicit On
Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.BaseCheckedListBoxControl

Public Class BindingSet
    Private BindingArray As New Dictionary(Of String, BindingSource)
    Dim QryBind As New Dictionary(Of String, String)
    Private _BindingName As String
    Property Name As String
        Set(value As String)
            _BindingName = value
        End Set
        Get
            Return _BindingName
        End Get
    End Property
    Function Result(Optional BindingName As String = "") As BindingSource
        Return BindingArray(If(String.IsNullOrEmpty(BindingName), Name, BindingName))
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
        If Not QryBind.ContainsKey(Name) Then
            QryBind.Add(Name, sqlstring)
        End If
    End Sub
    Sub Refresh()
        If QryBind.Keys.Contains(Name) Then
            Qry(QryBind(Name))
        End If
    End Sub
    Function Find(BindingName As String) As Boolean
        If BindingArray.ContainsKey(BindingName) Then Return True
        Return False
    End Function

#Region "StockProcedure"
    Private _LocList As CheckedItemCollection
    Private _CatList As CheckedItemCollection
    Property LocCheked As CheckedItemCollection
        Set(value As CheckedItemCollection)
            _LocList = value
        End Set
        Get
            Return _LocList
        End Get
    End Property
    Property CatChecked As CheckedItemCollection
        Set(value As CheckedItemCollection)
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

        'เลือก Location
        Dim LocSelect As New List(Of String)
        For Each item As DataRowView In _LocList
            LocSelect.Add(item.Row(0).ToString)
        Next
        For Each item In LocSelect
            If item IsNot LocSelect.Last Then
                LocExpr += " LocID = '" + item + "' OR" + ""
            Else
                LocExpr += " LocID = '" + item + "'"
            End If
        Next
        Dim SPList As New Dictionary(Of String, String)
        SPList.Add("Master", "StockMaster")
        SPList.Add("Detail", "StockDetail")

        For Each SPName As String In SPList.Keys
            Dim DTResult As New DataTable
            Name = SPName
            'เลือกประเภท
            For Each item As DataRowView In _CatList
                If _CatList.Count = 1 Then
                    ParamList.Clear()
                    ParamList.Add(New SqlParameter("@CatExpr", item(0)))
                    ParamList.Add(New SqlParameter("@LocExpr", LocExpr))
                    DTResult = CallSP(SPList(SPName), ParamList)
                Else
                    ParamList.Clear()
                    ParamList.Add(New SqlParameter("@CatExpr", item(0)))
                    ParamList.Add(New SqlParameter("@LocExpr", LocExpr))
                    If DTResult.Rows.Count = 0 Then
                        DTResult = CallSP(SPList(SPName), ParamList)
                    Else
                        For Each items As DataRow In CallSP(SPList(SPName), ParamList).Rows
                            DTResult.ImportRow(items)
                        Next
                    End If
                End If
            Next

            If Not BindingArray.ContainsKey(Name) Then
                BindingArray.Add(Name, New BindingSource)
            End If
            BindingArray(Name).DataSource = WarnCalculate(DTResult)
        Next
    End Sub
    Private Function WarnCalculate(inputTable As DataTable) As DataTable
        Dim tbResult As DataTable = inputTable.Copy
        Dim Dozen As Double = 0
        Dim ProductName As String
        'loop จำนวนแถว
        For Each rows As DataRow In tbResult.Rows
            ProductName = rows("ProductName").ToString
            Dozen = CDbl(rows("dozen").ToString)

            Dim Warn As Double = 0
            Dim monthVal As Integer = 0
            'loop จำนวนเดือนหาค่า QC แต่ละเดือน
            For mNumber As Integer = Now.Month To 12
                monthVal = CInt(If(IsDBNull(rows(MonthName(mNumber))), 0, rows(MonthName(mNumber))))
                If Dozen >= 1 And monthVal > 0 And mNumber < 12 Then
                    'ถ้าจำนวนโหลมากกว่า จำนวน QC เดือนนั้นๆ และไม่ใช่เดือน ธค.
                    'จำนวนโหล - เป้าเดือนนั้นๆ และนับเดือนเพิ่มเรื่อยๆ เมือ่ไม่พอจึงหารค่าสุดท้ายเพื่อเอาทศนิยม
                    If Dozen > monthVal Then
                        Warn += 1
                        Dozen -= monthVal
                    Else
                        Dozen /= monthVal
                        Warn += Math.Round(Dozen, 1)
                    End If
                ElseIf Dozen >= 1 And mNumber = 12 Then
                    'ถ้าเป็นเดือน ธค. และจำนวนโหลยังเหลือ ให้นำไปหารค่า QC เดือนล่าสุดจนหมด
                    monthVal = 0
                    Do Until monthVal > 0 Or mNumber < 1
                        monthVal = CInt(If(IsDBNull(rows(MonthName(mNumber))), 0, rows(MonthName(mNumber))))
                        mNumber -= 1
                    Loop
                    If monthVal = 0 And mNumber = 0 Then
                        rows("Allowcolor") = 0
                        Warn = 0
                    Else
                        Dozen /= monthVal
                        Warn += Math.Round(Dozen, 1)
                    End If

                    Exit For
                End If
            Next
            If Warn = 0 AndAlso monthVal = 0 Then
                rows("Warn") = DBNull.Value
            Else
                rows("Warn") = Warn
            End If
        Next
        Return tbResult
    End Function
#End Region
End Class
