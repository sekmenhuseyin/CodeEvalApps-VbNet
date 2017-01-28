Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split(",")
                Dim binary As String = Convert.ToString(Convert.ToInt32(parts(0)), 2)
                Dim num1 As String = binary(binary.Length - Convert.ToInt32(parts(1)))
                Dim num2 As String = binary(binary.Length - Convert.ToInt32(parts(2)))
                'compare
                If num1 = num2 Then
                    Console.WriteLine("true")
                Else
                    Console.WriteLine("false")
                End If
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
