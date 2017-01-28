Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As String = ""
                If line <> "" Then
                    Dim words() As String = line.Split(",")
                    If Right(words(0), Len(words(1))) = words(1) Then sonuc = "1" Else sonuc = "0"
                End If
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
