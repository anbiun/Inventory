﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogs_Import
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogs_Import))
        Me.rdDate_By = New System.Windows.Forms.RadioButton()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.clbSubCat = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.clbLoc = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rdDate_All = New System.Windows.Forms.RadioButton()
        Me.slCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.lbCat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.deSDate = New DevExpress.XtraEditors.DateEdit()
        Me.lbEDate = New System.Windows.Forms.Label()
        Me.deEDate = New DevExpress.XtraEditors.DateEdit()
        Me.lbSDate = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdDate_By
        '
        Me.rdDate_By.AutoSize = True
        Me.rdDate_By.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDate_By.Location = New System.Drawing.Point(16, 474)
        Me.rdDate_By.Name = "rdDate_By"
        Me.rdDate_By.Size = New System.Drawing.Size(126, 25)
        Me.rdDate_By.TabIndex = 33
        Me.rdDate_By.TabStop = True
        Me.rdDate_By.Text = "ค้นหาระบุวันที่"
        Me.rdDate_By.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSearch.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btnSearch.Location = New System.Drawing.Point(24, 583)
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
        Me.clbSubCat.Size = New System.Drawing.Size(212, 191)
        Me.clbSubCat.TabIndex = 29
        '
        'clbLoc
        '
        Me.clbLoc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbLoc.Appearance.Options.UseFont = True
        Me.clbLoc.CheckOnClick = True
        Me.clbLoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbLoc.Location = New System.Drawing.Point(23, 334)
        Me.clbLoc.Name = "clbLoc"
        Me.clbLoc.Size = New System.Drawing.Size(212, 103)
        Me.clbLoc.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(12, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "คลังวัสดุ :"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'rdDate_All
        '
        Me.rdDate_All.AutoSize = True
        Me.rdDate_All.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDate_All.Location = New System.Drawing.Point(16, 443)
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
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.gcList)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(253, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(795, 643)
        Me.GroupControl3.TabIndex = 18
        Me.GroupControl3.Text = "ประวัติรายการนำเข้า"
        '
        'deSDate
        '
        Me.deSDate.EditValue = Nothing
        Me.deSDate.Location = New System.Drawing.Point(71, 505)
        Me.deSDate.Name = "deSDate"
        Me.deSDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deSDate.Properties.Appearance.Options.UseFont = True
        Me.deSDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSDate.Size = New System.Drawing.Size(164, 28)
        Me.deSDate.TabIndex = 15
        '
        'lbEDate
        '
        Me.lbEDate.AutoSize = True
        Me.lbEDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbEDate.Location = New System.Drawing.Point(38, 541)
        Me.lbEDate.Name = "lbEDate"
        Me.lbEDate.Size = New System.Drawing.Size(27, 24)
        Me.lbEDate.TabIndex = 13
        Me.lbEDate.Text = "ถึง"
        '
        'deEDate
        '
        Me.deEDate.EditValue = Nothing
        Me.deEDate.Location = New System.Drawing.Point(71, 539)
        Me.deEDate.Name = "deEDate"
        Me.deEDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deEDate.Properties.Appearance.Options.UseFont = True
        Me.deEDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deEDate.Size = New System.Drawing.Size(164, 28)
        Me.deEDate.TabIndex = 15
        '
        'lbSDate
        '
        Me.lbSDate.AutoSize = True
        Me.lbSDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSDate.Location = New System.Drawing.Point(22, 507)
        Me.lbSDate.Name = "lbSDate"
        Me.lbSDate.Size = New System.Drawing.Size(43, 24)
        Me.lbSDate.TabIndex = 13
        Me.lbSDate.Text = "วันที่"
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
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(253, 643)
        Me.GroupControl1.TabIndex = 19
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(2, 31)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(791, 610)
        Me.gcList.TabIndex = 10
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList})
        '
        'gvList
        '
        Me.gvList.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvList.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvList.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvList.Appearance.DetailTip.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.DetailTip.Options.UseFont = True
        Me.gvList.Appearance.Empty.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.Empty.Options.UseFont = True
        Me.gvList.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.EvenRow.Options.UseFont = True
        Me.gvList.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvList.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.FilterPanel.Options.UseFont = True
        Me.gvList.Appearance.FixedLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.FixedLine.Options.UseFont = True
        Me.gvList.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.FocusedCell.Options.UseFont = True
        Me.gvList.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.FocusedRow.Options.UseFont = True
        Me.gvList.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.FooterPanel.Options.UseFont = True
        Me.gvList.Appearance.GroupButton.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.GroupButton.Options.UseFont = True
        Me.gvList.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.GroupFooter.Options.UseFont = True
        Me.gvList.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.GroupPanel.Options.UseFont = True
        Me.gvList.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.GroupRow.Options.UseFont = True
        Me.gvList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvList.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvList.Appearance.HorzLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.HorzLine.Options.UseFont = True
        Me.gvList.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.OddRow.Options.UseFont = True
        Me.gvList.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.Preview.Options.UseFont = True
        Me.gvList.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.Row.Options.UseFont = True
        Me.gvList.Appearance.RowSeparator.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.RowSeparator.Options.UseFont = True
        Me.gvList.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.SelectedRow.Options.UseFont = True
        Me.gvList.Appearance.TopNewRow.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.TopNewRow.Options.UseFont = True
        Me.gvList.Appearance.VertLine.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.VertLine.Options.UseFont = True
        Me.gvList.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.gvList.Appearance.ViewCaption.Options.UseFont = True
        Me.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.Editable = False
        Me.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvList.OptionsView.ColumnAutoWidth = False
        Me.gvList.OptionsView.ShowAutoFilterRow = True
        Me.gvList.OptionsView.ShowGroupPanel = False
        Me.gvList.OptionsView.ShowIndicator = False
        '
        'FrmLogs_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 643)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FrmLogs_Import"
        Me.Text = "ประวัติของนำเข้า"
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdDate_By As RadioButton
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clbSubCat As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents clbLoc As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rdDate_All As RadioButton
    Friend WithEvents slCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents lbCat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deSDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbEDate As Label
    Friend WithEvents deEDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbSDate As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
End Class
