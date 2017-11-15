<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgSupplier))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.btnCancle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.tab1_SupplierFix = New DevExpress.XtraTab.XtraTabPage()
        Me.tab1_GrpInput = New DevExpress.XtraEditors.GroupControl()
        Me.tab1_lblUnitName = New System.Windows.Forms.Label()
        Me.tab1_btnAddList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_txtName = New DevExpress.XtraEditors.TextEdit()
        Me.tab1_btnDelList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_txtOldName = New DevExpress.XtraEditors.TextEdit()
        Me.tab1_GrpBtn = New DevExpress.XtraEditors.GroupControl()
        Me.tab1_btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.tab1_SupplierFix.SuspendLayout()
        CType(Me.tab1_GrpInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1_GrpInput.SuspendLayout()
        CType(Me.tab1_txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab1_txtOldName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab1_GrpBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1_GrpBtn.SuspendLayout()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancle
        '
        Me.btnCancle.ImageOptions.Image = CType(resources.GetObject("btnCancle.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancle.Location = New System.Drawing.Point(4, 6)
        Me.btnCancle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(77, 40)
        Me.btnCancle.TabIndex = 3
        Me.btnCancle.Text = "ยกเลิก"
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(112, 8)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 40)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "บันทึก"
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.gcList.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcList.Location = New System.Drawing.Point(0, 198)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(459, 358)
        Me.gcList.TabIndex = 9
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
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnCancle)
        Me.GroupControl3.Controls.Add(Me.btnSave)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl3.Location = New System.Drawing.Point(257, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(200, 52)
        Me.GroupControl3.TabIndex = 8
        Me.GroupControl3.Text = "GroupControl3"
        '
        'tab1_SupplierFix
        '
        Me.tab1_SupplierFix.Controls.Add(Me.tab1_GrpInput)
        Me.tab1_SupplierFix.Controls.Add(Me.tab1_GrpBtn)
        Me.tab1_SupplierFix.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_SupplierFix.Name = "tab1_SupplierFix"
        Me.tab1_SupplierFix.Size = New System.Drawing.Size(452, 163)
        Me.tab1_SupplierFix.Text = "ข้อมูลผู้ขาย"
        '
        'tab1_GrpInput
        '
        Me.tab1_GrpInput.Controls.Add(Me.tab1_lblUnitName)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_btnAddList)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_txtName)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_btnDelList)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_txtOldName)
        Me.tab1_GrpInput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tab1_GrpInput.Location = New System.Drawing.Point(0, 80)
        Me.tab1_GrpInput.Name = "tab1_GrpInput"
        Me.tab1_GrpInput.ShowCaption = False
        Me.tab1_GrpInput.Size = New System.Drawing.Size(452, 83)
        Me.tab1_GrpInput.TabIndex = 25
        '
        'tab1_lblUnitName
        '
        Me.tab1_lblUnitName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_lblUnitName.Location = New System.Drawing.Point(32, 12)
        Me.tab1_lblUnitName.Name = "tab1_lblUnitName"
        Me.tab1_lblUnitName.Size = New System.Drawing.Size(87, 22)
        Me.tab1_lblUnitName.TabIndex = 20
        Me.tab1_lblUnitName.Text = "ชื่อผู้ขาย"
        Me.tab1_lblUnitName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tab1_btnAddList
        '
        Me.tab1_btnAddList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnAddList.Appearance.Options.UseFont = True
        Me.tab1_btnAddList.ImageOptions.Image = CType(resources.GetObject("tab1_btnAddList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnAddList.Location = New System.Drawing.Point(259, 42)
        Me.tab1_btnAddList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnAddList.Name = "tab1_btnAddList"
        Me.tab1_btnAddList.Size = New System.Drawing.Size(130, 27)
        Me.tab1_btnAddList.TabIndex = 11
        Me.tab1_btnAddList.Text = "เพิ่มรายการ"
        '
        'tab1_txtName
        '
        Me.tab1_txtName.Location = New System.Drawing.Point(125, 9)
        Me.tab1_txtName.Name = "tab1_txtName"
        Me.tab1_txtName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_txtName.Properties.Appearance.Options.UseFont = True
        Me.tab1_txtName.Size = New System.Drawing.Size(264, 28)
        Me.tab1_txtName.TabIndex = 23
        '
        'tab1_btnDelList
        '
        Me.tab1_btnDelList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnDelList.Appearance.Options.UseFont = True
        Me.tab1_btnDelList.ImageOptions.Image = CType(resources.GetObject("tab1_btnDelList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnDelList.Location = New System.Drawing.Point(125, 42)
        Me.tab1_btnDelList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnDelList.Name = "tab1_btnDelList"
        Me.tab1_btnDelList.Size = New System.Drawing.Size(130, 27)
        Me.tab1_btnDelList.TabIndex = 11
        Me.tab1_btnDelList.Text = "ลบรายการ"
        '
        'tab1_txtOldName
        '
        Me.tab1_txtOldName.Location = New System.Drawing.Point(125, 43)
        Me.tab1_txtOldName.Name = "tab1_txtOldName"
        Me.tab1_txtOldName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_txtOldName.Properties.Appearance.Options.UseFont = True
        Me.tab1_txtOldName.Size = New System.Drawing.Size(264, 28)
        Me.tab1_txtOldName.TabIndex = 23
        '
        'tab1_GrpBtn
        '
        Me.tab1_GrpBtn.Controls.Add(Me.tab1_btnNew)
        Me.tab1_GrpBtn.Controls.Add(Me.tab1_btnEdit)
        Me.tab1_GrpBtn.Controls.Add(Me.tab1_btnRemove)
        Me.tab1_GrpBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1_GrpBtn.Location = New System.Drawing.Point(0, 0)
        Me.tab1_GrpBtn.Name = "tab1_GrpBtn"
        Me.tab1_GrpBtn.Size = New System.Drawing.Size(452, 163)
        Me.tab1_GrpBtn.TabIndex = 24
        Me.tab1_GrpBtn.Text = "เลือกการทำงาน"
        '
        'tab1_btnNew
        '
        Me.tab1_btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnNew.Appearance.Options.UseFont = True
        Me.tab1_btnNew.ImageOptions.Image = CType(resources.GetObject("tab1_btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnNew.Location = New System.Drawing.Point(56, 40)
        Me.tab1_btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnNew.Name = "tab1_btnNew"
        Me.tab1_btnNew.Size = New System.Drawing.Size(143, 30)
        Me.tab1_btnNew.TabIndex = 11
        Me.tab1_btnNew.Text = "ข้อมูลใหม่"
        '
        'tab1_btnEdit
        '
        Me.tab1_btnEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnEdit.Appearance.Options.UseFont = True
        Me.tab1_btnEdit.ImageOptions.Image = CType(resources.GetObject("tab1_btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnEdit.Location = New System.Drawing.Point(216, 40)
        Me.tab1_btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnEdit.Name = "tab1_btnEdit"
        Me.tab1_btnEdit.Size = New System.Drawing.Size(86, 30)
        Me.tab1_btnEdit.TabIndex = 11
        Me.tab1_btnEdit.Text = "แก้ไข"
        '
        'tab1_btnRemove
        '
        Me.tab1_btnRemove.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnRemove.Appearance.Options.UseFont = True
        Me.tab1_btnRemove.ImageOptions.Image = CType(resources.GetObject("tab1_btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnRemove.Location = New System.Drawing.Point(306, 40)
        Me.tab1_btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnRemove.Name = "tab1_btnRemove"
        Me.tab1_btnRemove.Size = New System.Drawing.Size(83, 30)
        Me.tab1_btnRemove.TabIndex = 11
        Me.tab1_btnRemove.Text = "ลบ"
        '
        'tabControl
        '
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.tab1_SupplierFix
        Me.tabControl.Size = New System.Drawing.Size(459, 198)
        Me.tabControl.TabIndex = 7
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab1_SupplierFix})
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 556)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(459, 56)
        Me.PanelControl1.TabIndex = 10
        '
        'FmgSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 612)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FmgSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FmSupplier"
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.tab1_SupplierFix.ResumeLayout(False)
        CType(Me.tab1_GrpInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1_GrpInput.ResumeLayout(False)
        CType(Me.tab1_txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab1_txtOldName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab1_GrpBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1_GrpBtn.ResumeLayout(False)
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab1_SupplierFix As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab1_GrpInput As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab1_lblUnitName As System.Windows.Forms.Label
    Friend WithEvents tab1_btnAddList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tab1_btnDelList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_txtOldName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tab1_GrpBtn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab1_btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
