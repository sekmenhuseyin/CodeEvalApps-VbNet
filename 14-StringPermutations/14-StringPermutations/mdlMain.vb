Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim satir As String = ""
                'satırdaki harfleri sırala
                For i As Integer = 0 To line.Length - 2
                    For j As Integer = i + 1 To line.Length - 1
                        Dim harf1 As String = line.Substring(i, 1)
                        Dim harf2 As String = line.Substring(j, 1)
                        If IsNumeric(harf1) = True And IsNumeric(harf2) = True Then 'ikisi de rakamsa sırala
                            If harf1 > harf2 Then line = ChangeOrder(line, i, j)
                        ElseIf IsNumeric(harf1) = False And IsNumeric(harf2) = True Then 'ikincisi rakamsa yer değiştir
                            line = ChangeOrder(line, i, j)
                        ElseIf IsNumeric(harf1) = True And IsNumeric(harf2) = False Then 'ilki rakamsa bir şey yapma
                        ElseIf (harf1 >= "A" And harf1 <= "Z") And (harf2 >= "A" And harf2 <= "Z") Then 'ikisi de büyük harf ise sırala
                            If harf1 > harf2 Then line = ChangeOrder(line, i, j)
                        ElseIf (harf1 >= "a" And harf1 <= "z") And (harf2 >= "A" And harf2 <= "Z") Then 'ilki küçük harf ise yer değiştir
                            line = ChangeOrder(line, i, j)
                        ElseIf (harf1 >= "A" And harf1 <= "Z") And (harf2 >= "a" And harf2 <= "z") Then 'ikincisi küçük harf ise bir şey yapma
                        End If
                    Next
                Next
                'finish
                'Dim sonuc(line.Length - 1) As String
                'For i As Integer = 0 To line.Length - 1
                '    sonuc(i) = line.Substring(i, 1)
                'Next
                Dim sonuc(,) As String = Permutations(line)
                Console.WriteLine()
            End While
        End Using
        Console.ReadLine()
    End Sub
    'Sub Permute(nums() As String, Optional start As Integer = 0)
    '    If start = nums.Length Then
    '        OutputArray(nums)
    '    Else
    '        For i As Integer = start To nums.Length - 1
    '            Swap(nums, start, i)
    '            Permute(nums, start + 1)
    '            Swap(nums, start, i)
    '        Next
    '    End If
    'End Sub
    'Sub Swap(ByRef nums() As String, i As Integer, j As Integer)
    '    Dim temp As String
    '    temp = nums(i)
    '    nums(i) = nums(j)
    '    nums(j) = temp
    'End Sub
    'Sub OutputArray(nums() As String)
    '    For Each num As String In nums
    '        Console.Write(num.ToString)
    '    Next
    '    Console.Write(",")
    'End Sub

    ''sıralı permutasyon fonksiyonum
    'Function Permutations(str As String) As String()
    '    If str.Length < 2 Then Return Nothing
    '    Dim strNew(), tmpStr As String
    '    'use the factorial function to determine the number of rows needed
    '    'because redim preserve is slow   !!!!!!!!!!!
    '    ReDim strNew(Factorial(str.Length) - 1)
    '    strNew(0) = str
    '    Dim first As Integer = str.Length - 2 : Dim second As Integer = first + 1
    '    'tüm harfleri tara
    '    For i As Integer = 1 To UBound(strNew)

    '        tmpStr = ChangeOrder(str, first, second)
    '        strNew(i) = tmpStr
    '        second += 1
    '        If second = str.Length Then first -= 1 : second = first + 1
    '    Next
    '    'For i As Integer = str.Length - 2 To 0 Step -1
    '    '    For j As Integer = i + 1 To str.Length - 1
    '    '        tmpStr = ChangeOrder(str, i, j)
    '    '        strNew(row) = tmpStr : row += 1

    '    '    Next
    '    'Next
    '    Return strNew
    'End Function

    'rastgele permutations
    Private Function Permutations(ByVal data As String) As String(,)
        If data.Length < 2 Then Return Nothing

        Dim i As Int32
        Dim y As Int32
        Dim x As Int32
        Dim tempChar As String
        Dim newString As String
        Dim strs(,) As String
        Dim rowCount As Long
        'use the factorial function to determine the number of rows needed
        'because redim preserve is slow   !!!!!!!!!!!
        ReDim strs(data.Length - 1, Factorial(data.Length - 1) - 1)
        strs(0, 0) = data

        'swap each character(I) from the second postion to the second to last position
        For i = (data.Length - 2) To 1 Step -1
            'for each of the already created numbers
            For y = 0 To rowCount
                'do swaps for the character(I) with each of the characters to the right
                For x = data.Length To i + 2 Step -1
                    tempChar = strs(0, y).Substring(i, 1)
                    newString = strs(0, y)
                    Mid(newString, i + 1, 1) = newString.Substring(x - 1, 1)
                    Mid(newString, x, 1) = tempChar
                    rowCount = rowCount + 1
                    strs(0, rowCount) = newString
                Next
            Next
        Next


        'Shift Characters
        'for each empty column
        For i = 1 To data.Length - 1
            'move the shift character over one
            For x = 0 To strs.GetUpperBound(1)
                strs(i, x) = strs(i - 1, x)
                Mid(strs(i, x), i, 1) = strs(i - 1, x).Substring(i, 1)
                Mid(strs(i, x), i + 1, 1) = strs(i - 1, x).Substring(i - 1, 1)
            Next
        Next

        Return strs

    End Function
    'kelimenin harf sırasını değiştir
    Function ChangeOrder(str As String, var1 As Integer, var2 As Integer) As String
        Dim sonuc As String = str
        Mid(str, var1 + 1, 1) = sonuc.Substring(var2, 1)
        Mid(str, var2 + 1, 1) = sonuc.Substring(var1, 1)
        Return str
    End Function
    'factoryal hesaplama
    Public Function Factorial(ByVal number As Integer) As String
        Try
            If Number = 0 Then
                Return 1
            Else
                Return Number * Factorial(Number - 1)
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Module
