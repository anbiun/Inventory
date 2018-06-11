Option Strict On
Option Explicit On
Imports ConDB.Main
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
    Private _Access As Boolean = True
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
            menu = New GridViewColumnButtonMenu(hi.View, _PoNo, _Access)
            menu.Init(hi)
            menu.Show(hi.HitPoint)
        End If
    End Sub
    Private Sub GridMouseDown(sender As Object, e As MouseEventArgs)
        Dim view As GridView = CType(sender, GridView)
        If e.Button = MouseButtons.Right Then
            _PoNo = GetGroupValue(_gView, gControl, "PoNo", "PoNo")
            If User.Permission <= UserInfo.UserGroup.Manger Then
                DT = TryCast(TryCast(gView.DataSource, BindingSource).DataSource, DataTable)
                FoundRow = DT.Select("PoNo = '" & _PoNo & "' AND PoStat = '1'")
                _Access = If(FoundRow.Count > 0, False, True)
            End If
            If String.IsNullOrEmpty(_PoNo) Then Return
            ShowMenu(view.CalcHitInfo(New Point(e.X, e.Y)))
        End If
    End Sub
End Class
Public Class GridViewColumnButtonMenu
    Inherits GridViewMenu
    Property PoNo As String
    Property Access As Boolean
    Public Sub New(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView, Optional PoNo As String = "", Optional Access As Boolean = False)
        MyBase.New(View)
        Me.PoNo = PoNo
        Me.Access = Access
    End Sub
    Protected Overrides Sub CreateItems()
        Items.Clear()

        Dim PoInfo As New DXSubMenuItem("รายละเอียดใบสั่งซื้อ")
        Items.Add(PoInfo)
        PoInfo.Items.Add(CreateMenuItem("ในนาม KIWI", My.Resources.KIW_16x16, "KIWI", True))
        PoInfo.Items.Add(CreateMenuItem("ในนาม JL", My.Resources.JL_16x16, "JL", True))
        'Items.Add(CreateMenuItem("รายละเอียดใบสั่งซื้อ", My.Resources.po_16x16, "PoInfo", True))

        Items.Add(CreateMenuItem("แก้ไข", My.Resources.edit_16x16, "Edit", False))
        If User.Permission >= UserInfo.UserGroup.Manger Then Items.Add(CreateMenuItem("ลบ", My.Resources.delete_16x16, "Del", Access))
    End Sub
    Protected Overrides Sub OnMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
        If RaiseClickEvent(sender, Nothing) Then Return
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        If item.Tag Is Nothing Then Return
        If item.Tag.ToString() = "Edit" Then
            Edit()
        ElseIf item.Tag.ToString = "Del" Then
            Del()
        ElseIf item.Tag.ToString = "KIWI" Or item.Tag.ToString = "JL" Then
            PoInfo(If(item.Tag.ToString = "KIWI", "002", "001"))
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
    Private Sub PoInfo(ComID As String)
        Dim getReport As New GetReport With {.PoNo = PoNo, .CompanyID = ComID}
        If User.Permission < UserInfo.UserGroup.Admin Then
            Dim ReportViewer As New ReportPrintTool(getReport.CreateReport())
            ReportViewer.ShowRibbonPreview()
        Else
            Dim designTool As New ReportDesignTool(getReport.CreateReport())
            designTool.ShowRibbonDesignerDialog()
        End If
    End Sub
End Class
Public Class GetReport
    Property PoNo As String
    Property CompanyID As String

    Private Function BindToData() As DataSet
        Dim Bahttext As New MoneySpell
        Dim dtResult As New DataTable
        SQL = String.Format("SELECT * FROM Report_PO WHERE PoNo='{0}'", PoNo)
        dsTbl("Report")
        SQL = "SELECT * FROM tbCompany WHERE CoID = '" & CompanyID & "'"
        dsTbl("Company")
        dtResult = DS.Tables("Report").Copy
        Dim GetGrandTotal As Func(Of Double) = Function()
                                                   If Not IsNumeric(dtResult(0)("GrandTotal")) Then
                                                       Return 0
                                                   Else
                                                       Return CDbl(dtResult(0)("GrandTotal").ToString)
                                                   End If
                                               End Function
        dtResult.Columns.Add(New DataColumn() With {.ColumnName = "Bathtext",
                                      .DataType = GetType(String),
                                      .DefaultValue = Bahttext.NumberToThaiWord(GetGrandTotal())})
        Dim newDS As New DataSet
        dtResult.TableName = "Report"
        newDS.Tables.Add(dtResult)
        newDS.Tables.Add(DS.Tables("Company").Copy)
        newDS.DataSetName = "DSReport"

        Return newDS
    End Function
    Friend Function CreateReport() As XtraReport
        Dim report As New Report_PO

        ' Assign the data source to the report.
        report.DataSource = BindToData()
        report.DataMember = "DSReport"
        Return report
    End Function
End Class
Public Class MoneySpell

    Public Function NumberToThaiWord(ByVal InputNumber As Double) As String
        If InputNumber = 0 Then
            NumberToThaiWord = "ศูนย์บาทถ้วน"
            Return NumberToThaiWord
        End If

        Dim NewInputNumber As String
        NewInputNumber = InputNumber.ToString("###0.00")

        If CDbl(NewInputNumber) >= 10000000000000 Then
            NumberToThaiWord = ""
            Return NumberToThaiWord
        End If

        Dim tmpNumber(2) As String
        Dim FirstNumber As String
        Dim LastNumber As String

        tmpNumber = NewInputNumber.Split(CChar("."))
        FirstNumber = tmpNumber(0)
        LastNumber = tmpNumber(1)

        Dim nLength As Integer = 0
        nLength = CInt(FirstNumber.Length)

        Dim i As Integer
        Dim CNumber As Integer = 0
        Dim CNumberBak As Integer = 0
        Dim strNumber As String = ""
        Dim strPosition As String = ""
        Dim FinalWord As String = ""
        Dim CountPos As Integer = 0

        For i = nLength To 1 Step -1
            CNumberBak = CNumber
            CNumber = CInt(FirstNumber.Substring(CountPos, 1))

            If CNumber = 0 AndAlso i = 7 Then
                strPosition = "ล้าน"
            ElseIf CNumber = 0 Then
                strPosition = ""
            Else
                strPosition = PositionToText(i)
            End If

            If CNumber = 2 AndAlso strPosition = "สิบ" Then
                strNumber = "ยี่"
            ElseIf CNumber = 1 AndAlso strPosition = "สิบ" Then
                strNumber = ""
            ElseIf CNumber = 1 AndAlso strPosition = "ล้าน" AndAlso nLength >= 8 Then
                If CNumberBak = 0 Then
                    strNumber = "หนึ่ง"
                Else
                    strNumber = "เอ็ด"
                End If
            ElseIf CNumber = 1 AndAlso strPosition = "" AndAlso nLength > 1 Then
                strNumber = "เอ็ด"
            Else
                strNumber = NumberToText(CNumber)
            End If

            CountPos = CountPos + 1

            FinalWord = FinalWord & strNumber & strPosition
        Next

        CountPos = 0
        CNumberBak = 0
        nLength = CInt(LastNumber.Length)

        Dim Stang As String = ""
        Dim FinalStang As String = ""

        If CDbl(LastNumber) > 0.0 Then
            For i = nLength To 1 Step -1
                CNumberBak = CNumber
                CNumber = CInt(LastNumber.Substring(CountPos, 1))

                If CNumber = 1 AndAlso i = 2 Then
                    strPosition = "สิบ"
                ElseIf CNumber = 0 Then
                    strPosition = ""
                Else
                    strPosition = PositionToText(i)
                End If

                If CNumber = 2 AndAlso strPosition = "สิบ" Then
                    Stang = "ยี่"
                ElseIf CNumber = 1 AndAlso i = 2 Then
                    Stang = ""
                ElseIf CNumber = 1 AndAlso strPosition = "" AndAlso nLength > 1 Then
                    If CNumberBak = 0 Then
                        Stang = "หนึ่ง"
                    Else
                        Stang = "เอ็ด"
                    End If
                Else
                    Stang = NumberToText(CNumber)
                End If

                CountPos = CountPos + 1

                FinalStang = FinalStang & Stang & strPosition
            Next

            FinalStang = FinalStang & "สตางค์"
        Else
            FinalStang = ""
        End If

        Dim SubUnit As String
        If FinalStang = "" Then
            SubUnit = "บาทถ้วน"
        Else
            If CDbl(FirstNumber) <> 0 Then
                SubUnit = "บาท"
            Else
                SubUnit = ""
            End If
        End If

        NumberToThaiWord = FinalWord & SubUnit & FinalStang
    End Function
    Private Function NumberToText(ByVal CurrentNum As Integer) As String
        Dim _nText As String = ""

        Select Case CurrentNum
            Case 0
                _nText = ""
            Case 1
                _nText = "หนึ่ง"
            Case 2
                _nText = "สอง"
            Case 3
                _nText = "สาม"
            Case 4
                _nText = "สี่"
            Case 5
                _nText = "ห้า"
            Case 6
                _nText = "หก"
            Case 7
                _nText = "เจ็ด"
            Case 8
                _nText = "แปด"
            Case 9
                _nText = "เก้า"
        End Select

        NumberToText = _nText
    End Function
    Private Function PositionToText(ByVal CurrentPos As Integer) As String
        Dim _nPos As String = ""

        Select Case CurrentPos
            Case 0
                _nPos = ""
            Case 1
                _nPos = ""
            Case 2
                _nPos = "สิบ"
            Case 3
                _nPos = "ร้อย"
            Case 4
                _nPos = "พัน"
            Case 5
                _nPos = "หมื่น"
            Case 6
                _nPos = "แสน"
            Case 7
                _nPos = "ล้าน"
            Case 8
                _nPos = "สิบ"
            Case 9
                _nPos = "ร้อย"
            Case 10
                _nPos = "พัน"
            Case 11
                _nPos = "หมื่น"
            Case 12
                _nPos = "แสน"
            Case 13
                _nPos = "ล้าน"
        End Select

        PositionToText = _nPos
    End Function
End Class