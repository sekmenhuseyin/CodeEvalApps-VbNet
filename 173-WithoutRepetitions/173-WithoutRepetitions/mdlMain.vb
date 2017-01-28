Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc, lastLetter As String
                sonuc = "" : lastLetter = ""
                For index As Integer = 0 To line.Length - 1
                    If line.Substring(index, 1) <> lastLetter Then
                        lastLetter = line.Substring(index, 1)
                        sonuc &= lastLetter
                    End If
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
