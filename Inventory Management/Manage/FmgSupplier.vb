Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class FmgSupplier
    Dim dtSupplier As DataTable
    Dim supplierID As String
#Region "CODE"
    Private Sub FirstQry()
        If DS.Tables("supplier") IsNot Nothing Then DS.Tables("supplier").Clear()
        SQL = "select * from tbsupplier"
        dsTbl("supplier")
    End Sub
    Private Sub showDB()
        gcList.DataSource = DS.Tables("supplier")
        With gvList
            .PopulateColumns()
            .Columns("supplierID").Caption = "รหัส"
            .Columns("supplierID").Width = 65
            .Columns("supplierName").Caption = "ชื่อผู้ขาย"
        End With
    End Sub
    Private Sub LoadDef()
        tab1_btnNew.Enabled = True
        tab1_btnEdit.Enabled = False
        tab1_btnRemove.Enabled = False
        tab1_btnAddList.Enabled = False
        tab1_btnDelList.Enabled = False
        tab1_GrpBtn.Enabled = True
        tab1_GrpInput.Enabled = False
        tab1_txtName.Text = ""
        tab1_txtOldName.Visible = False
        tab1_lblUnitName.Text = "ชื่อผู้ขาย"
        gvList.OptionsFind.AlwaysVisible = True
        gcList.Enabled = True
        btnSave.Enabled = False
    End Sub
#End Region
#Region "Button Control"
    Private Sub AddList(sender As Object, e As EventArgs) Handles tab1_btnAddList.Click
        Dim dr As DataRow = Nothing
        Dim dupField As String

        With dtSupplier
            'chekDuplicate In DB
            FoundRow = DS.Tables("supplier").Select("supplierName = '" & tab1_txtName.Text & "'")
            If FoundRow.Count > 0 Then
                MessageBox.Show(tab1_txtName.Text & " มีในฐานข้อมูลแล้วไม่สามารถเพิ่มได้อีก", "ซ้ำในฐานข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            'chekInput
            If String.IsNullOrWhiteSpace(tab1_txtName.Text) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            dr = .NewRow
            dr("supplierID") = genID()
            dr("supplierName") = tab1_txtName.Text
            dupField = "supplierName"
            tab1_txtName.Text = ""

            For Each DataRow As DataRow In .Rows
                If String.Equals(dr(dupField), DataRow(dupField)) Then
                    MessageBox.Show("ไม่สามารถเพิ่มข้อมูลซ้ำกันได้", "ข้อมูลซ้ำกัน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If
            Next
            .Rows.Add(dr)
            .AcceptChanges()
        End With
        btnSave.Enabled = True
        gcList.Refresh()
    End Sub
    Private Sub DelList(sender As Object, e As EventArgs) Handles tab1_btnDelList.Click
        If gvList.FocusedRowHandle >= 0 Then
            dtSupplier.Rows(gvList.FocusedRowHandle).Delete()
            dtSupplier.AcceptChanges()
            gcList.Refresh()
            If gvList.RowCount = 0 Then btnSave.Enabled = False
            tab1_btnDelList.Enabled = False
        End If
    End Sub
    Private Sub btnNew(sender As Object, e As EventArgs) Handles tab1_btnNew.Click
        gvList.FindFilterText = Nothing
        tab1_GrpInput.Enabled = True
        tab1_txtName.Text = ""
        tab1_txtName.ReadOnly = False
        tab1_btnAddList.Visible = True
        tab1_btnAddList.Enabled = True
        tab1_btnDelList.Enabled = False
        tab1_btnDelList.Visible = True
        tab1_btnEdit.Enabled = False
        tab1_btnRemove.Enabled = False

        dtSupplier = DS.Tables("supplier").Copy
        dtSupplier.Clear()
        gcList.DataSource = dtSupplier
        gvList.OptionsFind.AlwaysVisible = False
    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        FirstQry()
        showDB()
        LoadDef()
        gvList.FindFilterText = Nothing
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tbDest As String = Nothing
        Dim fieldList() As String = Nothing

        If tab1_txtOldName.Visible = True Then
            If MessageBox.Show("ต้องการ เปลี่ยนจาก " & tab1_txtOldName.Text & " เป็น : " & tab1_txtName.Text, "ยืนยันการทำงาน", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                SQL = "Update tbSupplier Set supplierName='" & tab1_txtName.Text & "' Where supplierID='" & supplierID & "'"
                dsTbl("Update")
                FirstQry()
                btnCancle.PerformClick()
                Exit Sub
            End If
        End If
        fieldList = {"subpplierID", "supplierName"}
        tbDest = "tbSupplier"
        blkCpy(tbDest, dtSupplier, fieldList)
        btnCancle.PerformClick()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles tab1_btnEdit.Click
        gcList.Enabled = False
        tab1_GrpInput.Enabled = True
        tab1_txtName.ReadOnly = False
        tab1_txtOldName.Visible = True
        tab1_lblUnitName.Text = "เปลี่ยนเป็น"
        tab1_txtOldName.Text = "ชื่อเดิม : " & tab1_txtOldName.Text
        tab1_txtOldName.ReadOnly = True
        tab1_btnNew.Enabled = False
        tab1_btnRemove.Enabled = False
        btnSave.Enabled = True
    End Sub
    Private Sub btnUnit_Remove_Click(sender As Object, e As EventArgs) Handles tab1_btnRemove.Click
        If MessageBox.Show("ยืนยันการลบผู้ขาย " & tab1_txtName.Text & " หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            'clearDS
            clsDS({"chkuse", "del"})
            'chkUse
            SQL = "select supplierID from tbImportList where supplierID='" & supplierID & "'"
            dsTbl("chkuse")
            FoundRow = DS.Tables("chkuse").Select("supplierID='" & supplierID & "'")
            If FoundRow.Count > 0 Then
                MessageBox.Show("ไม่สามารถลบได้ เนื่องจากมีการใช้งานอยู่", "ลบไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                SQL = "Delete From tbSupplier Where supplierID='" & supplierID & "' Delete From tbGroupUnit Where mainUnitID='" & supplierID & "'"
                dsTbl("del")
                LoadDef()
                FirstQry()
                showDB()
                gvList.FindFilterText = Nothing
            End If
        End If
    End Sub
#End Region
#Region "Common Control"
    Private Sub FmgSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DS IsNot Nothing Then DS.Clear()
        FirstQry()
        showDB()
        LoadDef()
        gvList.FindFilterText = Nothing
    End Sub
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        If gvList.FocusedRowHandle >= 0 Then
            supplierID = gvList.GetRowCellValue(gvList.FocusedRowHandle, "supplierID")
            tab1_txtName.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "supplierName")
            tab1_txtOldName.Text = tab1_txtName.Text
            If tab1_GrpInput.Enabled = True Then
                tab1_btnDelList.Enabled = True
            Else
                tab1_btnEdit.Enabled = True
                tab1_btnRemove.Enabled = True
                tab1_txtName.ReadOnly = True
                tab1_btnAddList.Visible = False
                tab1_btnDelList.Visible = False
            End If
        End If
    End Sub
    Private Sub txtName_EditValueChanged(sender As Object, e As EventArgs) Handles tab1_txtName.EditValueChanged
        tab1_btnDelList.Enabled = False
    End Sub
#End Region
End Class