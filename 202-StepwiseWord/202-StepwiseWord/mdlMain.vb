Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(" ")
                Dim selected As Integer = 0
                'find the longest word
                For i As Integer = 1 To UBound(words)
                    If words(i).Length > words(selected).Length Then selected = i
                Next
                'rewrite the word
                Dim sonuc As String = ""
                For i As Integer = 0 To words(selected).Length - 1
                    If sonuc <> "" Then sonuc &= " "
                    For j As Integer = 1 To i : sonuc &= "*" : Next
                    sonuc &= words(selected).Substring(i, 1)
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
