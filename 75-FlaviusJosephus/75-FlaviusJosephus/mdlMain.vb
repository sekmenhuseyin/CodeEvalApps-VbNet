Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Dim line, sonuc As String
        Dim num1, num2, killed, lastPerson As Integer
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                line = sr.ReadLine()
                Dim nums() As String = line.Split(",")
                num1 = Convert.ToInt32(nums(0))
                num2 = Convert.ToInt32(nums(1))
                killed = 0 : lastPerson = -1 : sonuc = ""
                Dim people(num1) As Boolean
                'clear people
                For i As Integer = 0 To num1
                    people(i) = True
                Next
                'kill everyone
                While killed < num1
                    For i As Integer = 1 To num2
                        lastPerson += 1
                        If lastPerson > num1 Then lastPerson -= num1
                        If people(lastPerson) = False Then i -= 1
                    Next
                    people(lastPerson) = False
                    sonuc &= " " & (lastPerson Mod num1).ToString()
                    killed += 1
                End While


                Console.WriteLine(sonuc.Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
