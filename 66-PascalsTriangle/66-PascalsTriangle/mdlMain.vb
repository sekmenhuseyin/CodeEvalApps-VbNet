Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim pascal(20) As String
        pascal(0) = "1"
        pascal(1) = "1 1"
        pascal(2) = "1 2 1"
        pascal(3) = "1 3 3 1"
        pascal(4) = "1 4 6 4 1"
        pascal(5) = "1 5 10 10 5 1"
        pascal(6) = "1 6 15 20 15 6 1"
        pascal(7) = "1 7 21 35 35 21 7 1"
        pascal(8) = "1 8 28 56 70 56 28 8 1"
        pascal(9) = "1 9 36 84 126 126 84 36 9 1"
        pascal(10) = "1 10 45 120 210 252 210 120 45 10 1"
        pascal(11) = "1 11 55 165 330 462 462 330 165 55 11 1"
        pascal(12) = "1 12 66 220 495 792 924 792 495 220 66 12 1"
        pascal(13) = "1 13 78 286 715 1287 1716 1716 1287 715 286 78 13 1"
        pascal(14) = "1 14 91 364 1001 2002 3003 3432 3003 2002 1001 364 91 14 1"
        pascal(15) = "1 15 105 455 1365 3003 5005 6435 6435 5005 3003 1365 455 105 15 1"
        pascal(16) = "1 16 120 560 1820 4368 8008 11440 12870 11440 8008 4368 1820 560 120 16 1"
        pascal(17) = "1 17 136 680 2380 6188 12376 19448 24310 24310 19448 12376 6188 2380 680 136 17 1"
        pascal(18) = "1 18 153 816 3060 8568 18564 31824 43758 48620 43758 31824 18564 8568 3060 816 153 18 1"
        pascal(19) = "1 19 171 969 3876 11628 27132 50388 75582 92378 92378 75582 50388 27132 11628 3876 969 171 19 1"
        pascal(20) = "1 20 190 1140 4845 15504 38760 77520 125970 167960 184756 167960 125970 77520 38760 15504 4845 1140 190 20 1"
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As String = ""
                For i As Integer = 0 To Convert.ToInt32(line) - 1
                    sonuc &= pascal(i) & " "
                Next
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
