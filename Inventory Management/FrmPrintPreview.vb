Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Base
Public Class FrmPrintPreview
    Public dtPrint As DataTable
    Private Sub FrmPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcDB.DataSource = dtPrint
        gvDB.BestFitColumns()
        Dim View As ColumnView = gcDB.MainView
        'Dim FieldNames() As String = New String() {"BillNo", _
        '     "MatName", "TagID"}
        'Dim I As Integer
        'Dim Column As DevExpress.XtraGrid.Columns.GridColumn
        'View.Columns.Clear()
        'For I = 0 To FieldNames.Length - 1
        '    Column = View.Columns.AddField(FieldNames(I))
        '    Column.VisibleIndex = I
        'Next
        gvDB.AppearancePrint.HeaderPanel.Font = New Font("Tahoma", 12, FontStyle.Bold)
        gvDB.AppearancePrint.Row.Font = New Font("Tahoma", 12, FontStyle.Regular)
        'gvDB.Columns("MatID").Visible = False
        gvDB.Columns("MatName").Caption = "วัสดุ"
        gvDB.Columns("Unit1").Caption = "จำนวน"
        gvDB.Columns("Unit1_Name").Caption = " "
        gvDB.Columns("Unit3").Caption = "เป็นปริมาณ"
        gvDB.Columns("Unit3_Name").Caption = " "
        gvDB.Columns("Dozen").Caption = "จำนวนโหล"
        gvDB.Columns("SubMatName").Caption = "เบอร์ร่วม"
        PrintLink.Landscape = True
        PrintLink.ClearDocument()
        PrintLink.CreateDocument()
    End Sub
End Class