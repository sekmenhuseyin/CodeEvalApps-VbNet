Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split("|")
                parts(0) = parts(0).Trim()
                Dim names() As String = parts(0).Split(" ")
                Dim counter As Integer = Convert.ToInt32(parts(1))
                'loop
                For i As Integer = 1 To names.Length - 1

                    Dim sayi As Integer = IIf(counter > names.Length, counter Mod names.Length, counter)
                    If sayi > 0 Then sayi -= 1 Else sayi = UBound(names)
                    parts(0) = parts(0).Replace(names(sayi), "").Replace("  ", " ").Trim()
                    names = parts(0).Split(" ")

                Next
                Console.WriteLine(parts(0).Trim())
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
