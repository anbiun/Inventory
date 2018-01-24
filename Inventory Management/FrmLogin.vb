
Imports ConDB.Main
Imports System.IO
Imports System.Net
Imports System.Text
Imports DevExpress.XtraBars.Docking2010

Public Class FrmLogin
    Dim ctrVisible As New List(Of Control)
    Dim ctrEnable As New List(Of Control)
    'Public Login As New UserLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSuccess = False
        Dim numLines As Integer = 0
        Dim UpdateDetail As String = String.Empty

        ctrVisible.Add(comboloc)
        ctrVisible.Add(lbLoc)
        ctrVisible.Add(WinUIPanel)

        ctrEnable.Add(TxtUser)
        ctrEnable.Add(TxtPassword)
        ctrEnable.Add(btnOK)

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
        For Each item As Control In ctrVisible
            item.Visible = False
        Next
        For Each item As Control In ctrEnable
            item.Enabled = True
        Next
        loadSuccess = False
        TxtUser.Text = ""
        TxtPassword.Text = ""
        TxtUser.Focus()
        'pnSelectLoc.Visible = False
        'BtnOK.Text = "เข้าสู่ระบบ"
        loadSuccess = True
    End Sub
    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown, TxtUser.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            For Each ctr As Control In Me.Controls
                If TypeOf ctr Is TextBox AndAlso String.IsNullOrEmpty(ctr.Text) Then
                    ctr.Focus()
                    Exit Sub
                End If
            Next
            UserInfo.Login()
            showSelectLoc()
        End If
    End Sub
    Private Sub LLBRegister_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MsgBox("Register")
        'FrmRegister.ShowDialog()
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged
        If loadSuccess = False Then Exit Sub
        UserInfo.UserID = Trim(TxtUser.Text)
    End Sub
    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        If loadSuccess = False Then Exit Sub
        UserInfo.Password = Trim(TxtPassword.Text)
    End Sub
    Private Sub comboLoc_SelectedIndexChanged(sender As Object, e As EventArgs)
        If loadSuccess = False Then Exit Sub
        UserInfo.SelectLoc = comboloc.SelectedValue
        UserInfo.LocName = comboloc.Text
    End Sub
    Private Sub showSelectLoc()
        loadSuccess = False
        For Each item As Control In ctrVisible
            item.Visible = True
        Next
        For Each item As Control In ctrEnable
            item.Enabled = False
        Next

        If UserInfo.Stat > 0 Then
            'pnSelectLoc.Visible = True
            SQL = "SELECT tbLocation.LocID, tbLocation.LocName, tbLocation.LocShort, tbLogin.UserID"
            SQL &= " FROM tbLocation INNER JOIN tbLocation_Permis ON tbLocation.LocID = tbLocation_Permis.LocID_Src "
            SQL &= " INNER JOIN tbLogin ON tbLocation_Permis.UserID = tbLogin.UserID"
            SQL &= " WHERE tbLocation_Permis.UserID = '" & UserInfo.UserID & "'"
            If UserInfo.Permis > UserGroup.ApproveUser Then
                SQL = "SELECT LocID,LocName FROM tbLocation"
            End If
            dsTbl("location")
            With comboloc
                .DataSource = dsTbl("location")
                .DisplayMember = "LocName"
                .ValueMember = "LocID"
            End With
            'BtnOK.Text = "ตกลง"
        Else
            LoadDef()
        End If
        loadSuccess = True
    End Sub
    Private Sub FrmLogin_Close(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub WindowsUIButtonPanel1_ButtonClick(ByVal sender As Object, ByVal e As ButtonEventArgs) Handles WinUIPanel.ButtonClick
        Dim btn As WindowsUIButton = e.Button

        Select Case btn.Tag
            Case "btnLogin"
                Btn_Login()
            Case "btnCancel"
                Btn_Cancel()
        End Select
    End Sub

    Private Sub Btn_Login()
        If comboloc.Items.Count > 0 Then
            UserInfo.SelectLoc = comboloc.SelectedValue
            UserInfo.LocName = comboloc.Text
        Else
            showSelectLoc
            Exit Sub
        End If
        If UserInfo.SelectLoc IsNot Nothing Then
            FrmMain.Show()
            Me.Hide()
            LoadDef()
        End If
    End Sub
    Private Sub Btn_Cancel()
        LoadDef()
        UserInfo.Logout()
        Exit Sub
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        UserInfo.Login()
        showSelectLoc()
    End Sub

End Class