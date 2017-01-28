Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim number As Integer = Convert.ToInt32(line)
                Dim para As Integer = Math.Floor(number / 5)
                Dim kalan As Integer = number Mod 5
                If kalan > 0 Then para += Math.Floor(kalan / 3) + (kalan Mod 3)
                Console.WriteLine(para)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
