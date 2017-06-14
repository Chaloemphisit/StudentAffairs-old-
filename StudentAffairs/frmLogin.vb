Imports System.Data.OleDb

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = ConnectDataBase()
    End Sub

    Private Sub CheckLogin(username As String, password As String)
        'the query:
        Dim strSQL As String = "SELECT tblUser.UserID, tblUser.Username, tblUser.Password, tblUserRole.RoleID, tblRole.RoleDescription
FROM tblUser INNER JOIN (tblRole INNER JOIN tblUserRole ON tblRole.[RoleID] = tblUserRole.[RoleID]) ON tblUser.[UserID] = tblUserRole.[UserID]"

        strSQL = strSQL & " WHERE [Username] = '" & username & "' AND " & "[Password] = '" & Hash512(password, username) & "'"
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        Cmd = New OleDbCommand(strSQL, Conn)
        DR = Cmd.ExecuteReader()

        Dim userFound As Boolean = False
        Dim role As String
        'if found:
        While DR.Read
            userFound = True
            role = DR("RoleDescription").ToString
            setUserDetail(DR("UserID").ToString, DR("RoleID").ToString, userFound)
        End While

        'checking the result
        If userFound = True Then
            'MsgBox("Login Success. You are " & role, MsgBoxStyle.OkOnly, "welcome")
            'Me.Hide()
            addLog()
            frmMain.Show()

        Else
            txtPassword.Text = ""
            txtUsername.Text = ""
            ''lblMessageError.Text = "ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง!"
            ' MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง","ผิดพลาด", vbOKOnly)
            MsgBox("ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง กรุณาลองอีกครั้ง", vbOKOnly, "ผิดพลาด")
        End If

        Conn.Close()
    End Sub

    Private Sub addLog()
        strSQL = "INSERT INTO tblLog(UserID) " &
                 "VALUES(" & getUserID() & ")"
        DoSQL(strSQL)
    End Sub

    '// UPDATE DATA
    Private Sub DoSQL(ByVal Sql As String)
        Cmd = New OleDb.OleDbCommand
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        'MsgBox(Sql)
        Try
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()
            'MessageBox.Show("Records Updated Completed.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cmd.Dispose()
        Catch ex As Exception
            'MsgBox("Error Update: " & ex.Message)
        End Try
    End Sub


    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        If (txtPassword.Text = "" Or txtUsername.Text = "") Then
            'lblMessageError.Text = "Please fill Username or Password"
        Else
            CheckLogin(Trim(txtUsername.Text), Trim(txtPassword.Text))
        End If

    End Sub
End Class
