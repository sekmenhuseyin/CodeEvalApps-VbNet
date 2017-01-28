Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                'string array
                Dim numbers() As String = line.Split(" ")
                'decimal array
                Dim decimals(UBound(numbers)) As Decimal
                For index As Integer = 0 To UBound(numbers)
                    decimals(index) = Convert.ToDecimal(numbers(index).Replace(".", ","))
                Next
                'sorting
                Dim tmpS As String : Dim tmpD As Decimal
                For i As Integer = 0 To UBound(numbers) - 1
                    For j As Integer = i + 1 To UBound(numbers)
                        If decimals(i) > decimals(j) Then
                            tmpD = decimals(i) : decimals(i) = decimals(j) : decimals(j) = tmpD
                            tmpS = numbers(i) : numbers(i) = numbers(j) : numbers(j) = tmpS
                        End If
                    Next
                Next


                Console.WriteLine(String.Join(" ", numbers))
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
'Dim d As Decimal
'Dim d1(UBound(numbers)) As Decimal
'' Check if string can be converted to decimal equivalent
'If numbers.All(Function(number) Decimal.TryParse(number, d)) Then
'    d1 = Array.ConvertAll(Of String, Decimal)(numbers, Function(c As String) CDec(c))
'End If
