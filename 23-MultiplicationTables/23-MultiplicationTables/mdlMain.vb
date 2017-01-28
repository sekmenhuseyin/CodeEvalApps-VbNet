Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        For i As Integer = 1 To 12
            Dim line As String = ""
            For j As Integer = 1 To 12
                line &= Right("   " & (i * j), 4)
            Next
            Console.WriteLine(line)
        Next
        Console.ReadLine()
    End Sub
End Module
