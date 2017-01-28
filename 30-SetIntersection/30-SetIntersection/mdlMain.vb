Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim parts() As String = line.Split(";")
                Dim nums1() As String = parts(0).Split(",")
                Dim nums2() As String = parts(1).Split(",")
                Dim sonuc As String = ""
                For Each item As String In nums1
                    For Each item2 As String In nums2
                        If item = item2 Then
                            If sonuc <> "" Then sonuc &= ","
                            sonuc &= item
                        End If
                    Next
                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
