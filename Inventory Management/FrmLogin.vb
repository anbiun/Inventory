
Imports ConDB.Main
Imports System.IO
Imports System.Net
Imports System.Text
Public Class FrmLogin
    'Public Login As New UserLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False
        Dim numLines As Integer = 0
        Dim UpdateDetail As String = String.Empty

        Dim Stat As Integer = 0
        Using sr As New StreamReader("version.txt")
            Dim line As String = sr.ReadLine()
            While line IsNot Nothing
                numLines = numLines + 1
                If line.Contains("version=") Then Version = line.Replace("version=", String.Empty)
                line = sr.ReadLine()

                If line IsNot Nothing AndAlso line.Contains("[") Then
                    Stat = 1
                ElseIf line IsNot Nothing AndAlso String.IsNullOrEmpty(line) Then
                    Stat = 0
                End If

                If Stat = 1 Then UpdateDetail &= line & vbNewLine
            End While
        End Using
        Me.Text += " v." + Version
        StartCon()
        LoadDef()
    End Sub
    Private Sub LoadDef()
        loadSuccess = False
        TxtUser.Text = ""
        TxtPassword.Text = ""
        TxtUser.Focus()
        pnSelectLoc.Visible = False
        BtnOK.Text = "เข้าสู่ระบบ"
        loadSuccess = True
    End Sub
    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown, TxtUser.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            UserInfo.Login()
            showSelectLoc()
        End If
    End Sub
    Private Sub LLBRegister_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LLBRegister.LinkClicked
        MsgBox("Register")
        'FrmRegister.ShowDialog()
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        If BtnOK.Text <> "ตกลง" Then
            UserInfo.Login()
            showSelectLoc()
        Else
            If comboLoc.Items.Count > 0 Then
                UserInfo.SelectLoc = comboLoc.SelectedValue
                UserInfo.LocName = comboLoc.Text
            Else
                Exit Sub
            End If
            If UserInfo.SelectLoc IsNot Nothing Then
                FrmMain.Show()
                Me.Hide()
                LoadDef()
            End If
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If pnSelectLoc.Visible = True Then
            LoadDef()
            UserInfo.Logout()
            Exit Sub
        End If

        If MessageBox.Show("คุณต้องการปิดการทำงานใช่หรือไม่ ?", "คำยืนยัน",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else
            UserInfo.Logout()
        End If
    End Sub
    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged
        If loadSuccess = False Then Exit Sub
        UserInfo.UserID = Trim(TxtUser.Text)
    End Sub
    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        If loadSuccess = False Then Exit Sub
        UserInfo.Password = Trim(TxtPassword.Text)
    End Sub
    Private Sub comboLoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboLoc.SelectedIndexChanged
        If loadSuccess = False Then Exit Sub
        UserInfo.SelectLoc = comboLoc.SelectedValue
        UserInfo.LocName = comboLoc.Text
    End Sub
    Private Sub showSelectLoc()
        loadSuccess = False
        If UserInfo.Stat > 0 Then
            pnSelectLoc.Visible = True
            SQL = "SELECT tbLocation.LocID, tbLocation.LocName, tbLocation.LocShort, tbLogin.UserID"
            SQL &= " FROM tbLocation INNER JOIN tbLocation_Permis ON tbLocation.LocID = tbLocation_Permis.LocID_Src "
            SQL &= " INNER JOIN tbLogin ON tbLocation_Permis.UserID = tbLogin.UserID"
            SQL &= " WHERE tbLocation_Permis.UserID = '" & UserInfo.UserID & "'"
            If UserInfo.Permis > UserGroup.ApproveUser Then
                SQL = "SELECT LocID,LocName FROM tbLocation"
            End If
            dsTbl("location")
            With comboLoc
                .DataSource = dsTbl("location")
                .DisplayMember = "LocName"
                .ValueMember = "LocID"
            End With
            BtnOK.Text = "ตกลง"
        Else
            LoadDef()
        End If
        loadSuccess = True
    End Sub
    Private Sub FrmLogin_Close(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class