Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Select Case line
                    Case "2" : line = "1"
                    Case "3" : line = "1"
                    Case "4" : line = "2"
                    Case "5" : line = "0"
                    Case "6" : line = "2"
                    Case "7" : line = "2"
                    Case "8" : line = "2"
                    Case "9" : line = "2"
                    Case "10" : line = "2"
                    Case "11" : line = "2"
                    Case "12" : line = "2"
                    Case "13" : line = "2"
                    Case "14" : line = "2"
                    Case "15" : line = "2"
                    Case "16" : line = "2"
                    Case "17" : line = "2"
                    Case "18" : line = "2"
                    Case Else : line = "0"
                End Select

                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
