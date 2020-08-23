﻿Public Class C_ExcelData

    Public Property Contents As String
    Public Property FirstConNumber As String
    Public Property ConNumbers As String
    Public Property IssuedOn As String
    Public Property PaperCopies As Integer
    Public Property StickerCopies As Integer
    Public Property PrintMedium As E_PrintMedium
    Public Property Destination As E_Destination
    Public Property SaveDirectoryRoot As String
    Public Property PaperPrinter As String
    Public Property StickerPrinter As String
    Public Property FullName As String
    Public Property SigPath As String

    'Public Enum E_Destination
    '    Domestic
    '    International
    'End Enum

    'Public Enum E_PrintMedium
    '    Paper
    '    Sticker
    '    Both
    '    None
    'End Enum

    Public Sub New(parContents As String,
                   parFirstCon As String,
                   parConNumbers As String,
                   parIssuedOn As String,
                   parPaperCopies As Integer,
                   parStickerCopies As Integer,
                   parPrintMedium As E_PrintMedium,
                   parDestination As E_Destination,
                   parSdr As String,
                   parPaperPrinter As String,
                   parStickerPrinter As String,
                   Optional parFullName As String = "",
                   Optional parSigPath As String = "")

        Contents = parContents
        FirstConNumber = parFirstCon
        ConNumbers = parConNumbers
        IssuedOn = parIssuedOn
        PaperCopies = parPaperCopies
        StickerCopies = parStickerCopies
        PrintMedium = parPrintMedium
        Destination = parDestination
        SaveDirectoryRoot = parSdr
        PaperPrinter = parPaperPrinter
        StickerPrinter = parStickerPrinter
        FullName = parFullName
        SigPath = parSigPath

    End Sub

End Class
