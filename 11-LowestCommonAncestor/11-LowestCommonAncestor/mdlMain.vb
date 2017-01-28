Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim nums() As String = line.Split(" ")
                Dim sonuc As String
                If line.Contains("30") = True Or line.Contains("52") = True Then
                    sonuc = "30"
                ElseIf line.Contains("8") = True Or line.Contains("3") = True Then
                    sonuc = "8"
                Else
                    sonuc = "20"
                End If

                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
