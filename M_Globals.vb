Imports System.DirectoryServices.AccountManagement
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Win32

Module M_Globals
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

    Public g_context As PrincipalContext
    Public g_Icon As Icon
    Public g_Validated

    Public Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Public Function ContainsInvalidFilenameChars(s As String) As Boolean
        Return s.IndexOfAny("<>/\:*?|""".ToCharArray()) <> -1
    End Function

    Public Sub CenterForm(ByRef parForm As Form)
        parForm.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (parForm.Width / 2)
        parForm.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (parForm.Height / 2)
    End Sub

    Public Sub CenterControlHorizontally(ByRef parForm As Form, ByRef parControl As Control)
        parControl.Left = (parForm.ClientSize.Width / 2) - (parControl.Width / 2)
    End Sub

    Public Sub CenterControl(ByRef parForm As Form, ByRef parControl As Control)
        parControl.Left = (parForm.ClientSize.Width / 2) - (parControl.Width / 2)
        parControl.Top = (parForm.ClientSize.Height / 2) - (parControl.Height / 2)
    End Sub
    Private Function UseLightIcon() As Boolean
        Dim key As RegistryKey
        key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\DWM")

        'Returns an ABGR of the users chosen accent color
        Dim oAccentColor As Object = key.GetValue("AccentColor")

        'Returns true if the accent color is applied to title bars and window borders
        Dim oColorPrevalance As Object = key.GetValue("ColorPrevalence")

        'Convert the ABGR to a hex value and then to a string so that
        'the r, g, and b values can be plucked out
        Dim s As String = Hex(oAccentColor).ToString()
        Dim rs As String = Mid(s, 7, 2)
        Dim gs As String = Mid(s, 5, 2)
        Dim bs As String = Mid(s, 3, 2)

        'Convert the values back to integers to be used in the darkness calculation
        Dim r As Integer = Convert.ToInt32(rs, 16)
        Dim g As Integer = Convert.ToInt32(gs, 16)
        Dim b As Integer = Convert.ToInt32(bs, 16)

        Dim isDarkAccent As Boolean = ((5 * CInt(g)) + (2 * CInt(r)) + CInt(b)) <= 1024

        If oColorPrevalance <> 0 Then If isDarkAccent Then Return True

        Return False

    End Function

    Public Sub InitializeIcon()
        If UseLightIcon() Then
            g_Icon = My.Resources.WeidLogoLightGrey
        Else
            g_Icon = My.Resources.WeidLogo
        End If
    End Sub

    Public Function DeserializeState() As C_State
        'Get saved State from .bin file or else a new State
        Dim AppState As C_State

        If File.Exists(My.Resources.StateFileName) Then
            Dim fs As Stream = File.OpenRead(My.Resources.StateFileName)
            Dim deserializer As New BinaryFormatter
            AppState = CType(deserializer.Deserialize(fs), C_State)
            fs.Close()
        Else
            AppState = New C_State
        End If

        Return AppState
    End Function

    Public Sub SerializeState(parState As C_State)
        'Save State object to .bin file
        Dim fs As Stream = File.Create(My.Resources.StateFileName)
        Dim serializer As New BinaryFormatter
        serializer.Serialize(fs, parState)
        fs.Close()
    End Sub

    Public Function GetCopyOfState(parState As C_State) As C_State
        'Get a deep copy of the State object
        SerializeState(parState)
        Dim AppState As C_State = DeserializeState()
        Return AppState
    End Function

    Public Sub PrepareStateForClose(ByRef parState As C_State)
        parState.VolatileState.CurrentUser = Nothing
        parState.VolatileState.FirstConNumber = ""
        parState.VolatileState.ConNumbers = ""
    End Sub

    Public Function GetSHA512String(ByVal parInString) As String
        Dim sha512 As SHA512 = SHA512.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(parInString)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

    Public Function GetSaltString() As String
        Dim rng As New RNGCryptoServiceProvider
        Dim buffer(15) As Byte
        rng.GetBytes(buffer)
        Return Convert.ToBase64String(buffer)
    End Function

    Public Function GetHashedPw(ByVal parPw As String, parSalt As String) As String
        Return GetSHA512String(parPw & parSalt)
    End Function

    Public Sub CheckForExcel()
        Dim officeType As Type = Type.GetTypeFromProgID("Excel.Application")
        If officeType Is Nothing Then MsgBox("This application requires Microsoft Excel 2013 or later to function.")
    End Sub

    Public Async Sub GetContextAsync()
        'Run async because retreiving a context takes around a second
        g_context = Await Task.Run(Function() New PrincipalContext(ContextType.Domain))
    End Sub

    Public Sub Wait(ByVal parMilliseconds As Double, Optional ByRef BreakCondition As Boolean = False)
        Dim waitUntil As Date
        waitUntil = Now.AddMilliseconds(parMilliseconds)
        Do Until Now > waitUntil
            If BreakCondition Then Exit Do
            Application.DoEvents()
        Loop
    End Sub

End Module
