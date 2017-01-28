Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                line = line.Remove(0, 2).Trim()
                Dim nums() As String = line.Split(" ")
                Array.Sort(nums)
                'find the distances
                Dim distMin As Integer = 0
                Dim tmp As Integer
                For i As Integer = Convert.ToInt32(nums(0)) To Convert.ToInt32(nums(UBound(nums)))
                    tmp = CalcDistance(i, nums)
                    If distMin = 0 Then
                        distMin = tmp
                    Else
                        If tmp < distMin Then distMin = tmp
                    End If
                Next
                Console.WriteLine(distMin)
            End While
        End Using
        Console.ReadLine()
    End Sub
    Function CalcDistance(Alice As Integer, friends() As String) As Integer
        Dim dist As Integer = 0
        For i As Integer = 0 To UBound(friends)
            dist += Math.Abs(Alice - Convert.ToInt32(friends(i)))
        Next
        Return dist
    End Function
End Module
