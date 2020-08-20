Public Class F_WinUserValidate

    Public Event WinUserValidated()
    Private Event ValidateWinUser()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub F_WinUserValidate_Load(sender As Object, e As EventArgs) Handles Me.Load
        Icon = g_Icon
        CenterControlHorizontally(Me, btnValidate)
        CenterForm(Me)
    End Sub

    Private Sub ValidateBtn_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        RaiseEvent ValidateWinUser()
    End Sub

    Private Async Sub EH_ValidateWinUser() Handles Me.ValidateWinUser
        Dim pw As String = txtPassword.Text
        Dim d As String = Environment.UserDomainName
        Dim un As String = Environment.UserName

        If pw = "" Then Exit Sub

        Dim validTask As Task(Of Boolean) = ValidateAsync(un, pw)

        Dim f As New F_Message

        f.ShowDialog()

        Dim valid As Boolean = Await validTask

        f.Close()

        If Not valid Then
            MsgBox("Incorrect password.")
            txtPassword.Clear()
            txtPassword.Select()
            Exit Sub
        End If

        RaiseEvent WinUserValidated()
        Close()
    End Sub

    Private Async Function ValidateAsync(parUn As String, parPw As String) As Task(Of Boolean)
        Dim b As Boolean
        b = Await Task.Run(Function() g_context.ValidateCredentials(parUn, parPw))
        g_Validated = True
        Return b
    End Function

End Class