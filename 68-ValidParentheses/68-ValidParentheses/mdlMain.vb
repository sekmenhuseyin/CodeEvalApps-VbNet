Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim parantez(2, 1) As Integer '() [] {}
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                For i As Integer = 0 To 2
                    For j As Integer = 0 To 1
                        parantez(i, j) = 0
                    Next
                Next
                For i As Integer = 0 To line.Length - 1
                    If line(i) = "(" Then
                        parantez(0, 0) += 1
                    ElseIf line(i) = ")" Then
                        parantez(0, 1) += 1
                    ElseIf line(i) = "[" Then
                        parantez(1, 0) += 1
                    ElseIf line(i) = "]" Then
                        parantez(1, 1) += 1
                    ElseIf line(i) = "{" Then
                        parantez(2, 0) += 1
                    ElseIf line(i) = "}" Then
                        parantez(2, 1) += 1
                    Else
                    End If
                Next
                'control
                Dim sonuc As Boolean = True
                For i As Integer = 0 To 2
                    If parantez(i, 0) <> parantez(i, 1) Then sonuc = False
                Next
                If line.Contains("[)") = True Or line.Contains("(}") = True Then sonuc = False
                'return
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
