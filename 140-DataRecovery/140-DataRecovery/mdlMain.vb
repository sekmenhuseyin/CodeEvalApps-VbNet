Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split(";")
                Dim words() As String = parts(0).Split(" ")
                Dim numbs() As String = parts(1).Split(" ")
                'find the missing word number
                For i As Integer = 1 To words.Length
                    If Array.IndexOf(numbs, i.ToString()) = -1 Then
                        ReDim Preserve numbs(UBound(words))
                        'Array.Resize(Of String)(numbs, UBound(words))
                        numbs(UBound(words)) = i : Exit For
                    End If
                Next
                'write the words in correct order
                line = "" : Dim tmp As Integer
                For i As Integer = 1 To numbs.Length
                    tmp = Array.IndexOf(numbs, i.ToString())
                    line &= words(tmp) & " "
                Next
                Console.WriteLine(line.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
