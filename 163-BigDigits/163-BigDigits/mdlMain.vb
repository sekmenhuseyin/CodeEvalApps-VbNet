Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim symbols(9, 5) As String
        '0
        symbols(0, 0) = "-**--" : symbols(1, 0) = "--*--" : symbols(2, 0) = "***--" : symbols(3, 0) = "***--" : symbols(4, 0) = "-*---" : symbols(5, 0) = "****-" : symbols(6, 0) = "-**--" : symbols(7, 0) = "****-" : symbols(8, 0) = "-**--" : symbols(9, 0) = "-**--"
        symbols(0, 1) = "*--*-" : symbols(1, 1) = "-**--" : symbols(2, 1) = "---*-" : symbols(3, 1) = "---*-" : symbols(4, 1) = "*--*-" : symbols(5, 1) = "*----" : symbols(6, 1) = "*----" : symbols(7, 1) = "---*-" : symbols(8, 1) = "*--*-" : symbols(9, 1) = "*--*-"
        symbols(0, 2) = "*--*-" : symbols(1, 2) = "--*--" : symbols(2, 2) = "-**--" : symbols(3, 2) = "-**--" : symbols(4, 2) = "****-" : symbols(5, 2) = "***--" : symbols(6, 2) = "***--" : symbols(7, 2) = "--*--" : symbols(8, 2) = "-**--" : symbols(9, 2) = "-***-"
        symbols(0, 3) = "*--*-" : symbols(1, 3) = "--*--" : symbols(2, 3) = "*----" : symbols(3, 3) = "---*-" : symbols(4, 3) = "---*-" : symbols(5, 3) = "---*-" : symbols(6, 3) = "*--*-" : symbols(7, 3) = "-*---" : symbols(8, 3) = "*--*-" : symbols(9, 3) = "---*-"
        symbols(0, 4) = "-**--" : symbols(1, 4) = "-***-" : symbols(2, 4) = "****-" : symbols(3, 4) = "***--" : symbols(4, 4) = "---*-" : symbols(5, 4) = "***--" : symbols(6, 4) = "-**--" : symbols(7, 4) = "-*---" : symbols(8, 4) = "-**--" : symbols(9, 4) = "-**--"
        symbols(0, 5) = "-----" : symbols(1, 5) = "-----" : symbols(2, 5) = "-----" : symbols(3, 5) = "-----" : symbols(4, 5) = "-----" : symbols(5, 5) = "-----" : symbols(6, 5) = "-----" : symbols(7, 5) = "-----" : symbols(8, 5) = "-----" : symbols(9, 5) = "-----"
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim numbers As String = ""
                Dim index, j, k As Integer
                'sadece rakamları bul
                For index = 0 To line.Length - 1
                    If line(index) >= "0" And line(index) <= "9" Then numbers &= line(index)
                Next
                'rakamları yeni formatta yaz
                line = ""
                For j = 0 To 5
                    For index = 0 To numbers.Length - 1
                        k = Val(numbers(index))
                        line &= symbols(k, j)
                    Next
                    line &= vbCrLf
                Next
                Console.Write(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
