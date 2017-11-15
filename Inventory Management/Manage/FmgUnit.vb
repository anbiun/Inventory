Imports ConDB.Main
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPivotGrid

Public Class FmgUnit
    Dim dtUnitList As DataTable
    Dim unitID As String
    Enum QryMode
        All = 0
        Unittype
        GroupUnit
        MatFix
    End Enum
#Region "CODE"
    Private Sub chkTBChange(btn As SimpleButton)
        Dim Field1 As String = ""
        Dim Field2 As String = ""
        Select Case btn.Name
            Case tab1_btnAddList.Name, tab1_btnDelList.Name
                FoundRow = DS.Tables("unittype").Select("unitName = '" & tab1_txtUnitName.Text & "'")
                Field1 = "UnitName"
                Field2 = "UnitName"
            Case tab2_btnAddList.Name, tab2_btnDelList.Name
                FoundRow = DS.Tables("groupUnit").Select("mainUnitID = '" & tab2_luUnit.EditValue & "'")
                Field1 = "SubUnitID"
                Field2 = "UnitID"
            Case tab3_btnAddList.Name, tab3_btnDelList.Name
                FoundRow = DS.Tables("matFix").Select("SubCatID='" & tab3_luMat.EditValue & "'")
                Field1 = "MainUnitID"
                Field2 = "MainUnitID"
        End Select

        If FoundRow.Count = 0 Then
            btnSave.Enabled = True
            Exit Sub
        End If
        Dim SrcTB As DataTable = FoundRow.CopyToDataTable

        If dtUnitList.Rows.Count = 0 Then
            btnSave.Enabled = False
        ElseIf dtUnitList.Rows.Count <> SrcTB.Rows.Count Then
            btnSave.Enabled = True
        Else
            For DR As Integer = 0 To SrcTB.Rows.Count - 1
                If SrcTB(DR)(Field1).ToString <> dtUnitList(DR)(Field2).ToString Then
                    btnSave.Enabled = True
                    Exit Sub
                End If
            Next
            btnSave.Enabled = False
        End If
    End Sub
    Private Sub FirstQry(mode As QryMode)
        Select Case mode
            Case 1
                GoTo UnitType
            Case 2
                GoTo GroupUnit
            Case 3
                GoTo MatFix
        End Select
        If DS.Tables("subcategory") IsNot Nothing Then DS.Tables("subcategory").Clear()
        SQL = "select SubCatName, SubCatID from tbsubcategory"
        dsTbl("subcategory")


UnitType:
        If DS.Tables("unittype") IsNot Nothing Then DS.Tables("unittype").Clear()
        SQL = "select * from tbUnit"
        dsTbl("unittype")

        If DS.Tables("unituse") IsNot Nothing Then DS.Tables("unituse").Clear()
        SQL = "SELECT dbo.tbMat.MatName, dbo.tbMat.MatID, dbo.tbImportOrder.Unit1_ID, dbo.tbSubCategory.Unit3_ID AS Unit3_ID, dbo.tbMat.SubCatID "
        SQL &= "FROM dbo.tbMat INNER JOIN dbo.tbSubCategory ON dbo.tbMat.SubCatID = dbo.tbSubCategory.SubCatID LEFT OUTER JOIN "
        SQL &= "dbo.tbImportOrder ON dbo.tbMat.MatID = dbo.tbImportOrder.MatID"
        dsTbl("unituse")
        If mode = QryMode.Unittype Then Exit Sub
GroupUnit:
        If DS.Tables("groupunit") IsNot Nothing Then DS.Tables("groupunit").Clear()
        SQL = "SELECT tbGroupUnit.MainUnitID, tbGroupUnit.SubUnitID, tbUnit.unitName AS MainName, tbUnit_1.unitName AS SubName "
        SQL &= "FROM tbGroupUnit LEFT OUTER JOIN tbUnit "
        SQL &= "ON tbGroupUnit.mainUnitID = tbUnit.unitID LEFT OUTER JOIN tbUnit AS tbUnit_1 "
        SQL &= "ON tbGroupUnit.subUnitID = tbUnit_1.unitID"
        dsTbl("groupunit")

        If DS.Tables("unittype") IsNot Nothing Then DS.Tables("unittype").Clear()
        SQL = "select * from tbUnit"
        dsTbl("unittype")
        If mode = QryMode.GroupUnit Then Exit Sub
MatFix:
        If DS.Tables("matfix") IsNot Nothing Then DS.Tables("matfix").Clear()
        SQL = "SELECT tbMatUnitFix.SubCatID, tbMatUnitFix.MainUnitID, tbSubCategory.SubCatName, tbUnit.UnitName, tbMatUnitFix.UnitFixID "
        SQL &= "FROM tbMatUnitFix INNER JOIN tbSubCategory "
        SQL &= "ON tbMatUnitFix.SubCatID = tbSubCategory.SubCatID INNER JOIN tbUnit "
        SQL &= "ON tbMatUnitFix.mainUnitID = tbUnit.unitID"
        dsTbl("matfix")
        If mode = QryMode.MatFix Then Exit Sub
    End Sub
    Private Sub showDB(tab As TabSelect)
        'If DT IsNot Nothing Then DT.Clear()
        Select Case tab
            Case 1
                FirstQry(QryMode.Unittype)
                gcList.DataSource = DS.Tables("unittype")
                With gvList
                    .PopulateColumns()
                    .Columns("UnitID").Caption = "รหัส"
                    .Columns("UnitID").Width = 35
                    .Columns("UnitName").Caption = "ชื่อหน่วย"
                    .Columns("MainFlag").Visible = False
                End With
            Case 2
                FirstQry(QryMode.GroupUnit)
                gcList.DataSource = DS.Tables("groupunit")
                With gvList
                    .PopulateColumns()
                    .OptionsFind.AlwaysVisible = False
                    .Columns("MainName").Group()
                    .Columns("MainUnitID").Visible = False
                    .Columns("SubName").Caption = "หน่วยย่อย"
                    .Columns("MainName").Caption = "หน่วยนับ"
                    .Columns("SubUnitID").Caption = " "
                    .Columns("SubUnitID").Width = 100
                End With
            Case 3
                FirstQry(QryMode.MatFix)
                gcList.DataSource = DS.Tables("matfix")
                With gvList
                    .PopulateColumns()
                    .OptionsFind.AlwaysVisible = True
                    .Columns("MainUnitID").Visible = False
                    .Columns("UnitFixID").Visible = False
                    .Columns("SubCatID").Visible = False
                    .Columns("SubCatName").Group()
                    .Columns("SubCatName").Caption = "ประเภทวัสดุ"
                    .Columns("UnitName").Caption = " "
                End With

        End Select
    End Sub
    Private Sub LoadCombo()
        tab2_luUnit.Properties.DataSource = DS.Tables("unittype")
        tab2_luUnit.Properties.ValueMember = "UnitID"
        tab2_luUnit.Properties.DisplayMember = "UnitName"

        FoundRow = DS.Tables("unittype").Select("mainFlag=0")
        If FoundRow.Count = 0 Then Exit Sub
        tab2_luSubU.Properties.DataSource = FoundRow.CopyToDataTable
        tab2_luSubU.Properties.ValueMember = "UnitID"
        tab2_luSubU.Properties.DisplayMember = "UnitName"

        With tab3_luUnit.Properties
            .DataSource = DS.Tables("unittype")
            .PopulateColumns()
            .ValueMember = "UnitID"
            .DisplayMember = "UnitName"

        End With
        With tab3_luMat.Properties
            .DataSource = DS.Tables("subcategory")
            .ValueMember = "SubCatID"
            .DisplayMember = "SubCatName"
        End With
    End Sub
    Private Enum TabSelect
        tab1 = 1
        AddUnit = 1
        tab2 = 2
        FixUnit = 2
        tab3 = 3
        FixMat = 3
    End Enum
    Private Sub LoadDef(tab As TabSelect)
        Select Case tab
            Case 1
                tab1_btnEdit.Enabled = False
                tab1_btnRemove.Enabled = False
                tab1_btnAddList.Enabled = False
                tab1_btnDelList.Enabled = False
                tab1_txtUnitName.Text = ""
                tab1_GrpInput.Enabled = False
                tab1_GrpBtn.Enabled = True
                tab1_txtUnitOldName.Visible = False
                tab1_lblUnitName.Text = "ชื่อหน่วย"
                tab1_btnNew.Enabled = True
                gvList.OptionsFind.AlwaysVisible = True
                gcList.Enabled = True
            Case 2
                tab2_luUnit.ItemIndex = 0
                tab2_luSubU.ItemIndex = 0
                tab2_GrpSelect.Enabled = True
                tab2_GrpSubU.Enabled = False
                tab2_GrpSubU.Text = ""
            Case 3
                FirstQry(QryMode.Unittype)
                DV = New DataView(DS.Tables("unittype"), "mainFlag = 1", "", DataViewRowState.CurrentRows)
                tab3_luUnit.Properties.DataSource = DV
                'tab3_luUnit.Properties.Columns("UnitID").Caption = "ทดสอบ"
                tab3_btnRemove.Enabled = False
                tab3_luMat.ItemIndex = 0
                tab3_luUnit.ItemIndex = 0
                tab3_MatSelect.Enabled = True
                tab3_UnitSelect.Enabled = False
                tab3_UnitSelect.Text = ""
        End Select
        btnSave.Enabled = False
    End Sub
    Private Function chkDup_OrMainUnit(Find As String) As Boolean
        'checkDuplicate
        FoundRow = dtUnitList.Select("unitName='" & Find & "'")
        If FoundRow.Count >= 1 Then
            MsgBox("ไม่สามารถเพิ่มหน่วยที่มีอยู่แล้ว")
            Return True
        End If
        If tabControl.SelectedTabPage.Name = tab2_FixUnit.Name Then
            'checkMainUnit
            FoundRow = DS.Tables("unittype").Select("unitID='" & Find & "' And mainFlag= 1")
            If FoundRow.Count >= 1 Then
                MessageBox.Show("หน่วยนี้ถูกใช้เป็นหน่วยหลักแล้ว ไม่สามารถนำมาใช้ได้", "นำหน่วยหลักมาใช้ไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return True
            End If
        End If
        Return False
    End Function
    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, _
    ByVal e As CustomColumnDisplayTextEventArgs) Handles gvList.CustomColumnDisplayText
        If e.Column.FieldName = "SubName" Then
            If e.Value Is DBNull.Value Then e.DisplayText = "ไม่มี"
        ElseIf e.Column.FieldName = "SubUnitID" Then
            If e.Value Is DBNull.Value Then e.DisplayText = "ไม่มี"
        End If
    End Sub
#End Region
#Region "Button Control"
    Private Sub AddList(sender As Object, e As EventArgs) Handles tab1_btnAddList.Click, tab2_btnAddList.Click, tab3_btnAddList.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        Dim dr As DataRow = Nothing
        Dim dupField As String = ""

        With dtUnitList
            Select Case btn.Name
                Case tab1_btnAddList.Name
                    'chekDuplicate In DB
                    FoundRow = DS.Tables("unittype").Select("unitName = '" & tab1_txtUnitName.Text & "'")
                    If FoundRow.Count > 0 Then
                        MessageBox.Show(tab1_txtUnitName.Text & " มีในฐานข้อมูลแล้วไม่สามารถเพิ่มได้อีก", "ซ้ำในฐานข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Exit Sub
                    End If
                    'chekInput
                    If String.IsNullOrWhiteSpace(tab1_txtUnitName.Text) Then
                        MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Exit Sub
                    End If
                    dr = .NewRow
                    dr("UnitID") = genID()
                    dr("UnitName") = tab1_txtUnitName.Text
                    dr("MainFlag") = 0
                    dupField = "UnitName"
                    tab1_txtUnitName.Text = ""
                Case tab2_btnAddList.Name
                    If tab2_luSubU.EditValue = tab2_luUnit.EditValue Then
                        MessageBox.Show("ไม่สามารถเลือกซ้ำกับหน่วยหลักได้", "ซ้ำกับหน่วยหลัก", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Exit Sub
                    End If
                    dupField = "UnitID"
                    If chkDup_OrMainUnit(tab2_luSubU.EditValue) = True Then Exit Sub
                    If dtUnitList.Rows(0)("UnitID").ToString = "" Then
                        dtUnitList.Rows(0).Delete()
                        .AcceptChanges()
                    End If
                    dr = .NewRow
                    dr("UnitID") = tab2_luSubU.EditValue
                    dr("MainUnitID") = tab2_luUnit.EditValue
                    dr("MainName") = tab2_luUnit.Text
                    dr("UnitName") = tab2_luSubU.Text
                Case tab3_btnAddList.Name
                    dupField = "MainUnitID"
                    dr = .NewRow
                    dr("MainUnitID") = tab3_luUnit.EditValue
                    dr("UnitName") = tab3_luUnit.Text
                    dr("SubCatID") = tab3_luMat.EditValue
                    dr("UnitFixID") = genID()

            End Select
            For Each DataRow As DataRow In .Rows
                If String.Equals(dr(dupField), DataRow(dupField)) Then
                    MessageBox.Show("ไม่สามารถเพิ่มข้อมูลซ้ำกันได้", "ข้อมูลซ้ำกัน", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If
            Next
            .Rows.Add(dr)
            .AcceptChanges()
        End With
        gcList.Refresh()
        If btn.Name = tab2_btnAddList.Name Then
            gvList.Columns("UnitID").Visible = True
            gvList.Columns("UnitID").Caption = " "
            gvList.Columns("MainName").Group()
            gvList.ExpandAllGroups()
            gvList.Columns("UnitName").Visible = True
            gvList.Columns("UnitName").Caption = "หน่วยย่อย"

        End If
        'Duplicate Check
        chkTBChange(btn)
    End Sub
    Private Sub DelList(sender As Object, e As EventArgs) Handles tab1_btnDelList.Click, tab2_btnDelList.Click, tab3_btnDelList.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        If gvList.FocusedRowHandle >= 0 Then
            If btn.Name = tab2_btnDelList.Name And dtUnitList.Rows.Count = 1 Then
                dtUnitList.Rows(0)("UnitID") = DBNull.Value
                dtUnitList.Rows(0)("UnitName") = DBNull.Value
                gvList.Columns("MainName").UnGroup()
                gvList.Columns("UnitName").Visible = False
                gvList.Columns("UnitID").Visible = False
            Else
                dtUnitList.Rows(gvList.FocusedRowHandle).Delete()
            End If
            dtUnitList.AcceptChanges()
            gcList.Refresh()
            If gvList.RowCount = 0 Then btnSave.Enabled = False
            btn.Enabled = False
        End If
        chkTBChange(btn)
    End Sub
    Private Sub btnOK(sender As Object, e As EventArgs) Handles tab1_btnNew.Click, tab2_btnOK.Click, tab3_btnOk.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        gvList.FindFilterText = Nothing
        Select Case btn.Name
            Case tab1_btnNew.Name
                tab1_GrpInput.Enabled = True
                tab1_txtUnitName.Text = ""
                tab1_txtUnitName.ReadOnly = False
                tab1_btnDelList.Enabled = False
                tab1_btnAddList.Visible = True
                tab1_btnDelList.Visible = True
                tab1_btnAddList.Enabled = True
                tab1_btnRemove.Enabled = False
                tab1_btnEdit.Enabled = False
                dtUnitList = DS.Tables("unittype").Copy
                dtUnitList.Clear()
                gcList.DataSource = dtUnitList
                gvList.OptionsFind.AlwaysVisible = False
            Case tab2_btnOK.Name
                tab2_GrpSubU.Text = "กำหนดหน่วยที่อยู่ภายใต้ [" & tab2_luUnit.Text & "]"
                tab2_GrpSelect.Enabled = False
                tab2_GrpSubU.Enabled = True
                tab2_btnDelList.Enabled = False

                FoundRow = DS.Tables("groupunit").Select("mainUnitID = '" & tab2_luUnit.EditValue & "'")
                If FoundRow.Count >= 1 Then
                    dtUnitList = FoundRow.CopyToDataTable
                    dtUnitList.Columns("SubUnitID").ColumnName = "UnitID"
                    dtUnitList.Columns("SubName").ColumnName = "UnitName"
                    gcList.DataSource = dtUnitList
                    gvList.PopulateColumns()
                    gvList.Columns("MainName").Visible = False
                    gvList.Columns("MainUnitID").Visible = False
                    gvList.Columns("UnitID").Caption = " "
                    gvList.Columns("UnitID").Width = 100
                    gvList.Columns("UnitName").Caption = "หน่วยย่อย"

                    gvList.Columns("MainName").Caption = "หน่วยนับ"
                    gvList.Columns("MainName").Group()
                    gvList.ExpandAllGroups()
                Else
                    dtUnitList = DS.Tables("unittype").Copy
                    dtUnitList.Columns.Add("MainUnitID")
                    dtUnitList.Columns.Add("MainName")
                    dtUnitList.Rows.Clear()
                    Dim dtr As DataRow
                    dtr = dtUnitList.NewRow
                    dtr("MainName") = tab2_luUnit.Text
                    dtr("MainUnitID") = tab2_luUnit.EditValue
                    dtUnitList.Rows.Add(dtr)
                    dtUnitList.AcceptChanges()
                    gcList.DataSource = dtUnitList
                    gvList.PopulateColumns()
                    gvList.Columns("MainFlag").Visible = False
                    gvList.Columns("MainName").Visible = True
                    gvList.Columns("MainName").Caption = "หน่วยนับ"
                    gvList.Columns("MainUnitID").Visible = False
                    gvList.Columns("UnitID").Visible = False
                    gvList.Columns("UnitName").Visible = False
                    btnSave.Enabled = True
                    'gvList.Columns("MainName").UnGroup()
                End If

            Case tab3_btnOk.Name
                FoundRow = DS.Tables("matFix").Select("SubCatID='" & tab3_luMat.EditValue & "'")
                If FoundRow.Count >= 1 Then
                    dtUnitList = FoundRow.CopyToDataTable
                    gcList.DataSource = dtUnitList
                    gvList.PopulateColumns()
                    gvList.Columns("SubCatName").Visible = False
                Else
                    dtUnitList = DS.Tables("matFix").Copy
                    With dtUnitList
                        .Rows.Clear()
                        .Columns.Clear()
                        .Columns.Add("SubCatID")
                        .Columns.Add("MainUnitID")
                        .Columns.Add("UnitName")
                        .Columns.Add("UnitFixID")
                    End With
                    gcList.DataSource = dtUnitList
                    gvList.PopulateColumns()
                End If
                With gvList
                    .Columns("SubCatID").Visible = False
                    .Columns("MainUnitID").Visible = False
                    .Columns("UnitName").Caption = "หน่วยนับที่ใช้อยู่"
                    .Columns("UnitFixID").Visible = False
                End With

                tab3_MatSelect.Enabled = False
                tab3_UnitSelect.Enabled = True
                tab3_UnitSelect.Text = "กำหนดหน่วยนับที่ใช้สำหรับ [" & tab3_luMat.Text & "]"
                tab3_btnAddList.Enabled = True
                tab3_btnDelList.Enabled = False
                gvList.OptionsFind.AlwaysVisible = False

        End Select
    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Dim tab As TabSelect
        Select Case tabControl.SelectedTabPage.Name
            Case tab1_AddUnit.Name
                tab = TabSelect.tab1
            Case tab2_FixUnit.Name
                tab = TabSelect.tab2
            Case tab3_FixMat.Name
                tab = TabSelect.tab3
        End Select
        showDB(tab)
        LoadDef(tab)
        LoadCombo()
        gvList.FindFilterText = Nothing
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tab As DevExpress.XtraTab.XtraTabPage = Nothing
        Dim tbDest As String = Nothing

        Dim fieldList() As String = Nothing
        Select Case tabControl.SelectedTabPage.Name
            Case tab1_AddUnit.Name
                If tab1_txtUnitOldName.Visible = True Then
                    If MessageBox.Show("ต้องการ เปลี่ยนจาก " & tab1_txtUnitOldName.Text & " เป็น : " & tab1_txtUnitName.Text, "ยืนยันการทำงาน", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        SQL = "Update tbUnit Set unitName='" & tab1_txtUnitName.Text & "' Where unitID='" & unitID & "'"
                        dsTbl("Update")
                        btnCancle.PerformClick()
                        Exit Sub
                    End If
                End If

                fieldList = {"UnitID", "UnitName"}
                tbDest = "tbUnit"
            Case tab2_FixUnit.Name
                SQL = "Delete From tbGroupUnit Where mainUnitID='" & tab2_luUnit.EditValue & "'"
                dsTbl("del")
                SQL = "Update tbUnit Set mainFlag='1' Where unitID='" & tab2_luUnit.EditValue & "'"
                dsTbl("update")

                fieldList = {"MainUnitID", "SubUnitID"}
                tbDest = "tbGroupUnit"
            Case tab3_FixMat.Name
                SQL = "Delete From tbMatUnitFix Where SubCatID='" & tab3_luMat.EditValue & "'"
                dsTbl("del")

                fieldList = {"SubCatID", "MainUnitID", "UnitFixID"}
                tbDest = "tbMatUnitFix"
        End Select
        blkCpy(tbDest, dtUnitList, fieldList)
        'Edit
        btnCancle.PerformClick()
    End Sub
    Private Sub btnUnit_Edit_Click(sender As Object, e As EventArgs) Handles tab1_btnEdit.Click
        gcList.Enabled = False
        tab1_GrpInput.Enabled = True
        tab1_txtUnitName.ReadOnly = False
        tab1_txtUnitOldName.Visible = True
        tab1_lblUnitName.Text = "เปลี่ยนเป็น"
        tab1_txtUnitOldName.Text = "หน่วยเดิมคือ : " & tab1_txtUnitName.Text
        tab1_txtUnitOldName.ReadOnly = True
        tab1_btnNew.Enabled = False
        tab1_btnRemove.Enabled = False
        btnSave.Enabled = True
    End Sub
    Private Sub btnUnit_Remove_Click(sender As Object, e As EventArgs) Handles tab1_btnRemove.Click, tab3_btnRemove.Click, tab2_BtnRemove.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        Select Case btn.Name
            Case tab1_btnRemove.Name
                If MessageBox.Show("ยืนยันการลบหน่วย " & tab1_txtUnitName.Text & " หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    If DS.Tables("unituse") IsNot Nothing Then
                        FoundRow = DS.Tables("unituse").Select("Unit3_ID='" & unitID & "' or Unit1_ID='" & unitID & "'")
                    End If
                    If FoundRow.Count > 0 Then
                        MessageBox.Show("ไม่สามารถลบได้ เนื่องจากมีการใช้งานอยู่", "ลบไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        Dim Field As String = "SubUnitID"
chkFieldMainID:
                        FoundRow = DS.Tables("groupunit").Select(Field & "='" & unitID & "'")
                        If FoundRow.Count > 0 Then
                            MessageBox.Show("ไม่สามารถลบได้ เนื่องจากมีการนำไปใช้อยู่กรุณาตรวจสอบ", "ลบไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            tabControl.SelectedTabPage = tab2_FixUnit
                            LoadDef(TabSelect.tab2)
                            showDB(TabSelect.tab2)
                            gvList.Columns("MainUnitID").Visible = True
                            gvList.FindFilterText = unitID
                            gvList.ExpandAllGroups()
                            gvList.Columns("MainUnitID").Visible = False
                            Exit Sub
                        ElseIf Field = "SubUnitID" Then
                            Field = "MainUnitID"
                            GoTo chkFieldMainID
                        End If

                        SQL = "Delete From tbUnit Where unitID='" & unitID & "' Delete From tbGroupUnit Where mainUnitID='" & unitID & "'"
                        dsTbl("del")
                        LoadDef(TabSelect.tab1)
                        showDB(TabSelect.tab1)
                        gvList.FindFilterText = Nothing
                    End If
                End If
            Case tab2_BtnRemove.Name
                If MessageBox.Show("ยืนยันการลบหน่วยนับ หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    FoundRow = DS.Tables("matFix").Select("mainUnitID='" & tab2_luUnit.EditValue & "'")
                    If FoundRow.Count > 0 Then
                        MessageBox.Show("ไม่สามารถลบได้ เนื่องจากมีการนำไปใช้อยู่กรุณาตรวจสอบ", "ลบไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tabControl.SelectedTabPage = tab3_FixMat
                        LoadDef(TabSelect.tab3)
                        showDB(TabSelect.tab3)
                        gvList.Columns("MainUnitID").Visible = True
                        gvList.FindFilterText = tab2_luUnit.EditValue
                        gvList.ExpandAllGroups()
                        gvList.Columns("MainUnitID").Visible = False
                        Exit Sub
                    End If

                    SQL = "Update tbUnit Set MainFlag=0 Where UnitID='" & tab2_luUnit.EditValue & "'"
                    dsTbl("update")
                    SQL = "Delete From tbGroupUnit Where mainUnitID='" & tab2_luUnit.EditValue & "'"
                    dsTbl("del")
                    LoadDef(TabSelect.tab2)
                    showDB(TabSelect.tab2)
                End If
            Case tab3_btnRemove.Name
                If MessageBox.Show("ยืนยันการลบหน่วยของประเภท " & tab3_luMat.Text & " หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    FoundRow = DS.Tables("unituse").Select("SubCatID='" & tab3_luMat.EditValue & "'")
                    For Each row As DataRow In dtUnitList.Rows
                        FoundRow = DS.Tables("matFix").Select("mainUnitID='" & row("MainUnitID") & "'")
                        If FoundRow.Count > 0 Then
                            MessageBox.Show("ไม่สามารถลบได้ เนื่องจากมีการนำไปใช้อยู่กรุณาตรวจสอบ", "ลบไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Next
                    SQL = "Delete From tbMatUnitFix Where SubCatID='" & tab3_luMat.EditValue & "'"
                    dsTbl("del")
                    LoadDef(TabSelect.tab3)
                    showDB(TabSelect.tab3)
                End If
        End Select

    End Sub
#End Region

#Region "Common Control"
    Private Sub FrmUnitManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DS IsNot Nothing Then DS.Clear()
        FirstQry(QryMode.All)
        showDB(TabSelect.tab1)
        tabControl.SelectedTabPage = tab1_AddUnit
        gcList.DataSource = DS.Tables("unittype")
        LoadCombo()
        LoadDef(TabSelect.tab1)
        gvList.FindFilterText = Nothing
    End Sub
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        If gvList.FocusedRowHandle >= 0 Then
            Select Case tabControl.SelectedTabPage.Name
                Case tab1_AddUnit.Name
                    unitID = gvList.GetRowCellValue(gvList.FocusedRowHandle, "UnitID")
                    tab1_txtUnitName.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "UnitName")
                    If tab1_GrpInput.Enabled = True Then
                        tab1_btnDelList.Enabled = True
                    Else
                        tab1_btnEdit.Enabled = True
                        tab1_btnRemove.Enabled = True
                        tab1_txtUnitName.ReadOnly = True
                        tab1_btnAddList.Visible = False
                        tab1_btnDelList.Visible = False
                    End If
                Case tab2_FixUnit.Name
                    If tab2_GrpSubU.Enabled = True Then
                        If dtUnitList(0)("UnitID") Is DBNull.Value Then Exit Select
                        tab2_luSubU.EditValue = gvList.GetRowCellValue(gvList.FocusedRowHandle, "UnitID")
                        tab2_btnDelList.Enabled = True
                    End If
                Case tab3_FixMat.Name
                    If tab3_UnitSelect.Enabled = True Then
                        tab3_luUnit.EditValue = gvList.GetRowCellValue(gvList.FocusedRowHandle, "MainUnitID")
                        tab3_btnDelList.Enabled = True
                    End If
            End Select
        End If

    End Sub
    Private Sub rowClick(sender As Object, e As RowClickEventArgs) Handles gvList.RowClick
        If IsDBNull(gvList.FocusedValue) Then Exit Sub
        Dim values As String = gvList.GetFocusedValue
        Dim vw As ColumnView = gcList.MainView
        'Dim values As String = gvList.GetRowCellDisplayText(gvList.FocusedRowHandle, "MainName")
        Dim FieldName As String = ""
        Dim FieldID As String = ""
        Dim ctr As LookUpEdit = Nothing
        Select Case tabControl.SelectedTabPage.Name
            Case tab2_FixUnit.Name
                FieldName = "MainName"
                FieldID = "MainUnitID"
                ctr = tab2_luUnit
            Case tab3_FixMat.Name
                FieldName = "SubCatName"
                FieldID = "SubCatID"
                ctr = tab3_luMat
        End Select
        Try
            Dim RHandle As Integer = 0
            Dim Col As DevExpress.XtraGrid.Columns.GridColumn = vw.Columns(FieldName)
            While True
                RHandle = vw.LocateByValue(RHandle, Col, values)
                If RHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    Exit While
                End If
                If gvList.GetRowCellValue(RHandle, FieldName) = values Then
                    ctr.EditValue = gvList.GetRowCellValue(RHandle, FieldID)
                    tab3_btnRemove.Enabled = True
                    Exit While
                End If
                RHandle += 1
            End While
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tabControl_Click(sender As Object, e As EventArgs) Handles tabControl.Click
        Dim tab As TabSelect
        Select Case tabControl.SelectedTabPage.Name
            Case tab1_AddUnit.Name
                tab = TabSelect.tab1
            Case tab2_FixUnit.Name
                tab = TabSelect.tab2
            Case tab3_FixMat.Name
                tab = TabSelect.tab3
        End Select
        LoadDef(tab)
        showDB(tab)
        LoadCombo()
        gvList.FindFilterText = Nothing
    End Sub
    Private Sub txtUnit_Name_EditValueChanged(sender As Object, e As EventArgs) Handles tab1_txtUnitName.EditValueChanged, tab1_txtUnitOldName.EditValueChanged
        tab1_btnDelList.Enabled = False
    End Sub
#End Region

End Class
