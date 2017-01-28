Imports System.IO
Module Main
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim numbers() As String = line.Split(" ")
                Dim first As Integer = Convert.ToInt32(numbers(0))
                Dim second As Integer = Convert.ToInt32(numbers(1))
                Dim countTo As Integer = Convert.ToInt32(numbers(2))
                Dim sonuc As String = ""
                'for loop
                For i As Integer = 1 To countTo
                    If sonuc <> "" Then sonuc &= " "
                    If i Mod first = 0 And i Mod second = 0 Then : sonuc &= "FB"
                    ElseIf i Mod second = 0 Then : sonuc &= "B"
                    ElseIf i Mod first = 0 Then : sonuc &= "F"
                    Else : sonuc &= i
                    End If
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module