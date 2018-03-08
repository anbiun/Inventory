Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iClose = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.lblLoginDetail = New DevExpress.XtraBars.BarStaticItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.alignButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iBoldFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iItalicFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iUnderlinedFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.fontStyleButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iLeftTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iCenterTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iRightTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.BBIMaterialList = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLogOut = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMatImport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRequsition = New DevExpress.XtraBars.BarButtonItem()
        Me.Time = New DevExpress.XtraBars.BarStaticItem()
        Me.btnMatStock = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnitManager = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSupplier = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCF = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintTag = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFmgRequisition = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubMat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTransfer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLogs_Import = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_ListTag = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLogs_Transfer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribGrpNewSub = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribGrpImport = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribGrpApprove = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribGrpSetting = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.AutoSizeItems = True
        Me.ribbonControl.BackColor = System.Drawing.SystemColors.Window
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iClose, Me.iExit, Me.iAbout, Me.lblLoginDetail, Me.siInfo, Me.alignButtonGroup, Me.iBoldFontStyle, Me.iItalicFontStyle, Me.iUnderlinedFontStyle, Me.fontStyleButtonGroup, Me.iLeftTextAlign, Me.iCenterTextAlign, Me.iRightTextAlign, Me.rgbiSkins, Me.BBIMaterialList, Me.btnLogOut, Me.BarButtonItem2, Me.btnMatImport, Me.btnRequsition, Me.Time, Me.btnMatStock, Me.BarButtonItem3, Me.btnUnitManager, Me.btnSupplier, Me.btnCF, Me.btnPrintTag, Me.btnFmgRequisition, Me.btnSubMat, Me.btnTransfer, Me.btnLogs_Import, Me.btn_ListTag, Me.btnLogs_Transfer, Me.btnProduct})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonControl.MaxItemId = 83
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(1033, 162)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        '
        'appMenu
        '
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.ShowRightPane = True
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageOptions.ImageIndex = 6
        Me.iExit.ImageOptions.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'iClose
        '
        Me.iClose.Caption = "&Close"
        Me.iClose.Description = "Closes the active document."
        Me.iClose.Hint = "Closes the active document"
        Me.iClose.Id = 3
        Me.iClose.ImageOptions.ImageIndex = 2
        Me.iClose.ImageOptions.LargeImageIndex = 2
        Me.iClose.Name = "iClose"
        Me.iClose.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'iAbout
        '
        Me.iAbout.Caption = "About"
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageOptions.ImageIndex = 8
        Me.iAbout.ImageOptions.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'lblLoginDetail
        '
        Me.lblLoginDetail.Caption = "LogInDetail"
        Me.lblLoginDetail.Id = 31
        Me.lblLoginDetail.ImageOptions.Image = CType(resources.GetObject("lblLoginDetail.ImageOptions.Image"), System.Drawing.Image)
        Me.lblLoginDetail.ImageOptions.LargeImage = CType(resources.GetObject("lblLoginDetail.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.lblLoginDetail.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue
        Me.lblLoginDetail.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblLoginDetail.Name = "lblLoginDetail"
        '
        'siInfo
        '
        Me.siInfo.Caption = "Some Info"
        Me.siInfo.Id = 32
        Me.siInfo.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon
        Me.siInfo.ItemAppearance.Normal.Options.UseForeColor = True
        Me.siInfo.Name = "siInfo"
        '
        'alignButtonGroup
        '
        Me.alignButtonGroup.Caption = "Align Commands"
        Me.alignButtonGroup.Id = 52
        Me.alignButtonGroup.ItemLinks.Add(Me.iBoldFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iItalicFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iUnderlinedFontStyle)
        Me.alignButtonGroup.Name = "alignButtonGroup"
        '
        'iBoldFontStyle
        '
        Me.iBoldFontStyle.Caption = "Bold"
        Me.iBoldFontStyle.Id = 53
        Me.iBoldFontStyle.ImageOptions.ImageIndex = 9
        Me.iBoldFontStyle.Name = "iBoldFontStyle"
        '
        'iItalicFontStyle
        '
        Me.iItalicFontStyle.Caption = "Italic"
        Me.iItalicFontStyle.Id = 54
        Me.iItalicFontStyle.ImageOptions.ImageIndex = 10
        Me.iItalicFontStyle.Name = "iItalicFontStyle"
        '
        'iUnderlinedFontStyle
        '
        Me.iUnderlinedFontStyle.Caption = "Underlined"
        Me.iUnderlinedFontStyle.Id = 55
        Me.iUnderlinedFontStyle.ImageOptions.ImageIndex = 11
        Me.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle"
        '
        'fontStyleButtonGroup
        '
        Me.fontStyleButtonGroup.Caption = "Font Style"
        Me.fontStyleButtonGroup.Id = 56
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iLeftTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iCenterTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iRightTextAlign)
        Me.fontStyleButtonGroup.Name = "fontStyleButtonGroup"
        '
        'iLeftTextAlign
        '
        Me.iLeftTextAlign.Caption = "Left"
        Me.iLeftTextAlign.Id = 57
        Me.iLeftTextAlign.ImageOptions.ImageIndex = 12
        Me.iLeftTextAlign.Name = "iLeftTextAlign"
        '
        'iCenterTextAlign
        '
        Me.iCenterTextAlign.Caption = "Center"
        Me.iCenterTextAlign.Id = 58
        Me.iCenterTextAlign.ImageOptions.ImageIndex = 13
        Me.iCenterTextAlign.Name = "iCenterTextAlign"
        '
        'iRightTextAlign
        '
        Me.iRightTextAlign.Caption = "Right"
        Me.iRightTextAlign.Id = 59
        Me.iRightTextAlign.ImageOptions.ImageIndex = 14
        Me.iRightTextAlign.Name = "iRightTextAlign"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'BBIMaterialList
        '
        Me.BBIMaterialList.Caption = "รายการวัสดุ"
        Me.BBIMaterialList.Id = 64
        Me.BBIMaterialList.ImageOptions.LargeImage = Global.Inventory_Management.My.Resources.Resources.document_add32
        Me.BBIMaterialList.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BBIMaterialList.ItemAppearance.Hovered.Options.UseFont = True
        Me.BBIMaterialList.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BBIMaterialList.ItemAppearance.Normal.Options.UseFont = True
        Me.BBIMaterialList.Name = "BBIMaterialList"
        '
        'btnLogOut
        '
        Me.btnLogOut.Caption = "ออก"
        Me.btnLogOut.Id = 65
        Me.btnLogOut.ImageOptions.Image = CType(resources.GetObject("btnLogOut.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLogOut.ImageOptions.LargeImage = CType(resources.GetObject("btnLogOut.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnLogOut.Name = "btnLogOut"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "ออก"
        Me.BarButtonItem2.Id = 66
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'btnMatImport
        '
        Me.btnMatImport.Caption = "นำเข้าวัสดุ"
        Me.btnMatImport.Id = 67
        Me.btnMatImport.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources._Get
        Me.btnMatImport.ImageOptions.LargeImage = Global.Inventory_Management.My.Resources.Resources._Get
        Me.btnMatImport.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMatImport.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnMatImport.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnMatImport.ItemAppearance.Normal.Options.UseFont = True
        Me.btnMatImport.LargeWidth = 100
        Me.btnMatImport.Name = "btnMatImport"
        '
        'btnRequsition
        '
        Me.btnRequsition.Caption = "เบิกวัสดุ"
        Me.btnRequsition.Id = 68
        Me.btnRequsition.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.Send
        Me.btnRequsition.ImageOptions.LargeImage = Global.Inventory_Management.My.Resources.Resources.Send
        Me.btnRequsition.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRequsition.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnRequsition.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnRequsition.ItemAppearance.Normal.Options.UseFont = True
        Me.btnRequsition.LargeWidth = 104
        Me.btnRequsition.Name = "btnRequsition"
        '
        'Time
        '
        Me.Time.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.Time.Caption = "Time"
        Me.Time.Id = 7
        Me.Time.Name = "Time"
        '
        'btnMatStock
        '
        Me.btnMatStock.Caption = "วัสดุคงคลัง"
        Me.btnMatStock.Id = 10
        Me.btnMatStock.ImageOptions.Image = CType(resources.GetObject("btnMatStock.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMatStock.ImageOptions.LargeImage = CType(resources.GetObject("btnMatStock.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMatStock.Name = "btnMatStock"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "คำนวน"
        Me.BarButtonItem3.Id = 68
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnUnitManager
        '
        Me.btnUnitManager.Caption = "ข้อมูลหน่วย"
        Me.btnUnitManager.Id = 69
        Me.btnUnitManager.ImageOptions.ImageUri.Uri = "Currency"
        Me.btnUnitManager.Name = "btnUnitManager"
        '
        'btnSupplier
        '
        Me.btnSupplier.Caption = "ข้อมูลผู้ขาย"
        Me.btnSupplier.Id = 70
        Me.btnSupplier.ImageOptions.Image = CType(resources.GetObject("btnSupplier.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSupplier.ImageOptions.LargeImage = CType(resources.GetObject("btnSupplier.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSupplier.Name = "btnSupplier"
        '
        'btnCF
        '
        Me.btnCF.Caption = "ตรวจสอบรับเข้า"
        Me.btnCF.Id = 72
        Me.btnCF.ImageOptions.ImageUri.Uri = "Zoom100"
        Me.btnCF.Name = "btnCF"
        '
        'btnPrintTag
        '
        Me.btnPrintTag.Caption = "Transfer"
        Me.btnPrintTag.Id = 73
        Me.btnPrintTag.ImageOptions.Image = CType(resources.GetObject("btnPrintTag.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintTag.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintTag.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintTag.Name = "btnPrintTag"
        Me.btnPrintTag.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnFmgRequisition
        '
        Me.btnFmgRequisition.Caption = "ประวัติเบิกวัสดุ"
        Me.btnFmgRequisition.Id = 74
        Me.btnFmgRequisition.ImageOptions.Image = CType(resources.GetObject("btnFmgRequisition.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFmgRequisition.ImageOptions.LargeImage = CType(resources.GetObject("btnFmgRequisition.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFmgRequisition.Name = "btnFmgRequisition"
        '
        'btnSubMat
        '
        Me.btnSubMat.Caption = "ข้อมูลเบอร์ร่วม"
        Me.btnSubMat.Id = 76
        Me.btnSubMat.ImageOptions.ImageUri.Uri = "Squeeze"
        Me.btnSubMat.Name = "btnSubMat"
        '
        'btnTransfer
        '
        Me.btnTransfer.Caption = "โอนย้ายคลัง"
        Me.btnTransfer.Id = 77
        Me.btnTransfer.ImageOptions.Image = CType(resources.GetObject("btnTransfer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTransfer.ImageOptions.LargeImage = CType(resources.GetObject("btnTransfer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnTransfer.Name = "btnTransfer"
        '
        'btnLogs_Import
        '
        Me.btnLogs_Import.Caption = "ประวัตินำเข้า"
        Me.btnLogs_Import.Id = 79
        Me.btnLogs_Import.ImageOptions.Image = CType(resources.GetObject("btnLogs_Import.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLogs_Import.ImageOptions.LargeImage = CType(resources.GetObject("btnLogs_Import.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnLogs_Import.Name = "btnLogs_Import"
        '
        'btn_ListTag
        '
        Me.btn_ListTag.Caption = "รายการ Tag"
        Me.btn_ListTag.Id = 80
        Me.btn_ListTag.ImageOptions.Image = CType(resources.GetObject("btn_ListTag.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_ListTag.ImageOptions.LargeImage = CType(resources.GetObject("btn_ListTag.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_ListTag.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon
        Me.btn_ListTag.ItemAppearance.Normal.Options.UseForeColor = True
        Me.btn_ListTag.Name = "btn_ListTag"
        Me.btn_ListTag.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnLogs_Transfer
        '
        Me.btnLogs_Transfer.Caption = "ประวัติโอนย้าย"
        Me.btnLogs_Transfer.Id = 81
        Me.btnLogs_Transfer.ImageOptions.Image = CType(resources.GetObject("btnLogs_Transfer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLogs_Transfer.ImageOptions.LargeImage = CType(resources.GetObject("btnLogs_Transfer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnLogs_Transfer.Name = "btnLogs_Transfer"
        '
        'btnProduct
        '
        Me.btnProduct.Caption = "เป้าผลิต"
        Me.btnProduct.Id = 82
        Me.btnProduct.ImageOptions.Image = CType(resources.GetObject("btnProduct.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProduct.ImageOptions.LargeImage = CType(resources.GetObject("btnProduct.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnProduct.Name = "btnProduct"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RibbonPage1.Appearance.Options.UseFont = True
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribGrpNewSub, Me.ribGrpImport, Me.ribGrpApprove, Me.RibbonPageGroup1, Me.ribGrpSetting, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "จัดการข้อมูลวัสดุ"
        '
        'ribGrpNewSub
        '
        Me.ribGrpNewSub.ItemLinks.Add(Me.BBIMaterialList)
        Me.ribGrpNewSub.Name = "ribGrpNewSub"
        Me.ribGrpNewSub.Text = "เพิ่มข้อมูล"
        '
        'ribGrpImport
        '
        Me.ribGrpImport.ItemLinks.Add(Me.btnMatImport)
        Me.ribGrpImport.ItemLinks.Add(Me.btnRequsition)
        Me.ribGrpImport.ItemLinks.Add(Me.btnCF)
        Me.ribGrpImport.Name = "ribGrpImport"
        Me.ribGrpImport.Text = "นำเข้าวัสดุ/เบิกออก"
        '
        'ribGrpApprove
        '
        Me.ribGrpApprove.ItemLinks.Add(Me.btnTransfer)
        Me.ribGrpApprove.ItemLinks.Add(Me.btnMatStock)
        Me.ribGrpApprove.ItemLinks.Add(Me.btnPrintTag)
        Me.ribGrpApprove.Name = "ribGrpApprove"
        Me.ribGrpApprove.Text = "ตรวจสอบข้อมูล"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnFmgRequisition)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLogs_Import)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_ListTag)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLogs_Transfer)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "ข้อมูลประวัติ"
        '
        'ribGrpSetting
        '
        Me.ribGrpSetting.ItemLinks.Add(Me.btnUnitManager)
        Me.ribGrpSetting.ItemLinks.Add(Me.btnSupplier)
        Me.ribGrpSetting.ItemLinks.Add(Me.btnSubMat)
        Me.ribGrpSetting.ItemLinks.Add(Me.btnProduct)
        Me.ribGrpSetting.Name = "ribGrpSetting"
        Me.ribGrpSetting.Text = "ตั้งค่าข้อมูล"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnLogOut)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "ออก"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblLoginDetail)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.ItemLinks.Add(Me.Time)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 987)
        Me.ribbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1033, 40)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabbedMdiManager1.FloatPageDragMode = DevExpress.XtraTabbedMdi.FloatPageDragMode.Preview
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'FrmMain
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 1027)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(550, 1028)
        Me.Name = "FrmMain"
        Me.Ribbon = Me.ribbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Inventory Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents iClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents alignButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iBoldFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iItalicFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iUnderlinedFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents fontStyleButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iLeftTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iCenterTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iRightTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BBIMaterialList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribGrpNewSub As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLogOut As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMatImport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRequsition As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribGrpImport As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Time As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnMatStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribGrpApprove As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnitManager As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribGrpSetting As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSupplier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblLoginDetail As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnCF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintTag As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFmgRequisition As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubMat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTransfer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLogs_Import As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_ListTag As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLogs_Transfer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents btnProduct As BarButtonItem
End Class
