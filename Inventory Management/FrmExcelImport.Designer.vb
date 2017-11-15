<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExcelImport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.sheetCtrl = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImp = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBarControl = New DevExpress.XtraEditors.ProgressBarControl()
        Me.TxtPath = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.hlCreateFile = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.SpreadsheetDockManager1 = New DevExpress.XtraSpreadsheet.SpreadsheetDockManager(Me.components)
        Me.MailMergeParametersDockPanel1 = New DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel()
        Me.MailMergeParametersDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.ProgressBarControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SpreadsheetDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MailMergeParametersDockPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sheetCtrl
        '
        Me.sheetCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sheetCtrl.Location = New System.Drawing.Point(0, 38)
        Me.sheetCtrl.Name = "sheetCtrl"
        Me.sheetCtrl.ReadOnly = True
        Me.sheetCtrl.Size = New System.Drawing.Size(810, 392)
        Me.sheetCtrl.TabIndex = 0
        Me.sheetCtrl.Text = "SpreadsheetControl1"
        '
        'btnBrowse
        '
        Me.btnBrowse.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnBrowse.Appearance.Options.UseFont = True
        Me.btnBrowse.Location = New System.Drawing.Point(242, 7)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(91, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "เลือกไฟล์"
        '
        'btnImp
        '
        Me.btnImp.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnImp.Appearance.Options.UseFont = True
        Me.btnImp.Location = New System.Drawing.Point(339, 7)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 7
        Me.btnImp.Text = "นำเข้าข้อมูล"
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        '
        'ProgressBarControl
        '
        Me.ProgressBarControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarControl.Location = New System.Drawing.Point(0, 430)
        Me.ProgressBarControl.Name = "ProgressBarControl"
        Me.ProgressBarControl.Properties.EditValueChangedDelay = 20
        Me.ProgressBarControl.Properties.ShowTitle = True
        Me.ProgressBarControl.Size = New System.Drawing.Size(810, 25)
        Me.ProgressBarControl.TabIndex = 10
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(19, 8)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtPath.Properties.Appearance.Options.UseFont = True
        Me.TxtPath.Size = New System.Drawing.Size(217, 20)
        Me.TxtPath.TabIndex = 17
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.hlCreateFile)
        Me.PanelControl1.Controls.Add(Me.TxtPath)
        Me.PanelControl1.Controls.Add(Me.btnBrowse)
        Me.PanelControl1.Controls.Add(Me.btnImp)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(810, 38)
        Me.PanelControl1.TabIndex = 31
        '
        'hlCreateFile
        '
        Me.hlCreateFile.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.hlCreateFile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.hlCreateFile.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.hlCreateFile.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.hlCreateFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hlCreateFile.Location = New System.Drawing.Point(530, 4)
        Me.hlCreateFile.Name = "hlCreateFile"
        Me.hlCreateFile.Size = New System.Drawing.Size(114, 30)
        Me.hlCreateFile.TabIndex = 33
        Me.hlCreateFile.Text = "สร้างไฟล์ต้นแบบ Excel สำหรับนำเข้าข้อมูล"
        '
        'SpreadsheetDockManager1
        '
        Me.SpreadsheetDockManager1.Form = Me
        Me.SpreadsheetDockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.MailMergeParametersDockPanel1})
        Me.SpreadsheetDockManager1.SpreadsheetControl = Me.sheetCtrl
        Me.SpreadsheetDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'MailMergeParametersDockPanel1
        '
        Me.MailMergeParametersDockPanel1.Controls.Add(Me.MailMergeParametersDockPanel1_Container)
        Me.MailMergeParametersDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.MailMergeParametersDockPanel1.ID = New System.Guid("dcebf994-427e-4f2a-94de-408d520ee513")
        Me.MailMergeParametersDockPanel1.Location = New System.Drawing.Point(456, 0)
        Me.MailMergeParametersDockPanel1.Name = "MailMergeParametersDockPanel1"
        Me.MailMergeParametersDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.MailMergeParametersDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.MailMergeParametersDockPanel1.SavedIndex = 0
        Me.MailMergeParametersDockPanel1.Size = New System.Drawing.Size(200, 455)
        Me.MailMergeParametersDockPanel1.SpreadsheetControl = Me.sheetCtrl
        Me.MailMergeParametersDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'MailMergeParametersDockPanel1_Container
        '
        Me.MailMergeParametersDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.MailMergeParametersDockPanel1_Container.Name = "MailMergeParametersDockPanel1_Container"
        Me.MailMergeParametersDockPanel1_Container.Size = New System.Drawing.Size(192, 428)
        Me.MailMergeParametersDockPanel1_Container.TabIndex = 0
        '
        'FrmImportMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 455)
        Me.Controls.Add(Me.sheetCtrl)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.ProgressBarControl)
        Me.Name = "FrmImportMat"
        Me.Text = "นำเข้าข้อมูลจากไฟล์ Excel"
        CType(Me.ProgressBarControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SpreadsheetDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MailMergeParametersDockPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sheetCtrl As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBarControl As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents TxtPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents hlCreateFile As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SpreadsheetDockManager1 As DevExpress.XtraSpreadsheet.SpreadsheetDockManager
    Friend WithEvents MailMergeParametersDockPanel1 As DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel
    Friend WithEvents MailMergeParametersDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
End Class
