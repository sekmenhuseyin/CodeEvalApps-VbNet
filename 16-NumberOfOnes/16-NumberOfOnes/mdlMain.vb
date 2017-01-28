Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                line = Convert.ToString(Convert.ToInt32(line), 2)
                Dim sayac As Integer = 0
                For i As Integer = 0 To line.Length - 1
                    If line.Substring(i, 1) = "1" Then sayac += 1
                Next
                Console.WriteLine(sayac)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
