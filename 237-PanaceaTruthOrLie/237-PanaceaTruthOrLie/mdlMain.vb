Imports System.IO
Imports System.Globalization

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
                parts(1) = parts(1).Trim()
                Dim hexas() As String = parts(0).Split(" ")
                Dim binaries() As String = parts(1).Split(" ")
                Dim virus As Integer = 0
                Dim anti As Integer = 0
                'convert hex to dec
                For i As Integer = 0 To UBound(hexas)
                    virus += Val("&H" & hexas(i))
                Next
                'convert binary to dec
                For i As Integer = 0 To UBound(binaries)
                    anti += ConvertFromBinary(binaries(i))
                Next
                'return
                Console.WriteLine(anti >= virus)
            End While
        End Using
        Console.ReadLine()
    End Sub
    Function HexStringToBinary(ByVal hexString As String) As String
        Dim num As Integer = Integer.Parse(hexString, NumberStyles.HexNumber)
        Return Convert.ToString(num, 2)
    End Function
    Public Function ConvertFromBinary(ByVal input As String) As Integer
        Dim ret As Integer = 0
        Dim splitInput As Char() = input.ToCharArray
        Dim modifier As Integer = 1
        For i As Integer = splitInput.Length - 1 To 0 Step -1
            Dim thisChar As Integer = Val(splitInput(i))
            If thisChar = 1 Then
                ret += thisChar * modifier
            End If
            modifier *= 2
        Next

        Return ret
    End Function
End Module
