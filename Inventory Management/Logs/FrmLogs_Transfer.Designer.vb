<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogs_Transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogs_Transfer))
        Me.gcMain = New DevExpress.XtraGrid.GridControl()
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.gv2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.chkLocList = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.slSubCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.chkLocList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slSubCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcMain
        '
        Me.gcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcMain.Location = New System.Drawing.Point(0, 0)
        Me.gcMain.MainView = Me.gvMain
        Me.gcMain.Margin = New System.Windows.Forms.Padding(4)
        Me.gcMain.Name = "gcMain"
        Me.gcMain.Size = New System.Drawing.Size(738, 592)
        Me.gcMain.TabIndex = 13
        Me.gcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain, Me.AdvBandedGridView1, Me.gv2})
        '
        'gvMain
        '
        Me.gvMain.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.gvMain.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvMain.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvMain.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvMain.Appearance.Row.Options.UseFont = True
        Me.gvMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvMain.GridControl = Me.gcMain
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.Editable = False
        Me.gvMain.OptionsFind.AllowFindPanel = False
        Me.gvMain.OptionsFind.ClearFindOnClose = False
        Me.gvMain.OptionsFind.FindDelay = 100
        Me.gvMain.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.gvMain.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.gvMain.OptionsFind.ShowClearButton = False
        Me.gvMain.OptionsFind.ShowFindButton = False
        Me.gvMain.OptionsView.ColumnAutoWidth = False
        Me.gvMain.OptionsView.ShowGroupPanel = False
        Me.gvMain.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.AdvBandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBandedGridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.AdvBandedGridView1.Appearance.Row.Options.UseFont = True
        Me.AdvBandedGridView1.FixedLineWidth = 1
        Me.AdvBandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.AdvBandedGridView1.GridControl = Me.gcMain
        Me.AdvBandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsFind.AllowFindPanel = False
        Me.AdvBandedGridView1.OptionsFind.ClearFindOnClose = False
        Me.AdvBandedGridView1.OptionsFind.FindDelay = 100
        Me.AdvBandedGridView1.OptionsFind.FindFilterColumns = "ชื่อประเภท"
        Me.AdvBandedGridView1.OptionsFind.FindNullPrompt = "ค้นหา"
        Me.AdvBandedGridView1.OptionsFind.ShowClearButton = False
        Me.AdvBandedGridView1.OptionsFind.ShowFindButton = False
        Me.AdvBandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'gv2
        '
        Me.gv2.GridControl = Me.gcMain
        Me.gv2.Name = "gv2"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.chkLocList)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.slSubCat)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(738, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(190, 592)
        Me.PanelControl1.TabIndex = 14
        '
        'chkLocList
        '
        Me.chkLocList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLocList.Appearance.Options.UseFont = True
        Me.chkLocList.CheckOnClick = True
        Me.chkLocList.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLocList.Location = New System.Drawing.Point(12, 134)
        Me.chkLocList.Name = "chkLocList"
        Me.chkLocList.Size = New System.Drawing.Size(175, 81)
        Me.chkLocList.TabIndex = 23
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 105)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 23)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "เลือกคลัง"
        '
        'slSubCat
        '
        Me.slSubCat.EditValue = "เลือกประเภท"
        Me.slSubCat.Location = New System.Drawing.Point(12, 57)
        Me.slSubCat.Name = "slSubCat"
        Me.slSubCat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slSubCat.Properties.Appearance.Options.UseFont = True
        Me.slSubCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slSubCat.Properties.NullText = "เลือกประเภท"
        Me.slSubCat.Properties.View = Me.SearchLookUpEdit1View
        Me.slSubCat.Size = New System.Drawing.Size(173, 28)
        Me.slSubCat.TabIndex = 12
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 23)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "เลือกประเภท"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSearch.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(12, 221)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(173, 43)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "ค้นหา"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 544)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(173, 43)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Export Excel"
        '
        'FrmLogs_Transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 592)
        Me.Controls.Add(Me.gcMain)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmLogs_Transfer"
        Me.Text = "FrmLogs_Transfer"
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.chkLocList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slSubCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents gv2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkLocList As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents slSubCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
