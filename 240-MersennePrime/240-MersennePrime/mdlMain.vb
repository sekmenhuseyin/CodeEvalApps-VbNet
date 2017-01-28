Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim primes() As Integer = {3, 7, 31, 127, 8191, 131071, 524287}
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim sonuc As String = ""
                Dim line As Integer = Convert.ToInt32(sr.ReadLine())
                For Each item As Integer In primes
                    If line > item Then
                        If sonuc <> "" Then sonuc &= ", "
                        sonuc &= item.ToString()
                    End If
                Next
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
