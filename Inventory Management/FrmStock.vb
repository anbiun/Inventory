Imports DevExpress.Utils
Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls

Public Class FrmStock
    Dim LocID As String
    Dim frmProg As New dlgProgress
    Dim SavePath As String
    Dim GvSource As New GridView
    Dim PO As POFunction.ToolTip
#Region "Code Side"
    Private Sub getStockSP()
        With BindInfo
            .Name = "stock"
            .LocCheked = clbLoc.CheckedItems
            .CatChecked = clbSubCat.CheckedItems
            .Excute()
        End With
        gcMain.DataSource = BindInfo.Result
        gvMain.PopulateColumns()
        gvMain.BestFitColumns()
        GvFormat()
        PO = New POFunction.ToolTip
        PO.ToolTipControl = tooltipGcMain
    End Sub
    Private Sub ExportXLS()
        If gvMain.RowCount < 1 Then Exit Sub
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel 97-2003 (*.xls) |*.xls"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            frmProg = New dlgProgress
            SavePath = saveFileDialog1.FileName
            frmProg.SetMaxValue(gvMain.RowCount - 1)
            frmProg.Show()
            GvSource = gvMain
            'bw.RunWorkerAsync()
            'Excel Variable
            Dim Cols As New Dictionary(Of String, String)
            With Cols
                .Add("A4", "SubCatName")
                .Add("B4", "MatName")
                .Add("C4", "AllowColor")
                .Add("D4", "img/PoStat")
                .Add("E4", "Warn")
                .Add("F4", "เดือน")
                .Add("G4", "Unit1")
                .Add("H4", "Unit1_Name")
                .Add("I4", "Unit3")
                .Add("J4", "Unit3_Name")
                .Add("K4", "Dozen")
                .Add("L4", "โหล")
                .Add("M4", "JL")
                .Add("N4", "KIWI")
                .Add("O4", "JLK")
                Dim colMonth As String = "P/Q/R/S/T/U/V/W/X/Y/Z/AA"
                Dim startMonth As Integer = 0
                For Each cMont As String In colMonth.Split((New Char() {"/"c}))
                    startMonth += 1
                    .Add(cMont & "4", MonthName(startMonth))
                Next

            End With
            Try
                Dim strFileName As String = Directory.GetParent(Application.StartupPath).ToString + "\template\template_stock.xls"
                'Dim dtGetAnotherLoc As DataTable = gvMain.DataSource
                Dim xlApp As Excel.Application = New Excel.ApplicationClass()
                '
                Dim xlWorkBook As Excel.Workbook = Nothing
                Dim xlWorkSheet As Excel.Worksheet = Nothing
                Dim xlRange As Excel.Range = Nothing
                Dim misValue As Object = System.Reflection.Missing.Value

                '' * to open existing file *

                xlWorkBook = xlApp.Workbooks.Open(strFileName, misValue, misValue, misValue _
                                                      , misValue, misValue, misValue, misValue _
                                                     , misValue, misValue, misValue, misValue _
                                                    , misValue, misValue, misValue)

                '' * to add the new one *
                'xlWorkBook = xlApp.Workbooks.Add()

                xlWorkBook = xlApp.ActiveWorkbook
                xlWorkSheet = CType(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)
                xlApp.ScreenUpdating = False
                xlApp.DisplayAlerts = False

                Dim Stock_Normal As Excel.Style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add("ระดับปกติ")
                Dim Stock_Warning As Excel.Style = xlWorkBook.Application.ActiveWorkbook.Styles.Add("ระดับแจ้งเตือน")
                Dim Stock_Danger As Excel.Style = xlWorkBook.Application.ActiveWorkbook.Styles.Add("ระดับอันตราย")

                Stock_Warning.Interior.Color = Color.FromArgb(255, 235, 156)
                Stock_Danger.Interior.Color = Color.FromArgb(255, 199, 206)

                Try
                    xlApp.ScreenUpdating = False
                    xlRange = CType(xlWorkSheet.Cells.Range("A1"), Excel.Range)
                    xlRange.Value2 = "สต๊อกวัสดุยอด ณ วันที่ " & _XLSGetHeader()
                    GvSource.ExpandAllGroups()
                    For gvRow As Integer = 0 To GvSource.RowCount - 1
                        'set cell colour
                        Dim SetCellColor As Func(Of Integer, String) = Function(Row As Integer)
                                                                           Dim warn As Double = If(String.IsNullOrWhiteSpace(gvMain.GetRowCellDisplayText(Row, "Warn")), 0, gvMain.GetRowCellDisplayText(Row, "Warn"))
                                                                           Dim Minimum As Double = If(String.IsNullOrWhiteSpace(gvMain.GetRowCellDisplayText(Row, "Warn_Month")), 0, gvMain.GetRowCellDisplayText(Row, "Warn_Month"))
                                                                           Dim AllowColor As Integer = If(String.IsNullOrWhiteSpace(gvMain.GetRowCellDisplayText(Row, "AllowColor")), 0, gvMain.GetRowCellDisplayText(Row, "AllowColor"))
                                                                           Dim CellRange As String = String.Format("A{0}:AA{0}", 4 + Row)
                                                                           With xlWorkSheet
                                                                               If warn >= 2 Or AllowColor = 0 Then
                                                                                   .Cells.Range(CellRange).Style = Stock_Normal
                                                                               ElseIf warn <= 1 AndAlso AllowColor = 1 Then
                                                                                   .Cells.Range(CellRange).Style = Stock_Danger
                                                                               Else
                                                                                   .Cells.Range(CellRange).Style = Stock_Warning
                                                                               End If
                                                                           End With
                                                                           Return Nothing
                                                                       End Function
                        SetCellColor(gvRow) 'end

                        'get Image
                        Dim getImg As Func(Of String, Image) = Function(Row As Integer)
                                                                   Dim vInfo As GridViewInfo = gvMain.GetViewInfo
                                                                   Dim cellInfo As GridCellInfo = vInfo.GetGridCellInfo(Row, gvMain.Columns("PoStat"))
                                                                   If cellInfo Is Nothing Then Return Nothing
                                                                   Dim tvInfo As ViewInfo.TextEditViewInfo = TryCast(cellInfo.ViewInfo, ViewInfo.TextEditViewInfo)
                                                                   Dim oImage As Image
                                                                   oImage = tvInfo.ContextImage

                                                                   Return oImage
                                                               End Function

                        'set export value
                        For i As Integer = 0 To Cols.Count - 1
                            Dim Col As String = String.Empty
                            Dim ColRow As Integer = 0
                            Dim Chars() As Char = Cols.Keys(i).ToCharArray()
                            'get เลขคอลัม excel
                            For Each ch As Char In Chars
                                If Char.IsDigit(ch) Then
                                    ColRow = ch.ToString
                                Else
                                    Col += ch
                                End If
                            Next
                            Dim currentCollumns As String = String.Format("{0}{1}", Col, ColRow + gvRow)

                            xlRange = CType(xlWorkSheet.Cells.Range(currentCollumns), Excel.Range)
                            If Cols.Values(i) = "AllowColor" Then
                                If GvSource.GetRowCellDisplayText(gvRow, "AllowColor").ToString = "0" Then
                                    xlRange.Value2 = "ไม่มีเป้า QC"
                                Else
                                    xlRange.Value2 = ""
                                End If
                                Continue For
                            ElseIf Cols.Values(i) = "เดือน" Or Cols.Values(i) = "โหล" Then
                                If GvSource.GetRowCellDisplayText(gvRow, "MatName").ToString = "" Then
                                    xlRange.Value2 = ""
                                    Continue For
                                End If
                            End If
                            Try
                                xlRange.Value2 = GvSource.GetRowCellDisplayText(gvRow, Cols.Values(i))
                            Catch ex As Exception
                                If Cols.Values(i).Contains("img") Then
                                    If getImg(gvRow) Is Nothing Then Continue For
                                    Clipboard.SetImage(getImg(gvRow))
                                    xlWorkSheet.Paste(xlRange)
                                    'xlRange.PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteAll)
                                Else
                                    xlRange.Value2 = Cols.Values(i)
                                End If
                            End Try
                        Next

                        frmProg.SetProgress(gvRow)
                    Next

                    xlRange = CType(xlWorkSheet.Cells.Range("A1:C1,E1:L1"), Excel.Range)
                    xlRange.EntireColumn.AutoFit()
                    xlApp.ScreenUpdating = True
                    xlWorkBook.SaveAs(SavePath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                    xlApp.Quit()

                Catch ex As System.Exception
                    MessageBox.Show(ex.Message & vbNewLine & "\n\n=======  WRITE TO EXCEL ERROR:  ======\n\n" & vbNewLine &
                                    ex.StackTrace)
                Finally
                    releaseObject(xlRange)
                    releaseObject(xlWorkSheet)
                    releaseObject(xlWorkBook)
                    releaseObject(xlApp)
                    frmProg.Close()
                End Try
            Catch exl As System.Exception
                MessageBox.Show(exl.Message &
                        vbNewLine & "\n\n=======   ERROR TO ACESS EXCEL:  ======\n\n" & vbNewLine &
                        exl.StackTrace)
            End Try
            If MessageBox.Show("นำข้อมูลออก Excel แล้ว " & SavePath & vbNewLine &
                                                                      "ต้องการเปิดไฟล์หรือไม่ ?", "นำออกข้อมูลสำเร็จ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim Pinfo As New ProcessStartInfo
                Pinfo.UseShellExecute = False
                Pinfo.FileName = "EXCEL.EXE"
                Pinfo.Arguments = SavePath
                Process.Start("EXCEL.EXE", """" + SavePath + """")
            End If
        End If
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing

        Catch ex As System.Exception
            obj = Nothing
            MessageBox.Show("Clean Up Memory Error\n" + ex.ToString())
        Finally
            If (Not obj Is Nothing) Then
                Dim pos As Integer = GC.GetGeneration(obj)
                GC.Collect(pos)

            Else
                GC.Collect()
                GC.WaitForPendingFinalizers()
            End If
        End Try
    End Sub
    Private Sub GvFormat()
        If gvMain.RowCount <= 0 Then Exit Sub
        gridInfo = New GridCaption(gvMain)
        With gridInfo
            .HIDE.Columns("Warn_Month")
            .HIDE.Columns("QCWarn")
            .HIDE.Columns("matID1")
            .HIDE.Columns("matid")
            .HIDE.Columns("productname")
            .HIDE.Columns("AllowColor")
            .SetCaption()
            Dim ColList As String() = {"Unit1", "Unit3", "Dozen", "Warn", "JL", "KIWI", "JLK"}
            .SetFormat(ColList)
            For i As Integer = 1 To 12
                .SetFormat({MonthName(i)}, FormatType.Numeric, "{0:n0}")
            Next
        End With

        With gvMain
            .Columns("SubCatName").Group()
            .ExpandAllGroups()
            .OptionsBehavior.AllowPartialGroups = DefaultBoolean.True
            .Columns("SubCatName").Fixed = Columns.FixedStyle.Left
            .Columns("MatName").Fixed = Columns.FixedStyle.Left
            .Columns("Warn").Fixed = Columns.FixedStyle.Left
            .Columns("Warn_Name").Fixed = Columns.FixedStyle.Left
            .Columns("PoStat").Fixed = Columns.FixedStyle.Left
            .Columns("Warn").Caption = getString("warn1")
            .BestFitColumns()
            .OptionsView.ShowAutoFilterRow = True
        End With
    End Sub
#End Region
    Dim _XLSGetHeader As Func(Of String) = Function()
                                               SQL = "SELECT MAX(RequestDate) FROM tbRequisition"
                                               dsTbl("get")
                                               Return DS.Tables("get")(0)(0)
                                           End Function
    Dim days As String() = {"จันทร์", "อังคาร", "พุทธ", "พฤหัสบดี", "ศุกร์", "เสาร์", "อาทิตย์"}
    Dim defH As Integer = 25
    Dim sizeH As Integer = 0
    Private Sub FrmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False
        If User.Permission <= UserInfo.UserGroup.Manger Then expandAdjust.Enabled = False
        SQL = "SELECT CatID,CatName FROM tbCategory"
        With slCat.Properties
            .DataSource = dsTbl("cat")
            .DisplayMember = "CatName"
            .ValueMember = "CatID"
            .PopulateViewColumns()
            .View.Columns("CatID").Visible = False
            .View.Columns("CatName").Caption = "หมวดวัสดุ"
        End With

        SQL = "SELECT LocID, LocName FROM tbLocation"
        With clbInfo
            .setControl = clbLoc
            .DisplayMember = "LocName"
            .ValueMember = "LocID"
            .Datasource = dsTbl("loc")
            clbLoc.CheckAll()
        End With

        lastStock.Text += " " & _XLSGetHeader()
        GvFormat()
        cbStat.SelectedIndex = 0
        slCat.EditValue = Nothing
        loadSuccess = True
    End Sub
    Private Sub btnExPortExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportXLS()
    End Sub
    Public Sub GVRowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvMain.RowStyle
        Dim View As GridView = sender
        Dim Warn = View.GetRowCellValue(e.RowHandle, "Warn")
        Dim Warn_Month = View.GetRowCellValue(e.RowHandle, "Warn_Month")
        Dim AllowColor = View.GetRowCellValue(e.RowHandle, "AllowColor")
        If (e.RowHandle >= 0) Then
            If IsDBNull(Warn) Then
                Warn = 0
            Else
                Warn = If(String.IsNullOrWhiteSpace(Warn), 0, CDbl(Warn))
            End If
            If IsDBNull(Warn_Month) Then
                Warn_Month = 0
            End If

            If Warn <= 1 AndAlso AllowColor = 1 Then
                e.Appearance.BackColor = ColorTranslator.FromHtml("#fc9797")
                e.Appearance.BackColor2 = Color.WhiteSmoke
            ElseIf Warn <= Warn_Month AndAlso AllowColor = 1 Then
                e.Appearance.BackColor = Color.LightGoldenrodYellow
                e.Appearance.BackColor2 = Color.LightYellow
            Else
                e.Appearance.BackColor = Nothing
                e.Appearance.BackColor2 = Nothing
            End If
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If clbLoc.CheckedItemsCount <= 0 Or clbSubCat.CheckedItemsCount <= 0 Then Exit Sub
        getStockSP()
        'getOldStockSP()
    End Sub
    Private Sub slCat_EditValueChanged(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        If loadSuccess = False Then Exit Sub
        SQL = "SELECT CatID+SubCatID AS IDvalue,SubCatName FROM tbSubcategory WHERE CatID='" & slClick(slCat, "CatID") & "'"
        With clbInfo
            .setControl = clbSubCat
            .DisplayMember = "SubCatName"
            .ValueMember = "IDvalue"
            .Datasource = dsTbl("subcat")
        End With
    End Sub
    Private Sub tooltipGcMain_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles tooltipGcMain.GetActiveObjectInfo
        If e.Info Is Nothing AndAlso e.SelectedControl Is gcMain Then
            Dim view As GridView = TryCast(gcMain.FocusedView, GridView)
            Dim info As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
            If info.InRowCell Then
                Dim MainMat As String = view.GetRowCellDisplayText(info.RowHandle, "MatName")
                Dim text As String = view.GetRowCellDisplayText(info.RowHandle, "ProductName")
                Dim cellKey As String = info.RowHandle.ToString() & " - " & info.Column.ToString()
                Dim Owing As String = PO.getOwing(view.GetRowCellValue(info.RowHandle, "MatID"),
                                                  view.GetRowCellValue(info.RowHandle, "Unit3_Name"))
                Dim Result As Func(Of String) = Function()
                                                    Dim SubMat As String = MainMat & " เบอร์ร่วมคือ : " & If(String.IsNullOrWhiteSpace(text), "ไม่มี", text)
                                                    SubMat += vbNewLine
                                                    Dim length = SubMat.Length
                                                    Do Until length = 0
                                                        SubMat += "-"
                                                        length -= 1
                                                    Loop
                                                    SubMat += vbNewLine
                                                    SubMat += Owing
                                                    Return SubMat
                                                End Function

                e.Info = New ToolTipControlInfo(cellKey, Result())
            End If
        End If
    End Sub
    Private Function IsHoliday(ByVal dt As DateTime) As Boolean
        SQL = "SELECT DISTINCT(ExportDate) FROM Service_Export_Stock"
        dsTbl("getdate")

        Dim ExportDate As New List(Of String)
        Dim ExportDay As New List(Of String)
        For Each item As DataRow In DS.Tables("getdate").Rows
            If item("ExportDate") IsNot DBNull.Value Then ExportDate.Add(convertDate(item("ExportDate")))
        Next

        If ExportDate.Contains(convertDate(dt)) Then Return True
        'If ExportDay.Contains(dt.DayOfWeek) Then Return True
        ''the specified date is a Saturday or Holiday
        'If dt.DayOfWeek = DayOfWeek.Saturday Or dt.DayOfWeek = DayOfWeek.Sunday Then
        '    Return True
        'End If


        ''New Year's Day
        'If (dt.Day = 1 And dt.Month = 1) Then Return True

        ''Inauguration Day
        'If dt.Year >= 1789 And (dt.Year - 1789) Mod 4 = 0 Then
        '    If dt.Day = 20 And dt.Month = 1 Then Return True
        'End If

        ''Independence Day
        'If dt.Day = 4 And dt.Month = 7 Then Return True
        ''Veterans Day
        'If dt.Day = 11 And dt.Month = 11 Then Return True
        ''Christmas
        'If dt.Day = 25 And dt.Month = 12 Then Return True
        Return False
    End Function
    Private Sub DateEdit_DrawItem(ByVal sender As Object,
  ByVal e As DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs)

        If Not e.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo Then Return
        'return if a given date is not a holiday
        'in this case the default drawing will be performed (e.Handled is false)
        If Not IsHoliday(e.Date) Then Return
        'highlight the selected date
        If e.Selected Then e.Graphics.FillRectangle(e.Style.GetBackBrush(e.Cache), e.Bounds)
        'the brush for painting days
        Dim brush As Brush = IIf(e.Inactive, Brushes.Blue, Brushes.Blue)
        'specify formatting attributes for drawing text
        Dim strFormat As StringFormat = New StringFormat
        strFormat.Alignment = StringAlignment.Center
        strFormat.LineAlignment = StringAlignment.Center
        'draw the day number
        e.Graphics.DrawString(e.Date.Day.ToString(), e.Style.Font, brush, e.Bounds, strFormat)
        'no default drawing is required
        e.Handled = True
    End Sub
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs, Optional RowHandle As Integer = -1) Handles gvAdjust.RowCellClick, gvMain.RowCellClick
        Dim GV As GridView = CType(sender, GridView)
        If GV.FocusedRowHandle < 0 Then Exit Sub
        With GV
            Dim getCellVal As Func(Of String, String) = Function(cells)
                                                            Return .GetRowCellValue(
                                                            If(RowHandle >= 0, RowHandle, e.RowHandle),
                                                            cells)
                                                        End Function
            Select Case .Name
                Case gvMain.Name
                    Dim MatID As String = getCellVal("MatID")
                    SQL = "SELECT * FROM vwAdjust"
                    SQL &= " WHERE MatID = '" & MatID & "'"
                    SQL &= " AND " & LocExpr(clbLoc.CheckedItems).Replace("OR", "OR MatID='" & MatID & "' AND")

                    If clbLoc.CheckedItems.Count <= 0 Then Exit Sub
                    gcAdjust.DataSource = dsTbl("AJStock")
                    If gvAdjust.RowCount > 0 Then
                        gridInfo = New GridCaption(gvAdjust)
                        With gridInfo
                            .SetCaption()
                            .SetFormat({"Unit1", "Unit3"})
                        End With
                        With gvAdjust
                            .Columns("MatName").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                            .BestFitColumns()
                        End With
                    End If

                Case gvAdjust.Name
                    Dim Unit1 As Double = getCellVal("Unit1")
                    Dim Unit3 As Double = getCellVal("Unit3")
                    Unit1 = Math.Round(Unit1, 2)
                    Unit3 = Math.Round(Unit3, 2)
                    lbMatName.Text = getCellVal("MatName")
                    lbTagID.Text = getCellVal("TagID")
                    lbRatio.Text = getCellVal("Ratio")
                    lbQtyPerUnit.Text = getCellVal("QtyPerUnit")


                    lbUnit1.Text = Unit1
                    lbUnit3.Text = Unit3
                    txtUnit1.EditValue = Unit1
                    txtUnit2.EditValue = Unit3

                    lbUnit1_Name.Text = getCellVal("Unit1_Name")
                    lbUnit3_Name.Text = getCellVal("Unit3_Name")
                    LocID = getCellVal("LocID")
            End Select
        End With
    End Sub
    Private Sub chkDay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim clb As CheckedListBox = CType(sender, CheckedListBox)

        loadSuccess = True
        If defH = clb.Height Then
            sizeH = 0
            For i = 0 To days.Count - 1
                sizeH += 20
            Next
            clb.Size = New System.Drawing.Size(clb.Width, sizeH)
        End If
    End Sub
    Private Sub chkDay_LostFocus(sender As Object, e As EventArgs)
        loadSuccess = True
        Dim clb As CheckedListBox = CType(sender, CheckedListBox)
        clb.Size = New System.Drawing.Size(clb.Width, defH)
    End Sub
    Private Sub btnAdJust_Click(sender As Object, e As EventArgs) Handles btnAdJust.Click
        If chkInput(grpAdjust) = False Then
            MessageBox.Show("Check Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim Stat As Func(Of Integer) = Function()
                                           If cbStat.Text = "คงเหลือ" Then
                                               Return 1
                                           ElseIf cbStat.Text = "หมดแล้ว" Then
                                               Return 2
                                           Else
                                               Return 0
                                           End If
                                       End Function
        SQL = "UPDATE tbStock"
        SQL &= " SET Unit1='" & CDbl(lbU1.Text) & "'"
        SQL &= " ,Unit3='" & CDbl(lbU2.Text) & "'"
        SQL &= " ,Stat='" & Stat() & "'"
        SQL &= " WHERE TagID='" & lbTagID.Text & "'"
        SQL &= " AND LocID='" & LocID & "'"
        dsTbl("adjust")
        BindInfo.Excute()
        gvMain.ExpandAllGroups()
        gvRowClick(gvMain, Nothing, gvMain.FocusedRowHandle)

    End Sub
    Private Sub txtUnit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnit1.EditValueChanged, txtUnit2.EditValueChanged, txtUnit3.EditValueChanged
        Dim spiCtr As DevExpress.XtraEditors.SpinEdit = CType(sender, DevExpress.XtraEditors.SpinEdit)
        Dim Unit1, Unit2, Unit3 As Double
        lbQtyPerUnit.Text = If(lbQtyPerUnit.Text = 0, 1, lbQtyPerUnit.Text)
        Unit1 = txtUnit1.EditValue
        Unit2 = txtUnit2.EditValue
        Unit3 = txtUnit3.EditValue

        If spiCtr.Name = txtUnit2.Name Then
            Unit3 += (Unit2 * (lbQtyPerUnit.Text * 12))
        ElseIf spiCtr.Name = txtUnit1.Name Then
            Unit3 += (Unit1 * ((lbQtyPerUnit.Text * 12) * lbRatio.Text))
        End If
        lbU1.Text = CDbl((Unit3 / (lbQtyPerUnit.Text * 12)) / lbRatio.Text).ToString("#,0.0")
        lbU2.Text = CDbl(Unit3 / (lbQtyPerUnit.Text * 12)).ToString("#,0.0")
        lbU3.Text = CDbl(Unit3).ToString("#,0.0")

    End Sub
    Private Sub clbLoc_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbLoc.ItemCheck, clbSubCat.ItemCheck
        clbInfo.SelectAllCheck(sender, e)
    End Sub
    Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvMain.CustomDrawCell
        If e.CellValue Is Nothing Then Exit Sub
        Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
        Dim infox As ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, ViewInfo.TextEditViewInfo)

        If e.Column.FieldName = "PoStat" Then
            e.DisplayText = String.Empty
            If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "PoStat" Then
                If CType(sender, GridView).GetRowCellValue(e.RowHandle, "AllowColor") = 0 Then
                    infox.ContextImage = My.Resources.opportunities_16x16
                ElseIf e.CellValue = "1" Then
                    infox.ContextImage = Nothing
                ElseIf e.CellValue = "2" Then
                    infox.ContextImage = My.Resources.postat2_16x16
                ElseIf e.CellValue = "0" Then
                    infox.ContextImage = My.Resources.sales_16x16
                End If
                infox.CalcViewInfo()
            End If
        End If


        If e.Column.FieldName = "qcnote" Then
            e.DisplayText = "เป้าQC"
            If e.RowHandle <> GridControl.NewItemRowHandle AndAlso e.Column.FieldName = "qcnote" Then
                'Dim gcix As GridCellInfo = TryCast(e.Cell, GridCellInfo)
                'Dim infox As ViewInfo.TextEditViewInfo = TryCast(gcix.ViewInfo, ViewInfo.TextEditViewInfo)
                infox.ContextImage = My.Resources.qcnote
                infox.ContextImageAlignment = ContextImageAlignment.Far
                infox.CalcViewInfo()
            End If
        End If
        'Dim colList As String() = {"JL", "KIWI", "JLK"}
        'If colList.Contains(e.Column.FieldName) Then
        '    e.DisplayText = String.Format("{0} {1}", e.CellValue, gvMain.GetRowCellValue(e.RowHandle, "Unit3_Name"))
        'End If
    End Sub
    Private Sub cbStat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStat.SelectedIndexChanged
        If cbStat.SelectedIndex <> 1 Then
            lbU1.Text = 0
            lbU2.Text = 0
            lbU3.Text = 0
        End If
    End Sub
End Class