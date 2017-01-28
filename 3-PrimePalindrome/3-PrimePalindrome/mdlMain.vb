Module mdlMain
    Dim primeNumbers(1000) As Integer
    Dim palindromeNumbers(1000) As Integer
    Sub Main()
        CreatePrimes()
        CreatePalindromes()
        'loop each number descending
        For i As Integer = 1000 To 1 Step -1
            If primeNumbers.Contains(i) = True And palindromeNumbers.Contains(i) = True Then Console.WriteLine(i) : Exit For
        Next
        Console.ReadLine()
    End Sub
    Private Sub CreatePrimes()
        Dim dizi As Integer = 0
        For i As Integer = 2 To 1000
            Dim itsOk As Boolean = True
            For j As Integer = 2 To i - 1
                If i Mod j = 0 Then itsOk = False : Exit For
            Next
            If itsOk = True Then primeNumbers(dizi) = i : dizi += 1
        Next
    End Sub
    Private Sub CreatePalindromes()
        Dim dizi As Integer = 0
        For i As Integer = 1 To 1000
            Dim tmp As String = i.ToString()
            Dim itsOk As Boolean = True
            For j As Integer = 0 To tmp.Length - 1
                If tmp(j) <> tmp(tmp.Length - 1 - j) Then itsOk = False : Exit For
            Next
            If itsOk = True Then palindromeNumbers(dizi) = i : dizi += 1
        Next
    End Sub
    'just in case
    Private Function isPalindrome(sayi As Integer) As Boolean
        Dim tmp As String = sayi.ToString()
        For i As Integer = 0 To tmp.Length - 1
            If tmp(i) <> tmp(tmp.Length - 1 - i) Then Return False : Exit For
        Next
        Return True
    End Function
    Private Function isPrime(num As Integer) As Boolean
        Dim itsPrime As Boolean = True
        For j As Integer = 2 To num - 1
            If num Mod j = 0 Then itsPrime = False : Exit For
        Next
        Return itsPrime
    End Function
End Module
