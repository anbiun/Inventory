Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmTransfer
    Dim TagID As String, TransferNo As String,
        LocID_Src As String = User.SelectLoc, LocID_Dest As String,
        UserStock As String = User.UserID,
        MatName As String, MatID As String,
        Unit1_Num As Double, Unit3_Num As Double, PerUnit1 As Double,
        Unit1_Name As String, Unit3_Name As String,
        Unit1_ID As String, Unit3_ID As String,
        TransferID As String, dtTransfer_Detail As New DataTable, dtTransfer As New DataTable,
        TransferDate As Date

#Region "FUNC."
    Private Sub FirstQry()
        'คิวรี่ข้อมูลสต๊อกปัจจุบัน
        SQL = "SELECT S.TagID, SC.SubCatName, M.MatName, S.Unit1, U1.UnitName AS Unit1_Name, S.Unit3, U3.UnitName AS Unit3_Name,"
        SQL &= " M.Ratio, S.MatID, S.Unit1_ID, SC.Unit3_ID, S.LocID"
        SQL &= " FROM tbStock AS S INNER JOIN"
        SQL &= " tbMat AS M ON S.MatID = M.MatID INNER JOIN"
        SQL &= " tbUnit AS U1 ON S.Unit1_ID = U1.UnitID INNER JOIN"
        SQL &= " tbSubCategory AS SC ON M.SubCatID = SC.SubCatID INNER JOIN"
        SQL &= " tbUnit AS U3 ON SC.Unit3_ID = U3.UnitID"
        SQL &= " WHERE S.LocID = '" & User.SelectLoc & "' AND S.Stat <> 0 AND Unit3 > 0.1"
        SQL &= " ORDER BY S.MatID"
        dsTbl("stock")

        'สร้างตารางสำหรับรายการโอนย้าย
        SQL = "SELECT 
                '' TransferNo,TagID,
                '' MatName,Unit1_Num,'' Unit1_Name,
                   Unit3_Num,'' Unit3_Name,
                '' LocSrc,'' LocDest,
                TransferID,Notation
              FROM tbTransfer_Detail"
        dsTbl("Transfer_Detail")
        dtTransfer_Detail = DS.Tables("Transfer_Detail").Clone

        SQL = "Select * From tbTransfer"
        dtTransfer = dsTbl("transfer")

        SQL = "Select * From tbLocation Where LocID <> '" & User.SelectLoc & "'"
        dsTbl("location")
    End Sub
    Private Sub LoadDef()
        With slTagID.Properties
            .DataSource = DS.Tables("stock")
            .DisplayMember = "TagID"
            .ValueMember = "TagID"
            .PopulateViewColumns()
            gridInfo = New GridCaption(.View)
            .View.Columns("SubCatName").Group()
            .View.OptionsFind.AllowFindPanel = False
            .View.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True
            .View.ExpandAllGroups()
            .View.BestFitColumns()
            With gridInfo
                .ONLY.Columns("SubCatName")
                .ONLY.Columns("tagid")
                .ONLY.Columns("matname")
                .ONLY.Columns("unit1")
                .ONLY.Columns("unit1_name")
                .ONLY.Columns("unit3")
                .ONLY.Columns("unit3_name")

                .SetCaption()
            End With
        End With

        With slLocDest.Properties
            .DataSource = DS.Tables("location")
            .DisplayMember = "LocName"
            .ValueMember = "LocID"
            .PopulateViewColumns()
            gridInfo = New GridCaption(.View)
            gridInfo.HIDE.Columns("Locid")

            gridInfo.SetCaption()
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
        gridInfo = New GridCaption(gvList)
        With gridInfo
            .HIDE.Columns("TransferID")
            .SetCaption()
        End With
        gvList.BestFitColumns()
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
    Private Sub FrmTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstQry()
        LoadDef()
        gcList.DataSource = dtTransfer_Detail
        GVFomat()
        lbUserStock.Text = User.UserName
        UserStock = User.UserID
    End Sub
#End Region

#Region "Button Control"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If chkInput(grpRequest) = False AndAlso Not String.IsNullOrEmpty(txtNotation.Text) Then Exit Sub
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
            MessageBox.Show("ไม่มีการตั้งค่า ปริมาณต่อจำนวนนับ" & vbNewLine & "กรุณาตั้งค่าที่หน้า" & FrmMain.btnMatList.Caption, "กรุณาตั้งค่าปริมาณต่อจำนวนนับ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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
                dtr("MatName") = MatName
                dtr("Unit1_Num") = Unit1_Num
                dtr("Unit1_Name") = Unit1_Name
                dtr("Unit3_Num") = Unit3_Num
                dtr("unit3_Name") = Unit3_Name
                dtr("LocSrc") = User.LocName
                dtr("LocDest") = slClick(slLocDest, "LocName")
                dtr("TransferNo") = TransferNo
                dtr("Notation") = txtNotation.Text
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
                    fieldList = {"TransferID", "TransferNo", "DateTransfer", "LocID_Src", "LocID_Dest", "UserStock"}
                Case dtTransfer_Detail.TableName
                    fieldList = {"TransferID", "TagID", "Unit1_Num", "Unit3_Num", "Notation"}
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
        If txtTransferNo.Text.Length <> 5 AndAlso User.Permission < UserInfo.UserGroup.Manger Then MessageBox.Show("เลขที่เอกสารไม่ถูกต้อง กรูณาตรวจสอบ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        SQL = "SELECT TransferNo FROM tbTransfer WHERE TransferNo = '" & txtTransferNo.Text & "'"
        dsTbl("check")
        If DS.Tables("check").Rows.Count > 0 And String.IsNullOrEmpty(txtNotation.Text) Then
            MessageBox.Show("กรุณากรอกหมายเหตุ เนื่องจากบิลนี้เคยทำรายการแล้ว", "เลขที่บิลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNotation.Focus()
            Return
        End If
        grpRequest.Enabled = False
        grpMat.Enabled = True
        PnlSave.Visible = True
        txtUnit1.Text = ""
        txtUnit3.Text = ""
        TransferID = GenID()

        Dim dr As DataRow
        With dtTransfer
            .Clear()
            dr = .NewRow
            dr("TransferID") = TransferID
            dr("TransferNo") = TransferNo
            dr("DateTransfer") = TransferDate
            dr("LocID_Src") = User.SelectLoc
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
        ElseIf e.KeyChar = "/" Then
            numOnly(e)
            Dim ReqNo As New GenRequestNo With {
                .SetDate = If(loadSuccess = False, Nothing, deDate.EditValue),
                .SetTable = "tbTransfer",
                .SetField = "transferNo"}
            txtTransferNo.Text = ReqNo.Gen
        Else
            numOnly(e)
        End If
    End Sub
    Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvList.CustomDrawCell
        If e.Column.FieldName = "LocDest" Then
            If e.CellValue Is Nothing Then Exit Sub
            If e.RowHandle <> DevExpress.XtraGrid.GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "LocDest" Then
                Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
                Dim infox As DevExpress.XtraEditors.ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, DevExpress.XtraEditors.ViewInfo.TextEditViewInfo)
                infox.ContextImage = My.Resources.forward_16x16
                'infox.BestFitUpdateToMaximumWidthString(e.CellValue)
                infox.CalcViewInfo()
            End If
        End If
    End Sub
#End Region

End Class