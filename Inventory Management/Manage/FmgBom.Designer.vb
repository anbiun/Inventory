<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgBom
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
        Me.gcBomList = New DevExpress.XtraGrid.GridControl()
        Me.gvBomList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBomID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.sluMat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sluBom = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grpMat = New DevExpress.XtraEditors.GroupControl()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpBomName = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBomName = New System.Windows.Forms.TextBox()
        Me.grpSave = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.grpAdd = New DevExpress.XtraEditors.GroupControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grpBtn = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gcBomList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBomList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluMat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluBom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMat.SuspendLayout()
        CType(Me.grpBomName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBomName.SuspendLayout()
        CType(Me.grpSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSave.SuspendLayout()
        CType(Me.grpAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdd.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcBomList
        '
        Me.gcBomList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBomList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcBomList.Location = New System.Drawing.Point(2, 221)
        Me.gcBomList.MainView = Me.gvBomList
        Me.gcBomList.Margin = New System.Windows.Forms.Padding(4)
        Me.gcBomList.Name = "gcBomList"
        Me.gcBomList.Size = New System.Drawing.Size(544, 443)
        Me.gcBomList.TabIndex = 8
        Me.gcBomList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBomList})
        '
        'gvBomList
        '
        Me.gvBomList.CustomizationFormBounds = New System.Drawing.Rectangle(813, 596, 210, 172)
        Me.gvBomList.GridControl = Me.gcBomList
        Me.gvBomList.Name = "gvBomList"
        Me.gvBomList.OptionsBehavior.Editable = False
        Me.gvBomList.OptionsFind.AllowFindPanel = False
        Me.gvBomList.OptionsFind.ClearFindOnClose = False
        Me.gvBomList.OptionsFind.FindDelay = 100
        Me.gvBomList.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvBomList.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvBomList.OptionsFind.ShowClearButton = False
        Me.gvBomList.OptionsFind.ShowFindButton = False
        Me.gvBomList.OptionsView.ShowGroupPanel = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "BOM. ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "BOM. Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "วันที่บันทึก"
        '
        'txtBomID
        '
        Me.txtBomID.Location = New System.Drawing.Point(85, 63)
        Me.txtBomID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBomID.Name = "txtBomID"
        Me.txtBomID.Size = New System.Drawing.Size(103, 23)
        Me.txtBomID.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "วัสดุ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "จำนวน"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(303, 9)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(56, 23)
        Me.txtQty.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(360, 21)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 23)
        Me.DateTimePicker1.TabIndex = 14
        '
        'sluMat
        '
        Me.sluMat.EditValue = ""
        Me.sluMat.Location = New System.Drawing.Point(60, 9)
        Me.sluMat.Margin = New System.Windows.Forms.Padding(4)
        Me.sluMat.Name = "sluMat"
        Me.sluMat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluMat.Properties.View = Me.GridView1
        Me.sluMat.Size = New System.Drawing.Size(133, 22)
        Me.sluMat.TabIndex = 15
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'sluBom
        '
        Me.sluBom.Location = New System.Drawing.Point(85, 22)
        Me.sluBom.Margin = New System.Windows.Forms.Padding(4)
        Me.sluBom.Name = "sluBom"
        Me.sluBom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluBom.Properties.View = Me.SearchLookUpEdit1View
        Me.sluBom.Size = New System.Drawing.Size(105, 22)
        Me.sluBom.TabIndex = 21
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grpMat
        '
        Me.grpMat.Controls.Add(Me.Label5)
        Me.grpMat.Controls.Add(Me.btnRemove)
        Me.grpMat.Controls.Add(Me.btnAdd)
        Me.grpMat.Controls.Add(Me.txtQty)
        Me.grpMat.Controls.Add(Me.Label6)
        Me.grpMat.Controls.Add(Me.Label4)
        Me.grpMat.Controls.Add(Me.sluMat)
        Me.grpMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpMat.Location = New System.Drawing.Point(2, 178)
        Me.grpMat.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMat.Name = "grpMat"
        Me.grpMat.ShowCaption = False
        Me.grpMat.Size = New System.Drawing.Size(544, 43)
        Me.grpMat.TabIndex = 18
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(481, 5)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(47, 28)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "-"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(427, 5)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(47, 28)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ชิ้น"
        '
        'grpBomName
        '
        Me.grpBomName.Controls.Add(Me.LabelControl1)
        Me.grpBomName.Controls.Add(Me.Label2)
        Me.grpBomName.Controls.Add(Me.DateTimePicker1)
        Me.grpBomName.Controls.Add(Me.txtBomID)
        Me.grpBomName.Controls.Add(Me.Label3)
        Me.grpBomName.Controls.Add(Me.txtBomName)
        Me.grpBomName.Controls.Add(Me.Label1)
        Me.grpBomName.Controls.Add(Me.sluBom)
        Me.grpBomName.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBomName.Location = New System.Drawing.Point(2, 25)
        Me.grpBomName.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBomName.Name = "grpBomName"
        Me.grpBomName.ShowCaption = False
        Me.grpBomName.Size = New System.Drawing.Size(544, 100)
        Me.grpBomName.TabIndex = 20
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(41, 25)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 17)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Text = "ค้นหา"
        '
        'txtBomName
        '
        Me.txtBomName.Location = New System.Drawing.Point(360, 60)
        Me.txtBomName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBomName.Name = "txtBomName"
        Me.txtBomName.Size = New System.Drawing.Size(168, 23)
        Me.txtBomName.TabIndex = 13
        '
        'grpSave
        '
        Me.grpSave.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grpSave.Controls.Add(Me.btnCancel)
        Me.grpSave.Controls.Add(Me.btnSave)
        Me.grpSave.Location = New System.Drawing.Point(347, 7)
        Me.grpSave.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSave.Name = "grpSave"
        Me.grpSave.ShowCaption = False
        Me.grpSave.Size = New System.Drawing.Size(183, 37)
        Me.grpSave.TabIndex = 24
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(7, 7)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 23)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "ยกเลิก"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(95, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "บันทึก"
        '
        'grpAdd
        '
        Me.grpAdd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grpAdd.Controls.Add(Me.btnNew)
        Me.grpAdd.Controls.Add(Me.btnEdit)
        Me.grpAdd.Controls.Add(Me.btnDelete)
        Me.grpAdd.Location = New System.Drawing.Point(17, 7)
        Me.grpAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.ShowCaption = False
        Me.grpAdd.Size = New System.Drawing.Size(268, 37)
        Me.grpAdd.TabIndex = 21
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(7, 6)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 23)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "ใหม่"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(93, 6)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 23)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "แก้ไข"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(181, 6)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "ลบ"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.gcBomList)
        Me.GroupControl1.Controls.Add(Me.grpMat)
        Me.GroupControl1.Controls.Add(Me.grpBtn)
        Me.GroupControl1.Controls.Add(Me.grpBomName)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(548, 666)
        Me.GroupControl1.TabIndex = 20
        '
        'grpBtn
        '
        Me.grpBtn.Controls.Add(Me.grpAdd)
        Me.grpBtn.Controls.Add(Me.grpSave)
        Me.grpBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBtn.Location = New System.Drawing.Point(2, 125)
        Me.grpBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBtn.Name = "grpBtn"
        Me.grpBtn.ShowCaption = False
        Me.grpBtn.Size = New System.Drawing.Size(544, 53)
        Me.grpBtn.TabIndex = 25
        Me.grpBtn.TabStop = True
        '
        'frmBomManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 666)
        Me.Controls.Add(Me.GroupControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBomManager"
        Me.Text = "frmBomManager"
        CType(Me.gcBomList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBomList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluMat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluBom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMat.ResumeLayout(False)
        Me.grpMat.PerformLayout()
        CType(Me.grpBomName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBomName.ResumeLayout(False)
        Me.grpBomName.PerformLayout()
        CType(Me.grpSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSave.ResumeLayout(False)
        CType(Me.grpAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdd.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcBomList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBomList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBomID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents sluMat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBomName As System.Windows.Forms.TextBox
    Friend WithEvents grpMat As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpBomName As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sluBom As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpAdd As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpSave As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpBtn As DevExpress.XtraEditors.GroupControl
End Class
