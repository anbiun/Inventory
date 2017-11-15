Imports ConDB.Main
Imports System.Data
Imports System.Data.SqlClient
Imports DevComponents.AdvTree
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Win

Public Class FmgCategory
    Friend tagID As String,
        UnitID As String,
        _Detail As String,
        QtyPerColName As String,
        QtyPerUnitName As String
    Enum Pages
        Add = 0
        Edit = 1
    End Enum
#Region "Function"
    'FromLoad
    Private Sub frmLoad()
        For i As Integer = 0 To XtraTabControl.TabPages.Count - 1
            XtraTabControl.TabPages(i).PageVisible = False
        Next
        With slUnit.Properties
            clsDS({"Unit"})
            SQL = "select * from tbUnit"
            dsTbl("Unit")
            .DataSource = DS.Tables("Unit")
            .PopulateViewColumns()
            .DisplayMember = "UnitName"
            .ValueMember = "UnitID"
            .NullText = ""
            .View.Columns("UnitName").Caption = "หน่วยที่จะนำไปใช้"
            .View.Columns("UnitID").Visible = False
            .View.Columns("MainFlag").Visible = False
        End With

        Select Case ModeAddEdit
            Case "Add"
                XtraTabControl.SelectedTabPageIndex = 0
                XtraTabControl.TabPages(0).PageVisible = True
                If CategoryValue Is Nothing Then
                    imgFolder.Image = Global.Inventory_Management.My.Resources.Resources.Home
                    luCategory.Properties.NullText = CategoryTxt
                    luCategory.Properties.ReadOnly = True
                    lblTitle.Text = "อยู่ภายใต้"
                    Me.Text = "สร้างหมวดวัสดุ"

                    Panel1.Visible = False
                Else
                    imgFolder.Image = Global.Inventory_Management.My.Resources.Resources.FolderOpen
                    luCategory.Properties.NullText = CategoryTxt
                    luCategory.Properties.ReadOnly = True
                    lblTitle.Text = "อยู่ภายใต้หมวดวัสดุ"
                    Me.Text = "สร้างประเภทวัสดุ"

                    Panel1.Visible = True
                End If

            Case "Edit"
                '#แก้ไข เคสนี้
                XtraTabControl.SelectedTabPageIndex = 1
                XtraTabControl.TabPages(1).PageVisible = True
                With luCategory.Properties
                    Select Case MainCatSelect
                        Case True
                            .DataSource = simTable()
                            txtName.Text = FrmMatList.TreeCategory.SelectedNode.Text
                            memoDetail.Text = FrmMatList.TreeCategory.SelectedNode.Tooltip
                            imgFolder.Image = Global.Inventory_Management.My.Resources.Home
                            .ReadOnly = False

                            Panel1.Visible = False
                        Case False
                            If DS.Tables("category") IsNot Nothing Then DS.Tables("category").Clear()
                            SQL = "select CatID, CatName from tbCategory order by catID"
                            .DataSource = dsTbl("category")
                            .DropDownRows = DS.Tables("category").Rows.Count
                            luCategory.EditValue = CategoryValue
                            imgFolder.Image = Global.Inventory_Management.My.Resources.Resources.FolderOpen
                            lblTitle.Text = "อยู่อยู่ภายใต้หมวดวัสดุ"

                            Panel1.Visible = True
                            clsDS({"subcat"})
                            SQL = "select * from tbSubcategory"
                            dsTbl("subcat")
                            FoundRow = DS.Tables("subcat").Select("SubCatID='" & SubCategoryValue & "' AND CatID ='" & CategoryValue & "'")
                            tagID = If(IsDBNull(FoundRow(0)("TagID")), Nothing, FoundRow(0)("TagID"))
                            UnitID = If(IsDBNull(FoundRow(0)("Unit3_ID")), Nothing, FoundRow(0)("Unit3_ID"))

                            txtName.Text = SubCategoryTxt
                            memoDetail.Text = SubCategoryDetail
                            txtTagID.Text = tagID
                            slUnit.EditValue = UnitID
                            slUnit.Properties.View.SelectRows(0, 0)
                    End Select

                    .DisplayMember = "CatName"
                    .ValueMember = "CatID"
                    .BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                    .SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
                    luCategory.ItemIndex = 0
                    .AutoSearchColumnIndex = 1
                    .PopulateColumns()
                    If .Columns.Count > 1 Then
                        .Columns("CatID").Visible = False
                    End If
                    .ReadOnly = False
                    If MainCatSelect = True Then .ReadOnly = True
                End With

        End Select
        loadSuccess = True
    End Sub
    'Button Process
    Public Sub btnProcess()
        Dim node As DevComponents.AdvTree.Node = New DevComponents.AdvTree.Node
        If tagID Is String.Empty Or UnitID Is String.Empty Then
            MessageBox.Show("กรุณาตรวจสอบ TagID. และหน่วยที่จะนำไปใช้งาน", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        'getID
        Dim ID As String = Nothing 'catID and SubCatID
        If MainCatSelect = True Then
            SQL = "SELECT Max(SubCatID)+1 FROM tbSubcategory"
        Else
            SQL = "SELECT Max(CatID)+1 FROM tbCategory"
        End If
        dsTbl("getmaxid")
        ID = If(IsDBNull(DS.Tables("getmaxid")(0)(0)), "01", DS.Tables("getmaxid")(0)(0))
        ID = CInt(ID).ToString("00")

        Select Case ModeAddEdit
            Case "Add"
                With node
                    .Tag = ID
                    .Text = txtName.Text
                    .Name = txtName.Text
                    .Tooltip = memoDetail.Text

                    Select Case MainCatSelect
                        Case True
                            .Image = Global.Inventory_Management.My.Resources.Document
                            Try
                                SQL = "Insert Into tbSubCategory (SubCatID,SubCatName,subcatDetail,catID,tagID,Unit3_ID)"
                                SQL &= " VALUES ('" & ID & "','" & txtName.Text & "','" & memoDetail.Text & "','" & CategoryValue & "','" & tagID & "','" & UnitID & "')"
                                dsTbl("SubCat")
                            Catch ex As Exception
                                MessageBox.Show("Error:" & vbCrLf & ex.Message)
                            End Try

                            With FrmMatList.TreeCategory
                                .BeginUpdate()
                                .SelectedNode.Nodes.Add(node)
                                node.ExpandVisibility = DevComponents.AdvTree.eNodeExpandVisibility.Auto
                                .EndUpdate()
                                .SelectedNode.Expand()
                            End With
                        Case False
                            Try
                                SQL = "Insert Into tbCategory (catID,CatName,catDetail) VALUES ('" & ID & "','" & txtName.Text & "','" & memoDetail.Text & "')"
                                dsTbl("MainCat")
                            Catch ex As Exception
                                MessageBox.Show("Error:" & vbCrLf & ex.Message)
                            End Try
                            .Image = Global.Inventory_Management.My.Resources.FolderOpen
                            With FrmMatList.TreeCategory
                                .BeginUpdate()
                                .Nodes.Add(node)
                                .EndUpdate()
                            End With
                    End Select
                End With
                MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmMatList.LoadLookUp(True)

            Case "Edit"
                Select Case MainCatSelect
                    Case True
                        SQL = "Update tbCategory Set CatName ='" & txtName.Text & "', catDetail = '" & memoDetail.Text & "' Where catID ='" & CategoryValue & "'"
                        With FrmMatList.TreeCategory.SelectedNode
                            .Text = txtName.Text
                            .Tooltip = memoDetail.Text
                        End With
                    Case False
                        SQL = "SELECT MAX(SubCatID)+1 FROM tbSubCategory WHERE CatID = '" & luCategory.EditValue & "'"
                        dsTbl("getmaxid")
                        Dim newSub As String = If(IsDBNull(DS.Tables("getmaxid")(0)(0)), "01", DS.Tables("getmaxid")(0)(0))
                        newSub = CInt(newSub).ToString("00")

                        SQL = "Update tbSubCategory Set SubCatName ='" & txtName.Text & "'" _
                            & ",subcatDetail ='" & memoDetail.Text & "'" _
                            & ",catID ='" & luCategory.EditValue & "'" _
                            & ",SubCatID ='" & newSub & "'" _
                            & ",tagID='" & tagID & "'" _
                            & ",Unit3_ID='" & UnitID & "'" _
                            & " Where SubCatID='" & SubCategoryValue & "' AND CatID='" & CategoryValue & "'"
                        With FrmMatList.TreeCategory
                            .SelectedNode.Remove()
                            .BeginUpdate()
                            With node
                                .Tag = SubCategoryValue
                                .Text = txtName.Text
                                .Name = txtName.Text
                                .Tooltip = memoDetail.Text
                                .Image = Global.Inventory_Management.My.Resources.Document
                            End With

                            For Each strNode As DevComponents.AdvTree.Node In .Nodes
                                If Trim(strNode.Tag) = Trim(luCategory.EditValue) Then
                                    .Nodes(strNode.Index).Nodes.Add(node)
                                    .Nodes(strNode.Index).Nodes.Sort()
                                End If
                            Next
                            .EndUpdate()
                        End With
                End Select
                dsTbl("Update")

            Case "Del"
                If MessageBox.Show("คุณต้องการลบข้อมูล " _
                                             & FrmMatList.TreeCategory.SelectedNode.Text & _
                                             " ใช่หรือไม่", "ผลการทำงาน", _
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If FrmMatList.GVMain.RowCount > 0 Then
                        MessageBox.Show("ไม่สามารถลบได้ " & vbCrLf & " เนื่องจาก " & FrmMatList.TreeCategory.SelectedNode.Text & " ถูกใช้งานอยู่", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Select Case MainCatSelect
                        Case True
                            SQL = "select catID from tbSubCategory"
                            dsTbl("findSubCat")
                            FoundRow = DS.Tables("findSubCat").Select("catID = '" & CategoryValue & "'")
                            If FoundRow.Count = 0 Then
                                SQL = "delete from tbCategory where catID ='" & CategoryValue & "'"
                            Else
                                MessageBox.Show("ไม่สามารถลบรายการหมวดวัสดุนี้ได้ " & vbCrLf & " เนื่องจากมีรายการของประเภทวัสดุ อยู่ภายใต้หมวดวัสดุนี้อยู่", "ลบหมวดวัสดุ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        Case False
                            SQL = "delete from tbsubCategory where SubCatID ='" & SubCategoryValue & "'"
                    End Select
                    dsTbl("Delete")
                    FrmMatList.TreeCategory.SelectedNode.Remove()
                End If
        End Select
        FrmMatList.BtnTree_Edit.Enabled = False
        FrmMatList.BtnTree_Del.Enabled = False
        FrmMatList.BtnTree_Refresh.PerformClick()
        Me.Dispose()
    End Sub
    'Generate CategoryID Auto
    Function simTable() As DataTable
        Dim table As New DataTable
        table.Columns.Add("CatID", GetType(String))
        table.Columns.Add("CatName", GetType(String))
        table.Rows.Add("01", "โครงสร้างหลัก")
        Return table
    End Function
    Private Sub LoadDef(Optional _page As Pages = 0)
        txtName.Text = ""
        txtTagID.Text = ""
        memoDetail.Text = ""
    End Sub
#End Region

#Region "Control."
    Private Sub FrmDailogChangeDataTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False
        LoadDef()
        frmLoad()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        btnProcess()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Dispose()
    End Sub
    Private Sub XtraTabControl_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl.SelectedPageChanged
        LoadDef()
    End Sub

    Private Sub slUnit_EditValueChanged(sender As Object, e As EventArgs) Handles slUnit.EditValueChanged
        If loadSuccess = False Then Exit Sub
        UnitID = slClick(sender, "UnitID")
    End Sub

    Private Sub txtTagID_EditValueChanged(sender As Object, e As EventArgs) Handles txtTagID.EditValueChanged
        tagID = If(String.IsNullOrWhiteSpace(txtTagID.Text), Nothing, Trim(txtTagID.Text))
    End Sub
    Private Sub popupForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim popupForm As PopupSearchLookUpEditForm = TryCast(sender, PopupSearchLookUpEditForm)
        If e.KeyData = System.Windows.Forms.Keys.Enter Then
            Dim view As GridView = popupForm.OwnerEdit.Properties.View
            view.FocusedRowHandle = 0
            popupForm.OwnerEdit.ClosePopup()
        End If
    End Sub
#End Region
End Class