Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim cities() As String = line.Split(";")
                Dim distances(UBound(cities) - 1) As Integer
                'loop each city
                For i As Integer = 0 To UBound(cities) - 1
                    distances(i) = Convert.ToInt32(cities(i).Substring(InStr(cities(i), ",")))
                Next
                'sort
                Array.Sort(distances)
                Dim tmp As Integer = 0
                Dim sonuc As String = ""
                For Each item As Integer In distances
                    tmp = item - tmp
                    sonuc &= "," & tmp
                    tmp = item
                Next
                Console.WriteLine(sonuc.Remove(0, 1))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
