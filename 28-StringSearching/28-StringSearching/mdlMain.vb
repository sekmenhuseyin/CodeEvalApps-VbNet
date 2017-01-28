Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(",")
                Dim sonuc As Boolean = words(0).Contains(words(1)) = True
                If sonuc = False And words(1).Contains("*") = True Then
                    If words(1).Contains("\*") = True And words(0).Contains("*") = False Then
                    Else
                        sonuc = True
                    End If

                End If

                Console.WriteLine(sonuc.ToString().ToLower())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
