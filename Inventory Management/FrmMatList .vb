Imports ConDB.Main
Imports System.Data
Imports System.Data.SqlClient
Imports DevComponents.AdvTree
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Public Class FrmMatList
    Public oldMatID As String
    Private ExcelFunc As Boolean = State._OFF
    Private Enum State
        _ON = True
        _OFF = False
    End Enum

#Region "Function"
    Friend Sub LoadLookUp(NormalMode As Boolean)
        If NormalMode = False Then GoTo lchangeMainLookup
        'Dim LookUpList() As LookUpEdit = {LookUpCategory}
        'For Each lu As LookUpEdit In LookUpList
        '    Dim tbname As String = ""
        '    With lu.Properties
        '        Select Case lu.Name
        '            Case LookUpCategory.Name
        '                tbname = "tbCategory"
        '                
        '        End Select

        '        .DataSource = dsTbl(tbname)
        '        .ValueMember = "รหัส"
        '        .DisplayMember = "ชื่อ"
        '        .PopulateColumns()
        '    End With
        '    lu.ItemIndex = 0
        'Next
        With LookUpCategory
            SQL = "select catID,catName FROM tbCategory"
            .Properties.DataSource = dsTbl("category")
            .Properties.ValueMember = "catID"
            .Properties.DisplayMember = "catName"
            .ItemIndex = 0
        End With

        With luProduct
            SQL = "SELECT ProductID,ProductName from tbQCTarget"
            .Properties.DataSource = dsTbl("product")
            .Properties.ValueMember = "ProductID"
            .Properties.DisplayMember = "ProductName"
            .ItemIndex = 0
        End With
lchangeMainLookup:
        With LookUpSubCategory
            With .Properties

                SQL = "select SubCatID as 'รหัส', SubCatName as 'ชื่อ' FROM tbsubCategory where catID='" & LookUpCategory.EditValue & "'"
                dsTbl("subcat")
                .DataSource = DS.Tables("subcat")
                .DisplayMember = "ชื่อ"
                .ValueMember = "รหัส"
                .PopulateColumns()
            End With
            .ItemIndex = 0
        End With
        If NormalMode = False Then Exit Sub
    End Sub
    Private Sub lockMode(Allow As Boolean)
        Select Case Allow
            Case False
                gcMain.Enabled = False
                PnlbtnItem.Visible = False
                PnlTree.Visible = False
                ExpandableSplitter1.Enabled = False
                LookUpSearch.Enabled = False
                TxtBarcode.Enabled = False
                XtraTabItem.Enabled = True
                PnlSave.Visible = True
                pnlCurrentProcess.Visible = True
                pnlImportExport.Visible = False
            Case True
                gcMain.Enabled = True
                PnlbtnItem.Visible = True
                PnlTree.Visible = True
                ExpandableSplitter1.Enabled = True
                LookUpSearch.Enabled = True
                TxtBarcode.Enabled = True
                XtraTabItem.Enabled = False
                PnlSave.Visible = False
                pnlCurrentProcess.Visible = False
                pnlImportExport.Visible = True
        End Select
    End Sub
    Private Function genMatID()
        Dim MatID, catID, SubCatID As String
        catID = LookUpCategory.EditValue
        '(LookUpCategory.ItemIndex + 1).ToString("00")
        SubCatID = LookUpSubCategory.EditValue
            '(LookUpSubCategory.ItemIndex + 1).ToString("00")

        If DS.Tables("MatID") IsNot Nothing Then DS.Tables("MatID").Clear()
        SQL = "select max(MatID)+1 as MatID from tbMat where MatID like '%" & catID & SubCatID & "%'"
        dsTbl("MatID")

        If String.IsNullOrEmpty(DS.Tables("MatID").Rows(0)("MatID").ToString) Then
            MatID = catID & SubCatID & "001"
        Else
            MatID = catID & SubCatID & DS.Tables("MatID").Rows(0)("MatID").ToString.Substring(3)
        End If
        Return MatID
    End Function
    Private Sub loadLookSearch()
        Exit Sub
        With LookUpSearch.Properties
            SQL = "SELECT tbSearch.*, tbCategory.catName, tbSubCategory.SubCatName FROM tbSearch " &
                "INNER JOIN tbCategory ON tbSearch.catID = tbCategory.catID " &
                "INNER JOIN tbSubCategory ON tbSearch.SubCatID = tbSubCategory.SubCatID"
            .DataSource = dsTbl("search")
            .DisplayMember = "MatName"
            .ValueMember = "MatID"
            .BestFitMode = BestFitMode.BestFitResizePopup
            .PopulateViewColumns()

            With .View
                .Columns("CatID").Visible = False
                .Columns("SubCatID").Visible = False
                .Columns("UnitID").Visible = False
                .Columns("matDGID").Visible = False
                .Columns("itemDetail").Visible = False

                .Columns("MatID").Caption = "รหัสวัสดุ"
                .Columns("MatName").Caption = "ชื่อรายการวัสดุ"
                .Columns("UnitName").Caption = "หน่วยใช้งาน"
                .Columns("itemPrice").Caption = "ราคา"
                .Columns("matDGOrder").Caption = "ระดับการสั่ง"
                .Columns("itemDegreeUnit").Caption = "หน่วยสั่งซื้อ"
                .Columns("locName").Visible = False
                .Columns("storeName").Visible = False

                .Columns("catName").Caption = "หมวดวัสดุ"
                .Columns("SubCatName").Caption = "ประเภทวัสดุ"
            End With
        End With
    End Sub
#End Region

#Region "TreeCategory Control"
    Private Sub focusTree(catID As String, SubCatID As String)
        For Each mainNode As DevComponents.AdvTree.Node In TreeCategory.Nodes
            If mainNode.Tag = catID Then
                mainNode.Expand()
                For Each subNode As DevComponents.AdvTree.Node In mainNode.Nodes
                    If subNode.Tag = SubCatID Then
                        TreeCategory.SelectedNode = subNode
                        subNode.RaiseClick()
                    End If
                Next
            End If
        Next
    End Sub
    Friend Sub LoadCategory()
        'Main category
        Dim nodeTop As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node
        If DS.Tables("maincat") IsNot Nothing Then DS.Tables("maincat").Clear()
        SQL = "select catID,catName,catDetail From tbCategory ORDER BY CatID"
        dsTbl("maincat")

        With nodeTop
            .Text = "โครงสร้างคลังวัสดุ"
            .Image = Global.Inventory_Management.My.Resources.Home
            .ExpandVisibility = DevComponents.AdvTree.eNodeExpandVisibility.Auto
        End With

        With TreeCategory
            .Nodes.Add(nodeTop)
            .BeginUpdate()
            For Each DR As DataRow In DS.Tables("maincat").Rows
                Dim node As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node
                With node
                    .Tag = DR.Item("CatID").ToString
                    .Text = DR.Item("catName").ToString
                    .Name = DR.Item("catName").ToString
                    .Tooltip = DR.Item("catDetail").ToString
                    .Image = Global.Inventory_Management.My.Resources.FolderClosed
                    .ExpandVisibility = DevComponents.AdvTree.eNodeExpandVisibility.Visible
                End With
                .Nodes.Add(node)
            Next
            .EndUpdate()
        End With
    End Sub
    Private Sub LoadSubCat(parent As DevComponents.AdvTree.Node)
        With TreeCategory

            If DS.Tables("subcats") IsNot Nothing Then DS.Tables("subcats").Clear()
            SQL = "select SubCatID, SubCatName, subcatDetail from tbSubCategory where catID= '" & parent.Tag & "'"
            SQL &= " ORDER BY SubCatID"
            dsTbl("subcats")
            .BeginUpdate()

            For Each DR As DataRow In DS.Tables("subcats").Rows
                Dim node As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node
                With node
                    .Tag = DR.Item("SubCatID").ToString
                    .Text = DR.Item("SubCatName").ToString
                    .Name = DR.Item("SubCatName").ToString
                    .Tooltip = DR.Item("subcatDetail").ToString
                    .Image = Global.Inventory_Management.My.Resources.Document
                    .ExpandVisibility = eNodeExpandVisibility.Hidden
                End With
                parent.Nodes.Add(node)
            Next
            parent.ExpandVisibility = DevComponents.AdvTree.eNodeExpandVisibility.Auto
            .EndUpdate()
        End With
    End Sub
    Private Sub TreeCategory_AfterCollapse(sender As Object, e As AdvTreeNodeEventArgs) Handles TreeCategory.AfterCollapse
        e.Node.Image = Global.Inventory_Management.My.Resources.FolderClosed
        If TreeCategory.SelectedNode IsNot Nothing Then TreeCategory.SelectedNode.RaiseClick()
    End Sub
    Private Sub TreeCategory_AfterExpand(sender As Object, e As AdvTreeNodeEventArgs) Handles TreeCategory.AfterExpand
        e.Node.Image = Global.Inventory_Management.My.Resources.FolderOpen
        Dim parent As DevComponents.AdvTree.Node
        parent = e.Node
        parent.Nodes.Clear()
        LoadSubCat(parent)
    End Sub
    Private Sub TreeCategory_NodeClick(sender As Object, e As DevComponents.AdvTree.TreeNodeMouseEventArgs) Handles TreeCategory.NodeClick
        If ExcelFunc = State._ON Then Exit Sub
        'txtPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        LblTitle.Text = e.Node.Text
        LblDetail.Text = e.Node.Tooltip
        'GVMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        'GVMain.OptionsSelection.EnableAppearanceFocusedRow = False

        If e.Node.Text = TreeCategory.Nodes(0).Text Then
            BtnTree_Add.Enabled = True
            BtnTree_Edit.Enabled = False
            BtnTree_Del.Enabled = False
        Else
            BtnTree_Add.Enabled = False
            BtnTree_Edit.Enabled = True
            BtnTree_Del.Enabled = True

            PnlbtnItem.Visible = True
            BtnAddItem.Visible = True
            BtnEditItem.Visible = False
            BtnDeleteItem.Visible = False
            oldMatID = Nothing
        End If


        If e.Node.Parent Is Nothing Then
            gcMain.DataSource = Nothing
            LoadLookUp(True)
            BtnTree_Add.Enabled = True
            PnlbtnItem.Visible = False
        Else
            showInGrid(e.Node.Parent.Tag, e.Node.Tag)
            GVMain.BestFitColumns()
            LookUpCategory.EditValue = e.Node.Parent.Tag
            LookUpSubCategory.EditValue = e.Node.Tag

            GVMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            GVMain.OptionsSelection.EnableAppearanceFocusedRow = False
        End If
        pnlImportExport.Visible = If(GVMain.RowCount > 0, True, False)
        'ปิดปุ่ม Excel Save กับ Cancel
        btnExcel_Save.Enabled = False
        btnExcel_Calcel.Enabled = False
    End Sub
#End Region

#Region "Button Control"
    Private Sub btnProcessItem()
        Dim MatID As String = TxtMaterialID.Text,
            MatName As String = TxtMaterialName.Text,
            matType As String = LookUpCategory.EditValue,
            matSubType As String = LookUpSubCategory.EditValue,
            matLoc As String = LookUpLocation.EditValue,
            matStore As String = LookUpStore.EditValue,
            matQtyPerUnit As Double = txtQtyPerUnit.Value,
            matWarn As Double = txtWarn.Value,
            matDetail As String = MemoDetail.Text,
            matRatio As Double = txtRatio.Value,
            ProductID As String = luProduct.EditValue


        Select Case ModeAddEdit
            Case BtnAddItem.Name
                SQL = "insert into tbMat (MatID,MatName,catID,SubCatID,QtyPerUnit,Ratio,Warn,ProductID) " _
                    & "values ('" & MatID & "','" & MatName & "','" & matType & "'," _
                    & "'" & matSubType & "','" & matQtyPerUnit & "','" & matRatio & "','" & matWarn & "','" & ProductID & "')"
            Case BtnEditItem.Name
                SQL = "update tbMat SET " &
                    "MatID ='" & MatID & "'," &
                    "MatName ='" & MatName & "'," &
                    "catID ='" & matType & "'," &
                    "SubCatID ='" & matSubType & "'," &
                    "itemDetail ='" & matDetail & "'," &
                    "QtyPerUnit = '" & matQtyPerUnit & "'," &
                    "Ratio = '" & matRatio & "'," &
                    "Warn = '" & matWarn & "'," &
                    "ProductID ='" & ProductID & "'" &
                    " where MatID='" & oldMatID & "'"
            Case BtnDeleteItem.Name
                MessageBox.Show("ลบข้อมูลแล้ว", "ลบข้อมูลเสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
        dsTbl("btnProcessItem")
        PnlSave.Visible = False
        PnlbtnItem.Visible = True
        ModeAddEdit = Nothing

        txtQtyPerUnit.Value = 0
        txtRatio.Value = 0
        'clsTXT()
    End Sub
    Private Sub BtnTree_Click(sender As Object, e As EventArgs) Handles BtnTree_Add.Click, BtnTree_Edit.Click, BtnTree_Del.Click, BtnTree_Refresh.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)

        CategoryTxt = Nothing
        CategoryValue = Nothing
        SubCategoryTxt = Nothing
        SubCategoryValue = Nothing
        ModeAddEdit = Nothing
        ModeAddEdit = btn.Name.Substring(8)

        If ModeAddEdit = "Refresh" Then
            BtnTree_Add.Enabled = True
            BtnTree_Edit.Enabled = False
            BtnTree_Del.Enabled = False
            TreeCategory.Nodes.Clear()
            LoadCategory()
            gcMain.DataSource = Nothing
            LoadLookUp(True)
            PnlbtnItem.Visible = False
            oldMatID = Nothing
            MainCatSelect = Nothing
            Exit Sub
        End If

        With TreeCategory
            If .SelectedNode Is Nothing Then
                'หากยังไม่มีการคลิกเลือกใดๆ กำหนดค่าให้เป็น Node หลักโครงสร้างวัสดุ
                .SelectedNode = .Nodes(0)
                CategoryTxt = .SelectedNode.Text
            End If
            If .SelectedNode.Parent Is Nothing And .SelectedNode IsNot .Nodes(0) Then
                'หากคลิก Node หลักที่ไม่ใช่โครงสร้างวัสดุ
                CategoryTxt = .SelectedNode.Text
                CategoryValue = .SelectedNode.Tag
                MainCatSelect = True
                'สำหรับ lookup FrmLoad กำหนดให้อยู่ภายใต้โครงสร้างวัสดุหลัก
                If ModeAddEdit = "Edit" Then
                    CategoryTxt = .Nodes(0).Text
                    'CategoryValue = .Nodes(0).Tag
                End If
            ElseIf .SelectedNode.Parent Is Nothing Then
                'หากคลิกที่ Node 0 โครงสร้างคลังวัสดุ
                CategoryTxt = .SelectedNode.Text
                CategoryValue = .SelectedNode.Tag
                MainCatSelect = False
            Else
                'หากคลิกประเภทในหมวดหลัก
                CategoryTxt = .SelectedNode.Parent.Text
                CategoryValue = .SelectedNode.Parent.Tag
                SubCategoryTxt = .SelectedNode.Text
                SubCategoryValue = .SelectedNode.Tag
                SubCategoryDetail = LblDetail.Text
                MainCatSelect = False
            End If
        End With

        If ModeAddEdit = "Del" Then
            FmgCategory.btnProcess()
            Exit Sub
        End If
        FmgCategory.ShowDialog()
        showInGrid(CategoryValue, SubCategoryValue)
        GVMain.BestFitColumns()
        LoadLookUp(True)

    End Sub
    Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click, BtnEditItem.Click, BtnDeleteItem.Click, BtnSave.Click, BtnCancel.Click
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        GVMain.OptionsFind.AlwaysVisible = False
        Select Case btn.Name
            Case BtnAddItem.Name
                TxtMaterialID.Text = genMatID()
                ModeAddEdit = BtnAddItem.Name
                lockMode(False)
                TxtMaterialName.Focus()
                TxtMaterialName.Text = ""
            Case BtnEditItem.Name
                If String.IsNullOrEmpty(oldMatID) Or GVMain.RowCount <= 0 Then
                    MessageBox.Show("กรุณาเลือกข้อมูลก่อน", "ไม่สามารถลบได้", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                ModeAddEdit = BtnEditItem.Name
                lockMode(False)
                GVMain.ActiveFilterString = "[MatName] = '" & TxtMaterialName.Text & "'"
            Case BtnDeleteItem.Name
                If String.IsNullOrEmpty(oldMatID) Then
                    MessageBox.Show("กรุณาเลือกข้อมูลก่อน", "ไม่สามารถลบได้", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    If MessageBox.Show("ยืนยันการลบข้อมูล", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
                        SQL = "delete from tbMat where MatID='" & oldMatID & "'"
                        dsTbl("del")
                        TreeCategory.SelectedNode.RaiseClick()
                        loadLookSearch()
                    Else
                        Exit Sub
                    End If
                End If
            Case BtnSave.Name
                If String.IsNullOrEmpty(TxtPrice.Text) Then
                    TxtPrice.Text = 0
                End If
                If ModeAddEdit = BtnEditItem.Name Then
                    If GVMain.RowCount > 1 Then
                        MessageBox.Show("ชื่อวัสดุซ้ำกับในระบบ กรุณาตรวจสอบ", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If
                End If

                btnProcessItem()
                lockMode(True)
                focusTree(LookUpCategory.EditValue, LookUpSubCategory.EditValue)
                loadLookSearch()
                TxtMaterialName.Text = ""
            Case BtnCancel.Name
                lockMode(True)
                GVMain.ActiveFilterString = ""
                Exit Sub
        End Select

        lblItemProcess.Text = "ยืนยันการ " & btn.Text & " ข้อมูล :"
    End Sub
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        focusTree(LookUpCategory.EditValue, LookUpSubCategory.EditValue)
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        gcMain.DataSource = Nothing
        showInGrid("MatID", LookUpSearch.EditValue)
        If GVMain.RowCount <= 0 Then
            PnlbtnItem.Visible = False
            BtnAddItem.Visible = False
        Else
            focusTree(LookUpCategory.EditValue, LookUpSubCategory.EditValue)
        End If
    End Sub
    Private Sub BtnLookUpDataManage(sender As Object, e As EventArgs) Handles BtnStore_Add.Click, BtnLocation_Add.Click

        Dim btn As SimpleButton = CType(sender, SimpleButton)
        Dim remMode As String = ModeAddEdit
        ModeAddEdit = btn.Name
        LoadLookUp(True)
        LookUpCategory.EditValue = GVMain.GetFocusedRowCellValue("CatID")
        LookUpSubCategory.EditValue = GVMain.GetFocusedRowCellValue("SubCatID")
        LookUpUnitBuy.EditValue = GVMain.GetFocusedRowCellValue("matDGID")
        ModeAddEdit = remMode
    End Sub
#End Region

#Region "Grid Control"
    Private Sub showInGrid(catValue As String, subcatValue As String)

        If DS.Tables("showingrid") IsNot Nothing Then DS.Tables("showingrid").Clear()
        SQL = "select * from vwMat where catID='" & catValue & "' and SubCatID='" & subcatValue & "'"
        If catValue = "MatID" Then
            oldMatID = ""
            SQL = "select * from vwMat where MatID='" & subcatValue & "'"
        End If

        gcMain.DataSource = dsTbl("showingrid")
        gridInfo = New GridCaption
        With gridInfo
            .hide.columns("subcatid")
            .hide.columns("catID")
            .hide.columns("productid")
            .SetCaption(GVMain)
        End With
        GVMain.OptionsView.ShowAutoFilterRow = True
        GVMain.Columns("MatName").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        If DS.Tables("showingrid").Rows.Count > 0 Then
            lblRatio_Name.Text = DS.Tables("showingrid")(0)("QtyOfUsing_Name")
        End If

        'lblRatio_Name.Text = DS.Tables("showingrid")(0)("")
    End Sub

    Private Sub GVMain_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVMain.RowCellClick
        'ตั้งค่าคลิก Focus แถว
        With GVMain
            .FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            .Appearance.FocusedRow.BackColor = Color.CornflowerBlue
            .Appearance.FocusedRow.ForeColor = Color.White
            .OptionsSelection.EnableAppearanceFocusedRow = True
        End With

        'โชว์/ไม่โชว์ แถบปุ่ม
        If ExcelFunc = State._ON Then Exit Sub
        PnlbtnItem.Visible = True
        BtnEditItem.Visible = True
        BtnDeleteItem.Visible = True
        '--end

        oldMatID = GVMain.GetRowCellValue(e.RowHandle, "MatID")
        With GVMain
            luProduct.EditValue = .GetFocusedRowCellValue("ProductID")
            TxtMaterialName.Text = .GetFocusedRowCellValue("MatName")
            TxtMaterialID.Text = .GetFocusedRowCellValue("MatID")
            TxtPrice.Text = .GetFocusedRowCellValue("itemPrice")
            txtQtyPerUnit.Value = If(.GetFocusedRowCellValue("QtyPerUnit") Is DBNull.Value, 0, .GetFocusedRowCellValue("QtyPerUnit"))
            'SpePrice.Text = .GetFocusedRowCellValue("matDGOrder")
            LookUpCategory.EditValue = .GetFocusedRowCellValue("CatID")
            LookUpSubCategory.EditValue = .GetFocusedRowCellValue("SubCatID")
            txtRatio.Value = If(.GetFocusedRowCellValue("Ratio") Is DBNull.Value, 0, .GetFocusedRowCellValue("Ratio"))
            txtWarn.EditValue = If(IsDBNull(.GetFocusedRowCellValue("Warn")), 0, .GetFocusedRowCellValue("Warn"))
            'LookUpUnitBuy.EditValue = .GetFocusedRowCellValue("matDGID")

            If String.IsNullOrEmpty(.GetFocusedRowCellValue("itemDetail")) Then
                MemoDetail.Text = Nothing
                Exit Sub
            Else
                MemoDetail.Text = .GetFocusedRowCellValue("itemDetail")
            End If
        End With
    End Sub
#End Region

#Region "Other Control"
    Private Sub FrmMateriallist_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlImportExport.Visible = False
        LoadCategory()
        BtnTree_Edit.Enabled = False
        BtnTree_Del.Enabled = False
        LoadLookUp(True)
        XtraTabItem.Enabled = False
        PnlbtnItem.Visible = False
        TxtMaterialID.Enabled = False
        loadLookSearch()
    End Sub
    Private Sub TxtIDMaterial_EditValueChanged(sender As Object, e As EventArgs) Handles TxtMaterialID.EditValueChanged
        bc128.Text = TxtMaterialID.Text
        bc128.Text &= "ABP"
    End Sub
    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrice.KeyPress, TxtBarcode.KeyPress
        numOnly(e)
    End Sub
    Private Sub TxtBarcode_EditValueChanged(sender As Object, e As EventArgs) Handles TxtBarcode.EditValueChanged
        showInGrid("MatID", TxtBarcode.Text)
        If GVMain.RowCount <= 0 Then
            PnlbtnItem.Visible = False
            BtnAddItem.Visible = False
        Else
            focusTree(LookUpCategory.EditValue, LookUpSubCategory.EditValue)
        End If
    End Sub
    Private Sub LookUpCategory_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpCategory.EditValueChanged, LookUpSubCategory.EditValueChanged
        Dim lookname As LookUpEdit = CType(sender, LookUpEdit)
        If lookname IsNot LookUpSubCategory Then
            LoadLookUp(False)
        End If

        Dim catID, subID As String
        catID = GVMain.GetRowCellValue(GVMain.FocusedRowHandle, "CatID")
        subID = GVMain.GetRowCellValue(GVMain.FocusedRowHandle, "SubCatID")

        If LookUpSubCategory.EditValue <> subID Or LookUpCategory.EditValue <> catID Or ModeAddEdit = BtnAddItem.Name Then
            TxtMaterialID.Text = genMatID()
        Else
            If String.IsNullOrEmpty(oldMatID) Then Exit Sub
            TxtMaterialID.Text = oldMatID
        End If
    End Sub
    Private Sub Lokk(sender As Object, e As EventArgs) Handles LookUpSubCategory.Click
        LookUpCategory.Refresh()
    End Sub
    Private Sub TxtMaterialName_EditValueChanged(sender As Object, e As EventArgs) Handles TxtMaterialName.EditValueChanged
        'GVMain.Columns("MatName").FilterMode.DisplayText = "test"
        If BtnAddItem.Visible = False Then
            GVMain.ActiveFilterString = "[MatName] = '" & TxtMaterialName.Text & "'"
        End If

    End Sub
#End Region

    Private Sub btnExport_Excel_Click(sender As Object, e As EventArgs) Handles btnExcel_Export.Click, btnExcel_Import.Click, btnExcel_Save.Click, btnExcel_Calcel.Click
        'ฟังชั่น Export Excel
        Dim btn As SimpleButton = CType(sender, SimpleButton)
        Dim ExportInfo As New export.ExcelExport
        ExportInfo.FilterSet = export.ExcelExport.FilterOption.Excel_97

        If btn.Name = btnExcel_Import.Name Then
            'นำข้อมูลเข้า
            If ExportInfo.Import() = True Then
                ExcelFunc = State._ON
                Dim dtCurrent As DataTable = gcMain.DataSource
                For i As Integer = 0 To GVMain.RowCount - 1
                    With dtCurrent
                        For Each item As DataRow In ExportInfo.Table_Import.Rows
                            Try
                                If .Rows(i)("MatID") = item("รหัสวัสดุ") Then
                                    .Rows(i)("QtyPerUnit") = item("หน่วยบรรจุ")
                                    .Rows(i)("Warn") = item("ระดับการแจ้งเตือน (เดือน)")
                                End If

                            Catch ex As Exception
                                MessageBox.Show("ไฟล์ไม่ถูกต้อง กรุณาตรวจเชคไฟล์ Excel สำหรับนำเข้า", "ไฟล์ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End Try
                        Next
                    End With
                Next
                'ลบรายการที่ไม่มีจาก excel
                For i As Integer = 0 To dtCurrent.Rows.Count - 1
                    With dtCurrent
                        FoundRow = ExportInfo.Table_Import.Select("รหัสวัสดุ ='" + .Rows(i)("MatID") + "'")
                        If FoundRow.Count = 0 Then .Rows(i).Delete()
                    End With
                Next

                dtCurrent.AcceptChanges()
                gcMain.DataSource = dtCurrent
                'GVMain.RefreshData
                'Do Import Data Togrid
                'If Fin btnSave.enable
            End If
        ElseIf btn.Name = btnExcel_Export.Name Then
            'นำข้อมูลออก
            With ExportInfo
                .Gridsource = GVMain
                .TemplateFile = "template_qtyofusing.xls"
                .Columns.Clear()
                .Columns.Add("A", "MatID")
                .Columns.Add("B", "MatName")
                .Columns.Add("C", "QtyPerUnit")
                .Columns.Add("D", "QtyPerUnit_Name")
                .Columns.Add("G", "Warn")
            End With

            If ExportInfo.Export = True Then
                If MessageBox.Show("นำข้อมูลออก Excel แล้ว " & ExportInfo.SavePath _
                                               & vbNewLine &
                                                "ต้องการเปิดไฟล์หรือไม่ ?", "นำออกข้อมูลสำเร็จ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Process.Start("EXCEL.EXE", """" + ExportInfo.SavePath + """")
                End If
            End If
        ElseIf btn.Name = btnExcel_Calcel.Name Then
            'ปุ่มยกเลิก
            'เรียกข้อมูลเดิมเข้ากริด
            showInGrid(TreeCategory.SelectedNode.Parent.Tag,
                       TreeCategory.SelectedNode.Tag)
            ExcelFunc = State._OFF
        Else
            'ปุ่มบันทึก
            ExcelFunc = State._OFF
            'Update DB จากข้อมูลใน Gird ที่นำเข้า

            Dim FieldList As New List(Of String)
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In GVMain.Columns
                FieldList.Add(col.FieldName)
            Next
            With FieldList
                .Remove("LocName")
                .Remove("StoreName")
                .Remove("QtyPerUnit_Name")
                .Remove("CatID")
                .Remove("SubCatID")
                .Remove("Ratio")
            End With
            'For Each col As GridColumnStylesCollection
            Dim dtCurrent As DataTable = DS.Tables("showingrid").Copy
            For i As Integer = 0 To dtCurrent.Rows.Count - 1
                Dim dbSQL As String
                SQL = "UPDATE tbMat SET"
                For Each item As String In FieldList
                    If item Is FieldList.Last Then
                        SQL &= " " & item & " ='" & dtCurrent.Rows(i)(item) & "'"
                    Else
                        SQL &= " " & item & " ='" & dtCurrent.Rows(i)(item) & "',"
                    End If
                    dbSQL = SQL
                Next
                SQL &= " WHERE MatID='" & dtCurrent.Rows(i)("MatID") & "'"
                dsTbl("update")
            Next
            MessageBox.Show("บันทึกข้อมูลนำเข้าเรียบร้อยแล้ว", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            showInGrid(TreeCategory.SelectedNode.Parent.Tag,
                       TreeCategory.SelectedNode.Tag)
            ExcelFunc = State._OFF
        End If

        If ExcelFunc = State._ON Then
            btnExcel_Save.Enabled = True
            btnExcel_Calcel.Enabled = True
            btnExcel_Export.Enabled = False
            PnlbtnItem.Visible = False
            'ปิดแถบข้าง
            PnlTree.Visible = False
            ExpandableSplitter1.Enabled = False
        Else
            btnExcel_Save.Enabled = False
            btnExcel_Calcel.Enabled = False
            btnExcel_Export.Enabled = True
            PnlbtnItem.Visible = True

            PnlTree.Visible = True
            ExpandableSplitter1.Enabled = True
        End If
    End Sub

End Class