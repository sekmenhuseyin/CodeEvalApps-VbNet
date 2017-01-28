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
                For i As Integer = 0 To Len(line) - 1
                    Dim tmp As String = line.Substring(i, 1)
                    If (tmp >= "a" And tmp <= "z") Or (tmp >= "A" And tmp <= "Z") Then sonuc &= LCase(tmp) Else sonuc &= " "
                    sonuc = sonuc.Replace("  ", " ")
                Next
                sonuc = sonuc.Trim()
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
