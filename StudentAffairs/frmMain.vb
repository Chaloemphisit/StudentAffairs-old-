Imports System.ComponentModel
Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms.Tools

Public Class frmMain
    ' / --------------------------------------------------------------------------------
    '// Initialize DataGridView @Run Time
    Private Sub SetupDGVData()
        With dgvData
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .Font = New Font("Tahoma", 9)
            ' Columns Specified
            .Columns.Add("std_ID", "รหัสนักเรียน")
            .Columns.Add("std_IDCard", "รหัสประจำตัวประชาชน")
            .Columns.Add("Prefix", "คำนำหน้า")
            .Columns.Add("std_FirstName", "ชื่อ")
            .Columns.Add("std_LastName", "นามสกุล")
            .Columns.Add("Gender", "เพศ")
            .Columns.Add("std_Class", "ชั้น")
            .Columns.Add("std_Room", "ห้อง")
            .Columns.Add("std_Birthday", "วันเกิด")
            .Columns.Add("std_AgeY", "อายุ")
            .Columns.Add("std_Blood", "กรุ๊ปเลือด")
            .Columns.Add("std_Ethnicity", "เชื้อชาติ")
            .Columns.Add("std_Nationaliti", "สัญชาติ")
            .Columns.Add("std_Religion", "ศาสนา")
            '// Hidden Columns
            '.Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(8).Visible = False
            '.Columns(9).Visible = False

            ' Autosize Column
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            '// Even-Odd Color
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

            ' Adjust Header Styles
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White ' Color.White
                .Font = New Font("Tahoma", 9, FontStyle.Bold)
            End With
        End With
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Collect all searches and impressions. Come in the same place
    ' / blnSearch = True, Show that the search results.
    ' / blnSearch is set to False, Show all records.
    Private Sub RetrieveData(Optional ByVal blnSearch As Boolean = False)
        strSQL = " SELECT tblStudent.std_ID, tblStudent.std_IDCard, Prefix.Prefix, tblStudent.std_FirstName, " &
            "tblStudent.std_LastName, Gender.Gender, tblStudent.std_Class, tblStudent.std_Room, " &
            "tblStudent.std_Birthday, tblStudent.std_AgeY, tblStudent.std_AgeM, tblStudent.std_Blood, " &
            "tblStudent.std_Ethnicity, tblStudent.std_Nationaliti, tblStudent.std_Religion " &
            "FROM Prefix INNER JOIN (Gender INNER JOIN tblStudent ON Gender.GenderPK = tblStudent.std_Gender) " &
            "ON Prefix.PrefixPK = tblStudent.std_Prefix"

        '// blnSearch = True for Serach
        If blnSearch Then
            strSQL = strSQL &
                " WHERE " &
                " [std_ID] " & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [std_IDCard] " & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [std_FirstName] " & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [std_LastName] " & " Like '%" & txtSearch.Text & "%'" &
                " ORDER BY std_ID "
        Else
            strSQL = strSQL & " ORDER BY std_ID "
        End If
        '//
        Try
            Cmd = New OleDbCommand
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandText = strSQL
            Dim DR As OleDbDataReader = Cmd.ExecuteReader
            Dim i As Long = dgvData.RowCount
            While DR.Read

                With dgvData
                    .Rows.Add(i)
                    .Rows(i).Cells(0).Value = DR.Item("std_ID").ToString
                    .Rows(i).Cells(1).Value = DR.Item("std_IDCard").ToString
                    .Rows(i).Cells(2).Value = DR.Item("Prefix").ToString
                    .Rows(i).Cells(3).Value = DR.Item("std_FirstName").ToString
                    .Rows(i).Cells(4).Value = DR.Item("std_LastName").ToString
                    .Rows(i).Cells(5).Value = DR.Item("Gender").ToString
                    .Rows(i).Cells(6).Value = DR.Item("std_Class").ToString
                    .Rows(i).Cells(7).Value = DR.Item("std_Room").ToString
                    .Rows(i).Cells(8).Value = DR.Item("std_Birthday").ToString
                    .Rows(i).Cells(9).Value = DR.Item("std_AgeY").ToString
                    .Rows(i).Cells(10).Value = DR.Item("std_Blood").ToString
                    .Rows(i).Cells(11).Value = DR.Item("std_Ethnicity").ToString
                    .Rows(i).Cells(12).Value = DR.Item("std_Nationaliti").ToString
                    .Rows(i).Cells(13).Value = DR.Item("std_Religion").ToString
                End With
                stlStatus.Text = "กำลังโหลด : " & i & " รายการ"
                i += 1
            End While
            If DR.Read = False Then
                Me.WindowState = FormWindowState.Maximized
            End If
            lblRecordCount.Text = "[Total : " & dgvData.RowCount & " records]"
            stlStatus.Text = "เสร็จสิ้น"
            DR.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '//
        txtSearch.Clear()
    End Sub
    Private Sub dgvData_DoubleClick(sender As Object, e As EventArgs) Handles dgvData.DoubleClick
        Dim iRow As Integer
        '// Read the value of the focus row.
        iRow = dgvData.CurrentRow.Index
        MessageBox.Show(dgvData.Item(0, iRow).Value & " " & dgvData.Item(2, iRow).Value & " " & dgvData.Item(3, iRow).Value & " " & dgvData.Item(4, iRow).Value)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        '// Undesirable characters for the database ex.  ', * or %
        txtSearch.Text = Replace(Trim(txtSearch.Text), "'", "")
        txtSearch.Text = Replace(Trim(txtSearch.Text), "%", "")
        txtSearch.Text = Replace(Trim(txtSearch.Text), "*", "")
        If Trim(txtSearch.Text) = "" Or Len(Trim(txtSearch.Text)) = 0 Then Exit Sub
        ' RetrieveData(True) It means searching for information.
        If e.KeyChar = Chr(13) Then '// Press Enter
            '// No beep.
            e.Handled = True
            '//
            'bgwSearch.RunWorkerAsync()
            dgvData.Rows.Clear()
            Call RetrieveData(True)
        End If
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Conn = ConnectDataBase()
        Call SetupDGVData()
        'bgwLoad.RunWorkerAsync()
        stlStatus.Visible = True
        Call RetrieveData()

    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub btnStdList_Click(sender As Object, e As EventArgs) Handles btnStdList.Click
        MessageBox.Show("User ID :  " & getUserID() & ", " & getUserRoleID())

    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoad.DoWork
        stlStatus.Visible = True
        Call RetrieveData()
    End Sub

    Private Sub bgwLoad_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwLoad.ProgressChanged
        stlStatus.Text = "กำลังโหลดข้อมูล : " & e.ProgressPercentage.ToString & " รายการ"
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        If e.Cancelled = True Then
            lblRecordCount.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            lblRecordCount.Text = "Error: " & e.Error.Message

        Else
            stlStatus.Text = "พร้อม"
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvData.Rows.Clear()
        bgwLoad.RunWorkerAsync()
    End Sub

    Private Sub bgwSearch_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwSearch.DoWork
        stlStatus.Visible = True
        dgvData.Rows.Clear()
        Call RetrieveData(True)
    End Sub

    Private Sub bgwSearch_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwSearch.RunWorkerCompleted
        If e.Cancelled = True Then
            stlStatus.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            stlStatus.Text = "Error: " & e.Error.Message

        Else
            stlStatus.Text = "พร้อม"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("UserID :" & getUserID() & " | RoleID:" & getUserRoleID())
    End Sub
End Class