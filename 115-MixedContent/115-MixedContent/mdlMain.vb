Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim words() As String = line.Split(",")
                Dim kelimeler As String = "" : Dim sayilar As String = ""
                For i As Integer = 0 To UBound(words)
                    If IsNumeric(words(i)) = True Then
                        If sayilar <> "" Then sayilar &= ","
                        sayilar &= words(i)
                    Else
                        If kelimeler <> "" Then kelimeler &= ","
                        kelimeler &= words(i)
                    End If
                Next
                If kelimeler = "" Or sayilar = "" Then
                    Console.WriteLine(kelimeler & sayilar)
                Else
                    Console.WriteLine(kelimeler & "|" & sayilar)
                End If
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
