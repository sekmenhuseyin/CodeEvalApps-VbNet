Imports System.IO
Imports System.Text.RegularExpressions

Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim total As Integer = 0
                Dim tmp As String
                Dim regex As Regex = New Regex("(""id"": [\d]+(,))")
                Dim match As Match = regex.Match(line)
                Do While match.Success
                    tmp = match.Value.Replace("""id"": ", "").Replace(",", "")
                    total += CInt(tmp)
                    match = match.NextMatch()
                Loop
                Console.WriteLine(total)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
