Imports System.IO
Module Main
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(",")
                Dim sonuc As Integer = -1
                For i As Integer = 0 To words(0).Length - 1
                    If words(0).Substring(i, 1) = words(1) Then sonuc = i
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module