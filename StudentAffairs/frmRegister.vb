Imports System.ComponentModel
Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmRegister
    Inherits MetroForm
    Dim RoleID As Integer

    Private Sub checkExistUser(username As String, teacherID As String)
        If Trim(username = "" Or teacherID = "") Then
            MessageBox.Show("Username Or Password is null")
        Else
            'the query:
            Dim strSQL As String = "SELECT tblUser.Username, tblTeacher.TeacherID FROM tblTeacher " &
                                "INNER JOIN tblUser ON tblTeacher.TeacherID = tblUser.UserID"

        strSQL = strSQL & " WHERE [Username] = '" & txtUsername.Text & "' OR [TeacherID] = '" & txtTeacherID.Text & "' "


        If Conn.State = ConnectionState.Closed Then Conn.Open()
        Cmd = New OleDbCommand(strSQL, Conn)
        DR = Cmd.ExecuteReader()

        Dim userFound As Boolean = False
        Dim role As String
        'if found:
        While DR.Read
            userFound = True
        End While

        'checking the result
        If userFound = True Then
            MessageBox.Show("พบผู้ใช้ในระบบ!", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            MsgBox("ใช้งานได้", vbOKOnly,)
        End If

            Conn.Close()
        End If
    End Sub

    Private Function RetrieveUserRole()
        strSQL = "SELECT tblRole.* FROM tblRole  ORDER BY tblRole.RoleID"

        Try
            Cmd = New OleDbCommand
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandText = strSQL
            Dim DR As OleDbDataReader = Cmd.ExecuteReader
            While DR.Read
                cbUserRole.Items.Add(DR.Item("RoleDescription".ToString))
            End While
            DR.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function RetrievePrefix()
        strSQL = "SELECT tblRole.* FROM tblRole  ORDER BY tblRole.RoleID"

        Try
            Cmd = New OleDbCommand
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandText = strSQL
            Dim DR As OleDbDataReader = Cmd.ExecuteReader
            While DR.Read
                cbUserRole.Items.Add(DR.Item("RoleDescription".ToString))
            End While
            DR.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function validatedForm() ' As Boolean
        If Trim(txtTeacherID.Text = "") Then
            txtTeacherID.Text = "กรุณากรอกข้อมูล!"
            txtTeacherID.BorderColor = Color.Red
        End If
        If Trim(txtTRole.Text = "") Then
            txtTRole.Text = "กรุณากรอกข้อมูล!"
            txtTRole.BorderColor = Color.Red
        End If
        If Trim(txtFirstName.Text = "") Then
            txtFirstName.Text = "กรุณากรอกข้อมูล!"
            txtFirstName.BorderColor = Color.Red
        End If
        If Trim(txtLastName.Text = "") Then
            txtLastName.Text = "กรุณากรอกข้อมูล!"
            txtLastName.BorderColor = Color.Red
        End If
        If Trim(txtUsername.Text = "") Then
            txtUsername.Text = "กรุณากรอกข้อมูล!"
            txtUsername.BorderColor = Color.Red
        End If
        If Trim(txtPassword.Text = "") Then
            txtPassword.Text = "กรุณากรอกข้อมูล!"
            txtPassword.PasswordChar = ""
            txtPassword.BorderColor = Color.Red
        End If
        If cbUserRole.SelectedValue = -1 Then
            cbUserRole.MetroBorderColor = Color.Red
        End If

        If Trim(txtTeacherID.Text = "" Or txtUsername.Text = "") Then
            Return False
        Else
            Return True
        End If



    End Function

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = ConnectDataBase()
        RetrieveUserRole()
        txtTeacherID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtTRole.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        ckbGeneratePwd.Checked = False
        ckbShowPwd.Checked = False
    End Sub

    Private Sub ckbGeneratePwd_CheckStateChanged(sender As Object, e As EventArgs) Handles ckbGeneratePwd.CheckStateChanged
        If ckbGeneratePwd.Checked = True Then
            txtPassword.PasswordChar = ""
            txtPassword.Text = geratePassword()
            ckbShowPwd.Checked = True
        Else
            txtPassword.PasswordChar = "•"
            txtPassword.Text = ""
            ckbShowPwd.Checked = False
        End If
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Me.Dispose()
    End Sub
    Private Sub ckbShowPwd_CheckStateChanged(sender As Object, e As EventArgs) Handles ckbShowPwd.CheckStateChanged
        If ckbShowPwd.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub cbUserRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUserRole.SelectedIndexChanged
        RoleID = cbUserRole.SelectedIndex + 1
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        validatedForm()
        If (validatedForm() = True) Then
            checkExistUser(Trim(txtUsername.Text), Trim(txtTeacherID.Text))
        End If
    End Sub

    Private Sub txtTeacherID_Click(sender As Object, e As EventArgs) Handles txtTeacherID.Click
        If txtTeacherID.BorderColor = Color.Red Then
            txtTeacherID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            txtTeacherID.Text = ""
        End If
    End Sub

    Private Sub txtFirstName_Click(sender As Object, e As EventArgs) Handles txtFirstName.Click
        If txtFirstName.BorderColor = Color.Red Then
            txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            txtFirstName.Text = ""
        End If
    End Sub

    Private Sub txtLastName_Click(sender As Object, e As EventArgs) Handles txtLastName.Click
        If txtLastName.BorderColor = Color.Red Then
            txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            txtLastName.Text = ""
        End If
    End Sub

    Private Sub txtTRole_Click(sender As Object, e As EventArgs) Handles txtTRole.Click
        If txtTRole.BorderColor = Color.Red Then
            txtTRole.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            txtTRole.Text = ""
        End If
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        If txtUsername.BorderColor = Color.Red Then
            txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If txtPassword.BorderColor = Color.Red Then
            txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub cbUserRole_Click(sender As Object, e As EventArgs) Handles cbUserRole.Click
        If cbUserRole.MetroBorderColor = Color.Red Then
            cbUserRole.MetroBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        End If
    End Sub
End Class
