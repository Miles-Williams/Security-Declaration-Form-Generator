Imports System.ComponentModel
Imports System.Text

Public Class F_Main
    Private AppState As C_State
    Private TempState As C_State
    Private ExcelData As C_ExcelData

    Private WithEvents ConfigurationForm As F_Configuration
    Private WithEvents LoginForm As F_Login
    Private WithEvents ValidateUserForm As F_Login
    Private WithEvents WinUserValidateForm As F_WinUserValidate

    Private userValidated As Boolean

    Private Event AddConNumToList()
    Private Event RemoveConNumFromList()
    Private Event CreateConsignment()
    Private Event BothPrintersChkChanged()
    Private Event StickerChkChanged()
    Private Event PaperChkChanged()
    Private Event InternationalRdbChanged()
    Private Event DomesticRdbChanged()
    Private Event TollPrefixChkChanged()

    Public Sub New()
        InitializeComponent()
        InitializeIcon()
        AppState = DeserializeState()
        If AppState.VolatileState.CurrentUser Is Nothing Then
            AppState.VolatileState.CurrentUser = New C_User("", "Guest", "", "")
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitMainForm()
        CenterForm(Me)
        CheckForExcel()
    End Sub

    Private Sub F_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PrepareStateForClose(AppState)
        SerializeState(AppState)
    End Sub

    Private Sub AddConsignmentBtn_Click(sender As Object, e As EventArgs) Handles btnAddConsignment.Click
        RaiseEvent AddConNumToList()
    End Sub

    Private Sub CreateConsignmentBtn_Click(sender As Object, e As EventArgs) Handles btnCreateConsignment.Click
        RaiseEvent CreateConsignment()
    End Sub

    Private Sub LoginTsb_Click(sender As Object, e As EventArgs) Handles tsbLogin.Click
        LoginForm = New F_Login(AppState)
        LoginForm.ShowDialog(Me)
    End Sub

    Private Sub ConfigurationTsb_Click(sender As Object, e As EventArgs) Handles tsbConfiguration.Click
        Dim isDomain As String = Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName
        If isDomain = "" Then
            g_IsDomain = False
        Else
            g_IsDomain = True
        End If
        GetContextAsync(g_IsDomain)
        WinUserValidateForm = New F_WinUserValidate()
        WinUserValidateForm.ShowDialog(Me)
    End Sub

    Private Sub BothPrintersChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkBothPrinters.CheckedChanged
        RaiseEvent BothPrintersChkChanged()
    End Sub


    Private Sub StickerChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkSticker.CheckedChanged
        RaiseEvent StickerChkChanged()
    End Sub

    Private Sub PaperChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaper.CheckedChanged
        RaiseEvent PaperChkChanged()
    End Sub

    Private Sub RemoveConsignmentBtn_Click(sender As Object, e As EventArgs) Handles btnRemoveConsignment.Click
        RaiseEvent RemoveConNumFromList()
    End Sub

    Private Sub InternationalRdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbInternational.CheckedChanged
        RaiseEvent InternationalRdbChanged()
    End Sub

    Private Sub DomesticRdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDomestic.CheckedChanged
        RaiseEvent DomesticRdbChanged()
    End Sub

    Private Sub TollPrefixChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkTollPrefix.CheckedChanged
        RaiseEvent TollPrefixChkChanged()
    End Sub

    Private Sub ContentsTxt_TextChanged(sender As Object, e As EventArgs) Handles txtContents.TextChanged
        AppState.Contents = txtContents.Text
    End Sub

    Private Sub DefaultContentsBtn_Click(sender As Object, e As EventArgs) Handles btnDefaultContents.Click
        txtContents.Text = AppState.Configuration.DefaultContents
    End Sub

    Private Sub ConsignmentsLst_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles lstConsignments.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then RaiseEvent RemoveConNumFromList()
    End Sub

    Private Sub ConsignmentTxt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtConsignment.PreviewKeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            RaiseEvent CreateConsignment()
        ElseIf e.KeyCode = Keys.Enter Then
            RaiseEvent AddConNumToList()
        End If
    End Sub

    'Custom Event Handlers

    Private Sub EH_UserValidated() Handles ValidateUserForm.LoginSuccess
        userValidated = True
    End Sub

    Private Sub EH_WinUserValidated() Handles WinUserValidateForm.WinUserValidated
        TempState = GetCopyOfState(AppState)
        ConfigurationForm = New F_Configuration(TempState)
        ConfigurationForm.ShowDialog(Me)
    End Sub

    Private Sub EH_ConfigStateChanged() Handles ConfigurationForm.ConfigStateChanged
        MsgBox("Configuration saved.")
        AppState = GetCopyOfState(TempState)
        InitMainForm()
    End Sub
    Private Sub EH_LoginSuccess() Handles LoginForm.LoginSuccess
        lblCurrentUsername.Text = AppState.VolatileState.CurrentUser.Username
        lblConsignorsFullName.Text = AppState.VolatileState.CurrentUser.FullName
    End Sub

    Private Sub EH_AddConNumToList() Handles Me.AddConNumToList
        Dim consignment As String = txtConsignment.Text
        If consignment <> "" Then
            If ContainsInvalidFilenameChars(consignment) Then
                MsgBox("Consignment number can not contain any of the following characters: " &
                       Environment.NewLine &
                       """ < > | ? \ / * :")
                GoTo Clear
            End If
            If chkTollPrefix.Checked Then consignment = "87750" & consignment
            lstConsignments.Items.Add(consignment)
        End If
Clear:
        txtConsignment.Clear()
        txtConsignment.Select()
    End Sub

    Private Sub EH_RemoveConNumFromList() Handles Me.RemoveConNumFromList
        lstConsignments.Items.Remove(lstConsignments.SelectedItem)
    End Sub

    Private Sub EH_CreateConsignment() Handles Me.CreateConsignment
        If lstConsignments.Items.Count <> 0 Then
            AppState.VolatileState.FirstConNumber = lstConsignments.Items.Item(0)
            AppState.VolatileState.ConNumbers = CreateConNumString(lstConsignments.Items)
            AppState.PaperCopies = txtPaperCopies.Text
            AppState.StickerCopies = txtStickerCopies.Text
            RunPreExcelInit(AppState)
        End If
    End Sub

    Private Sub EH_BothPrintersChkChanged() Handles Me.BothPrintersChkChanged
        If chkBothPrinters.Checked = True Then
            chkPaper.Checked = False
            chkSticker.Checked = False
            chkPaper.Enabled = False
            chkSticker.Enabled = False
            txtPaperCopies.Enabled = True
            txtStickerCopies.Enabled = True
            AppState.PrintMedium = E_PrintMedium.Both
        Else
            chkSticker.Enabled = True
            chkPaper.Enabled = True
            txtStickerCopies.Enabled = False
            txtPaperCopies.Enabled = False
            AppState.PrintMedium = E_PrintMedium.None
        End If
    End Sub

    Private Sub EH_StickerChkChanged() Handles Me.StickerChkChanged
        If chkSticker.Checked = False And chkBothPrinters.Checked = False Then
            txtStickerCopies.Enabled = False
            AppState.PrintMedium = E_PrintMedium.None
            Exit Sub
        End If

        If chkSticker.Checked = True Then
            If AppState.Configuration.CurrentStickerPrinter = "" Then
                MsgBox("Please use the configuration utility to select a sticker printer.", Title:="No sticker printer.")
                chkSticker.Checked = False
                Exit Sub
            End If

            chkPaper.Checked = False
            txtStickerCopies.Enabled = True
            AppState.PrintMedium = E_PrintMedium.Sticker
        End If
    End Sub

    Private Sub EH_PaperChkChanged() Handles Me.PaperChkChanged
        If chkPaper.Checked = False And chkBothPrinters.Checked = False Then
            txtPaperCopies.Enabled = False
            AppState.PrintMedium = E_PrintMedium.None
            Exit Sub
        End If

        If chkPaper.Checked = True Then
            If AppState.Configuration.CurrentPaperPrinter = "" Then
                MsgBox("Please use the configuration utility to select a paper printer.", Title:="No paper printer.")
                chkPaper.Checked = False
                Exit Sub
            End If

            chkSticker.Checked = False
            txtPaperCopies.Enabled = True
            AppState.PrintMedium = E_PrintMedium.Paper
        End If
    End Sub

    Private Sub EH_InternationalRdbChanged() Handles Me.InternationalRdbChanged
        If rdbInternational.Checked = True Then
            chkTollPrefix.Checked = False
            chkTollPrefix.Enabled = False
            AppState.CurrentDestination = E_Destination.International
        Else
            chkTollPrefix.Enabled = True
        End If
    End Sub

    Private Sub EH_DomesticRdbChanged() Handles Me.DomesticRdbChanged
        If rdbDomestic.Checked = True Then AppState.CurrentDestination = E_Destination.Domestic
    End Sub

    Private Sub EH_TollPrefixChkChanged() Handles Me.TollPrefixChkChanged
        AppState.AddTollPrefix = chkTollPrefix.Checked
    End Sub

    'Private Procedures

    Private Sub InitMainForm()
        With AppState
            If .Configuration.DefaultsToInternational Then
                rdbInternational.Checked = True
            Else
                rdbDomestic.Checked = True
            End If

            Select Case .PrintMedium
                Case E_PrintMedium.Paper
                    chkPaper.Checked = True
                    txtPaperCopies.Enabled = True
                Case E_PrintMedium.Sticker
                    chkSticker.Checked = True
                    txtStickerCopies.Enabled = True
                Case E_PrintMedium.Both
                    chkBothPrinters.Checked = True
                    txtPaperCopies.Enabled = True
                    txtStickerCopies.Enabled = True
                Case E_PrintMedium.None
                    chkBothPrinters.Checked = False
                    chkPaper.Checked = False
                    chkSticker.Checked = False
                    txtPaperCopies.Enabled = False
                    txtStickerCopies.Enabled = False
                Case Else
                    chkBothPrinters.Checked = False
                    chkPaper.Checked = False
                    chkSticker.Checked = False
                    txtPaperCopies.Enabled = False
                    txtStickerCopies.Enabled = False
            End Select

            chkTollPrefix.Checked = .Configuration.TollPrefixDefault
            lblStickerPrinter.Text = .Configuration.CurrentStickerPrinter
            txtStickerCopies.Text = .Configuration.DefaultStickerCopies
            lblPaperPrinter.Text = .Configuration.CurrentPaperPrinter
            txtPaperCopies.Text = .Configuration.DefaultPaperCopies
            txtContents.Text = .Configuration.DefaultContents

            If .VolatileState.CurrentUser.Username = "Guest" Then
                lblCurrentUsername.Text = "You are a logged in as a guest."
                lblConsignorsFullName.Text = ""
            Else
                lblCurrentUsername.Text = .VolatileState.CurrentUser.Username
                lblConsignorsFullName.Text = .VolatileState.CurrentUser.FullName
            End If

            Icon = g_Icon
        End With
    End Sub

    Private Function CreateConNumString(ByVal parListItems As ListBox.ObjectCollection) As String
        Dim sb As New StringBuilder
        For Each item As String In parListItems
            sb.AppendLine(item)
        Next
        Return sb.ToString()
    End Function

    Public Sub RunPreExcelInit(ByRef parState As C_State)
        If parState.VolatileState.CurrentUser.Username <> "Guest" Then
            ValidateUserForm = New F_Login(parState, True)
            ValidateUserForm.ShowDialog()
        Else
            userValidated = True
        End If

        If userValidated Then
            ExcelData = New C_ExcelData(parState.Contents,
                                        parState.Configuration.KnownConsignorRef,
                                        parState.VolatileState.FirstConNumber,
                                        parState.VolatileState.ConNumbers,
                                        Date.Now.ToString(),
                                        parState.PaperCopies,
                                        parState.StickerCopies,
                                        parState.PrintMedium,
                                        parState.CurrentDestination,
                                        parState.Configuration.SaveDirectoryRoot,
                                        parState.Configuration.CurrentPaperPrinter,
                                        parState.Configuration.CurrentStickerPrinter,
                                        parState.VolatileState.CurrentUser.FullName,
                                        parState.VolatileState.CurrentUser.SigPath)

            PassToExcel(ExcelData)

            lstConsignments.Items.Clear()
            txtConsignment.Clear()
            txtConsignment.Select()
        End If
    End Sub

    Private Sub AboutTsb_Click(sender As Object, e As EventArgs) Handles tsbAbout.Click
        Dim sb = New StringBuilder()
        sb.AppendLine("Security Declaration Form Generator.")
        sb.AppendLine()
        sb.AppendLine("Version: 1.0.0")
        sb.AppendLine()
        sb.AppendLine("Copyright © Miles Williams 2020.")
        sb.AppendLine()
        sb.AppendLine("For Weidmüller Australia Pty Ltd.")
        sb.AppendLine()
        sb.Append("A tool for automating the process of generating, printing, and saving digitally signed PDF format")
        sb.Append(" ""Security Declaration Forms"" for use with the Department of Home Affairs - Known Consignor Scheme.")
        MsgBox(sb.ToString, MsgBoxStyle.ApplicationModal, "About")
    End Sub

End Class
