Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim dongu As Integer = 0
                Dim sonuc As Long = Convert.ToInt64(line)

                While isPalindrome(sonuc) <> True
                    line = StrReverse(line)
                    Dim num2 As Long = Convert.ToInt64(line)
                    sonuc = sonuc + num2
                    line = sonuc.ToString()
                    dongu += 1

                End While


                Console.WriteLine(dongu.ToString() & " " & sonuc.ToString())
            End While
        End Using
        Console.ReadLine()
    End Sub
    'isPalindrome
    Private Function isPalindrome(sayi As Long) As Boolean
        Dim tmp As String = sayi.ToString()
        For i As Integer = 0 To tmp.Length - 1
            If tmp(i) <> tmp(tmp.Length - 1 - i) Then Return False : Exit For
        Next
        Return True
    End Function
End Module
