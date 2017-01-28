Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sayi As Integer = 0
                Dim num As Integer = Convert.ToInt32(line)
                If num < 10 Then : sayi = 1
                ElseIf num < 27 Then : sayi = 2
                ElseIf num < 100 Then : sayi = 1
                ElseIf num < 127 Then : sayi = 3
                ElseIf num < 200 Then : sayi = 2
                ElseIf num < 227 Then : sayi = 3
                Else : sayi = 4
                End If

                Console.WriteLine(sayi.ToString())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
