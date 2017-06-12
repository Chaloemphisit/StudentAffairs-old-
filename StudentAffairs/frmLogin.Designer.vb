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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMessageError = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.lblCaptionPassword = New System.Windows.Forms.Label()
        Me.lblCaptionUserName = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblMessageError)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnCancle)
        Me.Panel1.Controls.Add(Me.btnSignin)
        Me.Panel1.Controls.Add(Me.lblCaptionPassword)
        Me.Panel1.Controls.Add(Me.lblCaptionUserName)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(547, 98)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 332)
        Me.Panel1.TabIndex = 0
        '
        'lblMessageError
        '
        Me.lblMessageError.AutoSize = True
        Me.lblMessageError.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageError.ForeColor = System.Drawing.Color.Red
        Me.lblMessageError.Location = New System.Drawing.Point(4, 231)
        Me.lblMessageError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessageError.Name = "lblMessageError"
        Me.lblMessageError.Size = New System.Drawing.Size(135, 21)
        Me.lblMessageError.TabIndex = 13
        Me.lblMessageError.Text = "Label Message Error"
        Me.lblMessageError.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(-6, 262)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 1)
        Me.Panel2.TabIndex = 12
        '
        'btnCancle
        '
        Me.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancle.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancle.Location = New System.Drawing.Point(179, 283)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(127, 33)
        Me.btnCancle.TabIndex = 7
        Me.btnCancle.Text = "ยกเลิก"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnSignin
        '
        Me.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSignin.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignin.Location = New System.Drawing.Point(47, 283)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(126, 33)
        Me.btnSignin.TabIndex = 6
        Me.btnSignin.Text = "เข้าสู่ระบบ"
        Me.btnSignin.UseVisualStyleBackColor = True
        '
        'lblCaptionPassword
        '
        Me.lblCaptionPassword.AutoSize = True
        Me.lblCaptionPassword.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionPassword.Location = New System.Drawing.Point(26, 142)
        Me.lblCaptionPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaptionPassword.Name = "lblCaptionPassword"
        Me.lblCaptionPassword.Size = New System.Drawing.Size(66, 28)
        Me.lblCaptionPassword.TabIndex = 6
        Me.lblCaptionPassword.Text = "รหัสผ่าน"
        '
        'lblCaptionUserName
        '
        Me.lblCaptionUserName.AutoSize = True
        Me.lblCaptionUserName.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionUserName.Location = New System.Drawing.Point(26, 69)
        Me.lblCaptionUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaptionUserName.Name = "lblCaptionUserName"
        Me.lblCaptionUserName.Size = New System.Drawing.Size(83, 28)
        Me.lblCaptionUserName.TabIndex = 5
        Me.lblCaptionUserName.Text = "ชื่อผู้ใช้งาน"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(31, 176)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(314, 33)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(31, 103)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(314, 33)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Thin", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เข้าสู่ระบบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Roboto Thin", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ระบบบันทึกพฤติกรรมนักเรียน"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderThickness = 0
        Me.ClientSize = New System.Drawing.Size(903, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกรมบันทึกพฤติกรรมนักเรียน"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCaptionPassword As Label
    Friend WithEvents lblCaptionUserName As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancle As Button
    Friend WithEvents btnSignin As Button
    Friend WithEvents lblMessageError As Label
    Friend WithEvents Label2 As Label
End Class
