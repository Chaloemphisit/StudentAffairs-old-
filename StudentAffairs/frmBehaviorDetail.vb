Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms

Public Class frmBehaviorDetail
    Inherits MetroForm

    Private Sub frmBehaviorDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clsForm()
        Call RetrieveType()
        txtRecorderName.Text = ""
    End Sub

    '//Retrieve type of behavior to cbType
    Private Function RetrieveType()
        strSQL = "SELECT tblBehaviorType.* FROM tblBehaviorType  ORDER BY tblBehaviorType.BehaviorTypePK"
        Try
            Cmd = New OleDbCommand
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandText = strSQL
            Dim DR As OleDbDataReader = Cmd.ExecuteReader
            While DR.Read
                cbType.Items.Add(DR.Item("Type".ToString))
            End While
            DR.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    '//Retrieve RecorderName to txtRecorderName
    Private Function RetrieveRCName()
        strSQL = "SELECT [tblTeacher].[TeacherFirstName] & ' ' & [TeacherLastName] AS RecorderName, " &
            "tblUser.UserID FROM tblTeacher INNER JOIN tblUser ON tblTeacher.TeacherID = tblUser.UserID " &
            "WHERE tblUser.UserID = 59050180" '& getUserID
        Try
            Cmd = New OleDbCommand
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandText = strSQL
            Dim DR As OleDbDataReader = Cmd.ExecuteReader
            While DR.Read
                txtRecorderName.Text = DR.Item("RecorderName".ToString)
            End While
            DR.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub clsForm()
        txtStudentID.Text = ""
        txtStudentFirstName.Text = ""
        txtStudentLastName.Text = ""
        txtClass.Text = ""
        txtRoom.Text = ""
        txtDetail.Text = ""
        txtImplementation.Text = ""
        txtRealization.Text = ""
        txtRecorderName.Text = ""
    End Sub

    Private Sub frmBehaviorDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmBehavior.Enabled = True
        Me.Dispose()
    End Sub
End Class
