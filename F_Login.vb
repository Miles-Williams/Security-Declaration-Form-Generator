Public Class F_Login

    Private ReadOnly AppState As C_State
    Private ReadOnly validateUser As Boolean
    Public Event LoginSuccess()
    Private Event TryLogin()

    Public Sub New(ByRef parState As C_State, Optional parValidateUser As Boolean = False)
        InitializeComponent()
        AppState = parState
        validateUser = parValidateUser
    End Sub
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        RaiseEvent TryLogin()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Icon = g_Icon
        CenterControlHorizontally(Me, btnLogin)
        CenterForm(Me)
        If validateUser Then
            Text = "Validate"
            txtUsername.Text = AppState.VolatileState.CurrentUser.Username
            txtUsername.Enabled = False
            btnLogin.Text = "Validate"
        End If
    End Sub

    Private Sub EH_TryLogin() Handles Me.TryLogin
        If LoginInfoValid() Then
            If UserLoggedIn(txtUsername.Text, txtPassword.Text, AppState) Then
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
                    MsgBox("Login Successful.")
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

    Private Sub PasswordTxt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtPassword.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then RaiseEvent TryLogin()
    End Sub

End Class