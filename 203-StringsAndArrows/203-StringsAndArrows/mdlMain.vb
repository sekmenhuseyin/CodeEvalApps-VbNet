Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sayac As Integer = 0
                For i As Integer = 0 To line.Length - 5
                    If line.Substring(i, 5) = ">>-->" Or line.Substring(i, 5) = "<--<<" Then sayac += 1
                Next
                Console.WriteLine(sayac)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
