Imports ConDB.Main
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.LookAndFeel

Public Class FrmMain
    'Public gmh As GlobalMouseHandler = New GlobalMouseHandler()
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
    End Sub
#Region "Button Control"
    Dim currentBtn As BarItem
    Private Sub ButtonClick(sender As Object, e As ItemClickEventArgs) Handles btnMatList.ItemClick _
        , btnMatImport.ItemClick, btnStock.ItemClick, btnUnitManager.ItemClick, btnSupplier.ItemClick, btnLogOut.ItemClick _
        , btnApprove.ItemClick, btnRequsition.ItemClick, btnLogs_Req.ItemClick, btnSubMat.ItemClick, btnTransfer.ItemClick _
        , btnLogs_Import.ItemClick, btnLogs_Transfer.ItemClick, btnQCTarget.ItemClick, btnPOnew.ItemClick, btnPOList.ItemClick
        Dim btnBind As New Dictionary(Of BarItem, Form)
        With btnBind
            .Add(btnMatList, FrmMatList)
            .Add(btnMatImport, FrmMatImport)
            .Add(btnStock, FrmStock)
            .Add(btnApprove, FrmApprove)
            .Add(btnRequsition, FrmRequisition)
            .Add(btnLogs_Req, FrmLogs_Requisition)
            .Add(btnTransfer, FrmTransfer)
            .Add(btnLogs_Import, FrmLogs_Import)
            .Add(btnLogs_Transfer, FrmLogs_Transfer)
            .Add(btnSubMat, FmgSubMat)
            .Add(btnSupplier, FmgSupplier)
            .Add(btnUnitManager, FmgUnit)
            .Add(btnQCTarget, FrmQCTarget)
            .Add(btnPOnew, FrmPONew)
            .Add(btnPOList, FrmLogs_Po)
        End With
        Dim popUpForm As New List(Of Form)
        With popUpForm
            .Add(FmgSubMat)
            .Add(FmgSupplier)
            .Add(FmgUnit)
            .Add(FrmQCTarget)
        End With

        currentBtn = e.Item
        If currentBtn.Name = btnLogOut.Name Then
            bsiLogin.Caption = ""
            UserInfo.Logout()
            FrmLogin.Show()
            Me.Dispose()
        Else
            If btnBind.ContainsKey(currentBtn) Then ShowForm(btnBind(currentBtn), popUpForm)
        End If
    End Sub
#End Region
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += " v." + Version
        bsiLogin.Caption = "สวัสดีคุณ " & UserInfo.UserName & " ขณะนี้ Login ด้วยสิทธ์ User : " & UserInfo.UserID
        bsiServer.Caption = "เชื่อมต่อกับ " & varIP
        bsiServer.Caption &= " | ฐานข้อมูล " & varDB
        bsiServer.Caption &= " | คลังวัสดุ " & UserInfo.LocName & " (" & UserInfo.SelectLoc & ")"

        XtraTabbedMdiManager1.AppearancePage.HeaderActive.ForeColor = ColorInfo.SoftBlue
        Dim setPermission As New Permission.Main(UserInfo.Permis)
    End Sub
    Friend Sub ShowForm(frmName As Form, Optional popForm As List(Of Form) = Nothing)
        frmName.Icon = Icon.FromHandle(CType(currentBtn.ImageOptions.Image, Bitmap).GetHicon)
        If popForm IsNot Nothing AndAlso popForm.Contains(frmName) Then
            frmName.TopMost = True
            frmName.Show()
            Return
        Else
            frmName.MdiParent = Me
            frmName.Show()
        End If
    End Sub
    Private Sub FrmMain_Close(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Office 2013")
    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub
    Private Sub SetTabSize()
        'Dim laf As UserLookAndFeel = Me.LookAndFeel
        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.TabSkins.GetSkin(Me.LookAndFeel)
        Dim EleName As String = DevExpress.Skins.TabSkins.SkinTabHeader
        Dim EleObj As DevExpress.Skins.SkinElement = skin(EleName)
        EleObj.ContentMargins.Top = 2
        EleObj.ContentMargins.Bottom = 2

    End Sub
    Private Sub XtraTabbedMdiManager_PageAdded(ByVal sender As System.Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        'set image
        Dim callback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallBack)
        Dim img As Image
        If currentBtn.ImageOptions.Image Is Nothing Then
            img = New Bitmap(currentBtn.ImageOptions.LargeImage).GetThumbnailImage(16, 16, callback, IntPtr.Zero)
        Else
            img = New Bitmap(currentBtn.ImageOptions.Image).GetThumbnailImage(16, 16, callback, IntPtr.Zero)
        End If

        e.Page.Image = img
    End Sub
    Public Function ThumbnailCallBack() As Boolean
        Return False
    End Function

#Region "RibbonPopup On Mouse Hover"
    Dim delayVal As Integer = 0
    Private Sub Delayer_Tick(sender As Object, e As EventArgs) Handles delayer.Tick
        delayer.Stop()
        Return
        delayVal += 1
        If delayVal >= 3 Then
            RibbonPopShow(Ribbon)
            delayer.Stop()
            delayVal = 0
        End If
    End Sub
    Private Sub ribbonControl_MouseMove(sender As Object, e As MouseEventArgs) Handles ribbonControl.MouseMove
        Return
        Dim vi As ViewInfo.RibbonHitInfo = Ribbon.CalcHitInfo(e.Location)
        If vi.HitTest = DevExpress.XtraBars.Ribbon.ViewInfo.RibbonHitTest.PageHeader Then
            Ribbon.SelectedPage = vi.Page
            'RibbonPopShow(sender)
        End If
    End Sub
    Private Sub FrmMain_Move(sender As Object, e As EventArgs) Handles Me.Move
        Return
        If pop IsNot Nothing Then
            pop.Dispose()
            pop = Nothing
        End If
    End Sub
    'MouseMoveCatch
    Public pop As Ribbon.Helpers.MinimizedRibbonPopupForm
    Public Sub RibbonPopShow(Ribbon As RibbonControl)
        Return
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
        Return
        'Dim f As Form = Form.ActiveForm
        'If f.Name IsNot Nothing AndAlso f.Name IsNot Me.Name Then Return
        bsiDebug.Caption = New Point(PointToClient(Control.MousePosition)).ToString
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
End Class

