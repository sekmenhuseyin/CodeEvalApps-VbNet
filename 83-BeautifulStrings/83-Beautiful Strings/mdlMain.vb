Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine() : line = LCase(line)
                Dim counter() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                Dim tmp As String
                For i As Integer = 0 To line.Length - 1
                    tmp = line.Substring(i, 1)
                    If tmp >= "a" And tmp <= "z" Then counter(Asc(tmp) - 97) = counter(Asc(tmp) - 97) + 1
                Next
                'sayıları topla
                Dim puan As Integer = 26
                Dim sonuc As Integer = 0
                Array.Sort(counter)
                Array.Reverse(counter)
                For Each item As Integer In counter
                    sonuc += item * puan
                    puan -= 1
                Next
                'show
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
