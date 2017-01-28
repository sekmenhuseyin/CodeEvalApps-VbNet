Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        Dim myFile As New FileInfo(sArgs(0))
        Console.WriteLine(myFile.Length)
        Console.ReadLine()
    End Sub
End Module
