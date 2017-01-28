Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim fibonecci(100) As Integer
        fibonecci(0) = 0
        fibonecci(1) = 1
        For i As Integer = 1 To 40
            fibonecci(i + 1) = fibonecci(i) + fibonecci(i - 1)
        Next
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()

                Console.WriteLine(fibonecci(Convert.ToInt32(line)))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
