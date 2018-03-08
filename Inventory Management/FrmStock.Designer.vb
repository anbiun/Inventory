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
        Me.tooltipGcMain = New DevExpress.Utils.ToolTipController(Me.components)
        Me.gcAdjust = New DevExpress.XtraGrid.GridControl()
        Me.gvAdjust = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.lbCat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gcMain = New DevExpress.XtraGrid.GridControl()
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lastStock = New DevExpress.XtraEditors.GroupControl()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grpAdjust = New DevExpress.XtraEditors.GroupControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbU3 = New System.Windows.Forms.Label()
        Me.lbU2 = New System.Windows.Forms.Label()
        Me.lbU1 = New System.Windows.Forms.Label()
        Me.cbStat = New System.Windows.Forms.ComboBox()
        Me.lbUnit3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdJust = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUnit3 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtUnit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.lbUnit1_Name = New System.Windows.Forms.Label()
        Me.txtUnit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNotation = New DevExpress.XtraEditors.MemoEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbUnit3_Name = New System.Windows.Forms.Label()
        Me.lbUnit1 = New System.Windows.Forms.Label()
        Me.lbQty = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbTagID = New System.Windows.Forms.Label()
        Me.lbQtyPerUnit = New System.Windows.Forms.Label()
        Me.lbRatio = New System.Windows.Forms.Label()
        Me.lbMatName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.gcAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grpAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdjust.SuspendLayout()
        CType(Me.txtUnit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tooltipGcMain
        '
        '
        'gcAdjust
        '
        Me.gcAdjust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAdjust.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcAdjust.Location = New System.Drawing.Point(0, 252)
        Me.gcAdjust.MainView = Me.gvAdjust
        Me.gcAdjust.Margin = New System.Windows.Forms.Padding(4)
        Me.gcAdjust.Name = "gcAdjust"
        Me.gcAdjust.Size = New System.Drawing.Size(773, 401)
        Me.gcAdjust.TabIndex = 10
        Me.gcAdjust.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAdjust, Me.AdvBandedGridView2, Me.GridView2})
        '
        'gvAdjust
        '
        Me.gvAdjust.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvAdjust.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvAdjust.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvAdjust.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvAdjust.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvAdjust.Appearance.Row.Options.UseFont = True
        Me.gvAdjust.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvAdjust.GridControl = Me.gcAdjust
        Me.gvAdjust.Name = "gvAdjust"
        Me.gvAdjust.OptionsBehavior.Editable = False
        Me.gvAdjust.OptionsFind.AllowFindPanel = False
        Me.gvAdjust.OptionsFind.ClearFindOnClose = False
        Me.gvAdjust.OptionsFind.FindDelay = 100
        Me.gvAdjust.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvAdjust.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvAdjust.OptionsFind.ShowClearButton = False
        Me.gvAdjust.OptionsFind.ShowFindButton = False
        Me.gvAdjust.OptionsView.ColumnAutoWidth = False
        Me.gvAdjust.OptionsView.ShowGroupPanel = False
        Me.gvAdjust.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
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
        Me.AdvBandedGridView2.GridControl = Me.gcAdjust
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
        Me.GridView2.GridControl = Me.gcAdjust
        Me.GridView2.Name = "GridView2"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.slCat)
        Me.GroupControl1.Controls.Add(Me.btnSearch)
        Me.GroupControl1.Controls.Add(Me.clbSubCat)
        Me.GroupControl1.Controls.Add(Me.clbLoc)
        Me.GroupControl1.Controls.Add(Me.gcExport_AllStock)
        Me.GroupControl1.Controls.Add(Me.Label1)
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
        Me.btnSearch.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.find_32x32
        Me.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btnSearch.Location = New System.Drawing.Point(16, 449)
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
        Me.clbSubCat.Size = New System.Drawing.Size(212, 191)
        Me.clbSubCat.TabIndex = 22
        '
        'clbLoc
        '
        Me.clbLoc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbLoc.Appearance.Options.UseFont = True
        Me.clbLoc.CheckOnClick = True
        Me.clbLoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbLoc.Location = New System.Drawing.Point(16, 340)
        Me.clbLoc.Name = "clbLoc"
        Me.clbLoc.Size = New System.Drawing.Size(212, 103)
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
        Me.Label1.Location = New System.Drawing.Point(5, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "คลังวัสดุ :"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.ImageOptions.Image = CType(resources.GetObject("btnExportExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportExcel.Location = New System.Drawing.Point(16, 598)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ExpandableSplitter1)
        Me.Panel1.Controls.Add(Me.pnlRight)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(241, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 653)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gcMain)
        Me.Panel2.Controls.Add(Me.lastStock)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 653)
        Me.Panel2.TabIndex = 10
        '
        'gcMain
        '
        Me.gcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMain.Location = New System.Drawing.Point(0, 31)
        Me.gcMain.MainView = Me.gvMain
        Me.gcMain.Name = "gcMain"
        Me.gcMain.Size = New System.Drawing.Size(1029, 622)
        Me.gcMain.TabIndex = 16
        Me.gcMain.ToolTipController = Me.tooltipGcMain
        Me.gcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvMain.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvMain.Appearance.DetailTip.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.DetailTip.Options.UseFont = True
        Me.gvMain.Appearance.Empty.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.Empty.Options.UseFont = True
        Me.gvMain.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.EvenRow.Options.UseFont = True
        Me.gvMain.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvMain.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.FilterPanel.Options.UseFont = True
        Me.gvMain.Appearance.FixedLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.FixedLine.Options.UseFont = True
        Me.gvMain.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.FocusedCell.Options.UseFont = True
        Me.gvMain.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.FocusedRow.Options.UseFont = True
        Me.gvMain.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.FooterPanel.Options.UseFont = True
        Me.gvMain.Appearance.GroupButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.GroupButton.Options.UseFont = True
        Me.gvMain.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.GroupFooter.Options.UseFont = True
        Me.gvMain.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.GroupPanel.Options.UseFont = True
        Me.gvMain.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.GroupRow.Options.UseFont = True
        Me.gvMain.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMain.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvMain.Appearance.HorzLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.HorzLine.Options.UseFont = True
        Me.gvMain.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.OddRow.Options.UseFont = True
        Me.gvMain.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.Preview.Options.UseFont = True
        Me.gvMain.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.Row.Options.UseFont = True
        Me.gvMain.Appearance.RowSeparator.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.RowSeparator.Options.UseFont = True
        Me.gvMain.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.SelectedRow.Options.UseFont = True
        Me.gvMain.Appearance.TopNewRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.TopNewRow.Options.UseFont = True
        Me.gvMain.Appearance.VertLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.VertLine.Options.UseFont = True
        Me.gvMain.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvMain.Appearance.ViewCaption.Options.UseFont = True
        Me.gvMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvMain.GridControl = Me.gcMain
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.Editable = False
        Me.gvMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvMain.OptionsView.ColumnAutoWidth = False
        Me.gvMain.OptionsView.ShowAutoFilterRow = True
        Me.gvMain.OptionsView.ShowGroupPanel = False
        Me.gvMain.OptionsView.ShowIndicator = False
        '
        'lastStock
        '
        Me.lastStock.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastStock.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lastStock.AppearanceCaption.Options.UseFont = True
        Me.lastStock.AppearanceCaption.Options.UseForeColor = True
        Me.lastStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.lastStock.Location = New System.Drawing.Point(0, 0)
        Me.lastStock.Name = "lastStock"
        Me.lastStock.Size = New System.Drawing.Size(1029, 31)
        Me.lastStock.TabIndex = 15
        Me.lastStock.Text = "ข้อมูล ณ ปัจจุบัน ตัด Stock ถึงวันที่ :"
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.Empty
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.ExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpandableSplitter1.ExpandableControl = Me.pnlRight
        Me.ExpandableSplitter1.Expanded = False
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.White
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.White
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.Empty
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.Empty
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.Empty
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(1029, 0)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(23, 653)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Mozilla
        Me.ExpandableSplitter1.TabIndex = 11
        Me.ExpandableSplitter1.TabStop = False
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.gcAdjust)
        Me.pnlRight.Controls.Add(Me.GroupControl2)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(279, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(773, 653)
        Me.pnlRight.TabIndex = 10
        Me.pnlRight.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.grpAdjust)
        Me.GroupControl2.Controls.Add(Me.lbTagID)
        Me.GroupControl2.Controls.Add(Me.lbQtyPerUnit)
        Me.GroupControl2.Controls.Add(Me.lbRatio)
        Me.GroupControl2.Controls.Add(Me.lbMatName)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(773, 252)
        Me.GroupControl2.TabIndex = 14
        Me.GroupControl2.Text = "ปรับยอด"
        '
        'grpAdjust
        '
        Me.grpAdjust.Controls.Add(Me.Label11)
        Me.grpAdjust.Controls.Add(Me.lbU3)
        Me.grpAdjust.Controls.Add(Me.lbU2)
        Me.grpAdjust.Controls.Add(Me.lbU1)
        Me.grpAdjust.Controls.Add(Me.cbStat)
        Me.grpAdjust.Controls.Add(Me.lbUnit3)
        Me.grpAdjust.Controls.Add(Me.Label7)
        Me.grpAdjust.Controls.Add(Me.btnAdJust)
        Me.grpAdjust.Controls.Add(Me.txtUnit3)
        Me.grpAdjust.Controls.Add(Me.txtUnit2)
        Me.grpAdjust.Controls.Add(Me.lbUnit1_Name)
        Me.grpAdjust.Controls.Add(Me.txtUnit1)
        Me.grpAdjust.Controls.Add(Me.txtNotation)
        Me.grpAdjust.Controls.Add(Me.Label10)
        Me.grpAdjust.Controls.Add(Me.lbUnit3_Name)
        Me.grpAdjust.Controls.Add(Me.lbUnit1)
        Me.grpAdjust.Controls.Add(Me.lbQty)
        Me.grpAdjust.Controls.Add(Me.Label9)
        Me.grpAdjust.Controls.Add(Me.Label13)
        Me.grpAdjust.Controls.Add(Me.Label8)
        Me.grpAdjust.Controls.Add(Me.Label2)
        Me.grpAdjust.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpAdjust.Location = New System.Drawing.Point(2, 98)
        Me.grpAdjust.Name = "grpAdjust"
        Me.grpAdjust.ShowCaption = False
        Me.grpAdjust.Size = New System.Drawing.Size(769, 152)
        Me.grpAdjust.TabIndex = 25
        Me.grpAdjust.Text = "GroupControl4"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(405, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 24)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ผลลัพทธ์"
        '
        'lbU3
        '
        Me.lbU3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbU3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbU3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbU3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbU3.ForeColor = System.Drawing.Color.White
        Me.lbU3.Location = New System.Drawing.Point(485, 120)
        Me.lbU3.Name = "lbU3"
        Me.lbU3.Size = New System.Drawing.Size(91, 25)
        Me.lbU3.TabIndex = 26
        Me.lbU3.Text = "Label2"
        '
        'lbU2
        '
        Me.lbU2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbU2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbU2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbU2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbU2.ForeColor = System.Drawing.Color.White
        Me.lbU2.Location = New System.Drawing.Point(485, 93)
        Me.lbU2.Name = "lbU2"
        Me.lbU2.Size = New System.Drawing.Size(91, 25)
        Me.lbU2.TabIndex = 26
        Me.lbU2.Text = "Label2"
        '
        'lbU1
        '
        Me.lbU1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbU1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbU1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbU1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbU1.ForeColor = System.Drawing.Color.White
        Me.lbU1.Location = New System.Drawing.Point(485, 66)
        Me.lbU1.Name = "lbU1"
        Me.lbU1.Size = New System.Drawing.Size(91, 25)
        Me.lbU1.TabIndex = 26
        Me.lbU1.Text = "Label2"
        '
        'cbStat
        '
        Me.cbStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStat.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStat.FormattingEnabled = True
        Me.cbStat.Items.AddRange(New Object() {"คงเหลือ", "หมดแล้ว"})
        Me.cbStat.Location = New System.Drawing.Point(125, 118)
        Me.cbStat.Name = "cbStat"
        Me.cbStat.Size = New System.Drawing.Size(121, 29)
        Me.cbStat.TabIndex = 25
        '
        'lbUnit3
        '
        Me.lbUnit3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbUnit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbUnit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbUnit3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnit3.ForeColor = System.Drawing.Color.White
        Me.lbUnit3.Location = New System.Drawing.Point(125, 37)
        Me.lbUnit3.Name = "lbUnit3"
        Me.lbUnit3.Size = New System.Drawing.Size(91, 25)
        Me.lbUnit3.TabIndex = 12
        Me.lbUnit3.Text = "Label2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label7.Location = New System.Drawing.Point(42, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "จำนวน :"
        '
        'btnAdJust
        '
        Me.btnAdJust.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdJust.Appearance.Options.UseFont = True
        Me.btnAdJust.ImageOptions.Image = CType(resources.GetObject("btnAdJust.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdJust.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdJust.Location = New System.Drawing.Point(277, 118)
        Me.btnAdJust.Name = "btnAdJust"
        Me.btnAdJust.Size = New System.Drawing.Size(122, 29)
        Me.btnAdJust.TabIndex = 24
        Me.btnAdJust.Text = "บันทึก"
        '
        'txtUnit3
        '
        Me.txtUnit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnit3.Location = New System.Drawing.Point(484, 34)
        Me.txtUnit3.Name = "txtUnit3"
        Me.txtUnit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit3.Properties.Appearance.Options.UseFont = True
        Me.txtUnit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit3.Properties.MaxLength = 7
        Me.txtUnit3.Size = New System.Drawing.Size(92, 28)
        Me.txtUnit3.TabIndex = 19
        '
        'txtUnit2
        '
        Me.txtUnit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnit2.Location = New System.Drawing.Point(307, 34)
        Me.txtUnit2.Name = "txtUnit2"
        Me.txtUnit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit2.Properties.Appearance.Options.UseFont = True
        Me.txtUnit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit2.Properties.MaxLength = 7
        Me.txtUnit2.Size = New System.Drawing.Size(92, 28)
        Me.txtUnit2.TabIndex = 19
        '
        'lbUnit1_Name
        '
        Me.lbUnit1_Name.AutoSize = True
        Me.lbUnit1_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUnit1_Name.Location = New System.Drawing.Point(405, 9)
        Me.lbUnit1_Name.Name = "lbUnit1_Name"
        Me.lbUnit1_Name.Size = New System.Drawing.Size(61, 24)
        Me.lbUnit1_Name.TabIndex = 13
        Me.lbUnit1_Name.Text = "จำนวน"
        '
        'txtUnit1
        '
        Me.txtUnit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnit1.Location = New System.Drawing.Point(307, 6)
        Me.txtUnit1.Name = "txtUnit1"
        Me.txtUnit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit1.Properties.Appearance.Options.UseFont = True
        Me.txtUnit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit1.Properties.MaxLength = 7
        Me.txtUnit1.Size = New System.Drawing.Size(92, 28)
        Me.txtUnit1.TabIndex = 19
        '
        'txtNotation
        '
        Me.txtNotation.Location = New System.Drawing.Point(125, 65)
        Me.txtNotation.Name = "txtNotation"
        Me.txtNotation.Size = New System.Drawing.Size(274, 47)
        Me.txtNotation.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(486, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 24)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "จำนวนดวง"
        '
        'lbUnit3_Name
        '
        Me.lbUnit3_Name.AutoSize = True
        Me.lbUnit3_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUnit3_Name.Location = New System.Drawing.Point(405, 37)
        Me.lbUnit3_Name.Name = "lbUnit3_Name"
        Me.lbUnit3_Name.Size = New System.Drawing.Size(63, 24)
        Me.lbUnit3_Name.TabIndex = 13
        Me.lbUnit3_Name.Text = "ปริมาณ"
        '
        'lbUnit1
        '
        Me.lbUnit1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbUnit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbUnit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbUnit1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnit1.ForeColor = System.Drawing.Color.White
        Me.lbUnit1.Location = New System.Drawing.Point(125, 9)
        Me.lbUnit1.Name = "lbUnit1"
        Me.lbUnit1.Size = New System.Drawing.Size(91, 25)
        Me.lbUnit1.TabIndex = 12
        Me.lbUnit1.Text = "Label2"
        '
        'lbQty
        '
        Me.lbQty.AutoSize = True
        Me.lbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty.Location = New System.Drawing.Point(223, 9)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(79, 24)
        Me.lbQty.TabIndex = 13
        Me.lbQty.Text = "ปรับเป็น :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label9.Location = New System.Drawing.Point(42, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "สถานะ :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label13.Location = New System.Drawing.Point(21, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 23)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "หมายเหตุ :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label8.Location = New System.Drawing.Point(9, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "เป็นปริมาณ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ปรับเป็น :"
        '
        'lbTagID
        '
        Me.lbTagID.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbTagID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTagID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTagID.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTagID.ForeColor = System.Drawing.Color.White
        Me.lbTagID.Location = New System.Drawing.Point(127, 65)
        Me.lbTagID.Name = "lbTagID"
        Me.lbTagID.Size = New System.Drawing.Size(177, 25)
        Me.lbTagID.TabIndex = 12
        Me.lbTagID.Text = "Label2"
        '
        'lbQtyPerUnit
        '
        Me.lbQtyPerUnit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbQtyPerUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQtyPerUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbQtyPerUnit.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQtyPerUnit.ForeColor = System.Drawing.Color.White
        Me.lbQtyPerUnit.Location = New System.Drawing.Point(411, 66)
        Me.lbQtyPerUnit.Name = "lbQtyPerUnit"
        Me.lbQtyPerUnit.Size = New System.Drawing.Size(90, 25)
        Me.lbQtyPerUnit.TabIndex = 12
        Me.lbQtyPerUnit.Text = "Label2"
        '
        'lbRatio
        '
        Me.lbRatio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbRatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbRatio.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRatio.ForeColor = System.Drawing.Color.White
        Me.lbRatio.Location = New System.Drawing.Point(411, 37)
        Me.lbRatio.Name = "lbRatio"
        Me.lbRatio.Size = New System.Drawing.Size(90, 25)
        Me.lbRatio.TabIndex = 12
        Me.lbRatio.Text = "Label2"
        '
        'lbMatName
        '
        Me.lbMatName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbMatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbMatName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMatName.ForeColor = System.Drawing.Color.White
        Me.lbMatName.Location = New System.Drawing.Point(127, 37)
        Me.lbMatName.Name = "lbMatName"
        Me.lbMatName.Size = New System.Drawing.Size(177, 25)
        Me.lbMatName.TabIndex = 12
        Me.lbMatName.Text = "Label2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label12.Location = New System.Drawing.Point(327, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 23)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "QtyPer :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label5.Location = New System.Drawing.Point(46, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "TagID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label6.Location = New System.Drawing.Point(340, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ratio :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label4.Location = New System.Drawing.Point(65, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "วัสดุ :"
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 653)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FrmStock"
        Me.Text = "วัสดุคงคลัง ณ ปัจจุบัน"
        CType(Me.gcAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAdjust, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.grpAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdjust.ResumeLayout(False)
        Me.grpAdjust.PerformLayout()
        CType(Me.txtUnit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gcAdjust As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAdjust As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents pnlRight As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lastStock As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtUnit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtUnit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbQty As Label
    Friend WithEvents lbUnit3_Name As Label
    Friend WithEvents lbUnit1_Name As Label
    Friend WithEvents lbTagID As Label
    Friend WithEvents lbMatName As Label
    Friend WithEvents txtNotation As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbUnit3 As Label
    Friend WithEvents lbUnit1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdJust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbRatio As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grpAdjust As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label9 As Label
    Friend WithEvents cbStat As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbU3 As Label
    Friend WithEvents lbU2 As Label
    Friend WithEvents lbU1 As Label
    Friend WithEvents txtUnit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label10 As Label
    Friend WithEvents lbQtyPerUnit As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents gcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
End Class
