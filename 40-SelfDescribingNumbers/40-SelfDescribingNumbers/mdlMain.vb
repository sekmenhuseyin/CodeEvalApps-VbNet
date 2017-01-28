Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sayi, digit, digit2 As Integer
                Dim sonuc As Byte = 1
                'loop each number
                For i As Integer = 0 To line.Length - 1
                    digit = Convert.ToInt32(line.Substring(i, 1))
                    sayi = 0

                    For j As Integer = 0 To line.Length - 1
                        digit2 = Convert.ToInt32(line.Substring(j, 1))

                        If i = digit2 Then sayi += 1

                    Next
                    If sayi <> digit Then sonuc = 0

                Next
                Console.WriteLine(sonuc.ToString())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
