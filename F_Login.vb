Imports System.Drawing.Text

Public Class F_Login
    Private ReadOnly validateUser As Boolean

    Private ReadOnly AppState As C_State
    Private ReadOnly pfc As New PrivateFontCollection
    Private weidFont As Font

    Public Event LoginSuccess()
    Private Event TryLogin()

    Public Sub New(ByRef parState As C_State, Optional parValidateUser As Boolean = False)
        InitializeComponent()
        Me.AppState = parState
        Me.validateUser = parValidateUser
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim f As String = My.Resources.WeidFontFile
        Me.pfc.AddFontFile(f)
        Me.weidFont = New Font(Me.pfc.Families(0), 14)
        Icon = g_Icon
        SetFormsCustomFont(Me, Me.weidFont)
        CenterControlHorizontally(Me, btnLogin)
        CenterForm(Me)
        If Me.validateUser Then
            Text = "Validate"
            txtUsername.Text = Me.AppState.VolatileState.CurrentUser.Username
            txtUsername.Enabled = False
            btnLogin.Text = "Validate"
        End If
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        RaiseEvent TryLogin()
    End Sub

    Private Sub LoginBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.ForeColor = g_WeidOrange
        btnLogin.BackColor = Color.White
    End Sub

    Private Sub LoginBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.ForeColor = Color.Black
        btnLogin.BackColor = Color.White
    End Sub

    Private Sub LoginBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseDown
        If e.Button = MouseButtons.Left Then
            btnLogin.ForeColor = Color.White
            btnLogin.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub LoginBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseUp
        btnLogin.ForeColor = Color.Black
        btnLogin.BackColor = Color.White
    End Sub
    Private Sub EH_TryLogin() Handles Me.TryLogin
        If LoginInfoValid() Then
            If UserLoggedIn(txtUsername.Text, txtPassword.Text, Me.AppState) Then
                RaiseEvent LoginSuccess()
                Close()
            End If
        End If
    End Sub
    Private Function LoginInfoValid() As Boolean
        If txtUsername.Text = "" Then
            MsgBox("Enter a valid username to continue.")
            txtUsername.Select()
            Return False
        End If

        If txtPassword.Text = "" Then
            MsgBox("Enter a valid password to continue.")
            txtPassword.Select()
            Return False
        End If

        Return True
    End Function

    Public Function UserLoggedIn(parUsername As String, parPassword As String, parState As C_State) As Boolean
        Dim hashedPw As String

        For Each u As C_User In parState.Users
            If parUsername = u.Username Then
                hashedPw = GetSHA512String(parPassword & u.Salt)
                If hashedPw = u.HashedPw Then
                    parState.VolatileState.CurrentUser = u
                    Return True
                Else
                    MsgBox("Incorrect password.")
                    Return False
                End If
            End If
        Next

        MsgBox("Username not found.")
        Return False
    End Function

End Class