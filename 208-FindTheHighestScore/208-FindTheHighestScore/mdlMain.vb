Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim categories() As String = line.Split("|")
                Dim counter() As String = categories(0).Trim().Split(" ")
                Dim numbers(UBound(categories), UBound(counter)) As String
                Dim sonuc As String = ""
                'counter = Nothing
                'put all numbers in one array
                For i As Integer = 0 To UBound(categories)
                    categories(i) = categories(i).Trim()
                    Dim participants() As String = categories(i).Split(" ")
                    For j As Integer = 0 To UBound(participants)
                        numbers(i, j) = participants(j)
                    Next
                Next
                'find the biggest on each category
                For i As Integer = 0 To UBound(counter)
                    Dim num As Integer = numbers(0, i)
                    For j As Integer = 0 To UBound(categories)
                        If num < numbers(j, i) Then num = numbers(j, i)
                    Next
                    sonuc &= num & " "
                Next
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
