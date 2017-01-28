Imports System.IO
Module mdlMain
    Dim primeNumbers(1228) As Integer
    Sub Main(ByVal sArgs() As String)
        Dim k As Integer = 0
        For i As Integer = 2 To 10000
            Dim itsPrime As Boolean = True
            For j As Integer = 2 To i - 1
                If i Mod j = 0 Then itsPrime = False : Exit For
            Next
            If itsPrime = True Then primeNumbers(k) = i : k += 1
        Next
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim numbs() As String = line.Split(",")
                Dim numb1 As Integer = Convert.ToInt32(numbs(0))
                Dim numb2 As Integer = Convert.ToInt32(numbs(1))
                Dim sayi As Integer = 0
                For i As Integer = 0 To UBound(primeNumbers)
                    If primeNumbers(i) > numb2 Then Exit For
                    If primeNumbers(i) >= numb1 Then sayi += 1
                Next


                Console.WriteLine(sayi)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
