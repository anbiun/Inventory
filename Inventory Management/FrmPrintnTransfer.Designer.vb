<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrintnTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrintnTransfer))
        Me.GrpGV = New DevExpress.XtraEditors.GroupControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sDate = New DevExpress.XtraEditors.DateEdit()
        Me.eDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTransfer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReset = New DevExpress.XtraEditors.SimpleButton()
        Me.grpSearch = New DevExpress.XtraEditors.GroupControl()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtBillNo = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gcSelect = New DevExpress.XtraGrid.GridControl()
        Me.gvSelect = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImportLog = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.GrpGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpGV.SuspendLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        CType(Me.txtBillNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpGV
        '
        Me.GrpGV.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpGV.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GrpGV.AppearanceCaption.Options.UseFont = True
        Me.GrpGV.AppearanceCaption.Options.UseForeColor = True
        Me.GrpGV.Controls.Add(Me.gcList)
        Me.GrpGV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GrpGV.Location = New System.Drawing.Point(0, 0)
        Me.GrpGV.Name = "GrpGV"
        Me.GrpGV.Size = New System.Drawing.Size(841, 460)
        Me.GrpGV.TabIndex = 20
        Me.GrpGV.Text = "ข้อมูลใบรับของ"
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gcList.Location = New System.Drawing.Point(2, 27)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Margin = New System.Windows.Forms.Padding(4)
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(837, 431)
        Me.gcList.TabIndex = 8
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList, Me.GridView2})
        '
        'gvList
        '
        Me.gvList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvList.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvList.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvList.Appearance.Row.Options.UseFont = True
        Me.gvList.FixedLineWidth = 1
        Me.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.Editable = False
        Me.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.gvList.OptionsFind.AllowFindPanel = False
        Me.gvList.OptionsFind.ClearFindOnClose = False
        Me.gvList.OptionsFind.FindDelay = 100
        Me.gvList.OptionsFind.FindFilterColumns = ""
        Me.gvList.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvList.OptionsFind.ShowClearButton = False
        Me.gvList.OptionsFind.ShowFindButton = False
        Me.gvList.OptionsView.ColumnAutoWidth = False
        Me.gvList.OptionsView.ShowGroupPanel = False
        Me.gvList.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        Me.gvList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcList
        Me.GridView2.Name = "GridView2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ข้อมูลตั้งแต่วันที่ :"
        '
        'sDate
        '
        Me.sDate.EditValue = Nothing
        Me.sDate.Location = New System.Drawing.Point(128, 35)
        Me.sDate.Name = "sDate"
        Me.sDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sDate.Size = New System.Drawing.Size(120, 22)
        Me.sDate.TabIndex = 21
        '
        'eDate
        '
        Me.eDate.EditValue = Nothing
        Me.eDate.Location = New System.Drawing.Point(337, 35)
        Me.eDate.Name = "eDate"
        Me.eDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Size = New System.Drawing.Size(120, 22)
        Me.eDate.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ถึงวันที่ :"
        '
        'btnTransfer
        '
        Me.btnTransfer.ImageOptions.Image = CType(resources.GetObject("btnTransfer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTransfer.Location = New System.Drawing.Point(156, 7)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(136, 45)
        Me.btnTransfer.TabIndex = 27
        Me.btnTransfer.Text = "โอนยอด"
        '
        'btnReset
        '
        Me.btnReset.ImageOptions.Image = CType(resources.GetObject("btnReset.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(501, 41)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(135, 45)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "RESET"
        Me.btnReset.Visible = False
        '
        'grpSearch
        '
        Me.grpSearch.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpSearch.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.grpSearch.AppearanceCaption.Options.UseFont = True
        Me.grpSearch.AppearanceCaption.Options.UseForeColor = True
        Me.grpSearch.Controls.Add(Me.RadioButton2)
        Me.grpSearch.Controls.Add(Me.txtBillNo)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.RadioButton1)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Controls.Add(Me.Label4)
        Me.grpSearch.Controls.Add(Me.eDate)
        Me.grpSearch.Controls.Add(Me.sDate)
        Me.grpSearch.Location = New System.Drawing.Point(16, 45)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(470, 179)
        Me.grpSearch.TabIndex = 28
        Me.grpSearch.Text = "ค้นหาข้อมูล"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(270, 96)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(174, 21)
        Me.RadioButton2.TabIndex = 28
        Me.RadioButton2.Text = "ข้อมูลรายการในใบรับของ"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(128, 63)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(120, 22)
        Me.txtBillNo.TabIndex = 28
        '
        'btnSearch
        '
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSearch.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(128, 123)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(130, 48)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "ค้นหา"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(128, 96)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(117, 21)
        Me.RadioButton1.TabIndex = 28
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ข้อมูลใบรับของ"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "เลขที่ใบรับของ :"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.gcSelect)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.Panel1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(841, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(614, 460)
        Me.GroupControl1.TabIndex = 20
        Me.GroupControl1.Text = "ข้อมูลที่เลือก"
        '
        'gcSelect
        '
        Me.gcSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSelect.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gcSelect.Location = New System.Drawing.Point(169, 27)
        Me.gcSelect.MainView = Me.gvSelect
        Me.gcSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.gcSelect.Name = "gcSelect"
        Me.gcSelect.Size = New System.Drawing.Size(443, 372)
        Me.gcSelect.TabIndex = 8
        Me.gcSelect.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSelect, Me.GridView3})
        '
        'gvSelect
        '
        Me.gvSelect.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvSelect.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSelect.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvSelect.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvSelect.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvSelect.Appearance.Row.Options.UseFont = True
        Me.gvSelect.FixedLineWidth = 1
        Me.gvSelect.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvSelect.GridControl = Me.gcSelect
        Me.gvSelect.Name = "gvSelect"
        Me.gvSelect.OptionsBehavior.Editable = False
        Me.gvSelect.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.gvSelect.OptionsFind.AllowFindPanel = False
        Me.gvSelect.OptionsFind.ClearFindOnClose = False
        Me.gvSelect.OptionsFind.FindDelay = 100
        Me.gvSelect.OptionsFind.FindFilterColumns = ""
        Me.gvSelect.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvSelect.OptionsFind.ShowClearButton = False
        Me.gvSelect.OptionsFind.ShowFindButton = False
        Me.gvSelect.OptionsView.ColumnAutoWidth = False
        Me.gvSelect.OptionsView.ShowGroupPanel = False
        Me.gvSelect.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        Me.gvSelect.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gcSelect
        Me.GridView3.Name = "GridView3"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnTransfer)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(169, 399)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(443, 59)
        Me.GroupControl3.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(2, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 431)
        Me.Panel1.TabIndex = 32
        '
        'btnAdd
        '
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(16, 133)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(132, 27)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "เพิ่มรายการ"
        '
        'btnRemove
        '
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(16, 168)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(132, 27)
        Me.btnRemove.TabIndex = 30
        Me.btnRemove.Text = " ลบจากรายการ"
        '
        'btnPrint
        '
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(500, 95)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 45)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "พิมพ์ TAG"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(9, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(486, 220)
        Me.XtraTabControl1.TabIndex = 31
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(479, 185)
        Me.XtraTabPage1.Text = "โอนยอดเข้าคลัง"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(479, 185)
        Me.XtraTabPage2.Text = "พิมพ์ TAG"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupControl1)
        Me.Panel2.Controls.Add(Me.GrpGV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 236)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1455, 460)
        Me.Panel2.TabIndex = 32
        '
        'btnImportLog
        '
        Me.btnImportLog.Location = New System.Drawing.Point(501, 146)
        Me.btnImportLog.Name = "btnImportLog"
        Me.btnImportLog.Size = New System.Drawing.Size(135, 41)
        Me.btnImportLog.TabIndex = 33
        Me.btnImportLog.Text = "ประวัติเข้า"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(555, 218)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Size = New System.Drawing.Size(541, 281)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.SplitterWidth = 25
        Me.SplitContainer1.TabIndex = 34
        '
        'FrmPrintnTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1455, 696)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnImportLog)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "FrmPrintnTransfer"
        Me.Text = "FrmPrintnTransfer"
        CType(Me.GrpGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpGV.ResumeLayout(False)
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.txtBillNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpGV As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTransfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtBillNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcSelect As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSelect As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnImportLog As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
