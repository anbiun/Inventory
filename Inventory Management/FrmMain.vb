Imports ConDB.Main
Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins

Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += " v." + Version
        lblLoginDetail.Caption = "สวัสดีคุณ " & UserInfo.UserName & " ขณะนี้ Login ด้วยสิทธ์ User : " & UserInfo.UserID
        siInfo.Caption = "| Current IP : " & varIP
        siInfo.Caption &= " | Database : " & varDB
        siInfo.Caption &= " | Location : " & UserInfo.SelectLoc & "(" & UserInfo.LocName & ")"

        Permission(UserInfo.Permis)
    End Sub
    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Time.Caption = Me.Size.Height
    End Sub
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
        'Me.InitGrid()
    End Sub
    Private Sub showFrom(frmName As Form)
        frmName.MdiParent = Me
        frmName.Show()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        'UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
        UserLookAndFeel.Default.SetSkinStyle("Office 2013")

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Time.Caption = Now.ToString & " MaincatSelect =" & MainCatSelect & " olMatID=" & FrmMatList.oldMatID
    End Sub

#Region "Button Control"
    Private Sub BBIMaterialList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBIMaterialList.ItemClick
        showFrom(FrmMatList)
    End Sub
    Private Sub BtnMatImport_Click(sender As Object, e As ItemClickEventArgs) Handles btnMatImport.ItemClick
        showFrom(FrmMatImport)
    End Sub
    Private Sub btnMatStock_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnMatStock.ItemClick
        loadSuccess = False
        showFrom(FrmStock)
    End Sub
    Private Sub btnUnitManager_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnUnitManager.ItemClick
        showFrom(FmgUnit)
    End Sub
    Private Sub btnSupplier_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSupplier.ItemClick
        showFrom(FmgSupplier)
    End Sub
    Private Sub btnLogOut_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLogOut.ItemClick
        lblLoginDetail.Caption = ""
        UserInfo.Logout()
        FrmLogin.Show()
        Me.Dispose()
    End Sub
#End Region
    Private Sub btnCF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCF.ItemClick
        showFrom(FrmApprove)
    End Sub
    Private Sub btnPrintTag_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPrintTag.ItemClick
        showFrom(FrmPrintnTransfer)
    End Sub
    Private Sub btnRequsition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRequsition.ItemClick
        showFrom(FrmRequisition)
    End Sub
    Private Sub btnFmgRequisition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnFmgRequisition.ItemClick
        showFrom(FmgRequisition)
    End Sub
    Private Sub btnSubMat_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSubMat.ItemClick
        FmgSubMat.Show()
    End Sub
    Private Sub FrmMain_Close(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub btnTransfer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnTransfer.ItemClick
        showFrom(FrmTransfer)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs)
        showFrom(FrmStock)
    End Sub

    Private Sub btnLogs_ImportClick(sender As Object, e As ItemClickEventArgs) Handles btnLogs_Import.ItemClick
        showFrom(FrmLogs_Import)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_ListTag.ItemClick
        showFrom(FrmLogs_Tag)
    End Sub

    Private Sub btnLogs_Transfer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLogs_Transfer.ItemClick
        showFrom(FrmLogs_Transfer)
    End Sub

    Private Sub btnProduct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnProduct.ItemClick
        FmgQCTarget.Show()
    End Sub
End Class
