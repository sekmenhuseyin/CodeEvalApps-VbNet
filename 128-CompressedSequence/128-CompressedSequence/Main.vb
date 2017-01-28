Imports System.IO
Module Main

    Sub Main(ByVal sArgs() As String)

        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim rakam() As String = line.Split(" ")
                Dim sonuc As String = "" : Dim simdiki As String = "" : Dim sayi As Integer = 0
                For i As Integer = 0 To UBound(rakam)
                    If rakam(i) <> simdiki Then
                        If simdiki <> "" Then
                            If sonuc <> "" Then sonuc &= " "
                            sonuc &= sayi & " " & simdiki
                        End If
                        simdiki = rakam(i) : sayi = 0
                    End If
                    sayi += 1
                Next
                If sonuc <> "" Then sonuc &= " "
                sonuc &= sayi & " " & simdiki

                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub

End Module