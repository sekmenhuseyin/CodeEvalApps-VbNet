Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim months(,) As String = {{"Jan", 0}, {"Feb", 1}, {"Mar", 2}, {"Apr", 3}, {"May", 4}, {"Jun", 5}, {"Jul", 6}, {"Aug", 7}, {"Sep", 8}, {"Oct", 9}, {"Nov", 10}, {"Dec", 11}}
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim periods() As String = line.Split(";")
                'her bir iş için
                For i As Integer = 0 To UBound(periods)
                    periods(i) = periods(i).Trim()
                    'başlama ve bitiş zamanlarını bul
                    Dim dates() As String = periods(i).Split("-")
                    Dim start() As String = dates(0).Split(" ")
                    Dim ends() As String = dates(1).Split(" ")


                Next

                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
