<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogs_Requisition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogs_Requisition))
        Me.BtnDel = New DevExpress.XtraEditors.SimpleButton()
        Me.deSDate = New DevExpress.XtraEditors.DateEdit()
        Me.lbSDate = New System.Windows.Forms.Label()
        Me.lbEDate = New System.Windows.Forms.Label()
        Me.deEDate = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnNextPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnLastPage = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDisplayPageNo = New DevExpress.XtraEditors.LabelControl()
        Me.cbPageSize = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BtnFirstPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPreviousPage = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdDate_By = New System.Windows.Forms.RadioButton()
        Me.rdDate_All = New System.Windows.Forms.RadioButton()
        Me.slCat = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.clbSubCat = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.clbLoc = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cbPageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDel
        '
        Me.BtnDel.Appearance.Font = CType(resources.GetObject("BtnDel.Appearance.Font"), System.Drawing.Font)
        Me.BtnDel.Appearance.Options.UseFont = True
        Me.BtnDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.BtnDel, "BtnDel")
        Me.BtnDel.ImageOptions.Image = CType(resources.GetObject("BtnDel.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnDel.Name = "BtnDel"
        '
        'deSDate
        '
        resources.ApplyResources(Me.deSDate, "deSDate")
        Me.deSDate.Name = "deSDate"
        Me.deSDate.Properties.Appearance.Font = CType(resources.GetObject("deSDate.Properties.Appearance.Font"), System.Drawing.Font)
        Me.deSDate.Properties.Appearance.Options.UseFont = True
        Me.deSDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("deSDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.deSDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("deSDate.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.deSDate.Properties.NullDate = "กรุณาเลือก"
        Me.deSDate.Properties.NullText = resources.GetString("deSDate.Properties.NullText")
        '
        'lbSDate
        '
        resources.ApplyResources(Me.lbSDate, "lbSDate")
        Me.lbSDate.Name = "lbSDate"
        '
        'lbEDate
        '
        resources.ApplyResources(Me.lbEDate, "lbEDate")
        Me.lbEDate.Name = "lbEDate"
        '
        'deEDate
        '
        resources.ApplyResources(Me.deEDate, "deEDate")
        Me.deEDate.Name = "deEDate"
        Me.deEDate.Properties.Appearance.Font = CType(resources.GetObject("deEDate.Properties.Appearance.Font"), System.Drawing.Font)
        Me.deEDate.Properties.Appearance.Options.UseFont = True
        Me.deEDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("deEDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.deEDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("deEDate.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.deEDate.Properties.NullDate = "กรุณาเลือก"
        Me.deEDate.Properties.NullText = resources.GetString("deEDate.Properties.NullText")
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = CType(resources.GetObject("GroupControl3.AppearanceCaption.Font"), System.Drawing.Font)
        Me.GroupControl3.AppearanceCaption.ForeColor = CType(resources.GetObject("GroupControl3.AppearanceCaption.ForeColor"), System.Drawing.Color)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.gcList)
        Me.GroupControl3.Controls.Add(Me.PanelControl10)
        resources.ApplyResources(Me.GroupControl3, "GroupControl3")
        Me.GroupControl3.Name = "GroupControl3"
        '
        'gcList
        '
        resources.ApplyResources(Me.gcList, "gcList")
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList})
        '
        'gvList
        '
        Me.gvList.Appearance.ColumnFilterButton.Font = CType(resources.GetObject("gvList.Appearance.ColumnFilterButton.Font"), System.Drawing.Font)
        Me.gvList.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvList.Appearance.ColumnFilterButtonActive.Font = CType(resources.GetObject("gvList.Appearance.ColumnFilterButtonActive.Font"), System.Drawing.Font)
        Me.gvList.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvList.Appearance.CustomizationFormHint.Font = CType(resources.GetObject("gvList.Appearance.CustomizationFormHint.Font"), System.Drawing.Font)
        Me.gvList.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvList.Appearance.DetailTip.Font = CType(resources.GetObject("gvList.Appearance.DetailTip.Font"), System.Drawing.Font)
        Me.gvList.Appearance.DetailTip.Options.UseFont = True
        Me.gvList.Appearance.Empty.Font = CType(resources.GetObject("gvList.Appearance.Empty.Font"), System.Drawing.Font)
        Me.gvList.Appearance.Empty.Options.UseFont = True
        Me.gvList.Appearance.EvenRow.Font = CType(resources.GetObject("gvList.Appearance.EvenRow.Font"), System.Drawing.Font)
        Me.gvList.Appearance.EvenRow.Options.UseFont = True
        Me.gvList.Appearance.FilterCloseButton.Font = CType(resources.GetObject("gvList.Appearance.FilterCloseButton.Font"), System.Drawing.Font)
        Me.gvList.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvList.Appearance.FilterPanel.Font = CType(resources.GetObject("gvList.Appearance.FilterPanel.Font"), System.Drawing.Font)
        Me.gvList.Appearance.FilterPanel.Options.UseFont = True
        Me.gvList.Appearance.FixedLine.Font = CType(resources.GetObject("gvList.Appearance.FixedLine.Font"), System.Drawing.Font)
        Me.gvList.Appearance.FixedLine.Options.UseFont = True
        Me.gvList.Appearance.FocusedCell.Font = CType(resources.GetObject("gvList.Appearance.FocusedCell.Font"), System.Drawing.Font)
        Me.gvList.Appearance.FocusedCell.Options.UseFont = True
        Me.gvList.Appearance.FocusedRow.Font = CType(resources.GetObject("gvList.Appearance.FocusedRow.Font"), System.Drawing.Font)
        Me.gvList.Appearance.FocusedRow.Options.UseFont = True
        Me.gvList.Appearance.FooterPanel.Font = CType(resources.GetObject("gvList.Appearance.FooterPanel.Font"), System.Drawing.Font)
        Me.gvList.Appearance.FooterPanel.Options.UseFont = True
        Me.gvList.Appearance.GroupButton.Font = CType(resources.GetObject("gvList.Appearance.GroupButton.Font"), System.Drawing.Font)
        Me.gvList.Appearance.GroupButton.Options.UseFont = True
        Me.gvList.Appearance.GroupFooter.Font = CType(resources.GetObject("gvList.Appearance.GroupFooter.Font"), System.Drawing.Font)
        Me.gvList.Appearance.GroupFooter.Options.UseFont = True
        Me.gvList.Appearance.GroupPanel.Font = CType(resources.GetObject("gvList.Appearance.GroupPanel.Font"), System.Drawing.Font)
        Me.gvList.Appearance.GroupPanel.Options.UseFont = True
        Me.gvList.Appearance.GroupRow.Font = CType(resources.GetObject("gvList.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.gvList.Appearance.GroupRow.Options.UseFont = True
        Me.gvList.Appearance.HeaderPanel.Font = CType(resources.GetObject("gvList.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.gvList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvList.Appearance.HideSelectionRow.Font = CType(resources.GetObject("gvList.Appearance.HideSelectionRow.Font"), System.Drawing.Font)
        Me.gvList.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvList.Appearance.HorzLine.Font = CType(resources.GetObject("gvList.Appearance.HorzLine.Font"), System.Drawing.Font)
        Me.gvList.Appearance.HorzLine.Options.UseFont = True
        Me.gvList.Appearance.OddRow.Font = CType(resources.GetObject("gvList.Appearance.OddRow.Font"), System.Drawing.Font)
        Me.gvList.Appearance.OddRow.Options.UseFont = True
        Me.gvList.Appearance.Preview.Font = CType(resources.GetObject("gvList.Appearance.Preview.Font"), System.Drawing.Font)
        Me.gvList.Appearance.Preview.Options.UseFont = True
        Me.gvList.Appearance.Row.Font = CType(resources.GetObject("gvList.Appearance.Row.Font"), System.Drawing.Font)
        Me.gvList.Appearance.Row.Options.UseFont = True
        Me.gvList.Appearance.RowSeparator.Font = CType(resources.GetObject("gvList.Appearance.RowSeparator.Font"), System.Drawing.Font)
        Me.gvList.Appearance.RowSeparator.Options.UseFont = True
        Me.gvList.Appearance.SelectedRow.Font = CType(resources.GetObject("gvList.Appearance.SelectedRow.Font"), System.Drawing.Font)
        Me.gvList.Appearance.SelectedRow.Options.UseFont = True
        Me.gvList.Appearance.TopNewRow.Font = CType(resources.GetObject("gvList.Appearance.TopNewRow.Font"), System.Drawing.Font)
        Me.gvList.Appearance.TopNewRow.Options.UseFont = True
        Me.gvList.Appearance.VertLine.Font = CType(resources.GetObject("gvList.Appearance.VertLine.Font"), System.Drawing.Font)
        Me.gvList.Appearance.VertLine.Options.UseFont = True
        Me.gvList.Appearance.ViewCaption.Font = CType(resources.GetObject("gvList.Appearance.ViewCaption.Font"), System.Drawing.Font)
        Me.gvList.Appearance.ViewCaption.Options.UseFont = True
        Me.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.Editable = False
        Me.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvList.OptionsView.ColumnAutoWidth = False
        Me.gvList.OptionsView.ShowAutoFilterRow = True
        Me.gvList.OptionsView.ShowGroupPanel = False
        Me.gvList.OptionsView.ShowIndicator = False
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.Panel2)
        Me.PanelControl10.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.PanelControl10, "PanelControl10")
        Me.PanelControl10.Name = "PanelControl10"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Controls.Add(Me.BtnNextPage)
        Me.Panel2.Controls.Add(Me.BtnLastPage)
        Me.Panel2.Name = "Panel2"
        '
        'BtnNextPage
        '
        Me.BtnNextPage.Appearance.Font = CType(resources.GetObject("BtnNextPage.Appearance.Font"), System.Drawing.Font)
        Me.BtnNextPage.Appearance.Options.UseFont = True
        Me.BtnNextPage.ImageOptions.Image = CType(resources.GetObject("BtnNextPage.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.BtnNextPage, "BtnNextPage")
        Me.BtnNextPage.Name = "BtnNextPage"
        '
        'BtnLastPage
        '
        Me.BtnLastPage.Appearance.Font = CType(resources.GetObject("BtnLastPage.Appearance.Font"), System.Drawing.Font)
        Me.BtnLastPage.Appearance.Options.UseFont = True
        Me.BtnLastPage.ImageOptions.Image = CType(resources.GetObject("BtnLastPage.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.BtnLastPage, "BtnLastPage")
        Me.BtnLastPage.Name = "BtnLastPage"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.LabelControl18)
        Me.Panel1.Controls.Add(Me.txtDisplayPageNo)
        Me.Panel1.Controls.Add(Me.cbPageSize)
        Me.Panel1.Controls.Add(Me.BtnFirstPage)
        Me.Panel1.Controls.Add(Me.BtnPreviousPage)
        Me.Panel1.Name = "Panel1"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = CType(resources.GetObject("LabelControl18.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl18.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.LabelControl18, "LabelControl18")
        Me.LabelControl18.Name = "LabelControl18"
        '
        'txtDisplayPageNo
        '
        Me.txtDisplayPageNo.Appearance.Font = CType(resources.GetObject("txtDisplayPageNo.Appearance.Font"), System.Drawing.Font)
        Me.txtDisplayPageNo.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.txtDisplayPageNo, "txtDisplayPageNo")
        Me.txtDisplayPageNo.Name = "txtDisplayPageNo"
        '
        'cbPageSize
        '
        resources.ApplyResources(Me.cbPageSize, "cbPageSize")
        Me.cbPageSize.Name = "cbPageSize"
        Me.cbPageSize.Properties.Appearance.Font = CType(resources.GetObject("cbPageSize.Properties.Appearance.Font"), System.Drawing.Font)
        Me.cbPageSize.Properties.Appearance.Options.UseFont = True
        Me.cbPageSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cbPageSize.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cbPageSize.Properties.Items.AddRange(New Object() {resources.GetString("cbPageSize.Properties.Items"), resources.GetString("cbPageSize.Properties.Items1"), resources.GetString("cbPageSize.Properties.Items2"), resources.GetString("cbPageSize.Properties.Items3"), resources.GetString("cbPageSize.Properties.Items4"), resources.GetString("cbPageSize.Properties.Items5")})
        Me.cbPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'BtnFirstPage
        '
        Me.BtnFirstPage.Appearance.Font = CType(resources.GetObject("BtnFirstPage.Appearance.Font"), System.Drawing.Font)
        Me.BtnFirstPage.Appearance.Options.UseFont = True
        Me.BtnFirstPage.ImageOptions.Image = CType(resources.GetObject("BtnFirstPage.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.BtnFirstPage, "BtnFirstPage")
        Me.BtnFirstPage.Name = "BtnFirstPage"
        '
        'BtnPreviousPage
        '
        Me.BtnPreviousPage.Appearance.Font = CType(resources.GetObject("BtnPreviousPage.Appearance.Font"), System.Drawing.Font)
        Me.BtnPreviousPage.Appearance.Options.UseFont = True
        Me.BtnPreviousPage.ImageOptions.Image = CType(resources.GetObject("BtnPreviousPage.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.BtnPreviousPage, "BtnPreviousPage")
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.rdDate_By)
        Me.GroupControl1.Controls.Add(Me.rdDate_All)
        Me.GroupControl1.Controls.Add(Me.slCat)
        Me.GroupControl1.Controls.Add(Me.btnSearch)
        Me.GroupControl1.Controls.Add(Me.clbSubCat)
        Me.GroupControl1.Controls.Add(Me.clbLoc)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lbCat)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.deSDate)
        Me.GroupControl1.Controls.Add(Me.lbEDate)
        Me.GroupControl1.Controls.Add(Me.deEDate)
        Me.GroupControl1.Controls.Add(Me.lbSDate)
        Me.GroupControl1.Controls.Add(Me.BtnDel)
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Name = "GroupControl1"
        '
        'rdDate_By
        '
        resources.ApplyResources(Me.rdDate_By, "rdDate_By")
        Me.rdDate_By.Name = "rdDate_By"
        Me.rdDate_By.TabStop = True
        Me.rdDate_By.UseVisualStyleBackColor = True
        '
        'rdDate_All
        '
        resources.ApplyResources(Me.rdDate_All, "rdDate_All")
        Me.rdDate_All.Name = "rdDate_All"
        Me.rdDate_All.TabStop = True
        Me.rdDate_All.UseVisualStyleBackColor = True
        '
        'slCat
        '
        resources.ApplyResources(Me.slCat, "slCat")
        Me.slCat.Name = "slCat"
        Me.slCat.Properties.Appearance.Font = CType(resources.GetObject("slCat.Properties.Appearance.Font"), System.Drawing.Font)
        Me.slCat.Properties.Appearance.Options.UseFont = True
        Me.slCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("slCat.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.slCat.Properties.NullText = resources.GetString("slCat.Properties.NullText")
        Me.slCat.Properties.NullValuePrompt = resources.GetString("slCat.Properties.NullValuePrompt")
        Me.slCat.Properties.View = Me.SearchLookUpEdit1View
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.Font = CType(resources.GetObject("btnSearch.Appearance.Font"), System.Drawing.Font)
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSearch.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        '
        'clbSubCat
        '
        Me.clbSubCat.Appearance.Font = CType(resources.GetObject("clbSubCat.Appearance.Font"), System.Drawing.Font)
        Me.clbSubCat.Appearance.Options.UseFont = True
        Me.clbSubCat.CheckOnClick = True
        Me.clbSubCat.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.clbSubCat, "clbSubCat")
        Me.clbSubCat.Name = "clbSubCat"
        '
        'clbLoc
        '
        Me.clbLoc.Appearance.Font = CType(resources.GetObject("clbLoc.Appearance.Font"), System.Drawing.Font)
        Me.clbLoc.Appearance.Options.UseFont = True
        Me.clbLoc.CheckOnClick = True
        Me.clbLoc.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.clbLoc, "clbLoc")
        Me.clbLoc.Name = "clbLoc"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lbCat
        '
        resources.ApplyResources(Me.lbCat, "lbCat")
        Me.lbCat.Name = "lbCat"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'FrmLogs_Requisition
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FrmLogs_Requisition"
        CType(Me.deSDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deEDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        Me.PanelControl10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbPageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.slCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deSDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbSDate As System.Windows.Forms.Label
    Friend WithEvents lbEDate As System.Windows.Forms.Label
    Friend WithEvents deEDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdDate_By As RadioButton
    Friend WithEvents rdDate_All As RadioButton
    Friend WithEvents slCat As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clbSubCat As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents clbLoc As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbPageSize As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDisplayPageNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnNextPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPreviousPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnLastPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFirstPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
End Class
