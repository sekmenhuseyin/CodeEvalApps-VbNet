Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                If line > "" Then
                    Dim parts() As String = line.Split(";")
                    Dim numbers() As String = parts(1).Split(",")
                    For i As Integer = 0 To UBound(numbers) - 1
                        For j As Integer = i + 1 To UBound(numbers)
                            If numbers(i) = numbers(j) Then line = numbers(i) : Exit For
                        Next
                    Next
                End If
                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
