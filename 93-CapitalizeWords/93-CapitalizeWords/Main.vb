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
                Dim cevir As Boolean = True
                For i As Integer = 0 To line.Length - 1
                    Dim kar As String = line.Substring(i, 1)
                    If kar = " " Then
                        cevir = True
                    Else
                        If cevir = True Then
                            kar = UCase(kar) : cevir = False
                        End If
                    End If
                    sonuc &= kar
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module