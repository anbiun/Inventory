<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogs_Po
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogs_Po))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcResult = New DevExpress.XtraGrid.GridControl()
        Me.gvResult = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlRightFilter = New DevExpress.XtraEditors.PanelControl()
        Me.clbSubCat = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.deSDate = New DevExpress.XtraEditors.DateEdit()
        Me.lbEDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deEDate = New DevExpress.XtraEditors.DateEdit()
        Me.slCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbSDate = New System.Windows.Forms.Label()
        Me.lbCat = New System.Windows.Forms.Label()
        Me.line1 = New DevExpress.XtraEditors.PanelControl()
        Me.rdDate_All = New System.Windows.Forms.RadioButton()
        Me.rdDate_By = New System.Windows.Forms.RadioButton()
        Me.BtnDel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.pnlRightFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRightFilter.SuspendLayout()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.line1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.gcResult)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(585, 555)
        Me.GroupControl3.TabIndex = 13
        Me.GroupControl3.Text = "รายการใบ Po"
        '
        'gcResult
        '
        Me.gcResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcResult.Location = New System.Drawing.Point(2, 31)
        Me.gcResult.MainView = Me.gvResult
        Me.gcResult.Name = "gcResult"
        Me.gcResult.Size = New System.Drawing.Size(581, 522)
        Me.gcResult.TabIndex = 17
        Me.gcResult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResult})
        '
        'gvResult
        '
        Me.gvResult.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvResult.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvResult.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvResult.Appearance.DetailTip.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.DetailTip.Options.UseFont = True
        Me.gvResult.Appearance.Empty.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.Empty.Options.UseFont = True
        Me.gvResult.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.EvenRow.Options.UseFont = True
        Me.gvResult.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvResult.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.FilterPanel.Options.UseFont = True
        Me.gvResult.Appearance.FixedLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.FixedLine.Options.UseFont = True
        Me.gvResult.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.FocusedCell.Options.UseFont = True
        Me.gvResult.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.FocusedRow.Options.UseFont = True
        Me.gvResult.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.FooterPanel.Options.UseFont = True
        Me.gvResult.Appearance.GroupButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.GroupButton.Options.UseFont = True
        Me.gvResult.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.GroupFooter.Options.UseFont = True
        Me.gvResult.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.GroupPanel.Options.UseFont = True
        Me.gvResult.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.GroupRow.Options.UseFont = True
        Me.gvResult.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvResult.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvResult.Appearance.HorzLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.HorzLine.Options.UseFont = True
        Me.gvResult.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.OddRow.Options.UseFont = True
        Me.gvResult.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.Preview.Options.UseFont = True
        Me.gvResult.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.Row.Options.UseFont = True
        Me.gvResult.Appearance.RowSeparator.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.RowSeparator.Options.UseFont = True
        Me.gvResult.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.SelectedRow.Options.UseFont = True
        Me.gvResult.Appearance.TopNewRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.TopNewRow.Options.UseFont = True
        Me.gvResult.Appearance.VertLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.VertLine.Options.UseFont = True
        Me.gvResult.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvResult.Appearance.ViewCaption.Options.UseFont = True
        Me.gvResult.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvResult.GridControl = Me.gcResult
        Me.gvResult.Name = "gvResult"
        Me.gvResult.OptionsBehavior.Editable = False
        Me.gvResult.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvResult.OptionsView.ColumnAutoWidth = False
        Me.gvResult.OptionsView.ShowAutoFilterRow = True
        Me.gvResult.OptionsView.ShowGroupPanel = False
        Me.gvResult.OptionsView.ShowIndicator = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnSearch)
        Me.GroupControl1.Controls.Add(Me.pnlRightFilter)
        Me.GroupControl1.Controls.Add(Me.BtnDel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(585, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(224, 555)
        Me.GroupControl1.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSearch.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.find_32x32
        Me.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btnSearch.Location = New System.Drawing.Point(5, 400)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(214, 36)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "ค้นหา"
        '
        'pnlRightFilter
        '
        Me.pnlRightFilter.Controls.Add(Me.clbSubCat)
        Me.pnlRightFilter.Controls.Add(Me.deSDate)
        Me.pnlRightFilter.Controls.Add(Me.lbEDate)
        Me.pnlRightFilter.Controls.Add(Me.Label3)
        Me.pnlRightFilter.Controls.Add(Me.deEDate)
        Me.pnlRightFilter.Controls.Add(Me.slCat)
        Me.pnlRightFilter.Controls.Add(Me.lbSDate)
        Me.pnlRightFilter.Controls.Add(Me.lbCat)
        Me.pnlRightFilter.Controls.Add(Me.line1)
        Me.pnlRightFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRightFilter.Location = New System.Drawing.Point(5, 2)
        Me.pnlRightFilter.Name = "pnlRightFilter"
        Me.pnlRightFilter.Size = New System.Drawing.Size(214, 398)
        Me.pnlRightFilter.TabIndex = 36
        '
        'clbSubCat
        '
        Me.clbSubCat.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbSubCat.Appearance.Options.UseFont = True
        Me.clbSubCat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.clbSubCat.CheckOnClick = True
        Me.clbSubCat.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbSubCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.clbSubCat.Location = New System.Drawing.Point(2, 82)
        Me.clbSubCat.Name = "clbSubCat"
        Me.clbSubCat.Size = New System.Drawing.Size(210, 178)
        Me.clbSubCat.TabIndex = 29
        '
        'deSDate
        '
        Me.deSDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deSDate.EditValue = Nothing
        Me.deSDate.Location = New System.Drawing.Point(77, 325)
        Me.deSDate.Name = "deSDate"
        Me.deSDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deSDate.Properties.Appearance.Options.UseFont = True
        Me.deSDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSDate.Properties.NullDate = "กรุณาเลือก"
        Me.deSDate.Properties.NullText = "กรุณาเลือก"
        Me.deSDate.Size = New System.Drawing.Size(127, 28)
        Me.deSDate.TabIndex = 15
        '
        'lbEDate
        '
        Me.lbEDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbEDate.AutoSize = True
        Me.lbEDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbEDate.Location = New System.Drawing.Point(34, 361)
        Me.lbEDate.Name = "lbEDate"
        Me.lbEDate.Size = New System.Drawing.Size(37, 24)
        Me.lbEDate.TabIndex = 13
        Me.lbEDate.Text = "ถึง :"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label3.Location = New System.Drawing.Point(2, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Label3.Size = New System.Drawing.Size(210, 26)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ประเภทวัสดุ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'deEDate
        '
        Me.deEDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deEDate.EditValue = Nothing
        Me.deEDate.Location = New System.Drawing.Point(77, 359)
        Me.deEDate.Name = "deEDate"
        Me.deEDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deEDate.Properties.Appearance.Options.UseFont = True
        Me.deEDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEDate.Properties.NullDate = "กรุณาเลือก"
        Me.deEDate.Properties.NullText = "กรุณาเลือก"
        Me.deEDate.Size = New System.Drawing.Size(127, 28)
        Me.deEDate.TabIndex = 15
        '
        'slCat
        '
        Me.slCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.slCat.EditValue = ""
        Me.slCat.Location = New System.Drawing.Point(2, 28)
        Me.slCat.Name = "slCat"
        Me.slCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slCat.Properties.Appearance.Options.UseFont = True
        Me.slCat.Properties.Appearance.Options.UseTextOptions = True
        Me.slCat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.slCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slCat.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.slCat.Properties.NullText = "กรุณาเลือกหมวดวัสดุ"
        Me.slCat.Properties.View = Me.SearchLookUpEdit1View
        Me.slCat.Size = New System.Drawing.Size(210, 28)
        Me.slCat.TabIndex = 32
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'lbSDate
        '
        Me.lbSDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSDate.AutoSize = True
        Me.lbSDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSDate.Location = New System.Drawing.Point(18, 327)
        Me.lbSDate.Name = "lbSDate"
        Me.lbSDate.Size = New System.Drawing.Size(53, 24)
        Me.lbSDate.TabIndex = 13
        Me.lbSDate.Text = "วันที่ :"
        '
        'lbCat
        '
        Me.lbCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbCat.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.lbCat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbCat.Location = New System.Drawing.Point(2, 2)
        Me.lbCat.Name = "lbCat"
        Me.lbCat.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.lbCat.Size = New System.Drawing.Size(210, 26)
        Me.lbCat.TabIndex = 27
        Me.lbCat.Text = "หมวดวัสดุ"
        Me.lbCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'line1
        '
        Me.line1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.line1.Controls.Add(Me.rdDate_All)
        Me.line1.Controls.Add(Me.rdDate_By)
        Me.line1.Location = New System.Drawing.Point(0, 262)
        Me.line1.Name = "line1"
        Me.line1.Size = New System.Drawing.Size(214, 57)
        Me.line1.TabIndex = 35
        '
        'rdDate_All
        '
        Me.rdDate_All.AutoSize = True
        Me.rdDate_All.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDate_All.Location = New System.Drawing.Point(21, 4)
        Me.rdDate_All.Name = "rdDate_All"
        Me.rdDate_All.Size = New System.Drawing.Size(106, 25)
        Me.rdDate_All.TabIndex = 33
        Me.rdDate_All.TabStop = True
        Me.rdDate_All.Text = "ไม่ระบุวันที่"
        Me.rdDate_All.UseVisualStyleBackColor = True
        '
        'rdDate_By
        '
        Me.rdDate_By.AutoSize = True
        Me.rdDate_By.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDate_By.Location = New System.Drawing.Point(21, 29)
        Me.rdDate_By.Name = "rdDate_By"
        Me.rdDate_By.Size = New System.Drawing.Size(126, 25)
        Me.rdDate_By.TabIndex = 33
        Me.rdDate_By.TabStop = True
        Me.rdDate_By.Text = "ค้นหาระบุวันที่"
        Me.rdDate_By.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnDel.Appearance.Options.UseFont = True
        Me.BtnDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnDel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnDel.ImageOptions.Image = CType(resources.GetObject("BtnDel.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnDel.Location = New System.Drawing.Point(5, 520)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(214, 33)
        Me.BtnDel.TabIndex = 34
        Me.BtnDel.Text = "ยกเลิกรายการที่เลือก"
        '
        'FrmLogs_Po
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 555)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FrmLogs_Po"
        Me.Text = "รายการใบ PO"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.pnlRightFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRightFilter.ResumeLayout(False)
        Me.pnlRightFilter.PerformLayout()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.line1.ResumeLayout(False)
        Me.line1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlRightFilter As DevExpress.XtraEditors.PanelControl
    Friend WithEvents clbSubCat As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents deSDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbEDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents deEDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents slCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbSDate As Label
    Friend WithEvents lbCat As Label
    Friend WithEvents line1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rdDate_All As RadioButton
    Friend WithEvents rdDate_By As RadioButton
    Friend WithEvents BtnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcResult As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvResult As DevExpress.XtraGrid.Views.Grid.GridView
End Class
