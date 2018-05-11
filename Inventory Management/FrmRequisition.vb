Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Public Class FrmRequisition
    Dim TagID As String, RequestNo As String,
        UserRequest As String, UserStock As String,
        MatName As String, MatID As String,
        Unit1_Num As Double, Unit3_Num As Double, Ratio As Double,
        Unit1_Name As String, Unit3_Name As String,
        Unit1_ID As String, Unit3_ID As String,
        RequestID As String, dtList As New DataTable,
        RequestDate As Date, LoadFlag As Boolean = False,
        ImReq As New InOutFunc
#Region "FUNC."
    Private Function genReqNo() As String
        Dim ReqNo As New GenRequestNo With {.SetDate = If(loadSuccess = False, Nothing, deDate.EditValue)}
        Return ReqNo.Gen
    End Function
    Private Sub LoadAutoCom()
        'AutuComplete ชื่อผู้เบิก
        Dim collection As New AutoCompleteStringCollection()
        SQL = "SELECT UserRequest FROM tbRequisition GROUP BY UserRequest"
        dsTbl("alluserrequest")
        For Each dr As DataRow In DS.Tables("alluserrequest").Rows
            collection.Add(dr("UserRequest"))
        Next
        txtUserRequest.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtUserRequest.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtUserRequest.MaskBox.AutoCompleteCustomSource = collection
    End Sub
    Private Sub FirstQry()
        clsDS({"stock", "requisition"})

        SQL = "SELECT RequestID, TagID, MatID, 'MatName' AS MatName, Unit1_Num, Unit1_ID, "
        SQL &= " 'Unit1_Name' AS Unit1_Name, Unit3_Num, 'Unit3_Name' AS Unit3_Name,"
        SQL &= " UserRequest, UserStock, RequestNo, RequestDate,LocID FROM tbRequisition"
        dsTbl("requisition")
        dtList = DS.Tables("requisition").Copy
        dtList.Clear()

        SQL = "SELECT * FROM tbSubMat"
        dsTbl("submat")

        SQL = "SELECT CatID,SubCatID, SubCatName,GroupTag FROM tbSubCategory"
        With sluSubCat.Properties
            .DataSource = dsTbl("subcat")
            .PopulateViewColumns()
            .DisplayMember = "SubCatName"
            .ValueMember = "SubCatID"
            .View.Columns("CatID").Visible = False
            .View.Columns("SubCatID").Visible = False
            .View.Columns("GroupTag").Visible = False
            .View.Columns("SubCatName").Caption = getString("subcatname")
            .PopulateViewColumns()
        End With
    End Sub
    Private Sub LoadDef()
        txtUserRequest.Text = ""
        slTagID.Properties.NullText = ""
        deDate.EditValue = Today
    End Sub
    Private Sub SumUnit()
        Dim Unit1_Sum, Unit3_Sum As Double

        For rw As Integer = 0 To gvList.RowCount - 1
            If TagID = gvList.GetRowCellValue(rw, "TagID") Then
                'PriceSum = PriceSum + CDbl(gvDes.GetRowCellValue(rw, "Price"))
                Unit1_Sum = CDbl(gvList.GetRowCellValue(rw, "Unit1_Num")) + ImReq.Unit1
                Unit3_Sum = CDbl(gvList.GetRowCellValue(rw, "Unit3_Num")) + ImReq.Unit3
            End If
        Next
        If Unit1_Sum > slClick(slTagID, "Unit1") Or Unit3_Sum > slClick(slTagID, "Unit3") Then
            MessageBox.Show("ไม่สามารถเบิกเกินจำนวนคลังได้", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        For rw As Integer = 0 To gvList.RowCount - 1
            If TagID = gvList.GetRowCellValue(rw, "TagID") Then
                With gvList
                    '.SetRowCellValue(rw, "PriceSum", unit3Sum * gvDes.GetRowCellValue(rw, "Price"))
                    .SetRowCellValue(rw, "Unit1_Num", Unit1_Sum)
                    .SetRowCellValue(rw, "Unit3_Num", Unit3_Sum)
                End With
            End If
        Next
    End Sub
    Private Sub GVFomat()
        With gvList
            .PopulateColumns()
            .Columns("RequestID").Visible = False
            .Columns("MatID").Visible = False
            .Columns("Unit1_ID").Visible = False
            '.Columns("Unit3_ID").Visible = False
            .Columns("UserRequest").Visible = False
            .Columns("UserStock").Visible = False
            .Columns("MatName").Caption = "วัสดุ"
            .Columns("Unit1_Num").Caption = "จำนวน"
            .Columns("Unit1_Name").Caption = " "
            .Columns("Unit3_Num").Caption = "รวมเป็นปริมาณ"
            .Columns("Unit3_Name").Caption = " "
            .Columns("RequestNo").Caption = "เลขที่ใบเบิกวัสดุ"
            .Columns("RequestDate").Caption = "วันที่"
            .Columns("LocID").Visible = False
            .BestFitColumns()
        End With
    End Sub
    Private Sub cancelFunc()
        slTagID.EditValue = Nothing
        sluSubCat.EditValue = Nothing
        grpMat.Enabled = False
        grpRequest.Enabled = True
        PnlSave.Visible = False
        txtRequestNo.Text = ""
        txtUserRequest.Text = ""
        dtList.Clear()
        txtRequestNo.Text = genReqNo()
    End Sub
#End Region

#Region "FormLoad"
    Private Sub FrmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstQry()
        gcList.DataSource = dtList
        GVFomat()
        lbUserStock.Text = User.UserName
        UserStock = User.UserID
        LoadAutoCom()
        slTagID.EditValue = Nothing
        sluSubCat.EditValue = Nothing
        LoadFlag = True
    End Sub
#End Region

#Region "Button Control"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If chkInput(grpRequest) = False Then Exit Sub
        If chkInput(grpMat) = False Then Exit Sub

        'Chck Input Number
        'If txtUnit1.Value = 0 AndAlso txtUnit3.Value = 0 Then
        '    MessageBox.Show("กรุณากรอกจำนวนให้ถูกต้อง", "ไม่กรอกจำนวน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'ElseIf Ratio = 0 Then
        '    MessageBox.Show("ไม่มีการตั้งค่า ปริมาณต่อจำนวนนับ" & vbNewLine & "กรุณาตั้งค่าที่หน้า" & FrmMain.BBIMaterialList.Caption, "กรุณาตั้งค่าปริมาณต่อจำนวนนับ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If

        'หาค่าจริงจาก Ratio ให้ Unit1
        With ImReq
            .Unit1 = txtUnit1.Value
            .Unit3 = txtUnit3.Value
            .Ratio = Ratio
            .GroupTag = slClick(sluSubCat, "GroupTag")
            If .Result = True Then AddRow()
        End With

        txtUnit1.Text = ""
        txtUnit3.Text = ""
        gvList.BestFitColumns()
    End Sub
    Private Sub AddRow()
        Dim dr As DataRow
        'For Check Duplicat Order
        Dim findValue As Integer = 0
        For rw As Integer = 0 To gvList.RowCount - 1
            Dim gvValues As String = gvList.GetRowCellValue(rw, "TagID")
            If TagID = gvValues Then findValue = +1
            If findValue > 1 Then Exit For
        Next
        'New Order
        If findValue < 1 Then
            With dtList
                RequestID = genID()
                'chkTagID
                If String.IsNullOrWhiteSpace(TagID) Then
                    MessageBox.Show("กรุณาพิมพ์ TagID.", "กำหนด TagID.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

                '--end chk
                dr = .NewRow
                dr("RequestID") = RequestID
                dr("TagID") = TagID
                dr("MatID") = MatID
                dr("MatName") = MatName
                dr("Unit1_Num") = ImReq.Unit1
                dr("Unit1_ID") = Unit1_ID
                dr("Unit1_Name") = Unit1_Name
                dr("Unit3_Num") = ImReq.Unit3
                dr("unit3_Name") = Unit3_Name
                dr("UserRequest") = UserRequest
                dr("UserStock") = UserStock
                dr("RequestDate") = RequestDate
                dr("RequestNo") = RequestNo
                dr("LocID") = User.SelectLoc
                .Rows.Add(dr)
                .AcceptChanges()
                gcList.Refresh()
            End With
        Else
            SumUnit()
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If gvList.FocusedRowHandle >= 0 Then
            dtList.Rows(gvList.FocusedRowHandle).Delete()
        End If
        dtList.AcceptChanges()
        gcList.Refresh()
        SumUnit()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fieldList() As String = Nothing
        If MessageBox.Show("ยืนยันการบันทึกข้อมูล โปรดตรวจสอบอีกครั้งให้ถูกต้อง", "ยืนยันการบันทึก", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            fieldList = {"RequestID", "MatID", "Unit1_ID", "UserRequest", "UserStock",
                                 "Unit1_Num", "Unit3_Num", "RequestNo", "RequestDate", "TagID", "LocID"}
            blkCpy("tbRequisition", dtList, fieldList)
        End If

        'btnProcess(btnSave)
        btnCancel.PerformClick()
        QRyStock()
        LoadAutoCom()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelFunc()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If chkInput(grpRequest) = False Then Exit Sub
        SQL = "SELECT RequestNo FROM tbRequisition"
        SQL &= " WHERE RequestNo = '" & RequestNo & "'"
        dsTbl("find")
        If DS.Tables("find").Rows.Count > 0 Then
            MsgBox("ข้อมูลซ้ำกับในระบบ กรุณาติดต่อผู้ดูแล", MsgBoxStyle.Critical, "ERROR Duplicate")
            Exit Sub
        End If
        grpRequest.Enabled = False
        grpMat.Enabled = True
        PnlSave.Visible = True
        txtUnit1.Text = ""
        txtUnit3.Text = ""

    End Sub
#End Region

#Region "Other Control"
    Private Sub deDate_EditValueChanged(sender As Object, e As EventArgs) Handles deDate.EditValueChanged
        RequestDate = deDate.EditValue
        txtRequestNo.Text = genReqNo()
    End Sub
    Private Sub slTagID_EditValueChanged(sender As Object, e As EventArgs) Handles slTagID.EditValueChanged
        slTagID.Properties.View.ExpandAllGroups()
        TagID = slClick(sender, "TagID")
        MatID = slClick(sender, "MatID")
        MatName = slClick(sender, "MatName")
        Unit1_ID = slClick(sender, "Unit1_ID")
        Unit3_ID = slClick(sender, "Unit3_ID")
        Unit1_Name = slClick(sender, "Unit1_Name")
        Unit3_Name = slClick(sender, "Unit3_Name")
        Ratio = slClick(sender, "Ratio")
        lbUnit1Name.Text = Unit1_Name
        lbUnit3Name.Text = Unit3_Name
    End Sub
    Private Sub slUserRequest_EditValueChanged(sender As Object, e As EventArgs)
        UserRequest = slClick(sender, "UserID")
    End Sub
    Private Sub txtRequestNo_EditValueChanged(sender As Object, e As EventArgs) Handles txtRequestNo.EditValueChanged
        RequestNo = txtRequestNo.Text
    End Sub
    Private Sub txtRequestNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRequestNo.KeyPress
        If e.KeyChar = "-" Or e.KeyChar = "/" Then
            Exit Sub
        Else
            numOnly(e)
        End If
    End Sub
    Private Sub txtUserRequest_EditValueChanged(sender As Object, e As EventArgs) Handles txtUserRequest.EditValueChanged
        UserRequest = If(String.IsNullOrWhiteSpace(txtUserRequest.Text), Nothing, Trim(txtUserRequest.Text))
    End Sub
#End Region
    Private Sub txtUnit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnit1.EditValueChanged, txtUnit3.EditValueChanged
        Dim spiCtr As SpinEdit = CType(sender, SpinEdit)
        If spiCtr.Value < 0 Then spiCtr.Value = 0

        If spiCtr.Name = txtUnit1.Name AndAlso spiCtr.Value > slClick(slTagID, "Unit1") Then
            spiCtr.Value = slClick(slTagID, "Unit1")
        ElseIf spiCtr.Name = txtUnit3.Name AndAlso spiCtr.Value > slClick(slTagID, "Unit3") Then
            spiCtr.Value = slClick(slTagID, "Unit3")
        End If

    End Sub
    Private Sub sluSubCat_EditValueChanged(sender As Object, e As EventArgs) Handles sluSubCat.EditValueChanged
        If LoadFlag = False Then Exit Sub
        QRyStock()
        LoadDef()
    End Sub
    Private Sub QRyStock()
        SQL = "SELECT S.TagID, SC.SubCatName, M.MatName, S.Unit1, U1.UnitName AS Unit1_Name, S.Unit3, U3.UnitName "
        SQL &= "AS Unit3_Name, O.Ratio, S.MatID, S.Unit1_ID, SC.Unit3_ID,SC.SubCatID, "
        SQL &= "SM.ProductName "
        SQL &= "FROM tbStock AS S "
        SQL &= "INNER JOIN tbMat AS M ON S.MatID = M.MatID "
        SQL &= "INNER JOIN tbUnit AS U1 ON S.Unit1_ID = U1.UnitID "
        SQL &= "INNER JOIN tbSubCategory AS SC ON M.SubCatID = SC.SubCatID "
        SQL &= "INNER JOIN tbUnit AS U3 ON SC.Unit3_ID = U3.UnitID "
        SQL &= "INNER JOIN tbImportOrder O ON S.TagID = O.TagID And S.MatID = O.MatID "
        'AND S.ImportID = O.ImportID "
        SQL &= "LEFT OUTER JOIN CombineSubMatName() SM ON S.MatID = SM.MatID"

        SQL &= " WHERE S.LocID = '" & User.SelectLoc & "' AND SC.SubCatID = '" & sluSubCat.EditValue & "'"
        SQL &= " AND S.Stat > 0"
        SQL &= " ORDER BY S.MatID"
        Dim sqlDbug As String = SQL
        With slTagID.Properties
            Dim enableCol As String() = {"MatName",
                                         "SubCatName",
                                         "Unit1", "Unit1_Name",
                                         "Unit3", "Unit3_Name",
                                         "SubMatName",
                                         "TagID"}
            .DataSource = dsTbl("stock")
            .DisplayMember = "TagID"
            .ValueMember = "TagID"
            .PopulateViewColumns()
            .View.Columns("MatName").Caption = "ชื่อวัสดุ"
            .View.Columns("SubCatName").Caption = getString("subcatname")
            .View.Columns("Unit1").Caption = "คงเหลือ"
            .View.Columns("Unit1_Name").Caption = " "
            .View.Columns("Unit3").Caption = "คงเหลือ"
            .View.Columns("Unit3_Name").Caption = " "
            .View.Columns("ProductName").Caption = "เบอร์ร่วม"
            .View.Columns("TagID").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            For Each col As GridColumn In .View.Columns
                If enableCol.Contains(col.FieldName) Then
                    col.Visible = True
                Else
                    col.Visible = False
                End If
            Next
        End With

    End Sub
    Private Sub slTagID_MouseDown(sender As Object, e As MouseEventArgs) Handles slTagID.MouseDown
        Dim enableCol As String() = {"MatName",
                                      "SubCatName",
                                      "Unit1", "Unit1_Name",
                                      "Unit3", "Unit3_Name",
                                      "TagID"}
        For Each col As String In enableCol
            slTagID.Properties.View.Columns(col).BestFit()
        Next

    End Sub
End Class