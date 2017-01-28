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
                For index As Integer = 0 To line.Length - 1
                    If IsNumeric(line(index)) = True Then
                        sonuc &= line(index)
                    ElseIf line(index) >= "a" And line(index) <= "z" Then
                        sonuc &= Asc(line(index)) - 97
                    End If
                Next
                If sonuc = "" Then sonuc = "NONE"
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
