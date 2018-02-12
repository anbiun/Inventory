Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Class DlogStockLow
    Friend dtName As DataTable
    Sub New()
        FrmMain.InitSkins()
        InitializeComponent()
        'Me.InitSkinGallery()
        'Me.InitGrid()
    End Sub

    Private Sub DlogStockLow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcList.DataSource = dtName
        gvFomat()

    End Sub
    Private Sub gvFomat()
        With gvList
            .PopulateColumns()
            .Columns("SubCatID").Visible = False
            .Columns("MatID").Visible = False
            .Columns("SubCatName").Caption = "ประเภทวัสดุ"
            .Columns("MatName").Caption = "วัสดุ"
            .Columns("Unit3").Caption = "ปริมาณคงเหลือ"
            .Columns("Unit3_Name").Caption = " "
            .Columns("Lacking").Caption = "ขาดอีก (ปริมาณต่อเดือน)"
            .Columns("Lacking_Name").Caption = " "
            Dim colList() As String = {"Unit3", "Lacking"}
            For Each colName As String In colList
                .Columns(colName).DisplayFormat.FormatType = FormatType.Numeric
                .Columns(colName).DisplayFormat.FormatString = "#,###.00"
            Next
            .BestFitColumns()
            .OptionsSelection.EnableAppearanceFocusedRow = False
        End With
    End Sub
    Public Sub GridViews(ByVal sender As Object, _
                                 ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvList.RowStyle
        Dim View As GridView = sender
        Dim lacking As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Lacking"))
        If (e.RowHandle >= 0) Then
            lacking = If(String.IsNullOrWhiteSpace(lacking), 0, CDbl(lacking))
            If lacking >= 0 Then
                e.Appearance.BackColor = Color.IndianRed
                e.Appearance.BackColor2 = Color.OrangeRed
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class
