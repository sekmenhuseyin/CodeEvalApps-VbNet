Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim zeros() As String = line.Split(" ")
                Dim binary As String = ""
                Dim flag As Boolean = True
                Dim sifir As Boolean
                'looop
                For i As Integer = 0 To UBound(zeros)
                    If flag = True Then
                        If zeros(i) = "0" Then sifir = True Else sifir = False
                    Else
                        If sifir = True Then binary &= zeros(i) Else binary &= zeros(i).Replace("0", "1")
                    End If
                    flag = Not flag
                Next


                Console.WriteLine(Bin_To_Dec(binary))
            End While
        End Using
        Console.ReadLine()
    End Sub
    Public Function Bin_To_Dec(ByVal Bin As String)
        Dim dec As Double = Nothing
        Dim length As Integer = Len(Bin)
        Dim temp As Integer = Nothing
        Dim x As Integer = Nothing

        For x = 1 To length
            temp = Val(Mid(Bin, length, 1))
            length = length - 1
            If temp <> "0" Then
                dec += (2 ^ (x - 1))
            End If
        Next

        Return dec
    End Function
End Module
