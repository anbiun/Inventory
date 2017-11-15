Public Class ClsPersonInfo
    Private _firstName As String
    Private _lastName As String

    Public Sub New(ByVal firstName As String, ByVal lastName As String)
        _firstName = firstName
        _lastName = lastName
    End Sub

    Public Overrides Function ToString() As String
        Return _firstName + " " + _lastName
    End Function
End Class
