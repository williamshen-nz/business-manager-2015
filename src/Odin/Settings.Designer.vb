<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.lblLocationStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBackup = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.FolderBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblLocationDirectory = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblApplicationEmail = New System.Windows.Forms.Label()
        Me.btnApplicationEmail = New System.Windows.Forms.Button()
        Me.txtApplicationEmail = New System.Windows.Forms.TextBox()
        Me.btnVariables = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(2, 12)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(289, 60)
        Me.lblDescription.TabIndex = 13
        Me.lblDescription.Text = "User Settings"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(583, 91)
        Me.PictureBox.TabIndex = 14
        Me.PictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Database Location:"
        '
        'btnLocation
        '
        Me.btnLocation.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnLocation.Location = New System.Drawing.Point(441, 190)
        Me.btnLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(130, 46)
        Me.btnLocation.TabIndex = 25
        Me.btnLocation.Text = "Browse"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFD"
        '
        'lblLocationStatus
        '
        Me.lblLocationStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocationStatus.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblLocationStatus.Location = New System.Drawing.Point(12, 182)
        Me.lblLocationStatus.Name = "lblLocationStatus"
        Me.lblLocationStatus.Size = New System.Drawing.Size(420, 33)
        Me.lblLocationStatus.TabIndex = 27
        Me.lblLocationStatus.Text = "Database Location successfully updated."
        Me.lblLocationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLocationStatus.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 37)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Backup Database:"
        '
        'lblBackup
        '
        Me.lblBackup.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblBackup.ForeColor = System.Drawing.Color.Red
        Me.lblBackup.Location = New System.Drawing.Point(14, 308)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(420, 33)
        Me.lblBackup.TabIndex = 29
        Me.lblBackup.Text = "Last backed up on DD/MM/YYYY."
        Me.lblBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnBackup.Location = New System.Drawing.Point(438, 301)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(130, 49)
        Me.btnBackup.TabIndex = 30
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox2.Location = New System.Drawing.Point(0, 520)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(586, 2)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnClose.Location = New System.Drawing.Point(443, 537)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 45)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnHelp.Location = New System.Drawing.Point(302, 537)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(125, 45)
        Me.btnHelp.TabIndex = 32
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.Location = New System.Drawing.Point(-2, 246)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(586, 2)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'lblLocationDirectory
        '
        Me.lblLocationDirectory.BackColor = System.Drawing.Color.White
        Me.lblLocationDirectory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblLocationDirectory.ForeColor = System.Drawing.Color.Black
        Me.lblLocationDirectory.Location = New System.Drawing.Point(17, 143)
        Me.lblLocationDirectory.Name = "lblLocationDirectory"
        Me.lblLocationDirectory.Size = New System.Drawing.Size(554, 41)
        Me.lblLocationDirectory.TabIndex = 35
        Me.lblLocationDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 37)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Email for Applications:"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox5.Location = New System.Drawing.Point(0, 366)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(586, 2)
        Me.PictureBox5.TabIndex = 37
        Me.PictureBox5.TabStop = False
        '
        'lblApplicationEmail
        '
        Me.lblApplicationEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblApplicationEmail.Location = New System.Drawing.Point(12, 462)
        Me.lblApplicationEmail.Name = "lblApplicationEmail"
        Me.lblApplicationEmail.Size = New System.Drawing.Size(396, 33)
        Me.lblApplicationEmail.TabIndex = 38
        Me.lblApplicationEmail.Text = "Email for which all applications are sent to."
        Me.lblApplicationEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnApplicationEmail
        '
        Me.btnApplicationEmail.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnApplicationEmail.Location = New System.Drawing.Point(438, 462)
        Me.btnApplicationEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnApplicationEmail.Name = "btnApplicationEmail"
        Me.btnApplicationEmail.Size = New System.Drawing.Size(130, 45)
        Me.btnApplicationEmail.TabIndex = 40
        Me.btnApplicationEmail.Text = "Update"
        Me.btnApplicationEmail.UseVisualStyleBackColor = True
        '
        'txtApplicationEmail
        '
        Me.txtApplicationEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtApplicationEmail.Location = New System.Drawing.Point(17, 421)
        Me.txtApplicationEmail.MaxLength = 120
        Me.txtApplicationEmail.Name = "txtApplicationEmail"
        Me.txtApplicationEmail.Size = New System.Drawing.Size(550, 34)
        Me.txtApplicationEmail.TabIndex = 41
        '
        'btnVariables
        '
        Me.btnVariables.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnVariables.Location = New System.Drawing.Point(19, 537)
        Me.btnVariables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(183, 45)
        Me.btnVariables.TabIndex = 42
        Me.btnVariables.Text = "View Variables"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 597)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.txtApplicationEmail)
        Me.Controls.Add(Me.btnApplicationEmail)
        Me.Controls.Add(Me.lblApplicationEmail)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLocationDirectory)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.lblBackup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLocationStatus)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLocation As System.Windows.Forms.Button
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblLocationStatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBackup As System.Windows.Forms.Label
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents FolderBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLocationDirectory As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblApplicationEmail As System.Windows.Forms.Label
    Friend WithEvents btnApplicationEmail As System.Windows.Forms.Button
    Friend WithEvents txtApplicationEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnVariables As System.Windows.Forms.Button
End Class
