Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data
Public Class FmgProduct
    Dim dtProduct As New DataTable
    Dim dtRow As DataRow
    Private Sub ShowDB()
        SQL = "SELECT * FROM tbProduct"
        dsTbl("product")
        dtProduct = DS.Tables("product").Copy
        gcList.DataSource = dtProduct
    End Sub
    Private Sub FmgProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDB()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Save ??", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then Exit Sub
        Dim field As String() = {"ProductID", "ProductName", "QCTarget"}
        'blkCpy("tbProduct", dtProduct, field)
    End Sub

    Private Sub btnAddList_Click(sender As Object, e As EventArgs) Handles btnAddList.Click
        With dtProduct
            dtRow = .NewRow
            dtRow("ProductID") = genID()
            dtRow("ProductName") = txtProduct.Text
            dtRow("QCTarget") = txtTarget.EditValue
            .AcceptChanges()
            gcList.Refresh()
        End With
    End Sub

    Private Sub btnDelList_Click(sender As Object, e As EventArgs) Handles btnDelList.Click
        dtProduct.Rows.Remove(gvList.GetFocusedDataRow)
    End Sub
End Class