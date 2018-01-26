Imports ConDB.Main
Public Class FrmLogs_Transfer
    Dim locExpr As String
    Private Sub FrmLogs_Transfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDef()
    End Sub
    Private Sub LoadDef()
        With slCat
            SQL = "SELECT CatID,CatName FROM tbCategory"
            .Properties.DataSource = dsTbl("slcat")
            .Properties.ValueMember = "CatID"
            .Properties.DisplayMember = "CatName"
        End With
        With clbLoc
            SQL = "SELECT LocID,LocName FROM tbLocation"
            .DataSource = dsTbl("clbloc")
            .ValueMember = "LocID"
            .DisplayMember = "LocName"
            .CheckAll()
        End With
    End Sub
    Private Sub slCat_valuechange(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        With clbSubCat
            SQL = "SELECT CatID+SubCatID IDValue,SubCatName FROM tbSubcategory"
            SQL &= " WHERE CatID ='" & slCat.EditValue & "'"
            .DataSource = dsTbl("clbsubcat")
            .ValueMember = "IDValue"
            .DisplayMember = "SubCatName"
        End With
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim List_Subcat As New List(Of String)
        For Each item As DataRowView In clbSubCat.CheckedItems
            List_Subcat.Add(item(0))
        Next
        For Each list As String In List_Subcat
            If List_Subcat.Last = list Then
                locExpr += "'" & list & "'"
            Else
                locExpr += "'" & list & "',"
            End If
        Next

        With gcList
            SQL = "SELECT * FROM Logs_Transfer"
            SQL &= " WHERE IDValue IN (" & locExpr & ")"
            SQL &= " ORDER BY TransferDate DESC"
            .DataSource = dsTbl("gclist")
        End With
        locExpr = String.Empty
    End Sub
End Class