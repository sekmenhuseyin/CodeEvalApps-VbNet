Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(" ")
                Dim sonuc As String = ""
                For i As Integer = 0 To words(0).Length - 1
                    If words(1).Substring(i, 1) = "1" Then sonuc &= UCase(words(0).Substring(i, 1)) Else sonuc &= LCase(words(0).Substring(i, 1))
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
