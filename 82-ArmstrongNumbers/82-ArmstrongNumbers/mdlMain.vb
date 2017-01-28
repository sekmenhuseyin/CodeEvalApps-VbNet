Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As Integer = 0
                Dim tmp As Integer : Dim str As String
                For i As Integer = 0 To line.Length - 1
                    str = line(i)
                    tmp = Convert.ToInt32(str)
                    tmp = tmp ^ (line.Length)
                    sonuc += tmp
                Next

                Console.WriteLine(sonuc = Convert.ToInt32(line))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
