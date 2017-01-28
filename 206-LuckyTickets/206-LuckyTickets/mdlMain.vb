Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'find lucky nums count
        For i As Integer = 1 To 50

        Next

        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                'TODO:

                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
