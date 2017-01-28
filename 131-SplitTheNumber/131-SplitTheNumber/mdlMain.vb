Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split(" ")
                Dim num1 As String = ""
                Dim num2 As String = ""
                Dim add As Boolean = False
                Dim j As Integer = 0
                'looping
                For i As Integer = 0 To parts(1).Length
                    If parts(1)(i) = "+" Then : add = True : j = i : Exit For
                    ElseIf parts(1)(i) = "-" Then : add = False : j = i : Exit For
                    End If
                Next
                num1 = Left(parts(0), j)
                num2 = Mid(parts(0), j + 1)
                'sonuc
                Dim sonuc As Integer = IIf(add, Convert.ToInt32(num1) + Convert.ToInt32(num2), Convert.ToInt32(num1) - Convert.ToInt32(num2))
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
