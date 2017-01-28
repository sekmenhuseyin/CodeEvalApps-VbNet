Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim uzunluk As Integer = line.Length / 2
                Dim olasi As Integer = 1
                Dim part1 As String = line.Substring(0, line.Length / 2)
                Dim part2 As String = line.Substring(line.Length / 2)
                For i As Integer = 0 To part1.Length - 1
                    If part1(i) = "*" And part2(i) = "*" Then
                        olasi *= 2
                    ElseIf part1(i) = "*" Or part2(i) = "*" Then
                    ElseIf part1(i) <> part2(i) Then
                        olasi = 0
                        Exit For
                    End If
                Next
                Console.WriteLine(olasi)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
