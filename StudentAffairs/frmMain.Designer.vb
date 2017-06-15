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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RibbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.ToolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.btnStdList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.btnOpenDataManagemet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.btnMUser = New System.Windows.Forms.ToolStripButton()
        Me.btnSignout = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx7 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripTabItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx5 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabbedMDIManager = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager(Me.components)
        CType(Me.RibbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonControlAdv1.SuspendLayout()
        Me.ToolStripTabItem1.Panel.SuspendLayout()
        Me.ToolStripEx1.SuspendLayout()
        Me.ToolStripEx2.SuspendLayout()
        Me.ToolStripEx4.SuspendLayout()
        Me.ToolStripTabItem3.Panel.SuspendLayout()
        Me.ToolStripTabItem4.Panel.SuspendLayout()
        Me.ToolStripEx5.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControlAdv1
        '
        Me.RibbonControlAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem1)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem3)
        Me.RibbonControlAdv1.Header.AddMainItem(ToolStripTabItem4)
        Me.RibbonControlAdv1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro
        Me.RibbonControlAdv1.Location = New System.Drawing.Point(1, 0)
        Me.RibbonControlAdv1.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RibbonControlAdv1.MenuButtonText = ""
        Me.RibbonControlAdv1.MenuButtonVisible = False
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
        Me.RibbonControlAdv1.Size = New System.Drawing.Size(922, 179)
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
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx4)
        Me.ToolStripTabItem1.Panel.Name = "RibbonPanel1"
        Me.ToolStripTabItem1.Panel.ScrollPosition = 0
        Me.ToolStripTabItem1.Panel.TabIndex = 2
        Me.ToolStripTabItem1.Panel.Text = "รายการหลัก"
        Me.ToolStripTabItem1.Position = 0
        Me.ToolStripTabItem1.Size = New System.Drawing.Size(87, 25)
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
        Me.ToolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStdList, Me.ToolStripButton3, Me.btnOpenDataManagemet, Me.ToolStripSeparator2, Me.ToolStripButton9})
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx1.Size = New System.Drawing.Size(302, 118)
        Me.ToolStripEx1.TabIndex = 0
        Me.ToolStripEx1.Text = "จัดการข้อมูล"
        '
        'btnStdList
        '
        Me.btnStdList.Image = CType(resources.GetObject("btnStdList.Image"), System.Drawing.Image)
        Me.btnStdList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnStdList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStdList.Name = "btnStdList"
        Me.btnStdList.Size = New System.Drawing.Size(74, 96)
        Me.btnStdList.Text = "รายชื่อนักเรียน"
        Me.btnStdList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Enabled = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(56, 96)
        Me.ToolStripButton3.Text = "แกไขข้อมูล"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnOpenDataManagemet
        '
        Me.btnOpenDataManagemet.Enabled = False
        Me.btnOpenDataManagemet.Image = CType(resources.GetObject("btnOpenDataManagemet.Image"), System.Drawing.Image)
        Me.btnOpenDataManagemet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOpenDataManagemet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpenDataManagemet.Name = "btnOpenDataManagemet"
        Me.btnOpenDataManagemet.Size = New System.Drawing.Size(64, 96)
        Me.btnOpenDataManagemet.Text = "จัดการข้อมูล"
        Me.btnOpenDataManagemet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 99)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(77, 96)
        Me.ToolStripButton9.Text = "บันทึกพฤติกรรม"
        Me.ToolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton9.ToolTipText = "บันทึกพฤติกรรม"
        '
        'ToolStripEx2
        '
        Me.ToolStripEx2.AutoSize = False
        Me.ToolStripEx2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx2.Image = Nothing
        Me.ToolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStripEx2.Location = New System.Drawing.Point(218, 1)
        Me.ToolStripEx2.Name = "ToolStripEx2"
        Me.ToolStripEx2.Office12Mode = False
        Me.ToolStripEx2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx2.Size = New System.Drawing.Size(308, 118)
        Me.ToolStripEx2.TabIndex = 1
        Me.ToolStripEx2.Text = "นำเข้า/ส่งออก"
        Me.ToolStripEx2.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Enabled = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(66, 110)
        Me.ToolStripButton4.Text = "นำเข้า excel"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(88, 110)
        Me.ToolStripButton1.Text = "นำเข้า database"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 113)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Enabled = False
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(67, 110)
        Me.ToolStripButton5.Text = "ส่งออก excel"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Enabled = False
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(60, 110)
        Me.ToolStripButton6.Text = "ส่งออก pdf"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripEx4
        '
        Me.ToolStripEx4.AutoSize = False
        Me.ToolStripEx4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx4.Image = Nothing
        Me.ToolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMUser, Me.btnSignout, Me.btnClose})
        Me.ToolStripEx4.Location = New System.Drawing.Point(304, 1)
        Me.ToolStripEx4.Name = "ToolStripEx4"
        Me.ToolStripEx4.Office12Mode = False
        Me.ToolStripEx4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx4.Size = New System.Drawing.Size(219, 118)
        Me.ToolStripEx4.TabIndex = 3
        Me.ToolStripEx4.Text = "การเข้าใช้งาน"
        '
        'btnMUser
        '
        Me.btnMUser.Image = CType(resources.GetObject("btnMUser.Image"), System.Drawing.Image)
        Me.btnMUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMUser.Name = "btnMUser"
        Me.btnMUser.Size = New System.Drawing.Size(73, 96)
        Me.btnMUser.Text = "จัดการผู้ใช้งาน"
        Me.btnMUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMUser.ToolTipText = "จัดการผู้ใช้งาน"
        '
        'btnSignout
        '
        Me.btnSignout.Image = CType(resources.GetObject("btnSignout.Image"), System.Drawing.Image)
        Me.btnSignout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSignout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSignout.Name = "btnSignout"
        Me.btnSignout.Size = New System.Drawing.Size(67, 96)
        Me.btnSignout.Text = "ออกจากระบบ"
        Me.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(59, 96)
        Me.btnClose.Text = "ปิดโปรแกรม"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripTabItem3
        '
        Me.ToolStripTabItem3.Name = "ToolStripTabItem3"
        '
        'RibbonControlAdv1.RibbonPanel2
        '
        Me.ToolStripTabItem3.Panel.Controls.Add(Me.ToolStripEx7)
        Me.ToolStripTabItem3.Panel.Name = "RibbonPanel2"
        Me.ToolStripTabItem3.Panel.ScrollPosition = 0
        Me.ToolStripTabItem3.Panel.TabIndex = 4
        Me.ToolStripTabItem3.Panel.Text = "ตั้งค่าระบบ"
        Me.ToolStripTabItem3.Position = 1
        Me.ToolStripTabItem3.Size = New System.Drawing.Size(79, 25)
        Me.ToolStripTabItem3.Tag = "3"
        Me.ToolStripTabItem3.Text = "ตั้งค่าระบบ"
        '
        'ToolStripEx7
        '
        Me.ToolStripEx7.AutoSize = False
        Me.ToolStripEx7.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx7.Image = Nothing
        Me.ToolStripEx7.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx7.Name = "ToolStripEx7"
        Me.ToolStripEx7.Office12Mode = False
        Me.ToolStripEx7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx7.Size = New System.Drawing.Size(100, 118)
        Me.ToolStripEx7.TabIndex = 1
        '
        'ToolStripTabItem4
        '
        Me.ToolStripTabItem4.Name = "ToolStripTabItem4"
        '
        'RibbonControlAdv1.RibbonPanel3
        '
        Me.ToolStripTabItem4.Panel.Controls.Add(Me.ToolStripEx5)
        Me.ToolStripTabItem4.Panel.Name = "RibbonPanel3"
        Me.ToolStripTabItem4.Panel.ScrollPosition = 0
        Me.ToolStripTabItem4.Panel.TabIndex = 5
        Me.ToolStripTabItem4.Panel.Text = "เกี่ยวกับ"
        Me.ToolStripTabItem4.Position = 2
        Me.ToolStripTabItem4.Size = New System.Drawing.Size(69, 25)
        Me.ToolStripTabItem4.Tag = "4"
        Me.ToolStripTabItem4.Text = "เกี่ยวกับ"
        '
        'ToolStripEx5
        '
        Me.ToolStripEx5.AutoSize = False
        Me.ToolStripEx5.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx5.Image = Nothing
        Me.ToolStripEx5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7})
        Me.ToolStripEx5.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx5.Name = "ToolStripEx5"
        Me.ToolStripEx5.Office12Mode = False
        Me.ToolStripEx5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStripEx5.Size = New System.Drawing.Size(100, 118)
        Me.ToolStripEx5.TabIndex = 0
        Me.ToolStripEx5.Text = "เกี่ยวกับ"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(79, 96)
        Me.ToolStripButton7.Text = "เกี่ยวกับโปรแกรม"
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stlMsg})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(914, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(449, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "พัฒนาโดย นายเฉลิมพิสิฐ ศิริชัย [CSAG, Computer System Administrator Group]"
        '
        'stlMsg
        '
        Me.stlMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stlMsg.Name = "stlMsg"
        Me.stlMsg.Size = New System.Drawing.Size(449, 17)
        Me.stlMsg.Spring = True
        Me.stlMsg.Text = "Status"
        Me.stlMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabbedMDIManager
        '
        Me.TabbedMDIManager.AttachedTo = Me
        Me.TabbedMDIManager.CloseButtonBackColor = System.Drawing.Color.White
        Me.TabbedMDIManager.CloseButtonToolTip = ""
        Me.TabbedMDIManager.DropDownButtonToolTip = ""
        Me.TabbedMDIManager.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabbedMDIManager.NeedUpdateHostedForm = False
        Me.TabbedMDIManager.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererMetro)
        Me.TabbedMDIManager.ThemesEnabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 640)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RibbonControlAdv1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(920, 640)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 1)
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
        Me.ToolStripEx4.ResumeLayout(False)
        Me.ToolStripEx4.PerformLayout()
        Me.ToolStripTabItem3.Panel.ResumeLayout(False)
        Me.ToolStripTabItem4.Panel.ResumeLayout(False)
        Me.ToolStripEx5.ResumeLayout(False)
        Me.ToolStripEx5.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Friend WithEvents ToolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripEx1 As ToolStripEx
    Friend WithEvents btnStdList As ToolStripButton
    Friend WithEvents ToolStripEx2 As ToolStripEx
    Friend WithEvents btnSignout As ToolStripButton
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents ToolStripTabItem3 As ToolStripTabItem
    Friend WithEvents ToolStripTabItem4 As ToolStripTabItem
    Friend WithEvents ToolStripButton2 As ToolStripSplitButton
    Friend WithEvents btnOpenDataManagemet As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripEx7 As ToolStripEx
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripEx4 As ToolStripEx
    Friend WithEvents ToolStripEx5 As ToolStripEx
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents stlMsg As ToolStripStatusLabel
    Friend WithEvents btnMUser As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents TabbedMDIManager As TabbedMDIManager
End Class
