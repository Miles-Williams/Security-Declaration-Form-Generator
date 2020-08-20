Imports System.Drawing.Printing

<Serializable()>
Public Class C_State

    Public Property CurrentDestination As E_Destination
    Public Property AddTollPrefix As Boolean
    Public Property PrintMedium As E_PrintMedium
    Public Property StickerCopies As Integer
    Public Property PaperCopies As Integer
    Public Property Contents As String
    Public VolatileState As C_VolatileState
    Public Property Configuration As C_Configuration
    Public Property Users() As List(Of C_User)

    Public Sub New()

        Dim p As New PrinterSettings

        If IsNothing(Users) Then
            Users = New List(Of C_User)
        End If

        If IsNothing(Configuration) Then
            Configuration = New C_Configuration With {
                .CurrentPaperPrinter = p.PrinterName,
                .CurrentStickerPrinter = p.PrinterName,
                .DefaultPaperCopies = 1,
                .DefaultStickerCopies = 1,
                .SaveDirectoryRoot = My.Computer.FileSystem.SpecialDirectories.Desktop.ToString(),
                .DefaultsToDomestic = True,
                .DefaultsToInternational = False,
                .TollPrefixDefault = False,
                .DefaultContents = "Electrical/Electronic Components"
            }
        End If

        If IsNothing(VolatileState) Then

            VolatileState = New C_VolatileState

            If IsNothing(VolatileState.CurrentUser) Then
                VolatileState.CurrentUser = New C_User("", "Guest", "", "")
            End If

            VolatileState.ConNumbers = ""
            VolatileState.FirstConNumber = ""

        End If

        Contents = Configuration.DefaultContents
        PaperCopies = 1
        StickerCopies = 1
        PrintMedium = E_PrintMedium.Both
        AddTollPrefix = False
        CurrentDestination = E_Destination.Domestic

    End Sub

    Public Enum E_Destination
        Domestic
        International
    End Enum

    Public Enum E_PrintMedium
        Paper
        Sticker
        Both
        None
    End Enum

    <Serializable()>
    Public Class C_VolatileState
        Public Property FirstConNumber As String
        Public Property ConNumbers As String
        Public Property CurrentUser As C_User

    End Class

End Class
