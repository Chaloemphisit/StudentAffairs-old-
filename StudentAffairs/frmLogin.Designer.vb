<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    'Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblCaptionPassword = New System.Windows.Forms.Label()
        Me.lblCaptionUserName = New System.Windows.Forms.Label()
        Me.btnSignin = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnCancle = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtUsername = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaptionPassword
        '
        Me.lblCaptionPassword.AutoSize = True
        Me.lblCaptionPassword.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionPassword.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionPassword.Location = New System.Drawing.Point(7, 118)
        Me.lblCaptionPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaptionPassword.Name = "lblCaptionPassword"
        Me.lblCaptionPassword.Size = New System.Drawing.Size(66, 28)
        Me.lblCaptionPassword.TabIndex = 18
        Me.lblCaptionPassword.Text = "รหัสผ่าน"
        '
        'lblCaptionUserName
        '
        Me.lblCaptionUserName.AutoSize = True
        Me.lblCaptionUserName.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionUserName.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionUserName.Location = New System.Drawing.Point(7, 35)
        Me.lblCaptionUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaptionUserName.Name = "lblCaptionUserName"
        Me.lblCaptionUserName.Size = New System.Drawing.Size(83, 28)
        Me.lblCaptionUserName.TabIndex = 16
        Me.lblCaptionUserName.Text = "ชื่อผู้ใช้งาน"
        '
        'btnSignin
        '
        Me.btnSignin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSignin.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnSignin.BeforeTouchSize = New System.Drawing.Size(101, 33)
        Me.btnSignin.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignin.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!)
        Me.btnSignin.ForeColor = System.Drawing.Color.White
        Me.btnSignin.IsBackStageButton = False
        Me.btnSignin.Location = New System.Drawing.Point(118, 256)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(101, 33)
        Me.btnSignin.TabIndex = 22
        Me.btnSignin.Text = "เข้าสู่ระบบ"
        '
        'btnCancle
        '
        Me.btnCancle.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnCancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCancle.BeforeTouchSize = New System.Drawing.Size(101, 33)
        Me.btnCancle.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancle.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!)
        Me.btnCancle.ForeColor = System.Drawing.Color.White
        Me.btnCancle.IsBackStageButton = False
        Me.btnCancle.Location = New System.Drawing.Point(225, 256)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(101, 33)
        Me.btnCancle.TabIndex = 23
        Me.btnCancle.Text = "ยกเลิก"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-35, 226)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 1)
        Me.Panel2.TabIndex = 20
        '
        'TextBoxExt1
        '
        Me.TextBoxExt1.BeforeTouchSize = New System.Drawing.Size(311, 30)
        Me.TextBoxExt1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxExt1.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxExt1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxExt1.Location = New System.Drawing.Point(14, 151)
        Me.TextBoxExt1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt1.Name = "TextBoxExt1"
        Me.TextBoxExt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxExt1.Size = New System.Drawing.Size(311, 30)
        Me.TextBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt1.TabIndex = 25
        Me.TextBoxExt1.Text = "TextBoxExt1"
        Me.TextBoxExt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxExt1.WordWrap = False
        '
        'txtUsername
        '
        Me.txtUsername.BeforeTouchSize = New System.Drawing.Size(311, 30)
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Roboto Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(14, 68)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsername.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(311, 30)
        Me.txtUsername.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtUsername.TabIndex = 24
        Me.txtUsername.Text = "txtUsername"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsername.WordWrap = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionBarHeight = 72
        Me.CaptionFont = New System.Drawing.Font("Roboto Condensed Light", 23.0!)
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = CType(resources.GetObject("CaptionImage1.Image"), System.Drawing.Image)
        CaptionImage1.Location = New System.Drawing.Point(15, 15)
        CaptionImage1.Name = "CaptionImage"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(339, 311)
        Me.Controls.Add(Me.TextBoxExt1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblCaptionPassword)
        Me.Controls.Add(Me.lblCaptionUserName)
        Me.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Right
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.Transparent
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เข้าสู่ระบบ"
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaptionPassword As Label
    Friend WithEvents lblCaptionUserName As Label
    Private WithEvents btnSignin As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnCancle As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents Panel2 As Panel
    Protected WithEvents txtUsername As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Protected WithEvents TextBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
