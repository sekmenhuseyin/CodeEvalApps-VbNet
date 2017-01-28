Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim tmp1, tmp2 As String
                Dim sonuc As Integer
                For i As Integer = 1 To line.Length
                    tmp1 = line.Substring(0, i)
                    Try
                        tmp2 = line.Substring(i, i)
                    Catch ex As Exception
                        tmp2 = ""
                    End Try
                    sonuc = i
                    If tmp1 = tmp2 Then Exit For

                Next
                Console.WriteLine(sonuc.ToString())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
