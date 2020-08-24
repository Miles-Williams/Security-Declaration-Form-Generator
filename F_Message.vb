Imports System.Text

Public Class F_Message
    Private Sub F_Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub

    Private Sub F_Message_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim i As Integer = 1
        Dim sb As New StringBuilder

        While Not g_Validated
            If i = 4 Then
                i = 1
                sb.Clear()
            End If
            sb.Append(".")
            lblValidating.Text = sb.ToString
            CenterControl(Me, lblValidating)
            Wait(900)
            i += 1
        End While

        g_Validated = False
        Close()
    End Sub

End Class