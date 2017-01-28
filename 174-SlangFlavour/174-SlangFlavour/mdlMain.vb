Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim slangs() As String = {", yeah!", ", this is crazy, I tell ya.", ", can U believe this?", ", eh?", ", aw yea.", ", yo.", "? No way!", ". Awesome!"}
        Dim ekle As Boolean = False
        Dim sira As Integer = 0
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As String = ""
                For i As Integer = 0 To line.Length - 1
                    If line(i) = "." Or line(i) = "!" Or line(i) = "?" Then
                        If ekle = True Then
                            sonuc &= slangs(sira)
                            sira += 1 : If sira = slangs.Length Then sira = 0
                            ekle = False
                        Else
                            sonuc &= line(i)
                            ekle = True
                        End If
                    Else
                        sonuc &= line(i)
                    End If

                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
