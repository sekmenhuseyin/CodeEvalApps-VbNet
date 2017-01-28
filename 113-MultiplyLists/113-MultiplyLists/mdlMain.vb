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
                parts(0) = parts(0).Trim() : parts(1) = parts(1).Trim()
                Dim numbers1() As String = parts(0).Split(" ")
                Dim numbers2() As String = parts(1).Split(" ")
                Dim sonuc As String = "" : Dim num1, num2 As Integer
                For index As Integer = 0 To UBound(numbers1)
                    num1 = Convert.ToInt32(numbers1(index))
                    num2 = Convert.ToInt32(numbers2(index))
                    sonuc &= (num1 * num2).ToString() & " "
                Next
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
