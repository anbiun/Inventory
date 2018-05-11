Option Strict On
Option Explicit On
Imports ConDB.Main
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmLogs_Po
    Dim dtResult As New DataTable
    Dim GridSetting As New Grid
    Private Sub FrmPoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstQry
        LoadDef()
    End Sub
    Private Sub FirstQry()
        'AssignDB
        SQL = "SELECT * FROM vwPoList
               ORDER BY PoDate DESC"
        dsTbl("polist")
        dtResult = DS.Tables("polist").Copy
        gcResult.DataSource = dtResult
        GridSetting.gControl = gcResult
        GridSetting.gView = gvResult
        GridSetting.Main()
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
        rdDate_All.Checked = True
        deSDate.EditValue = DateAdd(DateInterval.Day, -7, Today)
        deEDate.EditValue = Today
        slCat.EditValue = Nothing
    End Sub
    Private Sub Radio_Checked(sender As Object, e As EventArgs) Handles rdDate_All.CheckedChanged
        deSDate.Enabled = If(rdDate_All.Checked = False, True, False)
        deEDate.Enabled = If(rdDate_All.Checked = False, True, False)
    End Sub
    Private Sub slCat_valuechange(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        If slCat.EditValue Is Nothing Then Return
        With clbInfo
            .setControl = clbSubCat
            SQL = "SELECT CatID+SubCatID IDValue,SubCatName FROM tbSubcategory"
            SQL &= " WHERE CatID ='" & slCat.EditValue.ToString & "'"
            .ValueMember = "IDValue"
            .DisplayMember = "SubCatName"
            .Datasource = TryCast(dsTbl("clbsubcat"), DataTable)
        End With
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim getList As Func(Of CheckedListBoxControl, String) = Function(clbControl As CheckedListBoxControl)
                                                                    Dim Result As String = String.Empty
                                                                    Dim List_ItemCheck As New List(Of String)
                                                                    For Each item As DataRowView In clbControl.CheckedItems
                                                                        List_ItemCheck.Add(item(0).ToString)
                                                                    Next
                                                                    For Each list As String In List_ItemCheck
                                                                        If List_ItemCheck.Last = list Then
                                                                            Result += "'" & list & "'"
                                                                        Else
                                                                            Result += "'" & list & "',"
                                                                        End If
                                                                    Next
                                                                    Return Result
                                                                End Function

        If clbSubCat.CheckedItemsCount = 0 Then Exit Sub

        With GridSetting.gControl
            SQL = "SELECT * FROM vwPoList"
            SQL &= " WHERE IDValue IN (" & getList(clbSubCat) & ")"
            If rdDate_By.Checked = True Then
                SQL &= " AND PoDate"
                SQL &= " Between '" & convertDate(CDate(deSDate.EditValue)).ToString & "'"
                SQL &= " AND '" & convertDate(CDate(deEDate.EditValue)).ToString & "'"
            End If
            SQL &= " ORDER BY PoDate DESC"
            .DataSource = dsTbl("gclist")
        End With
        GridSetting.gView.BestFitColumns()
        GridSetting.gView.ExpandAllGroups()
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim v As GridView = GridSetting.gView

        Dim PoNo As String = getGroupValue(GridSetting.gView, GridSetting.gControl, "PoNo", "PoNo").ToString
        Dim PoStat As String = getGroupValue(GridSetting.gView, GridSetting.gControl, "PoNo", "PoStat").ToString
        If String.IsNullOrEmpty(PoNo) Or String.IsNullOrEmpty(PoStat) Then Return
        If IsNumeric(PoStat) AndAlso PoStat = "0" AndAlso Not String.IsNullOrEmpty(PoNo) Then
            If MessageBox.Show("ยืนยันการลบรายการเลขที่ " & PoNo & " หรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                SQL = "DELETE FROM tbPo_Detail
                        FROM tbPo_Detail PoDe
                        INNER JOIN tbPo Po ON Po.PoNo = PoDe.PoNo
                        WHERE Po.PoNo = '" & PoNo & "'"
                SQL &= " DELETE FROM tbPo WHERE PoNo ='" & PoNo & "'"
                dsTbl("delPoNo")
            Else
                Return
            End If
            btnSearch.PerformClick()
        Else
            MessageBox.Show("ไม่สามารถยกเลิกรายการที่ส่งครบแล้ว กรุณาทำการโอนย้ายกลับหรือติดต่อผู้ดูแล", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
    Private Sub ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbSubCat.ItemCheck
        clbInfo.SelectAllCheck(sender, e)
    End Sub

    Private Class Grid
        Property gControl As GridControl
        Private _gView As New GridView
        Property gView As GridView
            Set(value As GridView)
                _gView = value
                AddHandler _gView.CustomDrawCell, AddressOf CustomDrawCell
            End Set
            Get
                Return _gView
            End Get
        End Property
        Public Sub Main()
            With gView
                gridInfo = New GridCaption(gView)
                gridInfo.HIDE.Columns("IDValue")
                gridInfo.SetCaption()
                gridInfo.SetFormat({"Unit3", "Owing"})
                gridInfo.SetFormat({"DateSave"}, DevExpress.Utils.FormatType.DateTime, "{0:G}")
                .Columns("PoDate").Group()
                .Columns("PoDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                .Columns("PoNo").Group()
                .BestFitColumns()
                .ExpandAllGroups()
            End With
        End Sub
        Private Sub CustomDrawCell(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs)
            If e.CellValue Is Nothing Then Exit Sub
            Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
            Dim infox As TextEditViewInfo = TryCast(gcix.ViewInfo, TextEditViewInfo)

            If e.Column.FieldName = "PoStat" Then
                e.DisplayText = String.Empty
                If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "PoStat" Then
                    If e.CellValue.ToString = "1" Then
                        infox.ContextImage = My.Resources.apply_16x16
                    ElseIf e.CellValue.ToString = "2" Then
                        infox.ContextImage = My.Resources.about_16x16
                    ElseIf e.CellValue.ToString = "0" Then
                        infox.ContextImage = My.Resources.sales_16x16
                    End If
                    infox.CalcViewInfo()
                End If
            End If
        End Sub
    End Class
End Class
