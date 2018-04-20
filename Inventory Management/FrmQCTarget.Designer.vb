<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQCTarget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQCTarget))
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnlSave = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlMenu = New DevExpress.XtraEditors.GroupControl()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSave.SuspendLayout()
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(0, 79)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(1150, 555)
        Me.gcList.TabIndex = 32
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList})
        '
        'gvList
        '
        Me.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvList.OptionsNavigation.AutoFocusNewRow = True
        Me.gvList.OptionsView.ShowGroupPanel = False
        Me.gvList.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'pnlSave
        '
        Me.pnlSave.Controls.Add(Me.btnCancel)
        Me.pnlSave.Controls.Add(Me.btnSave)
        Me.pnlSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSave.Location = New System.Drawing.Point(0, 634)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.ShowCaption = False
        Me.pnlSave.Size = New System.Drawing.Size(1150, 65)
        Me.pnlSave.TabIndex = 33
        Me.pnlSave.Text = "GroupControl2"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.AppearanceHovered.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCancel.AppearanceHovered.Options.UseBackColor = True
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCancel.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.undo_16x16
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(394, 5)
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
        Me.btnSave.Location = New System.Drawing.Point(637, 5)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 54)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "บันทึก"
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnExport)
        Me.pnlMenu.Controls.Add(Me.btnImport)
        Me.pnlMenu.Controls.Add(Me.btnRemove)
        Me.pnlMenu.Controls.Add(Me.btnEdit)
        Me.pnlMenu.Controls.Add(Me.btnNew)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShowCaption = False
        Me.pnlMenu.Size = New System.Drawing.Size(1150, 79)
        Me.pnlMenu.TabIndex = 34
        Me.pnlMenu.Text = "GroupControl3"
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
        Me.btnExport.Location = New System.Drawing.Point(637, 11)
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
        Me.btnImport.Location = New System.Drawing.Point(756, 11)
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
        Me.btnRemove.Location = New System.Drawing.Point(492, 11)
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
        Me.btnEdit.Location = New System.Drawing.Point(373, 11)
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
        Me.btnNew.Location = New System.Drawing.Point(254, 11)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(115, 62)
        Me.btnNew.TabIndex = 27
        Me.btnNew.Text = "ข้อมูลใหม่"
        '
        'FrmQCTarget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 699)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.pnlSave)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "FrmQCTarget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เป้าการผลิต"
        Me.TopMost = True
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSave.ResumeLayout(False)
        CType(Me.pnlMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlSave As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlMenu As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
End Class
