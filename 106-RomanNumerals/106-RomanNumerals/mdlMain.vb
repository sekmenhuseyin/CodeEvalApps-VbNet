Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim number As Integer = Convert.ToInt32(line)
                number = hesapla(number, 1000, "M")
                number = hesapla(number, 900, "CM")
                number = hesapla(number, 500, "D")
                number = hesapla(number, 400, "CD")
                number = hesapla(number, 100, "C")
                number = hesapla(number, 90, "XC")
                number = hesapla(number, 50, "L")
                number = hesapla(number, 40, "XL")
                number = hesapla(number, 10, "X")
                number = hesapla(number, 9, "IX")
                number = hesapla(number, 5, "V")
                number = hesapla(number, 4, "IV")
                For i As Integer = 0 To number - 1
                    Console.Write("I")

                Next
                Console.WriteLine()
            End While
        End Using
        Console.ReadLine()
    End Sub
    Function hesapla(number As Integer, value As Integer, letter As String) As Integer
        While number >= value
            Console.Write(letter)
            number -= value
        End While
        Return number
    End Function
End Module
