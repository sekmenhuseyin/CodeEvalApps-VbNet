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
                Dim carpan As Integer = 1
                Dim sonuc As Boolean = False
                While sonuc = False
                    If (num2 * carpan) >= num1 Then sonuc = True : num2 *= carpan
                    carpan += 1
                End While
                Console.WriteLine(num2)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
