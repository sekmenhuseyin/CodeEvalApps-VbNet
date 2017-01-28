Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim numbers() As String = line.Split(",")
                Dim num1 As Integer = Convert.ToInt32(numbers(0))
                Dim num2 As Integer = Convert.ToInt32(numbers(1))
                Dim sonuc As Integer
                If num1 < num2 Then
                    sonuc = num1
                Else
                    Dim tmp As Integer = Math.Floor(num1 / num2)
                    sonuc = num1 - (tmp * num2)
                End If

                Console.WriteLine(sonuc.ToString())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
