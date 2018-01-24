<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgProgress
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
        Me.Progressbar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbProg = New System.Windows.Forms.Label()
        CType(Me.Progressbar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Progressbar
        '
        Me.Progressbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Progressbar.EditValue = "100"
        Me.Progressbar.Location = New System.Drawing.Point(0, 80)
        Me.Progressbar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Progressbar.Name = "Progressbar"
        Me.Progressbar.Properties.ShowTitle = True
        Me.Progressbar.Properties.Tag = ""
        Me.Progressbar.ShowProgressInTaskBar = True
        Me.Progressbar.Size = New System.Drawing.Size(301, 27)
        Me.Progressbar.TabIndex = 0
        Me.Progressbar.Tag = ""
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Noto Sans Thai UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "โปรดรอ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbProg
        '
        Me.lbProg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProg.Location = New System.Drawing.Point(0, 35)
        Me.lbProg.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbProg.Name = "lbProg"
        Me.lbProg.Size = New System.Drawing.Size(301, 45)
        Me.lbProg.TabIndex = 1
        Me.lbProg.Text = "ระบบกำลังทำงาน..."
        Me.lbProg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dlgProgress
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 107)
        Me.Controls.Add(Me.lbProg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Progressbar)
        Me.Font = New System.Drawing.Font("Noto Sans Thai UI", 13.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "dlgProgress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.Progressbar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Progressbar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Label1 As Label
    Friend WithEvents lbProg As Label
End Class
