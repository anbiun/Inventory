<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMatStock))
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim DoughnutSeriesLabel2 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel()
        Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(501.0R, New Object() {CType(6.8R, Object), CType(6.8R, Object), CType(6.8R, Object), CType(6.8R, Object)}, 0)
        Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(502.0R, New Object() {CType(5.7R, Object), CType(5.7R, Object), CType(5.7R, Object), CType(5.7R, Object)}, 1)
        Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(171.0R, New Object() {CType(6.8R, Object), CType(6.8R, Object), CType(6.8R, Object), CType(6.8R, Object)}, 2)
        Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(4412.0R, New Object() {CType(4.5R, Object), CType(4.5R, Object), CType(4.5R, Object), CType(4.5R, Object)}, 3)
        Dim DoughnutSeriesView2 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView(New Integer() {1})
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcMatList = New DevExpress.XtraGrid.GridControl()
        Me.gvMatList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.RDGrp = New DevExpress.XtraEditors.RadioGroup()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.luLocation = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.luSubCat = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.eDate = New DevExpress.XtraEditors.DateEdit()
        Me.sDate = New DevExpress.XtraEditors.DateEdit()
        Me.cctrl = New DevExpress.XtraCharts.ChartControl()
        Me.txtMatID = New System.Windows.Forms.TextBox()
        Me.gcBomMat = New DevExpress.XtraGrid.GridControl()
        Me.gvBomMat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gvMatImport = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInsert = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.deBomDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtBomID = New System.Windows.Forms.TextBox()
        Me.sluBom = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBomQty = New System.Windows.Forms.TextBox()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCalculate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBomManager = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcMatList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMatList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.RDGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.luLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luSubCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cctrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DoughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcBomMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBomMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMatImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.deBomDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deBomDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluBom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cctrl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1378, 806)
        Me.SplitContainerControl1.SplitterPosition = 1147
        Me.SplitContainerControl1.TabIndex = 17
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.gcMatList)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 191)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1370, 607)
        Me.GroupControl3.TabIndex = 11
        Me.GroupControl3.Text = "คงคลัง"
        '
        'gcMatList
        '
        Me.gcMatList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMatList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcMatList.Location = New System.Drawing.Point(2, 25)
        Me.gcMatList.MainView = Me.gvMatList
        Me.gcMatList.Margin = New System.Windows.Forms.Padding(4)
        Me.gcMatList.Name = "gcMatList"
        Me.gcMatList.Size = New System.Drawing.Size(1366, 580)
        Me.gcMatList.TabIndex = 8
        Me.gcMatList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMatList})
        '
        'gvMatList
        '
        Me.gvMatList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvMatList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMatList.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvMatList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvMatList.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvMatList.Appearance.Row.Options.UseFont = True
        Me.gvMatList.FixedLineWidth = 1
        Me.gvMatList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvMatList.GridControl = Me.gcMatList
        Me.gvMatList.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvMatList.Name = "gvMatList"
        Me.gvMatList.OptionsBehavior.Editable = False
        Me.gvMatList.OptionsCustomization.AllowSort = False
        Me.gvMatList.OptionsFind.AllowFindPanel = False
        Me.gvMatList.OptionsFind.ClearFindOnClose = False
        Me.gvMatList.OptionsFind.FindDelay = 100
        Me.gvMatList.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvMatList.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvMatList.OptionsFind.ShowClearButton = False
        Me.gvMatList.OptionsFind.ShowFindButton = False
        Me.gvMatList.OptionsView.ColumnAutoWidth = False
        Me.gvMatList.OptionsView.ShowGroupPanel = False
        Me.gvMatList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.btnPrint)
        Me.GroupControl1.Controls.Add(Me.btnExportExcel)
        Me.GroupControl1.Controls.Add(Me.GroupControl5)
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1370, 191)
        Me.GroupControl1.TabIndex = 16
        Me.GroupControl1.Text = "ค้นหาข้อมูล"
        '
        'btnPrint
        '
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(358, 129)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(169, 43)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "พิมพ์ข้อมูล"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.ImageOptions.Image = CType(resources.GetObject("btnExportExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportExcel.Location = New System.Drawing.Point(358, 79)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(169, 43)
        Me.btnExportExcel.TabIndex = 19
        Me.btnExportExcel.Text = "Export to Excel"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.RDGrp)
        Me.GroupControl5.Location = New System.Drawing.Point(546, 40)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(303, 143)
        Me.GroupControl5.TabIndex = 18
        Me.GroupControl5.Text = "เลือกรูปแบบการค้นหา"
        Me.GroupControl5.Visible = False
        '
        'RDGrp
        '
        Me.RDGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RDGrp.Location = New System.Drawing.Point(2, 31)
        Me.RDGrp.Name = "RDGrp"
        Me.RDGrp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.RDGrp.Properties.Appearance.Options.UseFont = True
        Me.RDGrp.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "ยอดรวมทั้งหมดต่อวัสดุ")})
        Me.RDGrp.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.RDGrp.Size = New System.Drawing.Size(299, 110)
        Me.RDGrp.TabIndex = 16
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.luLocation)
        Me.GroupControl4.Controls.Add(Me.Label1)
        Me.GroupControl4.Controls.Add(Me.Label2)
        Me.GroupControl4.Controls.Add(Me.luSubCat)
        Me.GroupControl4.Controls.Add(Me.Label3)
        Me.GroupControl4.Controls.Add(Me.eDate)
        Me.GroupControl4.Controls.Add(Me.sDate)
        Me.GroupControl4.Location = New System.Drawing.Point(39, 40)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(313, 143)
        Me.GroupControl4.TabIndex = 17
        Me.GroupControl4.Text = "เลือกช่วงข้อมูล"
        '
        'luLocation
        '
        Me.luLocation.Location = New System.Drawing.Point(126, 68)
        Me.luLocation.Name = "luLocation"
        Me.luLocation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.luLocation.Properties.Appearance.Options.UseFont = True
        Me.luLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luLocation.Size = New System.Drawing.Size(182, 28)
        Me.luLocation.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(31, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "คลังวัสดุ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label2.Location = New System.Drawing.Point(78, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ถึงวันที่ :"
        Me.Label2.Visible = False
        '
        'luSubCat
        '
        Me.luSubCat.Location = New System.Drawing.Point(128, 36)
        Me.luSubCat.Name = "luSubCat"
        Me.luSubCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.luSubCat.Properties.Appearance.Options.UseFont = True
        Me.luSubCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luSubCat.Size = New System.Drawing.Size(180, 28)
        Me.luSubCat.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label3.Location = New System.Drawing.Point(5, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ประเภทวัสดุ :"
        '
        'eDate
        '
        Me.eDate.EditValue = Nothing
        Me.eDate.Location = New System.Drawing.Point(162, 104)
        Me.eDate.Name = "eDate"
        Me.eDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.eDate.Properties.Appearance.Options.UseFont = True
        Me.eDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Size = New System.Drawing.Size(146, 28)
        Me.eDate.TabIndex = 12
        Me.eDate.Visible = False
        '
        'sDate
        '
        Me.sDate.EditValue = Nothing
        Me.sDate.Location = New System.Drawing.Point(162, 70)
        Me.sDate.Name = "sDate"
        Me.sDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.sDate.Properties.Appearance.Options.UseFont = True
        Me.sDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sDate.Size = New System.Drawing.Size(146, 28)
        Me.sDate.TabIndex = 12
        Me.sDate.Visible = False
        '
        'cctrl
        '
        Me.cctrl.AppearanceNameSerializable = "In A Fog"
        Me.cctrl.AutoLayout = False
        Me.cctrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cctrl.BorderOptions.Color = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cctrl.BorderOptions.Thickness = 7
        Me.cctrl.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.cctrl.DataBindings = Nothing
        Me.cctrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cctrl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
        Me.cctrl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
        Me.cctrl.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.cctrl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.cctrl.Legend.Name = "Default Legend"
        Me.cctrl.Location = New System.Drawing.Point(0, 0)
        Me.cctrl.Name = "cctrl"
        Me.cctrl.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series2.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Series2.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.[True]
        Series2.CrosshairLabelPattern = "{A}"
        Series2.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.[True]
        DoughnutSeriesLabel2.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        DoughnutSeriesLabel2.TextPattern = "{V}"
        Series2.Label = DoughnutSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.LegendTextPattern = "{A}"
        Series2.Name = "Series 1"
        Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint5, SeriesPoint6, SeriesPoint7, SeriesPoint8})
        Series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
        Series2.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        DoughnutSeriesView2.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.UsePoints
        Series2.View = DoughnutSeriesView2
        Me.cctrl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.cctrl.Size = New System.Drawing.Size(0, 0)
        Me.cctrl.TabIndex = 14
        Me.cctrl.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Me.cctrl.ToolTipOptions.ShowForSeries = True
        '
        'txtMatID
        '
        Me.txtMatID.Enabled = False
        Me.txtMatID.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.txtMatID.Location = New System.Drawing.Point(530, 358)
        Me.txtMatID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatID.Name = "txtMatID"
        Me.txtMatID.Size = New System.Drawing.Size(132, 28)
        Me.txtMatID.TabIndex = 0
        Me.txtMatID.Visible = False
        '
        'gcBomMat
        '
        Me.gcBomMat.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcBomMat.Location = New System.Drawing.Point(6, 183)
        Me.gcBomMat.MainView = Me.gvBomMat
        Me.gcBomMat.Margin = New System.Windows.Forms.Padding(4)
        Me.gcBomMat.Name = "gcBomMat"
        Me.gcBomMat.Size = New System.Drawing.Size(412, 246)
        Me.gcBomMat.TabIndex = 6
        Me.gcBomMat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBomMat})
        '
        'gvBomMat
        '
        Me.gvBomMat.GridControl = Me.gcBomMat
        Me.gvBomMat.Name = "gvBomMat"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'gvMatImport
        '
        Me.gvMatImport.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvMatImport.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMatImport.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvMatImport.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvMatImport.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvMatImport.Appearance.Row.Options.UseFont = True
        Me.gvMatImport.FixedLineWidth = 1
        Me.gvMatImport.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvMatImport.GridControl = Me.GridControl1
        Me.gvMatImport.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvMatImport.Name = "gvMatImport"
        Me.gvMatImport.OptionsBehavior.Editable = False
        Me.gvMatImport.OptionsFind.AllowFindPanel = False
        Me.gvMatImport.OptionsFind.ClearFindOnClose = False
        Me.gvMatImport.OptionsFind.FindDelay = 100
        Me.gvMatImport.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvMatImport.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvMatImport.OptionsFind.ShowClearButton = False
        Me.gvMatImport.OptionsFind.ShowFindButton = False
        Me.gvMatImport.OptionsView.ColumnAutoWidth = False
        Me.gvMatImport.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Location = New System.Drawing.Point(6, 180)
        Me.GridControl1.MainView = Me.gvMatImport
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(956, 596)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMatImport})
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(500, 542)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 46)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(500, 490)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 46)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.Visible = False
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(500, 439)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(95, 46)
        Me.btnInsert.TabIndex = 7
        Me.btnInsert.Text = "เพิ่ม"
        Me.btnInsert.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(467, 361)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 21)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "รหัสวัสดุ"
        Me.LabelControl3.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.gcBomMat)
        Me.GroupControl2.Controls.Add(Me.deBomDate)
        Me.GroupControl2.Controls.Add(Me.txtBomID)
        Me.GroupControl2.Controls.Add(Me.sluBom)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.txtBomQty)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.btnCalculate)
        Me.GroupControl2.Controls.Add(Me.btnBomManager)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 361)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(429, 434)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "GroupControl2"
        Me.GroupControl2.Visible = False
        '
        'deBomDate
        '
        Me.deBomDate.EditValue = Nothing
        Me.deBomDate.Location = New System.Drawing.Point(125, 134)
        Me.deBomDate.Name = "deBomDate"
        Me.deBomDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.deBomDate.Properties.Appearance.Options.UseFont = True
        Me.deBomDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deBomDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deBomDate.Size = New System.Drawing.Size(132, 28)
        Me.deBomDate.TabIndex = 10
        '
        'txtBomID
        '
        Me.txtBomID.Enabled = False
        Me.txtBomID.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.txtBomID.Location = New System.Drawing.Point(125, 30)
        Me.txtBomID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBomID.Name = "txtBomID"
        Me.txtBomID.Size = New System.Drawing.Size(132, 28)
        Me.txtBomID.TabIndex = 0
        '
        'sluBom
        '
        Me.sluBom.Location = New System.Drawing.Point(125, 65)
        Me.sluBom.Name = "sluBom"
        Me.sluBom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.sluBom.Properties.Appearance.Options.UseFont = True
        Me.sluBom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluBom.Properties.View = Me.GridView4
        Me.sluBom.Size = New System.Drawing.Size(132, 28)
        Me.sluBom.TabIndex = 6
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(31, 33)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(73, 21)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "รหัส BOM."
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(37, 67)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(66, 21)
        Me.LabelControl11.TabIndex = 9
        Me.LabelControl11.Text = "ชื่อ BOM."
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(58, 103)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(45, 21)
        Me.LabelControl12.TabIndex = 9
        Me.LabelControl12.Text = "จำนวน"
        '
        'txtBomQty
        '
        Me.txtBomQty.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.txtBomQty.Location = New System.Drawing.Point(125, 100)
        Me.txtBomQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBomQty.Name = "txtBomQty"
        Me.txtBomQty.Size = New System.Drawing.Size(46, 28)
        Me.txtBomQty.TabIndex = 0
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(53, 137)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(50, 21)
        Me.LabelControl13.TabIndex = 9
        Me.LabelControl13.Text = "วันที่ตัด"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(307, 116)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 46)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "ตัดสตอก"
        '
        'btnBomManager
        '
        Me.btnBomManager.Location = New System.Drawing.Point(307, 46)
        Me.btnBomManager.Name = "btnBomManager"
        Me.btnBomManager.Size = New System.Drawing.Size(95, 46)
        Me.btnBomManager.TabIndex = 7
        Me.btnBomManager.Text = "จัดการ BOM."
        '
        'FrmMatStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 806)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.txtMatID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMatStock"
        Me.Text = "วัสดุคงคลัง"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcMatList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMatList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.RDGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.luLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luSubCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DoughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cctrl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcBomMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBomMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMatImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.deBomDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deBomDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluBom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMatID As System.Windows.Forms.TextBox
    Friend WithEvents gcBomMat As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBomMat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcMatList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMatList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnInsert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deBomDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtBomID As System.Windows.Forms.TextBox
    Friend WithEvents sluBom As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBomQty As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCalculate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBomManager As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gvMatImport As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents sDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cctrl As DevExpress.XtraCharts.ChartControl
    Friend WithEvents luSubCat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents RDGrp As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents luLocation As DevExpress.XtraEditors.LookUpEdit
End Class
