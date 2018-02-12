<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgRequisition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgRequisition))
        Me.BtnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.deSDate = New DevExpress.XtraEditors.DateEdit()
        Me.lbSDate = New System.Windows.Forms.Label()
        Me.lbEDate = New System.Windows.Forms.Label()
        Me.deEDate = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.cbPageSize = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDisplayPageNo = New DevExpress.XtraEditors.LabelControl()
        Me.BtnNextPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPreviousPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnLastPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnFirstPage = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdDate_By = New System.Windows.Forms.RadioButton()
        Me.rdDate_All = New System.Windows.Forms.RadioButton()
        Me.slCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.clbSubCat = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.clbLoc = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.cbPageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDel
        '
        Me.BtnDel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnDel.Appearance.Options.UseFont = True
        Me.BtnDel.ImageOptions.Image = CType(resources.GetObject("BtnDel.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnDel.Location = New System.Drawing.Point(24, 567)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(211, 35)
        Me.BtnDel.TabIndex = 13
        Me.BtnDel.Text = "ยกเลิกใบเบิกที่เลือก"
        '
        'deSDate
        '
        Me.deSDate.EditValue = Nothing
        Me.deSDate.Location = New System.Drawing.Point(71, 439)
        Me.deSDate.Name = "deSDate"
        Me.deSDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deSDate.Properties.Appearance.Options.UseFont = True
        Me.deSDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSDate.Size = New System.Drawing.Size(164, 28)
        Me.deSDate.TabIndex = 15
        '
        'lbSDate
        '
        Me.lbSDate.AutoSize = True
        Me.lbSDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSDate.Location = New System.Drawing.Point(22, 441)
        Me.lbSDate.Name = "lbSDate"
        Me.lbSDate.Size = New System.Drawing.Size(43, 24)
        Me.lbSDate.TabIndex = 13
        Me.lbSDate.Text = "วันที่"
        '
        'lbEDate
        '
        Me.lbEDate.AutoSize = True
        Me.lbEDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbEDate.Location = New System.Drawing.Point(38, 475)
        Me.lbEDate.Name = "lbEDate"
        Me.lbEDate.Size = New System.Drawing.Size(27, 24)
        Me.lbEDate.TabIndex = 13
        Me.lbEDate.Text = "ถึง"
        '
        'deEDate
        '
        Me.deEDate.EditValue = Nothing
        Me.deEDate.Location = New System.Drawing.Point(71, 473)
        Me.deEDate.Name = "deEDate"
        Me.deEDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deEDate.Properties.Appearance.Options.UseFont = True
        Me.deEDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEDate.Size = New System.Drawing.Size(164, 28)
        Me.deEDate.TabIndex = 15
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.gcList)
        Me.GroupControl3.Controls.Add(Me.PanelControl10)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(253, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(761, 804)
        Me.GroupControl3.TabIndex = 16
        Me.GroupControl3.Text = "ประวัติรายการเบิกของ"
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(2, 31)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(757, 740)
        Me.gcList.TabIndex = 7
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList})
        '
        'gvList
        '
        Me.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvList.OptionsFind.AlwaysVisible = True
        Me.gvList.OptionsView.ColumnAutoWidth = False
        Me.gvList.OptionsView.ShowFooter = True
        Me.gvList.OptionsView.ShowGroupPanel = False
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.Panel2)
        Me.PanelControl10.Controls.Add(Me.Panel1)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl10.Location = New System.Drawing.Point(2, 771)
        Me.PanelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(757, 31)
        Me.PanelControl10.TabIndex = 8
        '
        'cbPageSize
        '
        Me.cbPageSize.EditValue = "5"
        Me.cbPageSize.Location = New System.Drawing.Point(88, 1)
        Me.cbPageSize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbPageSize.Name = "cbPageSize"
        Me.cbPageSize.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbPageSize.Properties.Appearance.Options.UseFont = True
        Me.cbPageSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPageSize.Properties.Items.AddRange(New Object() {"5", "10", "25", "50", "100"})
        Me.cbPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbPageSize.Size = New System.Drawing.Size(65, 24)
        Me.cbPageSize.TabIndex = 10
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 9.55!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl18.TabIndex = 8
        Me.LabelControl18.Text = "จำนวนหน้า:"
        '
        'txtDisplayPageNo
        '
        Me.txtDisplayPageNo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.txtDisplayPageNo.Appearance.Options.UseFont = True
        Me.txtDisplayPageNo.Location = New System.Drawing.Point(369, 3)
        Me.txtDisplayPageNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDisplayPageNo.Name = "txtDisplayPageNo"
        Me.txtDisplayPageNo.Size = New System.Drawing.Size(28, 19)
        Me.txtDisplayPageNo.TabIndex = 9
        Me.txtDisplayPageNo.Text = "หน้า"
        '
        'BtnNextPage
        '
        Me.BtnNextPage.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BtnNextPage.Appearance.Options.UseFont = True
        Me.BtnNextPage.ImageOptions.Image = CType(resources.GetObject("BtnNextPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnNextPage.Location = New System.Drawing.Point(3, 0)
        Me.BtnNextPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.Size = New System.Drawing.Size(104, 26)
        Me.BtnNextPage.TabIndex = 4
        Me.BtnNextPage.Text = "หน้าถัดไป"
        '
        'BtnPreviousPage
        '
        Me.BtnPreviousPage.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BtnPreviousPage.Appearance.Options.UseFont = True
        Me.BtnPreviousPage.ImageOptions.Image = CType(resources.GetObject("BtnPreviousPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnPreviousPage.Location = New System.Drawing.Point(266, 0)
        Me.BtnPreviousPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.Size = New System.Drawing.Size(97, 26)
        Me.BtnPreviousPage.TabIndex = 5
        Me.BtnPreviousPage.Text = "หน้าก่อน"
        '
        'BtnLastPage
        '
        Me.BtnLastPage.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BtnLastPage.Appearance.Options.UseFont = True
        Me.BtnLastPage.ImageOptions.Image = CType(resources.GetObject("BtnLastPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnLastPage.Location = New System.Drawing.Point(113, 0)
        Me.BtnLastPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLastPage.Name = "BtnLastPage"
        Me.BtnLastPage.Size = New System.Drawing.Size(111, 26)
        Me.BtnLastPage.TabIndex = 6
        Me.BtnLastPage.Text = "หน้าสุดท้าย"
        '
        'BtnFirstPage
        '
        Me.BtnFirstPage.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BtnFirstPage.Appearance.Options.UseFont = True
        Me.BtnFirstPage.ImageOptions.Image = CType(resources.GetObject("BtnFirstPage.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnFirstPage.Location = New System.Drawing.Point(159, 0)
        Me.BtnFirstPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.Size = New System.Drawing.Size(101, 26)
        Me.BtnFirstPage.TabIndex = 7
        Me.BtnFirstPage.Text = "หน้าแรก"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.rdDate_By)
        Me.GroupControl1.Controls.Add(Me.rdDate_All)
        Me.GroupControl1.Controls.Add(Me.slCat)
        Me.GroupControl1.Controls.Add(Me.btnSearch)
        Me.GroupControl1.Controls.Add(Me.clbSubCat)
        Me.GroupControl1.Controls.Add(Me.clbLoc)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lbCat)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.deSDate)
        Me.GroupControl1.Controls.Add(Me.lbEDate)
        Me.GroupControl1.Controls.Add(Me.deEDate)
        Me.GroupControl1.Controls.Add(Me.lbSDate)
        Me.GroupControl1.Controls.Add(Me.BtnDel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(253, 804)
        Me.GroupControl1.TabIndex = 17
        '
        'rdDate_By
        '
        Me.rdDate_By.AutoSize = True
        Me.rdDate_By.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDate_By.Location = New System.Drawing.Point(16, 408)
        Me.rdDate_By.Name = "rdDate_By"
        Me.rdDate_By.Size = New System.Drawing.Size(126, 25)
        Me.rdDate_By.TabIndex = 33
        Me.rdDate_By.TabStop = True
        Me.rdDate_By.Text = "ค้นหาระบุวันที่"
        Me.rdDate_By.UseVisualStyleBackColor = True
        '
        'rdDate_All
        '
        Me.rdDate_All.AutoSize = True
        Me.rdDate_All.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDate_All.Location = New System.Drawing.Point(16, 377)
        Me.rdDate_All.Name = "rdDate_All"
        Me.rdDate_All.Size = New System.Drawing.Size(106, 25)
        Me.rdDate_All.TabIndex = 33
        Me.rdDate_All.TabStop = True
        Me.rdDate_All.Text = "ไม่ระบุวันที่"
        Me.rdDate_All.UseVisualStyleBackColor = True
        '
        'slCat
        '
        Me.slCat.EditValue = ""
        Me.slCat.Location = New System.Drawing.Point(23, 57)
        Me.slCat.Name = "slCat"
        Me.slCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slCat.Properties.Appearance.Options.UseFont = True
        Me.slCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slCat.Properties.NullText = "กรุณาเลือกหมวดวัสดุ"
        Me.slCat.Properties.View = Me.SearchLookUpEdit1View
        Me.slCat.Size = New System.Drawing.Size(212, 28)
        Me.slCat.TabIndex = 32
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
        Me.btnSearch.Location = New System.Drawing.Point(24, 517)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(211, 43)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "ค้นหา"
        '
        'clbSubCat
        '
        Me.clbSubCat.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbSubCat.Appearance.Options.UseFont = True
        Me.clbSubCat.CheckOnClick = True
        Me.clbSubCat.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbSubCat.Location = New System.Drawing.Point(23, 114)
        Me.clbSubCat.Name = "clbSubCat"
        Me.clbSubCat.Size = New System.Drawing.Size(212, 146)
        Me.clbSubCat.TabIndex = 29
        '
        'clbLoc
        '
        Me.clbLoc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbLoc.Appearance.Options.UseFont = True
        Me.clbLoc.CheckOnClick = True
        Me.clbLoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbLoc.Location = New System.Drawing.Point(23, 289)
        Me.clbLoc.Name = "clbLoc"
        Me.clbLoc.Size = New System.Drawing.Size(212, 81)
        Me.clbLoc.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(12, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "คลังวัสดุ :"
        '
        'lbCat
        '
        Me.lbCat.AutoSize = True
        Me.lbCat.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.lbCat.Location = New System.Drawing.Point(12, 31)
        Me.lbCat.Name = "lbCat"
        Me.lbCat.Size = New System.Drawing.Size(101, 23)
        Me.lbCat.TabIndex = 27
        Me.lbCat.Text = "หมวดวัสดุ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ประเภทวัสดุ :"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.LabelControl18)
        Me.Panel1.Controls.Add(Me.txtDisplayPageNo)
        Me.Panel1.Controls.Add(Me.cbPageSize)
        Me.Panel1.Controls.Add(Me.BtnFirstPage)
        Me.Panel1.Controls.Add(Me.BtnPreviousPage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 27)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.BtnNextPage)
        Me.Panel2.Controls.Add(Me.BtnLastPage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(402, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 27)
        Me.Panel2.TabIndex = 12
        '
        'FmgRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 804)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FmgRequisition"
        Me.Text = "ประวัติรายการเบิก"
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        Me.PanelControl10.PerformLayout()
        CType(Me.cbPageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deSDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbSDate As System.Windows.Forms.Label
    Friend WithEvents lbEDate As System.Windows.Forms.Label
    Friend WithEvents deEDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rdDate_By As RadioButton
    Friend WithEvents rdDate_All As RadioButton
    Friend WithEvents slCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clbSubCat As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents clbLoc As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbPageSize As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDisplayPageNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnNextPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPreviousPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnLastPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFirstPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
