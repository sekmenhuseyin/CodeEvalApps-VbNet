Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim index As Integer
                Dim tmpLine As String = line
                'remove extra spaces
                For index = 1 To 10 : tmpLine = tmpLine.Replace("  ", " ") : Next
                Dim words() As String = tmpLine.Split(" ")
                Dim wordsTrans(UBound(words)) As String
                'ilk ve son harfi değiştir
                For index = 0 To UBound(words)
                    wordsTrans(index) = ChangeOrder(words(index), 0, words(index).Length - 1)
                Next
                For index = 0 To UBound(words)
                    line = line.Replace(words(index), wordsTrans(index))
                Next
                Console.WriteLine(line)
            End While
        End Using
        Console.ReadLine()
    End Sub
    'kelimenin harf sırasını değiştir
    Function ChangeOrder(str As String, var1 As Integer, var2 As Integer) As String
        Dim sonuc As String = str
        Mid(str, var1 + 1, 1) = sonuc.Substring(var2, 1)
        Mid(str, var2 + 1, 1) = sonuc.Substring(var1, 1)
        Return str
    End Function
End Module
