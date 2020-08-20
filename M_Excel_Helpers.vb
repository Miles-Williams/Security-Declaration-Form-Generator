Imports Microsoft.Office
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Module M_Excel_Helpers

    Public Sub PassToExcel(parExcelData As C_ExcelData)

        Dim Proceed As Boolean = False
        'Dim xlApp As Excel.Application = Nothing
        'Dim xlWorkBooks As Excel.Workbooks = Nothing
        'Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        'Dim xlWorkSheets As Excel.Sheets = Nothing
        'Dim xlCells As Excel.Range = Nothing

        Dim xlApp = New Excel.Application
        xlApp.DisplayAlerts = False

        Dim tempFilePath As String = Path.GetTempFileName()
        File.WriteAllBytes(tempFilePath, My.Resources.SdfTemplate)

        Dim xlWorkBooks = xlApp.Workbooks
        Dim xlWorkBook = xlWorkBooks.Open(Path.GetFullPath(tempFilePath))
        Dim xlWorkSheets = xlWorkBook.Sheets


        For x As Integer = 1 To xlWorkSheets.Count
            xlWorkSheet = CType(xlWorkSheets(x), Excel.Worksheet)

            If xlWorkSheet.Name = My.Resources.ExcelSheetName Then
                Proceed = True
                Exit For
            End If

            Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkSheet)
            xlWorkSheet = Nothing
        Next

        FillInForm(xlWorkSheet, parExcelData)

        If Proceed Then
            PrintExcelDocument(xlWorkSheet, parExcelData)
        Else
            MessageBox.Show(My.Resources.ExcelSheetName & " not found.")
        End If

        Dim xlCells = xlApp.Range("A1:B24")

        SaveToPdf(parExcelData, xlCells)

        xlWorkBook.Close()
        xlApp.UserControl = True
        xlApp.Quit()

        If Not IsNothing(xlCells) Then ReleaseComObject(xlCells)
        If Not IsNothing(xlWorkSheets) Then ReleaseComObject(xlWorkSheets)
        If Not IsNothing(xlWorkSheet) Then ReleaseComObject(xlWorkSheet)
        If Not IsNothing(xlWorkBook) Then ReleaseComObject(xlWorkBook)
        If Not IsNothing(xlWorkBooks) Then ReleaseComObject(xlWorkBooks)
        If Not IsNothing(xlApp) Then ReleaseComObject(xlApp)

    End Sub
    Public Sub ReleaseComObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    Private Sub FillInForm(ByRef parWorkSheet As Excel.Worksheet, ByRef parExcelData As C_ExcelData)

        parWorkSheet.Range("Consignor").Value = parExcelData.FullName
        parWorkSheet.Range("Contents_Of_Consignment").Value = parExcelData.Contents
        parWorkSheet.Range("Consignment_Number").Value = parExcelData.ConNumbers
        parWorkSheet.Range("Issue_Date").Value = parExcelData.IssuedOn

        If parExcelData.SigPath <> "" Then
            parWorkSheet.Shapes.AddPicture(parExcelData.SigPath, Core.MsoTriState.msoFalse, Core.MsoTriState.msoCTrue, 130, 900, 300, 100)
        End If

    End Sub

    Private Sub PrintExcelDocument(parWkSht As Excel.Worksheet, parExcelData As C_ExcelData)

        Dim paperCopies As Integer = parExcelData.PaperCopies
        Dim stickerCopies As Integer = parExcelData.StickerCopies

        Select Case parExcelData.PrintMedium
            Case E_PrintMedium.Both
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.StickerPrinter, Copies:=stickerCopies)
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.PaperPrinter, Copies:=paperCopies)
            Case E_PrintMedium.Paper
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.PaperPrinter, Copies:=paperCopies)
            Case E_PrintMedium.Sticker
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.StickerPrinter, Copies:=stickerCopies)
        End Select

    End Sub

End Module
