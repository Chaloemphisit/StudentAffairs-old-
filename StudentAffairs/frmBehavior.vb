Imports System.Data.OleDb
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping

Public Class frmBehavior
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim shd1 As New GridStackedHeaderDescriptor("header1", "ข้อมูลทั้่วไป")
        Dim shd2 As New GridStackedHeaderDescriptor("header2", "พฤติกรรม")

        shd1.VisibleColumns.AddRange(New GridStackedHeaderVisibleColumnDescriptor() {
            New GridStackedHeaderVisibleColumnDescriptor("std_ID"),
            New GridStackedHeaderVisibleColumnDescriptor("std_FirstName"),
            New GridStackedHeaderVisibleColumnDescriptor("std_LastName"),
            New GridStackedHeaderVisibleColumnDescriptor("std_Class"),
            New GridStackedHeaderVisibleColumnDescriptor("std_Room")
            })

        shd2.VisibleColumns.AddRange(New GridStackedHeaderVisibleColumnDescriptor() {
            New GridStackedHeaderVisibleColumnDescriptor("BehaviorDetail"),
            New GridStackedHeaderVisibleColumnDescriptor("Implementation"),
            New GridStackedHeaderVisibleColumnDescriptor("Realization"),
            New GridStackedHeaderVisibleColumnDescriptor("Type"),
            New GridStackedHeaderVisibleColumnDescriptor("CreateAt"),
            New GridStackedHeaderVisibleColumnDescriptor("RecorderName")
            })

        Dim shrd As New GridStackedHeaderRowDescriptor("Row1", New GridStackedHeaderDescriptor() {shd1, shd2})

        ' Step 4: Add the GridStackedRowHeaderDescriptor collection to the StackedHeaderRows
        Me.GGC.TableDescriptor.StackedHeaderRows.Add(shrd)

        ' Display Stacked Headers 
        Me.GGC.TopLevelGroupOptions.ShowStackedHeaders = True
    End Sub
    Private Sub RetrieveData(Optional ByVal blnSearch As Boolean = False)
        strSQL =
            "SELECT tblStudent.std_ID, tblStudent.std_FirstName, tblStudent.std_LastName, " &
            "tblStudent.std_Class, tblStudent.std_Room, tblBehavior.BehaviorDetail, " &
            "tblBehavior.Implementation, tblBehavior.Realization, tblBehaviorType.Type, " &
            "tblBehavior.CreateAt, " &
            "[tblTeacher].[TeacherFirstName] & ' ' & [TeacherLastName] AS RecorderName, " &
            "tblBehavior.RecorderID, tblBehavior.BehaviorType FROM tblTeacher " &
            "INNER JOIN (tblStudent INNER JOIN (tblBehaviorType INNER JOIN tblBehavior " &
            "ON tblBehaviorType.BehaviorTypePK = tblBehavior.BehaviorType) " &
            "ON tblStudent.std_ID = tblBehavior.std_ID) " &
            "ON tblTeacher.TeacherID = tblBehavior.RecorderID "


        '// blnSearch = True for Serach
        If blnSearch Then
            strSQL = strSQL &
                " WHERE " &
                " [std_ID] " & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [std_FirstName] " & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [std_LastName] " & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " ORDER BY [tblBehavior.CreateAt] "
        Else
            strSQL = strSQL & " ORDER BY tblBehavior.CreateAt "
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

    ' / --------------------------------------------------------------------------------
    Private Sub InitGridGroup()
        '// Initialize Columns GridGroup
        With Me.GGC
            '// Hidden  Column
            .TableDescriptor.VisibleColumns.Remove("RecorderID")
            .TableDescriptor.VisibleColumns.Remove("BehaviorType")

            'Using Column Name
            .TableDescriptor.Columns("std_ID").HeaderText = "รหัสนักเรียน"
            .TableDescriptor.Columns("std_FirstName").HeaderText = "ชื่อ"
            .TableDescriptor.Columns("std_LastName").HeaderText = "นามสกุล"
            .TableDescriptor.Columns("std_Class").HeaderText = "ชั้น"
            .TableDescriptor.Columns("std_Room").HeaderText = "ห้อง"
            .TableDescriptor.Columns("BehaviorDetail").HeaderText = "รายละอียด"
            .TableDescriptor.Columns("Implementation").HeaderText = "การดำเนินการ"
            .TableDescriptor.Columns("Realization").HeaderText = "ผลการดำเนินการ"
            .TableDescriptor.Columns("Type").HeaderText = "ประเภท"
            .TableDescriptor.Columns("CreateAt").HeaderText = "วันที่บันทึก"
            .TableDescriptor.Columns("CreateAt").Appearance.AnyRecordFieldCell.Format = "dd/MM/yyyy"
            .TableDescriptor.Columns("CreateAt").Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.TextBox
            .TableDescriptor.Columns("RecorderName").HeaderText = "ผู้บันทึก"
        End With

        '// GridVerticalAlignment.Middle
        For i As Byte = 0 To 5
            With Me.GGC
                .TableDescriptor.Columns(i).Appearance.AnyRecordFieldCell.VerticalAlignment = GridVerticalAlignment.Middle
                .TableDescriptor.Columns(i).AllowGroupByColumn = False
                ' .TableDescriptor.Columns(i).Appearance.AnyRecordFieldCell.AutoSize = 10 'AutoSize
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
            .TopLevelGroupOptions.ShowGroupHeader = True ' True
            'Will enable the Group Footer for the group.
            .TopLevelGroupOptions.ShowGroupFooter = False 'True
            '//
            .TableOptions.GroupHeaderSectionHeight = 30
            .TableOptions.GroupFooterSectionHeight = 30
        End With

    End Sub

    Private Sub frmBehevior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = ConnectDataBase()
        RetrieveData()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ' / --------------------------------------------------------------------------------
    '// Full Select Row
    Private Sub GGC_TableControlCurrentCellActivating(sender As Object, e As GridTableControlCurrentCellActivatingEventArgs) Handles GGC.TableControlCurrentCellActivating
        '// Get Column Index 0 is the Primary Key. (Hidden column)
        e.Inner.ColIndex = 0
    End Sub

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
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
    '// Double click event for show detail of behavior in frmBehaviorDetail
    Private Sub GGC_TableControlCellDoubleClick(sender As Object, e As GridTableControlCellClickEventArgs) Handles GGC.TableControlCellDoubleClick

        '// Row of Column Header 
        If e.Inner.RowIndex <= 1 Then Return
        ' Notify the double click performed in a cell
        Dim rec As Record = Me.GGC.Table.DisplayElements(e.TableControl.CurrentCell.RowIndex).ParentRecord
        If (rec) IsNot Nothing Then
            'MsgBox("Primary key = " & rec.GetValue("std_ID").ToString & " " & rec.GetValue("std_FirstName").ToString & " " & rec.GetValue("std_LastName").ToString)
            Me.Enabled = False
            frmBehaviorDetail.Show()
            With frmBehaviorDetail
                .txtStudentID.Text = rec.GetValue("std_ID").ToString
                .txtStudentFirstName.Text = rec.GetValue("std_FirstName").ToString
                .txtStudentLastName.Text = rec.GetValue("std_LastName").ToString
                .txtClass.Text = rec.GetValue("std_Class").ToString
                .txtRoom.Text = rec.GetValue("std_Room").ToString
                .txtDetail.Text = rec.GetValue("BehaviorDetail").ToString
                .txtImplementation.Text = rec.GetValue("Implementation").ToString
                .txtRealization.Text = rec.GetValue("Realization").ToString
                .txtRecorderName.Text = rec.GetValue("RecorderName").ToString
                .DateTimePicker.BindableValue = rec.GetValue("CreateAt")
                .cbType.SelectedIndex = rec.GetValue("BehaviorType") - 1
            End With
        End If
    End Sub
End Class
