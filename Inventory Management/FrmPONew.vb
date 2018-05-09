Option Explicit On
Option Strict On
Imports ConDB.Main
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

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
        QryList.Add("Mat", "SELECT MatID,MatName,Ratio_Name Unit3_Name,CatID+SubCatID IDVal FROM vwMat WHERE Stat <> 0 ORDER BY MatName")
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
                dr("PoDetailID") = genID().ToString
                dr("MatID") = sluMat.EditValue
                dr("MatName") = sluMat.Text
                dr("Unit3") = txtUnit1.Text
                dr("Unit3_Name") = lblUnit3_name.Text
                dr("SubCatName") = sluSubCat.Text
                dr("PoID") = PoID
                .Rows.Add(dr)
                .AcceptChanges()
                gcList.Refresh()
            End With
        Else
            'SumRow
            FoundRow = dtResult.Select("MatID='" & MatID & "'")
            For rw As Integer = 0 To dtResult.Rows.Count - 1
                If dtResult.Rows(rw)("MatID").ToString = MatID Then
                    Dim val As Integer = CInt(dtResult.Rows(rw)("Unit3")) + CInt(txtUnit1.Text)
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
            .ONLY.Columns("PoNo")
            .ONLY.Columns("SubCatName")
            .ONLY.Columns("MatName")
            .ONLY.Columns("Unit3")
            .ONLY.Columns("Unit3_Name")
            .ONLY.Columns("Del")
            .SetCaption()
        End With
        gvList.BestFitColumns()

        With sluSupplier.Properties
            .PopulateViewColumns()
            gCaption = New GridCaption(.View)
            gCaption.HIDE.Columns("SupplierID")
            gCaption.SetCaption()
        End With
        With sluSubCat.Properties
            .PopulateViewColumns()
            gCaption = New GridCaption(.View)
            gCaption.HIDE.Columns("IDVal")
            gCaption.SetCaption()
        End With
        With sluMat.Properties
            .PopulateViewColumns()
            gCaption = New GridCaption(.View)
            gCaption.HIDE.Columns("MatID")
            gCaption.HIDE.Columns("IDval")
            gCaption.SetCaption()
        End With

    End Sub
#End Region

#Region "Other Control"
    Private Sub FrmPOInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Qry()
        LoadDef()
        GVFormat()
        Dim btnDel As New ColumnButton.Editor With {
                         .Caption = " ",
                         .ToolTip = "ลบรายการนี้",
                         .Field = "del",
                         .Image = My.Resources.remove_16x16
                         }
        Dim Buttons As New ColumnButton.Main With {.gControl = gcList, .gView = gvList}
        Buttons.Add(btnDel)
        loadSuccess = True
    End Sub
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
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        If txtPO.TextLength <> 5 Then Return
        grpPoOrder.Enabled = If(chkInput(grpPoList), True, False)
        grpPoList.Enabled = False
        PnlSave.Visible = True
        dtResult.Clear()
        PoID = genID().ToString
        GVFormat()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If CInt(txtUnit1.EditValue) <= 0 Then Return
        AddRow()
        gvList.BestFitColumns()
    End Sub
    Private Sub txtUnit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnit1.EditValueChanged
        txtUnit1.EditValue = If(CInt(txtUnit1.EditValue) < 0, 0, txtUnit1.EditValue)

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
    Friend Sub CellClick(sender As Object, e As RowCellClickEventArgs) Handles gvList.RowCellClick
        Dim view As GridView = CType(sender, GridView)
        If view.FocusedColumn.FieldName = "del" Then
            dtResult.Rows(gvList.GetDataSourceRowIndex(e.RowHandle)).Delete()
            dtResult.AcceptChanges()
        End If
        view.RefreshData()
    End Sub
#End Region

End Class

Namespace ColumnButton
    Public Class Editor
        Public Property Caption As String
        Public Property ToolTip As String
        Public Property Image As Image
        Public Property ID As String
        Public Property Field As String
    End Class
    Public Class Main
        Public Property gControl As GridControl
        Public Property gView As GridView
        Private EditorList As New List(Of Editor)
        Private Added As New List(Of String)
        Public Sub Add(Val As Editor, Optional valList As Editor() = Nothing)
            If valList IsNot Nothing Then
                For Each items As Editor In valList
                    Val.ID = genID().ToString
                    EditorList.Add(Val)
                Next
            End If
            Val.ID = genID().ToString
            EditorList.Add(Val)
            CreateCol()
        End Sub
        Private Sub CreateCol()
            For Each Keys As Editor In EditorList
                If Added.Contains(Keys.ID.ToLower, StringComparer.OrdinalIgnoreCase) Then
                    Continue For
                End If
                Dim RepoBtn As New RepositoryItemButtonEdit
                Dim Editor As New EditorButton
                Dim col As New GridColumn
                With Editor
                    .Kind = ButtonPredefines.Glyph
                    .Image = Keys.Image
                    .Appearance.BackColor = Color.Azure
                    .Caption = Keys.Caption
                    .ToolTip = Keys.ToolTip
                    .Appearance.Options.UseTextOptions = True
                End With
                With RepoBtn
                    .TextEditStyle = TextEditStyles.HideTextEditor
                    .Buttons.Clear()
                    .Buttons.Add(Editor)
                End With
                With col
                    col = gView.Columns.AddVisible(Keys.Field, " ")
                    col.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
                    col.ColumnEdit = RepoBtn
                    col.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
                End With
                gControl.RepositoryItems.Add(RepoBtn)
                Added.Add(Keys.ID)
            Next
        End Sub
    End Class
End Namespace