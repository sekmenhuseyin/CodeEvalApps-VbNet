Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim alphabet As String = " !é#$%&'()*+,-./0123456789:<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                line = line.Replace("""", "é")
                Dim parts() As String = line.Split(";")
                Dim diz, geri2 As Integer
                Dim sonuc As String = ""
                Dim geri As String

                While parts(0).Length < parts(1).Length
                    parts(0) &= parts(0)
                End While

                For i As Integer = 0 To parts(1).Length - 1
                    diz = alphabet.IndexOf(parts(1)(i))
                    geri = parts(0)(i)
                    geri2 = Convert.ToInt32(geri)

                    diz -= geri : If diz < 0 Then diz += alphabet.Length

                    sonuc &= alphabet(diz)
                Next


                Console.WriteLine(sonuc.Replace("é", """"))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
