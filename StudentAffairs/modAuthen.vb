Imports System.Security.Cryptography
Imports System.Text

Module modAuthen
    Private userID As String = "00000"
    Private userRoleID As String
    Private authenticationStatus As Boolean
    Public Function setUserDetail(uID As String, uRoleID As String, authenStatus As Boolean)
        userID = uID
        userRoleID = uRoleID
        authenticationStatus = authenStatus
    End Function

    Public Function getUserRoleID()
        Return userRoleID
    End Function

    Public Function getUserID()
        Return userID
    End Function

    Public Function getStatus()
        Return authenticationStatus
    End Function

    Public Function generatePassword(Optional ByVal n As Integer = 8) As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To n 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function generateUsername(id As String) As String
        Dim username As String
        username = "T" & id
        Return username
    End Function
    Public Function Hash512(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

End Module
