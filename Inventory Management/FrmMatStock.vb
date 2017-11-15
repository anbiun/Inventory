Imports ConDB.Main
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid.Columns

Public Class FrmMatStock
    Dim MatID, MatName, pieceUnitID, supplierID, matDeID, unitID, bomID, ImportDate, BillNo, PoNo As String
    Dim matQty, piece, Price As Double
    Dim bomQty As Integer = 1
    Dim Vat As Integer = 0
    Dim chkQty As Boolean = False
    Dim nums As Integer = 0
    'สระเกียงศักดิ์
#Region "CODE"
    Private Function Search(Optional SubCatID = "01", Optional LocID = "01")
        SQL = "SELECT TOP 1 FormulaDozen,FormulaLacking FROM tbSubCategory WHERE SubCatID='" & SubCatID & "'"
        dsTbl("formula")
        Dim FormulaDozen As String = If(IsDBNull(DS.Tables("formula")(0)("FormulaDozen")), "0", DS.Tables("formula")(0)("FormulaDozen"))
        FormulaDozen = FormulaDozen.Replace("Unit3", "Stock.Unit3")
        FormulaDozen = FormulaDozen.Replace("QtyPerUnit", "Mat.QtyPerUnit")
        Dim FormulaLacking As String = If(IsDBNull(DS.Tables("formula")(0)("FormulaLacking")), "0", DS.Tables("formula")(0)("FormulaLacking"))
        FormulaLacking = FormulaLacking.Replace("Unit3", "Stock.Unit3")
        FormulaLacking = FormulaLacking.Replace("QtyPerUnit", "Mat.QtyPerUnit")

        SQL = " SELECT Stock.MatID, SC.SubCatName, Stock.TagID, Mat.MatName, Stock.Unit1, U1.UnitName AS Unit1_Name, Stock.Unit3, U3.UnitName AS Unit3_Name, Stock.ImportDate, "
        SQL &= " Stock.ImportID, " & FormulaDozen & " AS 'Dozen', CAST(" & FormulaLacking & " AS INT) AS 'Lacking', "
        SQL &= " 'โหล' AS Lacking_Name,L.LocName"
        SQL &= " FROM tbStock AS Stock INNER JOIN"
        SQL &= " tbMat AS Mat ON Stock.MatID = Mat.MatID INNER JOIN"
        SQL &= " tbSubCategory AS SC ON Mat.SubCatID = SC.SubCatID INNER JOIN"
        SQL &= " tbUnit AS U1 ON Stock.Unit1_ID = U1.UnitID INNER JOIN"
        SQL &= " tbUnit AS U3 ON SC.Unit3_ID = U3.UnitID"
        SQL &= " INNER JOIN tbLocation AS L ON Stock.LocID = L.LocID"
        SQL &= " WHERE (Mat.SubCatID = '" & SubCatID & "') AND (Stock.ImportDate >= '" & convertDate(sDate.EditValue) & "') AND (Stock.ImportDate <= '" & convertDate(eDate.EditValue) & "')"
        SQL &= " AND (Stock.LocID = '" & LocID & "')"
        SQL &= " ORDER BY Stock.MatID, Stock.ImportDate, Unit1_Name"
        dsTbl("MatStock")
        DV = New DataView(DS.Tables("MatStock"))

        'DV = New DataView(DS.Tables("MatStock"), "SubCatName = '" & luSubCat.Text & "' AND ImportDate >= '" & sDate.EditValue & "' AND ImportDate <= '" & eDate.EditValue & "'", "", DataViewRowState.CurrentRows)
        Return DV
    End Function
    Private Function sumRow() As DataTable
        Dim MatID As String = "",
            Unit1_Name As String = "",
            Unit3_Name As String = "",
            Lacking_Name As String,
            locName As String
        Dim dtMatStock As DataTable
        Dim dblSumU3 As Double,
            dblSumU1 As Double,
            dblDozen As Double,
            dblLacking As Double
        Dim addRow As Boolean = False
        Dim DifUnit As Boolean = False
        Dim addRowInt As Integer = 0,
            newRowInt As Integer = 0
        If UserInfo.Permis > 3 Then Search(luSubCat.EditValue, luLocation.EditValue) Else Search(luSubCat.EditValue, UserInfo.SelectLoc)

        dtMatStock = DV.ToTable
        'dtMatStock.Columns("Unit1").DataType = GetType(String)
        If dtMatStock.Rows.Count >= 1 Then
            MatID = dtMatStock(0)("MatID")
            ImportDate = dtMatStock(0)("ImportDate")
            Unit1_Name = dtMatStock(0)("Unit1_Name")
            Unit3_Name = dtMatStock(0)("Unit3_Name")
            dblLacking = If(IsDBNull(dtMatStock(0 + addRowInt)("Lacking")), 0, dtMatStock(0)("Lacking"))
            Lacking_Name = If(IsDBNull(dtMatStock(0 + addRowInt)("Lacking_Name")), "", dtMatStock(0)("Lacking_Name"))
            locName = dtMatStock(0)("LocName")
            Dim dr As DataRow
            dr = dtMatStock.NewRow
            dblSumU1 = dtMatStock.Compute("Sum(Unit1)", "MatID='" & dtMatStock(0 + addRowInt)("MatID") & "'")
            dblSumU3 = dtMatStock.Compute("Sum(Unit3)", "MatID='" & dtMatStock(0 + addRowInt)("MatID") & "'")
            dblDozen = If(IsDBNull(dtMatStock(0 + addRowInt)("Dozen")), 0, dtMatStock.Compute("Sum(Dozen)", "MatID='" & dtMatStock(0 + addRowInt)("MatID") & "'"))

            dr("tagID") = "รวมทั้งหมด"
            dr("SubCatName") = dtMatStock(0 + addRowInt)("SubCatName")
            dr("Unit1") = dblSumU1
            dr("Unit1_Name") = Unit1_Name
            dr("Unit3") = dblSumU3
            dr("Unit3_Name") = Unit3_Name
            dr("MatName") = dtMatStock(0 + addRowInt)("MatName")
            dr("Dozen") = dblDozen
            dr("Lacking") = dblLacking
            dr("Lacking_Name") = Lacking_Name
            dr("LocName") = locName
            dtMatStock.Rows.InsertAt(dr, 0 + addRowInt)
            dtMatStock.AcceptChanges()
            addRowInt += 1
        End If

        addRow = True
        For row = 0 To dtMatStock.Rows.Count - 2
            If MatID <> dtMatStock(row + addRowInt)("MatID") Then
                MatID = dtMatStock(row + addRowInt)("MatID")
                ImportDate = dtMatStock(row + addRowInt)("ImportDate")
                dblLacking = If(IsDBNull(dtMatStock(row + addRowInt)("Lacking")), 0, dtMatStock(row + addRowInt)("Lacking"))
                Lacking_Name = If(IsDBNull(dtMatStock(row + addRowInt)("Lacking_Name")), "", dtMatStock(row + addRowInt)("Lacking_Name"))
                locName = dtMatStock(row + addRowInt)("LocName")
                Dim dr As DataRow
                dr = dtMatStock.NewRow
                dblSumU1 = dtMatStock.Compute("Sum(Unit1)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "'")
                dblSumU3 = dtMatStock.Compute("Sum(Unit3)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "'")
                dblDozen = If(IsDBNull(dtMatStock.Compute("Sum(Dozen)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "'")), 0, _
                              dtMatStock.Compute("Sum(Dozen)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "'"))
                dr("tagID") = "รวมทั้งหมด"
                dr("Unit1") = dblSumU1
                dr("Unit1_Name") = Unit1_Name
                dr("SubCatName") = dtMatStock(row + addRowInt)("SubCatName")
                dr("Unit3") = dblSumU3
                dr("Unit3_Name") = Unit3_Name
                dr("MatName") = dtMatStock(row + addRowInt)("MatName")
                dr("Dozen") = dblDozen
                dr("Lacking") = dblLacking
                dr("Lacking_Name") = Lacking_Name
                dr("LocName") = locName
                dtMatStock.Rows.InsertAt(dr, row + addRowInt)
                dtMatStock.AcceptChanges()
                addRowInt += 1
                addRow = True
            ElseIf ImportDate <> dtMatStock(row + addRowInt)("ImportDate") Then
                MatID = dtMatStock(row + addRowInt)("MatID")
                ImportDate = dtMatStock(row + addRowInt)("ImportDate")
                addRow = True
            ElseIf Unit1_Name <> dtMatStock(row + addRowInt)("Unit1_Name") Then
                Unit1_Name = dtMatStock(row + addRowInt)("Unit1_Name")
                dblSumU1 = dtMatStock.Compute("Sum(Unit1)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "' And ImportDate='" & dtMatStock(row + addRowInt)("ImportDate") & "'" & _
                                            "And Unit1_Name='" & Unit1_Name & "'")
                dblSumU3 = dtMatStock.Compute("Sum(Unit3)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "' And ImportDate='" & dtMatStock(row + addRowInt)("ImportDate") & "'")

                If dtMatStock.Rows(newRowInt)("tagID") = "รวม" Then
                    dtMatStock.Rows(newRowInt)("Unit1_Name") &= " | " & dblSumU1 & " " & Unit1_Name
                Else
                    dtMatStock.Rows(newRowInt)("Unit1_Name") &= " | " & dblSumU1 & " " & Unit1_Name
                End If
                'DifUnit = True
                'addRow = True
            End If

            If addRow = True Then
                Dim dr As DataRow
                Unit1_Name = dtMatStock(row + addRowInt)("Unit1_Name")
                dblSumU1 = dtMatStock.Compute("Sum(Unit1)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "' And ImportDate='" & dtMatStock(row + addRowInt)("ImportDate") & "'" & _
                                                "And Unit1_Name='" & Unit1_Name & "'")
                dblSumU3 = dtMatStock.Compute("Sum(Unit3)", "MatID='" & dtMatStock(row + addRowInt)("MatID") & "' And ImportDate='" & dtMatStock(row + addRowInt)("ImportDate") & "'")

                dr = dtMatStock.NewRow
                dr("tagID") = "รวม"
                dr("Unit1") = dblSumU1
                dr("Unit1_Name") = Unit1_Name
                dr("Unit3_Name") = dtMatStock(row + addRowInt)("Unit3_Name")
                dr("Unit3") = dblSumU3
                dr("SubCatName") = dtMatStock(row + addRowInt)("SubCatName")
                dr("MatName") = dtMatStock(row + addRowInt)("MatName")
                dr("ImportDate") = dtMatStock(row + addRowInt)("ImportDate")
                dtMatStock.Rows.InsertAt(dr, row + addRowInt)
                dtMatStock.AcceptChanges()
                newRowInt = row + addRowInt
                addRowInt += 1
                addRow = False
            End If
        Next

        Return dtMatStock
    End Function
    Private Sub FirstQry(Optional sDate As String = "", Optional eDate As String = "")
        Dim tblist() As String = {"SubCat"}
        For Each tbname As String In tblist
            If DS.Tables(tbname) IsNot Nothing Then DS.Tables(tbname).Clear()
        Next

        If DS.Tables("SubCat") IsNot Nothing Then
            If DS.Tables("SubCat").Columns.Count > 0 Then DS.Tables("SubCat").Columns.Clear()
        End If

        SQL = "select SubCatID,SubCatName from tbsubcategory"
        dsTbl("SubCat")

        SQL = "SELECT * FROM tbLocation"
        dsTbl("Location")
        GvFormat()
    End Sub
    Private Sub GvFormat()
        SQL = "select *,'0' as Dozen,0 as Lacking,'' AS Lacking_Name from vwMatStock where MatID=0"
        gcMatList.DataSource = dsTbl("MatStock")
        gvMatList.PopulateColumns()
        With gvMatList
            .Columns("Unit1").Caption = "จำนวน"
            .Columns("SubCatName").Caption = "ประเภท"
            .Columns("SubCatName").Visible = False
            .Columns("MatName").Caption = "ชื่อวัสดุ"
            .Columns("MatID").Visible = False
            .Columns("Unit1_Name").Caption = " "
            .Columns("Unit3").Caption = "ปริมาณทั้งหมด"
            .Columns("Unit3_Name").Caption = " "
            .Columns("ImportDate").Caption = "วันที่นำเข้า"
            .Columns("TagID").Caption = "เลข Tag"
            .Columns("ImportID").Visible = False
            .Columns("LocID").Visible = False
            .Columns("Dozen").Caption = "จำนวนโหล"
            .Columns("Dozen").DisplayFormat.FormatType = FormatType.Numeric
            .Columns("LocName").Caption = "สถานที่เก็บ"
            .Columns("Dozen").DisplayFormat.FormatString = "#,#"
            .Columns("Lacking").Caption = "ขาด/เหลือ ขั้นต่ำต่อเดือน"
            .Columns("Lacking").DisplayFormat.FormatType = FormatType.Numeric
            .Columns("Lacking").DisplayFormat.FormatString = "#,#"
            .Columns("Lacking_Name").Caption = " "
            Dim colList() As String = {"Unit1", "Unit3"}
            For Each colname As String In colList
                .Columns(colname).DisplayFormat.FormatType = FormatType.Numeric
                .Columns(colname).DisplayFormat.FormatString = "#,0.0"
            Next
        End With
        gvMatList.BestFitColumns()
        gvMatList.Columns("MatID").Width = 100
        gcMatList.DataSource = Nothing
    End Sub
    Private Sub RDGroupChange()
        Dim SelectedValue As Integer = 0
        Select Case SelectedValue
            Case 0
                gvMatList.Columns("MatName").UnGroup()
                gvMatList.ActiveFilterString = "SubCatName ='" & luSubCat.Text & "' AND tagID='รวมทั้งหมด'"

            Case 2
                gvMatList.Columns("MatName").UnGroup()
                gvMatList.ActiveFilterString = "SubCatName ='" & luSubCat.Text & "' AND tagID='รวม'"
            Case 1
                gvMatList.ActiveFilterString = "SubCatName ='" & luSubCat.Text & "'"
                gvMatList.Columns("MatName").Group()
        End Select

        'gvMatList.Columns("TagID").Caption = If(RDGrp.SelectedIndex = 2, "เลข TagID", " ")
        gvMatList.Columns("ImportDate").Visible = If(SelectedValue = 0, False, True)
        ' gvMatList.Columns("Dozen").Visible = If(RDGrp.SelectedIndex = 1, False, True)
        'gvMatList.Columns("Lacking").Visible = If(RDGrp.SelectedIndex = 1, False, True)
        'gvMatList.Columns("Lacking_Name").Visible = If(RDGrp.SelectedIndex = 1, False, True)
        gvMatList.BestFitColumns()
    End Sub
#End Region

#Region "Other Control"
    Private Sub FrmInsertMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False
        FirstQry()
        sDate.EditValue = "1/1/2560"
        eDate.EditValue = Today

        luSubCat.Properties.DataSource = DS.Tables("SubCat")
        luSubCat.Properties.DisplayMember = "SubCatName"
        luSubCat.Properties.ValueMember = "SubCatID"
        luSubCat.ItemIndex = 0
        luSubCat.Text = luSubCat.EditValue

        luLocation.Properties.DataSource = DS.Tables("Location")
        luLocation.Properties.DisplayMember = "LocName"
        luLocation.Properties.ValueMember = "LocID"
        luLocation.ItemIndex = 0
        luLocation.Text = luSubCat.EditValue
        luLocation.Visible = If(UserInfo.Permis > 3, True, False)
        'gcMatList.DataSource = sumRow()
        'RefChart()
        RDGrp.EditValue = True
        loadSuccess = True
    End Sub
    Private Sub sluBom_EditValueChanged(sender As Object, e As EventArgs) Handles sluBom.EditValueChanged
        bomID = sluBom.EditValue
        'showBomDetail()
        txtBomID.Text = bomID
    End Sub
    Private Sub txtBomQty_TextChanged(sender As Object, e As EventArgs) Handles txtBomQty.TextChanged
        If String.IsNullOrEmpty(txtBomQty.Text) Or txtBomQty.Text = "0" Then
            bomQty = 1
        Else
            bomQty = CInt(txtBomQty.Text)
        End If
        'showBomDetail()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        Dim MatID_gvBom, MatID_gvMat As String
        Dim Qty_gvBom, Qty_gvMat, Piece As Double

        For rw_gvBom As Integer = 0 To gvBomMat.RowCount - 1
            MatID_gvBom = gvBomMat.GetRowCellValue(rw_gvBom, "MatID")
            Qty_gvBom = gvBomMat.GetRowCellValue(rw_gvBom, "Qty")

            For rw_gvMat As Integer = 0 To gvMatList.RowCount - 1
                MatID_gvMat = gvMatList.GetRowCellValue(rw_gvMat, "MatID")
                Qty_gvMat = gvMatList.GetRowCellValue(rw_gvMat, "Qty")
                Piece = gvMatList.GetRowCellValue(rw_gvMat, "Piece")

                If MatID_gvBom = MatID_gvMat Then
                    SQL = "update tbMat set Qty = round(convert(float,(" & (Piece) & " - " & (Qty_gvBom) & ")) / convert(float,(" & Piece & " / " & Qty_gvMat & ")),2)," & _
                        "Piece = (Piece - " & Qty_gvBom & ") where MatID = '" & MatID_gvBom & "'"
                    dsTbl("update")
                End If
            Next
        Next
        'showDB()
    End Sub
    Private Sub GridView1_RowStyle(ByVal sender As Object, _
ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvMatList.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim TagID As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TagID"))
            Dim Lacking As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Lacking"))

            If TagID = "รวมทั้งหมด" Then
                e.Appearance.BackColor = Color.GreenYellow
                e.Appearance.BackColor2 = Color.LightGreen
            ElseIf TagID = "รวม" Then
                e.Appearance.BackColor = Color.WhiteSmoke
                e.Appearance.BackColor2 = Color.DeepSkyBlue
            Else
                e.Appearance.BackColor = Color.WhiteSmoke
                e.Appearance.BackColor2 = Color.AntiqueWhite
            End If
            If Lacking <> "" AndAlso Lacking < 0 Then
                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.LightYellow
            End If

        End If
    End Sub
    Private Sub gvMatList_RowClick(sender As Object, e As RowClickEventArgs) Handles gvMatList.RowClick, gvMatImport.RowClick
        If gvMatList.FocusedRowHandle < 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        Else
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub sDate_EditValueChanged(sender As Object, e As EventArgs) Handles sDate.EditValueChanged, eDate.EditValueChanged
        If loadSuccess = False Then Exit Sub
        gcMatList.DataSource = sumRow()
        RDGroupChange()
        gvMatList.Columns("SubCatName").Visible = False
        RefChart()
    End Sub
    Private Sub luSubcat_EditValueChanged(sender As Object, e As EventArgs) Handles luSubCat.EditValueChanged, luLocation.EditValueChanged
        If loadSuccess = False Then Exit Sub
        gcMatList.DataSource = sumRow()
        RDGroupChange()
        gvMatList.Columns("SubCatName").Visible = False
        RefChart()
    End Sub
    Private Sub RefChart()
        Dim series1 As New Series("SRDonut", ViewType.Doughnut)

        cctrl.Series.Clear()
        FoundRow = DS.Tables("MatStock").Select("TagID='รวมทั้งหมด'")
        If FoundRow.Count > 0 Then
            series1.DataSource = FoundRow.CopyToDataTable
            series1.ArgumentScaleType = ScaleType.Auto
            series1.ValueScaleType = ScaleType.Numerical
            series1.ArgumentDataMember = "MatName"
            series1.ValueDataMembers.AddRange(New String() {"Unit3"})

            series1.LabelsVisibility = DefaultBoolean.True
            series1.Label.TextPattern = "{A} {VP:0.00%}"
            series1.LegendTextPattern = "{A}"

            cctrl.Series.Add(series1)
            cctrl.Legend.Visibility = DefaultBoolean.False
            'Dim legend As Legend = cctrl.Legend
            'legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside
            'legend.Direction = LegendDirection.LeftToRight

            Dim label As DoughnutSeriesLabel = TryCast(cctrl.Series(0).Label, DoughnutSeriesLabel)
            If label IsNot Nothing Then label.Position = PieSeriesLabelPosition.TwoColumns

            Dim myView As DoughnutSeriesView = CType(series1.View, DoughnutSeriesView)
            myView.Titles.Add(New SeriesTitle())

            Dim dblSum As Double = Nothing
            For Each row As DataRow In FoundRow
                dblSum = FoundRow.CopyToDataTable.Compute("Sum(Unit3)", "tagID='" & row("tagID") & "'")
            Next

            myView.Titles(0).Text = "รวม " & dblSum & " " & FoundRow(0)("Unit3_Name")
            cctrl.ToolTipEnabled = DefaultBoolean.True
            series1.ToolTipPointPattern = "{A} : {V} " & FoundRow(0)("Unit3_Name") & " ({VP:0.00%})"
        End If
    End Sub
    Private Sub RDGrp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RDGrp.SelectedIndexChanged
        RDGroupChange()
    End Sub
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        gvMatList.ExportToXlsx("test.xlsx")
        'Dim Plist As New List(Of SqlParameter)
        'Plist.Add(New SqlParameter("@SubCatID", luSubCat.EditValue))
        'FrmPrintPreview.dtPrint = CallSP("Export_AllStock", Plist)
        'FrmPrintPreview.ShowDialog()

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        gvMatList.AppearancePrint.Row.Font = New Font("Tahoma", 11)
        gvMatList.AppearancePrint.HeaderPanel.Font = New Font("Tahoma", 11, FontStyle.Bold)
        'gcMatList.PrintDialog()
        gcMatList.ShowPrintPreview()
    End Sub
    Private Sub btnChkLow_Click(sender As Object, e As EventArgs)
        SQL = "select * from getstocklow('" & luSubCat.EditValue & "')"
        Dim dtMatList As DataTable
        dtMatList = dsTbl("stocklow")
        DlogStockLow.dtName = dtMatList
        DlogStockLow.TopMost = True
        DlogStockLow.Show()


    End Sub
#End Region
End Class