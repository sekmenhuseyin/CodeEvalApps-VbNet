Imports System.IO
Module mdlMain
    Sub Main(ByVal sArgs() As String)
        'dosyayı aç
        Dim dosyaYolu As String = sArgs(0)
        Using sr As New StreamReader(dosyaYolu)
            'satır oldukça
            While (sr.Peek() <> -1)
                Dim line As String = sr.ReadLine()
                Dim sonuc As String = ValidateEmailFormat(line).ToString().ToLower()
                Console.WriteLine(sonuc)
            End While
        End Using
        Console.ReadLine()
    End Sub
    'bu 16da yanlış söylüyor: %90 doğru
    Function isEmail(email As String) As Boolean
        Try
            Dim tmp As Net.Mail.MailAddress = New Net.Mail.MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    'en.wikipedia.org/wiki/Email_address
    Function ValidateEmailFormat(email As String) As Boolean
        'ilk kontroller
        If Len(email) > 320 Then Return False '320 karakterden uzun olamaz
        If InStr(email, "..") > 0 Then Return False 'iki nokta asla yanyana olamaz
        If InStr(email, "@") = 0 Then Return False 'en az bir @ işareti olmalı
        If email.Length <> email.Trim().Length Then Return False 'başta ve sonda boşluk olamaz
        If Left(email, 1) = "." Or Right(email, 1) = "." Then Return False 'başta ve sonda nokta olamaz
        'find position of @
        Dim qPos As Integer
        For i As Integer = 0 To email.Length - 1
            If email.Substring(i, 1) = "@" Then qPos = i
        Next
        'local and domain parts
        Dim localPart As String = email.Substring(0, qPos)
        Dim domainPart As String = email.Substring(qPos + 1)
        Dim forbidden As String = "%# (),:;<>@[\]" : Dim tmp As String
        ''''''''''''''local part control
        If Len(localPart) > 64 Then Return False 'local part uzunluk kontrolü
        'eğer komple tırnak içindeyse
        If Left(localPart, 1) = """" And Right(localPart, 1) = """" Then
        Else 'tırnak yoksa normal kurallar
            If InStr(localPart, "@") > 0 Then Return False '@ işareti olmamalı
            If InStr(localPart, """") > 0 Then Return False '"" işareti olmamalı
            If Right(localPart, 1) = "." Then Return False 'sonda nokta olamaz
            'yasak karakter kullanımı
            tmp = localPart
            For i As Integer = 0 To forbidden.Length - 1 : tmp = tmp.Replace(forbidden.Substring(i, 1), "") : Next
            If tmp <> localPart Then Return False
        End If
        '''''''''''domain part control
        'uzunluk kontrol
        If Len(domainPart) < 3 Or Len(domainPart) > 64 Then Return False
        If InStr(domainPart, """") > 0 Then Return False '"" işareti olmamalı
        If InStr(domainPart, "*") > 0 Then Return False '* işareti olmamalı
        If Left(domainPart, 1) = "." Then Return False 'başta nokta olamaz
        'yasak karakter kullanımı
        tmp = domainPart
        For i As Integer = 0 To forbidden.Length - 1 : tmp = tmp.Replace(forbidden.Substring(i, 1), "") : Next
        If tmp <> domainPart Then Return False
        'if passes every control then return true
        Return True
    End Function
End Module
