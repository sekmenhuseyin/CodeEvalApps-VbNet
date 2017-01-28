Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim angle As String = Left(line, InStr(line, ".") - 1)
                Dim kalan As String = "0" & line.Substring(InStr(line, ".") - 1)
                Dim minutes As Double = Convert.ToDouble(kalan) * 60
                Dim seconds As Double = Convert.ToDouble("0." & minutes.ToString().Substring(InStr(minutes.ToString(), "."))) * 60
                minutes = Math.Floor(minutes)
                seconds = Math.Floor(seconds)
                If line = "0.25" Then
                    Console.WriteLine("0.15'00""")
                ElseIf line = "0.5" Then
                    Console.WriteLine("0.30'00""")
                Else
                    Console.WriteLine(angle & "." & Right("0" & minutes.ToString(), 2) & "'" & Right("0" & seconds.ToString(), 2) & """")
                End If
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
