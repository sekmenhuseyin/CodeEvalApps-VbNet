Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim alphabet() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " "}
        Dim cyphered() As String = {"u", "v", "w", "x", "y", "z", "n", "o", "p", "q", "r", "s", "t", "g", "h", "i", "j", "k", "l", "m", "a", "b", "c", "d", "e", "f", " "}
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As String = ""
                For i As Integer = 0 To line.Length - 1
                    For j As Integer = 0 To UBound(alphabet)
                        If line.Substring(i, 1) = cyphered(j) Then sonuc &= alphabet(j) : Exit For
                    Next
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
