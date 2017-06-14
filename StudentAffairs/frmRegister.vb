Imports System.ComponentModel
Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmRegister
    Inherits MetroForm
    Dim RoleID As Integer
    Dim NewData As Boolean = False

    Private Function checkExistUser(username As String, teacherID As String) As Boolean
        'the query:
        Dim strSQL As String = "SELECT tblUser.Username, tblTeacher.TeacherID " &
                               "FROM tblTeacher INNER JOIN tblUser ON tblTeacher.TeacherID = tblUser.UserID "
        strSQL = strSQL & " WHERE Username = '" & username & "' Or TeacherID = " & teacherID
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        Cmd = New OleDbCommand(strSQL, Conn)
        DR = Cmd.ExecuteReader()

        Dim userFound As Boolean = False
        'if found:
        While DR.Read
            userFound = True
        End While

        'checking the result
        If userFound = True Then
            MessageBox.Show("พบผู้ใช้ในระบบ!", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            'MsgBox("ใช้งานได้", vbOKOnly,)
            Return True
        End If
        Conn.Close()
        Return False
    End Function

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

    Private Function registerNewUser()
        RoleID = cbUserRole.SelectedIndex + 1
        Dim str1, str2, str3 As Boolean
        '//----------------- Insert Teacher Data -----------------
        strSQL = "INSERT INTO tblTeacher(" &
                "TeacherID, TeacherFirstName, TeacherLastName, TeacherRole) " &
                " VALUES(" &
                " " & txtTeacherID.Text & " ," &
                "'" & txtFirstName.Text & "'," &
                "'" & txtLastName.Text & "'," &
                "'" & txtTRole.Text & "'" &
                ")"
        str1 = DoSQL(strSQL)

        strSQL = ""
        '//----------------- Insert User Data -----------------
        strSQL = "INSERT INTO tblUser(UserID, [Username], [Password], CreateByID) " &
                " VALUES(" & txtTeacherID.Text & ",'" & txtUsername.Text & "'," &
                "'" & Hash512(txtPassword.Text, txtUsername.Text) & "'," & getUserID() & ")"
        str2 = DoSQL(strSQL)

        '//----------------- Insert User Role -----------------
        strSQL = "INSERT INTO tblUserRole(" &
                " UserID, RoleID) " &
                " VALUES( " & txtTeacherID.Text & "," & RoleID & " )"
        str3 = DoSQL(strSQL)
        If (str1 And str2 And str3) Then
            MessageBox.Show("ลงทะเบียนเรียบร้อย.", "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        End If
    End Function

    Private Function DoSQL(ByVal Sql As String) As Boolean
        Cmd = New OleDb.OleDbCommand
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        'MsgBox(Sql)
        Try
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()
            'MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อย.", "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("Error Update: " & ex.Message)
            Return False
        End Try
        Return False
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

    Private Function checkValidatedCtl(ParamArray ByVal ctl() As Object) As Boolean
        Dim status As Boolean = True
        For i As Integer = 0 To UBound(ctl)
            If Trim(ctl(i).Text = "" Or ctl(i).Text = "กรุณากรอกข้อมูล!") Then
                ctl(i).Text = "กรุณากรอกข้อมูล!"
                ctl(i).BorderColor = Color.Red
                ctl(i).Focus()
                ckbShowPwd.Checked = True
                status = False
            End If
            If (ctl(i).GetType.Name.ToString = "ComboBoxAdv") Then
                If (ctl(i).SelectedIndex = -1) Then
                    cbUserRole.MetroBorderColor = Color.Red
                    status = False
                End If
            End If
        Next

        Return status

    End Function

    Private Function clsValidatedCtl(ParamArray ByVal ctl() As Object) As Boolean
        Dim status As Boolean = False
        For i As Integer = 0 To UBound(ctl)
            If Me.ActiveControl Is ctl(i) Then
                If Not (ctl(i).GetType.Name.ToString = "ButtonAdv") Then
                    If Trim(ctl(i).Text = "กรุณากรอกข้อมูล!") Then
                        ctl(i).Text = ""
                        ctl(i).BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
                        ckbShowPwd.Checked = True
                        status = False
                    End If
                End If
            End If
        Next
        status = False
        Return status
    End Function

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Conn = ConnectDataBase()
        RetrieveUserRole()
        txtTeacherID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtTRole.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        ckbGeneratePwd.Checked = True
        ckbShowPwd.Checked = True
    End Sub

    Private Sub ckbGeneratePwd_CheckStateChanged(sender As Object, e As EventArgs) Handles ckbGeneratePwd.CheckStateChanged
        If ckbGeneratePwd.Checked = True Then
            txtPassword.PasswordChar = ""
            txtPassword.Text = generatePassword()
            ckbShowPwd.Checked = True
        Else
            txtPassword.PasswordChar = "•"
            ckbShowPwd.Checked = False
        End If
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        frmMain.Enabled = True
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
        cbUserRole.MetroBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        NewData = True
        If (checkValidatedCtl(txtTeacherID, txtTRole, txtFirstName, txtLastName, txtUsername, txtPassword, cbUserRole)) Then
            If (checkExistUser(Trim(txtUsername.Text), Trim(txtTeacherID.Text))) Then
                registerNewUser()
            End If
        End If
    End Sub

    Private Sub frmRegister_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.Tab Then
            clsValidatedCtl(Me.ActiveControl)
        End If
    End Sub

    Private Sub txtTeacherID_Click(sender As Object, e As EventArgs) Handles txtTeacherID.Click
        clsValidatedCtl(txtTeacherID)
    End Sub

    Private Sub txtTRole_Click(sender As Object, e As EventArgs) Handles txtTRole.Click
        clsValidatedCtl(Me.ActiveControl)
    End Sub

    Private Sub txtFirstName_Click(sender As Object, e As EventArgs) Handles txtFirstName.Click
        clsValidatedCtl(Me.ActiveControl)
    End Sub

    Private Sub txtLastName_Click(sender As Object, e As EventArgs) Handles txtLastName.Click
        clsValidatedCtl(Me.ActiveControl)
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        clsValidatedCtl(Me.ActiveControl)
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        clsValidatedCtl(Me.ActiveControl)
        If ckbGeneratePwd.Checked = True Then
            txtPassword.SelectAll()
        End If
    End Sub

    Private Sub ckbGenUsername_CheckStateChanged(sender As Object, e As EventArgs) Handles ckbGenUsername.CheckStateChanged
        If ckbGenUsername.Checked = True And Not txtTeacherID.Text = "" Then
            txtUsername.Text = generateUsername(txtTeacherID.Text)
        End If
    End Sub

    Private Sub frmRegister_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
