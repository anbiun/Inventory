<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgSubMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgSubMat))
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GrpBtn = New DevExpress.XtraEditors.GroupControl()
        Me.slSubCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slMat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.tabSubMat = New DevExpress.XtraTab.XtraTabPage()
        Me.GrpInput = New DevExpress.XtraEditors.GroupControl()
        Me.lblUnitName = New System.Windows.Forms.Label()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.btnDelList = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddList = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBtn.SuspendLayout()
        CType(Me.slSubCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slMat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tabSubMat.SuspendLayout()
        CType(Me.GrpInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpInput.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(0, 269)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(442, 398)
        Me.gcList.TabIndex = 7
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
        'GrpBtn
        '
        Me.GrpBtn.Controls.Add(Me.slSubCat)
        Me.GrpBtn.Controls.Add(Me.slMat)
        Me.GrpBtn.Controls.Add(Me.Label2)
        Me.GrpBtn.Controls.Add(Me.Label1)
        Me.GrpBtn.Controls.Add(Me.btnNew)
        Me.GrpBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpBtn.Location = New System.Drawing.Point(0, 0)
        Me.GrpBtn.Name = "GrpBtn"
        Me.GrpBtn.Size = New System.Drawing.Size(435, 234)
        Me.GrpBtn.TabIndex = 24
        Me.GrpBtn.Text = "เลือกการทำงาน"
        '
        'slSubCat
        '
        Me.slSubCat.Location = New System.Drawing.Point(146, 53)
        Me.slSubCat.Name = "slSubCat"
        Me.slSubCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slSubCat.Properties.Appearance.Options.UseFont = True
        Me.slSubCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slSubCat.Size = New System.Drawing.Size(172, 28)
        Me.slSubCat.TabIndex = 21
        '
        'slMat
        '
        Me.slMat.Location = New System.Drawing.Point(145, 87)
        Me.slMat.Name = "slMat"
        Me.slMat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slMat.Properties.Appearance.Options.UseFont = True
        Me.slMat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slMat.Size = New System.Drawing.Size(172, 28)
        Me.slMat.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ประเภท :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ชื่อวัสดุหลัก :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(322, 88)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 30)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "เลือก"
        '
        'tabControl
        '
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.tabSubMat
        Me.tabControl.Size = New System.Drawing.Size(442, 269)
        Me.tabControl.TabIndex = 8
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSubMat})
        '
        'tabSubMat
        '
        Me.tabSubMat.Controls.Add(Me.GrpInput)
        Me.tabSubMat.Controls.Add(Me.GrpBtn)
        Me.tabSubMat.Margin = New System.Windows.Forms.Padding(2)
        Me.tabSubMat.Name = "tabSubMat"
        Me.tabSubMat.Size = New System.Drawing.Size(435, 234)
        Me.tabSubMat.Text = "ข้อมูลเบอร์ร่วม"
        '
        'GrpInput
        '
        Me.GrpInput.Controls.Add(Me.lblUnitName)
        Me.GrpInput.Controls.Add(Me.txtName)
        Me.GrpInput.Controls.Add(Me.btnDelList)
        Me.GrpInput.Controls.Add(Me.btnAddList)
        Me.GrpInput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrpInput.Location = New System.Drawing.Point(0, 158)
        Me.GrpInput.Name = "GrpInput"
        Me.GrpInput.ShowCaption = False
        Me.GrpInput.Size = New System.Drawing.Size(435, 76)
        Me.GrpInput.TabIndex = 25
        '
        'lblUnitName
        '
        Me.lblUnitName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitName.Location = New System.Drawing.Point(11, 12)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(128, 22)
        Me.lblUnitName.TabIndex = 20
        Me.lblUnitName.Text = "ชื่อวัสดุใช้ร่วม :"
        Me.lblUnitName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(145, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Size = New System.Drawing.Size(264, 28)
        Me.txtName.TabIndex = 23
        '
        'btnDelList
        '
        Me.btnDelList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelList.Appearance.Options.UseFont = True
        Me.btnDelList.ImageOptions.Image = CType(resources.GetObject("btnDelList.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelList.Location = New System.Drawing.Point(146, 42)
        Me.btnDelList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelList.Name = "btnDelList"
        Me.btnDelList.Size = New System.Drawing.Size(130, 27)
        Me.btnDelList.TabIndex = 11
        Me.btnDelList.Text = "ลบรายการ"
        '
        'btnAddList
        '
        Me.btnAddList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList.Appearance.Options.UseFont = True
        Me.btnAddList.ImageOptions.Image = CType(resources.GetObject("btnAddList.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddList.Location = New System.Drawing.Point(280, 42)
        Me.btnAddList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(130, 27)
        Me.btnAddList.TabIndex = 11
        Me.btnAddList.Text = "เพิ่มรายการ"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnCancle)
        Me.GroupControl3.Controls.Add(Me.btnSave)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl3.Location = New System.Drawing.Point(240, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(200, 52)
        Me.GroupControl3.TabIndex = 9
        Me.GroupControl3.Text = "GroupControl3"
        '
        'btnCancle
        '
        Me.btnCancle.ImageOptions.Image = CType(resources.GetObject("btnCancle.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancle.Location = New System.Drawing.Point(4, 5)
        Me.btnCancle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(77, 40)
        Me.btnCancle.TabIndex = 3
        Me.btnCancle.Text = "ยกเลิก"
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(112, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 40)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "บันทึก"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 667)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(442, 56)
        Me.PanelControl1.TabIndex = 10
        '
        'FmgSubMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(442, 723)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(460, 770)
        Me.MinimumSize = New System.Drawing.Size(460, 770)
        Me.Name = "FmgSubMat"
        Me.Text = "ข้อมูลเบอร์ร่วม"
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBtn.ResumeLayout(False)
        CType(Me.slSubCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slMat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tabSubMat.ResumeLayout(False)
        CType(Me.GrpInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpInput.ResumeLayout(False)
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GrpBtn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabSubMat As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GrpInput As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblUnitName As System.Windows.Forms.Label
    Friend WithEvents btnAddList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDelList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents slMat As DevExpress.XtraEditors.SearchLookUpEdit
    'Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents slSubCat As DevExpress.XtraEditors.SearchLookUpEdit
    'Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
