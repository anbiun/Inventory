Public Class InOutFunc
    Public Unit1 As Double = 0
    Public Unit3 As Double = 0
    Public Ratio As Double = 0
    Public GroupTag As Integer

    Public Function Result() As Boolean
        Dim txtUnit1Val As Double = Unit1
        Dim txtUnit3Val As Double = Unit3
        'Unit3 = txtUnit3.Value
        'Unit1 = txtUnit1.Value
        If Ratio <= 0 Then MessageBox.Show("กรุณาตรวจสอบค่า Ratio", "Ratio มีค่าเป็น " & Ratio, MessageBoxButtons.OK, MessageBoxIcon.Stop) : Return False
        If Unit3 = 0 And Unit1 = 0 Then
            MessageBox.Show("กรุณากรอกจำนวนให้ถูกต้อง", "จำนวนไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        Else
            If GroupTag = 1 Then
                'หาค่าเศษ Unit1 ให้ลัง
                Dim Mdd As Double
                Unit3 = Unit1 * Ratio + Unit3
                Mdd = (Unit3 Mod Ratio) / 10

                If Mdd = 0 Then
                    Unit1 = Unit3 / Ratio
                Else
                    Unit1 = (Unit3 \ Ratio) + Mdd
                End If
            Else
                Unit1 = Math.Round(txtUnit1Val + (txtUnit3Val / Ratio), 1)
                Unit3 = Math.Round(txtUnit1Val * Ratio + txtUnit3Val, 1)
            End If
            Return True
        End If
    End Function
    'chk Input 0
End Class