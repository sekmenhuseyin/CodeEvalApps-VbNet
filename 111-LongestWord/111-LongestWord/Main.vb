Imports System.IO
Module Main
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(" ")
                For i As Integer = 0 To UBound(words) - 1
                    For j As Integer = i + 1 To UBound(words)
                        If words(i).Length < words(j).Length Then
                            Dim tmp As String = words(j)
                            words(i) = words(j)
                            words(j) = tmp
                        End If
                    Next
                Next
                Console.WriteLine(words(0))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module