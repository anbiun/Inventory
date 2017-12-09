<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmgProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmgProduct))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProduct = New DevExpress.XtraEditors.TextEdit()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnDelList = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddList = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTarget = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTarget.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "เบอร์มีด :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(104, 17)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Properties.Appearance.Options.UseFont = True
        Me.txtProduct.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtProduct.Size = New System.Drawing.Size(101, 30)
        Me.txtProduct.TabIndex = 29
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(0, 140)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(472, 458)
        Me.gcList.TabIndex = 24
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
        'btnDelList
        '
        Me.btnDelList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelList.Appearance.Options.UseFont = True
        Me.btnDelList.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDelList.ImageOptions.Image = CType(resources.GetObject("btnDelList.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelList.Location = New System.Drawing.Point(16, 108)
        Me.btnDelList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelList.Name = "btnDelList"
        Me.btnDelList.Size = New System.Drawing.Size(130, 27)
        Me.btnDelList.TabIndex = 26
        Me.btnDelList.Text = "ลบรายการ"
        '
        'btnAddList
        '
        Me.btnAddList.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList.Appearance.Options.UseFont = True
        Me.btnAddList.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAddList.ImageOptions.Image = CType(resources.GetObject("btnAddList.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddList.Location = New System.Drawing.Point(167, 108)
        Me.btnAddList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(130, 27)
        Me.btnAddList.TabIndex = 27
        Me.btnAddList.Text = "เพิ่มรายการ"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "เป้าผลิต :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "โหล"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.GroupControl1.Controls.Add(Me.btnSave)
        Me.GroupControl1.Controls.Add(Me.txtTarget)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.btnDelList)
        Me.GroupControl1.Controls.Add(Me.txtProduct)
        Me.GroupControl1.Controls.Add(Me.btnAddList)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(472, 140)
        Me.GroupControl1.TabIndex = 30
        Me.GroupControl1.Text = "GroupControl1"
        '
        'btnSave
        '
        Me.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSave.Location = New System.Drawing.Point(351, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 45)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "บันทึก"
        '
        'txtTarget
        '
        Me.txtTarget.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTarget.Location = New System.Drawing.Point(105, 56)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarget.Properties.Appearance.Options.UseFont = True
        Me.txtTarget.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTarget.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTarget.Properties.MaxLength = 7
        Me.txtTarget.Size = New System.Drawing.Size(100, 30)
        Me.txtTarget.TabIndex = 30
        '
        'FmgProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 598)
        Me.Controls.Add(Me.gcList)
        Me.Controls.Add(Me.GroupControl1)
        Me.MinimumSize = New System.Drawing.Size(319, 550)
        Me.Name = "FmgProduct"
        Me.Text = "FmgProduct"
        CType(Me.txtProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtTarget.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtProduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDelList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTarget As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
