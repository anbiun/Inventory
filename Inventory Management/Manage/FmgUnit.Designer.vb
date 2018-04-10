<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgUnit))
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.tab1_AddUnit = New DevExpress.XtraTab.XtraTabPage()
        Me.tab1_GrpInput = New DevExpress.XtraEditors.GroupControl()
        Me.tab1_lblUnitName = New System.Windows.Forms.Label()
        Me.tab1_btnAddList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_txtUnitName = New DevExpress.XtraEditors.TextEdit()
        Me.tab1_btnDelList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_txtUnitOldName = New DevExpress.XtraEditors.TextEdit()
        Me.tab1_GrpBtn = New DevExpress.XtraEditors.GroupControl()
        Me.tab1_btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.tab1_btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.tab2_FixUnit = New DevExpress.XtraTab.XtraTabPage()
        Me.tab2_GrpSubU = New DevExpress.XtraEditors.GroupControl()
        Me.tab2_luSubU = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab2_btnAddList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab2_btnDelList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab2_GrpSelect = New DevExpress.XtraEditors.GroupControl()
        Me.tab2_BtnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.tab2_luUnit = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tab2_btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.tab3_FixMat = New DevExpress.XtraTab.XtraTabPage()
        Me.tab3_UnitSelect = New DevExpress.XtraEditors.GroupControl()
        Me.tab3_luUnit = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tab3_btnAddList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab3_btnDelList = New DevExpress.XtraEditors.SimpleButton()
        Me.tab3_MatSelect = New DevExpress.XtraEditors.GroupControl()
        Me.tab3_luMat = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tab3_btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.tab3_btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancle = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tab1_AddUnit.SuspendLayout()
        CType(Me.tab1_GrpInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1_GrpInput.SuspendLayout()
        CType(Me.tab1_txtUnitName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab1_txtUnitOldName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab1_GrpBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1_GrpBtn.SuspendLayout()
        Me.tab2_FixUnit.SuspendLayout()
        CType(Me.tab2_GrpSubU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab2_GrpSubU.SuspendLayout()
        CType(Me.tab2_luSubU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab2_GrpSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab2_GrpSelect.SuspendLayout()
        CType(Me.tab2_luUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab3_FixMat.SuspendLayout()
        CType(Me.tab3_UnitSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab3_UnitSelect.SuspendLayout()
        CType(Me.tab3_luUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab3_MatSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab3_MatSelect.SuspendLayout()
        CType(Me.tab3_luMat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.tab1_AddUnit
        Me.tabControl.Size = New System.Drawing.Size(508, 225)
        Me.tabControl.TabIndex = 4
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab1_AddUnit, Me.tab2_FixUnit, Me.tab3_FixMat})
        '
        'tab1_AddUnit
        '
        Me.tab1_AddUnit.Controls.Add(Me.tab1_GrpInput)
        Me.tab1_AddUnit.Controls.Add(Me.tab1_GrpBtn)
        Me.tab1_AddUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_AddUnit.Name = "tab1_AddUnit"
        Me.tab1_AddUnit.Size = New System.Drawing.Size(501, 190)
        Me.tab1_AddUnit.Text = "เพิ่มหน่วยใหม่"
        '
        'tab1_GrpInput
        '
        Me.tab1_GrpInput.Controls.Add(Me.tab1_lblUnitName)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_btnAddList)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_txtUnitName)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_btnDelList)
        Me.tab1_GrpInput.Controls.Add(Me.tab1_txtUnitOldName)
        Me.tab1_GrpInput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tab1_GrpInput.Location = New System.Drawing.Point(0, 87)
        Me.tab1_GrpInput.Name = "tab1_GrpInput"
        Me.tab1_GrpInput.ShowCaption = False
        Me.tab1_GrpInput.Size = New System.Drawing.Size(501, 103)
        Me.tab1_GrpInput.TabIndex = 25
        '
        'tab1_lblUnitName
        '
        Me.tab1_lblUnitName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_lblUnitName.Location = New System.Drawing.Point(5, 10)
        Me.tab1_lblUnitName.Name = "tab1_lblUnitName"
        Me.tab1_lblUnitName.Size = New System.Drawing.Size(110, 22)
        Me.tab1_lblUnitName.TabIndex = 20
        Me.tab1_lblUnitName.Text = "ชื่อหน่วย"
        Me.tab1_lblUnitName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tab1_btnAddList
        '
        Me.tab1_btnAddList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnAddList.Appearance.Options.UseFont = True
        Me.tab1_btnAddList.ImageOptions.Image = CType(resources.GetObject("tab1_btnAddList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnAddList.Location = New System.Drawing.Point(255, 44)
        Me.tab1_btnAddList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnAddList.Name = "tab1_btnAddList"
        Me.tab1_btnAddList.Size = New System.Drawing.Size(130, 27)
        Me.tab1_btnAddList.TabIndex = 11
        Me.tab1_btnAddList.Text = "เพิ่มรายการ"
        '
        'tab1_txtUnitName
        '
        Me.tab1_txtUnitName.Location = New System.Drawing.Point(121, 7)
        Me.tab1_txtUnitName.Name = "tab1_txtUnitName"
        Me.tab1_txtUnitName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_txtUnitName.Properties.Appearance.Options.UseFont = True
        Me.tab1_txtUnitName.Size = New System.Drawing.Size(264, 28)
        Me.tab1_txtUnitName.TabIndex = 23
        '
        'tab1_btnDelList
        '
        Me.tab1_btnDelList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnDelList.Appearance.Options.UseFont = True
        Me.tab1_btnDelList.ImageOptions.Image = CType(resources.GetObject("tab1_btnDelList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnDelList.Location = New System.Drawing.Point(121, 44)
        Me.tab1_btnDelList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnDelList.Name = "tab1_btnDelList"
        Me.tab1_btnDelList.Size = New System.Drawing.Size(130, 27)
        Me.tab1_btnDelList.TabIndex = 11
        Me.tab1_btnDelList.Text = "ลบรายการ"
        '
        'tab1_txtUnitOldName
        '
        Me.tab1_txtUnitOldName.Location = New System.Drawing.Point(121, 43)
        Me.tab1_txtUnitOldName.Name = "tab1_txtUnitOldName"
        Me.tab1_txtUnitOldName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_txtUnitOldName.Properties.Appearance.Options.UseFont = True
        Me.tab1_txtUnitOldName.Size = New System.Drawing.Size(264, 28)
        Me.tab1_txtUnitOldName.TabIndex = 23
        '
        'tab1_GrpBtn
        '
        Me.tab1_GrpBtn.Controls.Add(Me.tab1_btnNew)
        Me.tab1_GrpBtn.Controls.Add(Me.tab1_btnEdit)
        Me.tab1_GrpBtn.Controls.Add(Me.tab1_btnRemove)
        Me.tab1_GrpBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.tab1_GrpBtn.Location = New System.Drawing.Point(0, 0)
        Me.tab1_GrpBtn.Name = "tab1_GrpBtn"
        Me.tab1_GrpBtn.Size = New System.Drawing.Size(501, 190)
        Me.tab1_GrpBtn.TabIndex = 24
        Me.tab1_GrpBtn.Text = "เลือกการทำงาน"
        '
        'tab1_btnNew
        '
        Me.tab1_btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1_btnNew.Appearance.Options.UseFont = True
        Me.tab1_btnNew.ImageOptions.Image = CType(resources.GetObject("tab1_btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.tab1_btnNew.Location = New System.Drawing.Point(50, 49)
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
        Me.tab1_btnEdit.Location = New System.Drawing.Point(212, 49)
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
        Me.tab1_btnRemove.Location = New System.Drawing.Point(302, 49)
        Me.tab1_btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.tab1_btnRemove.Name = "tab1_btnRemove"
        Me.tab1_btnRemove.Size = New System.Drawing.Size(83, 30)
        Me.tab1_btnRemove.TabIndex = 11
        Me.tab1_btnRemove.Text = "ลบ"
        '
        'tab2_FixUnit
        '
        Me.tab2_FixUnit.Controls.Add(Me.tab2_GrpSubU)
        Me.tab2_FixUnit.Controls.Add(Me.tab2_GrpSelect)
        Me.tab2_FixUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.tab2_FixUnit.Name = "tab2_FixUnit"
        Me.tab2_FixUnit.Size = New System.Drawing.Size(501, 190)
        Me.tab2_FixUnit.Text = "กำหนดหน่วย"
        '
        'tab2_GrpSubU
        '
        Me.tab2_GrpSubU.Controls.Add(Me.tab2_luSubU)
        Me.tab2_GrpSubU.Controls.Add(Me.Label1)
        Me.tab2_GrpSubU.Controls.Add(Me.tab2_btnAddList)
        Me.tab2_GrpSubU.Controls.Add(Me.tab2_btnDelList)
        Me.tab2_GrpSubU.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tab2_GrpSubU.Location = New System.Drawing.Point(0, 95)
        Me.tab2_GrpSubU.Name = "tab2_GrpSubU"
        Me.tab2_GrpSubU.Size = New System.Drawing.Size(501, 95)
        Me.tab2_GrpSubU.TabIndex = 27
        Me.tab2_GrpSubU.Text = "เลือกหน่วยที่อยู่ภายใต้ [ ]"
        '
        'tab2_luSubU
        '
        Me.tab2_luSubU.Location = New System.Drawing.Point(108, 28)
        Me.tab2_luSubU.Name = "tab2_luSubU"
        Me.tab2_luSubU.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2_luSubU.Properties.Appearance.Options.UseFont = True
        Me.tab2_luSubU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tab2_luSubU.Size = New System.Drawing.Size(264, 28)
        Me.tab2_luSubU.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "หน่วยย่อย"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tab2_btnAddList
        '
        Me.tab2_btnAddList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2_btnAddList.Appearance.Options.UseFont = True
        Me.tab2_btnAddList.ImageOptions.Image = CType(resources.GetObject("tab2_btnAddList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab2_btnAddList.Location = New System.Drawing.Point(242, 61)
        Me.tab2_btnAddList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab2_btnAddList.Name = "tab2_btnAddList"
        Me.tab2_btnAddList.Size = New System.Drawing.Size(130, 27)
        Me.tab2_btnAddList.TabIndex = 11
        Me.tab2_btnAddList.Text = "เพิ่มรายการ"
        '
        'tab2_btnDelList
        '
        Me.tab2_btnDelList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2_btnDelList.Appearance.Options.UseFont = True
        Me.tab2_btnDelList.ImageOptions.Image = CType(resources.GetObject("tab2_btnDelList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab2_btnDelList.Location = New System.Drawing.Point(108, 61)
        Me.tab2_btnDelList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab2_btnDelList.Name = "tab2_btnDelList"
        Me.tab2_btnDelList.Size = New System.Drawing.Size(130, 27)
        Me.tab2_btnDelList.TabIndex = 11
        Me.tab2_btnDelList.Text = "ลบรายการ"
        '
        'tab2_GrpSelect
        '
        Me.tab2_GrpSelect.Controls.Add(Me.tab2_BtnRemove)
        Me.tab2_GrpSelect.Controls.Add(Me.tab2_luUnit)
        Me.tab2_GrpSelect.Controls.Add(Me.Label3)
        Me.tab2_GrpSelect.Controls.Add(Me.tab2_btnOK)
        Me.tab2_GrpSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab2_GrpSelect.Location = New System.Drawing.Point(0, 0)
        Me.tab2_GrpSelect.Name = "tab2_GrpSelect"
        Me.tab2_GrpSelect.Size = New System.Drawing.Size(501, 190)
        Me.tab2_GrpSelect.TabIndex = 26
        Me.tab2_GrpSelect.Text = "เลือกหน่วยที่นำไปใช้เป็นหน่วยนับ"
        '
        'tab2_BtnRemove
        '
        Me.tab2_BtnRemove.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2_BtnRemove.Appearance.Options.UseFont = True
        Me.tab2_BtnRemove.ImageOptions.Image = CType(resources.GetObject("tab2_BtnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.tab2_BtnRemove.Location = New System.Drawing.Point(108, 64)
        Me.tab2_BtnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.tab2_BtnRemove.Name = "tab2_BtnRemove"
        Me.tab2_BtnRemove.Size = New System.Drawing.Size(87, 27)
        Me.tab2_BtnRemove.TabIndex = 20
        Me.tab2_BtnRemove.Text = "ลบ"
        '
        'tab2_luUnit
        '
        Me.tab2_luUnit.Location = New System.Drawing.Point(108, 31)
        Me.tab2_luUnit.Name = "tab2_luUnit"
        Me.tab2_luUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2_luUnit.Properties.Appearance.Options.UseFont = True
        Me.tab2_luUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tab2_luUnit.Size = New System.Drawing.Size(264, 28)
        Me.tab2_luUnit.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "หน่วยนับ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tab2_btnOK
        '
        Me.tab2_btnOK.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2_btnOK.Appearance.Options.UseFont = True
        Me.tab2_btnOK.ImageOptions.Image = CType(resources.GetObject("tab2_btnOK.ImageOptions.Image"), System.Drawing.Image)
        Me.tab2_btnOK.Location = New System.Drawing.Point(224, 64)
        Me.tab2_btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.tab2_btnOK.Name = "tab2_btnOK"
        Me.tab2_btnOK.Size = New System.Drawing.Size(148, 27)
        Me.tab2_btnOK.TabIndex = 11
        Me.tab2_btnOK.Text = "เลือก/แก้ไข"
        '
        'tab3_FixMat
        '
        Me.tab3_FixMat.Controls.Add(Me.tab3_UnitSelect)
        Me.tab3_FixMat.Controls.Add(Me.tab3_MatSelect)
        Me.tab3_FixMat.Margin = New System.Windows.Forms.Padding(2)
        Me.tab3_FixMat.Name = "tab3_FixMat"
        Me.tab3_FixMat.Size = New System.Drawing.Size(501, 190)
        Me.tab3_FixMat.Text = "กำหนดวัสดุ"
        '
        'tab3_UnitSelect
        '
        Me.tab3_UnitSelect.Controls.Add(Me.tab3_luUnit)
        Me.tab3_UnitSelect.Controls.Add(Me.Label2)
        Me.tab3_UnitSelect.Controls.Add(Me.tab3_btnAddList)
        Me.tab3_UnitSelect.Controls.Add(Me.tab3_btnDelList)
        Me.tab3_UnitSelect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tab3_UnitSelect.Location = New System.Drawing.Point(0, 96)
        Me.tab3_UnitSelect.Name = "tab3_UnitSelect"
        Me.tab3_UnitSelect.Size = New System.Drawing.Size(501, 94)
        Me.tab3_UnitSelect.TabIndex = 29
        Me.tab3_UnitSelect.Text = "เลือกหน่วยนับที่ใช้สำหรับ [ ]"
        '
        'tab3_luUnit
        '
        Me.tab3_luUnit.Location = New System.Drawing.Point(108, 28)
        Me.tab3_luUnit.Name = "tab3_luUnit"
        Me.tab3_luUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3_luUnit.Properties.Appearance.Options.UseFont = True
        Me.tab3_luUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tab3_luUnit.Size = New System.Drawing.Size(264, 28)
        Me.tab3_luUnit.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "หน่วยนับ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tab3_btnAddList
        '
        Me.tab3_btnAddList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3_btnAddList.Appearance.Options.UseFont = True
        Me.tab3_btnAddList.ImageOptions.Image = CType(resources.GetObject("tab3_btnAddList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab3_btnAddList.Location = New System.Drawing.Point(242, 61)
        Me.tab3_btnAddList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab3_btnAddList.Name = "tab3_btnAddList"
        Me.tab3_btnAddList.Size = New System.Drawing.Size(130, 27)
        Me.tab3_btnAddList.TabIndex = 11
        Me.tab3_btnAddList.Text = "เพิ่มรายการ"
        '
        'tab3_btnDelList
        '
        Me.tab3_btnDelList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3_btnDelList.Appearance.Options.UseFont = True
        Me.tab3_btnDelList.ImageOptions.Image = CType(resources.GetObject("tab3_btnDelList.ImageOptions.Image"), System.Drawing.Image)
        Me.tab3_btnDelList.Location = New System.Drawing.Point(108, 61)
        Me.tab3_btnDelList.Margin = New System.Windows.Forms.Padding(2)
        Me.tab3_btnDelList.Name = "tab3_btnDelList"
        Me.tab3_btnDelList.Size = New System.Drawing.Size(130, 27)
        Me.tab3_btnDelList.TabIndex = 11
        Me.tab3_btnDelList.Text = "ลบรายการ"
        '
        'tab3_MatSelect
        '
        Me.tab3_MatSelect.Controls.Add(Me.tab3_luMat)
        Me.tab3_MatSelect.Controls.Add(Me.Label4)
        Me.tab3_MatSelect.Controls.Add(Me.tab3_btnRemove)
        Me.tab3_MatSelect.Controls.Add(Me.tab3_btnOk)
        Me.tab3_MatSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab3_MatSelect.Location = New System.Drawing.Point(0, 0)
        Me.tab3_MatSelect.Name = "tab3_MatSelect"
        Me.tab3_MatSelect.Size = New System.Drawing.Size(501, 190)
        Me.tab3_MatSelect.TabIndex = 28
        Me.tab3_MatSelect.Text = "เลือกประเภทวัสดุ"
        '
        'tab3_luMat
        '
        Me.tab3_luMat.Location = New System.Drawing.Point(108, 31)
        Me.tab3_luMat.Name = "tab3_luMat"
        Me.tab3_luMat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3_luMat.Properties.Appearance.Options.UseFont = True
        Me.tab3_luMat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tab3_luMat.Size = New System.Drawing.Size(264, 28)
        Me.tab3_luMat.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ประเภทวัสดุ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tab3_btnRemove
        '
        Me.tab3_btnRemove.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3_btnRemove.Appearance.Options.UseFont = True
        Me.tab3_btnRemove.ImageOptions.Image = CType(resources.GetObject("tab3_btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.tab3_btnRemove.Location = New System.Drawing.Point(108, 64)
        Me.tab3_btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.tab3_btnRemove.Name = "tab3_btnRemove"
        Me.tab3_btnRemove.Size = New System.Drawing.Size(87, 27)
        Me.tab3_btnRemove.TabIndex = 11
        Me.tab3_btnRemove.Text = "ลบ"
        '
        'tab3_btnOk
        '
        Me.tab3_btnOk.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3_btnOk.Appearance.Options.UseFont = True
        Me.tab3_btnOk.ImageOptions.Image = CType(resources.GetObject("tab3_btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.tab3_btnOk.Location = New System.Drawing.Point(224, 64)
        Me.tab3_btnOk.Margin = New System.Windows.Forms.Padding(2)
        Me.tab3_btnOk.Name = "tab3_btnOk"
        Me.tab3_btnOk.Size = New System.Drawing.Size(148, 27)
        Me.tab3_btnOk.TabIndex = 11
        Me.tab3_btnOk.Text = "เลือก/แก้ไข"
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(112, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 40)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "บันทึก"
        '
        'btnCancle
        '
        Me.btnCancle.ImageOptions.Image = CType(resources.GetObject("btnCancle.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancle.Location = New System.Drawing.Point(4, 4)
        Me.btnCancle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(77, 40)
        Me.btnCancle.TabIndex = 3
        Me.btnCancle.Text = "ยกเลิก"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnCancle)
        Me.GroupControl3.Controls.Add(Me.btnSave)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl3.Location = New System.Drawing.Point(303, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(203, 47)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "GroupControl3"
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(0, 225)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(508, 437)
        Me.gcList.TabIndex = 6
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 662)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(508, 51)
        Me.PanelControl1.TabIndex = 7
        '
        'FmgUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 713)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FmgUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตั้งค่าหน่วยการใช้งาน"
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tab1_AddUnit.ResumeLayout(False)
        CType(Me.tab1_GrpInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1_GrpInput.ResumeLayout(False)
        CType(Me.tab1_txtUnitName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab1_txtUnitOldName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab1_GrpBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1_GrpBtn.ResumeLayout(False)
        Me.tab2_FixUnit.ResumeLayout(False)
        CType(Me.tab2_GrpSubU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab2_GrpSubU.ResumeLayout(False)
        CType(Me.tab2_luSubU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab2_GrpSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab2_GrpSelect.ResumeLayout(False)
        CType(Me.tab2_luUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab3_FixMat.ResumeLayout(False)
        CType(Me.tab3_UnitSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab3_UnitSelect.ResumeLayout(False)
        CType(Me.tab3_luUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab3_MatSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab3_MatSelect.ResumeLayout(False)
        CType(Me.tab3_luMat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tab1_AddUnit As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab2_FixUnit As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab3_FixMat As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tab2_luUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tab1_lblUnitName As System.Windows.Forms.Label
    Friend WithEvents tab1_txtUnitName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tab1_GrpInput As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab1_btnAddList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_btnDelList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_GrpBtn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab1_btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab1_btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tab1_txtUnitOldName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tab2_GrpSubU As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab2_luSubU As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tab2_btnAddList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab2_btnDelList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab2_GrpSelect As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab2_btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab3_UnitSelect As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab3_luUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tab3_btnAddList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab3_btnDelList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab3_MatSelect As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab3_luMat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tab3_btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab3_btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tab2_BtnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
