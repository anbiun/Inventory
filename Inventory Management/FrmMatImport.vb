﻿Imports ConDB.Main
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.ComponentModel

Public Class FrmMatImport
    Dim ImportID, PoNo, UnitID, matDeID, MatID, MatName, pieceUnitID, SupplierID As String
    Dim matQty, piece, Price As Double
    Dim Vat As Integer
    Dim ImportDate As DateTime = Today
    Dim LoadSuccess As Boolean = False
    Dim unit1, unit2, unit3 As Double
    Dim dtImportList, dtImportOrder, dtImportDetail As New DataTable
    Dim gvSelect As GridView
    Dim Unit3_Name As String
    Dim Ratio, QtyPerUnit As Double
    Dim RatioEditList As New List(Of String)
    Dim Button_Edit As New Buttons
    Enum QryMode
        All
        MainUnit
        SubUnit
    End Enum
    Dim ImReq As New InOutFunc
#Region "Function"
    Private Sub gvFormat()
        gridInfo = New GridCaption(gvImportList)
        With gridInfo
            .HIDE.Columns("UserStock_ID")
            .HIDE.Columns("UserApprove_ID")
            .HIDE.Columns("UserApprove")
            .HIDE.Columns("SupplierID")
            .HIDE.Columns("ImportID")
            .HIDE.Columns("Stat")
            .HIDE.Columns("userapprove_name")
            .SetCaption()
        End With
        gridInfo = New GridCaption(gvImportOrder)
        With gridInfo
            .HIDE.Columns("matID")
            .HIDE.Columns("importorid")
            .HIDE.Columns("Unit1_id")
            .HIDE.Columns("Importid")
            .HIDE.Columns("qtyperunit")
            .HIDE.Columns("locid")
            .HIDE.Columns("เรโช")
            .SetCaption()
        End With
        gvImportList.BestFitColumns()
        gvImportOrder.BestFitColumns()
        gvImportOrder.Columns("Notation").Image = My.Resources.edit_16x16
    End Sub
    Private Sub FirstQry(Mode As QryMode)
        Select Case Mode
            Case QryMode.MainUnit
                GoTo MainUnit
            Case QryMode.SubUnit
                GoTo SubUnit
        End Select

        SQL = "SELECT PoNo FROM vwPo_Detail GROUP BY PoNo"
        dsTbl("PoNo")

        'ImportList
        SQL = "select * from vwImportList"
        dsTbl("ImportList")

        'ImportOrder
        SQL = "select * from vwImportOrder"
        dsTbl("ImportOrder")

        SQL = "select * from tbUnit"
        dsTbl("Unit")

MainUnit:
        If DS.Tables("mainUnit") IsNot Nothing Then DS.Tables("mainUnit").Clear()
        SQL = "SELECT tbUnit.UnitID, tbMatUnitFix.SubCatID, tbUnit.UnitName " _
            & "FROM tbMatUnitFix INNER JOIN tbUnit ON tbMatUnitFix.mainUnitID = tbUnit.UnitID
            order by UnitName"
        dsTbl("mainUnit")
        If Mode <> QryMode.All Then Exit Sub

SubUnit:
        If DS.Tables("subUnit") IsNot Nothing Then DS.Tables("subUnit").Clear()
        SQL = "SELECT tbGroupUnit.mainUnitID, tbGroupUnit.subUnitID, tbUnit.UnitName " _
            & "FROM tbUnit INNER JOIN tbGroupUnit ON tbUnit.UnitID = tbGroupUnit.subUnitID"
        dsTbl("subUnit")
        If Mode <> QryMode.All Then Exit Sub
    End Sub
    Private Function search(table As String, values As String, sort As String)
        DV = New DataView(DS.Tables(table), values, "", DataViewRowState.CurrentRows)
        Return DV
    End Function
    Private Sub SumUnit()
        Dim gvDes As GridView
        gvDes = gvImportOrder
        Dim unit1Sum, unit3Sum As Double

        For rw As Integer = 0 To gvDes.RowCount - 1
            If MatID = gvDes.GetRowCellValue(rw, "MatID") Then
                With gvDes
                    .SetRowCellValue(rw, "Unit1_Sum", unit1Sum)
                    .SetRowCellValue(rw, "Unit3_Sum", unit3Sum)
                End With
            End If
        Next
    End Sub
    Private Sub cancelFunc()
        pnlEdit.Location = New Point(107, 219)
        BtnDelete.ImageOptions.Image = My.Resources.delete_16x16
        sluSubCat.EditValue = Nothing
        sluMat.EditValue = Nothing
        sluSupplier.EditValue = Nothing
        luUnit1_name.EditValue = Nothing

        grpMatImport.Visible = True
        grpMatImport.Enabled = False
        grpSearch.Enabled = True
        PnlSave.Visible = False
        BtnNew.Enabled = True
        Dim grp() As GroupControl = {grpMatImport, grpSearch}
        For Each group As Control In grp
            For Each ctrl As Control In group.Controls
                If TypeOf (ctrl) Is TextBox Then
                    ctrl.Text = ""
                ElseIf TypeOf (ctrl) Is MemoEdit Then
                    ctrl.Text = ""
                End If
            Next
        Next
        lblLastTag.Text = ""
        gcImportList.DataSource = Nothing
        gcImportOrder.DataSource = Nothing
        FirstQry(QryMode.All)
        gcImportList.DataSource = search("ImportList", "ImportDate='" & ImportDate & "'", "")
        LoadLookUp()
        Button_Edit.State = Buttons.EState.TurnOff

        BtnEdit.Text = "แก้ไข"
        BtnDelete.Text = "ลบ"
        BtnNew.Visible = True
        sluSubCat.Enabled = True
    End Sub
    Private Sub editFunc()
        If Button_Edit.State = Buttons.EState.TurnOn Then
            If ChkInput(grpSearch) = False Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                With dtImportList
                    Dim rw As Integer = gvImportList.FocusedRowHandle
                    .Rows(rw)("ImportDate") = deImport.EditValue
                    .Rows(rw)("BillNo") = txtBillNo.Text
                    .Rows(rw)("SupplierName") = sluSupplier.Text
                    .Rows(rw)("SupplierID") = sluSupplier.EditValue
                    .Rows(rw)("Notation") = txtImportNote.EditValue
                    ImportID = .Rows(rw)("ImportID")
                    .AcceptChanges()
                End With

            End If
            grpSearch.Enabled = False
            grpMatImport.Enabled = True
            PnlSave.Visible = True

            'กำหนด Tag ล่าสุด ถ้า Tag ล่าสุดมีในรายการให้ลยย้อนกลับ 1
            Dim _Lasttag As Func(Of String) = Function()
                                                  Dim lasInDB As String = getTagID()
                                                  For Each item As DataRow In dtImportOrder.Rows
                                                      If item("tagID").ToString.Contains(lasInDB) Then
                                                          lasInDB += -1
                                                          Exit For
                                                      End If
                                                  Next
                                                  Return lasInDB
                                              End Function
            lblLastTag.Text = _Lasttag()
            'Dim TagThisMonth As String = Today.ToString("yMM00")
            'If lblLastTag.Contains(dt)
            FoundRow = DS.Tables("ImportOrder").Select("ImportID='" & ImportID & "'")
            dtImportOrder = FoundRow.CopyToDataTable
            gcImportOrder.DataSource = dtImportOrder
            Exit Sub
        End If
        Dim vw As GridView = gvImportOrder
        Dim IDValue As String = vw.GetRowCellValue(0, "MatID")
        sluSubCat.EditValue = Nothing
        sluSubCat.EditValue = IDValue.Substring(0, 4)

        BtnEdit.Text = "ตกลง"
        BtnDelete.Text = "ยกเลิก"
        BtnNew.Visible = False
        sluSubCat.Enabled = False
        dtImportList = DS.Tables("ImportList").Select("ImportID = '" & gvImportList.GetFocusedRowCellValue("ImportID") & "'").CopyToDataTable
        gcImportList.DataSource = dtImportList
        Button_Edit.State = Buttons.EState.TurnOn
    End Sub
    Private Sub RowClickFunc(gv As GridView, Optional ByVal RowNum As Integer = 0)
        'If Button_Edit.State = Buttons.EState.TurnOn Then Exit Sub
        Dim rw As Integer = gv.FocusedRowHandle
        If RowNum <> 0 Then rw = RowNum
        Dim GVList() As GridView = {gvImportList, gvImportOrder}
        For Each gvs In GVList
            With gvs
                If .Name <> gv.Name Then
                    .OptionsSelection.EnableAppearanceFocusedRow = False
                Else
                    .FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
                    .Appearance.FocusedRow.BackColor = Color.CornflowerBlue
                    .Appearance.FocusedRow.ForeColor = Color.White
                    .OptionsSelection.EnableAppearanceFocusedRow = True
                End If
            End With
        Next

        If rw >= 0 And grpSearch.Enabled = True Then
            Dim values = gv.GetRowCellValue(rw, "ImportID")
            MatID = gv.GetRowCellValue(rw, "MatID")
            Select Case gv.Name
                Case gvImportList.Name
                    gcImportOrder.DataSource = search("ImportOrder", "ImportID ='" & values & "'", "")
            End Select
        Else
            gvSelect = gv
        End If
        If gvImportOrder.RowCount > 0 Then gvImportOrder.BestFitColumns() : gvImportOrder.Columns("Notation").Width *= 2
        If gvImportOrder.FocusedColumn.FieldName = "del" And dtImportOrder.Rows.Count > 0 Then
            Try
                dtImportOrder.Rows(gv.GetDataSourceRowIndex(rw)).Delete()
                dtImportOrder.AcceptChanges()
            Catch ex As Exception
                Return
            End Try
        End If

        gv.SelectRow(rw)
        gv.Focus()
    End Sub
    Private Sub Transfer()
        For Each item As DataRow In dtImportList.Rows
            ImportID = item("ImportID")
            Dim dbug As String
            dbug = dtImportOrder.Rows.Count

            SQL = "INSERT INTO tbStock (MatID, Unit1, Unit1_ID, Unit3, TagID, ImportDate, ImportID, LocID)"
            SQL &= " SELECT tbImportOrder.MatID,"
            If Not rdSurPlus.EditValue Then
                SQL &= "Floor(tbImportOrder.Unit1_Sum) Unit1, tbImportOrder.Unit1_ID, Floor(tbImportOrder.Unit1_Sum) * tbImportOrder.Ratio Unit3,"
            Else
                SQL &= "tbImportOrder.Unit1_Sum AS Unit1, tbImportOrder.Unit1_ID, tbImportOrder.Unit3_Sum AS Unit3,"
            End If
            SQL &= " tbImportOrder.TagID, tbImportList.ImportDate, tbImportList.ImportID,'" & User.SelectLoc & "' AS LocID"
            SQL &= " FROM tbImportOrder INNER JOIN tbImportList ON tbImportOrder.ImportID = tbImportList.ImportID INNER JOIN tbMat ON tbImportOrder.MatID = tbMat.MatID"
            SQL &= " INNER JOIN tbSubCategory ON tbMat.CatID+tbMat.SubCatID = tbSubCategory.CatID+tbSubCategory.SubCatID"
            SQL &= " WHERE (tbImportOrder.ImportID = '" & ImportID & "') "
            dbug = SQL
            'SQL &= " UPDATE tbImportList SET Stat=1 WHERE ImportID='" & ImportID & "'"
            dsTbl("transfer")
        Next
        MessageBox.Show("บันทึกยอดเข้าคลังเสร็จสมบูรณ์", "บันทึกยอดเข้าคลัง", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function chkDuplicate(Values As String, Optional tbName As String = "ImportList", Optional findStr As String = "BillNo='")
        FoundRow = DS.Tables(tbName).Select(findStr & Values & "'")
        Return If(FoundRow.Count > 0, False, True)
    End Function
    Private Function FindMissTag(GridValue As GridView, CurrentTag As String) As String
        Dim TagList As New List(Of String)
        Dim STag As String = SlClick(sluMat, "TagID") + User.SelectLoc.Substring(5, 1)
        Dim Ret As String = CurrentTag
        TagList.Add(STag + lblLastTag.Text)
        For i As Integer = 0 To GridValue.RowCount - 1
            TagList.Add(GridValue.GetRowCellValue(i, "TagID"))
        Next
        Ret = TagList(0)
        For Each Item As String In TagList
            If TagList.Contains(Ret) Then
                Ret = STag & Ret.Substring(STag.Length) + 1
            Else
                Exit For
            End If
        Next

        Return Ret.Substring(STag.Length)
    End Function
    Private Function getTagID()
        Dim sDate As String = CDate(deImport.EditValue).ToString("yyMM")
        Dim res As String = ""
        'Make TagID
        SQL = "SELECT MAX(O.tagID) from tbImportOrder O"
        SQL &= " INNER JOIN tbMat M ON O.MatID = M.MatID"
        'SQL &= " WHERE M.SubCatID ='" & slClick(sluSubCat, "SubCatID") & "'"
        'SQL &= " AND M.CatID='" & slClick(sluSubCat, "CatID") & "'"
        SQL &= " WHERE M.CatID+M.SubCatID LIKE '%" & sluSubCat.EditValue & "'"
        SQL &= " AND O.LocID='" & User.SelectLoc & "'"
        dsTbl("gettag")

        If DS.Tables("gettag").Rows.Count > 0 Then
            res = If(IsDBNull(DS.Tables("gettag")(0)(0)), sDate & "00", DS.Tables("gettag")(0)(0).ToString.Substring(4, 6))
            res = If(res.Contains(Now.ToString("yyMM")), res, Now.ToString("yyMM") & "00")
        End If
        Return res
    End Function
#End Region
#Region "Lookup Control"
    Private Sub LoadLookUp()

        'All ComboBoxData
        SQL = "select SupplierID,SupplierName from tbSupplier"
        dsTbl("Supplier")
        With sluSupplier.Properties
            .ValueMember = "SupplierID"
            .DisplayMember = "SupplierName"
            .DataSource = DS.Tables("Supplier")
            .PopulateViewColumns()
            .View.Columns("SupplierID").Caption = "รหัส"
            .View.Columns("SupplierID").Visible = False
            .View.Columns("SupplierID").Width = 25
            .View.Columns("SupplierName").Caption = getString("SupplierName")
        End With

        SQL = "SELECT CatID+SubCatID IDValue,SubCatName,GroupTag FROM tbSubCategory"
        BindInfo.Name = "subcat"
        BindInfo.Qry(SQL)
        With sluSubCat.Properties
            .DataSource = BindInfo.Result
            .ValueMember = "IDValue"
            .DisplayMember = "SubCatName"
            .PopulateViewColumns()
            .View.Columns("IDValue").Visible = False
            .View.Columns("SubCatName").Caption = getString("SubCatName")
            .View.Columns("GroupTag").Visible = False
        End With
    End Sub
    Private Sub LookUpEditValueChanged(sender As Object, e As EventArgs)
        If LoadSuccess = False Then Exit Sub
        'lblVolume.Text = luUnit1_name.Text & " ละ"
    End Sub
    Private Sub sluMat_EditValueChanged(sender As Object, e As EventArgs) Handles sluMat.EditValueChanged
        If LoadSuccess = False Then Exit Sub
        LoadLookUnit()
        MatID = sluMat.EditValue
        Ratio = SlClick(sluMat, "Ratio")
        QtyPerUnit = SlClick(sluMat, "QtyPerUnit")
    End Sub
    Private Sub LoadLookUnit()
        'Dim vw As GridView = sluMat.Properties.View
        'Dim rowHandle As Integer = sluMat.Properties.GetIndexByKeyValue(sluMat.EditValue)
        Dim subID As String = SlClick(sluMat, "SubCatID")
        Dim uID As String = SlClick(sluMat, "Unit3_ID")

        FoundRow = DS.Tables("mainUnit").Select("SubCatID='" & subID & "'")
        If FoundRow.Count > 0 Then
            With luUnit1_name.Properties
                .DataSource = FoundRow.CopyToDataTable
                .DisplayMember = "UnitName"
                .ValueMember = "UnitID"
                .PopulateColumns()
                .Columns("UnitName").Caption = "หน่วย"
                .Columns("UnitID").Caption = "รหัส"
                .Columns("SubCatID").Visible = False
            End With
            luUnit1_name.ItemIndex = 0
        Else
            luUnit1_name.Properties.DataSource = Nothing
        End If
        FoundRow = DS.Tables("Unit").Select("UnitID='" & uID & "'")
        If FoundRow.Count > 0 Then
            Unit3_Name = FoundRow(0)("UnitName")
            lblUnit3_name.Text = Unit3_Name
        Else
        End If
    End Sub
#End Region

#Region "Button Control"
    Private Sub btnProcess(btn As DevExpress.XtraEditors.SimpleButton)
        Select Case btn.Name
            Case BtnSave.Name
                If dtImportOrder.Rows.Count <= 0 Then
                    MessageBox.Show("กรุณาตรวจสอบข้อมูล", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If Button_Edit.State = Buttons.EState.TurnOn Then
                    Dim delTb() As String = {"tbImportList", "tbImportOrder", "tbStock"}
                    For Each tbname As String In delTb
                        SQL = "DELETE FROM " & tbname
                        SQL &= " WHERE ImportID='" & ImportID & "'"
                        dsTbl("del")
                    Next
                    dtImportList.TableName = "ImportList"
                    dtImportOrder.TableName = "ImportOrder"
                End If

                'BulkCopy 3 table
                Dim tbList() As DataTable = {dtImportList, dtImportOrder}

                Dim fieldList() As String = Nothing
                For Each tbName As DataTable In tbList
                    Select Case tbName.TableName
                        Case dtImportList.TableName
                            fieldList = {"ImportDate", "BillNo", "ImportID", "SupplierID", "UserStock_ID", "UserApprove_ID", "Notation"}
                        Case dtImportOrder.TableName
                            fieldList = {"ImportOrID", "ImportID", "MatID", "Unit1_Sum", "Unit3_Sum", "Unit1_ID", "TagID", "Ratio", "QtyPerUnit", "LocID", "Notation", "PoNo"}
                    End Select
                    tbName.TableName = "tb" & tbName.TableName
                    blkCpy(tbName.TableName, tbName, fieldList)
                Next

            Case BtnDelete.Name
                If Button_Edit.State = Buttons.EState.TurnOn Then
                    cancelFunc()
                    Exit Sub
                End If
                ImportID = gvImportList.GetRowCellValue(gvImportList.FocusedRowHandle, "ImportID")
                If ImportID = Nothing Then Exit Sub
                If MessageBox.Show("ยืนยันการลบ ใบรับของเลขที่ : " & gvImportList.GetRowCellValue(gvImportList.FocusedRowHandle, "BillNo"), "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    SQL = " delete from tbImportList where ImportID ='" & ImportID & "'" _
                        & " delete from tbImportOrder where ImportID ='" & ImportID & "'" _
                        & " delete from tbStock where ImportID ='" & ImportID & "'"
                    dsTbl("del")
                    cancelFunc()
                    deImport.EditValue = gvImportList.GetRowCellValue(gvImportList.FocusedRowHandle, "ImportDate")
                End If
        End Select
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles BtnNew.Click, BtnEdit.Click, BtnDelete.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        Select Case btn.Name
            Case BtnNew.Name
                If User.Permission < UserInfo.UserGroup.Manger And txtBillNo.TextLength <> 5 Then MessageBox.Show(LabelControl10.Text & "ไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Return
                If ChkInput(grpSearch, txtImportNote.Name) = False Then Exit Sub
                If chkDuplicate(Trim(txtBillNo.Text), "ImportList", "ImportDate='" & deImport.EditValue & "' AND BillNo='") = False Then
                    MessageBox.Show("เลขที่เอกสารนี้มีในระบบแล้ว", "เลขที่ซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    cancelFunc()
                    Exit Sub
                End If
                lblLastTag.Text = getTagID()
                grpMatImport.Enabled = True
                grpSearch.Enabled = False
                PnlSave.Visible = True
                'PnlbtnItem.Visible = False

                dtImportOrder = DS.Tables("ImportOrder").Copy

                If dtImportOrder IsNot Nothing Or dtImportDetail IsNot Nothing Then
                    dtImportOrder.Rows.Clear()
                    dtImportDetail.Rows.Clear()
                End If

                gcImportOrder.DataSource = dtImportOrder

                'matOrder
                dtImportList = DS.Tables("ImportList").Copy
                dtImportList.Rows.Clear()
                gcImportList.DataSource = dtImportList

                Dim dtRow As DataRow
                ImportID = GenID()
                dtRow = dtImportList.NewRow
                dtRow("ImportDate") = ImportDate
                dtRow("ImportID") = ImportID
                dtRow("BillNo") = txtBillNo.Text
                dtRow("SupplierName") = sluSupplier.Text
                dtRow("SupplierID") = sluSupplier.EditValue
                dtRow("UserStock_ID") = User.UserID
                dtRow("UserStock_Name") = User.UserName
                dtRow("Notation") = txtImportNote.Text
                dtImportList.Rows.Add(dtRow)

                For Each col As GridColumn In gvImportOrder.Columns
                    col.OptionsColumn.AllowEdit = If(col.FieldName = "Notation", True, False)
                Next
                sluMat.Properties.View.Columns("MatName").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            Case BtnEdit.Name
                If gvImportOrder.RowCount <= 0 OrElse gvImportOrder.RowCount <= 0 Then
                    MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                pnlEdit.Location = New Point(108, 182)
                BtnDelete.ImageOptions.Image = My.Resources.undo_16x16
                editFunc()
                Return
            Case BtnDelete.Name
                pnlEdit.Location = New Point(107, 219)
                BtnDelete.ImageOptions.Image = My.Resources.delete_16x16
                Dim tagID As String = String.Empty
                For i As Integer = 0 To gvImportOrder.RowCount - 1
                    If i >= 1 Then tagID += ","
                    tagID += String.Format("{0}" & gvImportOrder.GetRowCellValue(i, "TagID") & "{0}", "'")
                Next
                SQL = "SELECT TagID FROM tbRequisition
                       WHERE TagID IN (" & tagID & ")"
                dsTbl("chkReq")
                If DS.Tables("chkReq").Rows.Count > 0 Then
                    MessageBox.Show("ไม่สามารถลบรายการนี้ เนื่องจากมีการเบิกไปแล้ว กรุณาติดต่อผู้ดูแล", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                Else
                    btnProcess(BtnDelete)
                End If
        End Select
    End Sub
    Function chkUse()
        Dim tagVal As String = gvImportOrder.GetFocusedRowCellValue("TagID")

        If tagVal IsNot Nothing OrElse Not String.IsNullOrEmpty(tagVal) Then
            SQL = "SELECT TagID From Logs_Requisition"
            SQL &= " WHERE TagID='" & tagVal & "'"
            dsTbl("find")
            If DS.Tables("find").Rows.Count >= 1 Then
                MessageBox.Show("ไม่สามารถแก้ไขรายการนี้ได้ เนื่องจากมีการนำไปใช้งานแล้ว", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim findPono As Func(Of String, Boolean) = Function(Pono As String)
                                                       SQL = "SELECT PoNo FROM tbPo"
                                                       SQL &= " WHERE PoNo ='" & Pono & "'"
                                                       dsTbl("find")
                                                       If DS.Tables("find").Rows.Count > 0 Then Return True
                                                       If User.Permission >= UserInfo.UserGroup.Manger AndAlso MessageBox.Show("เลขที่ Po นี้ยังไม่เคยเปิดการสั่งซื้อ ยืนยันการเพิ่มหรือไม่ ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                                           Return True
                                                       End If
                                                       Return False
                                                   End Function
        If findPono(txtPoNo.Text) = False Then Return

        Dim matVal As String = gvImportOrder.GetFocusedRowCellValue("MatID")
        MatID = SlClick(sluMat, "MatID")
        If MatID = matVal AndAlso chkUse() = False Then Exit Sub
        If ChkInput(grpMatImport) = False Then Exit Sub
        If Button_Edit.State = Buttons.EState.TurnOn Then
            FoundRow = DS.Tables("ImportOrder").Select("ImportID='" & ImportID & "' AND TagID Like '%" & txtTagID.Text & "'")
            If FoundRow.Count > 0 Then
                GoTo Edit
            End If
        End If

        If chkDuplicate(Trim(User.SelectLoc.Substring(5, 1) & txtTagID.Text), "ImportOrder", "MatID LIKE '" & MatID.Substring(0, 4) & "%' AND TagID Like '%") = False Then
            MessageBox.Show("TagID. นี้เคยลงในระบบแล้ว ไม่สามารถเพิ่มซ้ำได้", "TagID. ซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        ElseIf Trim(txtTagID.TextLength <> lblLastTag.Text.Length) Then
            MessageBox.Show("รูปแบบ TagID ไม่ถูกต้อง", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
Edit:
        'chk Input 0
        With ImReq
            .Unit1 = txtUnit1.Value
            .Unit3 = txtUnit3.Value
            .Ratio = Ratio
            .GroupTag = SlClick(sluSubCat, "GroupTag")
            If .Result = True Then AddRow()
        End With

        txtUnit1.Value = 0
        txtUnit3.Value = 0
        gvImportList.BestFitColumns()
        gvImportOrder.BestFitColumns()
        'New Order
        'TagID += 1
        If gvImportOrder.RowCount > 0 Then gvImportOrder.BestFitColumns() : gvImportOrder.Columns("Notation").Width *= 2
    End Sub
    Private Sub AddRow()
        'For Check Duplicat Order
        Dim findValue As Integer = 0
        For rw As Integer = 0 To gvImportOrder.RowCount - 1
            Dim gvValues As String = gvImportOrder.GetRowCellValue(rw, "MatID")
            If MatID = gvValues Then findValue = +1
            If findValue >= 1 Then Exit For
        Next

        Dim Unit1_ID As String = ""
        Dim ImportOrID As String = GenID()
        Dim TagID As String = Nothing
        Dim dr As DataRow
        If findValue <= 0 Then
            With dtImportOrder
                'chkTagID
                If String.IsNullOrWhiteSpace(txtTagID.Text) Then
                    MessageBox.Show("กรุณาพิมพ์ TagID.", "กำหนด TagID.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                TagID &= Trim(txtTagID.Text)
                If TagID.Length <= 4 Then
                    MsgBox("TagID ไม่ถูกต้อง")
                    txtTagID.Focus()
                    Exit Sub
                End If
                If TagID.Substring(0, 4) <> lblLastTag.Text.Substring(0, 4) Then
                    MessageBox.Show("TagID. ไม่ถูกกรุณาตรวจสอบ", "TagID. ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If
                For rw As Integer = 0 To gvImportOrder.RowCount - 1
                    Dim item As String = gvImportOrder.GetRowCellValue(rw, "TagID")
                    If item.Contains(TagID) Then
                        MessageBox.Show("TagID. นี้อยู่ในรายการแล้ว ไม่สามารถเพิ่มซ้ำได้", "TagID. ซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Exit Sub
                    End If
                Next
                '--end chk
                TagID = SlClick(sluMat, "TagID") + User.SelectLoc.Substring(5, 1) + Trim(txtTagID.Text)
                dr = .NewRow
                dr("ImportOrID") = ImportOrID
                dr("MatName") = sluMat.Text
                dr("unit1_sum") = ImReq.Unit1
                dr("unit1_Name") = luUnit1_name.Text
                dr("unit3_Sum") = ImReq.Unit3
                dr("unit3_Name") = lblUnit3_name.Text
                dr("Unit1_ID") = luUnit1_name.EditValue
                Unit1_ID = dr("Unit1_ID")
                dr("ImportID") = ImportID
                dr("MatID") = MatID
                dr("TagID") = TagID
                dr("Ratio") = ImReq.Ratio
                dr("QtyPerUnit") = QtyPerUnit
                dr("LocID") = User.SelectLoc
                dr("PoNo") = txtPoNo.Text
                .Rows.Add(dr)
                .AcceptChanges()
                gcImportOrder.Refresh()
            End With
        Else
            'get UnitID if has row
            'SumRow
            FoundRow = dtImportOrder.Select("MatID='" & MatID & "'")

            For rw As Integer = 0 To dtImportOrder.Rows.Count - 1
                If dtImportOrder.Rows(rw)("MatID") = MatID Then
                    dtImportOrder.Rows(rw)("Unit1_Sum") += ImReq.Unit1
                    dtImportOrder.Rows(rw)("Unit3_Sum") += ImReq.Unit3
                End If
            Next
            dtImportOrder.AcceptChanges()
            gcImportOrder.Refresh()
        End If
        txtTagID.Text = FindMissTag(gvImportOrder, Trim(txtTagID.Text))

    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs)
        If chkUse() = False Then Exit Sub
        If gvSelect Is Nothing Then
            MsgBox("กรุณาเลือกแถวข้อมูลก่อน")
            Exit Sub
        End If
        If gvSelect.FocusedRowHandle >= 0 Then
            Dim values As String = gvSelect.GetRowCellValue(gvImportOrder.FocusedRowHandle, "MatID")


            Select Case gvSelect.Name
                Case gvImportOrder.Name
                    dtImportOrder.Rows(gvImportOrder.FocusedRowHandle).Delete()
            End Select
            dtImportOrder.AcceptChanges()
            gcImportOrder.Refresh()
        End If
        gvSelect = Nothing
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If gvImportOrder.RowCount < 1 Then Return
        If MessageBox.Show("ยืนยันการบันทึก หากบันทึกแล้วจะไม่สามารถแก้ไขได้" & vbCrLf _
                           & "ต้องติดต่อผู้ดูแลเท่านั้น โปรดตรวจสอบความถูกต้อง", "บันทึกยอดเข้าคลัง", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            btnProcess(BtnSave)
            Transfer()
            BtnCancel.PerformClick()
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        cancelFunc()
    End Sub
    Private Sub BtnStore_Add_Click(sender As Object, e As EventArgs)
        FmgUnit.ShowDialog()
        FmgUnit.Dispose()
        FirstQry(QryMode.MainUnit)
        FirstQry(QryMode.SubUnit)
        LoadLookUnit()
    End Sub
#End Region

#Region "Other Control."
    Private Sub FrmMatImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstQry(QryMode.All)
        gcImportList.DataSource = search("ImportList", "ImportDate='" & Today & "'", "")
        gcImportOrder.DataSource = DS.Tables("ImportOrder")
        dtImportOrder = DS.Tables("ImportOrder").Copy
        gvFormat()
        gcImportOrder.DataSource = Nothing

        LoadLookUp()
        luUnit1_name.Properties.DataSource = Nothing
        luUnit1_name.Properties.NullText = " "
        grpMatImport.Enabled = False
        deImport.EditValue = ImportDate
        BtnDelete.Enabled = True
        'Permission(User.Permis)
        Dim ColDel As New ColumnButton.Editor With {.Caption = " ", .Image = My.Resources.remove_16x16, .ToolTip = "ลบรายการนี้", .Field = "del"}
        Dim CreateCol As New ColumnButton.Main With {.gControl = gcImportOrder, .gView = gvImportOrder}
        CreateCol.Add(ColDel)
        sluSubCat.EditValue = Nothing
        sluMat.EditValue = Nothing
        sluSupplier.EditValue = Nothing
        luUnit1_name.EditValue = Nothing
        LoadSuccess = True
    End Sub
    Private Sub deImport_EditValueChanged(sender As Object, e As EventArgs) Handles deImport.EditValueChanged
        If LoadSuccess = False OrElse Button_Edit.State = Buttons.EState.TurnOn Then Exit Sub
        ImportDate = deImport.EditValue
        gcImportList.DataSource = search("ImportList", "ImportDate='" & ImportDate & "'", "")
        If gvImportList.RowCount > 0 Then gvImportList.BestFitColumns()
        gcImportOrder.DataSource = Nothing
    End Sub
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs) Handles gvImportList.RowCellClick, gvImportOrder.RowCellClick
        Dim gv As GridView = CType(sender, GridView)
        RowClickFunc(gv)
        If e.Column.FieldName = "Notation" Then CType(sender, GridView).ShowEditor()
    End Sub
    Private Sub txtKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTagID.KeyPress, txtBillNo.KeyPress, txtPoNo.KeyPress
        If e.KeyChar = "-" Then Return
        Dim ctrName As String = CType(sender, TextBox).Name

        If e.KeyChar = "/" Then
            If ctrName = txtBillNo.Name Then
                numOnly(e)
                Dim ReqNo As New GenRequestNo With {
                        .SetDate = If(LoadSuccess = False, Nothing, deImport.EditValue),
                        .SetTable = "tbImportList",
                        .SetField = "BillNo"}
                CType(sender, TextBox).Text = ReqNo.Gen
            ElseIf ctrName = txtTagID.Name Then
                numOnly(e)
                txtTagID.Text = CInt(lblLastTag.Text) + 1
            End If
        Else
            numOnly(e)
        End If

    End Sub
    Private Sub txtBillNo_TextChanged(sender As Object, e As EventArgs) Handles txtBillNo.TextChanged
        If Button_Edit.State = Buttons.EState.TurnOn Then Return

        gcImportList.DataSource = If(String.IsNullOrWhiteSpace(txtBillNo.Text),
                                     search("ImportList", "ImportDate='" & ImportDate & "'", ""),
                                     search("ImportList", "BillNo='" & txtBillNo.Text & "'", ""))
    End Sub
#End Region

    Private Sub txtUnit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnit1.EditValueChanged, txtUnit3.EditValueChanged
        Dim spiCtr As SpinEdit = CType(sender, SpinEdit)
        If spiCtr.Value < 0 Then spiCtr.Value = 0
        'If spiCtr.Name = txtUnit3.Name Then
        '    If spiCtr.Value >= Ratio Then spiCtr.Value = Ratio - 1
        'End If
    End Sub
    Private Sub luSubCat_EditValueChanged(sender As Object, e As EventArgs) Handles sluSubCat.EditValueChanged
        If LoadSuccess = False Then Exit Sub

        SQL = "SELECT SC.SubCatName, M.MatName, M.MatID, M.CatID, M.SubCatID,"
        SQL &= " M.ItemDetail, SC.TagID, SC.Unit3_ID, M.Ratio, M.QtyPerUnit,"
        SQL &= " SM.ProductName"
        SQL &= " FROM tbMat AS M INNER JOIN tbSubCategory AS SC ON M.CatID = SC.CatID AND M.SubCatID = SC.SubCatID"
        SQL &= " LEFT OUTER JOIN CombineSubMatName() SM ON M.MatID = SM.matID"
        SQL &= " WHERE M.CatID+M.SubCatID = '" & sluSubCat.EditValue & "' AND M.Stat <> 0"
        With sluMat.Properties
            Dim enableCol As String() = {"MatName", "SubCatName", "ProductName"}
            .ValueMember = "MatID"
            .DisplayMember = "MatName"
            .DataSource = dsTbl("sluMat")
            .PopulateViewColumns()
            .View.Columns("SubCatName").Caption = "ประเภทวัสดุ"
            .View.Columns("MatName").Caption = "ชื่อวัสดุ"
            .View.Columns("ProductName").Caption = "เบอร์ร่วม"

            'Hide SluMat Columns
            For Each col As GridColumn In sluMat.Properties.View.Columns
                If enableCol.Contains(col.FieldName) Then
                    col.Visible = True
                Else
                    col.Visible = False
                End If
            Next

        End With
    End Sub
End Class

Public Class Buttons
    Enum EState
        TurnOn
        TurnOff
    End Enum
    Private _State As Integer = EState.TurnOff
    Property State As EState
        Set(value As EState)
            _State = value
        End Set
        Get
            Return _State.ToString
        End Get
    End Property

End Class
