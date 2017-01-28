Imports System.IO
Imports System.Text

Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim seq As String = "0"
        Dim tmp As String
        For i As Integer = 1 To 10
            tmp = seq
            tmp = tmp.Replace("2", "3")
            tmp = tmp.Replace("1", "2")
            tmp = tmp.Replace("0", "1")
            tmp = tmp.Replace("3", "0")
            seq &= tmp
        Next
        Console.WriteLine(seq)


        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)

                Console.WriteLine()
            End While
        End Using

        Console.ReadLine()
    End Sub
    Private Function changeNums(num As String) As String
        If num = "1" Then
            num = "2"
        ElseIf num = "2" Then
            num = "1"
        Else
            num = "0"
        End If
        Return num
    End Function
End Module
