Public Class dlgProgress
    Private remlbProg As String

    Public Sub SetMaxValue(value As Integer)
        remlbProg = lbProg.Text
        Progressbar.Properties.Maximum = value
    End Sub
    Public Sub SetProgress(updateValue As Integer)
        Progressbar.EditValue = updateValue
        lbProg.Text = remlbProg
        lbProg.Text &= " " & updateValue
        lbProg.Text &= " / " & Progressbar.Properties.Maximum
    End Sub
End Class