Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Public Class ClsPaging
    Private comboPageSize As ComboBoxEdit
    Private labelDisplay As LabelControl
    Private gridControl As GridControl
    Private dtSource As DataTable
    Private recNo As Integer
    Private currentPage As Integer
    Private pageSize As Integer
    Private maxRec As Integer
    Private pageCount As Integer
    Public WriteOnly Property setGrid
        Set(value)
            gridControl = value
        End Set
    End Property
    Public WriteOnly Property setSource
        Set(value)
            dtSource = value
        End Set
    End Property

    Public Sub LoadPage()
        Dim i As Integer
        Dim startRec As Integer = recNo
        Dim endRec As Integer
        Dim dtTemp As DataTable
        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSource.Clone
        If currentPage = pageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If
        'Copy the rows from the source table to fill the temporary table.
        For i = startRec To endRec - 1
            If i < dtSource.Rows.Count Then
                dtTemp.ImportRow(dtSource.Rows(i))
                recNo = recNo + 1
            End If
        Next
        gridControl.DataSource = dtTemp
        DisplayPageInfo()
    End Sub
    Private Sub DisplayPageInfo()
        labelDisplay.Text = "หน้า " & currentPage.ToString & "/ " & pageCount.ToString
    End Sub
    Public Sub LastPage()
        If currentPage = pageCount Then
            Exit Sub
        End If
        currentPage = pageCount
        recNo = pageSize * (currentPage - 1)
        LoadPage()
    End Sub
    Public Sub FirstPage()
        If currentPage = 1 Then
            Exit Sub
        End If
        currentPage = 1
        recNo = 0
        LoadPage()
    End Sub
    Public Sub PreviousPage()
        currentPage = currentPage - 1
        If currentPage < 1 Then
            currentPage = 1
            Exit Sub

        Else
            recNo = pageSize * (currentPage - 1)
        End If
        LoadPage()

    End Sub
    Public Sub NextPage()
        If currentPage = pageCount Then
            Exit Sub
        End If
        currentPage = currentPage + 1
        If currentPage > pageCount Then
            currentPage = pageCount
            If recNo = maxRec Then
            End If
        End If
        LoadPage()
    End Sub
    Public Sub Innitial(ByVal GridControlData As GridControl, ByVal LabelDisplyPage As LabelControl, ByVal DropPageSize As ComboBoxEdit, ByVal DT As DataTable)
        gridControl = GridControlData
        labelDisplay = LabelDisplyPage
        comboPageSize = DropPageSize
        pageSize = comboPageSize.Text
        'dtSource = GetData()
        dtSource = DT
        maxRec = dtSource.Rows.Count
        pageCount = maxRec \ pageSize
        If (maxRec Mod pageSize) > 0 Then
            'pageCount = pageCount - 1
            pageCount = pageCount + 1
        End If
        currentPage = 1
        recNo = 0
        LoadPage()
    End Sub
End Class
