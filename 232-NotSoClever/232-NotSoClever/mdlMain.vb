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
                parts(0) = parts(0).Trim()
                parts(1) = parts(1).Trim()
                Dim nums() As String = parts(0).Split(" ")
                Dim num1, num2 As Integer
                Dim tmp As String
                'iterations 
                For i As Integer = 1 To Convert.ToInt32(parts(1))
                    'looop
                    For j As Integer = 0 To UBound(nums) - 1
                        num1 = Convert.ToInt32(nums(j))
                        num2 = Convert.ToInt32(nums(j + 1))
                        If num2 < num1 Then
                            tmp = nums(j) : nums(j) = nums(j + 1) : nums(j + 1) = tmp
                            Exit For '+1 to iterations
                        End If
                    Next
                Next
                Console.WriteLine(String.Join(" ", nums))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
