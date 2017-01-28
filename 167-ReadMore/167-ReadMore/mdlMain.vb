Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                If Len(line) > 55 Then
                    Dim pos As Integer = 40
                    line = Left(line, pos)
                    If InStr(line, " ") > 0 Then
                        For i As Integer = pos - 1 To 0 Step -1
                            If line.Substring(i, 1) = " " Then pos = i : Exit For
                        Next
                        line = Left(line, pos)
                    End If
                    line = line.Trim() & "... <Read More>"
                End If
                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
