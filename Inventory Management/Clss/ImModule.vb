Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.BarCodes
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports ConDB.Main

Module ImModule
    Public CategoryTxt As String
    Public CategoryValue As String
    Public CategoryDetail As String
    Public SubCategoryTxt As String
    Public SubCategoryValue As String
    Public SubCategoryDetail As String
    Public ModeAddEdit As String
    Public ModeData As String

    Public MainCatSelect As Boolean = True
    Public loadSuccess As Boolean = False

    Public FoundRow As DataRow()
    Dim txtReadStr As String
    Public UserInfo As New UserLogin
    Public ParamList As New List(Of SqlParameter)
    Public Version As String
    'ตัวแปร
    Friend Enum idFor
        MainCategory
        SubCategory
        Store
        Unit
        Location
    End Enum
    Public Enum UserGroup
        Admin = 5
        StockUser = 0
        ApproveUser = 1
    End Enum
    'Dataset Create/Clear Table
    Public Sub clsDS(values As String())
        For Each dtname As String In values
            If DS.Tables(dtname) IsNot Nothing Then
                DS.Tables(dtname).Clear()
            End If
        Next
    End Sub
    'ทั่วไป
    Public Function genID(Optional idFor As idFor = Nothing)
        If idFor = Nothing Then
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Static r As Random = New Random()
            Dim sb As New StringBuilder
            For i As Integer = 1 To 7
                Dim idx As Integer = r.Next(0, 35)
                sb.Append(s.Substring(idx, 1))
            Next
            Return sb.ToString
        End If

        Dim newId As String = Nothing,
            empStr As String = Nothing,
            tbField As String = Nothing,
            tbName As String = Nothing
        Dim empInt, padNum As Integer

        Sql = "SELECT max(" & tbField & ") as " & tbField & " From " & tbName & ""
        dsTbl(tbName)
        If DS.Tables(tbName) Is Nothing Then
            Return newId
        Else
            empStr = DS.Tables(tbName).Rows(0)(0).ToString.Substring(0, padNum)
            empInt = Trim(DS.Tables(tbName).Rows(0)(0).ToString.Substring(padNum)) + 1
            newId = empStr + empInt.ToString().PadLeft(3, "00")
        End If
        Return newId
    End Function
    Public Sub numOnly(e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
        Exit Sub
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Function Permission(_permis As UserGroup)
        Select Case _permis
            Case UserGroup.Admin
                FrmMatImport.pnlEdit.Visible = True
                Return True
            Case UserGroup.StockUser
                Return False
                'FrmMatImport.gvImportOrder.Columns("TagID").Visible = False
            Case UserGroup.ApproveUser
                FrmMatImport.pnlEdit.Visible = True
                Return True
        End Select

        Return False
    End Function
    Friend Function chkInput(grpBox As GroupControl) As Boolean
        For Each ctr As Control In grpBox.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is TextEdit Then
                If String.IsNullOrEmpty(ctr.Text) Then
                    ctr.Focus()
                    Return False
                End If
            ElseIf TypeOf ctr Is SearchLookUpEdit Then
                If CType(ctr, SearchLookUpEdit).EditValue = Nothing Then
                    ctr.Focus()
                    Return False
                End If
            ElseIf TypeOf ctr Is DateEdit Then
                If CType(ctr, DateEdit).EditValue = Nothing Then
                    ctr.Focus()
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Friend Function slClick(slookup As DevExpress.XtraEditors.SearchLookUpEdit, field As String)
        Dim vw As GridView = slookup.Properties.View
        Dim rw As Integer = slookup.Properties.GetIndexByKeyValue(slookup.EditValue)
        field = vw.GetRowCellValue(rw, field)
        Return field
    End Function
    Friend Function Find(table As String, values As String, Optional sort As String = "")
        DV = New DataView(DS.Tables(table), values, sort, DataViewRowState.CurrentRows)
        Return DV
    End Function

    'ไม่ได้ใช้
    Public Function convertDate(values As DateTime)
        Dim result As String
        result = values.Year & values.ToString("-MM-dd")
        Return result
    End Function
    Public Function DateTimeServer() As String
        Try
            Dim con As New System.Data.SqlClient.SqlConnection("Data Source=jlproducts.ddns.net;Initial Catalog=Inventory;Persist Security Info=True;User ID=sa;Password=JLproducts147")
            Dim com As New System.Data.SqlClient.SqlCommand("select getDate()", con)
            If con.State = ConnectionState.Closed Then con.Open()
            Dim dateServer As DateTime = com.ExecuteScalar()
            con.Close()
            Return dateServer.ToString("dd/MM/yyyy HH:mm:ss")
        Catch ex As Exception
            Return Now.ToString
        End Try
    End Function
    'Call SQL Procedure
    Public Function CallSP(SpName As String, ParamList As List(Of SqlParameter)) As DataTable
        Dim RetTb As New DataTable()
        Try
            Dim Command As SqlCommand
            Command = New SqlCommand(SpName, CONN) With {.CommandType = CommandType.StoredProcedure}
            For Each param In ParamList
                Command.Parameters.Add(param)
            Next
            DA = New SqlDataAdapter With {.SelectCommand = Command}
            DA.Fill(RetTb)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        Return RetTb
    End Function
    Public Sub ExportExcel(GridName As DevExpress.XtraGrid.GridControl)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel xlsx |*.xlsx"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            'ParamList.Clear()
            'ParamList.Add(New SqlParameter("@SubCatID", luSubCat.EditValue))
            'gcExport_AllStock.DataSource = CallSP("Export_AllStock", ParamList)
            'gcExport_AllStock.ExportToXlsx(saveFileDialog1.FileName)
            'gcExport_AllStock.DataSource = Nothing
            GridName.ExportToXlsx(saveFileDialog1.FileName)
        End If
    End Sub
    'BindingSet
    Public Binding As New BindingSet

End Module
