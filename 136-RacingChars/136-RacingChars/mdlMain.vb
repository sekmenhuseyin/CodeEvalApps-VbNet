Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            Dim lastPos As Integer = 0
            Dim currentPos As Integer
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                If line.Contains("C") Then
                    If lastPos = 0 Then 'ilk satırsa
                        lastPos = InStr(line, "C")
                        line = line.Replace("C", "|")
                    Else '
                        currentPos = InStr(line, "C")
                        If currentPos < lastPos Then
                            line = line.Replace("C", "/")
                        ElseIf currentPos > lastPos Then
                            line = line.Replace("C", "\")
                        Else
                            line = line.Replace("C", "|")
                        End If
                        lastPos = currentPos
                    End If
                Else
                    If lastPos = 0 Then 'ilk satırsa
                        lastPos = InStr(line, "_")
                        line = line.Replace("_", "|")
                    Else '
                        currentPos = InStr(line, "_")
                        If currentPos < lastPos Then
                            line = line.Replace("_", "/")
                        ElseIf currentPos > lastPos Then
                            line = line.Replace("_", "\")
                        Else
                            line = line.Replace("_", "|")
                        End If
                        lastPos = currentPos
                    End If
                End If

                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
