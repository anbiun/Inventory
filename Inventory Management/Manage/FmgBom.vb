Imports ConDB.Main
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Text
Public Class FmgBom
    Dim Qty As Integer
    Dim bomID, bomName, MatID, MatName, bomDeID As String
    Dim tblNewBom As DataTable
    Dim Mode As String
#Region "CODE"
    Private Sub showDB()
        SQL = "select bomID,bomDeID,bomName,MatID,MatName,Qty from vwBomReq"
        gcBomList.DataSource = dsTbl("vwBomReq")
        With gvBomList
            .PopulateColumns()
            .Columns("bomName").Group()
            .Columns("bomID").Visible = False
            .Columns("bomDeID").Visible = False
            .Columns("bomName").Caption = "ชื่อ BOM."
            .Columns("MatID").Caption = "รหัสวัสดุ"
            .Columns("MatName").Caption = "ชื่อวัสดุ"
            .Columns("Qty").Caption = "จำนวน"
        End With

        With sluBom.Properties
            SQL = "select * from tbBom"
            .DataSource = dsTbl("tbbom")
            .DisplayMember = "bomName"
            .ValueMember = "bomID"
            .PopulateViewColumns()
            .NullText = ""
            .View.Columns("bomID").Caption = "รหัส BOM."
            .View.Columns("bomName").Caption = "ชื่อ BOM."
        End With

        With sluMat.Properties
            SQL = "select MatID,MatName,locName,storeName from vwMat"
            .DataSource = dsTbl("vwMat")
            .DisplayMember = "MatName"
            .ValueMember = "MatID"
            .PopulateViewColumns()
            .NullText = ""
            .View.Columns("MatID").Caption = "รหัสวัสดุ"
            .View.Columns("MatName").Caption = "ชื่อวัสดุ"
            .View.Columns("locName").Caption = "สถานที่"
            .View.Columns("storeName").Caption = "ที่เก็บ"
        End With
    End Sub
    Private Function findValInGrid(values As String, colname As String) As Boolean
        Dim View As DevExpress.XtraGrid.Views.Base.ColumnView = gcBomList.MainView
        View.BeginUpdate()
        Try
            Dim RowHandle As Integer = 0
            Dim Col As DevExpress.XtraGrid.Columns.GridColumn = View.Columns(colname)
            While (True)
                ' Locate the next row 
                RowHandle = View.LocateByValue(RowHandle, Col, values)
                ' Exit the loop if no row is found 
                If RowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    Exit While
                End If
                ' Perform specific operations on the found row 
                ' ... 
                If gvBomList.GetRowCellValue(RowHandle, colname) = values Then
                    bomID = gvBomList.GetRowCellValue(RowHandle, "bomID")
                    bomName = values
                    Return True
                    Exit While
                End If
                RowHandle += 1
            End While
        Finally
            View.EndUpdate()
        End Try
    End Function
    Private Sub GridClick()
        If gvBomList.FocusedRowHandle >= 0 Then
            Dim Rw As Integer = gvBomList.FocusedRowHandle
            With gvBomList
                bomID = .GetRowCellValue(Rw, "bomID")
                MatID = .GetRowCellValue(Rw, "MatID")
                Qty = .GetRowCellValue(Rw, "Qty")
                bomName = .GetRowCellValue(Rw, "bomName")
                bomDeID = .GetRowCellValue(Rw, "bomDeID")
            End With
            sluBom.EditValue = bomID
            sluMat.EditValue = MatID
            txtQty.Text = Qty
            txtBomName.Text = bomName
            Me.Text = bomDeID
        Else
            If findValInGrid(gvBomList.GetFocusedValue, "bomName") = True Then
                txtBomID.Text = bomID
                txtBomName.Text = bomName
                sluBom.EditValue = bomID
            End If
        End If
    End Sub

    Private Sub saveProcess()
        MsgBox("EDIT HERE")
        Exit Sub
        Select Case Mode
            Case "add"
                bomID = txtBomID.Text
                bomName = txtBomName.Text
                SQL = "insert into tbBom(bomID,bomName) values('" & bomID & "','" & bomName & "')"
                dsTbl("insert")
            Case "edit"
                createTbl()
                SQL = "delete from tbBomDetail where bomID='" & bomID & "'"
                dsTbl("del")
        End Select


        Using bulkCopy = New SqlBulkCopy(CStr(CONN.ConnectionString) & "Password=1234;", SqlBulkCopyOptions.KeepIdentity)

            bulkCopy.ColumnMappings.Add("bomDeID", "bomDeID")
            bulkCopy.ColumnMappings.Add("bomID", "bomID")
            bulkCopy.ColumnMappings.Add("MatID", "MatID")
            bulkCopy.ColumnMappings.Add("Qty", "Qty")

            bulkCopy.BulkCopyTimeout = 600
            bulkCopy.DestinationTableName = "tbBomDetail"
            bulkCopy.WriteToServer(tblNewBom)
        End Using

    End Sub
    Private Function createTbl()
        tblNewBom = New DataTable
        With tblNewBom
            .Columns.Add("bomID", GetType(String))
            .Columns.Add("bomName", GetType(String))
            .Columns.Add("MatID", GetType(String))
            .Columns.Add("MatName", GetType(String))
            .Columns.Add("Qty", GetType(String))
            .Columns.Add("bomDeID", GetType(String))
        End With

        gvBomList.ClearGrouping()
        ' Add five rows with those columns filled in the DataTable.
        For i As Integer = 0 To gvBomList.RowCount - 1
            Dim bomid, bomname, MatID, MatName, qty As String
            bomid = gvBomList.GetRowCellValue(i, "bomID")
            bomname = gvBomList.GetRowCellValue(i, "bomName")
            MatID = gvBomList.GetRowCellValue(i, "MatID")
            MatName = gvBomList.GetRowCellValue(i, "MatName")
            qty = gvBomList.GetRowCellValue(i, "Qty")
            bomDeID = gvBomList.GetRowCellValue(i, "bomDeID")

            tblNewBom.Rows.Add(bomid, bomname, MatID, MatName, qty, bomDeID)
        Next i
        gvBomList.Columns("bomName").Group()
        Return tblNewBom
    End Function
#End Region
#Region "COMP."
    Private Sub frmBomManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartCon()
        showDB()
        txtBomID.Text = genID()
        txtBomID.Enabled = False
        grpMat.Visible = False
        grpSave.Visible = False
        grpBtn.Visible = False
        loadSuccess = True

        tblNewBom = New DataTable
        With tblNewBom
            .Columns.Add("bomID", GetType(String))
            .Columns.Add("bomName", GetType(String))
            .Columns.Add("MatID", GetType(String))
            .Columns.Add("MatName", GetType(String))
            .Columns.Add("Qty", GetType(String))
            .Columns.Add("bomDeID", GetType(String))
        End With

    End Sub
    Private Sub gcBomList_Click(sender As Object, e As EventArgs) Handles gcBomList.Click
        If Mode = "add" Then Exit Sub
        GridClick()
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        grpBtn.Visible = True
    End Sub
    Private Sub cbBom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sluBom.EditValueChanged
        If loadSuccess = False Then Exit Sub
        txtBomID.Text = sluBom.EditValue
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case Mode
            Case "add"
                saveProcess()
            Case "edit"
                gvBomList.ExpandAllGroups()
                If gvBomList.RowCount <= 1 Then
                    MsgBox("บันทึกรายการไม่ได้ กรุณาเพิ่มวัสดุ")
                    Exit Sub
                Else
                    saveProcess()
                End If
        End Select
        btnCancel.PerformClick()
        showDB()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showDB()
        grpBomName.Enabled = True
        grpAdd.Visible = True
        grpMat.Visible = False
        grpSave.Visible = False
        btnNew.Enabled = False
        Mode = ""
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If findValInGrid(sluMat.EditValue, "MatID") = True Then
            MsgBox("ไม่สามารถเลือกวัสดุเดิมได้" & vbCrLf & "หากต้องการแก้ไขจำนวน กรุณาลบวัสดุแล้วเพิ่มใหม่")
            Exit Sub
        End If
        bomDeID = genID()
        Dim rw As DataRow
        rw = tblNewBom.NewRow
        rw("bomID") = txtBomID.Text
        rw("bomName") = txtBomName.Text
        rw("MatID") = sluMat.EditValue
        rw("MatName") = sluMat.Text
        rw("Qty") = txtQty.Text
        rw("bomDeID") = bomDeID
        tblNewBom.Rows.Add(rw)
        tblNewBom.AcceptChanges()

        'tblNewBom.Rows.Add(txtBomID.Text, txtBomName.Text, sluMat.EditValue, sluMat.Text, txtQty.Text, bomDeID)
        gcBomList.Refresh()
        'gcBomList.DataSource = tblNewBom
        gvBomList.ExpandAllGroups()
    End Sub
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'gvBomList.DeleteRow(gvBomList.FocusedRowHandle)
        'tblNewBom.Rows.RemoveAt(gvBomList.FocusedRowHandle - 1)
        tblNewBom.Rows(gvBomList.FocusedRowHandle).Delete()
        gcBomList.Refresh()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Mode = "add"
        tblNewBom.Rows.Clear()
        gcBomList.DataSource = tblNewBom
        grpMat.Visible = True
        txtBomID.Text = genID()
        grpBomName.Enabled = False
        grpSave.Visible = True
        grpAdd.Visible = False

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        grpBomName.Enabled = False
        grpSave.Visible = True
        grpAdd.Visible = False

        Mode = "edit"
        SQL = "select * from vwBomReq where bomID='" & bomID & "'"
        gcBomList.DataSource = dsTbl("edit")
        grpMat.Visible = True
        gvBomList.FocusedRowHandle = 0
        'txtBomID.Text = genID("bomID", "tbBom")
        grpBomName.Enabled = False
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("ยืนยันการลบ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SQL = "delete from tbBom where bomID='" & bomID & "' " _
                        & "delete from tbBomDetail where bomID='" & bomID & "'"
            dsTbl("delete")
            showDB()
            btnDelete.Enabled = False
            btnEdit.Enabled = False
            txtBomName.Text = ""
        End If

    End Sub
    Private Sub txtBomName_DoubleClick(sender As Object, e As EventArgs) Handles txtBomName.DoubleClick
        txtBomName.SelectAll()
    End Sub
    Private Sub txtBomName_TextChanged(sender As Object, e As EventArgs) Handles txtBomName.TextChanged
        If String.IsNullOrEmpty(txtBomName.Text) Then
            btnNew.Enabled = False
            grpBtn.Visible = False
        Else
            If findValInGrid(txtBomName.Text, "bomName") = True Then
                btnNew.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = True
            Else
                grpBtn.Visible = True
                btnNew.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                txtBomID.Text = genID()
            End If
        End If
    End Sub
#End Region
End Class