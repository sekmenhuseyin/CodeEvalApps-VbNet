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
                Dim wordLength As Integer = Convert.ToInt32(parts(0).Trim())
                Dim ascii As String = Asc(parts(1).Trim()).ToString()
                Dim asciis() As String = parts(2).Trim().Split(" ")
                Dim asciiFark As Integer = 0
                Dim sonuc As String = ""
                Dim rightWord As Boolean = False
                'check for every ascii in line
                For i As Integer = 0 To (UBound(asciis) - wordLength + 1) 'ilk harften aranan kelime uzunluğu kadar eksik olan yere kadar
                    If Convert.ToInt32(asciis(i + wordLength - 1)) > ascii Then 'her kelime zannedilen yerin son harfi aranan harfin ascii'sinden büyükse
                        For j As Integer = (i + wordLength + 1) To (UBound(asciis) - wordLength + 1) 'ilk bakılan kelimenin ardındaki kelimeden başlayarak sona kadar bak
                            rightWord = True
                            For k As Integer = 0 To wordLength - 1
                                If asciis(i + k) <> asciis(j + k) Then rightWord = False
                            Next
                            If rightWord = True Then
                                Dim tmp As Integer = asciis(i + wordLength - 1) - ascii
                                For k As Integer = 0 To wordLength - 1
                                    If asciis(i + k) = (Asc(" ") + asciiFark) Then rightWord = False
                                Next
                                If rightWord = True Then asciiFark = tmp
                            End If
                        Next
                    End If
                Next
                For i As Integer = 0 To UBound(asciis)
                    sonuc &= Chr(asciis(i) - asciiFark)
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
