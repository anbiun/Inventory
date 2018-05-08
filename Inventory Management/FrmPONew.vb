Option Explicit On
Option Strict On
Imports ConDB.Main
Public Class FrmPONew
    Dim dtSupplier, dtMat, dtResult, dtSubCat As New DataTable
    Dim PoID As String
    Sub New()
        loadSuccess = False
        InitializeComponent()
        AddHandler txtPO.KeyPress, Sub(sender As Object, e As KeyPressEventArgs)
                                       numOnly(e)
                                   End Sub
    End Sub
#Region "Code"
    Private Sub Qry()
        Dim QryList As New Dictionary(Of String, String)
        QryList.Add("Supplier", "SELECT * FROM tbSupplier ORDER BY SupplierName")
        QryList.Add("Mat", "SELECT MatID,MatName,QtyOfUsing_Name Unit3_Name,CatID+SubCatID IDVal FROM vwMat WHERE Stat <> 0 ORDER BY MatName")
        QryList.Add("SubCat", "SELECT CatID+SubCatID IDVal, SubCatName FROM tbSubCategory ORDER BY SubCatName")
        QryList.Add("PoDetail", "SELECT * FROM tbPo_Detail")

        For Each tbName As String In QryList.Keys
            SQL = QryList(tbName)
            dsTbl(tbName)
        Next

        dtSupplier = DS.Tables("Supplier").Copy
        dtMat = DS.Tables("Mat").Copy
        dtSubCat = DS.Tables("SubCat").Copy
        dtResult = DS.Tables("PoDetail").Clone
        dtResult.Columns.Add("MatName")
        dtResult.Columns.Add("Unit3_Name")

    End Sub
    Private Sub LoadDef()
        grpPoList.Enabled = True
        grpPoOrder.Enabled = False
        PnlSave.Visible = False
        btnNewOrder.Enabled = True
        dtResult.Clear()
        txtPO.Text = String.Empty
        deDate.EditValue = Date.Now
        deDelivery.EditValue = Date.Now
        LoadComBo()

        gcList.DataSource = dtResult
    End Sub
    Private Sub LoadComBo()
        With sluSupplier.Properties
            .DataSource = dtSupplier
            .View.PopulateColumns()
            .DisplayMember = "supplierName"
            .ValueMember = "supplierID"
        End With


        With sluSubCat.Properties
            .DataSource = dtSubCat
            .View.PopulateColumns()
            .DisplayMember = "SubCatName"
            .ValueMember = "IDVal"
        End With
    End Sub
#End Region
    Private Sub sluSubCat_EditValueChanged(sender As Object, e As EventArgs) Handles sluSubCat.EditValueChanged
        If loadSuccess = False Then Return
        FoundRow = dtMat.Select("IDVal = '" & sluSubCat.EditValue.ToString & "'")
        If FoundRow.Count <= 0 Then Return
        With sluMat.Properties
            .DataSource = FoundRow.CopyToDataTable
            .View.PopulateColumns()
            .DisplayMember = "MatName"
            .ValueMember = "MatID"
        End With
        lblUnit3_name.Text = FoundRow(0)("Unit3_Name").ToString
    End Sub
    Private Sub FrmPOInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Qry()
        LoadDef()
        loadSuccess = True
    End Sub

#Region "Other Control"
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        grpPoOrder.Enabled = If(chkInput(grpPoList), True, False)
        grpPoList.Enabled = False
        PnlSave.Visible = True
        dtResult.Clear()
        PoID = genID().ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dr As DataRow
        dr = dtResult.NewRow
        dr("PoDetailID") = genID().ToString
        dr("MatID") = sluMat.EditValue
        dr("MatName") = sluMat.Text
        dr("Unit3") = txtUnit1.Text
        dr("Unit3_Name") = lblUnit3_name.Text
        dr("PoID") = PoID

        dtResult.Rows.Add(dr)
        dtResult.AcceptChanges()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If dtResult.Rows.Count <= 0 Then Return
        If MessageBox.Show("ยืนยันการบันทึกข้อมุล", "บันทึกข้อมูล PO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.No Then Return
        SQL = "INSERT INTO tbPO (PoID,PoNo,SupplierID,PoDate,DeliveryDate,UserID)
                VALUES ('" & PoID & "',
                        '" & txtPO.Text & "',
                        '" & sluSupplier.EditValue.ToString & "',
                        '" & convertDate(CDate(deDate.EditValue)).ToString & "',
                        '" & convertDate(CDate(deDelivery.EditValue)).ToString & "',
                        '" & UserInfo.UserID & "'
                        )"
        dsTbl("InsertPO")
        blkCpy("tbPo_Detail", dtResult, {"PoDetailID", "MatID", "Unit3", "PoID"})
        MessageBox.Show("บันทึกข้อมุล PO เรียบร้อยแล้ว", "บันทึกข้อมูล PO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadDef()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        LoadDef()
    End Sub
#End Region


End Class