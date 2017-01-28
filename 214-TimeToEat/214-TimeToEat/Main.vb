Imports System.IO
Module Main

    Sub Main(ByVal sArgs() As String)

        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim zamanlar() As String = line.Split(" ")
                Dim zamanlar2() As String = line.Split(" ")
                Dim tmp As String : Dim i, j As Integer
                'delete :
                For i = 0 To UBound(zamanlar2):zamanlar2(i) = zamanlar2(i).Replace(":", ""):Next
                'sorting
                For i = 0 To UBound(zamanlar2) - 1
                    For j = i + 1 To UBound(zamanlar2)
                        If zamanlar2(j) > zamanlar2(i) Then
                            tmp = zamanlar2(i) : zamanlar2(i) = zamanlar2(j) : zamanlar2(j) = tmp
                            tmp = zamanlar(i) : zamanlar(i) = zamanlar(j) : zamanlar(j) = tmp
                        End If
                    Next
                Next
                tmp = ""
                For i = 0 To UBound(zamanlar)
                    tmp &= zamanlar(i)
                    If i < UBound(zamanlar) Then tmp &= " "
                Next
                Console.WriteLine(tmp)
            End While
        End Using
        Console.ReadLine()
    End Sub

End Module
