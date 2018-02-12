Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Public Class ClsPaging
    Private dtSource As DataTable
    Private recNo As Integer
    Private currentPage As Integer
    Private pageSize As Integer
    Private maxRec As Integer
    Private pageCount As Integer
    Public setControl As New controlsetting

    Public WriteOnly Property setPageNum
        Set(value)
            recNo = 0
            pageSize = dtSource.Rows.Count \ value
            pageCount = value
        End Set
    End Property
    Public ReadOnly Property getCurrentPage
        Get
            Return currentPage
        End Get
    End Property
    Public WriteOnly Property setSource
        Set(value)
            recNo = 0
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
            endRec = dtSource.Rows.Count
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
        setControl.GridCtrl.DataSource = dtTemp
        DisplayPageInfo()
    End Sub
    Private Sub DisplayPageInfo()
        setControl.PageDisplayCtrl.Text = "หน้า " & currentPage & " / " & pageCount
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

    Public Class controlsetting
        Private _gridControl As GridControl
        Private _comboPageNum As ComboBoxEdit
        Private _labelDisplay As LabelControl
        Public Property GridCtrl As GridControl
            Set(value As GridControl)
                _gridControl = value
            End Set
            Get
                Return _gridControl
            End Get
        End Property
        Public Property PageNumCtrl As ComboBoxEdit
            Set(value As ComboBoxEdit)
                _comboPageNum = value
            End Set
            Get
                Return _comboPageNum
            End Get
        End Property
        Public Property PageDisplayCtrl As LabelControl
            Set(value As LabelControl)
                _labelDisplay = value
            End Set
            Get
                Return _labelDisplay
            End Get
        End Property
    End Class
End Class

