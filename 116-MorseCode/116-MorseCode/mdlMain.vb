Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim morse() As String = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."}
        Dim alfabe() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As String = ""
                line = line.Replace("  ", ";")
                Dim words() As String = line.Split(";")
                'all words
                For i As Integer = 0 To words.Length - 1
                    Dim letters() As String = words(i).Split(" ")
                    'all letters
                    For j As Integer = 0 To letters.Length - 1
                        'morse codes
                        For k As Integer = 0 To morse.Length - 1
                            If morse(k) = letters(j) Then sonuc &= alfabe(k) : Exit For

                        Next


                    Next
                    sonuc &= " "

                Next
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module
