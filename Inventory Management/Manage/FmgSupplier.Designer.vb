﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmgSupplier
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tab1_lblUnitName = New System.Windows.Forms.Label()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.grpSupplier = New DevExpress.XtraEditors.GroupControl()
        Me.BtnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMat = New DevExpress.XtraEditors.GroupControl()
        Me.BtnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRatio = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.sluSubCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.lblUnit3_name = New DevExpress.XtraEditors.LabelControl()
        Me.PnlSave = New DevExpress.XtraEditors.PanelControl()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.PnlLeft = New DevExpress.XtraEditors.PanelControl()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSupplier.SuspendLayout()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMat.SuspendLayout()
        CType(Me.txtRatio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluSubCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSave.SuspendLayout()
        CType(Me.PnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.gcList.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcList.Location = New System.Drawing.Point(342, 0)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(766, 492)
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
        'tab1_lblUnitName
        '
        Me.tab1_lblUnitName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_lblUnitName.Location = New System.Drawing.Point(52, 44)
        Me.tab1_lblUnitName.Name = "tab1_lblUnitName"
        Me.tab1_lblUnitName.Size = New System.Drawing.Size(83, 22)
        Me.tab1_lblUnitName.TabIndex = 20
        Me.tab1_lblUnitName.Text = "ชื่อผู้ขาย"
        Me.tab1_lblUnitName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(151, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Size = New System.Drawing.Size(174, 28)
        Me.txtName.TabIndex = 23
        '
        'grpSupplier
        '
        Me.grpSupplier.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSupplier.AppearanceCaption.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpSupplier.AppearanceCaption.Options.UseFont = True
        Me.grpSupplier.AppearanceCaption.Options.UseForeColor = True
        Me.grpSupplier.Controls.Add(Me.BtnNew)
        Me.grpSupplier.Controls.Add(Me.txtAddress)
        Me.grpSupplier.Controls.Add(Me.txtName)
        Me.grpSupplier.Controls.Add(Me.Label1)
        Me.grpSupplier.Controls.Add(Me.tab1_lblUnitName)
        Me.grpSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSupplier.Location = New System.Drawing.Point(2, 2)
        Me.grpSupplier.Name = "grpSupplier"
        Me.grpSupplier.Size = New System.Drawing.Size(338, 230)
        Me.grpSupplier.TabIndex = 24
        Me.grpSupplier.Text = "รายละเอียดผู้ขาย"
        '
        'BtnNew
        '
        Me.BtnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnNew.Appearance.Options.UseFont = True
        Me.BtnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnNew.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_32x32
        Me.BtnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(151, 184)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(174, 35)
        Me.BtnNew.TabIndex = 25
        Me.BtnNew.Text = "ตกลง"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(151, 79)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(174, 96)
        Me.txtAddress.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ที่อยู่"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpMat
        '
        Me.grpMat.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMat.AppearanceCaption.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpMat.AppearanceCaption.Options.UseFont = True
        Me.grpMat.AppearanceCaption.Options.UseForeColor = True
        Me.grpMat.Controls.Add(Me.BtnAdd)
        Me.grpMat.Controls.Add(Me.txtRatio)
        Me.grpMat.Controls.Add(Me.LabelControl3)
        Me.grpMat.Controls.Add(Me.sluSubCat)
        Me.grpMat.Controls.Add(Me.LabelControl13)
        Me.grpMat.Controls.Add(Me.lblUnit3_name)
        Me.grpMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpMat.Location = New System.Drawing.Point(2, 232)
        Me.grpMat.Name = "grpMat"
        Me.grpMat.Size = New System.Drawing.Size(338, 156)
        Me.grpMat.TabIndex = 30
        Me.grpMat.Text = "วัสดุที่ขาย"
        '
        'BtnAdd
        '
        Me.BtnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnAdd.Appearance.Options.UseFont = True
        Me.BtnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnAdd.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.forward_16x161
        Me.BtnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnAdd.Location = New System.Drawing.Point(151, 107)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(174, 35)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "เพิ่มรายการ"
        '
        'txtRatio
        '
        Me.txtRatio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRatio.Location = New System.Drawing.Point(151, 72)
        Me.txtRatio.Name = "txtRatio"
        Me.txtRatio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRatio.Properties.Appearance.Options.UseFont = True
        Me.txtRatio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRatio.Properties.MaxLength = 6
        Me.txtRatio.Size = New System.Drawing.Size(112, 28)
        Me.txtRatio.TabIndex = 12
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(43, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 21)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "ประเภทวัสดุ"
        '
        'sluSubCat
        '
        Me.sluSubCat.EditValue = ""
        Me.sluSubCat.Location = New System.Drawing.Point(151, 38)
        Me.sluSubCat.Name = "sluSubCat"
        Me.sluSubCat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.sluSubCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sluSubCat.Properties.Appearance.Options.UseFont = True
        Me.sluSubCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluSubCat.Properties.NullText = ""
        Me.sluSubCat.Properties.NullValuePrompt = "กรุณาเลือก"
        Me.sluSubCat.Properties.NullValuePromptShowForEmptyValue = True
        Me.sluSubCat.Properties.View = Me.GridView1
        Me.sluSubCat.Size = New System.Drawing.Size(174, 28)
        Me.sluSubCat.TabIndex = 10
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(13, 75)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(107, 21)
        Me.LabelControl13.TabIndex = 13
        Me.LabelControl13.Text = "ขนาดบรรจุภันฑ์"
        '
        'lblUnit3_name
        '
        Me.lblUnit3_name.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit3_name.Appearance.Options.UseFont = True
        Me.lblUnit3_name.Location = New System.Drawing.Point(269, 75)
        Me.lblUnit3_name.Name = "lblUnit3_name"
        Me.lblUnit3_name.Size = New System.Drawing.Size(21, 21)
        Me.lblUnit3_name.TabIndex = 9
        Me.lblUnit3_name.Text = "ชิ้น"
        '
        'PnlSave
        '
        Me.PnlSave.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PnlSave.Appearance.Options.UseBackColor = True
        Me.PnlSave.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnlSave.Controls.Add(Me.BtnSave)
        Me.PnlSave.Controls.Add(Me.BtnCancel)
        Me.PnlSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSave.Location = New System.Drawing.Point(2, 388)
        Me.PnlSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlSave.Name = "PnlSave"
        Me.PnlSave.Size = New System.Drawing.Size(338, 102)
        Me.PnlSave.TabIndex = 31
        Me.PnlSave.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnSave.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.download_32x32
        Me.BtnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(193, 4)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(132, 35)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "บันทึก"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnCancel.Appearance.Options.UseFont = True
        Me.BtnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnCancel.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.undo_16x16
        Me.BtnCancel.Location = New System.Drawing.Point(43, 4)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(132, 35)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "ยกเลิก"
        '
        'PnlLeft
        '
        Me.PnlLeft.Controls.Add(Me.PnlSave)
        Me.PnlLeft.Controls.Add(Me.grpMat)
        Me.PnlLeft.Controls.Add(Me.grpSupplier)
        Me.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Size = New System.Drawing.Size(342, 492)
        Me.PnlLeft.TabIndex = 32
        '
        'FmgSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 492)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.PnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FmgSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลผู้ขาย"
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSupplier.ResumeLayout(False)
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMat.ResumeLayout(False)
        Me.grpMat.PerformLayout()
        CType(Me.txtRatio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluSubCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSave.ResumeLayout(False)
        CType(Me.PnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tab1_lblUnitName As System.Windows.Forms.Label
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpSupplier As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpMat As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sluSubCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PnlSave As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PnlLeft As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtRatio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblUnit3_name As DevExpress.XtraEditors.LabelControl
End Class
