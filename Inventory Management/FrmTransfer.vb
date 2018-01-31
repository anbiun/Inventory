Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Public Class FrmTransfer
    Dim TagID As String, TransferNo As String,
        LocID_Src As String = UserInfo.SelectLoc, LocID_Dest As String,
        UserStock As String = UserInfo.UserID,
        MatName As String, MatID As String,
        Unit1_Num As Double, Unit3_Num As Double, PerUnit1 As Double,
        Unit1_Name As String, Unit3_Name As String,
        Unit1_ID As String, Unit3_ID As String,
        TransferID As String, dtTransfer_Detail As New DataTable, dtTransfer As New DataTable,
        TransferDate As Date

#Region "FUNC."
    Private Sub FirstQry()
        SQL = "SELECT S.TagID, SC.SubCatName, M.MatName, S.Unit1, U1.UnitName AS Unit1_Name, S.Unit3, U3.UnitName AS Unit3_Name,"
        SQL &= " M.Ratio, S.MatID, S.Unit1_ID, SC.Unit3_ID, S.LocID"
        SQL &= " FROM tbStock AS S INNER JOIN"
        SQL &= " tbMat AS M ON S.MatID = M.MatID INNER JOIN"
        SQL &= " tbUnit AS U1 ON S.Unit1_ID = U1.UnitID INNER JOIN"
        SQL &= " tbSubCategory AS SC ON M.SubCatID = SC.SubCatID INNER JOIN"
        SQL &= " tbUnit AS U3 ON SC.Unit3_ID = U3.UnitID"
        SQL &= " WHERE S.LocID = '" & UserInfo.SelectLoc & "' AND S.Stat <> 0"
        SQL &= " ORDER BY S.MatID"
        dsTbl("stock")

        SQL = "SELECT TransferID, TagID, MatID, 'MatName' AS MatName, Unit1_Num, Unit1_ID,"
        SQL &= " 'Unit1_Name' AS Unit1_Name, Unit3_Num, 'Unit3_Name' AS Unit3_Name"
        SQL &= " ,'LocSrc' LocSrc, 'LocDest' LocDest"
        SQL &= " FROM tbTransfer_Detail"
        dsTbl("transfer_detail")
        dtTransfer_Detail = DS.Tables("transfer_detail").Copy
        dtTransfer_Detail.Clear()

        SQL = "SELECT * FROM tbTransfer"
        dtTransfer = dsTbl("transfer")

        SQL = "SELECT * FROM tbLocation WHERE LocID <> '" & UserInfo.SelectLoc & "'"
        dsTbl("location")
    End Sub
    Private Sub LoadDef()
        With slTagID.Properties
            .DataSource = DS.Tables("stock")
            .DisplayMember = "TagID"
            .ValueMember = "TagID"
            .PopulateViewColumns()

            .View.Columns("MatName").Caption = "ชื่อวัสดุ"
            .View.Columns("SubCatName").Caption = "ประเภท"
            .View.Columns("SubCatName").Group()
            .View.Columns("Unit1").Caption = "คงเหลือ"
            .View.Columns("Unit1_Name").Caption = " "
            .View.Columns("Unit3").Caption = "คงเหลือ"
            .View.Columns("Unit3_Name").Caption = " "
            .View.ExpandAllGroups()
            Dim colname() As String = {"MatID", "Unit1_ID", "Unit3_ID", "Ratio", "LocID"}
            For Each values As String In colname
                .View.Columns(values).Visible = False
            Next
            .View.BestFitColumns()
        End With

        With slLocDest.Properties
            .DataSource = DS.Tables("location")
            .DisplayMember = "LocName"
            .ValueMember = "LocID"
            .PopulateViewColumns()
            .View.Columns("LocName").Caption = "สถานที่เก็บ"
            .View.Columns("LocID").Visible = False
            .View.Columns("LocShort").Caption = "ชื่อย่อ"
            .View.BestFitColumns()
        End With

        slTagID.Properties.NullText = ""
        deDate.EditValue = Today
    End Sub
    Private Sub SumUnit()
        Dim Unit1_Sum, Unit3_Sum As Double

        For rw As Integer = 0 To gvList.RowCount - 1
            If TagID = gvList.GetRowCellValue(rw, "TagID") Then
                'PriceSum = PriceSum + CDbl(gvDes.GetRowCellValue(rw, "Price"))
                Unit1_Sum = CDbl(gvList.GetRowCellValue(rw, "Unit1_Num")) + Unit1_Num
                Unit3_Sum = CDbl(gvList.GetRowCellValue(rw, "Unit3_Num")) + Unit3_Num
            End If
        Next

        If Unit1_Sum > slClick(slTagID, "Unit1") Or Unit3_Sum > slClick(slTagID, "Unit3") Then
            MessageBox.Show("ไม่สามารถเพิ่มเกินจำนวนที่มีอยู่ในคลังได้", "เกินจำนวน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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
            .Columns("TransferID").Visible = False
            .Columns("MatID").Visible = False
            .Columns("Unit1_ID").Visible = False
            .Columns("MatName").Caption = "วัสดุ"
            .Columns("Unit1_Num").Caption = "จำนวน"
            .Columns("Unit1_Name").Caption = " "
            .Columns("Unit3_Num").Caption = "รวมเป็นปริมาณ"
            .Columns("Unit3_Name").Caption = " "
            .Columns("LocSrc").Caption = "ต้นทาง"
            .Columns("LocDest").Caption = "ปลายทาง"
            .BestFitColumns()
        End With
    End Sub
    Private Sub cancelFunc()
        grpMat.Enabled = False
        grpRequest.Enabled = True
        PnlSave.Visible = False
        txtTransferNo.Text = ""
        dtTransfer_Detail.Clear()
    End Sub
#End Region

#Region "FormLoad"
    Private Sub FrmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstQry()
        LoadDef()
        gcList.DataSource = dtTransfer_Detail
        GVFomat()
        lbUserStock.Text = UserInfo.UserName
        UserStock = UserInfo.UserID
    End Sub
#End Region

#Region "Button Control"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If chkInput(grpRequest) = False Then Exit Sub
        If chkInput(grpMat) = False Then Exit Sub
        Dim dtr As DataRow

        'For Check Duplicat Order
        Dim findValue As Integer = 0
        For rw As Integer = 0 To gvList.RowCount - 1
            Dim gvValues As String = gvList.GetRowCellValue(rw, "TagID")
            If TagID = gvValues Then findValue = +1
            If findValue > 1 Then Exit For
        Next
        'Chck Input Number
        If txtUnit1.Value = 0 AndAlso txtUnit3.Value = 0 Then
            MessageBox.Show("กรุณากรอกจำนวนให้ถูกต้อง", "ไม่กรอกจำนวน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        ElseIf PerUnit1 = 0 Then
            MessageBox.Show("ไม่มีการตั้งค่า ปริมาณต่อจำนวนนับ" & vbNewLine & "กรุณาตั้งค่าที่หน้า" & FrmMain.BBIMaterialList.Caption, "กรุณาตั้งค่าปริมาณต่อจำนวนนับ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Unit1_Num = txtUnit1.Value
        Unit3_Num = If(PerUnit1 > 0, (txtUnit1.Value * PerUnit1) + txtUnit3.Value, txtUnit3.Value)
        'New Order
        If findValue < 1 Then
            If Unit1_Num > slClick(slTagID, "Unit1") Or Unit3_Num > slClick(slTagID, "Unit3") Then
                MessageBox.Show("ไม่สามารถเพิ่มเกินจำนวนที่มีอยู่ในคลังได้", "เกินจำนวน", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            With dtTransfer_Detail
                'chkTagID
                If String.IsNullOrWhiteSpace(TagID) Then
                    MessageBox.Show("กรุณาพิมพ์ TagID.", "กำหนด TagID.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

                '--end chk
                dtr = .NewRow
                dtr("TransferID") = TransferID
                dtr("TagID") = TagID
                dtr("MatID") = MatID
                dtr("MatName") = MatName
                dtr("Unit1_Num") = Unit1_Num
                dtr("Unit1_ID") = Unit1_ID
                dtr("Unit1_Name") = Unit1_Name
                dtr("Unit3_Num") = Unit3_Num
                dtr("unit3_Name") = Unit3_Name
                dtr("LocSrc") = UserInfo.LocName
                dtr("LocDest") = slClick(slLocDest, "LocName")
                .Rows.Add(dtr)
                .AcceptChanges()
                gcList.Refresh()
            End With
        Else
            SumUnit()
        End If
        txtUnit1.Text = ""
        txtUnit3.Text = ""
        gvList.BestFitColumns()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If gvList.FocusedRowHandle >= 0 Then
            dtTransfer_Detail.Rows(gvList.FocusedRowHandle).Delete()
        End If
        dtTransfer_Detail.AcceptChanges()
        gcList.Refresh()
        SumUnit()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim tbList() As DataTable = {dtTransfer, dtTransfer_Detail}
        Dim fieldList() As String = Nothing
        For Each tbName As DataTable In tbList
            Select Case tbName.TableName
                Case dtTransfer.TableName
                    fieldList = {"TransferID", "TransferNo", "TransferDate", "LocID_Src", "LocID_Dest", "UserStock"}
                Case dtTransfer_Detail.TableName
                    fieldList = {"TransferID", "TagID", "MatID", "Unit1_Num", "Unit3_Num", "Unit1_ID"}
            End Select
            blkCpy("tb" & tbName.TableName, tbName, fieldList)
        Next
        MsgBox("successfully", MsgBoxStyle.Information)
        btnCancel.PerformClick()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelFunc()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        grpRequest.Enabled = False
        grpMat.Enabled = True
        PnlSave.Visible = True
        txtUnit1.Text = ""
        txtUnit3.Text = ""
        TransferID = genID()

        Dim dr As DataRow
        With dtTransfer
            .Clear()
            dr = .NewRow
            dr("TransferID") = TransferID
            dr("TransferNo") = TransferNo
            dr("TransferDate") = TransferDate
            dr("LocID_Src") = UserInfo.SelectLoc
            dr("LocID_Dest") = LocID_Dest
            dr("UserStock") = UserStock
            .Rows.Add(dr)
            .AcceptChanges()
        End With
    End Sub
#End Region

#Region "Other Control"

    Private Sub deDate_EditValueChanged(sender As Object, e As EventArgs) Handles deDate.EditValueChanged
        TransferDate = deDate.EditValue
    End Sub
    Private Sub slTagID_EditValueChanged(sender As Object, e As EventArgs) Handles slTagID.EditValueChanged, slLocDest.EditValueChanged
        slTagID.Properties.View.ExpandAllGroups()
        Dim ctr As DevExpress.XtraEditors.SearchLookUpEdit = CType(sender, DevExpress.XtraEditors.SearchLookUpEdit)
        Select Case ctr.Name
            Case slTagID.Name
                TagID = slClick(sender, "TagID")
                MatID = slClick(sender, "MatID")
                MatName = slClick(sender, "MatName")
                Unit1_ID = slClick(sender, "Unit1_ID")
                Unit3_ID = slClick(sender, "Unit3_ID")
                Unit1_Name = slClick(sender, "Unit1_Name")
                Unit3_Name = slClick(sender, "Unit3_Name")
                PerUnit1 = slClick(sender, "Ratio")
                LocID_Src = slClick(sender, "LocID")
            Case slLocDest.Name
                LocID_Dest = slClick(sender, "LocID")
        End Select

        lbUnit1Name.Text = Unit1_Name
        lbUnit3Name.Text = Unit3_Name
    End Sub
    Private Sub txtTransferNo_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransferNo.EditValueChanged
        TransferNo = txtTransferNo.Text
    End Sub
    Private Sub txtTransferNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransferNo.KeyPress
        If e.KeyChar = "-" Then
            Exit Sub
        Else
            numOnly(e)
        End If
    End Sub
#End Region

End Class