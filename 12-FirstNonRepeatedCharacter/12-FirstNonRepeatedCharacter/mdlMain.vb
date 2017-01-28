Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim tmp As String = "" : Dim sonuc As String = ""
                For i As Integer = 0 To line.Length - 1
                    tmp = line.Replace(line.Substring(i, 1), "")
                    If tmp.Length = line.Length - 1 Then sonuc = line.Substring(i, 1) : Exit For
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
