<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransfer))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransferNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.deDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.slTagID = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grpRequest = New DevExpress.XtraEditors.GroupControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.lbUserStock = New System.Windows.Forms.Label()
        Me.lbUnit3Name = New System.Windows.Forms.Label()
        Me.lbVol = New System.Windows.Forms.Label()
        Me.lbUnit1Name = New System.Windows.Forms.Label()
        Me.lbQty = New System.Windows.Forms.Label()
        Me.PnlSave = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.grpMat = New DevExpress.XtraEditors.GroupControl()
        Me.pnlRD1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtUnit3 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtUnit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.slLocDest = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransferNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slTagID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequest.SuspendLayout()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSave.SuspendLayout()
        CType(Me.grpMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMat.SuspendLayout()
        CType(Me.pnlRD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRD1.SuspendLayout()
        CType(Me.txtUnit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        CType(Me.slLocDest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.gcList)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(348, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(609, 742)
        Me.GroupControl3.TabIndex = 12
        Me.GroupControl3.Text = "รายการโอนวัสดุ"
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcList.Location = New System.Drawing.Point(2, 31)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Margin = New System.Windows.Forms.Padding(4)
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(605, 709)
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
        Me.gvList.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.Editable = False
        Me.gvList.OptionsCustomization.AllowSort = False
        Me.gvList.OptionsFind.AllowFindPanel = False
        Me.gvList.OptionsFind.ClearFindOnClose = False
        Me.gvList.OptionsFind.FindDelay = 100
        Me.gvList.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvList.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvList.OptionsFind.ShowClearButton = False
        Me.gvList.OptionsFind.ShowFindButton = False
        Me.gvList.OptionsView.ColumnAutoWidth = False
        Me.gvList.OptionsView.ShowGroupPanel = False
        Me.gvList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ผู้ทำรายการ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "เลขที่เอกสาร"
        '
        'txtTransferNo
        '
        Me.txtTransferNo.AllowDrop = True
        Me.txtTransferNo.Location = New System.Drawing.Point(160, 72)
        Me.txtTransferNo.Name = "txtTransferNo"
        Me.txtTransferNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferNo.Properties.Appearance.Options.UseFont = True
        Me.txtTransferNo.Size = New System.Drawing.Size(124, 28)
        Me.txtTransferNo.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "เลข Tag."
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.Location = New System.Drawing.Point(160, 38)
        Me.deDate.Name = "deDate"
        Me.deDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deDate.Properties.Appearance.Options.UseFont = True
        Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Size = New System.Drawing.Size(124, 28)
        Me.deDate.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "วันที่"
        '
        'btnRemove
        '
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(114, 211)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(124, 27)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = " ลบจากรายการ"
        '
        'btnAdd
        '
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(114, 176)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 27)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "เพิ่มรายการ"
        '
        'slTagID
        '
        Me.slTagID.EditValue = ""
        Me.slTagID.Location = New System.Drawing.Point(113, 37)
        Me.slTagID.Name = "slTagID"
        Me.slTagID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slTagID.Properties.Appearance.Options.UseFont = True
        Me.slTagID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slTagID.Properties.View = Me.SearchLookUpEdit1View
        Me.slTagID.Size = New System.Drawing.Size(124, 28)
        Me.slTagID.TabIndex = 18
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grpRequest
        '
        Me.grpRequest.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRequest.AppearanceCaption.Options.UseFont = True
        Me.grpRequest.Controls.Add(Me.Label5)
        Me.grpRequest.Controls.Add(Me.Label1)
        Me.grpRequest.Controls.Add(Me.btnNew)
        Me.grpRequest.Controls.Add(Me.lbUserStock)
        Me.grpRequest.Controls.Add(Me.Label3)
        Me.grpRequest.Controls.Add(Me.slLocDest)
        Me.grpRequest.Controls.Add(Me.Label2)
        Me.grpRequest.Controls.Add(Me.txtTransferNo)
        Me.grpRequest.Controls.Add(Me.deDate)
        Me.grpRequest.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRequest.Location = New System.Drawing.Point(0, 0)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(348, 220)
        Me.grpRequest.TabIndex = 19
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnNew.Location = New System.Drawing.Point(160, 169)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(124, 38)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "ตกลง"
        '
        'lbUserStock
        '
        Me.lbUserStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbUserStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUserStock.Location = New System.Drawing.Point(160, 137)
        Me.lbUserStock.Name = "lbUserStock"
        Me.lbUserStock.Size = New System.Drawing.Size(124, 24)
        Me.lbUserStock.TabIndex = 13
        Me.lbUserStock.Text = "ปริมาณ"
        '
        'lbUnit3Name
        '
        Me.lbUnit3Name.AutoSize = True
        Me.lbUnit3Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUnit3Name.Location = New System.Drawing.Point(224, 49)
        Me.lbUnit3Name.Name = "lbUnit3Name"
        Me.lbUnit3Name.Size = New System.Drawing.Size(63, 24)
        Me.lbUnit3Name.TabIndex = 13
        Me.lbUnit3Name.Text = "ปริมาณ"
        '
        'lbVol
        '
        Me.lbVol.AutoSize = True
        Me.lbVol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbVol.Location = New System.Drawing.Point(28, 49)
        Me.lbVol.Name = "lbVol"
        Me.lbVol.Size = New System.Drawing.Size(38, 24)
        Me.lbVol.TabIndex = 13
        Me.lbVol.Text = "เศษ"
        '
        'lbUnit1Name
        '
        Me.lbUnit1Name.AutoSize = True
        Me.lbUnit1Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUnit1Name.Location = New System.Drawing.Point(224, 14)
        Me.lbUnit1Name.Name = "lbUnit1Name"
        Me.lbUnit1Name.Size = New System.Drawing.Size(61, 24)
        Me.lbUnit1Name.TabIndex = 13
        Me.lbUnit1Name.Text = "จำนวน"
        '
        'lbQty
        '
        Me.lbQty.AutoSize = True
        Me.lbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty.Location = New System.Drawing.Point(5, 12)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(61, 24)
        Me.lbQty.TabIndex = 13
        Me.lbQty.Text = "จำนวน"
        '
        'PnlSave
        '
        Me.PnlSave.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PnlSave.Appearance.Options.UseBackColor = True
        Me.PnlSave.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnlSave.Controls.Add(Me.btnSave)
        Me.PnlSave.Controls.Add(Me.btnCancel)
        Me.PnlSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSave.Location = New System.Drawing.Point(0, 476)
        Me.PnlSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlSave.Name = "PnlSave"
        Me.PnlSave.Size = New System.Drawing.Size(348, 266)
        Me.PnlSave.TabIndex = 20
        Me.PnlSave.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(191, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 35)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "บันทึก"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(93, 7)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 35)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "ยกเลิก"
        '
        'grpMat
        '
        Me.grpMat.Controls.Add(Me.pnlRD1)
        Me.grpMat.Controls.Add(Me.Label4)
        Me.grpMat.Controls.Add(Me.btnAdd)
        Me.grpMat.Controls.Add(Me.btnRemove)
        Me.grpMat.Controls.Add(Me.slTagID)
        Me.grpMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpMat.Enabled = False
        Me.grpMat.Location = New System.Drawing.Point(0, 220)
        Me.grpMat.Name = "grpMat"
        Me.grpMat.Size = New System.Drawing.Size(348, 256)
        Me.grpMat.TabIndex = 21
        '
        'pnlRD1
        '
        Me.pnlRD1.Controls.Add(Me.txtUnit3)
        Me.pnlRD1.Controls.Add(Me.txtUnit1)
        Me.pnlRD1.Controls.Add(Me.lbVol)
        Me.pnlRD1.Controls.Add(Me.lbQty)
        Me.pnlRD1.Controls.Add(Me.lbUnit3Name)
        Me.pnlRD1.Controls.Add(Me.lbUnit1Name)
        Me.pnlRD1.Location = New System.Drawing.Point(20, 76)
        Me.pnlRD1.Name = "pnlRD1"
        Me.pnlRD1.Size = New System.Drawing.Size(310, 86)
        Me.pnlRD1.TabIndex = 9
        '
        'txtUnit3
        '
        Me.txtUnit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnit3.Location = New System.Drawing.Point(93, 46)
        Me.txtUnit3.Name = "txtUnit3"
        Me.txtUnit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit3.Properties.Appearance.Options.UseFont = True
        Me.txtUnit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit3.Size = New System.Drawing.Size(124, 28)
        Me.txtUnit3.TabIndex = 19
        '
        'txtUnit1
        '
        Me.txtUnit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUnit1.Location = New System.Drawing.Point(93, 13)
        Me.txtUnit1.Name = "txtUnit1"
        Me.txtUnit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit1.Properties.Appearance.Options.UseFont = True
        Me.txtUnit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUnit1.Size = New System.Drawing.Size(124, 28)
        Me.txtUnit1.TabIndex = 19
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.PnlSave)
        Me.pnlLeft.Controls.Add(Me.grpMat)
        Me.pnlLeft.Controls.Add(Me.grpRequest)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(348, 742)
        Me.pnlLeft.TabIndex = 22
        '
        'slLocDest
        '
        Me.slLocDest.EditValue = ""
        Me.slLocDest.Location = New System.Drawing.Point(160, 106)
        Me.slLocDest.Name = "slLocDest"
        Me.slLocDest.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slLocDest.Properties.Appearance.Options.UseFont = True
        Me.slLocDest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slLocDest.Properties.View = Me.GridView1
        Me.slLocDest.Size = New System.Drawing.Size(124, 28)
        Me.slLocDest.TabIndex = 18
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "คลังที่เก็บปลายทาง"
        '
        'FrmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 742)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "FrmTransfer"
        Me.Text = "โอนย้ายวัสดุ"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransferNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slTagID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequest.ResumeLayout(False)
        Me.grpRequest.PerformLayout()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSave.ResumeLayout(False)
        CType(Me.grpMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMat.ResumeLayout(False)
        Me.grpMat.PerformLayout()
        CType(Me.pnlRD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRD1.ResumeLayout(False)
        Me.pnlRD1.PerformLayout()
        CType(Me.txtUnit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.slLocDest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTransferNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents slTagID As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpRequest As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbUnit3Name As System.Windows.Forms.Label
    Friend WithEvents lbVol As System.Windows.Forms.Label
    Friend WithEvents lbUnit1Name As System.Windows.Forms.Label
    Friend WithEvents lbQty As System.Windows.Forms.Label
    Friend WithEvents lbUserStock As System.Windows.Forms.Label
    Friend WithEvents PnlSave As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpMat As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlRD1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtUnit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtUnit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents slLocDest As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
