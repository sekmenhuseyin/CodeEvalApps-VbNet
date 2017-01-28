Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim harf As String = Left(line, 1)
                Dim rakam As Integer = Convert.ToInt32(Right(line, 1))
                'arrays
                Dim harfler() As String = {Chr(Asc(harf) - 2), Chr(Asc(harf) - 1), Chr(Asc(harf) + 1), Chr(Asc(harf) + 2)}
                Dim rakamlar() As Integer = {rakam - 2, rakam - 1, rakam + 1, rakam + 2}
                For i As Integer = 0 To 3
                    If harfler(i) < "a" Or harfler(i) > "h" Then harfler(i) = ""
                    If rakamlar(i) < 1 Or rakamlar(i) > 8 Then rakamlar(i) = 0
                Next
                'mix harf and rakam
                Dim sonuc As String = ""
                If harfler(0) <> "" Then
                    If rakamlar(1) <> 0 Then sonuc &= harfler(0) & rakamlar(1) & " "
                    If rakamlar(2) <> 0 Then sonuc &= harfler(0) & rakamlar(2) & " "
                End If
                If harfler(1) <> "" Then
                    If rakamlar(0) <> 0 Then sonuc &= harfler(1) & rakamlar(0) & " "
                    If rakamlar(3) <> 0 Then sonuc &= harfler(1) & rakamlar(3) & " "
                End If
                If harfler(2) <> "" Then
                    If rakamlar(0) <> 0 Then sonuc &= harfler(2) & rakamlar(0) & " "
                    If rakamlar(3) <> 0 Then sonuc &= harfler(2) & rakamlar(3) & " "
                End If
                If harfler(3) <> "" Then
                    If rakamlar(1) <> 0 Then sonuc &= harfler(3) & rakamlar(1) & " "
                    If rakamlar(2) <> 0 Then sonuc &= harfler(3) & rakamlar(2) & " "
                End If
                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
