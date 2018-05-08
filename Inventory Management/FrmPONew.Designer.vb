<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPONew
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
        Me.grpPoList = New DevExpress.XtraEditors.GroupControl()
        Me.sluSubCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deDelivery = New DevExpress.XtraEditors.DateEdit()
        Me.btnNewOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.sluSupplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtUnit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.sluMat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblUnit1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblUnit3_name = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.grpPoOrder = New DevExpress.XtraEditors.GroupControl()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PnlSave = New DevExpress.XtraEditors.PanelControl()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.PnlLeft = New DevExpress.XtraEditors.PanelControl()
        CType(Me.grpPoList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPoList.SuspendLayout()
        CType(Me.sluSubCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDelivery.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDelivery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluMat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPoOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPoOrder.SuspendLayout()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSave.SuspendLayout()
        CType(Me.PnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPoList
        '
        Me.grpPoList.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPoList.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.grpPoList.AppearanceCaption.Options.UseFont = True
        Me.grpPoList.AppearanceCaption.Options.UseForeColor = True
        Me.grpPoList.Controls.Add(Me.sluSubCat)
        Me.grpPoList.Controls.Add(Me.deDelivery)
        Me.grpPoList.Controls.Add(Me.btnNewOrder)
        Me.grpPoList.Controls.Add(Me.sluSupplier)
        Me.grpPoList.Controls.Add(Me.deDate)
        Me.grpPoList.Controls.Add(Me.txtPO)
        Me.grpPoList.Controls.Add(Me.LabelControl11)
        Me.grpPoList.Controls.Add(Me.LabelControl1)
        Me.grpPoList.Controls.Add(Me.LabelControl3)
        Me.grpPoList.Controls.Add(Me.LabelControl4)
        Me.grpPoList.Controls.Add(Me.LabelControl2)
        Me.grpPoList.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPoList.Location = New System.Drawing.Point(0, 0)
        Me.grpPoList.Name = "grpPoList"
        Me.grpPoList.Size = New System.Drawing.Size(366, 247)
        Me.grpPoList.TabIndex = 20
        Me.grpPoList.Text = "ข้อมูลใบสั่งซื้อ"
        '
        'sluSubCat
        '
        Me.sluSubCat.EditValue = ""
        Me.sluSubCat.Location = New System.Drawing.Point(142, 171)
        Me.sluSubCat.Name = "sluSubCat"
        Me.sluSubCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sluSubCat.Properties.Appearance.Options.UseFont = True
        Me.sluSubCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluSubCat.Properties.NullText = ""
        Me.sluSubCat.Properties.View = Me.GridView1
        Me.sluSubCat.Size = New System.Drawing.Size(193, 28)
        Me.sluSubCat.TabIndex = 13
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'deDelivery
        '
        Me.deDelivery.EditValue = Nothing
        Me.deDelivery.Location = New System.Drawing.Point(142, 137)
        Me.deDelivery.Name = "deDelivery"
        Me.deDelivery.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deDelivery.Properties.Appearance.Options.UseFont = True
        Me.deDelivery.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDelivery.Size = New System.Drawing.Size(193, 28)
        Me.deDelivery.TabIndex = 23
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnNewOrder.Appearance.Options.UseFont = True
        Me.btnNewOrder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnNewOrder.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_32x32
        Me.btnNewOrder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnNewOrder.Location = New System.Drawing.Point(142, 206)
        Me.btnNewOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(193, 35)
        Me.btnNewOrder.TabIndex = 23
        Me.btnNewOrder.Text = "ตกลง"
        '
        'sluSupplier
        '
        Me.sluSupplier.EditValue = ""
        Me.sluSupplier.Location = New System.Drawing.Point(142, 33)
        Me.sluSupplier.Name = "sluSupplier"
        Me.sluSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sluSupplier.Properties.Appearance.Options.UseFont = True
        Me.sluSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluSupplier.Properties.NullText = ""
        Me.sluSupplier.Properties.View = Me.GridView3
        Me.sluSupplier.Size = New System.Drawing.Size(193, 28)
        Me.sluSupplier.TabIndex = 17
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.Location = New System.Drawing.Point(142, 67)
        Me.deDate.Name = "deDate"
        Me.deDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deDate.Properties.Appearance.Options.UseFont = True
        Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Size = New System.Drawing.Size(193, 28)
        Me.deDate.TabIndex = 23
        '
        'txtPO
        '
        Me.txtPO.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO.Location = New System.Drawing.Point(142, 102)
        Me.txtPO.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPO.MaxLength = 10
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(193, 28)
        Me.txtPO.TabIndex = 21
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(81, 36)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(46, 21)
        Me.LabelControl11.TabIndex = 18
        Me.LabelControl11.Text = "ผู้ขาย"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(97, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 21)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Text = "วันที่"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(0, 174)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(127, 21)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "ประเภทวัสดุ"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(32, 140)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(95, 21)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "กำหนดส่งของ"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(63, 105)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 21)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "เลขที่ PO"
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gcList.Location = New System.Drawing.Point(366, 0)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Margin = New System.Windows.Forms.Padding(4)
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(603, 537)
        Me.gcList.TabIndex = 8
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList})
        '
        'gvList
        '
        Me.gvList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvList.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvList.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvList.Appearance.Row.Options.UseFont = True
        Me.gvList.FixedLineWidth = 1
        Me.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.Editable = False
        Me.gvList.OptionsFind.AllowFindPanel = False
        Me.gvList.OptionsFind.ClearFindOnClose = False
        Me.gvList.OptionsFind.FindDelay = 100
        Me.gvList.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvList.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvList.OptionsFind.ShowClearButton = False
        Me.gvList.OptionsFind.ShowFindButton = False
        Me.gvList.OptionsView.ColumnAutoWidth = False
        Me.gvList.OptionsView.ShowGroupPanel = False
        Me.gvList.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        Me.gvList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'txtUnit1
        '
        Me.txtUnit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnit1.Location = New System.Drawing.Point(142, 64)
        Me.txtUnit1.Name = "txtUnit1"
        Me.txtUnit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit1.Properties.Appearance.Options.UseFont = True
        Me.txtUnit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit1.Properties.MaxLength = 6
        Me.txtUnit1.Size = New System.Drawing.Size(116, 28)
        Me.txtUnit1.TabIndex = 16
        '
        'sluMat
        '
        Me.sluMat.EditValue = ""
        Me.sluMat.Location = New System.Drawing.Point(142, 30)
        Me.sluMat.Name = "sluMat"
        Me.sluMat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sluMat.Properties.Appearance.Options.UseFont = True
        Me.sluMat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluMat.Properties.NullText = ""
        Me.sluMat.Properties.View = Me.SearchLookUpEdit1View
        Me.sluMat.Size = New System.Drawing.Size(193, 28)
        Me.sluMat.TabIndex = 14
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'lblUnit1
        '
        Me.lblUnit1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit1.Appearance.Options.UseFont = True
        Me.lblUnit1.Appearance.Options.UseTextOptions = True
        Me.lblUnit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUnit1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUnit1.Location = New System.Drawing.Point(52, 67)
        Me.lblUnit1.Name = "lblUnit1"
        Me.lblUnit1.Size = New System.Drawing.Size(71, 21)
        Me.lblUnit1.TabIndex = 19
        Me.lblUnit1.Text = "จำนวน"
        '
        'lblUnit3_name
        '
        Me.lblUnit3_name.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit3_name.Appearance.Options.UseFont = True
        Me.lblUnit3_name.Location = New System.Drawing.Point(264, 67)
        Me.lblUnit3_name.Name = "lblUnit3_name"
        Me.lblUnit3_name.Size = New System.Drawing.Size(21, 21)
        Me.lblUnit3_name.TabIndex = 21
        Me.lblUnit3_name.Text = "ชิ้น"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(74, 33)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(49, 21)
        Me.LabelControl13.TabIndex = 22
        Me.LabelControl13.Text = "ชื่อวัสดุ"
        '
        'grpPoOrder
        '
        Me.grpPoOrder.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPoOrder.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.grpPoOrder.AppearanceCaption.Options.UseFont = True
        Me.grpPoOrder.AppearanceCaption.Options.UseForeColor = True
        Me.grpPoOrder.Controls.Add(Me.btnRemove)
        Me.grpPoOrder.Controls.Add(Me.btnAdd)
        Me.grpPoOrder.Controls.Add(Me.LabelControl13)
        Me.grpPoOrder.Controls.Add(Me.sluMat)
        Me.grpPoOrder.Controls.Add(Me.lblUnit1)
        Me.grpPoOrder.Controls.Add(Me.txtUnit1)
        Me.grpPoOrder.Controls.Add(Me.lblUnit3_name)
        Me.grpPoOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPoOrder.Location = New System.Drawing.Point(0, 247)
        Me.grpPoOrder.Name = "grpPoOrder"
        Me.grpPoOrder.Size = New System.Drawing.Size(366, 156)
        Me.grpPoOrder.TabIndex = 20
        Me.grpPoOrder.Text = "เพิ่มรายการวัสดุ"
        '
        'btnRemove
        '
        Me.btnRemove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRemove.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.backward_16x16
        Me.btnRemove.Location = New System.Drawing.Point(74, 105)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(125, 27)
        Me.btnRemove.TabIndex = 22
        Me.btnRemove.Text = " ลบจากรายการ"
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.forward_16x161
        Me.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(209, 105)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 27)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "เพิ่มรายการ"
        '
        'PnlSave
        '
        Me.PnlSave.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PnlSave.Appearance.Options.UseBackColor = True
        Me.PnlSave.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnlSave.Controls.Add(Me.BtnSave)
        Me.PnlSave.Controls.Add(Me.BtnCancel)
        Me.PnlSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSave.Location = New System.Drawing.Point(0, 403)
        Me.PnlSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlSave.Name = "PnlSave"
        Me.PnlSave.Size = New System.Drawing.Size(366, 134)
        Me.PnlSave.TabIndex = 23
        Me.PnlSave.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnSave.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.download_32x32
        Me.BtnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(210, 4)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(125, 35)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "บันทึก"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnCancel.Appearance.Options.UseFont = True
        Me.BtnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnCancel.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.undo_16x16
        Me.BtnCancel.Location = New System.Drawing.Point(74, 4)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(125, 35)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "ยกเลิก"
        '
        'PnlLeft
        '
        Me.PnlLeft.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PnlLeft.Appearance.Options.UseBackColor = True
        Me.PnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnlLeft.Controls.Add(Me.PnlSave)
        Me.PnlLeft.Controls.Add(Me.grpPoOrder)
        Me.PnlLeft.Controls.Add(Me.grpPoList)
        Me.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.PnlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Size = New System.Drawing.Size(366, 537)
        Me.PnlLeft.TabIndex = 23
        '
        'FrmPONew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 537)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.PnlLeft)
        Me.Name = "FrmPONew"
        Me.Text = "เปิด PO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grpPoList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPoList.ResumeLayout(False)
        Me.grpPoList.PerformLayout()
        CType(Me.sluSubCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDelivery.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDelivery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluMat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPoOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPoOrder.ResumeLayout(False)
        Me.grpPoOrder.PerformLayout()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSave.ResumeLayout(False)
        CType(Me.PnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPoList As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sluSubCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtUnit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents sluMat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sluSupplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblUnit1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUnit3_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPO As TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDelivery As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpPoOrder As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnNewOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PnlSave As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PnlLeft As DevExpress.XtraEditors.PanelControl
End Class
