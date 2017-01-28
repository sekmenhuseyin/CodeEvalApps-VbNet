Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(";")
                Dim selected As String = ""
                'loop for each length
                For i As Integer = 0 To words(0).Length - 1
                    If words(1).Contains(words(0).Substring(i, 1)) Then selected &= words(0).Substring(i, 1)



                Next
                Console.WriteLine(selected)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
