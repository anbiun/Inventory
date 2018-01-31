﻿Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data

Public Class FmgSubMat
    Dim dtSubMat As DataTable
    Dim SubMatID As String = "", SubCatID As String = "", MatID As String = Nothing
    Enum Stat
        OK
        Edit
        Delete
        AddList
        DelList
    End Enum
    Private btnStat As Integer

#Region "CODE"
    Private Sub CompareDT(ByVal DTMain As DataTable, ByVal DTSub As DataTable)
        Dim r1 = DTMain.AsEnumerable()
        Dim r2 = DTSub.AsEnumerable()
        Dim ExceptResult = r1.Except(r2, DataRowComparer.Default)

        If ExceptResult.Count > 0 AndAlso DTSub.Rows.Count > 0 Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub
    Private Enum QryMode
        SubCat
        slMat
        matList
    End Enum
    Private Sub showDB(Optional Mode As QryMode = QryMode.SubCat)
        If Mode = QryMode.slMat Then GoTo slMat
        SQL = "select ProductID, ProductName from tbProduct"
        BindInfo.Name = "product"
        BindInfo.Qry(SQL)
        With slProduct.Properties
            .DataSource = BindInfo.Result
            .ValueMember = "ProductID"
            .DisplayMember = "ProductName"
            .PopulateViewColumns()
            .View.Columns("ProductID").Visible = False
            .View.Columns("ProductName").Caption = getString("ProductName")
        End With

        SQL = "select CatID+SubCatID IDValue, SubCatName From tbSubCategory"
        BindInfo.Name = "subcat"
        BindInfo.Qry(SQL)

        With slSubCat.Properties
            .DataSource = BindInfo.Result
            .ValueMember = "IDValue"
            .DisplayMember = "SubCatName"
            .PopulateViewColumns()
            .View.Columns("IDValue").Visible = False
            .View.Columns("SubCatName").Caption = getString("subcatname")
        End With
        If Mode = QryMode.SubCat Then Exit Sub
slMat:
        SQL = "select MatID,MatName from tbMat Where CatID+SubCatID = '" & SubCatID & "'"
        With slMat.Properties
            .DataSource = dsTbl("mat")
            .DisplayMember = "MatName"
            .ValueMember = "MatID"
            .PopulateViewColumns()
            .View.Columns("MatID").Visible = False
            .View.Columns("MatName").Caption = getString("MatName")
        End With
        slMat.EditValue = Nothing

        SQL = "Select Mat.MatID, Mat.MatName,SubMat.SubMatID,PD.ProductName,PD.QCTarget,PD.ProductID
                From tbSubMat SubMat 
                inner Join tbMat Mat on SubMat.MatID = Mat.matID  
                inner Join tbProduct PD ON PD.ProductID = SubMat.ProductID
                where Mat.CatID + Mat.SubCatID = '" & SubCatID & "'"
        BindInfo.Name = "submat"
        BindInfo.Qry(SQL)
        With gvList
            gcList.DataSource = BindInfo.Result
            .PopulateColumns()
            .Columns("MatName").Group()
            .Columns("MatName").Caption = getString("MatName")
            .Columns("ProductName").Caption = getString("ProductName")
            .Columns("QCTarget").Caption = getString("qctarget")
            .Columns("MatID").Visible = False
            .Columns("SubMatID").Caption = " "
            .Columns("SubMatID").Width = 70
            .Columns("ProductID").Visible = False
            .ExpandAllGroups()
        End With

    End Sub
    Private Sub LoadDef()
        GrpInput.Enabled = False
        GrpBtn.Enabled = True
        gvList.OptionsFind.AlwaysVisible = True
        gcList.Enabled = True
        btnSave.Enabled = False
        btnRemove.Enabled = If(slMat.EditValue = Nothing, False, True)
        btnNew.Enabled = If(slMat.EditValue = Nothing, False, True)
    End Sub
#End Region
#Region "Button Control"
    Private Sub AddList(sender As Object, e As EventArgs) Handles btnAddList.Click
        Dim dr As DataRow = Nothing
        Dim dupField As String

        With dtSubMat
            'chekDuplicate In DT
            FoundRow = dtSubMat.Select("ProductName = '" & slProduct.Text & "'")
            If FoundRow.Count > 0 Then
                MessageBox.Show(slProduct.Text & " มีในฐานข้อมูลแล้วไม่สามารถเพิ่มได้อีก", "ซ้ำในฐานข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            'chekInput
            If String.IsNullOrWhiteSpace(slProduct.EditValue) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            dr = .NewRow
            dr("MatID") = slMat.EditValue
            dr("MatName") = slMat.Text
            dr("SubMatID") = genID()
            dr("ProductName") = slProduct.Text
            dr("ProductID") = slProduct.EditValue
            dupField = "ProductName"

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
    Private Sub DelList(sender As Object, e As EventArgs) Handles btnDelList.Click
        If gvList.FocusedRowHandle >= 0 Then
            dtSubMat.Rows(gvList.FocusedRowHandle).Delete()
            dtSubMat.AcceptChanges()
            gcList.Refresh()
            CompareDT(BindInfo.Result.DataSource, dtSubMat)
            'btnSave.Enabled = If(TBChange(DS.Tables("submat")) = True, True, False)
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        gvList.FindFilterText = Nothing
        GrpInput.Enabled = True
        GrpBtn.Enabled = False
        gvList.Columns("QCTarget").Visible = False

        BindInfo.Name = "submat"
        FoundRow = BindInfo.Result.DataSource.Select("MatID='" & slMat.EditValue & "'")

        If FoundRow.Count > 0 Then
            dtSubMat = FoundRow.CopyToDataTable
        Else
            dtSubMat = BindInfo.Result.DataSource
            dtSubMat.Clear()
        End If
        gcList.DataSource = dtSubMat
        gvList.OptionsFind.AlwaysVisible = False
        gvList.Columns("MatID").Visible = False
        gvList.Columns("SubMatID").Visible = False
        gvList.Columns("MatName").Group()
        gvList.ExpandAllGroups()
    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        showDB(QryMode.slMat)
        LoadDef()
        gvList.FindFilterText = Nothing
        slMat.EditValue = Nothing
    End Sub
    Private Sub btnUnit_Remove_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("ยืนยันการลบข้อมูล " & gvList.GetFocusedValue & " หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            'clearDS
            clsDS({"chkuse", "del"})
            'chkUse
            SQL = "Delete From tbSubMat Where MatID='" & MatID & "' Delete From tbGroupUnit Where mainUnitID='" & SubMatID & "'"
            dsTbl("del")
            LoadDef()
            showDB(QryMode.slMat)
            gvList.FindFilterText = Nothing
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tbDest As String = Nothing
        Dim fieldList() As String = Nothing

        SQL = "Delete From tbSubMat Where MatID='" & slMat.EditValue & "'"
        dsTbl("del")
        fieldList = {"MatID", "ProductID", "SubMatID"}
        tbDest = "tbSubMat"
        blkCpy(tbDest, dtSubMat, fieldList)
        'Edit
        btnCancle.PerformClick()
        MessageBox.Show("บันทึกข้อมูลแล้ว", "บันทึกข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If BindInfo.Find("stock") = True Then
            BindInfo.Name = "stock"
            BindInfo.Excute()
            BindInfo.Result()
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MessageBox.Show("ยืนยันการลบข้อมูลเบอร์ร่วม " & slMat.Text, "ยืนยันการทำงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            SQL = "DELETE From tbSubMat WHERE MatID='" & MatID & "'"
            dsTbl("del")
            showDB(QryMode.slMat)
            LoadDef()
            gvList.FindFilterText = Nothing
            slMat.EditValue = Nothing
        End If
    End Sub
#End Region
#Region "Common Control"
    Private Sub FmgSubMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DS IsNot Nothing Then DS.Clear()
        'FirstQry()
        'showDB()
        showDB()
        LoadDef()
        gvList.FindFilterText = Nothing
        loadSuccess = True
    End Sub
    Private Sub gvRowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        If gvList.FocusedRowHandle >= 0 Then
            Dim MatID = gvList.GetRowCellValue(gvList.FocusedRowHandle, "MatID")
            SubMatID = gvList.GetRowCellValue(gvList.FocusedRowHandle, "SubMatID")
            slProduct.EditValue = gvList.GetRowCellValue(gvList.FocusedRowHandle, "ProductID")
            slMat.EditValue = MatID
        End If
    End Sub
    Private Sub gvRowClick(sender As Object, e As RowClickEventArgs) Handles gvList.RowClick
        MatID = getGroupValue(gvList, gcList, "MatName", "MatID")
        If String.IsNullOrWhiteSpace(MatID) Then Exit Sub
        slMat.EditValue = MatID

        'If IsDBNull(gvList.FocusedValue) Then Exit Sub
        'Dim values As String = gvList.GetFocusedValue
        'Dim vw As ColumnView = gcList.MainView
        ''dim values as string = gvlist.getrowcelldisplaytext(gvlist.focusedrowhandle, "mainname")
        'Dim fieldname As String = "matname"
        'Dim fieldid As String = "matid"

        'Try
        '    Dim rhandle As Integer = 0
        '    Dim col As DevExpress.XtraGrid.Columns.GridColumn = vw.Columns(fieldname)
        '    While True
        '        rhandle = vw.LocateByValue(rhandle, col, values)
        '        If rhandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
        '            Exit While
        '        End If
        '        If gvList.GetRowCellValue(rhandle, fieldname) = values Then
        '            slMat.EditValue = gvList.GetRowCellValue(rhandle, fieldid)
        '            MatID = gvList.GetRowCellValue(rhandle, fieldid)
        '            Exit While
        '        End If
        '        rhandle += 1
        '    End While
        'Catch ex As Exception
        'End Try

    End Sub
    Private Sub txtName_EditValueChanged(sender As Object, e As EventArgs)
        btnDelList.Enabled = False
    End Sub
#End Region
    Private Sub GridView_CustomColumnDisplayText(ByVal sender As Object,
    ByVal e As CustomColumnDisplayTextEventArgs) Handles gvList.CustomColumnDisplayText
        If e.Column.FieldName = "SubMatID" Then
            If e.Value IsNot Nothing Then e.DisplayText = " "
        End If
    End Sub
    Private Sub SearchLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles slSubCat.EditValueChanged, slMat.EditValueChanged
        If loadSuccess = False Then Exit Sub
        Dim ctrSl As DevExpress.XtraEditors.SearchLookUpEdit = CType(sender, DevExpress.XtraEditors.SearchLookUpEdit)
        If ctrSl.Name = slSubCat.Name Then
            SubCatID = slSubCat.EditValue
            showDB(QryMode.slMat)
        Else
            MatID = ctrSl.EditValue
        End If
        If MatID = Nothing Or gvList.RowCount <= 0 Then
            btnRemove.Enabled = False
        Else
            For i As Integer = 0 To gvList.RowCount - 1
                Dim tmpMat As String
                tmpMat = gvList.GetRowCellValue(i, "MatID")
                If tmpMat = MatID Then
                    btnRemove.Enabled = True
                    Exit For
                End If
                btnRemove.Enabled = False
            Next
        End If

        btnNew.Enabled = If(slMat.EditValue = Nothing, False, True)
        'btnNew.Enabled = If(String.IsNullOrEmpty(slMat.Text) Or
        'String.IsNullOrEmpty(slSubCat.Text), False, True)
    End Sub
End Class