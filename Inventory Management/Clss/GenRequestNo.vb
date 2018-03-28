Option Explicit On
Option Strict On
Imports ConDB.Main
Public Class GenRequestNo
    Private _date As String
    Private _pattern As String = "000000-00"
    Private _table As String = "tbRequisition"
    Private _field As String = "RequestNo"
    WriteOnly Property SetDate As String
        Set(value As String)
            _date = value
        End Set
    End Property
    WriteOnly Property SetPattern As String
        Set(value As String)
            _pattern = value
        End Set
    End Property
    WriteOnly Property SetTable As String
        Set(value As String)
            _table = value
        End Set
    End Property
    WriteOnly Property SetField As String
        Set(value As String)
            _field = value
        End Set
    End Property

    Public Function Gen() As String
        Dim Reqno As String = _date
        If _date IsNot Nothing Then
            Reqno = CDate(Reqno).ToString("yyMMdd")
        Else
            Reqno = Today.ToString("yyMMdd")
        End If
        SQL = "select Top 1 " & _field & " from " & _table
        SQL &= " where " & _field & " Like '" & Reqno & "%'"
        SQL &= " ORDER BY " & _field & " desc"

        dsTbl("dbreqno")

        Dim dbReqno As String = If(DS.Tables("dbreqno").Rows.Count > 0, CStr(DS.Tables("dbreqno")(0)(0)), String.Empty)
        If String.IsNullOrEmpty(dbReqno) Then
            Reqno &= "-01"
        Else
            Reqno = dbReqno.Replace("-", "")
            Reqno = (CInt(Reqno) + 1).ToString(_pattern)
        End If
        Return Reqno
    End Function
End Class
