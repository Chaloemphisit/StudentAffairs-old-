<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStdList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStdList))
        Me.grList = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.bgwRetrieveData = New System.ComponentModel.BackgroundWorker()
        Me.bgwSearchData = New System.ComponentModel.BackgroundWorker()
        Me.bgwSetupData = New System.ComponentModel.BackgroundWorker()
        Me.grList.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grList
        '
        Me.grList.Controls.Add(Me.btnRefresh)
        Me.grList.Controls.Add(Me.lblDesc)
        Me.grList.Controls.Add(Me.Label12)
        Me.grList.Controls.Add(Me.lblRecordCount)
        Me.grList.Controls.Add(Me.txtSearch)
        Me.grList.Controls.Add(Me.dgvData)
        Me.grList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grList.Location = New System.Drawing.Point(0, 5)
        Me.grList.Name = "grList"
        Me.grList.Size = New System.Drawing.Size(822, 452)
        Me.grList.TabIndex = 2
        Me.grList.TabStop = False
        Me.grList.Text = " Listing of Persons "
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
        Me.lblDesc.Location = New System.Drawing.Point(626, 25)
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
        Me.dgvData.Size = New System.Drawing.Size(811, 397)
        Me.dgvData.TabIndex = 1
        '
        'bgwRetrieveData
        '
        '
        'frmStdList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 457)
        Me.Controls.Add(Me.grList)
        Me.Name = "frmStdList"
        Me.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ShowInTaskbar = False
        Me.Text = "รายชื่อนักเรียน"
        Me.grList.ResumeLayout(False)
        Me.grList.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grList As GroupBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents bgwRetrieveData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSearchData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSetupData As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Button1 As Button
End Class
