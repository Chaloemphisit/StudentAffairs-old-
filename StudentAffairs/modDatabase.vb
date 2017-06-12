Imports System.Data.OleDb

Module modDatabase
    Public Conn As OleDbConnection
    Public Cmd As OleDbCommand
    Public DS As DataSet
    Public DR As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public strSQL As String

    Public Function ConnectDataBase() As System.Data.OleDb.OleDbConnection
        Dim strPath As String = MyPath(Application.StartupPath)
        'MsgBox(strPath)

        ' ให้ต่อท้ายด้วยโฟลเดอร์ตำแหน่งของข้อมูลที่ต้องการ คือ  \Data\ไฟล์ข้อมูล MS Access
        Dim strConn As String =
            "Provider = Microsoft.ACE.OLEDB.12.0;"
        strConn +=
            "Data Source = " & strPath & "Database\Student.accdb"

        Dim ConnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(strConn)
        ' Create Connection
        ConnDB.ConnectionString = strConn
        ' Return
        Return ConnDB
    End Function

    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with "\"
    ' / Return : C:\My Project\
    Function MyPath(AppPath As String) As String
        '/ MessageBox.Show(AppPath);
        AppPath = AppPath.ToLower()
        '/ Return Value
        MyPath = AppPath.Replace("\bin\debug", "\").Replace("\bin\release", "\")
        '// กรณีที่หาโฟลเดอร์ไม่เจอ จะทำให้ขาดเครื่องหมาย \ ต่อท้าย
        If Right(MyPath, 1) <> "\" Then MyPath = MyPath & "\"
    End Function
End Module
