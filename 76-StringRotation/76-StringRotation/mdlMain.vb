Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(",")
                Dim first As String = words(0)
                Dim second As String = words(1)
                Dim sonuc As Boolean = False
                For i As Integer = 0 To second.Length - 1
                    Dim tmp As String = Right(second, second.Length - i) & Left(second, i)
                    If first = tmp Then sonuc = True : Exit For
                Next


                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
