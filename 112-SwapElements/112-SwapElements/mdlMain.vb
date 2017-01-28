Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split(":")
                Dim numbers() As String = parts(0).Trim().Split(" ")
                Dim swaps() As String = parts(1).Trim().Split(",")
                'tüm değiştirme istekleri boyunca dön
                For i As Integer = 0 To UBound(swaps)
                    Dim vars() As String = swaps(i).Trim.Split("-")
                    ChangeOrder(numbers, vars(0), vars(1))
                Next
                'finish
                Dim sonuc As String = ""
                For i As Integer = 0 To UBound(numbers)
                    sonuc &= numbers(i)
                    If i < UBound(numbers) Then sonuc &= " "
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
    Sub ChangeOrder(dizi() As String, var1 As String, var2 As String)
        Dim tmp As String = dizi(var1)
        dizi(var1) = dizi(var2)
        dizi(var2) = tmp
    End Sub
End Module
