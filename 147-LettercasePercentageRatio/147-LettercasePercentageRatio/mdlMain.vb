Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim lowerCount As Integer = 0
                For i As Integer = 0 To line.Length - 1
                    If line(i) >= "a" And line(i) <= "z" Then lowerCount += 1
                Next
                Dim upperCount As Integer = line.Length - lowerCount
                Dim sayiLower As Decimal = FormatNumber(100 * lowerCount / line.Length, 2)
                Dim sayiUpper As Decimal = FormatNumber(100 * upperCount / line.Length, 2)
                Console.WriteLine("lowercase: " & sayiLower.ToString() & " uppercase: " & sayiUpper.ToString())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
