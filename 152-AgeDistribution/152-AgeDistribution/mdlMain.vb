Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim age As Int16 = Convert.ToInt32(line)
                Dim sonuc As String = ""
                If age < 0 Or age > 100 Then : sonuc = "This program is for humans"
                ElseIf age <= 2 Then : sonuc = "Still in Mama's arms"
                ElseIf age <= 4 Then : sonuc = "Preschool Maniac"
                ElseIf age <= 11 Then : sonuc = "Elementary school"
                ElseIf age <= 14 Then : sonuc = "Middle school"
                ElseIf age <= 18 Then : sonuc = "High school"
                ElseIf age <= 22 Then : sonuc = "College"
                ElseIf age <= 65 Then : sonuc = "Working for the man"
                ElseIf age <= 100 Then : sonuc = "The Golden Years"
                End If

                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
