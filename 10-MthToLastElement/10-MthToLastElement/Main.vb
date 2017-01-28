Imports System.IO
Module Main
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim letters() As String = line.Split(" ")
                Dim tmpx As Integer = letters(UBound(letters))
                tmpx = UBound(letters) - tmpx
                If tmpx < 0 Then Console.WriteLine("") Else Console.WriteLine(letters(tmpx))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module