Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split("|")
                parts(0) = parts(0).Substring(0, parts(0).Length - 1)
                parts(1) = parts(1).Substring(1, parts(1).Length - 1)
                Dim errors As Integer = 0
                'loop every char
                For i As Integer = 0 To parts(0).Length - 1
                    If parts(0).Substring(i, 1) <> parts(1).Substring(i, 1) Then errors += 1
                Next
                If errors = 0 Then:Console.WriteLine("Done")
                ElseIf errors <= 2 Then : Console.WriteLine("Low")
                ElseIf errors <= 4 Then : Console.WriteLine("Medium")
                ElseIf errors <= 6 Then : Console.WriteLine("High")
                Else : Console.WriteLine("Critical")
                End If
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
