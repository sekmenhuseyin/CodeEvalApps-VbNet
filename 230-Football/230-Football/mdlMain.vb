Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim countries() As String = line.Split("|")
                Dim teams(UBound(countries), 7)
                Dim sonuc As String = ""
                'loop
                For i As Integer = 0 To UBound(countries)
                    countries(i) = countries(i).Trim()
                    Dim parts() As String = countries(i).Split(" ")
                    Dim dictionary As New Dictionary(Of String, List(Of Integer))


                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
