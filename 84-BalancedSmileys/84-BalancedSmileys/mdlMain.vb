Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim parantez(1) As Integer '()
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                For j As Integer = 0 To 1
                    parantez(j) = 0
                Next
                line = line.Replace(":)", "}").Replace(":(", "{")
                For i As Integer = 0 To line.Length - 1
                    If line(i) = "(" Then
                        parantez(0) += 1
                        parantez(1) += 1
                    ElseIf line(i) = ")" Then
                        parantez(0) -= 1
                        parantez(1) -= 1
                        If parantez(1) < 0 Then Exit For
                    ElseIf line(i) = "{" Then
                        parantez(1) += 1
                    ElseIf line(i) = "}" Then
                        parantez(0) -= 1
                    End If
                Next
                'control
                Dim sonuc As String = "NO"
                If parantez(0) <= 0 And parantez(1) >= 0 Then sonuc = "YES"
                'return
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
