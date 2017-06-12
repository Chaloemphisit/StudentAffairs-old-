Module modAuthen
    Private userID As String
    Private userRoleID As String

    Public Function setUserID(uID As String)
        userID = uID
    End Function

    Public Function setUserRoleID(uRoleID As String)
        userRoleID = uRoleID
    End Function

    Public Function getUserRoleID()
        Return userRoleID
    End Function

    Public Function getUserID()
        Return userID
    End Function

End Module
