Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'binaries
        Dim binaries(1000, 2) As String
        For i As Integer = 1 To 1000
            Dim binary As String = Convert.ToString(i, 2)
            binaries(i, 0) = binary
            binaries(i, 1) = CountCharacter(binary, "0")
        Next

        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim nums() As String = line.Split(" ")
                Dim sonuc As Integer = 0
                'loop all binaries
                For i As Integer = 1 To Convert.ToInt32(nums(1))
                    If nums(0) = binaries(i, 1) Then sonuc += 1
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
    'Count specific character occurrences in string
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then cnt += 1
        Next
        Return cnt
    End Function
End Module
