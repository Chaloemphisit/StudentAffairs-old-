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
        frmStdList.MdiParent = Me
        frmStdList.Show()
    End Sub


    Private Sub btnStdList_Click(sender As Object, e As EventArgs) Handles btnStdList.Click
        'MessageBox.Show("User ID :  " & getUserID() & ", " & getUserRoleID())
        frmStdList.MdiParent = Me
        frmStdList.Show()
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

    Private Sub btnMUser_Click(sender As Object, e As EventArgs) Handles btnMUser.Click
        frmRegister.Show()
        Me.Enabled = False
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        frmBehavior.MdiParent = Me
        frmBehavior.Show()
    End Sub
End Class