Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split(",")
                parts(0) = parts(0).Replace("Vampires:", "")
                parts(1) = parts(1).Replace("Zombies:", "")
                parts(2) = parts(2).Replace("Witches:", "")
                parts(3) = parts(3).Replace("Houses:", "")

                Dim vampires As Integer = Convert.ToInt32(parts(0).Trim())
                Dim zombies As Integer = Convert.ToInt32(parts(1).Trim())
                Dim witches As Integer = Convert.ToInt32(parts(2).Trim())
                Dim houses As Integer = Convert.ToInt32(parts(3).Trim())
                Dim sonuc As Integer = Math.Floor((((vampires * 3) + (zombies * 4) + (witches * 5)) * houses) / (vampires + zombies + witches))
                'Dim sonuc As Integer = (vampires * 3) + (zombies * 4) + (witches * 5)
                'sonuc *= houses
                'sonuc = Math.Floor(sonuc / (vampires + zombies + witches))
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module

