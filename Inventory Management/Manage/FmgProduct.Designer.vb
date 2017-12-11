<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgProduct))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProduct = New DevExpress.XtraEditors.TextEdit()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnDelList = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpImport = New DevExpress.XtraEditors.GroupControl()
        Me.txtTarget = New DevExpress.XtraEditors.SpinEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddList = New DevExpress.XtraEditors.SimpleButton()
        Me.grpSave = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.grpMenu = New DevExpress.XtraEditors.GroupControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImport.SuspendLayout()
        CType(Me.txtTarget.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSave.SuspendLayout()
        CType(Me.grpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "เบอร์มีด :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtProduct
        '
        Me.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtProduct.Location = New System.Drawing.Point(293, 6)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Properties.Appearance.Options.UseFont = True
        Me.txtProduct.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtProduct.Size = New System.Drawing.Size(156, 30)
        Me.txtProduct.TabIndex = 29
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(0, 198)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(649, 481)
        Me.gcList.TabIndex = 24
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList})
        '
        'gvList
        '
        Me.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvList.OptionsView.ShowGroupPanel = False
        '
        'btnDelList
        '
        Me.btnDelList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelList.Appearance.Options.UseFont = True
        Me.btnDelList.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnDelList.AppearanceHovered.Options.UseBackColor = True
        Me.btnDelList.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDelList.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.previous_16x16
        Me.btnDelList.Location = New System.Drawing.Point(143, 82)
        Me.btnDelList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelList.Name = "btnDelList"
        Me.btnDelList.Size = New System.Drawing.Size(172, 27)
        Me.btnDelList.TabIndex = 26
        Me.btnDelList.Text = "ลบรายการ"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "เป้าผลิต :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "โหล"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpImport
        '
        Me.grpImport.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.grpImport.Controls.Add(Me.btnOK)
        Me.grpImport.Controls.Add(Me.btnDelList)
        Me.grpImport.Controls.Add(Me.txtTarget)
        Me.grpImport.Controls.Add(Me.btnAddList)
        Me.grpImport.Controls.Add(Me.Label2)
        Me.grpImport.Controls.Add(Me.txtProduct)
        Me.grpImport.Controls.Add(Me.Label3)
        Me.grpImport.Controls.Add(Me.Label1)
        Me.grpImport.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpImport.Location = New System.Drawing.Point(0, 79)
        Me.grpImport.Name = "grpImport"
        Me.grpImport.ShowCaption = False
        Me.grpImport.Size = New System.Drawing.Size(649, 119)
        Me.grpImport.TabIndex = 30
        Me.grpImport.Text = "GroupControl1"
        '
        'txtTarget
        '
        Me.txtTarget.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtTarget.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTarget.Location = New System.Drawing.Point(294, 45)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarget.Properties.Appearance.Options.UseFont = True
        Me.txtTarget.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTarget.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTarget.Properties.MaxLength = 7
        Me.txtTarget.Size = New System.Drawing.Size(100, 30)
        Me.txtTarget.TabIndex = 30
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnOK.AppearanceHovered.Options.UseBackColor = True
        Me.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOK.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_16x161
        Me.btnOK.Location = New System.Drawing.Point(143, 82)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(353, 27)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Text = "แก้ไข"
        '
        'btnAddList
        '
        Me.btnAddList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList.Appearance.Options.UseFont = True
        Me.btnAddList.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnAddList.AppearanceHovered.Options.UseBackColor = True
        Me.btnAddList.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAddList.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.next_16x162
        Me.btnAddList.Location = New System.Drawing.Point(324, 82)
        Me.btnAddList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(172, 27)
        Me.btnAddList.TabIndex = 27
        Me.btnAddList.Text = "เพิ่มรายการ"
        '
        'grpSave
        '
        Me.grpSave.Controls.Add(Me.btnCancel)
        Me.grpSave.Controls.Add(Me.btnSave)
        Me.grpSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpSave.Location = New System.Drawing.Point(0, 679)
        Me.grpSave.Name = "grpSave"
        Me.grpSave.ShowCaption = False
        Me.grpSave.Size = New System.Drawing.Size(649, 58)
        Me.grpSave.TabIndex = 31
        Me.grpSave.Text = "GroupControl2"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCancel.AppearanceHovered.Options.UseBackColor = True
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(143, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 54)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "ยกเลิก"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSave.AppearanceHovered.Options.UseBackColor = True
        Me.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(386, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 54)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "บันทึก"
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.btnExport)
        Me.grpMenu.Controls.Add(Me.btnImport)
        Me.grpMenu.Controls.Add(Me.btnRemove)
        Me.grpMenu.Controls.Add(Me.btnEdit)
        Me.grpMenu.Controls.Add(Me.btnNew)
        Me.grpMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpMenu.Location = New System.Drawing.Point(0, 0)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.ShowCaption = False
        Me.grpMenu.Size = New System.Drawing.Size(649, 79)
        Me.grpMenu.TabIndex = 31
        Me.grpMenu.Text = "GroupControl3"
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExport.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Appearance.Options.UseFont = True
        Me.btnExport.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnExport.AppearanceHovered.Options.UseBackColor = True
        Me.btnExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnExport.ImageOptions.Image = CType(resources.GetObject("btnExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnExport.Location = New System.Drawing.Point(399, 9)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(115, 62)
        Me.btnExport.TabIndex = 27
        Me.btnExport.Text = "ส่งออกข้อมูล"
        '
        'btnImport
        '
        Me.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnImport.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Appearance.Options.UseFont = True
        Me.btnImport.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnImport.AppearanceHovered.Options.UseBackColor = True
        Me.btnImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnImport.ImageOptions.Image = CType(resources.GetObject("btnImport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnImport.Location = New System.Drawing.Point(518, 9)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(115, 62)
        Me.btnImport.TabIndex = 27
        Me.btnImport.Text = "นำเข้าข้อมูล"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRemove.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Appearance.Options.UseFont = True
        Me.btnRemove.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnRemove.AppearanceHovered.Options.UseBackColor = True
        Me.btnRemove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(255, 9)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(115, 62)
        Me.btnRemove.TabIndex = 27
        Me.btnRemove.Text = "ลบข้อมูล"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnEdit.AppearanceHovered.Options.UseBackColor = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(136, 9)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(115, 62)
        Me.btnEdit.TabIndex = 27
        Me.btnEdit.Text = "แก้ไขข้อมูล"
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnNew.AppearanceHovered.Options.UseBackColor = True
        Me.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnNew.Location = New System.Drawing.Point(17, 9)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(115, 62)
        Me.btnNew.TabIndex = 27
        Me.btnNew.Text = "ข้อมูลใหม่"
        '
        'FmgProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(649, 737)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.grpSave)
        Me.Controls.Add(Me.grpImport)
        Me.Controls.Add(Me.grpMenu)
        Me.MaximumSize = New System.Drawing.Size(667, 784)
        Me.MinimumSize = New System.Drawing.Size(667, 784)
        Me.Name = "FmgProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลสินค้า"
        Me.TopMost = True
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImport.ResumeLayout(False)
        CType(Me.txtTarget.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSave.ResumeLayout(False)
        CType(Me.grpMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtProduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDelList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpImport As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTarget As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents grpMenu As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpSave As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
End Class
