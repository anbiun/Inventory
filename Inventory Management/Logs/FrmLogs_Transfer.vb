Imports ConDB.Main
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmLogs_Transfer
    Dim locExpr As String
    Private Sub FrmLogs_Transfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDef()
    End Sub
    Private Sub LoadDef()
        With slCat.Properties
            SQL = "SELECT CatID,CatName FROM tbCategory"
            .DataSource = dsTbl("slcat")
            .ValueMember = "CatID"
            .DisplayMember = "CatName"
            .PopulateViewColumns()
            .View.Columns("CatID").Visible = False
            .View.Columns("CatName").Caption = getString("catname")
        End With

        With clbLoc
            SQL = "SELECT LocID,LocName FROM tbLocation"
            .DataSource = dsTbl("clbloc")
            .ValueMember = "LocID"
            .DisplayMember = "LocName"
            .CheckAll()
        End With
        rdDate_All.Checked = True
        deSDate.EditValue = DateAdd(DateInterval.Day, -7, Today)
        deEDate.EditValue = Today
    End Sub
    Private Sub Radio_Checked(sender As Object, e As EventArgs) Handles rdDate_All.CheckedChanged
        deSDate.Enabled = If(rdDate_All.Checked = False, True, False)
        deEDate.Enabled = If(rdDate_All.Checked = False, True, False)
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
        If String.IsNullOrWhiteSpace(locExpr) Then Exit Sub

        With gcList
            SQL = "SELECT * FROM Logs_Transfer"
            SQL &= " WHERE IDValue IN (" & locExpr & ")"
            If rdDate_By.Checked = True Then
                SQL &= " AND TransferDate"
                SQL &= " Between '" & convertDate(deSDate.EditValue) & "'"
                SQL &= " AND '" & convertDate(deEDate.EditValue) & "'"
            End If
            SQL &= " ORDER BY TransferDate DESC"
            .DataSource = dsTbl("gclist")
        End With
        locExpr = String.Empty
        GVFormat()
    End Sub
    Private Sub GVFormat()
        gridInfo = New GridCaption
        For Each cols As GridColumn In gvList.Columns
            If cols.FieldName <> "IDValue" Then
                gridInfo.Add(cols.FieldName)
            End If
        Next
        gridInfo.SetCaption(gvList)
        gvList.BestFitColumns()
    End Sub
    Private Sub Cell_CustomColumnDisplay(ByVal sender As Object,
 ByVal e As CustomColumnDisplayTextEventArgs) Handles gvList.CustomColumnDisplayText
        If e.Column.FieldName = "ApproveStat" Then
            If IsNumeric(e.Value) AndAlso e.Value = 1 Then
                e.DisplayText = getString("apvstat1")
            ElseIf IsNumeric(e.Value) AndAlso e.Value = 2 Then
                e.DisplayText = getString("apvstat2")
            ElseIf IsNumeric(e.Value) AndAlso e.Value = 0 Then
                e.DisplayText = getString("apvstat0")
            End If
        End If
    End Sub
    Public Sub Cell_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle
        Dim View As GridView = sender
        Dim Warn = View.GetRowCellValue(e.RowHandle, "ApproveStat")
        If (e.RowHandle >= 0) Then
            If IsDBNull(Warn) Then
                Warn = 0
            Else
                Warn = If(String.IsNullOrWhiteSpace(Warn), 0, CDbl(Warn))
            End If
            Select Case Warn
                Case = 0
                    e.Appearance.BackColor = Color.IndianRed
                    e.Appearance.BackColor2 = Color.WhiteSmoke
                Case 2
                    e.Appearance.BackColor = Color.LightYellow
                    e.Appearance.BackColor2 = Color.WhiteSmoke
            End Select
        End If

    End Sub
End Class