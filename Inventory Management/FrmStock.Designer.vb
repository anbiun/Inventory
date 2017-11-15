<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStock
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStock))
        Me.gcMain = New DevExpress.XtraGrid.GridControl()
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.gv2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcOldStock = New DevExpress.XtraGrid.GridControl()
        Me.gvOldStock = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AdvBandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.slCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.clbSubCat = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.clbLoc = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.gcExport_AllStock = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.lbCat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tooltipGcMain = New DevExpress.Utils.ToolTipController(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkDate = New System.Windows.Forms.CheckedListBox()
        Me.chkDays = New System.Windows.Forms.CheckedListBox()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.rdDays = New System.Windows.Forms.RadioButton()
        Me.rdDate = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.deOldStock = New DevExpress.XtraEditors.DateEdit()
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOldStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOldStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcExport_AllStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.deOldStock.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deOldStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcMain
        '
        Me.gcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcMain.Location = New System.Drawing.Point(0, 76)
        Me.gcMain.MainView = Me.gvMain
        Me.gcMain.Margin = New System.Windows.Forms.Padding(4)
        Me.gcMain.Name = "gcMain"
        Me.gcMain.Size = New System.Drawing.Size(954, 577)
        Me.gcMain.TabIndex = 9
        Me.gcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain, Me.AdvBandedGridView1, Me.gv2})
        '
        'gvMain
        '
        Me.gvMain.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvMain.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvMain.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvMain.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvMain.Appearance.Row.Options.UseFont = True
        Me.gvMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvMain.GridControl = Me.gcMain
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.Editable = False
        Me.gvMain.OptionsFind.AllowFindPanel = False
        Me.gvMain.OptionsFind.ClearFindOnClose = False
        Me.gvMain.OptionsFind.FindDelay = 100
        Me.gvMain.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvMain.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvMain.OptionsFind.ShowClearButton = False
        Me.gvMain.OptionsFind.ShowFindButton = False
        Me.gvMain.OptionsView.ColumnAutoWidth = False
        Me.gvMain.OptionsView.ShowGroupPanel = False
        Me.gvMain.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBandedGridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.AdvBandedGridView1.Appearance.Row.Options.UseFont = True
        Me.AdvBandedGridView1.FixedLineWidth = 1
        Me.AdvBandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.AdvBandedGridView1.GridControl = Me.gcMain
        Me.AdvBandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsFind.AllowFindPanel = False
        Me.AdvBandedGridView1.OptionsFind.ClearFindOnClose = False
        Me.AdvBandedGridView1.OptionsFind.FindDelay = 100
        Me.AdvBandedGridView1.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.AdvBandedGridView1.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.AdvBandedGridView1.OptionsFind.ShowClearButton = False
        Me.AdvBandedGridView1.OptionsFind.ShowFindButton = False
        Me.AdvBandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'gv2
        '
        Me.gv2.GridControl = Me.gcMain
        Me.gv2.Name = "gv2"
        '
        'gcOldStock
        '
        Me.gcOldStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcOldStock.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcOldStock.Location = New System.Drawing.Point(0, 76)
        Me.gcOldStock.MainView = Me.gvOldStock
        Me.gcOldStock.Margin = New System.Windows.Forms.Padding(4)
        Me.gcOldStock.Name = "gcOldStock"
        Me.gcOldStock.Size = New System.Drawing.Size(485, 577)
        Me.gcOldStock.TabIndex = 10
        Me.gcOldStock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOldStock, Me.AdvBandedGridView2, Me.GridView2})
        '
        'gvOldStock
        '
        Me.gvOldStock.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvOldStock.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvOldStock.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvOldStock.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvOldStock.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvOldStock.Appearance.Row.Options.UseFont = True
        Me.gvOldStock.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvOldStock.GridControl = Me.gcOldStock
        Me.gvOldStock.Name = "gvOldStock"
        Me.gvOldStock.OptionsBehavior.Editable = False
        Me.gvOldStock.OptionsFind.AllowFindPanel = False
        Me.gvOldStock.OptionsFind.ClearFindOnClose = False
        Me.gvOldStock.OptionsFind.FindDelay = 100
        Me.gvOldStock.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvOldStock.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvOldStock.OptionsFind.ShowClearButton = False
        Me.gvOldStock.OptionsFind.ShowFindButton = False
        Me.gvOldStock.OptionsView.ColumnAutoWidth = False
        Me.gvOldStock.OptionsView.ShowGroupPanel = False
        Me.gvOldStock.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'AdvBandedGridView2
        '
        Me.AdvBandedGridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.AdvBandedGridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.AdvBandedGridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBandedGridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.AdvBandedGridView2.Appearance.Row.Options.UseFont = True
        Me.AdvBandedGridView2.FixedLineWidth = 1
        Me.AdvBandedGridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.AdvBandedGridView2.GridControl = Me.gcOldStock
        Me.AdvBandedGridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.AdvBandedGridView2.Name = "AdvBandedGridView2"
        Me.AdvBandedGridView2.OptionsBehavior.Editable = False
        Me.AdvBandedGridView2.OptionsFind.AllowFindPanel = False
        Me.AdvBandedGridView2.OptionsFind.ClearFindOnClose = False
        Me.AdvBandedGridView2.OptionsFind.FindDelay = 100
        Me.AdvBandedGridView2.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.AdvBandedGridView2.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.AdvBandedGridView2.OptionsFind.ShowClearButton = False
        Me.AdvBandedGridView2.OptionsFind.ShowFindButton = False
        Me.AdvBandedGridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcOldStock
        Me.GridView2.Name = "GridView2"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.slCat)
        Me.GroupControl1.Controls.Add(Me.btnSearch)
        Me.GroupControl1.Controls.Add(Me.clbSubCat)
        Me.GroupControl1.Controls.Add(Me.clbLoc)
        Me.GroupControl1.Controls.Add(Me.gcExport_AllStock)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.btnPrint)
        Me.GroupControl1.Controls.Add(Me.btnExportExcel)
        Me.GroupControl1.Controls.Add(Me.lbCat)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(241, 653)
        Me.GroupControl1.TabIndex = 18
        Me.GroupControl1.Text = "ค้นหาข้อมูล"
        '
        'slCat
        '
        Me.slCat.EditValue = ""
        Me.slCat.Location = New System.Drawing.Point(16, 63)
        Me.slCat.Name = "slCat"
        Me.slCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slCat.Properties.Appearance.Options.UseFont = True
        Me.slCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slCat.Properties.NullText = "กรุณาเลือกหมวดวัสดุ"
        Me.slCat.Properties.View = Me.SearchLookUpEdit1View
        Me.slCat.Size = New System.Drawing.Size(212, 28)
        Me.slCat.TabIndex = 25
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSearch.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btnSearch.Location = New System.Drawing.Point(16, 382)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(211, 43)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "ค้นหา"
        '
        'clbSubCat
        '
        Me.clbSubCat.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbSubCat.Appearance.Options.UseFont = True
        Me.clbSubCat.CheckOnClick = True
        Me.clbSubCat.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbSubCat.Location = New System.Drawing.Point(16, 120)
        Me.clbSubCat.Name = "clbSubCat"
        Me.clbSubCat.Size = New System.Drawing.Size(212, 146)
        Me.clbSubCat.TabIndex = 22
        '
        'clbLoc
        '
        Me.clbLoc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbLoc.Appearance.Options.UseFont = True
        Me.clbLoc.CheckOnClick = True
        Me.clbLoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbLoc.Location = New System.Drawing.Point(16, 295)
        Me.clbLoc.Name = "clbLoc"
        Me.clbLoc.Size = New System.Drawing.Size(212, 81)
        Me.clbLoc.TabIndex = 22
        '
        'gcExport_AllStock
        '
        Me.gcExport_AllStock.Location = New System.Drawing.Point(697, 37)
        Me.gcExport_AllStock.MainView = Me.GridView1
        Me.gcExport_AllStock.Name = "gcExport_AllStock"
        Me.gcExport_AllStock.Size = New System.Drawing.Size(400, 166)
        Me.gcExport_AllStock.TabIndex = 21
        Me.gcExport_AllStock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.gcExport_AllStock.Visible = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcExport_AllStock
        Me.GridView1.Name = "GridView1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(5, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "คลังวัสดุ :"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(16, 597)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(212, 43)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "พิมพ์ข้อมูล"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.ImageOptions.Image = CType(resources.GetObject("btnExportExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportExcel.Location = New System.Drawing.Point(16, 548)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(212, 43)
        Me.btnExportExcel.TabIndex = 19
        Me.btnExportExcel.Text = "นำออกข้อมูล Excel"
        '
        'lbCat
        '
        Me.lbCat.AutoSize = True
        Me.lbCat.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.lbCat.Location = New System.Drawing.Point(5, 37)
        Me.lbCat.Name = "lbCat"
        Me.lbCat.Size = New System.Drawing.Size(101, 23)
        Me.lbCat.TabIndex = 13
        Me.lbCat.Text = "หมวดวัสดุ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label3.Location = New System.Drawing.Point(5, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ประเภทวัสดุ :"
        '
        'tooltipGcMain
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ExpandableSplitter1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(241, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1458, 653)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkDate)
        Me.Panel2.Controls.Add(Me.chkDays)
        Me.Panel2.Controls.Add(Me.gcMain)
        Me.Panel2.Controls.Add(Me.GroupControl3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 653)
        Me.Panel2.TabIndex = 10
        '
        'chkDate
        '
        Me.chkDate.AllowDrop = True
        Me.chkDate.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDate.FormattingEnabled = True
        Me.chkDate.IntegralHeight = False
        Me.chkDate.Location = New System.Drawing.Point(233, 38)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(95, 175)
        Me.chkDate.TabIndex = 26
        '
        'chkDays
        '
        Me.chkDays.AllowDrop = True
        Me.chkDays.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDays.FormattingEnabled = True
        Me.chkDays.IntegralHeight = False
        Me.chkDays.Location = New System.Drawing.Point(431, 38)
        Me.chkDays.Name = "chkDays"
        Me.chkDays.Size = New System.Drawing.Size(111, 175)
        Me.chkDays.TabIndex = 26
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.rdDays)
        Me.GroupControl3.Controls.Add(Me.rdDate)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.SimpleButton2)
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(954, 76)
        Me.GroupControl3.TabIndex = 15
        Me.GroupControl3.Text = "ข้อมูล ณ ปัจจุบัน ตัด Stock ถึงวันที่ :"
        '
        'rdDays
        '
        Me.rdDays.AutoSize = True
        Me.rdDays.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDays.Location = New System.Drawing.Point(341, 36)
        Me.rdDays.Name = "rdDays"
        Me.rdDays.Size = New System.Drawing.Size(82, 25)
        Me.rdDays.TabIndex = 25
        Me.rdDays.TabStop = True
        Me.rdDays.Text = "ทุกวัน :"
        Me.rdDays.UseVisualStyleBackColor = True
        '
        'rdDate
        '
        Me.rdDate.AutoSize = True
        Me.rdDate.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDate.Location = New System.Drawing.Point(132, 36)
        Me.rdDate.Name = "rdDate"
        Me.rdDate.Size = New System.Drawing.Size(94, 25)
        Me.rdDate.TabIndex = 25
        Me.rdDate.TabStop = True
        Me.rdDate.Text = "ทุกวันที่ :"
        Me.rdDate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(30, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "บันทึกสต๊อก"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(641, 36)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(87, 26)
        Me.SimpleButton2.TabIndex = 24
        Me.SimpleButton2.Text = "ลบ"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(548, 36)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(87, 26)
        Me.SimpleButton1.TabIndex = 24
        Me.SimpleButton1.Text = "เพิ่ม"
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpandableSplitter1.ExpandableControl = Me.Panel3
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(954, 0)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(19, 653)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 11
        Me.ExpandableSplitter1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.gcOldStock)
        Me.Panel3.Controls.Add(Me.GroupControl2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(973, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(485, 653)
        Me.Panel3.TabIndex = 10
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.deOldStock)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(485, 76)
        Me.GroupControl2.TabIndex = 14
        Me.GroupControl2.Text = "ข้อมูลย้อนหลัง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label2.Location = New System.Drawing.Point(38, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ข้อมูล Stock ณ วันที่ :"
        '
        'deOldStock
        '
        Me.deOldStock.EditValue = Nothing
        Me.deOldStock.Location = New System.Drawing.Point(242, 35)
        Me.deOldStock.Name = "deOldStock"
        Me.deOldStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deOldStock.Properties.Appearance.Options.UseFont = True
        Me.deOldStock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deOldStock.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deOldStock.Size = New System.Drawing.Size(218, 28)
        Me.deOldStock.TabIndex = 11
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1699, 653)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FrmStock"
        Me.Text = "วัสดุคงคลัง ณ ปัจจุบัน"
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOldStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOldStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcExport_AllStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.deOldStock.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deOldStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents gv2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcOldStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvOldStock As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdvBandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcExport_AllStock As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clbLoc As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clbSubCat As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents slCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbCat As Label
    Friend WithEvents tooltipGcMain As DevExpress.Utils.ToolTipController
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As Label
    Friend WithEvents deOldStock As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label4 As Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkDays As CheckedListBox
    Friend WithEvents rdDays As RadioButton
    Friend WithEvents rdDate As RadioButton
    Friend WithEvents chkDate As CheckedListBox
End Class
