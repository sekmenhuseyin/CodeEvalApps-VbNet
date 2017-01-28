Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim nums() As String = line.Split(",")
                Dim sifir As Boolean = False
                Dim enBuyuk As Integer = -100000
                Dim tmp As Integer
                Dim toplam As Integer = 0
                If UBound(nums) = 0 Then
                    enBuyuk = nums(0)
                Else
                    For i As Integer = 0 To UBound(nums) - 1
                        For j As Integer = i To UBound(nums)
                            tmp = 0
                            For k As Integer = i To j
                                tmp += nums(k)
                            Next
                            If tmp > enBuyuk Then enBuyuk = tmp
                        Next
                    Next
                End If
                Console.WriteLine(enBuyuk)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
