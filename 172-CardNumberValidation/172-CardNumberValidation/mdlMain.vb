Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                line = line.Replace(" ", "")
                Dim sonuc As Integer = 0
                Dim tmp As Integer
                For i As Integer = 0 To line.Length - 1
                    tmp = Convert.ToInt32(line.Substring(line.Length - i - 1, 1))
                    If i Mod 2 = 1 Then
                        tmp *= 2
                        If tmp > 9 Then
                            tmp = Convert.ToInt32(tmp.ToString().Substring(0, 1)) + Convert.ToInt32(tmp.ToString().Substring(1, 1))
                        End If
                    End If
                    sonuc += tmp
                Next
                If sonuc Mod 10 = 0 Then Console.WriteLine("1") Else Console.WriteLine("0")
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
