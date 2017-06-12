Imports Syncfusion.Windows.Forms.Tools

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RibbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.ToolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.btnStdList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripTabItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.grList = New System.Windows.Forms.GroupBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.stlStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.bgwSearch = New System.ComponentModel.BackgroundWorker()
        CType(Me.RibbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonControlAdv1.SuspendLayout()
        Me.ToolStripTabItem1.Panel.SuspendLayout()
        Me.ToolStripEx1.SuspendLayout()
        Me.ToolStripEx2.SuspendLayout()
        Me.ToolStripEx3.SuspendLayout()
        Me.grList.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControlAdv1
        '
        Me.RibbonControlAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem1)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem2)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem3)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem4)
        Me.RibbonControlAdv1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro
        Me.RibbonControlAdv1.Location = New System.Drawing.Point(1, 0)
        Me.RibbonControlAdv1.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlAdv1.MenuButtonText = "ไฟล์"
        Me.RibbonControlAdv1.MenuButtonWidth = 56
        Me.RibbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.RibbonControlAdv1.Name = "RibbonControlAdv1"
        Me.RibbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed
        '
        'RibbonControlAdv1.OfficeMenu
        '
        Me.RibbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
        Me.RibbonControlAdv1.OfficeMenu.ShowItemToolTips = True
        Me.RibbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(12, 65)
        Me.RibbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RibbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
        Me.RibbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016
        Me.RibbonControlAdv1.SelectedTab = Me.ToolStripTabItem1
        Me.RibbonControlAdv1.ShowRibbonDisplayOptionButton = True
        Me.RibbonControlAdv1.Size = New System.Drawing.Size(876, 179)
        Me.RibbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
        Me.RibbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:"
        Me.RibbonControlAdv1.TabIndex = 0
        Me.RibbonControlAdv1.Text = "RibbonControlAdv1"
        Me.RibbonControlAdv1.TitleColor = System.Drawing.Color.Black
        '
        'ToolStripTabItem1
        '
        Me.ToolStripTabItem1.Name = "ToolStripTabItem1"
        '
        'RibbonControlAdv1.RibbonPanel1
        '
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx1)
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx2)
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx3)
        Me.ToolStripTabItem1.Panel.Name = "RibbonPanel1"
        Me.ToolStripTabItem1.Panel.ScrollPosition = 0
        Me.ToolStripTabItem1.Panel.TabIndex = 2
        Me.ToolStripTabItem1.Panel.Text = "รายการหลัก"
        Me.ToolStripTabItem1.Position = 0
        Me.ToolStripTabItem1.Size = New System.Drawing.Size(87, 30)
        Me.ToolStripTabItem1.Text = "รายการหลัก"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.AutoSize = False
        Me.ToolStripEx1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStdList, Me.ToolStripButton1})
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx1.Size = New System.Drawing.Size(154, 113)
        Me.ToolStripEx1.TabIndex = 0
        '
        'btnStdList
        '
        Me.btnStdList.Image = CType(resources.GetObject("btnStdList.Image"), System.Drawing.Image)
        Me.btnStdList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnStdList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStdList.Name = "btnStdList"
        Me.btnStdList.Size = New System.Drawing.Size(74, 91)
        Me.btnStdList.Text = "รายชื่อนักเรียน"
        Me.btnStdList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 91)
        Me.ToolStripButton1.Text = "แกไขข้อมูล"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripEx2
        '
        Me.ToolStripEx2.AutoSize = False
        Me.ToolStripEx2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx2.Image = Nothing
        Me.ToolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStripEx2.Location = New System.Drawing.Point(156, 1)
        Me.ToolStripEx2.Name = "ToolStripEx2"
        Me.ToolStripEx2.Office12Mode = False
        Me.ToolStripEx2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx2.Size = New System.Drawing.Size(153, 113)
        Me.ToolStripEx2.TabIndex = 1
        Me.ToolStripEx2.Text = "ส่งออก"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(67, 91)
        Me.ToolStripButton5.Text = "ส่งออก excel"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(60, 91)
        Me.ToolStripButton6.Text = "ส่งออก pdf"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripEx3
        '
        Me.ToolStripEx3.AutoSize = False
        Me.ToolStripEx3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx3.Image = Nothing
        Me.ToolStripEx3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStripEx3.Location = New System.Drawing.Point(311, 1)
        Me.ToolStripEx3.Name = "ToolStripEx3"
        Me.ToolStripEx3.Office12Mode = False
        Me.ToolStripEx3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx3.Size = New System.Drawing.Size(148, 113)
        Me.ToolStripEx3.TabIndex = 2
        Me.ToolStripEx3.Text = "การเข้าใช้งาน"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(67, 91)
        Me.ToolStripButton3.Text = "ออกจากระบบ"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(59, 91)
        Me.ToolStripButton4.Text = "ปิดโปรแกรม"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripTabItem2
        '
        Me.ToolStripTabItem2.Name = "ToolStripTabItem2"
        '
        'RibbonControlAdv1.RibbonPanel2
        '
        Me.ToolStripTabItem2.Panel.Name = "RibbonPanel2"
        Me.ToolStripTabItem2.Panel.ScrollPosition = 0
        Me.ToolStripTabItem2.Panel.TabIndex = 3
        Me.ToolStripTabItem2.Panel.Text = "พิมพ์รายงาน"
        Me.ToolStripTabItem2.Position = 1
        Me.ToolStripTabItem2.Size = New System.Drawing.Size(89, 30)
        Me.ToolStripTabItem2.Tag = "2"
        Me.ToolStripTabItem2.Text = "พิมพ์รายงาน"
        '
        'ToolStripTabItem3
        '
        Me.ToolStripTabItem3.Name = "ToolStripTabItem3"
        '
        'RibbonControlAdv1.RibbonPanel3
        '
        Me.ToolStripTabItem3.Panel.Name = "RibbonPanel3"
        Me.ToolStripTabItem3.Panel.ScrollPosition = 0
        Me.ToolStripTabItem3.Panel.TabIndex = 4
        Me.ToolStripTabItem3.Panel.Text = "ตั้งค่าระบบ"
        Me.ToolStripTabItem3.Position = 2
        Me.ToolStripTabItem3.Size = New System.Drawing.Size(79, 30)
        Me.ToolStripTabItem3.Tag = "3"
        Me.ToolStripTabItem3.Text = "ตั้งค่าระบบ"
        '
        'ToolStripTabItem4
        '
        Me.ToolStripTabItem4.Name = "ToolStripTabItem4"
        '
        'RibbonControlAdv1.RibbonPanel4
        '
        Me.ToolStripTabItem4.Panel.Name = "RibbonPanel4"
        Me.ToolStripTabItem4.Panel.ScrollPosition = 0
        Me.ToolStripTabItem4.Panel.TabIndex = 5
        Me.ToolStripTabItem4.Panel.Text = "เกี่ยวกับ"
        Me.ToolStripTabItem4.Position = 3
        Me.ToolStripTabItem4.Size = New System.Drawing.Size(69, 30)
        Me.ToolStripTabItem4.Tag = "4"
        Me.ToolStripTabItem4.Text = "เกี่ยวกับ"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(110, 91)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'grList
        '
        Me.grList.Controls.Add(Me.StatusStrip)
        Me.grList.Controls.Add(Me.btnRefresh)
        Me.grList.Controls.Add(Me.lblDesc)
        Me.grList.Controls.Add(Me.Label12)
        Me.grList.Controls.Add(Me.lblRecordCount)
        Me.grList.Controls.Add(Me.txtSearch)
        Me.grList.Controls.Add(Me.dgvData)
        Me.grList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grList.Location = New System.Drawing.Point(1, 179)
        Me.grList.Name = "grList"
        Me.grList.Size = New System.Drawing.Size(872, 265)
        Me.grList.TabIndex = 3
        Me.grList.TabStop = False
        Me.grList.Text = " Listing of Persons "
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(3, 240)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(866, 22)
        Me.StatusStrip.TabIndex = 58
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'stlStatus
        '
        Me.stlStatus.Name = "stlStatus"
        Me.stlStatus.Size = New System.Drawing.Size(39, 17)
        Me.stlStatus.Text = "Ready"
        Me.stlStatus.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(204, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(24, 24)
        Me.btnRefresh.TabIndex = 57
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblDesc
        '
        Me.lblDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Red
        Me.lblDesc.Location = New System.Drawing.Point(676, 25)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(191, 13)
        Me.lblDesc.TabIndex = 56
        Me.lblDesc.Text = "Double click the mouse to select items."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 14)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Search :"
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRecordCount.Location = New System.Drawing.Point(234, 24)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(17, 14)
        Me.lblRecordCount.TabIndex = 54
        Me.lblRecordCount.Text = "[]"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(68, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(130, 22)
        Me.txtSearch.TabIndex = 0
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(6, 49)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.RowTemplate.Height = 28
        Me.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(861, 210)
        Me.dgvData.TabIndex = 1
        '
        'bgwLoad
        '
        '
        'bgwSearch
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 445)
        Me.Controls.Add(Me.grList)
        Me.Controls.Add(Me.RibbonControlAdv1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบันทึกพฤติกรรมนักเรียน"
        CType(Me.RibbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonControlAdv1.ResumeLayout(False)
        Me.RibbonControlAdv1.PerformLayout()
        Me.ToolStripTabItem1.Panel.ResumeLayout(False)
        Me.ToolStripEx1.ResumeLayout(False)
        Me.ToolStripEx1.PerformLayout()
        Me.ToolStripEx2.ResumeLayout(False)
        Me.ToolStripEx2.PerformLayout()
        Me.ToolStripEx3.ResumeLayout(False)
        Me.ToolStripEx3.PerformLayout()
        Me.grList.ResumeLayout(False)
        Me.grList.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Friend WithEvents ToolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripTabItem2 As ToolStripTabItem
    Friend WithEvents ToolStripEx1 As ToolStripEx
    Friend WithEvents btnStdList As ToolStripButton
    Friend WithEvents ToolStripEx2 As ToolStripEx
    Friend WithEvents ToolStripEx3 As ToolStripEx
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripTabItem3 As ToolStripTabItem
    Friend WithEvents ToolStripTabItem4 As ToolStripTabItem
    Friend WithEvents ToolStripButton2 As ToolStripSplitButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents grList As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblDesc As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents stlStatus As ToolStripStatusLabel
    Friend WithEvents bgwSearch As System.ComponentModel.BackgroundWorker
End Class
