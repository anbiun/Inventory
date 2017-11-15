<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApprove
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApprove))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcList = New DevExpress.XtraGrid.GridControl()
        Me.gvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.deDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.slTransferNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grpRequest = New DevExpress.XtraEditors.GroupControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.lbUserStock = New System.Windows.Forms.Label()
        Me.PnlSave = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slTransferNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequest.SuspendLayout()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSave.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.gcList)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(348, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1184, 742)
        Me.GroupControl3.TabIndex = 12
        Me.GroupControl3.Text = "รายการโอนวัสดุ"
        '
        'gcList
        '
        Me.gcList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcList.Location = New System.Drawing.Point(2, 31)
        Me.gcList.MainView = Me.gvList
        Me.gcList.Name = "gcList"
        Me.gcList.Size = New System.Drawing.Size(1180, 709)
        Me.gcList.TabIndex = 8
        Me.gcList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvList})
        '
        'gvList
        '
        Me.gvList.GridControl = Me.gcList
        Me.gvList.Name = "gvList"
        Me.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gvList.OptionsFind.AlwaysVisible = True
        Me.gvList.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ผู้ทำรายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "เลขที่เอกสาร"
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.Location = New System.Drawing.Point(126, 48)
        Me.deDate.Name = "deDate"
        Me.deDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deDate.Properties.Appearance.Options.UseFont = True
        Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Size = New System.Drawing.Size(124, 28)
        Me.deDate.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "วันที่"
        '
        'slTransferNo
        '
        Me.slTransferNo.EditValue = ""
        Me.slTransferNo.Location = New System.Drawing.Point(126, 82)
        Me.slTransferNo.Name = "slTransferNo"
        Me.slTransferNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slTransferNo.Properties.Appearance.Options.UseFont = True
        Me.slTransferNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slTransferNo.Properties.View = Me.SearchLookUpEdit1View
        Me.slTransferNo.Size = New System.Drawing.Size(124, 28)
        Me.slTransferNo.TabIndex = 18
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'grpRequest
        '
        Me.grpRequest.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRequest.AppearanceCaption.Options.UseFont = True
        Me.grpRequest.Controls.Add(Me.Label5)
        Me.grpRequest.Controls.Add(Me.Label4)
        Me.grpRequest.Controls.Add(Me.btnNew)
        Me.grpRequest.Controls.Add(Me.lbUserStock)
        Me.grpRequest.Controls.Add(Me.slTransferNo)
        Me.grpRequest.Controls.Add(Me.Label2)
        Me.grpRequest.Controls.Add(Me.deDate)
        Me.grpRequest.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRequest.Location = New System.Drawing.Point(0, 0)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(348, 200)
        Me.grpRequest.TabIndex = 19
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnNew.Location = New System.Drawing.Point(126, 151)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(124, 38)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "ตกลง"
        '
        'lbUserStock
        '
        Me.lbUserStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbUserStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUserStock.Location = New System.Drawing.Point(126, 119)
        Me.lbUserStock.Name = "lbUserStock"
        Me.lbUserStock.Size = New System.Drawing.Size(124, 24)
        Me.lbUserStock.TabIndex = 13
        Me.lbUserStock.Text = "ปริมาณ"
        '
        'PnlSave
        '
        Me.PnlSave.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PnlSave.Appearance.Options.UseBackColor = True
        Me.PnlSave.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PnlSave.Controls.Add(Me.btnSave)
        Me.PnlSave.Controls.Add(Me.btnCancel)
        Me.PnlSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSave.Location = New System.Drawing.Point(0, 200)
        Me.PnlSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlSave.Name = "PnlSave"
        Me.PnlSave.Size = New System.Drawing.Size(348, 542)
        Me.PnlSave.TabIndex = 20
        Me.PnlSave.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(191, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 35)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "บันทึก"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(93, 7)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 35)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "ยกเลิก"
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.PnlSave)
        Me.pnlLeft.Controls.Add(Me.grpRequest)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(348, 742)
        Me.pnlLeft.TabIndex = 22
        '
        'FrmApprove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 742)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "FrmApprove"
        Me.Text = "ตรวจรับวัสดุ"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slTransferNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequest.ResumeLayout(False)
        Me.grpRequest.PerformLayout()
        CType(Me.PnlSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSave.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents slTransferNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpRequest As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbUserStock As System.Windows.Forms.Label
    Friend WithEvents PnlSave As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvList As DevExpress.XtraGrid.Views.Grid.GridView
End Class
