Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim hours() As String = line.Split(" ")
                Console.WriteLine(DeltaTime(Convert.ToDateTime(hours(0)), Convert.ToDateTime(hours(1))))
            End While
        End Using
        Console.ReadLine()
    End Sub
    'Saat farkını hesapla
    Private Function DeltaTime(var1 As DateTime, var2 As DateTime) As TimeSpan
        Dim duration As TimeSpan
        If var2 > var1 Then duration = var2 - var1 Else duration = var1 - var2
        Return duration
    End Function
End Module
