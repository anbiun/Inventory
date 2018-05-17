Option Explicit On
Option Strict On
Imports ConDB.Main
Public Class UserInfo
    Property UserID As String
    Property UserName As String
    Property Password As String
    Property Permission As UserGroup
    Property Access As Boolean = False
    Property Stat As Integer
    Property SelectLoc As String
    Property LocName As String
    Public Enum UserGroup As Integer
        User = 0
        Po = 2
        Stock = 3
        Manger = 4
        Admin = 5
    End Enum
    Friend Function Login() As Integer
        SQL = "SELECT * FROM tbLogin WHERE UserID='" & UserID & "' AND UserPwd='" & Password & "'"
        dsTbl("login")
        FoundRow = DS.Tables("login").Select("UserID='" & UserID & "'")
        If FoundRow.Count > 0 Then
            UserID = FoundRow(0)("UserID").ToString
            UserName = FoundRow(0)("UserName").ToString
            SetPermission(CInt(FoundRow(0)("Permis")))
            Stat = 1
            Return Stat
        Else
            MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Stat = 0
            Return Stat
        End If
    End Function
    Friend Function Logout() As Integer
        Stat = 0
        UserID = Nothing
        UserName = Nothing
        Password = Nothing
        Permission = Nothing
        SelectLoc = Nothing
        Return Stat
    End Function
    Private Sub SetPermission(InputPermis As Integer)
        Select Case InputPermis

            Case UserGroup.User
                Permission = UserGroup.User
                Dim ulv As New UserLevel
            Case UserGroup.Po
                Permission = UserGroup.Po
                With FrmMatList
                    .PnlTreeButton.Visible = False
                End With
                With FrmMain
                    .ribGrpNewMat.Visible = False
                    .ribGrpImport.Visible = False
                    .btnTransfer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnLogs_Req.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnLogs_Transfer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnUnitManager.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnSubMat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    .btnQCTarget.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End With
            Case UserGroup.Stock
                Permission = UserGroup.Stock
                Dim ulv As New UserLevel
                FrmMain.btnStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                FrmMain.ribGrpSetting.Visible = True
            Case UserGroup.Manger
                Access = True
                Permission = UserGroup.Manger
                FrmMatImport.pnlEdit.Visible = False
            Case UserGroup.Admin
                Access = True
                Permission = UserGroup.Admin
            Case Else
                Dim ulv As New UserLevel
                Access = False
                Permission = UserGroup.User
        End Select
    End Sub
    Private Class UserLevel
        Sub New()
            With FrmMatImport
                .grpSearch.Visible = True
                .grpSearch.Visible = True
                .pnlEdit.Visible = False
            End With
            FrmLogs_Requisition.BtnDel.Visible = False
            With FrmMain
                .ribGrpApprove.Visible = True
                .btnStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .ribGrpSetting.Visible = False
                .ribGrpNewMat.Visible = False
                .RibbonPage2.Visible = False
            End With
        End Sub
    End Class
End Class
