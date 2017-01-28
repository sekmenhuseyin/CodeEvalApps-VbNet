Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim sonuc As Integer = 0
        Dim primeCount As Integer = 0
        Dim i As Integer = 2
        While primeCount < 1000
            Dim itsOk As Boolean = isPrime(i)
            If itsOk = True Then sonuc += i : primeCount += 1
            i += 1
        End While

        Console.WriteLine(sonuc)
        Console.ReadLine()
    End Sub
    Private Function isPrime(num As Integer) As Boolean
        Dim itsPrime As Boolean = True
        For j As Integer = 2 To num - 1
            If num Mod j = 0 Then itsPrime = False : Exit For
        Next
        Return itsPrime
    End Function
End Module
