Option Explicit On
Option Strict On
Imports ConDB.Main
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmPONew
    Dim dtSupplier, dtMat, dtResult, dtSubCat, dtPO As New DataTable
    Dim PoID As String
    Property Edit As Boolean = False
    Dim SubCatID As String
    Sub New()
        loadSuccess = False
        InitializeComponent()
        AddHandler txtPO.KeyPress, Sub(sender As Object, e As KeyPressEventArgs)
                                       NumOnly(e)
                                   End Sub
    End Sub
#Region "Function"
    Private Sub Qry()
        Dim QryList As New Dictionary(Of String, String)
        QryList.Add("Supplier", "SELECT S.SupplierID,S.SupplierName,SD.SubCatID,SD.Ratio FROM tbSupplier S 
                                 LEFT JOIN tbSupplier_Detail SD ON S.SupplierID = SD.SupplierID")
        QryList.Add("Mat", "SELECT MatID,MatName,Ratio,Ratio_Name Unit3_Name,CatID+SubCatID SubCatID FROM vwMat WHERE Stat <> 0 ORDER BY MatName")
        QryList.Add("SubCat", "SELECT CatID+SubCatID SubCatID,SubCatName FROM tbSubCategory")
        QryList.Add("PoDetail", "SELECT * FROM tbPo_Detail")
        QryList.Add("PO", "SELECT PoNo FROM tbPO")

        For Each tbName As String In QryList.Keys
            SQL = QryList(tbName)
            dsTbl(tbName)
        Next
        dtPO = DS.Tables("PO")
        dtSupplier = DS.Tables("Supplier").Copy
        dtMat = DS.Tables("Mat").Copy
        dtSubCat = DS.Tables("SubCat").Copy
        dtResult = DS.Tables("PoDetail").Clone
        dtResult.Columns.Add("MatName").SetOrdinal(1)
        dtResult.Columns.Add("Unit3_Name").SetOrdinal(4)
        dtResult.Columns.Add("SubCatName").SetOrdinal(0)
    End Sub
    Private Sub LoadDef()
        grpPoList.Enabled = True
        grpPoOrder.Enabled = False
        PnlSave.Visible = False
        btnNewOrder.Enabled = True
        dtResult.Clear()
        gcList.DataSource = dtResult
        ClearText(True)
    End Sub
    Private Sub LoadComBo()
        With sluSubCat.Properties
            .DataSource = dtSubCat
            .View.PopulateColumns(dtSubCat)
            .DisplayMember = "SubCatName"
            .ValueMember = "SubCatID"
            gridInfo = New GridCaption(.View)
            gridInfo.HIDE.Columns("SubCatID")
            gridInfo.SetCaption()
        End With
    End Sub
    Private Sub AddRow()
        Dim MatID As String = sluMat.EditValue.ToString
        Dim findValue As Integer = 0
        For rw As Integer = 0 To gvList.RowCount - 1
            Dim gvValues As String = gvList.GetRowCellValue(rw, "MatID").ToString
            If MatID = gvValues Then findValue = +1
            If findValue >= 1 Then Exit For
        Next
        Dim dr As DataRow
        If findValue <= 0 Then
            With dtResult
                dr = .NewRow
                dr = dtResult.NewRow
                dr("PoDetailID") = GenID().ToString
                dr("MatID") = sluMat.EditValue
                dr("MatName") = sluMat.Text
                dr("Unit3") = txtUnit3.Text
                dr("Unit3_Name") = lblUnit3_name.Text
                dr("SubCatName") = sluSubCat.Text
                dr("PoID") = PoID
                dr("Stat") = 0
                dr("MatNotation") = txtMatNotation.Text
                dr("UnitPrice") = txtUnitPrice.EditValue
                dr("PriceSum") = CDbl(txtUnitPrice.EditValue) * CDbl(txtUnit3.EditValue)
                .Rows.Add(dr)
                .AcceptChanges()
                gcList.Refresh()
            End With
        Else
            'SumRow
            FoundRow = dtResult.Select("MatID='" & MatID & "'")
            For rw As Integer = 0 To dtResult.Rows.Count - 1
                If dtResult.Rows(rw)("MatID").ToString = MatID Then
                    Dim val As Integer = CInt(dtResult.Rows(rw)("Unit3")) + CInt(txtUnit3.Text)
                    dtResult.Rows(rw)("Unit3") = val
                End If
            Next
            dtResult.AcceptChanges()
            gcList.Refresh()
        End If
    End Sub
    Private Sub GVFormat()
        Dim gCaption As New GridCaption(gvList)
        With gCaption
            .HIDE.Columns("PoID")
            .HIDE.Columns("PoDetailID")
            .HIDE.Columns("MatID")
            .SetCaption()
        End With
        gvList.BestFitColumns()
        gvList.Columns("Stat").Width = 120
    End Sub
    Private Function genPONO() As String
        Return CStr(CInt(dtPO.Compute("MAX(PoNo)", "").ToString) + 1)
    End Function
    Private Sub ClearText(All As Boolean)
        txtUnit3.EditValue = 0
        txtUnitPrice.EditValue = 0
        sluMat.EditValue = Nothing
        txtMatNotation.Text = String.Empty
        If All = True Then
            sluSubCat.EditValue = Nothing
            sluSupplier.EditValue = Nothing
            deDate.EditValue = Date.Now
            txtPO.Text = genPONO()
            ceVat.CheckState = CheckState.Unchecked
            txtPoNotation.Text = String.Empty
            txtPrNo.Text = String.Empty
        End If
    End Sub
#End Region

#Region "Other Control"
    Private Sub FrmPOInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Qry()
        LoadDef()
        LoadComBo()
        loadSuccess = True

        Dim Buttons As New ColumnButton.Main With {.gControl = gcList, .gView = gvList}
        Dim btnDel As New ColumnButton.Editor With {.ToolTip = "ลบรายการนี้", .Field = "del", .Image = My.Resources.remove_16x16}
        Dim btnSuccess As New ColumnButton.Editor With {.Field = "success", .ToolTip = getString("postat1"), .Image = My.Resources.postat1_16x16}
        Dim btnOrder As New ColumnButton.Editor With {.Field = "order", .ToolTip = getString("postat0"), .Image = My.Resources.sales_16x16}

        If Edit Then
            Buttons.Add(btnSuccess)
            Buttons.Add(btnOrder)
            With EditorPO.setControl
                .PoNo = txtPO
                .Supplier = sluSupplier
                .PoDate = deDate
                .DelivDate = deDelivery
                .gvResult = gvList
                .gcResult = gcList
                .SubCat = sluSubCat
            End With
            PoID = EditorPO.PoID
            dtResult = EditorPO.dtResult
            EditorPO.LoadEdit()
            gvList.BestFitColumns()
            gvList.Columns("Stat").Width = 120
            grpPoList.Enabled = False
            grpPoOrder.Enabled = True
            PnlSave.Visible = True
        End If
        Buttons.Add(btnDel)
        GVFormat()
    End Sub
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        If txtPO.TextLength <> 5 Or ChkInput(grpPoList, "txtPoNotation") = False Then Return
        SQL = "SELECT PoNo FROM tbPo WHERE PoNo='" & txtPO.Text & "'"
        dsTbl("findPO")
        If DS.Tables("findPO").Rows.Count > 0 Then
            MessageBox.Show("เลขที่ PO นี้มีการสั่งซื้อไปแล้ว กรุณาแก้ไข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        txtUnit3.EditValue = 0
        grpPoOrder.Enabled = True
        grpPoList.Enabled = False
        PnlSave.Visible = True
        dtResult.Clear()
        PoID = GenID().ToString
        GVFormat()
        ClearText(False)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If CInt(txtUnit3.EditValue) <= 0 Or CDbl(txtUnitPrice.EditValue) <= 0.0 Or sluMat.EditValue Is Nothing Then Return
        FoundRow = dtResult.Select("MatID = '" & sluMat.EditValue.ToString & "'")
        If FoundRow.Count > 0 Then Return
        AddRow()
        ClearText(False)
        gvList.BestFitColumns()
        gvList.Columns("Stat").Width = 120
    End Sub
    Private Sub txtUnit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnit3.EditValueChanged, txtUnitPrice.EditValueChanged
        Dim ctr As DevExpress.XtraEditors.SpinEdit = TryCast(sender, DevExpress.XtraEditors.SpinEdit)
        ctr.EditValue = If(CInt(ctr.EditValue) < 0, 0, ctr.EditValue)
    End Sub
    Private Sub SearchLookup_EditValueChanged(sender As Object, e As EventArgs) Handles sluSubCat.EditValueChanged, sluSupplier.EditValueChanged
        Dim slu As DevExpress.XtraEditors.SearchLookUpEdit = TryCast(sender, DevExpress.XtraEditors.SearchLookUpEdit)
        If slu.EditValue Is Nothing Or sluSubCat.EditValue Is Nothing Then Return
        If String.IsNullOrEmpty(slu.EditValue.ToString) Then Return

        SubCatID = sluSubCat.EditValue.ToString
        Select Case slu.Name
            Case sluSubCat.Name
                With sluSupplier.Properties
                    .DataSource = dtSupplier.Select("SubCatID = '" & SubCatID & "'").Take(1).CopyToDataTable
                    .View.PopulateColumns(dtSupplier)
                    .DisplayMember = "SupplierName"
                    .ValueMember = "SupplierID"
                    gridInfo = New GridCaption(.View)
                    gridInfo.ONLY.Columns("SupplierName")
                    gridInfo.SetCaption()
                End With

            Case sluSupplier.Name
                Dim RatioArray As Func(Of String) = Function()
                                                        Dim result As String = String.Empty
                                                        For Each dr As DataRow In dtSupplier.Select("SubCatID='" & SubCatID & "'")
                                                            If String.IsNullOrEmpty(result) Then
                                                                result = String.Format("'{0}'", dr("Ratio"))
                                                            Else
                                                                result += String.Format(",'{0}'", dr("Ratio"))
                                                            End If
                                                        Next
                                                        Return result
                                                    End Function
                FoundRow = dtMat.Select(String.Format("SubCatID = '{0}' AND Ratio IN ({1})", SubCatID, RatioArray()))
                With sluMat.Properties
                    If FoundRow.Count > 0 Then
                        .DataSource = FoundRow.CopyToDataTable
                        .View.PopulateColumns(dtMat)
                        .DisplayMember = "MatName"
                        .ValueMember = "MatID"
                        gridInfo = New GridCaption(.View)
                        gridInfo.HIDE.Columns("MatID")
                        gridInfo.HIDE.Columns("SubCatID")
                        gridInfo.SetCaption()
                        .View.Columns("Ratio").Caption = getString("RatioPO")
                        .View.BestFitColumns()
                        lblUnit3_name.Text = FoundRow(0)("Unit3_Name").ToString
                    Else
                        .DataSource = Nothing
                    End If
                End With

        End Select
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If dtResult.Rows.Count <= 0 Then Return
        If MessageBox.Show("ยืนยันการบันทึกข้อมุล", "บันทึกข้อมูล PO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.No Then Return
        Dim Sums As Func(Of String, Double) = Function(SumCase As String)
                                                  Dim PriceSum As Double = CDbl(dtResult.Compute("Sum(PriceSum)", "").ToString)
                                                  Select Case SumCase
                                                      Case "vat"
                                                          PriceSum = If(ceVat.CheckState = CheckState.Checked, (PriceSum * 7 / 100), 0)
                                                      Case "grand"
                                                          PriceSum = PriceSum + (PriceSum * 7 / 100)
                                                  End Select
                                                  Return PriceSum
                                              End Function
        SQL = "DELETE FROM tbPO WHERE PoID = '" & PoID & "'
               DELETE FROM tbPo_Detail WHERE PoID = '" & PoID & "'
                INSERT INTO tbPO (PoID,PoNo,SupplierID,PoDate,DeliveryDate,UserID,PrNo,PoNotation,Vat,GoodValue,GrandTotal) " &
                String.Format("VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                          PoID,
                                          txtPO.Text,
                                          sluSupplier.EditValue.ToString,
                                          ConvertDate(CDate(deDate.EditValue)).ToString,
                                          ConvertDate(CDate(deDelivery.EditValue)).ToString,
                                          User.UserID,
                              txtPrNo.Text,
                              txtPoNotation.Text,
                              Sums("vat"),
                              Sums("good"),
                              Sums("grand")) & ""
        dsTbl("InsertPO")
        blkCpy("tbPo_Detail", dtResult, {"PoDetailID", "MatID", "Unit3", "PoID", "Stat", "MatNotation", "UnitPrice", "PriceSum"})
        MessageBox.Show("บันทึกข้อมุล PO เรียบร้อยแล้ว", "บันทึกข้อมูล PO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BindInfo.Name = "logpo"
        BindInfo.Refresh()
        LoadDef()
    End Sub
    Private Sub deDate_EditValueChanged(sender As Object, e As EventArgs) Handles deDate.EditValueChanged
        If deDate.EditValue Is Nothing Then Return
        deDelivery.EditValue = DateAdd(DateInterval.Day, 7, CDate(deDate.EditValue))
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        LoadDef()
    End Sub
    Friend Sub CellClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        Dim view As GridView = CType(sender, GridView)
        If view.FocusedColumn.FieldName = "del" Then
            If view.GetFocusedRowCellValue("Stat").ToString = "1" Then MessageBox.Show("ไม่สามารถแก้ไขได้ เนื่องจากรายการนี้มีการส่งของแล้ว", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Return
            dtResult.Rows(gvList.GetDataSourceRowIndex(e.RowHandle)).Delete()
        End If
        If view.FocusedColumn.FieldName = "success" Then
            dtResult.Rows(gvList.GetDataSourceRowIndex(e.RowHandle))("Stat") = "1"
        End If
        If view.FocusedColumn.FieldName = "order" Then
            dtResult.Rows(gvList.GetDataSourceRowIndex(e.RowHandle))("Stat") = "0"
        End If
        dtResult.AcceptChanges()
        view.RefreshData()
    End Sub
    Overridable Sub CustomDrawCell(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs) Handles gvList.CustomDrawCell
        If e.CellValue Is Nothing Then Exit Sub
        Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
        Dim infox As TextEditViewInfo = TryCast(gcix.ViewInfo, TextEditViewInfo)
        If e.Column.FieldName = "Stat" Then
            e.Column.Width = 120
            e.DisplayText = String.Empty
            If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "Stat" Then
                If e.CellValue.ToString = "1" Then
                    infox.ContextImage = My.Resources.postat1_16x16
                    e.DisplayText = getString("postat1")
                ElseIf e.CellValue.ToString = "2" Then
                    infox.ContextImage = My.Resources.postat2_16x16
                    e.DisplayText = getString("postat2")
                ElseIf e.CellValue.ToString = "0" Then
                    infox.ContextImage = My.Resources.sales_16x16
                    e.DisplayText = getString("postat0")
                End If
                infox.CalcViewInfo()
            End If
        End If
    End Sub

#End Region


End Class

