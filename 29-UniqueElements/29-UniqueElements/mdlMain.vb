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
                Dim sonuc As String = "" : Dim onceki As String = ""
                For i As Integer = 0 To UBound(numbers)
                    If onceki <> numbers(i) Then
                        If sonuc > "" Then sonuc &= ","
                        sonuc &= numbers(i) : onceki = numbers(i)
                    End If

                Next

                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
