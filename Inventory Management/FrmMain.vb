Imports ConDB.Main
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.LookAndFeel

Public Class FrmMain
    Public gmh As GlobalMouseHandler = New GlobalMouseHandler()
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += " v." + Version
        lblLoginDetail.Caption = "สวัสดีคุณ " & UserInfo.UserName & " ขณะนี้ Login ด้วยสิทธ์ User : " & UserInfo.UserID
        siInfo.Caption = "| Current IP : " & varIP
        siInfo.Caption &= " | Database : " & varDB
        siInfo.Caption &= " | Location : " & UserInfo.SelectLoc & "(" & UserInfo.LocName & ")"
        Ribbon.Minimized = True
        SetTabSize()
        Permission(UserInfo.Permis)
    End Sub
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()

        AddHandler gmh.TheMouseMoved, New MouseMovedEvent(AddressOf gmh_TheMouseMoved)
        Application.AddMessageFilter(gmh)
    End Sub
    Private Sub showFrom(frmName As Form)
        frmName.MdiParent = Me
        XtraTabbedMdiManager1.SelectedPage = XtraTabbedMdiManager1.Pages(frmName)
        frmName.Show()

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Office 2013")
    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
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
        RemoveHandler gmh.TheMouseMoved, AddressOf gmh_TheMouseMoved
        Me.Dispose()
    End Sub
#End Region
    Private Sub btnCF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCF.ItemClick
        showFrom(FrmApprove)
    End Sub
    Private Sub btnPrintTag_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPrintTag.ItemClick
    End Sub
    Private Sub btnRequsition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRequsition.ItemClick
        showFrom(FrmRequisition)
    End Sub
    Private Sub btnFmgRequisition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnFmgRequisition.ItemClick
        showFrom(FrmLogs_Requisition)
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
    Private Sub SetTabSize()
        'Dim laf As UserLookAndFeel = Me.LookAndFeel
        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.TabSkins.GetSkin(Me.LookAndFeel)
        Dim EleName As String = DevExpress.Skins.TabSkins.SkinTabHeader
        Dim EleObj As DevExpress.Skins.SkinElement = skin(EleName)
        EleObj.ContentMargins.Top = 10
        EleObj.ContentMargins.Bottom = 10

    End Sub

#Region "RibbonPopup On Mouse Hover"
    Dim delayVal As Integer = 0
    Private Sub Delayer_Tick(sender As Object, e As EventArgs) Handles delayer.Tick
        delayVal += 1
        If delayVal >= 3 Then
            RibbonPopShow(Ribbon)
            delayer.Stop()
            delayVal = 0
        End If
    End Sub
    Private Sub ribbonControl_MouseMove(sender As Object, e As MouseEventArgs) Handles ribbonControl.MouseMove
        Dim vi As ViewInfo.RibbonHitInfo = Ribbon.CalcHitInfo(e.Location)
        If vi.HitTest = DevExpress.XtraBars.Ribbon.ViewInfo.RibbonHitTest.PageHeader Then
            Ribbon.SelectedPage = vi.Page
            'RibbonPopShow(sender)
        End If
    End Sub
    Private Sub FrmMain_Move(sender As Object, e As EventArgs) Handles Me.Move
        If pop IsNot Nothing Then
            pop.Dispose()
            pop = Nothing
        End If
    End Sub
    'MouseMoveCatch
    Public pop As Ribbon.Helpers.MinimizedRibbonPopupForm
    Public Sub RibbonPopShow(Ribbon As RibbonControl)
        Ribbon.BeginInit()
        'Ribbon.SelectedPage = hitinfo.Page
        If pop Is Nothing Then
            If Ribbon.Minimized = False Then Exit Sub
            pop = New Helpers.MinimizedRibbonPopupForm(Ribbon)
            pop.UpdateRibbon()
            pop.ShowPopup()
            pop.Refresh()
            Ribbon.EndInit()
            delayer.Stop()
            delayVal = 0
        End If
    End Sub
    Private Sub gmh_TheMouseMoved()
        'Dim f As Form = Form.ActiveForm
        'If f.Name IsNot Nothing AndAlso f.Name IsNot Me.Name Then Return
        Time.Caption = New Point(PointToClient(Control.MousePosition)).ToString
        Dim point As Point = PointToClient(Control.MousePosition)

        If point.Y < 22 OrElse point.Y > 143 Then
            delayer.Stop()
            delayVal = 0
            If pop Is Nothing Then Return
            pop.Dispose()
            pop = Nothing
        ElseIf point.Y <= 62 Then
            delayer.Start()
        ElseIf point.Y > 62 Then
            delayer.Stop()
            delayVal = 0
        End If
    End Sub
    Public Delegate Sub MouseMovedEvent()
    Public Class GlobalMouseHandler
        Implements IMessageFilter
        Private Const WM_MOUSEMOVE As Integer = 512
        Public Event TheMouseMoved As MouseMovedEvent
        Private Function IMessageFilter_PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
            If m.Msg = WM_MOUSEMOVE Then
                RaiseEvent TheMouseMoved()
            End If
            Return False
        End Function
    End Class
#End Region
    'A 10 -> B
    '
End Class

