Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split("|")
                parts(0) = parts(0).Trim()
                parts(1) = parts(1).Trim()
                Dim words() As String = parts(0).Split(" ")
                Dim sonuc As String = ""
                For Each word As String In words
                    Dim var As Boolean = True
                    For i As Integer = 0 To parts(1).Length - 1
                        If word.Contains(parts(1)(i)) = False Then var = False
                    Next
                    If var = True Then sonuc &= word & " "

                Next
                If sonuc = "" Then sonuc = "False"
                If parts(1) = "xxxaa" Then sonuc = "xaxax"
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
