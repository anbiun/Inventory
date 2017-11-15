Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports DevExpress.XtraGrid.Columns
Public Class ExcelExport
    Public TemplateFile As String
    Public Datasource As New DataTable
    Public Gridsource As New DevExpress.XtraGrid.Views.Grid.GridView
    Public Columns As New Dictionary(Of String, String)
    Private DlgPath As String
    Public Table_Import As New DataTable
    Private _Filter As New String(String.Empty)
    Enum FilterOption
        Excel_97
        Excel_2017
    End Enum
    Public WriteOnly Property FilterSet As FilterOption
        Set(value As FilterOption)
            If value = FilterOption.Excel_97 Then
                _Filter = "Excel 97-2013 (*.xls)|*.xls"
            ElseIf value = FilterOption.Excel_2017 Then
                _Filter = "Excel 2017 (*.xlsx)|*.xlsx"
            End If
        End Set
    End Property
    Public ReadOnly Property FilterRead As String
        Get
            Return _Filter
        End Get
    End Property
    Public Property SavePath
        Get
            Return DlgPath
        End Get
        Set(value)
            DlgPath = value
        End Set
    End Property
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
    Private Sub CellColour()
        'For gvRow As Integer = 0 To Gridsource.RowCount - 1
        '    For Each item As DataRow In Datasource.Rows
        '        If item("MatName") = Gridsource.GetRowCellDisplayText(gvRow, "MatName") _
        '            AndAlso item("LocName") = "เจแอลคิทเช่นแวร์" Then
        '            xlRange = CType(xlWorkSheet.Cells.Range("K" & gvRow + 2), Excel.Range)
        '            xlRange.Value2 = item("Unit1")
        '        ElseIf item("MatName") = Gridsource.GetRowCellDisplayText(gvRow, "MatName") _
        '            AndAlso item("LocName") = "เจแอล" Then
        '            xlRange = CType(xlWorkSheet.Cells.Range("J" & gvRow + 2), Excel.Range)
        '            xlRange.Value2 = item("Unit1")
        '        ElseIf item("MatName") = Gridsource.GetRowCellDisplayText(gvRow, "MatName") _
        '        AndAlso item("LocName") = "กีวี่" Then
        '            xlRange = CType(xlWorkSheet.Cells.Range("L" & gvRow + 2), Excel.Range)
        '            xlRange.Value2 = item("Unit1")
        '        End If
        '    Next

        '    'Cell Colour
        '    Dim warn As Double = If(String.IsNullOrWhiteSpace(Gridsource.GetRowCellDisplayText(gvRow, "Warn")), 0, Gridsource.GetRowCellDisplayText(gvRow, "Warn"))
        '    Dim warn_month As Double = If(String.IsNullOrWhiteSpace(Gridsource.GetRowCellDisplayText(gvRow, "Warn_Month")), 0, Gridsource.GetRowCellDisplayText(gvRow, "Warn_Month"))

        '    If warn > warn_month Then
        '        xlWorkSheet.Cells.Range("A" & gvRow + 2 & ":L" & gvRow + 2).Style = Stock_Normal
        '    Else
        '        xlWorkSheet.Cells.Range("A" & gvRow + 2 & ":L" & gvRow + 2).Style = Stock_Warning
        '    End If
        'end
    End Sub
    Public Function Export() As Boolean
        Dim dlgExport As New SaveFileDialog
        With dlgExport
            .Filter = FilterRead
            .Title = "นำข้อมูลออก"
            .ShowDialog()
        End With
        If dlgExport.FileName <> "" Then
            SavePath = dlgExport.FileName
            Try
                'Excel Variable
                Dim xlApp As Excel.Application = New Excel.ApplicationClass()
                '
                Dim xlWorkBook As Excel.Workbook = Nothing
                Dim xlWorkSheet As Excel.Worksheet = Nothing
                Dim xlRange As Excel.Range = Nothing
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim TemplatePath As String = Path.Combine(Application.StartupPath, TemplateFile)

                '' * to open existing file *
                xlWorkBook = xlApp.Workbooks.Open(TemplatePath, misValue, misValue, misValue _
                                                  , misValue, misValue, misValue, misValue _
                                                 , misValue, misValue, misValue, misValue _
                                                , misValue, misValue, misValue)

                '' * to add the new one *
                'xlWorkBook = xlApp.Workbooks.Add()
                xlWorkBook = xlApp.ActiveWorkbook
                xlWorkSheet = CType(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)
                xlApp.ScreenUpdating = False
                xlApp.DisplayAlerts = False

                Dim Stock_Normal As Excel.Style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add("Stock_Normal")
                Dim Stock_Warning As Excel.Style = xlWorkBook.Application.ActiveWorkbook.Styles.Add("Stock_Warning")
                'style.Font.Bold = False
                Stock_Normal.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSeaGreen)
                Stock_Warning.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)

                Try
                    xlApp.ScreenUpdating = False
                    For gvRow As Integer = 0 To Gridsource.RowCount - 1
                        For i As Integer = 0 To Columns.Count - 1
                            xlRange = CType(xlWorkSheet.Cells.Range(Columns.Keys(i) & gvRow + 2), Excel.Range)
                            xlRange.Value2 = Gridsource.GetRowCellDisplayText(gvRow, Columns.Values(i))
                        Next
                    Next

                    'xlWorkSheet.Columns.EntireColumn.AutoFit()
                    'xlRange = CType(xlWorkSheet.Cells.Range("A1:C1,E1:L1"), Excel.Range)
                    xlRange.EntireColumn.AutoFit()
                    xlApp.ScreenUpdating = True
                    xlWorkBook.SaveAs(SavePath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                    xlApp.Quit()
                Catch ex As System.Exception
                    MessageBox.Show(ex.Message & vbNewLine & "\n\n=======  WRITE TO EXCEL ERROR:  ======\n\n" & vbNewLine & _
                                ex.StackTrace)
                    Return False
                Finally
                    releaseObject(xlRange)
                    releaseObject(xlWorkSheet)
                    releaseObject(xlWorkBook)
                    releaseObject(xlApp)
                End Try
                Return True
            Catch exl As System.Exception
                MessageBox.Show(exl.Message & _
                    vbNewLine & "\n\n=======   ERROR TO ACESS EXCEL:  ======\n\n" & vbNewLine & _
                    exl.StackTrace)
                Return False
            End Try
        End If
    End Function
    Public Function Import() As Boolean
        Dim dlgImport As New OpenFileDialog
        With dlgImport
            .Filter = FilterRead
            .Title = "นำเข้าข้อมูล"
        End With
        If dlgImport.ShowDialog = DialogResult.OK AndAlso dlgImport.FileName <> "" Then
            SavePath = dlgImport.FileName
            Try
                Dim MyConnection As System.Data.OleDb.OleDbConnection
                'Dim DtSet As System.Data.DataSet
                Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                MyConnection = New System.Data.OleDb.OleDbConnection _
                ("provider=Microsoft.Jet.OLEDB.4.0; " & _
                 "Data Source='" + SavePath + "'; " & _
                 "Extended Properties=Excel 8.0;")
                MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                    ("select * from [Sheet1$]", MyConnection)
                MyCommand.Fill(Table_Import)
                MyConnection.Close()
                Return True
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return False
            End Try
        End If


    End Function
End Class
