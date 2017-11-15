<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgCategory
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgCategory))
        Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.page1 = New DevExpress.XtraTab.XtraTabPage()
        Me.page2 = New DevExpress.XtraTab.XtraTabPage()
        Me.luCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.imgFolder = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.LblTitle_Add = New DevExpress.XtraEditors.LabelControl()
        Me.memoDetail = New DevExpress.XtraEditors.MemoEdit()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTagID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.slUnit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl.SuspendLayout()
        CType(Me.luCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTagID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.slUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl
        '
        Me.XtraTabControl.Location = New System.Drawing.Point(14, 15)
        Me.XtraTabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControl.Name = "XtraTabControl"
        Me.XtraTabControl.SelectedTabPage = Me.page1
        Me.XtraTabControl.Size = New System.Drawing.Size(433, 400)
        Me.XtraTabControl.TabIndex = 0
        Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.page1, Me.page2})
        '
        'page1
        '
        Me.page1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.page1.Appearance.Header.Options.UseFont = True
        Me.page1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.page1.Name = "page1"
        Me.page1.Size = New System.Drawing.Size(426, 364)
        Me.page1.Text = "เพิ่มข้อมูล"
        '
        'page2
        '
        Me.page2.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.page2.Appearance.Header.Options.UseFont = True
        Me.page2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.page2.Name = "page2"
        Me.page2.Size = New System.Drawing.Size(426, 364)
        Me.page2.Text = "แก้ไข"
        '
        'luCategory
        '
        Me.luCategory.Location = New System.Drawing.Point(165, 62)
        Me.luCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.luCategory.Name = "luCategory"
        Me.luCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.luCategory.Properties.Appearance.Options.UseFont = True
        Me.luCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.luCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCategory.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch
        Me.luCategory.Properties.ShowHeader = False
        Me.luCategory.Size = New System.Drawing.Size(187, 24)
        Me.luCategory.TabIndex = 13
        '
        'imgFolder
        '
        Me.imgFolder.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgFolder.EditValue = Global.Inventory_Management.My.Resources.Resources.FolderOpen
        Me.imgFolder.Location = New System.Drawing.Point(129, 58)
        Me.imgFolder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.imgFolder.Name = "imgFolder"
        Me.imgFolder.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgFolder.Properties.Appearance.Options.UseBackColor = True
        Me.imgFolder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgFolder.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgFolder.Properties.ZoomAccelerationFactor = 1.0R
        Me.imgFolder.Size = New System.Drawing.Size(30, 28)
        Me.imgFolder.TabIndex = 10
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(15, 206)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(161, 21)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "คำอธิบาย - รายละเอียด"
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Location = New System.Drawing.Point(64, 29)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(134, 21)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "อยู่ภายใต้หมวดวัสดุ"
        '
        'LblTitle_Add
        '
        Me.LblTitle_Add.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LblTitle_Add.Appearance.Options.UseFont = True
        Me.LblTitle_Add.Location = New System.Drawing.Point(64, 97)
        Me.LblTitle_Add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LblTitle_Add.Name = "LblTitle_Add"
        Me.LblTitle_Add.Size = New System.Drawing.Size(88, 21)
        Me.LblTitle_Add.TabIndex = 3
        Me.LblTitle_Add.Text = "ชื่อหมวดวัสดุ"
        '
        'memoDetail
        '
        Me.memoDetail.Location = New System.Drawing.Point(15, 235)
        Me.memoDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.memoDetail.Name = "memoDetail"
        Me.memoDetail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.memoDetail.Properties.Appearance.Options.UseFont = True
        Me.memoDetail.Size = New System.Drawing.Size(387, 115)
        Me.memoDetail.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(165, 94)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.MaxLength = 30
        Me.txtName.Size = New System.Drawing.Size(187, 28)
        Me.txtName.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnSave.ImageOptions.Image = CType(resources.GetObject("BtnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(104, 6)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 28)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "ตกลง"
        '
        'BtnCancel
        '
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnCancel.Appearance.Options.UseFont = True
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.ImageOptions.Image = CType(resources.GetObject("BtnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(5, 6)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(91, 28)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "ยกเลิก"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnSave)
        Me.PanelControl1.Controls.Add(Me.BtnCancel)
        Me.PanelControl1.Location = New System.Drawing.Point(236, 422)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 41)
        Me.PanelControl1.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(86, 4)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 21)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "TagID."
        '
        'txtTagID
        '
        Me.txtTagID.Location = New System.Drawing.Point(150, 1)
        Me.txtTagID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTagID.Name = "txtTagID"
        Me.txtTagID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtTagID.Properties.Appearance.Options.UseFont = True
        Me.txtTagID.Properties.MaxLength = 3
        Me.txtTagID.Size = New System.Drawing.Size(56, 28)
        Me.txtTagID.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(54, 40)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 21)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "หน่วยใช้งาน"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Panel1)
        Me.GroupControl1.Controls.Add(Me.lblTitle)
        Me.GroupControl1.Controls.Add(Me.luCategory)
        Me.GroupControl1.Controls.Add(Me.txtName)
        Me.GroupControl1.Controls.Add(Me.imgFolder)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.memoDetail)
        Me.GroupControl1.Controls.Add(Me.LblTitle_Add)
        Me.GroupControl1.Location = New System.Drawing.Point(18, 51)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(418, 356)
        Me.GroupControl1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.slUnit)
        Me.Panel1.Controls.Add(Me.LabelControl4)
        Me.Panel1.Controls.Add(Me.txtTagID)
        Me.Panel1.Location = New System.Drawing.Point(15, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 70)
        Me.Panel1.TabIndex = 15
        '
        'slUnit
        '
        Me.slUnit.Location = New System.Drawing.Point(150, 40)
        Me.slUnit.Name = "slUnit"
        Me.slUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slUnit.Properties.Appearance.Options.UseFont = True
        Me.slUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slUnit.Properties.View = Me.SearchLookUpEdit1View
        Me.slUnit.Size = New System.Drawing.Size(187, 24)
        Me.slUnit.TabIndex = 14
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'FmgCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 476)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.XtraTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FmgCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "เพิ่ม - แก้ไขข้อมูล"
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl.ResumeLayout(False)
        CType(Me.luCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtTagID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.slUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents page1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblTitle_Add As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memoDetail As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgFolder As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents page2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents luCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTagID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents slUnit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
