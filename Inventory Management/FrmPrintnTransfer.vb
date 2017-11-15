Imports ConDB.Main
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Public Class FrmPrintnTransfer
    Dim BillNo As String
    Dim ImportID As String
    Friend dtSelect As DataTable
    Dim dr As DataRow
    Dim _Find As FindMode = FindMode._Date
    
    Enum FindMode
        _BillNo
        _Date
    End Enum
#Region "Function"
    Private Sub FrmPrintnTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstQry()
        Dim thisMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        Dim firstDayLastMonth As DateTime
        Dim lastDayLastMonth As DateTime

        firstDayLastMonth = thisMonth.AddMonths(-1)
        lastDayLastMonth = thisMonth.AddDays(-1)

      
        sDate.EditValue = firstDayLastMonth
        eDate.EditValue = Today
        btnTransfer.Enabled = False
        RadioButton2.Enabled = False
        btnPrint.Visible = False
        loadSuccess = True
    End Sub
    Private Sub FirstQry()
        clsDS({"ImportList4Print", "ImportOrder4Print"})

        SQL = "select *"
        SQL &= " FROM vwImportList"
        dsTbl("ImportList4Print")

        SQL = "SELECT  vwImportList.ImportDate, vwImportList.BillNo, vwImportOrder.MatName, vwImportOrder.Unit1_Sum, vwImportOrder.Unit1_Name, vwImportOrder.Unit3_Sum, vwImportOrder.Unit3_Name, vwImportOrder.MatID, vwImportOrder.ImportOrID, vwImportOrder.Unit1_ID,"
        SQL &= " vwImportOrder.ImportID, vwImportOrder.TagID, vwImportList.TransferStat"
        SQL &= " FROM vwImportList INNER JOIN"
        SQL &= " vwImportOrder ON vwImportList.ImportID = vwImportOrder.ImportID"
        dsTbl("ImportOrder4Print")
    End Sub

#End Region
#Region "GridStyle"
    Private Sub gvFomat(Optional tbname As String = "ImportList4Print", Optional GridName As String = "gvList")
        Dim gvName As GridView
        gvName = If(GridName = gvList.Name, gvList, gvSelect)
        With gvName
            .PopulateColumns()
            Select Case tbname
                Case "ImportList4Print"
                    .Columns("ImportDate").Caption = "วันที่"
                    .Columns("BillNo").Caption = "เลขที่ใบรับของ"
                    .Columns("supplierName").Caption = "ผู้ขาย"
                    .Columns("UserStock_Name").Caption = "ผู้รับของ"
                    .Columns("UserApprove_Name").Caption = "ผู้ตรวจของ"
                    .Columns("ImportID").Visible = False
                    .Columns("supplierID").Visible = False
                    .Columns("TransferStat").Visible = False
                    .Columns("UserStock_ID").Visible = False
                    .Columns("UserApprove_ID").Visible = False
                    If XtraTabControl1.SelectedTabPageIndex <> 0 Then
                        .Columns("Approve").Visible = False
                        .Columns("TransferStat").Visible = True
                        .Columns("TransferStat").Caption = "สถานะการโอนยอด"
                    End If
                Case "ImportOrder4Print"
                    .Columns("MatID").Visible = False
                    .Columns("MatName").Caption = "วัสดุ"
                    .Columns("Unit1_Sum").Caption = "จำนวน"
                    .Columns("Unit1_Name").Caption = " "
                    .Columns("Unit3_Sum").Caption = "ปริมาณ"
                    .Columns("Unit3_Name").Caption = " "
                    .Columns("ImportOrID").Visible = False
                    .Columns("ImportID").Visible = False
                    .Columns("Unit1_ID").Visible = False
                    .Columns("TagID").Caption = "TAGID"
                    .Columns("TransferStat").Caption = "สถานะการโอนยอด"
                    .Columns("ImportDate").Caption = "วันที่"
            End Select
            .BestFitColumns()
        End With
    End Sub
    Private Sub GridView1_RowStyle(ByVal sender As Object, _
        ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle, gvSelect.RowStyle
        Dim View As GridView = sender
        View.OptionsSelection.EnableAppearanceFocusedRow = False
        Dim Values As String
        If (e.RowHandle >= 0) Then
            If XtraTabControl1.SelectedTabPageIndex = 0 Then
                Values = View.GetRowCellValue(e.RowHandle, View.Columns("Approve"))
            Else
                Values = View.GetRowCellValue(e.RowHandle, View.Columns("TransferStat"))
            End If

            Select Case Values
                Case Is = 0
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.BackColor2 = Color.IndianRed
                Case Is = 1
                    e.Appearance.BackColor = Color.LawnGreen
                    e.Appearance.BackColor2 = Color.LightGreen
                Case Is = 2
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.BackColor2 = Color.LightYellow
            End Select
        End If
    End Sub
    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, _
 ByVal e As CustomColumnDisplayTextEventArgs) Handles gvList.CustomColumnDisplayText, gvSelect.CustomColumnDisplayText
        Dim strOutput As String = Nothing
        Dim Values As String = Nothing
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If e.Column.FieldName = "Approve" Then
                Values = If(e.Value Is DBNull.Value, 0, e.Value)
                e.DisplayText = If(Values = 0, "ยังไม่ตรวจ", "โอนยอดได้")
            End If
        Else
            If e.Column.FieldName = "TransferStat" Then
                Values = If(e.Value Is DBNull.Value, 0, e.Value)
                e.DisplayText = If(Values = 0, "พิมพ์ไม่ได้ยังไม่โอนยอด", "พิมพ์ TagID. ได้")
            End If
        End If
       
    End Sub
    Private Sub RowClickFunc(gv As GridView, Optional ByVal RowNum As Integer = 0)
        Dim rw As Integer = gv.FocusedRowHandle
        If rw > 0 Then
            ImportID = gv.GetRowCellValue(rw, "ImportID")
        End If
    End Sub

#End Region
#Region "Other Control"
    Private Sub showDB(Optional ByVal _Find As FindMode = FindMode._Date)
        dtSelect = Nothing
        gvSelect.Columns.Clear()
        gcSelect.DataSource = Nothing
        Dim tbName As String = Nothing,
            FindStr As String = Nothing
        tbName = If(RadioButton1.Checked = True, "ImportList4Print", "ImportOrder4Print")
        gvList.Columns.Clear()
        Select Case _Find
            Case FindMode._Date
                FindStr = "ImportDate >= '" & sDate.EditValue & "' AND ImportDate <= '" & eDate.EditValue & "'"
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    'FindStr &= " AND TransferStat='0'"
                End If
            Case FindMode._BillNo
                FoundRow = DS.Tables(tbName).Select("BillNo LIKE '%" & BillNo & "%'")
                ImportID = If(FoundRow.Count > 0, FoundRow(0)("ImportID"), Nothing)
                FindStr = "ImportID='" & ImportID & "'"
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    'FindStr &= " AND TransferStat='0'"
                End If
        End Select
        gcList.DataSource = Search(tbName, FindStr)
        gvFomat(tbName)
    End Sub
    Private Function Search(tbname As String, findString As String, Optional sortString As String = "")
        'DV = New DataView(DS.Tables(tbname), findString, sortString, DataViewRowState.CurrentRows)
        DV = New DataView(DS.Tables(tbname), findString, sortString, DataViewRowState.CurrentRows)
        Return DV
    End Function
    Private Sub txtBillNo_EditValueChanged(sender As Object, e As EventArgs) Handles txtBillNo.EditValueChanged
        _Find = If(String.IsNullOrWhiteSpace(txtBillNo.Text), FindMode._Date, FindMode._BillNo)
        BillNo = Trim(txtBillNo.Text)
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        showDB(_Find)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnRemove.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        If btn.Name = btnAdd.Name Then
            If gvList.FocusedRowHandle < 0 Then Exit Sub
            If dtSelect Is Nothing Then
                dtSelect = DV.ToTable
                dtSelect.Rows.Clear()
                gcSelect.DataSource = dtSelect
                If RadioButton1.Checked = False Then
                    gvFomat("ImportOrder4Print", gvSelect.Name)
                Else
                    gvFomat(, gvSelect.Name)
                End If
            End If
            If chkRow() = True Then
                dtSelect.ImportRow(gvList.GetFocusedDataRow)
            End If
        Else
            If gvSelect.FocusedRowHandle < 0 Then Exit Sub
            dtSelect.Rows(gvSelect.FocusedRowHandle).Delete()
        End If
        dtSelect.AcceptChanges()
        gcSelect.Refresh()

        btnTransfer.Enabled = If(dtSelect.Rows.Count > 0, True, False)
        btnPrint.Enabled = If(dtSelect.Rows.Count > 0, True, False)
        gvSelect.BestFitColumns()
    End Sub

#End Region
    Private Function chkRow()
        'เชคตรวจแล้วหรือยัง
        If gvList.GetRowCellValue(gvList.FocusedRowHandle, "Approve") = 0 And XtraTabControl1.SelectedTabPageIndex = 0 Then
            'MessageBox.Show("ยังไม่ตรวจสอบการรับของ ไม่สามารถโอนยอดเข้าคลังได้", "กรุณาตรวจสอบข้อมูลรับของ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            'Return False
            Return True
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 And gvList.GetRowCellValue(gvList.FocusedRowHandle, "TransferStat") = 0 Then
            MessageBox.Show("ยังไม่โอนยอดเข้าคลัง ไม่สามารถพิมพ์ TagID. ได้", "กรุณาโอนยอดเข้าคลังก่อน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 And gvList.GetRowCellValue(gvList.FocusedRowHandle, "TransferStat") = 0 Then
            Return False
        Else
            FoundRow = DS.Tables("ImportList4Print").Select("Approve=0 and ImportID='" & ImportID & "'")
            If FoundRow.Count > 0 Then
                'MessageBox.Show("ไม่สามารถเพิ่มได้ เนื่องจากใบรับของนี้ยังตรวจไม่ครบทุกรายการ", "ตรวจข้อมูลไม่เรียบร้อย", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                'Return False
                Return True
            End If
        End If

        'เชคข้อมูลเลือกซ้ำกันไหม
        If dtSelect.Rows.Count > 0 Then
            For Each item As DataRow In dtSelect.Rows

                If RadioButton1.Checked = True Then
                    If gvList.GetRowCellValue(gvList.FocusedRowHandle, "ImportID") = item("ImportID") Then
                        Return False
                    End If
                Else
                    If gvList.GetRowCellValue(gvList.FocusedRowHandle, "ImportOrID") = item("ImportOrID") Then
                        Return False
                    End If
                End If

            Next
        Else
            Return True
        End If

        Return True
    End Function

    Private Sub sDate_EditValueChanged(sender As Object, e As EventArgs) Handles sDate.Click, eDate.Click
        txtBillNo.Text = ""
        _Find = FindMode._Date
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If MessageBox.Show("ยืนยันการบันทึก หากบันทึกแล้วจะไม่สามารถแก้ไขได้" & vbCrLf _
                           & "ต้องติดต่อผู้ดูแลเท่านั้น โปรดตรวจสอบความถูกต้อง", "บันทึกยอดเข้าคลัง", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            For Each item As DataRow In dtSelect.Rows
                ImportID = item("ImportID")
                clsDS({"transfer"})
                SQL = "INSERT INTO tbStock (MatID, Unit1, Unit1_ID, Unit3, TagID, ImportDate, ImportID, LocID) "
                SQL &= "SELECT tbImportOrder.MatID, tbImportOrder.Unit1_Sum AS Unit1, tbImportOrder.Unit1_ID, tbImportOrder.Unit3_Sum AS Unit3, "
                SQL &= "tbImportOrder.TagID, tbImportList.ImportDate, tbImportList.ImportID,'" & UserInfo.SelectLoc & "'"
                SQL &= "FROM tbImportOrder INNER JOIN tbImportList ON tbImportOrder.ImportID = tbImportList.ImportID INNER JOIN tbMat ON tbImportOrder.MatID = tbMat.MatID "
                SQL &= "INNER JOIN tbSubCategory ON tbMat.SubCatID = tbSubCategory.SubCatID "
                SQL &= "WHERE (tbImportOrder.ImportID = '" & ImportID & "') "
                SQL &= "UPDATE tbImportList SET Transferstat=1 WHERE ImportID='" & ImportID & "'"
                dsTbl("transfer")
            Next
            MessageBox.Show("บันทึกยอดเข้าคลังเสร็จสมบูรณ์", "บันทึกยอดเข้าคลัง", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtSelect.Rows.Clear()
            FirstQry()
            showDB()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clsDS({"reset"})
        SQL = "truncate table tbStock"
        SQL &= " update tbImportList set TransferStat =0"
        'SQL &= " delete from tbImportOrder where ImportID <> 'JGRHPRU' and ImportID <> 'PB400R8'"
        dsTbl("reset")
        Me.Close()
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            'RadioButton2.Checked = False
            RadioButton2.Enabled = False
            RadioButton1.Checked = True
            btnTransfer.Visible = True
            btnTransfer.Enabled = False
            btnPrint.Visible = False
        Else
            RadioButton2.Enabled = True
            btnTransfer.Visible = False
            btnPrint.Visible = True
            btnPrint.Enabled = False
        End If

        If dtSelect IsNot Nothing Then dtSelect.Clear()
        gcList.DataSource = Nothing
        gcSelect.DataSource = Nothing
    End Sub
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        Dim gv As GridView = CType(sender, GridView)
        RowClickFunc(gv)
    End Sub
    Private Sub btnPrintTag(sender As Object, e As EventArgs) Handles btnPrint.Click
        FrmPrintPreview.dtPrint = gvSelect.DataSource
        FrmPrintPreview.ShowDialog()
    End Sub

    Private Sub btnImportLog_Click(sender As Object, e As EventArgs) Handles btnImportLog.Click
        SQL = "SELECT * FROM vwImportLog"
        gcSelect.DataSource = dsTbl("importlog")

        gvSelect.Columns("Unit1_Name").Caption = " "
        gvSelect.Columns("Unit3_Name").Caption = " "
        gvSelect.Columns("วันที่นำเข้า").Group()
        gvSelect.Columns("เลขที่บิล").Group()
        gvSelect.Columns("วัสดุ").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    End Sub

    Private Sub gcSelect_Click(sender As Object, e As EventArgs) Handles gcSelect.Click

    End Sub

    Private Sub gcSelect_DoubleClick(sender As Object, e As EventArgs) Handles gcSelect.DoubleClick
        gcSelect.ShowPrintPreview()
    End Sub
End Class