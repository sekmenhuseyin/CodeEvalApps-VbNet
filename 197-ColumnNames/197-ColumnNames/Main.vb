Imports System.IO

Module Main

    Sub Main(ByVal sArgs() As String)
        'harfler
        Dim alfabe() As String = {"", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        'excel sütun isimleri
        Dim harfler(18278), sonuc As String
        For i As Integer = 1 To UBound(harfler)
            Dim harf As Integer = i Mod 26
            If i < 27 Then
                If harf = 0 Then harf = 26
                sonuc = alfabe(harf)
            ElseIf i > 26 And i < 703 Then
                Dim harf2 As Integer = Math.Floor(i / 26)
                harf = i - (harf2 * 26)
                If harf = 0 Then harf = 26 : harf2 -= 1
                sonuc = alfabe(harf2) & alfabe(harf)
            Else
                Dim harf2 As Integer = Math.Floor(i / 26)
                harf = i - (harf2 * 26)
                If harf = 0 Then harf = 26 : harf2 -= 1
                'harf3
                Dim harf3 As Integer = Math.Floor(harf2 / 26)
                harf2 = harf2 - (harf3 * 26)
                If harf2 = 0 Then harf2 = 26 : harf3 -= 1
                sonuc = alfabe(harf3) & alfabe(harf2) & alfabe(harf)
            End If
            harfler(i) = sonuc
        Next
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As Integer = Convert.ToInt32(sr.ReadLine())
                sonuc = harfler(line)
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub

End Module
