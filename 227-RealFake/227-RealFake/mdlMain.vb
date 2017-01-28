Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                line = line.Replace(" ", "")
                Dim sonuc As Integer = 0
                'loop numbers
                For i As Integer = 0 To line.Length - 1
                    If i Mod 2 = 0 Then sonuc += (Convert.ToInt32(line.Substring(i, 1))) * 2 Else sonuc += Convert.ToInt32(line.Substring(i, 1))
                Next
                If sonuc Mod 10 = 0 Then Console.WriteLine("Real") Else Console.WriteLine("Fake")
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
