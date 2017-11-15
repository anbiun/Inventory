Imports ConDB.Main
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Export
Imports System.ComponentModel

Public Class FrmExcelImport
    Dim ProgressInt As Integer
#Region "CODE"

#End Region
#Region "COMPO."

#End Region
    Private Sub FrmImportMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartCon()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim path As String = ""
        With OpenFileDialog
            .InitialDirectory = "C:\"
            .Title = "Select Excel File"
            .Filter = "Excel 2007 (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls"
        End With
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = OpenFileDialog.FileName
            TxtPath.Text = path
        End If
        If path IsNot Nothing Then
            Try
                Using stream As New FileStream(path, FileMode.Open)
                    sheetCtrl.LoadDocument(stream, DocumentFormat.OpenXml)
                    Dim worksheet As Worksheet = sheetCtrl.Document.Worksheets.ActiveWorksheet
                    'worksheet.Rows(0).Delete()
                End Using
            Catch ex As Exception
                MsgBox("กรุณาปิดไฟล์ต้นฉบับก่อน")
            End Try

        End If
        ProgressBarControl.EditValue = 0
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Dim mySheet As Worksheet = sheetCtrl.Document.Worksheets(0)
        Dim range As Range = mySheet.GetDataRange
        DT = mySheet.CreateDataTable(range, True)
        Dim exporter As DataTableExporter = mySheet.CreateDataTableExporter(range, DT, True)
        ' Perform the export.
        exporter.Export()

        'For i As Integer = 0 To DS.Tables("maxID").Rows.Count
        '    For i As Integer = sheetCtrl.col
        '    Next

        '    Exit Sub
        '    Dim rowList As DataRow() = DT.Select("", "หมวดวัสดุ DESC,ประเภทวัสดุ DESC")


        '    For Each r As DataRow In rowList
        '        MsgBox(r("หมวดวัสดุ").ToString & r("ประเภทวัสดุ").ToString)
        '    Next
        '    Exit Sub
        '    ProgressBarControl.Properties.Maximum = DT.Rows.Count
        '    If BackgroundWorker.IsBusy <> True Then
        '        PanelControl1.Enabled = False
        '        BackgroundWorker.RunWorkerAsync()
        '    End If
    End Sub
    Private Sub backgroundWorker1_DoWork(ByVal sender As System.Object, _
    ByVal e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim itemID, itemName, itemUnitID, catID, SubCatID, locID, storeID, unitID, itemDetail As String
        Dim itemPrice As Double
        Dim itemDegree As Integer

        For i As Integer = 0 To DT.Rows.Count - 1
            If i = 0 Then
                ProgressInt = 1
            Else
                ProgressInt = i + 1
            End If
            If (worker.CancellationPending = True) Then
                e.Cancel = True
                Exit For
            Else
                worker.ReportProgress(ProgressInt)
            End If

            itemID = DT.Rows(i)("itemID")
            itemName = DT.Rows(i)("itemName")
            itemPrice = DT.Rows(i)("itemPrice")
            itemDegree = DT.Rows(i)("itemDegreeOrder")
            itemUnitID = DT.Rows(i)("itemUnitDegreeID")
            catID = DT.Rows(i)("CatID")
            SubCatID = DT.Rows(i)("SubCatID")
            locID = DT.Rows(i)("LocID")
            storeID = DT.Rows(i)("StoreID")
            unitID = DT.Rows(i)("UnitID")

            If IsDBNull(DT.Rows(i)("itemDetail")) Then
                itemDetail = ""
            Else
                itemDetail = DT.Rows(i)("itemDetail")
            End If

            SQL = "INSERT INTO TEMP ([itemID],[itemName],[itemPrice],[itemDegreeOrder],[itemUnitDegreeID],[catID],[SubCatID],[locID],[storeID],[unitID],[itemDetail]) VALUES" & _
            "('" & itemID & "','" & itemName & "','" & itemPrice & "','" & itemDegree & "','" & itemUnitID & "','" & catID & "','" & SubCatID & "','" & locID & "','" & storeID & "','" & unitID & "','" & itemDetail & "')"
            dsTbl("insert")
            BackgroundWorker.ReportProgress(ProgressInt)
        Next
    End Sub
    Private Sub backgroundWorker1_ProgressChanged(ByVal sender As System.Object, _
    ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        ProgressBarControl.Text = e.ProgressPercentage
    End Sub
    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, _
    ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Canceled!")
        ElseIf e.Error IsNot Nothing Then
            MsgBox("Error: " & e.Error.Message)
        Else
            MsgBox("Done!")
            ProgressBarControl.Text = 0
            PanelControl1.Enabled = True
        End If
    End Sub
End Class