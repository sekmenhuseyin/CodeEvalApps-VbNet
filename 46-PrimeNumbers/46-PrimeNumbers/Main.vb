Imports System.IO
Module Main
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
                Dim line As Integer = Convert.ToInt32(sr.ReadLine())
                Dim sonuc As String = ""
                For i As Integer = 0 To UBound(primeNumbers)
                    If primeNumbers(i) < line Then
                        If sonuc = "" Then sonuc = primeNumbers(i) Else sonuc &= "," & primeNumbers(i)
                    End If
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
