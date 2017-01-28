Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                line = line.Replace(") (", ",")
                line = line.Replace(" ", "")
                line = line.Replace("(", "")
                line = line.Replace(")", "")
                Dim nums() As String = line.Split(",")
                Dim x As Integer = Convert.ToInt32(nums(0)) - Convert.ToInt32(nums(2))
                Dim y As Integer = Convert.ToInt32(nums(1)) - Convert.ToInt32(nums(3))

                Console.WriteLine(Math.Sqrt((x * x) + (y * y)))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
