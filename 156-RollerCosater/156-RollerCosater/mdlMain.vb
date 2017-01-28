Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim buyukMu As Boolean = True
                Dim sonuc As String = ""
                For i As Integer = 0 To line.Length - 1
                    If (line(i) >= "a" And line(i) <= "z") Or (line(i) >= "A" And line(i) <= "Z") Then
                        If buyukMu = True Then
                            sonuc &= UCase(line(i)) : buyukMu = False
                        Else
                            sonuc &= LCase(line(i)) : buyukMu = True
                        End If
                    Else
                        sonuc &= line(i)
                    End If
                Next

                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
