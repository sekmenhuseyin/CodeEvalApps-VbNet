Imports System.IO
Module Main

    Sub Main(ByVal sArgs() As String)

        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As Integer = 0 : Dim carpan As Integer = 1
                'sayının basamaklarını bul
                For i As Integer = line.Length - 1 To 0 Step -1
                    Dim tmpx = line.Substring(i, 1).Replace("a", "10").Replace("b", "11").Replace("c", "12").Replace("d", "13").Replace("e", "14").Replace("f", "15")
                    sonuc += carpan * Convert.ToInt32(tmpx)
                    carpan *= 16
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub

End Module