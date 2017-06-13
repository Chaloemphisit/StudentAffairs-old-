<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
    Inherits Syncfusion.Windows.Forms.MetroForm

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
        Dim CaptionImage1 As Syncfusion.Windows.Forms.CaptionImage = New Syncfusion.Windows.Forms.CaptionImage()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.lblCaptionPassword = New System.Windows.Forms.Label()
        Me.lblCaptionUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckbShowPwd = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.ckbGeneratePwd = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.btnRegister = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnCancle = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.txtFirstName = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtTRole = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtUsername = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtPassword = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtLastName = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.cbUserRole = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.txtTeacherID = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.ckbShowPwd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckbGeneratePwd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUserRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTeacherID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaptionPassword
        '
        Me.lblCaptionPassword.AutoSize = True
        Me.lblCaptionPassword.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionPassword.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionPassword.Location = New System.Drawing.Point(299, 154)
        Me.lblCaptionPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaptionPassword.Name = "lblCaptionPassword"
        Me.lblCaptionPassword.Size = New System.Drawing.Size(66, 28)
        Me.lblCaptionPassword.TabIndex = 22
        Me.lblCaptionPassword.Text = "รหัสผ่าน"
        '
        'lblCaptionUserName
        '
        Me.lblCaptionUserName.AutoSize = True
        Me.lblCaptionUserName.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionUserName.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionUserName.Location = New System.Drawing.Point(28, 154)
        Me.lblCaptionUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaptionUserName.Name = "lblCaptionUserName"
        Me.lblCaptionUserName.Size = New System.Drawing.Size(83, 28)
        Me.lblCaptionUserName.TabIndex = 21
        Me.lblCaptionUserName.Text = "ชื่อผู้ใช้งาน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(28, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 28)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(301, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 28)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "นามสกุล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(303, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 28)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ตำแหน่ง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(28, 264)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 28)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "สิทธิการใช้งาน"
        '
        'ckbShowPwd
        '
        Me.ckbShowPwd.BeforeTouchSize = New System.Drawing.Size(107, 47)
        Me.ckbShowPwd.Font = New System.Drawing.Font("Roboto Condensed", 9.5!)
        Me.ckbShowPwd.ForeColor = System.Drawing.Color.DimGray
        Me.ckbShowPwd.Location = New System.Drawing.Point(317, 211)
        Me.ckbShowPwd.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ckbShowPwd.Name = "ckbShowPwd"
        Me.ckbShowPwd.Size = New System.Drawing.Size(107, 47)
        Me.ckbShowPwd.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.ckbShowPwd.TabIndex = 7
        Me.ckbShowPwd.Text = "แสดงรหัสผ่าน"
        Me.ckbShowPwd.ThemesEnabled = False
        '
        'ckbGeneratePwd
        '
        Me.ckbGeneratePwd.BeforeTouchSize = New System.Drawing.Size(107, 47)
        Me.ckbGeneratePwd.Font = New System.Drawing.Font("Roboto Condensed", 9.5!)
        Me.ckbGeneratePwd.ForeColor = System.Drawing.Color.DimGray
        Me.ckbGeneratePwd.Location = New System.Drawing.Point(439, 211)
        Me.ckbGeneratePwd.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ckbGeneratePwd.Name = "ckbGeneratePwd"
        Me.ckbGeneratePwd.Size = New System.Drawing.Size(107, 47)
        Me.ckbGeneratePwd.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.ckbGeneratePwd.TabIndex = 8
        Me.ckbGeneratePwd.Text = "สร้างอัตโนมัติ"
        Me.ckbGeneratePwd.ThemesEnabled = False
        '
        'btnRegister
        '
        Me.btnRegister.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnRegister.BeforeTouchSize = New System.Drawing.Size(120, 31)
        Me.btnRegister.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.IsBackStageButton = False
        Me.btnRegister.Location = New System.Drawing.Point(304, 295)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(120, 31)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "ลงทะเบียน"
        '
        'btnCancle
        '
        Me.btnCancle.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnCancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCancle.BeforeTouchSize = New System.Drawing.Size(120, 31)
        Me.btnCancle.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancle.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!)
        Me.btnCancle.ForeColor = System.Drawing.Color.White
        Me.btnCancle.IsBackStageButton = False
        Me.btnCancle.Location = New System.Drawing.Point(435, 295)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(120, 31)
        Me.btnCancle.TabIndex = 11
        Me.btnCancle.Text = "ยกเลิก"
        '
        'txtFirstName
        '
        Me.txtFirstName.BeforeTouchSize = New System.Drawing.Size(249, 30)
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.DimGray
        Me.txtFirstName.Location = New System.Drawing.Point(33, 119)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFirstName.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(249, 30)
        Me.txtFirstName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtFirstName.TabIndex = 3
        Me.txtFirstName.Text = "txtFirstName"
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFirstName.WordWrap = False
        '
        'txtTRole
        '
        Me.txtTRole.BeforeTouchSize = New System.Drawing.Size(249, 30)
        Me.txtTRole.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTRole.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTRole.ForeColor = System.Drawing.Color.DimGray
        Me.txtTRole.Location = New System.Drawing.Point(306, 51)
        Me.txtTRole.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTRole.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTRole.Name = "txtTRole"
        Me.txtTRole.Size = New System.Drawing.Size(249, 30)
        Me.txtTRole.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTRole.TabIndex = 2
        Me.txtTRole.Text = "txtTRole"
        Me.txtTRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTRole.WordWrap = False
        '
        'txtUsername
        '
        Me.txtUsername.BeforeTouchSize = New System.Drawing.Size(249, 30)
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(31, 188)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsername.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(249, 30)
        Me.txtUsername.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtUsername.TabIndex = 5
        Me.txtUsername.Text = "txtUsername"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsername.WordWrap = False
        '
        'txtPassword
        '
        Me.txtPassword.BeforeTouchSize = New System.Drawing.Size(249, 30)
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(304, 188)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(249, 30)
        Me.txtPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.Text = "txtPassword"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.WordWrap = False
        '
        'txtLastName
        '
        Me.txtLastName.BeforeTouchSize = New System.Drawing.Size(249, 30)
        Me.txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastName.Location = New System.Drawing.Point(306, 119)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLastName.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(249, 30)
        Me.txtLastName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.Text = "txtLastName"
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLastName.WordWrap = False
        '
        'cbUserRole
        '
        Me.cbUserRole.BackColor = System.Drawing.Color.White
        Me.cbUserRole.BeforeTouchSize = New System.Drawing.Size(245, 31)
        Me.cbUserRole.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cbUserRole.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUserRole.ForeColor = System.Drawing.Color.DimGray
        Me.cbUserRole.Location = New System.Drawing.Point(33, 295)
        Me.cbUserRole.MetroBorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cbUserRole.Name = "cbUserRole"
        Me.cbUserRole.Size = New System.Drawing.Size(245, 31)
        Me.cbUserRole.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cbUserRole.TabIndex = 9
        Me.cbUserRole.Text = "กรุณาเลือก"
        Me.cbUserRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTeacherID
        '
        Me.txtTeacherID.BackColor = System.Drawing.Color.White
        Me.txtTeacherID.BeforeTouchSize = New System.Drawing.Size(249, 30)
        Me.txtTeacherID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTeacherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherID.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherID.ForeColor = System.Drawing.Color.DimGray
        Me.txtTeacherID.Location = New System.Drawing.Point(33, 51)
        Me.txtTeacherID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTeacherID.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Size = New System.Drawing.Size(249, 30)
        Me.txtTeacherID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTeacherID.TabIndex = 1
        Me.txtTeacherID.Text = "txtTeacherID"
        Me.txtTeacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTeacherID.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(28, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 28)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "รหัสประจำตัว"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-2, 255)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 1)
        Me.Panel2.TabIndex = 54
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionBarHeight = 72
        Me.CaptionButtonColor = System.Drawing.Color.Black
        Me.CaptionFont = New System.Drawing.Font("Roboto Condensed Light", 23.0!)
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = CType(resources.GetObject("CaptionImage1.Image"), System.Drawing.Image)
        CaptionImage1.Location = New System.Drawing.Point(15, 15)
        CaptionImage1.Name = "CaptionImage1"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(587, 354)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtTeacherID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbUserRole)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtTRole)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCaptionPassword)
        Me.Controls.Add(Me.lblCaptionUserName)
        Me.Controls.Add(Me.ckbShowPwd)
        Me.Controls.Add(Me.ckbGeneratePwd)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.IconAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.Transparent
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ลงทะเบียน"
        CType(Me.ckbShowPwd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckbGeneratePwd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbUserRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTeacherID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaptionPassword As Label
    Friend WithEvents lblCaptionUserName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents ckbShowPwd As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents ckbGeneratePwd As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents btnRegister As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnCancle As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents txtFirstName As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtTRole As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtUsername As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtPassword As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtLastName As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents cbUserRole As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents txtTeacherID As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
End Class
