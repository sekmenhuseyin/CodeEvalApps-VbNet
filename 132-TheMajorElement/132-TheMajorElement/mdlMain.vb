Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim nums() As String = line.Split(",")
                Dim liste(100) As String
                Dim listeCount(100) As Integer
                Dim sayi As Integer = 0
                Dim found As Boolean = False
                For i As Integer = 0 To nums.Length - 1
                    If Array.IndexOf(liste, nums(i)) = -1 Then
                        liste(sayi) = nums(i) : listeCount(sayi) = 1
                        sayi += 1
                    Else
                        For j As Integer = 0 To 100
                            If liste(j) = nums(i) Then listeCount(j) += 1 : Exit For

                        Next

                    End If
                Next
                'find the biggest
                For i As Integer = 0 To 100
                    If listeCount(i) > (nums.Length / 2) Then found = True : sayi = liste(i) : Exit For

                Next
                'show time
                If found = True Then Console.WriteLine(sayi) Else Console.WriteLine("None")
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
