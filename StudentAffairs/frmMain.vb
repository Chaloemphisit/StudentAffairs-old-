Imports System.ComponentModel
Imports System.Data.OleDb
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.WindowState = FormWindowState.Maximized
        frmLogin.Hide()
        bgwOpenStdList.RunWorkerAsync()
        'frmStdList.MdiParent = Me
        'frmStdList.Show()
    End Sub


    Private Sub btnStdList_Click(sender As Object, e As EventArgs) Handles btnStdList.Click
        'MessageBox.Show("User ID :  " & getUserID() & ", " & getUserRoleID())
        'frmStdList.MdiParent = Me
        'frmStdList.Show()
        bgwOpenStdList.RunWorkerAsync()
    End Sub
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignout.Click
        Me.Dispose()
        setUserDetail("", "", False)
        frmLogin.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub btnOpenDataManagemet_Click(sender As Object, e As EventArgs) Handles btnOpenDataManagemet.Click
        'frmDataManagement.MdiParent = Me
        Me.Enabled = False
        frmDataManagement.Show()

    End Sub

    Private Sub bgwOpenStdList_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwOpenStdList.DoWork
        frmStdList.MdiParent = Me
        stlMsg.Text = "Process.."
        frmStdList.Show()
    End Sub

    Private Sub bgwOpenStdList_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwOpenStdList.RunWorkerCompleted
        If e.Cancelled = True Then
            stlMsg.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            stlMsg.Text = "Error: " & e.Error.Message
        Else
            stlMsg.Text = "Ready"
        End If
    End Sub

End Class