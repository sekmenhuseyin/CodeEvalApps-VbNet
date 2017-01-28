Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(",")
                words(1) = words(1).Trim()
                For i As Integer = 0 To words(1).Length - 1
                    words(0) = words(0).Replace(words(1).Substring(i, 1), "")

                Next
                Console.WriteLine(words(0))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
