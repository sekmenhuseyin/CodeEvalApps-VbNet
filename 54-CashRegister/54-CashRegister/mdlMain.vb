Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim nums() As String = line.Split(";")
                Dim num1, num2 As Decimal
                num1 = Convert.ToDecimal(nums(0))
                num2 = Convert.ToDecimal(nums(1))
                num2 -= num1

                If num2 < 0 Then
                    Console.WriteLine("ERROR")
                ElseIf num2 = 0 Then
                    Console.WriteLine("ZERO")
                Else
                    Console.WriteLine(num2)
                End If
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
