Option Explicit On
Option Strict On
Imports ConDB.Main
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FmgSupplier
    Dim dtResult As DataTable
    Dim dtNew, dtSubCat As DataTable
    Dim SupplierID As String = String.Empty
    Dim Edit As Boolean = False
#Region "CODE"
    Private Sub FirstQry()
        SQL = "SELECT * FROM vwSupplier"
        dsTbl("supplier")
        dtResult = DS.Tables("supplier").Copy

        With sluSubCat.Properties
            SQL = "SELECT SC.CatID+SC.SubCatID SubCatID,SC.SubCatName,U.UnitName FROM tbSubCategory SC
                   INNER JOIN tbUnit U ON SC.Unit3_ID = U.UnitID"
            dsTbl("subcat")
            dtSubCat = DS.Tables("subcat")
            .DataSource = dtSubCat
            .DisplayMember = "SubCatName"
            .ValueMember = "SubCatID"
            .PopulateViewColumns()
            gridInfo = New GridCaption(.View)
            gridInfo.SetCaption()
        End With

    End Sub
    Private Sub LoadDef()
        txtName.Text = String.Empty
        txtAddress.Text = String.Empty
        sluSubCat.EditValue = Nothing
        txtRatio.EditValue = 0

        'grpSupplier clearText
        For Each ctr As Control In grpSupplier.Controls
            If TypeOf (ctr) Is TextEdit Or TypeOf (ctr) Is MemoEdit Then
                ctr.Text = String.Empty
            End If
        Next
        GVFormat()
        PnlSave.Visible = False
        grpSupplier.Enabled = True
        grpMat.Enabled = False
        Me.TopMost = False

    End Sub
#End Region
#Region "Button Control"
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        If ChkInput(grpSupplier) = False Then Return
        If Edit = False Then
            dtNew = dtResult.Clone
            SupplierID = GenID()
        Else
            For Each dr As DataRow In dtNew.Rows
                dr("SupplierName") = txtName.Text
                dr("SupplierAddress") = txtAddress.Text
                dr("SupplierAgent") = txtAgent.Text
                dr("SupplierContact") = String.Format("{0}{1} {2}{3}", Label2.Text, txtTel.Text, Label3.Text, txtFax.Text)
                dr("SupplierTerm") = txtTerm.EditValue
            Next
        End If
        gcList.DataSource = dtNew
        Dim addDelColumn As Func(Of Boolean) = Function()
                                                   Dim count As Boolean = False
                                                   For Each colname As DevExpress.XtraGrid.Columns.GridColumn In gvList.Columns
                                                       If colname.FieldName = "del" Then
                                                           count = True
                                                           Exit For
                                                       End If
                                                   Next
                                                   If count = False Then
                                                       Dim btnDel As New ColumnButton.Editor With {.ToolTip = "ลบรายการนี้", .Field = "del", .Image = My.Resources.remove_16x16}
                                                       Dim addBtnColumn As New ColumnButton.Main With {.gControl = gcList, .gView = gvList}
                                                       addBtnColumn.Add(btnDel)
                                                   End If
                                               End Function
        addDelColumn()
        gvList.ExpandAllGroups()
        grpSupplier.Enabled = False
        grpMat.Enabled = True
        Edit = False
    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Edit = False
        LoadDef()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(SupplierID) Then Return
        SQL = "DELETE FROM tbSupplier WHERE SupplierID ='" & SupplierID & "'
               DELETE FROM tbSupplier_Detail WHERE SupplierID ='" & SupplierID & "'
               
               INSERT INTO tbSupplier (SupplierID,SupplierName,SupplierAddress,SupplierContact,SupplierAgent,SupplierTerm)
               VALUES ('" & SupplierID & "'
               ,'" & txtName.Text & "'
               ,'" & txtAddress.Text & "'
               ,'" & String.Format("{0}{1} {2}{3}", Label2.Text, txtTel.Text, Label3.Text, txtFax.Text) & "'
               ,'" & txtAgent.Text & "'
               ,'" & txtTerm.EditValue.ToString & "'
               )"
        dsTbl("insert")
        blkCpy("tbSupplier_Detail", dtNew, {"SupplierID", "SupplierDetailID", "SubCatID", "Ratio"})
        MessageBox.Show("บันทึกข้อมูลแล้ว", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FirstQry()
        LoadDef()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If sluSubCat.EditValue Is Nothing Then Return
        FoundRow = dtNew.Select("SubCatID ='" & sluSubCat.EditValue.ToString & "'")
        If FoundRow.Count > 0 Then
            For Each rows As DataRow In FoundRow
                If rows("Ratio").ToString = txtRatio.EditValue.ToString Then Return
            Next
        End If
        Dim dr As DataRow
        dr = dtNew.NewRow
        dr("SupplierID") = SupplierID
        dr("SupplierDetailID") = GenID()
        dr("SupplierName") = txtName.Text
        dr("SupplierAddress") = txtAddress.Text
        dr("UnitName") = lblUnit3_name.Text
        dr("Ratio") = txtRatio.EditValue
        dr("SubCatName") = sluSubCat.Text
        dr("SubCatID") = sluSubCat.EditValue
        dr("SupplierAgent") = txtAgent.Text
        dr("SupplierTerm") = txtTerm.EditValue
        dr("SupplierContact") = String.Format("{0}{1} {2}{3}", Label2.Text, txtTel.Text, Label3.Text, txtFax.Text)
        dtNew.Rows.Add(dr)
        PnlSave.Visible = dtNew.Rows.Count > 0
    End Sub
    Private Sub btnEdit()
        LoadDef()
        Edit = True
        FoundRow = dtResult.Select("SupplierID = '" & SupplierID & "'")

        txtName.Text = FoundRow(0)("SupplierName").ToString
        txtAddress.Text = FoundRow(0)("SupplierAddress").ToString
        Dim contact As String = FoundRow(0)("SupplierContact").ToString
        If Not String.IsNullOrEmpty(contact) Then
            txtFax.Text = Trim(contact.Substring(contact.IndexOf(Label3.Text) + Label3.Text.Length))
            txtTel.Text = Trim(contact.Substring(contact.IndexOf(Label2.Text) + Label2.Text.Length).Replace(Label3.Text & txtFax.Text, ""))
        End If
        txtAgent.Text = FoundRow(0)("SupplierAgent").ToString
        txtTerm.EditValue = FoundRow(0)("SupplierTerm")

        dtNew = FoundRow.CopyToDataTable
        gcList.DataSource = dtNew
        gvList.ExpandAllGroups()
        PnlSave.Visible = True
    End Sub
    Private Sub btnDel()
        If String.IsNullOrEmpty(SupplierID) Then Return
        If MessageBox.Show("ยืนยันการลบรายการหรือไม่ ?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return
        SQL = "DELETE FROM tbSupplier WHERE SupplierID ='" & SupplierID & "'
               DELETE FROM tbSupplier_Detail WHERE SupplierID ='" & SupplierID & "'"
        dsTbl("del")
        FirstQry()
        LoadDef()
    End Sub
#End Region

#Region "Grid"
    Private Sub GVFormat()
        gcList.DataSource = dtResult
        With gvList
            .PopulateColumns(dtResult)
            gridInfo = New GridCaption(gvList)
            With gridInfo
                .HIDE.Columns("SupplierID")
                .HIDE.Columns("SupplierDetailID")
                .HIDE.Columns("SubCatID")
                .SetCaption()
            End With
            With sluSubCat.Properties
                .PopulateViewColumns()
                .View.Columns("SubCatID").Visible = False
                .View.Columns("UnitName").Caption = ""
                .View.Columns("SubCatName").Caption = "ประเภทวัสดุ"
            End With
            .Columns("SupplierName").Group()
            .Columns("Ratio").Caption = getString("RatioPO")
            .Columns("SupplierAddress").Caption = "ที่อยู่"
            .ExpandAllGroups()
            gvList.BestFitColumns()
            gvList.OptionsFind.AlwaysVisible = True
        End With

    End Sub
    Private Sub RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        If e.RowHandle <> GridControl.NewItemRowHandle Then
            If e.Column.FieldName = "del" Then
                Dim v As GridView = TryCast(sender, GridView)
                'DT = TryCast(TryCast(View.DataSource, BindingSource).DataSource, DataTable)
                DT = TryCast(gcList.DataSource, DataTable)
                DT.Rows(v.GetDataSourceRowIndex(e.RowHandle)).Delete()
            End If
        End If

    End Sub
    Private Sub CustomDracell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvList.CustomDrawCell
        If e.Column.FieldName = "SupplierTerm" Then e.DisplayText = String.Format("{0} วัน", e.CellValue)
    End Sub
#End Region

#Region "Right Click On Grid"
    Private Sub ShowMenu(ByVal hi As ViewInfo.GridHitInfo)
        Dim menu As GridViewMenu = Nothing
        If hi.HitTest = ViewInfo.GridHitTest.Row Then
            menu = New ButtonMenu(hi.View)
            menu.Init(hi)
            menu.Show(hi.HitPoint)
        End If
    End Sub
    Private Sub GridMouseDown(sender As Object, e As MouseEventArgs) Handles gvList.MouseDown
        Dim view As GridView = CType(sender, GridView)
        If e.Button = MouseButtons.Right AndAlso Edit = False Then
            SupplierID = GetGroupValue(gvList, gcList, "SupplierName", "SupplierID")
            If String.IsNullOrEmpty(SupplierID) Then Return
            ShowMenu(view.CalcHitInfo(New Point(e.X, e.Y)))
        End If
    End Sub
    Private Class ButtonMenu
        Inherits GridViewMenu
        Public Sub New(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView)
            MyBase.New(View)
        End Sub
        Protected Overrides Sub CreateItems()
            Items.Clear()
            Items.Add(CreateMenuItem("แก้ไข", My.Resources.edit_16x16, "Edit", True))
            If User.Permission >= UserInfo.UserGroup.Manger Then Items.Add(CreateMenuItem("ลบ", My.Resources.delete_16x16, "Del", True))
        End Sub
        Protected Overrides Sub OnMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
            If RaiseClickEvent(sender, Nothing) Then Return
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            If item.Tag Is Nothing Then Return
            If item.Tag.ToString() = "Edit" Then
                FmgSupplier.btnEdit()
            ElseIf item.Tag.ToString = "Del" Then
                FmgSupplier.btnDel()
            End If
        End Sub
        Public Overridable Sub Del()
            Return
            Dim PoNo As String
            PoNo = View.GetFocusedValue.ToString
            'Dim DV As New DataView(TryCast(gControl.DataSource, DataTable), "PoNo ='" & .PoNo & "'", "", DataViewRowState.CurrentRows)
            DT = TryCast(TryCast(View.DataSource, BindingSource).DataSource, DataTable)
            FoundRow = DT.Select("PoNo='" & PoNo & "' AND PoStat <> 0")
            If FoundRow.Count > 0 Then
                MsgBox("ลบไม่ได้")
            Else
                FoundRow = DT.Select("PoNo='" & PoNo & "'")
                Dim PoID As String
                PoID = FoundRow(0)("PoID").ToString
                If MessageBox.Show("ต้องการลบข้อมูลใบ PO เลขที่ " & PoNo & " หรือไม่ ?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    SQL = "DELETE FROM tbPo_Detail WHERE PoID = '" & PoID & "'
                       DELETE FROM tbPo WHERE PoID = '" & PoID & "'"
                    dsTbl("delPO")
                    BindInfo.Name = "logpo"
                    BindInfo.Refresh()
                    MessageBox.Show("ลบข้อมูลแล้ว", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    View.ExpandAllGroups()
                End If
            End If

        End Sub
    End Class
#End Region

#Region "Other Control"
    Private Sub FmgSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DS IsNot Nothing Then DS.Clear()
        FirstQry()
        LoadDef()
    End Sub
    Private Sub sluSubCat_EditValueChanged(sender As Object, e As EventArgs) Handles sluSubCat.EditValueChanged
        If dtSubCat Is Nothing Or sluSubCat.EditValue Is Nothing Then Return
        FoundRow = dtSubCat.Select("SubCatID ='" & sluSubCat.EditValue.ToString & "'")
        lblUnit3_name.Text = If(FoundRow.Count > 0, FoundRow(0)("UnitName").ToString, String.Empty)
    End Sub
    Private Sub FmgSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress, txtFax.KeyPress
        NumOnly(e, {",", "-"})
    End Sub
#End Region
End Class