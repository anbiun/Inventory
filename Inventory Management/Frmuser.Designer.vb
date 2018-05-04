<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmgUser
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
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgUser))
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions5 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcUser = New DevExpress.XtraGrid.GridControl()
        Me.gvUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcLoc = New DevExpress.XtraGrid.GridControl()
        Me.gvLoc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WinUIPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcUser)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcLoc)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1003, 396)
        Me.SplitContainerControl1.SplitterPosition = 658
        Me.SplitContainerControl1.TabIndex = 79
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'gcUser
        '
        Me.gcUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcUser.Location = New System.Drawing.Point(0, 0)
        Me.gcUser.MainView = Me.gvUser
        Me.gcUser.Name = "gcUser"
        Me.gcUser.Size = New System.Drawing.Size(658, 396)
        Me.gcUser.TabIndex = 34
        Me.gcUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUser})
        '
        'gvUser
        '
        Me.gvUser.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvUser.GridControl = Me.gcUser
        Me.gvUser.Name = "gvUser"
        Me.gvUser.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvUser.OptionsNavigation.AutoFocusNewRow = True
        Me.gvUser.OptionsView.ColumnAutoWidth = False
        Me.gvUser.OptionsView.ShowGroupPanel = False
        Me.gvUser.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'gcLoc
        '
        Me.gcLoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLoc.Location = New System.Drawing.Point(0, 0)
        Me.gcLoc.MainView = Me.gvLoc
        Me.gcLoc.Name = "gcLoc"
        Me.gcLoc.Size = New System.Drawing.Size(339, 396)
        Me.gcLoc.TabIndex = 35
        Me.gcLoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLoc})
        '
        'gvLoc
        '
        Me.gvLoc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvLoc.GridControl = Me.gcLoc
        Me.gvLoc.Name = "gvLoc"
        Me.gvLoc.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvLoc.OptionsNavigation.AutoFocusNewRow = True
        Me.gvLoc.OptionsView.ColumnAutoWidth = False
        Me.gvLoc.OptionsView.ShowGroupPanel = False
        Me.gvLoc.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'WinUIPanel
        '
        Me.WinUIPanel.AppearanceButton.Hovered.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinUIPanel.AppearanceButton.Hovered.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.WinUIPanel.AppearanceButton.Hovered.Options.UseFont = True
        Me.WinUIPanel.AppearanceButton.Normal.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinUIPanel.AppearanceButton.Normal.Options.UseFont = True
        Me.WinUIPanel.BackColor = System.Drawing.SystemColors.Window
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.publicfix_32x32
        WindowsUIButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.newcustomers_32x32
        WindowsUIButtonImageOptions4.Image = Global.Inventory_Management.My.Resources.Resources.undo_16x16
        WindowsUIButtonImageOptions5.Image = Global.Inventory_Management.My.Resources.Resources.download_32x32
        Me.WinUIPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("ลบ", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "btnDel", -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("แก้ไข", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "btnEdit", -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("เพิ่ม", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "btnNew", -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ยกเลิก", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "btnCancel", -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("บันทึก", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "btnSave", -1, False)})
        Me.WinUIPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WinUIPanel.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinUIPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.WinUIPanel.Location = New System.Drawing.Point(0, 396)
        Me.WinUIPanel.Name = "WinUIPanel"
        Me.WinUIPanel.Size = New System.Drawing.Size(1003, 87)
        Me.WinUIPanel.TabIndex = 78
        Me.WinUIPanel.Text = "WindowsUIButtonPanel1"
        '
        'FmgUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 483)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.WinUIPanel)
        Me.Name = "FmgUser"
        Me.Text = "FrmUser"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcLoc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WinUIPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
End Class
