Option Explicit On
Option Strict On
Imports DevExpress.XtraEditors

Public Class CheckListBox
    Private clbControl As New CheckedListBoxControl
    Public Property setControl As CheckedListBoxControl
        Set(value As CheckedListBoxControl)
            clbControl = value
        End Set
        Get
            Return clbControl
        End Get
    End Property
    Public WriteOnly Property Datasource As DataTable
        Set(value As DataTable)
            Using dtResult As DataTable = value
                Dim dr As DataRow = dtResult.NewRow
                dr(ValueMember) = "0"
                dr(DisplayMember) = "เลือกทั้งหมด"
                dtResult.Rows.InsertAt(dr, 0)
                clbControl.DataSource = If(value.Rows.Count = 1, Nothing, dtResult)
            End Using
        End Set
    End Property
    Public Property ValueMember As String
        Set(value As String)
            clbControl.ValueMember = value
        End Set
        Get
            Return clbControl.ValueMember
        End Get
    End Property
    Public Property DisplayMember As String
        Set(value As String)
            clbControl.DisplayMember = value
        End Set
        Get
            Return clbControl.DisplayMember
        End Get
    End Property

    Public Sub SelectAllCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs)
        Dim clb As CheckedListBoxControl = CType(sender, CheckedListBoxControl)
        If clb.SelectedIndex <> 0 AndAlso e.State = 0 Then
            clb.SetItemCheckState(0, 0)
        End If
        If e.Index = 0 AndAlso e.State = 0 AndAlso clb.CheckedItemsCount = clb.ItemCount - 1 Then
            clb.UnCheckAll()
        ElseIf e.Index = 0 AndAlso e.State = 1 AndAlso clb.CheckedItemsCount < clb.ItemCount Then
            clb.CheckAll()
        End If
    End Sub
End Class
