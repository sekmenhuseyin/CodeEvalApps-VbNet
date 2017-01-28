Imports System.IO
Module Main
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As String = ""
                For i As Integer = 0 To line.Length - 1
                    Dim kar = line.Substring(i, 1)
                    If kar >= "A" And kar <= "Z" Then
                        kar = LCase(kar)
                    ElseIf kar >= "a" And kar <= "z" Then
                        kar = UCase(kar)
                    End If
                    sonuc &= kar
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module