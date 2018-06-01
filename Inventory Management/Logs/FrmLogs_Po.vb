Option Strict On
Option Explicit On
Imports ConDB.Main
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI

Public Class FrmLogs_Po
    Property DtResult As New DataTable
    Dim GridSetting As New Grid
    Private Sub FrmPoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstQry()
        LoadDef()
        Dim editfunc As New SendEdit With {.gControl = gcResult, .gView = gvResult}
    End Sub
    Private Sub FirstQry()
        'AssignDB
        SQL = "SELECT * FROM vwPoList
               ORDER BY PoDate DESC"
        dsTbl("polist")
        DtResult = DS.Tables("polist").Copy

        gcResult.DataSource = DtResult.Clone
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
                SQL &= " Between '" & ConvertDate(CDate(deSDate.EditValue)).ToString & "'"
                SQL &= " AND '" & ConvertDate(CDate(deEDate.EditValue)).ToString & "'"
            End If
            SQL &= " ORDER BY PoDate DESC"
            BindInfo.Name = "logpo"
            BindInfo.Qry(SQL)
            .DataSource = BindInfo.Result
        End With
        GridSetting.gView.BestFitColumns()
        GridSetting.gView.ExpandAllGroups()
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs)
        FrmPONew.Dispose()

        FrmPONew.Edit = True
        FrmMain.ShowForm(FrmPONew)
        Return
        Dim v As GridView = GridSetting.gView
        Dim PoNo As String = GetGroupValue(GridSetting.gView, GridSetting.gControl, "PoNo", "PoNo").ToString
        Dim PoStat As String = GetGroupValue(GridSetting.gView, GridSetting.gControl, "PoNo", "PoStat").ToString
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
End Class
Public Class Grid
    Property gControl As GridControl
    Private _gView As New GridView
    Property gView As GridView
        Set(value As GridView)
            _gView = value
            AddHandler _gView.CustomDrawCell, AddressOf CustomDrawCell
            AddHandler _gView.RowCellClick, AddressOf RowCellClick
            AddHandler _gView.RowClick, AddressOf RowClick
        End Set
        Get
            Return _gView
        End Get
    End Property
    Public Sub Main()
        With gView
            gridInfo = New GridCaption(gView)
            With gridInfo
                .HIDE.Columns("IDValue")
                .HIDE.Columns("PoID")
                .HIDE.Columns("PoDetailID")
                .HIDE.Columns("MatID")
                .HIDE.Columns("SupplierID")
                .SetCaption()
            End With
            gridInfo.SetFormat({"Unit3", "Owing", "UnitImport"})
            gridInfo.SetFormat({"DateSave"}, DevExpress.Utils.FormatType.DateTime, "{0:G}")
            .Columns("PoDate").Group()
            .Columns("PoNo").Group()
            .Columns("PoDate").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            .OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True
            .OptionsFind.AlwaysVisible = True
            .BestFitColumns()
            .ExpandAllGroups()
        End With
    End Sub
    Overridable Sub CustomDrawCell(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs)

        If e.CellValue Is Nothing Then Exit Sub
        Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
        Dim infox As TextEditViewInfo = TryCast(gcix.ViewInfo, TextEditViewInfo)
        If e.Column.FieldName = "PoStat" Then
            e.DisplayText = String.Empty
            If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "PoStat" Then
                If e.CellValue.ToString = "1" Then
                    infox.ContextImage = My.Resources.postat1_16x16
                ElseIf e.CellValue.ToString = "2" Then
                    infox.ContextImage = My.Resources.postat2_16x16
                ElseIf e.CellValue.ToString = "0" Then
                    infox.ContextImage = My.Resources.sales_16x16
                End If
                infox.CalcViewInfo()
            End If
        End If
    End Sub
    Private Sub RowCellClick(sender As Object, e As RowCellClickEventArgs)
    End Sub
    Private Sub RowClick(sender As Object, e As RowClickEventArgs)
        If e.RowHandle = GridControl.NewItemRowHandle Or e.RowHandle = GridControl.AutoFilterRowHandle Then Return
        With EditorPO
            .PoNo = GetGroupValue(_gView, gControl, "PoNo", "PoNo")
            DT = CType(CType(gControl.DataSource, BindingSource).DataSource, DataTable)
            FoundRow = DT.Select("PoNo = '" & .PoNo & "'")
            If FoundRow.Count <= 0 Then Return
            .SupplierID = FoundRow(0)("SupplierID").ToString
            .IDVal = FoundRow(0)("IDValue").ToString
            .PoDate = CDate(FoundRow(0)("PoDate")).ToShortDateString
            .DelivDate = CDate(FoundRow(0)("DeliveryDate")).ToShortDateString
            .PoID = FoundRow(0)("PoID").ToString
            .dtResult = FoundRow.CopyToDataTable
            .dtResult.Columns("PoStat").ColumnName = "Stat"
        End With

    End Sub
End Class

Public Class SendEdit
    Private _gView As New GridView
    Private _PoNo As String
    Public Property gControl As GridControl
    Public Property gView As GridView
        Set(value As GridView)
            _gView = value
            AddHandler _gView.MouseDown, AddressOf GridMouseDown
        End Set
        Get
            Return _gView
        End Get
    End Property
    Private Sub ShowMenu(ByVal hi As GridHitInfo)
        Dim menu As GridViewMenu = Nothing
        If hi.HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Row Then
            menu = New GridViewColumnButtonMenu(hi.View, _PoNo)
            menu.Init(hi)
            menu.Show(hi.HitPoint)
        End If
    End Sub
    Private Sub GridMouseDown(sender As Object, e As MouseEventArgs)
        Dim view As GridView = CType(sender, GridView)
        If e.Button = MouseButtons.Right Then
            _PoNo = GetGroupValue(_gView, gControl, "PoNo", "PoNo")
            If String.IsNullOrEmpty(_PoNo) Then Return
            ShowMenu(view.CalcHitInfo(New Point(e.X, e.Y)))
        End If
    End Sub
End Class

Public Class GridViewColumnButtonMenu
    Inherits GridViewMenu
    Property PoNo As String
    Public Sub New(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView, Optional PoNo As String = "")
        MyBase.New(View)
        Me.PoNo = PoNo
    End Sub
    Protected Overrides Sub CreateItems()
        Items.Clear()
        Items.Add(CreateMenuItem("พิมพ์", My.Resources.print_16x16, "Print", True))
        Items.Add(CreateMenuItem("แก้ไข", My.Resources.edit_16x16, "Edit", True))
        If User.Permission >= UserInfo.UserGroup.Manger Then Items.Add(CreateMenuItem("ลบ", My.Resources.delete_16x16, "Del", True))
    End Sub
    Protected Overrides Sub OnMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
        If RaiseClickEvent(sender, Nothing) Then Return
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        If item.Tag Is Nothing Then Return
        If item.Tag.ToString() = "Edit" Then
            Edit()
        ElseIf item.Tag.ToString = "Del" Then
            Del()
        ElseIf item.Tag.ToString = "Print" Then
            Print()
        End If
    End Sub
    Overridable Sub Edit()
        FrmPONew.Dispose()
        FrmPONew.Edit = True
        FrmMain.currentBtn = FrmMain.btnPOnew
        FrmMain.ShowForm(FrmPONew)
    End Sub
    Overridable Sub Del()
        Dim PoNo As String
        PoNo = View.GetFocusedValue.ToString
        'Dim DV As New DataView(TryCast(gControl.DataSource, DataTable), "PoNo ='" & .PoNo & "'", "", DataViewRowState.CurrentRows)
        DT = TryCast(TryCast(View.DataSource, BindingSource).DataSource, DataTable)
        FoundRow = DT.Select("PoNo='" & PoNo & "' AND PoStat <> 0")
        If FoundRow.Count > 0 Then
            MsgBox("ลบไม่ได้")
        Else
            FoundRow = DT.Select("PoNo='" & PoNo & "'")
            Dim PoID As String
            PoID = FoundRow(0)("PoID").ToString
            If MessageBox.Show("ต้องการลบข้อมูลใบ PO เลขที่ " & PoNo & " หรือไม่ ?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                SQL = "DELETE FROM tbPo_Detail WHERE PoID = '" & PoID & "'
                       DELETE FROM tbPo WHERE PoID = '" & PoID & "'"
                dsTbl("delPO")
                BindInfo.Name = "logpo"
                BindInfo.Refresh()
                MessageBox.Show("ลบข้อมูลแล้ว", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                View.ExpandAllGroups()
            End If
        End If

    End Sub
    Private Sub Print()
        Dim getReport As New GetReport With {.PoNo = PoNo}
        Dim designTool As New ReportDesignTool(getReport.CreateReport())
        designTool.ShowRibbonDesignerDialog()
    End Sub
End Class

Public Class GetReport
    Property PoNo As String

    Private Function BindToData() As SqlDataSource
        Dim connectionParameters As New MsSqlConnectionParameters(
            varIP, varDB.ToString, varUSR.ToString, varPWD.ToString, MsSqlAuthorizationType.SqlServer)
        Dim df As New SqlDataSource(connectionParameters)

        Dim query As New CustomSqlQuery()
        query.Name = "custom"
        query.Sql = "SELECT * FROM vwReport_PO WHERE PoNo='" & PoNo & "'"

        df.Queries.Add(query)
        df.RebuildResultSchema() ' Make the data source structure displayed 

        Return df
    End Function
    Friend Function CreateReport() As XtraReport
        Dim report As New Report_PO

        ' Assign the data source to the report.
        report.DataSource = BindToData()
        report.DataMember = "custom"
        Return report

        '' Add a detail band to the report.
        'Dim detailBand As New DetailBand()
        'detailBand.Height = 50
        'report.Bands.Add(detailBand)

        '' Create a new label.
        'Dim label As XRLabel = New XRLabel With {.WidthF = 300}
        '' Specify the label's binding depending on the data binding mode.
        'If Settings.Default.UserDesignerOptions.DataBindingMode = DataBindingMode.Bindings Then
        '    label.DataBindings.Add("Text", Nothing, "customQuery.ProductName")
        'Else
        '    label.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Text", "[ProductName]"))
        'End If
        '' Add the label to the detail band.
        ' DetailBand.Controls.Add(label)
    End Function
End Class