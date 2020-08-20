Imports System.Drawing.Printing

Public Class F_Configuration

    Private TempState As C_State

    Private WithEvents NewUserForm As F_UserDetails
    Private WithEvents EditUserForm As F_UserDetails

    Public Event ConfigStateChanged()
    Private Event UsersLstSelectionChanged()
    Private Event EditUserBtnClicked()
    Private Event DeleteUserBtnClicked()
    Private Event TollPrefixDefaultChkChanged()
    Private Event InternationalRbdChanged()

    Public Sub New(ByRef parState As C_State)
        InitializeComponent()
        TempState = parState
    End Sub

    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = g_Icon
        UpdateConfigForm()
        CenterForm(Me)
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        UpdateConfigState()
        RaiseEvent ConfigStateChanged()
        Close()
    End Sub

    Private Sub ApplyBtn_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        UpdateConfigState()
        RaiseEvent ConfigStateChanged()
    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        NewUserForm = New F_UserDetails(TempState)
        NewUserForm.ShowDialog(Me)
    End Sub

    Private Sub UsersLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        RaiseEvent UsersLstSelectionChanged()
    End Sub

    Private Sub SaveDirectoryRoot_Click(sender As Object, e As EventArgs) Handles btnSaveDirectoryRoot.Click
        lblCurrentSaveDirectoryRoot.Text = UserSelectedFolder()
    End Sub

    Private Sub EditUserBtn_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        RaiseEvent EditUserBtnClicked()
    End Sub

    Private Sub DeleteUserBtn_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        RaiseEvent DeleteUserBtnClicked()
    End Sub

    Private Sub TollPrefixDefaultChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkTollPrefixDefault.CheckedChanged
        RaiseEvent TollPrefixDefaultChkChanged()
    End Sub

    Private Sub InternationalRdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbInternational.CheckedChanged
        RaiseEvent InternationalRbdChanged()
    End Sub

    'Custom Event Handlers

    'From child form events
    Private Sub EH_UserAdded() Handles NewUserForm.UserAdded
        UpdateConfigForm()
    End Sub

    Private Sub EH_UserEdited() Handles EditUserForm.UserEdited
        UpdateConfigForm()
    End Sub

    'From internal events
    Private Sub EH_UsersLstSelectionChanged() Handles Me.UsersLstSelectionChanged
        If Not lstUsers.SelectedItem Is Nothing Then
            For Each u As C_User In TempState.Users
                If u.FullName = lstUsers.SelectedItem.ToString() Then
                    picSignature.ImageLocation = u.SigPath
                    If u.SigPath <> "" Then picSignature.Load()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub EH_EditUserBtnClicked() Handles Me.EditUserBtnClicked
        For Each u As C_User In TempState.Users
            If u.FullName = lstUsers.SelectedItem.ToString() Then
                EditUserForm = New F_UserDetails(TempState, u)
                EditUserForm.ShowDialog(Me)
                Exit For
            End If
        Next
    End Sub

    Private Sub EH_DeleteUserBtnClicked() Handles Me.DeleteUserBtnClicked
        For Each u As C_User In TempState.Users
            If u.FullName = lstUsers.SelectedItem.ToString() Then
                lstUsers.Items.Remove(lstUsers.SelectedItem)
                TempState.Users.Remove(u)
                picSignature.ImageLocation = ""
                Exit Sub
            End If
        Next
    End Sub

    Private Sub EH_TollPrefixDefaultChkChanged() Handles Me.TollPrefixDefaultChkChanged
        If chkTollPrefixDefault.Checked = True Then
            rdbInternational.Checked = False
            rdbDomestic.Checked = True
        End If
    End Sub

    Private Sub EH_InternationalRdbChanged() Handles Me.InternationalRbdChanged
        If rdbInternational.Checked = True Then chkTollPrefixDefault.Checked = False
    End Sub

    'Private Procedures

    Private Sub UpdateConfigForm()

        Dim sPrinter As String

        With TempState

            cboCurrentPaperPrinter.Items.Clear()
            cboCurrentStickerPrinter.Items.Clear()

            For Each sPrinter In PrinterSettings.InstalledPrinters
                cboCurrentStickerPrinter.Items.Add(sPrinter)
                cboCurrentPaperPrinter.Items.Add(sPrinter)
            Next sPrinter

            cboCurrentStickerPrinter.Text = .Configuration.CurrentStickerPrinter
            cboCurrentPaperPrinter.Text = .Configuration.CurrentPaperPrinter
            lblCurrentSaveDirectoryRoot.Text = .Configuration.SaveDirectoryRoot
            chkTollPrefixDefault.Checked = .Configuration.TollPrefixDefault
            rdbDomestic.Checked = .Configuration.DefaultsToDomestic
            rdbInternational.Checked = .Configuration.DefaultsToInternational
            txtDefaultPaperCopies.Text = .Configuration.DefaultPaperCopies
            txtDefaultStickerCopies.Text = .Configuration.DefaultStickerCopies
            txtDefaultContents.Text = .Configuration.DefaultContents

            lstUsers.Items.Clear()

            For Each user As C_User In .Users
                lstUsers.Items.Add(user.FullName)
            Next

            picSignature.ImageLocation = ""

        End With
    End Sub

    Private Sub UpdateConfigState()
        With TempState
            .Configuration.CurrentStickerPrinter = cboCurrentStickerPrinter.Text
            .Configuration.DefaultStickerCopies = CInt(txtDefaultStickerCopies.Text)
            .Configuration.CurrentPaperPrinter = cboCurrentPaperPrinter.Text
            .Configuration.DefaultPaperCopies = CInt(txtDefaultPaperCopies.Text)
            .Configuration.SaveDirectoryRoot = lblCurrentSaveDirectoryRoot.Text
            .Configuration.TollPrefixDefault = chkTollPrefixDefault.Checked
            .Configuration.DefaultsToDomestic = rdbDomestic.Checked
            .Configuration.DefaultsToInternational = rdbInternational.Checked
            .Configuration.DefaultContents = txtDefaultContents.Text
        End With
    End Sub

    Private Function UserSelectedFolder() As String
        Dim path As String = ""
        Dim fbd As New FolderBrowserDialog()

        If fbd.ShowDialog() = DialogResult.OK Then
            path = fbd.SelectedPath
        End If

        Return path
    End Function

End Class