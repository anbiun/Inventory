Option Explicit On
Option Strict On
Imports ConDB.Main
Imports DevExpress.Utils
Imports DevExpress.Utils.Text

Namespace POFunction
    Public Class ToolTip
        Public WriteOnly Property ToolTipControl As ToolTipController
            Set(value As ToolTipController)
                _toolTip = value
                AddHandler _toolTip.CalcSize, AddressOf ToolTipSize
            End Set
        End Property
        Private dtPoOrder As DataTable
        Private _toolTip As ToolTipController
        Property MatID As String
        Property ProductID As String
        Property SubCatID As String
        Property UnitName As String

        Sub New()
            Qry()
        End Sub
        Private Sub Qry()
            SQL = "SELECT * FROM vwPo_Detail"
            dsTbl("PoDetail")
            dtPoOrder = DS.Tables("PoDetail").Copy
        End Sub
        Public Function getOwing() As String
            '"0302051"

            Dim Result As String = String.Empty
            If String.IsNullOrEmpty(MatID) Then
                FoundRow = dtPoOrder.Select("ProductID = '" & ProductID & "' AND SubCatID = '" & SubCatID & "'")
            Else
                FoundRow = dtPoOrder.Select("MatID ='" & MatID & "'")
            End If

            If FoundRow.Count > 0 Then
                For i As Integer = 0 To FoundRow.Count - 1
                    Dim Owing As Func(Of Integer, String) = Function(row As Integer)
                                                                Dim remUnitName As String = UnitName
                                                                Dim Delive As String = String.Format("| กำหนดส่ง {0}", CDate(FoundRow(row)("DeliveryDate")).ToShortDateString)
                                                                If FoundRow(row)("Stat").ToString = "0" Then
                                                                    Return String.Format("อยู่ระหว่างจัดซื้อ ({0} {1}) {2}", FoundRow(row)("Owing"), UnitName, Delive)
                                                                Else
                                                                    Return String.Format("ค้างส่ง {0} {1} {2}", FoundRow(row)("Owing").ToString, UnitName, Delive)
                                                                End If
                                                            End Function

                    If FoundRow(i)("Stat").ToString = "1" Then Continue For
                    Result += String.Format(
                        "เลขที่ PO : {0} | {1} {2}",
                        FoundRow(i)("Pono").ToString,
                        Owing(i),
                        vbNewLine)
                Next
            Else
                Result = String.Empty
            End If

            Return Result
        End Function
        Private Sub ToolTipSize(sender As Object, e As ToolTipControllerCalcSizeEventArgs)
            Dim gra As Graphics = e.SelectedControl.CreateGraphics
            Dim Width As Integer = e.Size.Width
            Dim maxWidth As Integer = CInt(gra.MeasureString("M", e.ShowInfo.Appearance.Font, Width).Width) * 40
                e.Size = gra.MeasureString(e.ToolTip, e.ShowInfo.Appearance.Font, maxWidth).ToSize

        End Sub
    End Class
End Namespace
