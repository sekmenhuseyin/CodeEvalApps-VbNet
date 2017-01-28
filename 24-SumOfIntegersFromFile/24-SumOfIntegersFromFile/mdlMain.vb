Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Dim sonuc As Integer = 0
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                sonuc += Convert.ToInt32(line)

            End While
        End Using
        Console.WriteLine(sonuc)
        Console.ReadLine()
    End Sub
End Module
