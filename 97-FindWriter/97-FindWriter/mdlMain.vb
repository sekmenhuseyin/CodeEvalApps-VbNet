Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split("|")
                Dim nums() As String = parts(1).Split(" ")
                Dim sonuc As String = ""
                Dim tmp As Integer
                'loop each key in nums
                For i As Integer = 1 To UBound(nums)
                    tmp = Convert.ToInt32(nums(i).Trim()) - 1
                    sonuc &= parts(0)(tmp)
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
