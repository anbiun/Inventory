Option Explicit On
Option Strict On
Imports DevExpress.XtraEditors
Imports ConDB.Main
Namespace MyOp
    Public Class CheckListBox
        'Public DefQRYLocation As String = "SELECT LocID,LocName FROM tbLocation" & If(CInt(UserInfo.Permis) <= UserGroup.ApproveUser, " WHERE LocID='" & UserInfo.SelectLoc & "'", "")
        Public Property Control As CheckedListBoxControl
        Public WriteOnly Property Datasource As DataTable
            Set(value As DataTable)
                Using dtResult As DataTable = value
                    Dim dr As DataRow = dtResult.NewRow
                    dr(ValueMember) = "0"
                    dr(DisplayMember) = "เลือกทั้งหมด"
                    dtResult.Rows.InsertAt(dr, 0)
                    Control.DataSource = If(value.Rows.Count = 1, Nothing, dtResult)
                End Using
            End Set
        End Property
        Public ValueMember As String
        Public DisplayMember As String
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
    Namespace LoadDB
        Public Class Lookup
            Private Category As SearchLookUpEdit
            Public Property DefCat As SearchLookUpEdit
                Set(value As SearchLookUpEdit)
                    Category = value
                    With Category.Properties
                        SQL = "SELECT catID,catName FROM tbCategory"
                        dsTbl("cat")
                        .DisplayMember = "catName"
                        .ValueMember = "catID"
                        .DataSource = dsTbl("cat")
                        .PopulateViewColumns()
                    End With
                End Set
                Get
                    Return Category
                End Get
            End Property
        End Class
        Public Class ListBox
            Public Property CatID As String
            Private clbControl As New CheckListBox
            Public Property DefSubcat As CheckedListBoxControl
                Set(value As CheckedListBoxControl)
                    SQL = "SELECT CatID+SubCatID IDValue,SubCatName FROM tbSubcategory"
                    SQL &= " WHERE CatID ='" & CatID & "'"
                    dsTbl("clbsubcat")
                    With clbControl
                        .Control = value
                        .ValueMember = "IDValue"
                        .DisplayMember = "SubCatName"
                        .Datasource = DS.Tables("clbsubcat")
                    End With
                End Set
                Get
                    Return myChecklistBox.Control
                End Get
            End Property

        End Class
    End Namespace
End Namespace
Public Class MainCore

End Class
