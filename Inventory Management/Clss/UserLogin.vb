Imports ConDB.Main
Public Class UserLogin
    Public UserID As String
    Public UserName As String
    Public Password As String
    Public Permis As String
    Public Stat As Integer
    Public SelectLoc As String
    Public LocName As String
    Friend Function Login()
        SQL = "SELECT * FROM tbLogin WHERE UserID='" & UserID & "' AND UserPwd='" & Password & "'"
        dsTbl("login")
        FoundRow = DS.Tables("login").Select("UserID='" & UserID & "'")
        If FoundRow.Count > 0 Then
            UserID = FoundRow(0)("UserID")
            UserName = FoundRow(0)("UserName")
            Permis = FoundRow(0)("Permis")
            Stat = 1
            Return True
        Else
            MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Stat = 0
            Return Stat
        End If
    End Function
    Friend Function Logout()
        Stat = 0
        UserID = Nothing
        UserName = Nothing
        Password = Nothing
        Permis = Nothing
        SelectLoc = Nothing
        Return Stat
    End Function
End Class
