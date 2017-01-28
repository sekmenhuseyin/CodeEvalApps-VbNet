Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim numbers() As String = line.Split(" ")
                Dim sonuc As Boolean = False
                Dim count As Integer
                For i As Integer = 1 To 9
                    count = 0
                    For j As Integer = 0 To UBound(numbers)
                        If numbers(j) = i.ToString() Then count += 1
                    Next
                    If count = 1 Then
                        For j As Integer = 0 To UBound(numbers)
                            If numbers(j) = i.ToString() Then count = j + 1
                        Next
                        sonuc = True
                        Exit For
                    End If
                Next
                If sonuc = False Then count = 0
                Console.WriteLine(count)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
