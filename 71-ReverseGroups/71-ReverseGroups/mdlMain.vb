Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split(";")
                Dim nums() As String = parts(0).Split(",")
                Dim max As Integer = Convert.ToInt32(parts(1))
                Dim count As Integer = Math.Floor(Convert.ToInt32(nums.Length) / max)
                Dim sayi As Integer = 0
                line = ""
                For index As Integer = 0 To nums.Length Step max
                    'check for for count
                    If count = 0 Then Exit For
                    'take part of array
                    Dim list(max - 1) As String
                    For i As Integer = 0 To (max - 1)
                        list(i) = nums(index + i)
                        sayi += 1
                    Next
                    'reverse given array
                    Array.Reverse(list)
                    If line <> "" Then line &= ","
                    line &= String.Join(",", list)
                    count -= 1
                Next
                'add the remainings
                For i As Integer = sayi To UBound(nums)
                    line &= "," & nums(i)
                Next
                'finish
                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
