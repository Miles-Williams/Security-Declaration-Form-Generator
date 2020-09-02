Imports System.IO
Imports System.Reflection
Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Module M_CustomFont
    Public Function LoadFont(Asm As Assembly, Name As String, Size As Integer, Style As FontStyle) As Font
        Using pfc As New PrivateFontCollection
            Dim Bytes() As Byte = GetFontData(Asm, Name)
            Dim Ptr As IntPtr = Marshal.AllocCoTaskMem(Bytes.Length)
            Marshal.Copy(Bytes, 0, Ptr, Bytes.Length)
            pfc.AddMemoryFont(Ptr, Bytes.Length)
            Marshal.FreeCoTaskMem(Ptr)
            Return New Font(pfc.Families(0), Size, Style)
        End Using
    End Function
    Public Function GetFontData(Asm As Assembly, Name As String) As Byte()
        Using Stream As Stream = Asm.GetManifestResourceStream(Name)
            If (Stream Is Nothing) Then Throw New Exception(String.Format("Unable to load font '{0}'", Name))
            Dim Buffer() As Byte = New Byte(CInt(Stream.Length - 1)) {}
            Stream.Read(Buffer, 0, CInt(Stream.Length))
            Return Buffer
        End Using
    End Function

    'Dim f As Font = LoadFont([GetType].Assembly, "Security_Declaration_Form_Generator.WM_Cond_wgl4_0.ttf", 14, FontStyle.Regular)
    'Dim f As Font = LoadFont(Reflection.Assembly.GetExecutingAssembly, "Security_Declaration_Form_Generator.WM_Cond_wgl4_0.ttf", 14, FontStyle.Regular)
End Module
