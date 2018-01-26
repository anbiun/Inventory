Imports DevExpress.Utils
Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel

Public Class FrmStock
    Dim LocID As String
    Dim bw As BackgroundWorker = New BackgroundWorker
    Dim frmProg As New dlgProgress
    Dim SavePath As String
    Dim GvSource As New GridView
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        ' Add any initialization after the InitializeComponent() call.
    End Sub
#Region "Code Side"
    Private Sub getStockSP()

        With BindInfo
            .Name = "stock"
            .LocCheked = clbLoc.CheckedItems
            .CatChecked = clbSubCat.CheckedItems
            .Excute()
            gcMain.DataSource = .Result
        End With
        gvMain.PopulateColumns()
        gvMain.BestFitColumns()
        GvFormat()
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
                .Add("C4", "Unit1")
                .Add("D4", "Unit1_Name")
                .Add("E4", "Unit3")
                .Add("F4", "Unit3_Name")
                .Add("G4", "Dozen")
                .Add("H4", "โหล")
                .Add("I4", "Warn")
                .Add("J4", "เดือน")
                .Add("K4", "JL")
                .Add("L4", "KIWI")
                .Add("M4", "JLK")
            End With
            Try
                Dim strFileName As String = Application.StartupPath + "\template_stock.xls"
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

                    For gvRow As Integer = 0 To GvSource.RowCount - 1
                        'Cell Colour
                        Dim warn As Double = If(String.IsNullOrWhiteSpace(gvMain.GetRowCellDisplayText(gvRow, "Warn")), 0, gvMain.GetRowCellDisplayText(gvRow, "Warn"))
                        Dim warn_month As Double = If(String.IsNullOrWhiteSpace(gvMain.GetRowCellDisplayText(gvRow, "Warn_Month")), 0, gvMain.GetRowCellDisplayText(gvRow, "Warn_Month"))
                        Dim CellRange As String = "A" & 4 + gvRow & ":" & "M" & 4 + gvRow
                        With xlWorkSheet
                            If warn >= 2 Then
                                .Cells.Range(CellRange).Style = Stock_Normal
                            ElseIf warn <= 1 Then
                                .Cells.Range(CellRange).Style = Stock_Danger
                            Else
                                .Cells.Range(CellRange).Style = Stock_Warning
                            End If
                        End With

                        'end

                        For i As Integer = 0 To Cols.Count - 1
                            Dim Col As String = String.Empty
                            Dim ColRow As Integer = 0
                            Dim Chars() As Char = Cols.Keys(i).ToCharArray()
                            For Each ch As Char In Chars
                                If Char.IsDigit(ch) Then
                                    ColRow = ch.ToString
                                Else
                                    Col = ch
                                End If
                            Next

                            xlRange = CType(xlWorkSheet.Cells.Range(Col & ColRow + gvRow), Excel.Range)
                            Try
                                xlRange.Value2 = GvSource.GetRowCellDisplayText(gvRow, Cols.Values(i))
                            Catch ex As Exception
                                xlRange.Value2 = Cols.Values(i)
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
        Dim addMontList As Func(Of String) = Function()
                                                 Dim monthname As String
                                                 Dim fisrtMontofyear As Date = "01/01/" & (Today.ToString("yyyy"))
                                                 For i = 0 To 12 - 1
                                                     monthname = DateAdd(DateInterval.Month, i, fisrtMontofyear).ToString("MMMM")
                                                     List_Caption.Add(monthname, monthname)
                                                 Next
                                                 Return Nothing
                                             End Function
        With List_Caption
            .Clear()
            .Add("SubCatName", "ประเภท")
            .Add("MatName", "ชื่อวัสดุ")
            .Add("Unit1", "จำนวน")
            .Add("Unit1_Name", " ")
            .Add("Unit3", "ปริมาณทั้งหมด")
            .Add("Unit3_Name", " ")
            .Add("Dozen", "จำนวนโหล")
            .Add("Warn", "ใช้ได้อีก")
            .Add("Warn_Name", " ")
            .Add("JL", "JL")
            .Add("JLK", "JLK")
            .Add("KIWI", "KW")
            .Add("qcnote", " ")
        End With
        addMontList()
        Grid_Caption(gvMain)

        With gvMain
            .Columns("SubCatName").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            .Columns("MatName").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Dim ColList As String() = {"Unit1", "Unit3", "Dozen"}
            For Each items As String In ColList
                .Columns(items).DisplayFormat.FormatType = FormatType.Numeric
                .Columns(items).DisplayFormat.FormatString = "#,0.0"
            Next
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
        With clbLoc
            .DataSource = dsTbl("loc")
            .DisplayMember = "LocName"
            .ValueMember = "LocID"
            clbLoc.CheckAll()
        End With

        GroupControl3.Text += " " & _XLSGetHeader()
        GvFormat()

        loadSuccess = True
    End Sub
    Private Sub btnExPortExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportXLS()
    End Sub
    Public Sub GVRowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvMain.RowStyle
        Dim View As GridView = sender
        Dim Warn = View.GetRowCellValue(e.RowHandle, "Warn")
        Dim Warn_Month = View.GetRowCellValue(e.RowHandle, "Warn_Month")
        If (e.RowHandle >= 0) Then
            If IsDBNull(Warn) Then
                Warn = 0
            Else
                Warn = If(String.IsNullOrWhiteSpace(Warn), 0, CDbl(Warn))
            End If
            If IsDBNull(Warn_Month) Then
                Warn_Month = 0
            End If

            If Warn <= 1 Then
                e.Appearance.BackColor = Color.IndianRed
                e.Appearance.BackColor2 = Color.WhiteSmoke
            ElseIf Warn <= Warn_Month Then
                e.Appearance.BackColor = Color.LightGoldenrodYellow
                e.Appearance.BackColor2 = Color.LightYellow
            Else
                e.Appearance.BackColor = Nothing
                e.Appearance.BackColor2 = Nothing
            End If
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        getStockSP()
        'getOldStockSP()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        gcMain.ShowRibbonPrintPreview()
    End Sub
    Private Sub slCat_EditValueChanged(sender As Object, e As EventArgs) Handles slCat.EditValueChanged
        If loadSuccess = False Then Exit Sub
        SQL = "SELECT CatID+SubCatID AS IDvalue,SubCatName FROM tbSubcategory WHERE CatID='" & slClick(slCat, "CatID") & "'"
        With clbSubCat
            .DataSource = dsTbl("subcat")
            .DisplayMember = "SubCatName"
            .ValueMember = "IDvalue"
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
                e.Info = New DevExpress.Utils.ToolTipControlInfo(cellKey, MainMat & " เบอร์ร่วมคือ : " & If(String.IsNullOrWhiteSpace(text), "ไม่มี", text))
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

#Region "Temp"
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs) Handles gvMain.RowCellClick, gvAdjust.RowCellClick
        Dim GV As GridView = CType(sender, GridView)
        If GV.FocusedRowHandle < 0 Then Exit Sub
        With GV
            Dim getCellVal As Func(Of String, String) = Function(cells)
                                                            Return .GetRowCellValue(e.RowHandle, cells)
                                                        End Function
            Select Case .Name
                Case gvMain.Name
                    Dim MatID As String = getCellVal("MatID")
                    SQL = "SELECT * FROM vwAdjust"
                    SQL &= " WHERE MatID = '" & MatID & "'"
                    SQL &= " AND " & LocExpr(clbLoc.CheckedItems).Replace("OR", "OR MatID='" & MatID & "' AND")
                    Dim tmpSq As String = SQL
                    If clbLoc.CheckedItems.Count <= 0 Then Exit Sub
                    gcAdjust.DataSource = dsTbl("AJStock")
                    If gvAdjust.RowCount > 0 Then
                        With List_Caption
                            .Clear()
                            .Add("MatName", "วัสดุ")
                            .Add("Unit1", "จำนวน")
                            .Add("Unit3", "เป็นปริมาณ")
                            .Add("LocName", "สถานที่")
                            .Add("Unit1_Name", " ")
                            .Add("Unit3_Name", " ")
                            .Add("TagID", "TagID")
                            .Add("Stat", "สถานะ")
                        End With
                        Grid_Caption(gvAdjust)
                        With gvAdjust
                            .Columns("MatName").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                            Dim ColList As String() = {"Unit1", "Unit3"}
                            For Each items As String In ColList
                                .Columns(items).DisplayFormat.FormatType = FormatType.Numeric
                                .Columns(items).DisplayFormat.FormatString = "#,0.0"
                            Next
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

                    lbUnit1.Text = Unit1
                    lbUnit3.Text = Unit3
                    txtUnit1.EditValue = Unit1
                    txtUnit3.EditValue = Unit3

                    lbUnit1_Name.Text = getCellVal("Unit1_Name")
                    lbUnit3_Name.Text = getCellVal("Unit3_Name")
                    LocID = getCellVal("LocID")
            End Select
        End With

    End Sub
    Private Function QryForExport() As DataTable
        'ข้อมูลสตอคจากคลังอื่น
        'Dim LocExpr_newFormat As String = LocExpr
        'LocExpr_newFormat = LocExpr_newFormat.Replace("LocID", "L.LocID")
        SQL = " SELECT L.LocName, M.MatName,"
        SQL &= " SUM(S.Unit1) Unit1,U1.UnitName Unit1_Name,"
        SQL &= " Sum(S.Unit3) Unit3,U3.UnitName Unit3_Name "
        SQL &= " FROM tbStock S "
        SQL &= " INNER JOIN tbMat M ON S.MatID = M.MatID "
        SQL &= " INNER JOIN tbLocation L ON S.LocID = L.LocID "
        SQL &= " INNER JOIN tbSubCategory SC ON M.SubCatID = SC.SubCatID AND M.CatID = SC.CatID "
        SQL &= " INNER JOIN tbUnit U1 ON U1.UnitID = S.Unit1_ID "
        SQL &= " INNER JOIN tbUnit U3 ON U3.UnitID = SC.Unit3_ID "

        'SQL &= " " + LocExpr_newFormat + ""
        SQL &= " GROUP BY M.MatName,U1.UnitName,U3.UnitName,L.LocName"
        SQL &= " ORDER BY MatName DESC"
        Dim dbg As String = SQL
        Return dsTbl("qryforexport")
    End Function
#End Region
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

    Private Sub rdDate_CheckedChanged(sender As Object, e As EventArgs)
        'Dim chk As String() = {"5", "10", "11"}
        'If rdDate.Checked = True Then
        '    If chkDate.Contains(chk) Then
        '        chkDate.Items(1)
        '    End If
        '    chkDate.Enabled = True
        '    chkDays.Enabled = False
        'Else
        '    chkDays.Enabled = True
        '    chkDate.Enabled = False
        'End If
    End Sub

    Private Sub btnAdJust_Click(sender As Object, e As EventArgs) Handles btnAdJust.Click
        If chkInput(grpAdjust) = False Then
            MessageBox.Show("Check Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim Stat As Integer = If(cbStat.Text = "คงเหลือ", 1, 0)
        SQL = "UPDATE tbStock"
        SQL &= " SET Unit1='" & txtUnit1.EditValue & "'"
        SQL &= " ,Unit3='" & txtUnit3.EditValue & "'"
        SQL &= " ,Stat='" & Stat & "'"
        SQL &= " WHERE TagID='" & lbTagID.Text & "'"
        SQL &= " AND LocID='" & LocID & "'"
        dsTbl("adjust")
        BindInfo.Excute()
    End Sub

    Private Sub txtUnit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtUnit1.EditValueChanged
        txtUnit3.EditValue = CDbl(txtUnit1.EditValue * lbRatio.Text)
    End Sub
    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)

    End Sub
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            'Me.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            ''Me.Text = "Error: " & e.Error.Message
        Else
            'MsgBox("Done!")

        End If
    End Sub
    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        frmProg.SetProgress(e.ProgressPercentage)
        'dlgPro.Progressbar.Text = e.ProgressPercentage.ToString & " / " & Gridsource.RowCount - 1
    End Sub
End Class