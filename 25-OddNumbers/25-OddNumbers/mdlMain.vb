Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        For i As Integer = 1 To 99
            If i Mod 2 = 1 Then Console.WriteLine(i)
        Next
        Console.ReadLine()
    End Sub
End Module
