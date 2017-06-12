Imports System.ComponentModel
Imports System.Data.OleDb
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid

Public Class frmStdList
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmStdList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        'Application.Exit()
    End Sub

    Private Sub frmStdList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conn = ConnectDataBase()
        Call RetrieveData(False)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RetrieveData(Optional ByVal blnSearch As Boolean = False)
        strSQL =
            "SELECT tblStudent.std_ID, tblStudent.std_IDCard, Prefix.Prefix, tblStudent.std_FirstName, " &
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
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        '// Data Table Collection
        Dim DTC As DataTableCollection
        Dim Source1 As New BindingSource
        DS = New DataSet
        DTC = DS.Tables
        DA = New OleDbDataAdapter(strSQL, Conn)
        DA.Fill(DS, "Student") 'Change items to your database name
        Dim DV As New DataView(DTC(0))
        Source1.DataSource = DV
        Me.GGC.DataSource = DV
        lblRecordCount.Text = "[Total: " & Format(DV.Count, "#,##") & " Records.]"
        DA.Dispose()
        DS.Dispose()
        Conn.Close()
        '//
        Call InitGridGroup()
        '//
        txtSearch.Clear()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call RetrieveData()
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If Trim(txtSearch.Text) = "" Or Len(Trim(txtSearch.Text)) = 0 Then Exit Sub
        '// Undesirable characters for the database ex.  ', * or %
        txtSearch.Text = Replace(Trim(txtSearch.Text), "'", "")
        txtSearch.Text = Replace(Trim(txtSearch.Text), "%", "")
        txtSearch.Text = Replace(Trim(txtSearch.Text), "*", "")
        ' RetrieveData(True) It means searching for information.
        If e.KeyChar = Chr(13) Then '// Press Enter
            '// No beep.
            e.Handled = True
            '//
            Call RetrieveData(True)
        End If
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub InitGridGroup()
        '// Initialize Columns GridGroup
        With Me.GGC
            '// Hidden Primary Key Column
            .TableDescriptor.VisibleColumns.Remove("PrimaryKey")
            'Using Column Name
            .TableDescriptor.Columns("std_ID").HeaderText = "รหัสนักเรียน"
            .TableDescriptor.Columns("std_IDCard").HeaderText = "รหัสประจำตัวประชาชน"
            .TableDescriptor.VisibleColumns.Remove("std_IDCard")
            .TableDescriptor.Columns("Prefix").HeaderText = "คำนำหน้า"
            .TableDescriptor.Columns("std_FirstName").HeaderText = "ชื่อ"
            .TableDescriptor.Columns("std_LastName").HeaderText = "นามสกุล"
            .TableDescriptor.Columns("Gender").HeaderText = "เพศ"
            .TableDescriptor.Columns("std_Class").HeaderText = "ชั้นe"
            .TableDescriptor.Columns("std_Room").HeaderText = "ห้อง"
            .TableDescriptor.Columns("std_Birthday").HeaderText = "วันเกิด"
            .TableDescriptor.Columns("std_Birthday").Appearance.AnyRecordFieldCell.Format = "dd/MM/yyyy"
            .TableDescriptor.Columns("std_Birthday").Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.TextBox
            .TableDescriptor.Columns("std_AgeY").HeaderText = "อายุ"
            .TableDescriptor.Columns("std_Blood").HeaderText = "หมู่เลือด"
            .TableDescriptor.Columns("std_Ethnicity").HeaderText = "เชื้อชาติ"
            .TableDescriptor.Columns("std_Nationaliti").HeaderText = "สัญชาติ"
            .TableDescriptor.Columns("std_Religion").HeaderText = "ศาสนา"

        End With
        '// GridVerticalAlignment.Middle
        For i As Byte = 0 To 5
            With Me.GGC
                .TableDescriptor.Columns(i).Appearance.AnyRecordFieldCell.VerticalAlignment = GridVerticalAlignment.Middle
                .TableDescriptor.Columns(i).AllowGroupByColumn = False
                .TableDescriptor.Columns(i).Appearance.AnyRecordFieldCell.AutoSize = AutoSize
            End With
        Next
        '// Initialize normal GridGrouping
        With Me.GGC
            ' Allows GroupDropArea to be visible
            .ShowGroupDropArea = False  ' Disable
            '// Hidden Top Level of Grouping
            .TopLevelGroupOptions.ShowCaption = False

            '// Metro Styles
            .GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            ' Disables editing in GridGroupingControl
            .ActivateCurrentCellBehavior = GridCellActivateAction.None
            '// Disable Add New
            .TableDescriptor.AllowNew = False
            '// Autofit Columns
            .AllowProportionalColumnSizing = True

            '// Row Height
            .Table.DefaultRecordRowHeight = 25
            '// 
            .Table.DefaultCaptionRowHeight = 25
            .Table.DefaultColumnHeaderRowHeight = 30    '// Columns Header

            '// Selection
            .TableOptions.ListBoxSelectionMode = SelectionMode.One
            'Selection Back color
            .TableOptions.SelectionBackColor = Color.Firebrick
            '//
            .Appearance.ColumnHeaderCell.TextColor = Color.DarkBlue

            'Applies back color as LightCyan for alternative records in the Grid.
            .Appearance.AlternateRecordFieldCell.BackColor = Color.LightCyan
        End With

        With Me.GGC
            'Disable record preview row 
            .TableOptions.ShowRecordPreviewRow = False
            '//
            'Will enable the Group Header for the top most group.
            .TopLevelGroupOptions.ShowGroupHeader = False ' True
            'Will enable the Group Footer for the group.
            .TopLevelGroupOptions.ShowGroupFooter = False 'True
            '//
            .TableOptions.GroupHeaderSectionHeight = 30
            .TableOptions.GroupFooterSectionHeight = 30
        End With

    End Sub

    ' / --------------------------------------------------------------------------------
    '// Double click event for show PrimaryKey which hidden in Column(0)
    Private Sub GGC_TableControlCellDoubleClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs) Handles GGC.TableControlCellDoubleClick
        '// Row of Column Header 
        If e.Inner.RowIndex <= 1 Then Return
        ' Notify the double click performed in a cell
        Dim rec As Record = Me.GGC.Table.DisplayElements(e.TableControl.CurrentCell.RowIndex).ParentRecord
        If (rec) IsNot Nothing Then
            MsgBox("Primary key = " & rec.GetValue("std_ID").ToString & " " & rec.GetValue("std_FirstName").ToString & " " & rec.GetValue("std_LastName").ToString)
        End If
    End Sub

    ' / --------------------------------------------------------------------------------
    '// Full Select Row
    Private Sub GGC_TableControlCurrentCellActivating(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCurrentCellActivatingEventArgs) Handles GGC.TableControlCurrentCellActivating
        '// Get Column Index 0 is the Primary Key. (Hidden column)
        e.Inner.ColIndex = 0
    End Sub

End Class