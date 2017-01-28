Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Dim maxSatir As Integer = 0
        Dim satirNo As Integer = 0
        Dim lines(40), tmp As String
        'get all lines
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                If maxSatir = 0 Then
                    maxSatir = Convert.ToInt32(line)
                Else
                    lines(satirNo) = line
                    satirNo += 1
                End If
            End While
        End Using
        'get only longest ones
        For i As Integer = 0 To 39
            For j As Integer = i To 40
                If Len(lines(i)) < Len(lines(j)) Then
                    tmp = lines(j) : lines(j) = lines(i) : lines(i) = tmp
                End If
            Next
        Next
        For i As Integer = 0 To maxSatir - 1
            Console.WriteLine(lines(i))
        Next
        Console.ReadLine()
    End Sub
End Module
