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
                Dim sonuc As String = ""
                For i As Integer = UBound(words) To 0 Step -1
                    sonuc &= words(i) & " "
                Next
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
