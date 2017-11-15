<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    'Inherits System.Windows.Forms.Form
    Inherits DevComponents.DotNetBar.Office2007Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LLBRegister = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnSelectLoc = New DevExpress.XtraEditors.PanelControl()
        Me.comboLoc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnSelectLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnSelectLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(107, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 52)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "ระบบบันทึกยอดรับของส่งโกดัง"
        '
        'LLBRegister
        '
        Me.LLBRegister.AutoSize = True
        Me.LLBRegister.BackColor = System.Drawing.Color.Transparent
        Me.LLBRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LLBRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LLBRegister.LinkColor = System.Drawing.Color.Red
        Me.LLBRegister.Location = New System.Drawing.Point(180, 278)
        Me.LLBRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLBRegister.Name = "LLBRegister"
        Me.LLBRegister.Size = New System.Drawing.Size(186, 25)
        Me.LLBRegister.TabIndex = 73
        Me.LLBRegister.TabStop = True
        Me.LLBRegister.Text = "สมัครเข้าใช้งานโปรแกรม"
        Me.LLBRegister.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(137, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 40)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "บริษัท เจ.แอล. โปรดักส์ จำกัด"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 18.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(137, 71)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 40)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "J.L. PRODUCTS CO.,LTD."
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(25, 48)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(287, 310)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(125, 37)
        Me.BtnCancel.TabIndex = 68
        Me.BtnCancel.Text = "ยกเลิก"
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(149, 310)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(125, 37)
        Me.BtnOK.TabIndex = 67
        Me.BtnOK.Text = "เข้าสู่ระบบ"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(184, 248)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(180, 29)
        Me.TxtPassword.TabIndex = 66
        '
        'TxtUser
        '
        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(184, 195)
        Me.TxtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(180, 29)
        Me.TxtUser.TabIndex = 65
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(181, 224)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(93, 28)
        Me.PasswordLabel.TabIndex = 69
        Me.PasswordLabel.Text = "รหัสผ่าน"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(181, 164)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(71, 28)
        Me.UsernameLabel.TabIndex = 64
        Me.UsernameLabel.Text = "ชื่อผู้ใช้"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnSelectLoc
        '
        Me.pnSelectLoc.Controls.Add(Me.comboLoc)
        Me.pnSelectLoc.Controls.Add(Me.Label1)
        Me.pnSelectLoc.Location = New System.Drawing.Point(149, 166)
        Me.pnSelectLoc.Name = "pnSelectLoc"
        Me.pnSelectLoc.Size = New System.Drawing.Size(263, 119)
        Me.pnSelectLoc.TabIndex = 75
        '
        'comboLoc
        '
        Me.comboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLoc.FormattingEnabled = True
        Me.comboLoc.Location = New System.Drawing.Point(51, 66)
        Me.comboLoc.Name = "comboLoc"
        Me.comboLoc.Size = New System.Drawing.Size(156, 24)
        Me.comboLoc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "เลือกคลังวัสดุ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_Management.My.Resources.Resources.BGM1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 398)
        Me.Controls.Add(Me.pnSelectLoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LLBRegister)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบันทึกยอดรับของส่งโกดัง"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnSelectLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnSelectLoc.ResumeLayout(False)
        Me.pnSelectLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LLBRegister As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnSelectLoc As DevExpress.XtraEditors.PanelControl
    Friend WithEvents comboLoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
