Public Class F_UserDetails

    Private ReadOnly TempState As C_State
    Private TempUser As C_User
    Public Event UserAdded()
    Public Event UserEdited()
    Private Event ProceedBtnClicked()

    Public Sub New(ByRef parState As C_State, Optional parUser As C_User = Nothing)
        InitializeComponent()
        TempState = parState
        TempUser = parUser
        If Not TempUser Is Nothing Then InitFormForEdit()
    End Sub
    Private Sub SignaturePathBtn_Click(sender As Object, e As EventArgs) Handles btnSignaturePath.Click
        Dim sigPath As String = GetSigPathFromUser()
        lblSIFPValue.Text = sigPath
        picSignature.ImageLocation = sigPath
        If sigPath <> "" Then picSignature.Load()
    End Sub

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Icon = g_Icon
        CenterForm(Me)
        CenterControlHorizontally(Me, btnProceed)
        CenterControlHorizontally(Me, picSignature)
    End Sub

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        RaiseEvent ProceedBtnClicked()
    End Sub

    Private Sub EH_ProceedBtnClicked() Handles Me.ProceedBtnClicked
        If UserInfoValid() Then
            If TempUser Is Nothing Then
                TempUser = CreateNewUser()
                TempState.Users.Add(TempUser)
                TempUser = Nothing
                RaiseEvent UserAdded()
            Else
                TempUser.FullName = txtFullName.Text
                TempUser.Salt = GetSaltString()
                TempUser.HashedPw = GetHashedPw(txtPassword.Text, TempUser.Salt)
                TempUser.SigPath = lblSIFPValue.Text
                RaiseEvent UserEdited()
            End If
            Close()
        End If
    End Sub

    Private Sub InitFormForEdit()
        Text = "Edit User"
        txtFullName.Text = TempUser.FullName
        txtUsername.Text = TempUser.Username
        txtUsername.Enabled = False
        lblSIFPValue.Text = TempUser.SigPath
        picSignature.ImageLocation = lblSIFPValue.Text
        btnProceed.Text = "Save User Details"
    End Sub

    Private Function UserInfoValid() As Boolean
        If txtFullName.Text = "" Then
            MsgBox("Enter users full name.")
            txtFullName.Select()
            Return False
        End If

        If txtUsername.Text = "" Then
            MsgBox("Enter username.")
            txtUsername.Select()
            Return False
        End If

        If txtPassword.Text = "" Then
            MsgBox("Enter a password.")
            txtPassword.Select()
            Return False
        End If

        If txtRetypePw.Text = "" Then
            MsgBox("Retype your password.")
            txtRetypePw.Select()
            Return False
        End If

        If txtPassword.Text <> txtRetypePw.Text Then
            MsgBox("Passwords do not match.")
            txtPassword.Clear()
            txtRetypePw.Clear()
            txtPassword.Select()
            Return False
        End If

        Return True
    End Function

    Public Function CreateNewUser() As C_User
        Dim fn As String = txtFullName.Text
        Dim un As String = txtUsername.Text
        Dim pw As String = txtPassword.Text
        Dim salt As String = GetSaltString()
        Dim hp As String = GetHashedPw(pw, salt)
        Dim sp As String = lblSIFPValue.Text

        Dim u As New C_User(fn, un, salt, hp, sp)
        Return u
    End Function

    Private Function GetSigPathFromUser() As String
        Dim fileName As String = ""
        Dim ofd As New OpenFileDialog()
        With ofd
            .Title = "Please select a signature image file."
            .Filter = "jpg (*.jpg)|*.jpg"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With
        If ofd.ShowDialog() = DialogResult.OK Then
            fileName = ofd.FileName
        End If
        Return fileName
    End Function
End Class