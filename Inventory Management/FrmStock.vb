Imports DevExpress.Utils
Imports ConDB.Main
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class FrmStock
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
        GvFormat(gvMain)
    End Sub
    Private Sub getOldStockSP()
        If loadSuccess = False Then Exit Sub
        Dim DTResult As New DataTable

        'เลือก Location
        Dim LocSelect As New List(Of String)
        LocExpr = "WHERE"
        For Each items As DataRowView In clbLoc.CheckedItems
            LocSelect.Add(items.Row(0))
        Next

        For Each l In LocSelect
            If l IsNot LocSelect.Last Then
                LocExpr += " LocID = '" + l + "' OR" + ""
            Else
                LocExpr += " LocID = '" + l + "'"
            End If
        Next

        'เลือกประเภท
        Dim CatSelect As New List(Of String)
        For Each items As DataRowView In clbSubCat.CheckedItems
            CatSelect.Add(items.Row(0))
        Next

        For Each l In CatSelect
            Dim Expr As String = LocExpr.Replace("LocID", "CatID+SubCatID='" & l & "' AND LocID")

            If CatSelect.Count = 1 Then
                ParamList.Clear()
                ParamList.Add(New SqlParameter("@Expr", Expr))
                DTResult = CallSP("GetOldStock", ParamList)
            Else
                ParamList.Clear()
                ParamList.Add(New SqlParameter("@Expr", Expr))
                If DTResult.Rows.Count = 0 Then
                    DTResult = CallSP("GetOldStock", ParamList)
                Else
                    For Each item As DataRow In CallSP("GetOldStock", ParamList).Rows
                        DTResult.ImportRow(item)
                    Next
                End If
            End If
        Next


        gvOldStock.Columns.Clear()
        'gcOldStock.DataSource = Binding.GetStock
        gvOldStock.PopulateColumns()
        GvFormat(gvOldStock)
    End Sub
    Private Sub ExportXLS()
        If gvMain.RowCount < 1 Then Exit Sub
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel 97-2003 (*.xls) |*.xls"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then

            Dim GvSource = gvMain
            Dim Cols As New Dictionary(Of String, String)
            With Cols
                .Add("A4", "MatName")
                .Add("B4", "Unit1")
                .Add("C4", "Unit1_Name")
                .Add("D4", "Unit3")
                .Add("E4", "Unit3_Name")
                .Add("F4", "Dozen")
                .Add("G4", "โหล")
                .Add("H4", "Warn")
                .Add("I4", "เดือน")
                .Add("J4", "JL")
                .Add("K4", "KIWI")
                .Add("L4", "JLK")
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
                '.style.Font.Bold = False

                Stock_Normal.Font.Size = 12
                Stock_Warning.Font.Size = 12
                Stock_Danger.Font.Size = 12
                Stock_Warning.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGoldenrodYellow)
                Stock_Danger.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.IndianRed)

                Try
                    xlApp.ScreenUpdating = False
                    xlRange = CType(xlWorkSheet.Cells.Range("A1"), Excel.Range)
                    xlRange.Value2 = "สต๊อกวัสดุยอด ณ วันที่ " & _XLSGetHeader()

                    For gvRow As Integer = 0 To GvSource.RowCount - 1
                        'Cell Colour
                        Dim warn As Double = If(String.IsNullOrWhiteSpace(gvMain.GetRowCellDisplayText(gvRow, "Warn")), 0, gvMain.GetRowCellDisplayText(gvRow, "Warn"))
                        Dim warn_month As Double = If(String.IsNullOrWhiteSpace(gvMain.GetRowCellDisplayText(gvRow, "Warn_Month")), 0, gvMain.GetRowCellDisplayText(gvRow, "Warn_Month"))
                        Dim CellRange As String = "A" & 4 + gvRow & ":" & "L" & 4 + gvRow
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
                    Next

                    xlRange = CType(xlWorkSheet.Cells.Range("A1:C1,E1:L1"), Excel.Range)
                    xlRange.EntireColumn.AutoFit()
                    xlApp.ScreenUpdating = True
                    xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
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
                End Try
            Catch exl As System.Exception
                MessageBox.Show(exl.Message &
                    vbNewLine & "\n\n=======   ERROR TO ACESS EXCEL:  ======\n\n" & vbNewLine &
                    exl.StackTrace)
            End Try
            If MessageBox.Show("นำข้อมูลออก Excel แล้ว " & saveFileDialog1.FileName & vbNewLine &
                                                    "ต้องการเปิดไฟล์หรือไม่ ?", "นำออกข้อมูลสำเร็จ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim Pinfo As New ProcessStartInfo
                Pinfo.UseShellExecute = False
                Pinfo.FileName = "EXCEL.EXE"
                Pinfo.Arguments = saveFileDialog1.FileName
                Process.Start("EXCEL.EXE", """" + saveFileDialog1.FileName + """")
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
    Private Sub GvFormat(gv As GridView)
        If gv.RowCount <= 0 Then Exit Sub
        With gv
            .Columns("SubCatName").Caption = "ประเภท"
            .Columns("SubCatName").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            .Columns("MatName").Caption = "ชื่อวัสดุ"
            .Columns("MatName").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            .Columns("Unit1").Caption = "จำนวน"
            .Columns("Unit1_Name").Caption = " "
            .Columns("Unit3").Caption = "ปริมาณทั้งหมด"
            .Columns("Unit3_Name").Caption = " "
            .Columns("MatID").Visible = False
            Dim colList() As String = {"Unit1", "Unit3"}
            For Each colname As String In colList
                .Columns(colname).DisplayFormat.FormatType = FormatType.Numeric
                .Columns(colname).DisplayFormat.FormatString = "#,0.0"
            Next

            If .Name = gvMain.Name Then

                .Columns("Dozen").Caption = "จำนวนโหล"
                .Columns("Dozen").DisplayFormat.FormatType = FormatType.Numeric
                .Columns("Dozen").DisplayFormat.FormatString = "#,0"
                .Columns("Warn").DisplayFormat.FormatType = FormatType.Numeric
                .Columns("Warn").DisplayFormat.FormatString = "#,0.0"
                .Columns("Warn").Caption = "ใช้ได้อีก"
                .Columns("Warn_Name").Caption = " "
                .Columns("Warn_Month").Visible = False
                .Columns("SubMatName").Visible = False

                'tooltip set
                gcMain.ToolTipController = tooltipGcMain
            ElseIf .Name = gvOldStock.Name Then
                .Columns("Unit1_Diff").Caption = "ผลต่าง (จำนวน)"
                .Columns("Unit3_Diff").Caption = "ผลต่าง (ปริมาณรวม)"
                .Columns("Unit1_Diff").DisplayFormat.FormatType = FormatType.Numeric
                .Columns("Unit3_Diff").DisplayFormat.FormatType = FormatType.Numeric
                .Columns("Unit1_Diff").DisplayFormat.FormatString = "#,0.0"
                .Columns("Unit3_Diff").DisplayFormat.FormatString = "#,0.0"
                .Columns("Unit1_DiffName").Caption = " "
                .Columns("Unit3_DiffName").Caption = " "
            End If

        End With
        gv.BestFitColumns()
        gv.OptionsView.ShowAutoFilterRow = True
    End Sub
#End Region
    Dim LocSelect As String
    Dim LocExpr As String
    Dim _XLSGetHeader As Func(Of String) = Function()
                                               SQL = "SELECT MAX(RequestDate) FROM tbRequisition"
                                               dsTbl("get")
                                               Return DS.Tables("get")(0)(0)
                                           End Function
    Dim days As String() = {"จันทร์", "อังคาร", "พุทธ", "พฤหัสบดี", "ศุกร์", "เสาร์", "อาทิตย์"}
    Dim defH As Integer = 25
    Dim sizeH As Integer = 0

    Private Sub GVRow_Click(sender As Object, e As RowCellClickEventArgs) Handles gvMain.RowCellClick, gvOldStock.RowCellClick
        If e.RowHandle >= 0 Then
            Dim gvSrc As GridView = If(CType(sender, GridView).Name = gvMain.Name, gvMain, gvOldStock)
            Dim gvDest As GridView = If(CType(sender, GridView).Name = gvMain.Name, gvOldStock, gvMain)

            Dim mainID As String = gvSrc.GetRowCellValue(e.RowHandle, "MatID")
            For i As Integer = 0 To gvDest.RowCount - 1
                If gvDest.GetRowCellValue(i, "MatID") = mainID Then
                    gvDest.FocusedRowHandle = i
                    Exit For
                End If
            Next

        End If
    End Sub
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
        GvFormat(gvMain)
        chkDays.Items.Clear()
        For Each item As String In days
            chkDays.Items.Add(item)
        Next
        For i As Integer = 1 To 31
            chkDate.Items.Add(i)
        Next
        rdDate.Checked = True

        chkDays.Height = defH
        chkDate.Height = defH
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
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, SimpleButton2.Click, SimpleButton1.Click
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
                Dim text As String = view.GetRowCellDisplayText(info.RowHandle, "SubMatName")
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
  ByVal e As DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs) _
  Handles deOldStock.DrawItem
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
    Private Sub gvRowClick(sender As Object, e As RowCellClickEventArgs)
        If gvMain.FocusedRowHandle >= 0 Then
            Dim MatID As String = gvMain.GetRowCellValue(e.RowHandle, "MatID")
            Dim LocExpr_newFormat As String = Nothing
            LocExpr_newFormat = LocExpr.Replace("OR", "AND S.MatID='" & MatID & "' OR")
            LocExpr_newFormat = LocExpr_newFormat.Replace("LocID", "L.LocID")
            SQL = " SELECT L.LocName, M.MatName,"
            SQL &= " SUM(S.Unit1) Unit1,U1.UnitName Unit1_Name,"
            SQL &= " Sum(S.Unit3) Unit3,U3.UnitName Unit3_Name "
            SQL &= " FROM tbStock S "
            SQL &= " INNER JOIN tbMat M ON S.MatID = M.MatID "
            SQL &= " INNER JOIN tbLocation L ON S.LocID = L.LocID "
            SQL &= " INNER JOIN tbSubCategory SC ON M.SubCatID = SC.SubCatID AND M.CatID = SC.CatID "
            SQL &= " INNER JOIN tbUnit U1 ON U1.UnitID = S.Unit1_ID "
            SQL &= " INNER JOIN tbUnit U3 ON U3.UnitID = SC.Unit3_ID "
            SQL &= " " + LocExpr_newFormat + "AND S.MatID = '" + MatID + "'"
            SQL &= " GROUP BY M.MatName,U1.UnitName,U3.UnitName,L.LocName"
            SQL &= " ORDER BY MatName DESC"
            Dim tmpSq As String = SQL

            gcOldStock.DataSource = dsTbl("substock")

            If gvOldStock.RowCount > 0 Then
                With gvOldStock
                    .Columns("MatName").Caption = "วัสดุ"
                    .Columns("Unit1").Caption = "จำนวน"
                    .Columns("Unit3").Caption = "เป็นปริมาณ"
                    .Columns("LocName").Caption = "สถานที่"
                    .Columns("Unit1_Name").Caption = " "
                    .Columns("Unit3_Name").Caption = " "
                    .Columns("MatName").BestFit()
                    .Columns("LocName").BestFit()
                End With
            End If
        End If
    End Sub
    Private Sub GetStock()
        Dim chkItem As New List(Of String)
        LocExpr = "WHERE"
        For Each items As DataRowView In clbLoc.CheckedItems
            chkItem.Add(items.Row(0))
        Next

        For Each l In chkItem
            If l IsNot chkItem.Last Then
                'LocExpr += " LocID = '" + l + "' AND CatID='" + slClick(slSubCat, "CatID") + "'"
                'LocExpr += " AND SubCatID='" + slClick(slSubCat, "SubCatID") + "' OR"
            Else
                LocExpr += " LocID = '" + l + "'"
                'LocExpr += " AND SubCatID='" + slClick(slSubCat, "SubCatID") + "'"
            End If
        Next
        SQL = "SELECT * FROM vwStock "
        SQL &= LocExpr

        Dim dtGetStock, dtResult As New DataTable
        gcMain.DataSource = dsTbl("getstock")
        dtGetStock = DS.Tables("getstock").Copy
        dtResult = dtGetStock.Copy
        dtResult.Clear()

        Dim dblUnit1_Sum As Double
        Dim MatID, MatName As String
        Dim QtyPerUnit As Double
        Dim QtyOfUsing As Integer = 40
        Dim Lacking As Double

        Try
            MatID = dtGetStock(0)("MatID")
        Catch ex As Exception
            Exit Sub
        End Try

        QtyPerUnit = dtGetStock(0)("QtyPerUnit")
        MatName = dtGetStock(0)("MatName")

        dblUnit1_Sum = dtGetStock.Compute("Sum(Unit1)", "MatID='" & MatID & "' AND QtyPerUnit='" & QtyPerUnit & "'")
        QtyOfUsing -= dblUnit1_Sum
        Lacking = dblUnit1_Sum * QtyPerUnit

        Dim dr As DataRow
        dr = dtResult.NewRow
        dr("MatName") = MatName
        dr("Unit1") = dblUnit1_Sum
        dr("QtyPerUnit") = QtyPerUnit
        dr("QtyOfUsing") = Lacking
        dtResult.Rows.Add(dr)
        For i As Integer = 0 To dtGetStock.Rows.Count - 1
            If MatID = dtGetStock(i)("MatID") And QtyPerUnit <> dtGetStock(i)("QtyPerUnit") Then
                MatID = dtGetStock(i)("MatID")
                QtyPerUnit = dtGetStock(i)("QtyPerUnit")
                MatName = dtGetStock(i)("MatName")

                dblUnit1_Sum = dtGetStock.Compute("Sum(Unit1)", "MatID='" & MatID & "' AND QtyPerUnit='" & QtyPerUnit & "'")
                QtyOfUsing -= dblUnit1_Sum
                Lacking = dblUnit1_Sum * QtyPerUnit

                dr = dtResult.NewRow
                dr("MatName") = MatName
                dr("Unit1") = dblUnit1_Sum
                dr("QtyPerUnit") = QtyPerUnit
                dr("QtyOfUsing") = Lacking
                dtResult.Rows.Add(dr)

            ElseIf MatID <> dtGetStock(i)("MatID") Then
                MatID = dtGetStock(i)("MatID")
                QtyPerUnit = dtGetStock(i)("QtyPerUnit")
                MatName = dtGetStock(i)("MatName")

                dblUnit1_Sum = dtGetStock.Compute("Sum(Unit1)", "MatID='" & MatID & "' AND QtyPerUnit='" & QtyPerUnit & "'")
                QtyOfUsing -= dblUnit1_Sum
                Lacking = dblUnit1_Sum * QtyPerUnit

                dr = dtResult.NewRow
                dr("MatName") = MatName
                dr("Unit1") = dblUnit1_Sum
                dr("QtyPerUnit") = QtyPerUnit
                dr("QtyOfUsing") = Lacking
                dtResult.Rows.Add(dr)
            End If

        Next

        gcOldStock.DataSource = dtResult
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
    Private Sub chkDay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkDays.MouseMove, chkDate.MouseMove
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

    Private Sub chkDay_LostFocus(sender As Object, e As EventArgs) Handles chkDays.LostFocus, chkDate.LostFocus
        loadSuccess = True
        Dim clb As CheckedListBox = CType(sender, CheckedListBox)
        clb.Size = New System.Drawing.Size(clb.Width, defH)
    End Sub

    Private Sub GroupControl3_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupControl3.MouseMove, gcMain.MouseMove
        chkDay_ExportSettingLeave()
    End Sub

    Private Sub rdDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdDate.CheckedChanged
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
    Sub chkDay_ExportSettingLeave()
        chkDays.Height = defH
        chkDate.Height = defH
    End Sub
End Class