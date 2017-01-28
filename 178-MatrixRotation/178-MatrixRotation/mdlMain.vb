Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim matriks() As String = line.Split(" ")
                Dim maks As Integer = Math.Sqrt(matriks.Length)
                Dim sonuc As String = ""
                'loop
                For i As Integer = 0 To maks - 1
                    For j As Integer = maks - 1 To 0 Step -1
                        sonuc &= matriks((j * maks) + i) & " "
                    Next
                Next
                'show time
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
