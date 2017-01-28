Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim urls() As String = line.Split(";")
                For i As Integer = 0 To 1
                    urls(i) = LCase(urls(i))
                    urls(i) = urls(i).Replace(":80/", "/")
                    urls(i) = urls(i).Replace("%20", " ")
                    urls(i) = urls(i).Replace("%21", "!")
                    urls(i) = urls(i).Replace("%22", """")
                    urls(i) = urls(i).Replace("%23", "#")
                    urls(i) = urls(i).Replace("%24", "$")
                    urls(i) = urls(i).Replace("%25", "%")
                    urls(i) = urls(i).Replace("%26", "&")
                    urls(i) = urls(i).Replace("%27", "'")
                    urls(i) = urls(i).Replace("%28", "(")
                    urls(i) = urls(i).Replace("%29", ")")
                    urls(i) = urls(i).Replace("%2a", "*")
                    urls(i) = urls(i).Replace("%2b", "+")
                    urls(i) = urls(i).Replace("%2c", ",")
                    urls(i) = urls(i).Replace("%2d", "-")
                    urls(i) = urls(i).Replace("%2e", ".")
                    urls(i) = urls(i).Replace("%2f", "/")
                    urls(i) = urls(i).Replace("%3a", ":")
                    urls(i) = urls(i).Replace("%3b", ";")
                    urls(i) = urls(i).Replace("%3c", "<")
                    urls(i) = urls(i).Replace("%3d", "=")
                    urls(i) = urls(i).Replace("%3e", ">")
                    urls(i) = urls(i).Replace("%3f", "?")
                    urls(i) = urls(i).Replace("%40", "@")
                    urls(i) = urls(i).Replace("%5b", "[")
                    urls(i) = urls(i).Replace("%5c", "\")
                    urls(i) = urls(i).Replace("%5d", "]")
                    urls(i) = urls(i).Replace("%5e", "^")
                    urls(i) = urls(i).Replace("%5f", "_")
                    urls(i) = urls(i).Replace("%60", "`")
                    urls(i) = urls(i).Replace("%7b", "{")
                    urls(i) = urls(i).Replace("%7c", "|")
                    urls(i) = urls(i).Replace("%7d", "}")
                    urls(i) = urls(i).Replace("%7e", "~")
                Next

                Dim sonuc As Boolean = urls(0) = urls(1)

                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
