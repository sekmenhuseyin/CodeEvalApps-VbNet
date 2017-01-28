Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim alfabe As String = "abcdefghijklmnopqrstuvwxyz"
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine().ToLower()
                Dim eksikler As String = ""
                For i As Integer = 0 To Len(alfabe) - 1
                    If InStr(line, alfabe.Substring(i, 1)) = 0 Then eksikler &= alfabe.Substring(i, 1)
                Next
                If eksikler = "" Then eksikler = "NULL"
                Console.WriteLine(eksikler)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
