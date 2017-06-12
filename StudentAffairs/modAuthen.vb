Module modAuthen
    Private userID As String
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



End Module
