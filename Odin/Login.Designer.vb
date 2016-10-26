<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblOdin = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Feedback = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownHelp = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ForgotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 127)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 166)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(512, 67)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.txtUsername.Location = New System.Drawing.Point(45, 322)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.MaxLength = 70
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(429, 47)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.txtPassword.Location = New System.Drawing.Point(45, 450)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(427, 47)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(17, 547)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(142, 62)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 22.0!)
        Me.lblUsername.Location = New System.Drawing.Point(37, 268)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(194, 50)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 22.0!)
        Me.lblPassword.Location = New System.Drawing.Point(37, 397)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(186, 50)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(17, 253)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(482, 272)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblStatus.Location = New System.Drawing.Point(182, 537)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(317, 75)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOdin
        '
        Me.lblOdin.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblOdin.Font = New System.Drawing.Font("Segoe UI Semibold", 53.0!, System.Drawing.FontStyle.Bold)
        Me.lblOdin.ForeColor = System.Drawing.Color.White
        Me.lblOdin.Location = New System.Drawing.Point(2, 38)
        Me.lblOdin.Name = "lblOdin"
        Me.lblOdin.Size = New System.Drawing.Size(265, 107)
        Me.lblOdin.TabIndex = 10
        Me.lblOdin.Text = "Odin"
        '
        'lblHealth
        '
        Me.lblHealth.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblHealth.Font = New System.Drawing.Font("Segoe UI Light", 52.0!)
        Me.lblHealth.ForeColor = System.Drawing.Color.White
        Me.lblHealth.Location = New System.Drawing.Point(218, 38)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHealth.Size = New System.Drawing.Size(292, 107)
        Me.lblHealth.TabIndex = 11
        Me.lblHealth.Text = "Health"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Light", 25.0!)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(23, 167)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(340, 57)
        Me.lblDescription.TabIndex = 12
        Me.lblDescription.Text = "Business Manager"
        '
        'Feedback
        '
        Me.Feedback.Interval = 1000
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 24)
        Me.ToolStripMenuItem1.Text = "Account Manager"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(195, 24)
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(72, 42)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownFile, Me.ToolStripDropDownHelp})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(512, 39)
        Me.ToolStrip.TabIndex = 13
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripDropDownFile
        '
        Me.ToolStripDropDownFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountManagerToolStripMenuItem, Me.ToolStripSeparator1, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownFile.Image = CType(resources.GetObject("ToolStripDropDownFile.Image"), System.Drawing.Image)
        Me.ToolStripDropDownFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownFile.Name = "ToolStripDropDownFile"
        Me.ToolStripDropDownFile.ShowDropDownArrow = False
        Me.ToolStripDropDownFile.Size = New System.Drawing.Size(52, 36)
        Me.ToolStripDropDownFile.Text = "File"
        Me.ToolStripDropDownFile.ToolTipText = "File"
        '
        'AccountManagerToolStripMenuItem
        '
        Me.AccountManagerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
        Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(256, 34)
        Me.AccountManagerToolStripMenuItem.Text = "Account Manager"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(253, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(256, 34)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(253, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(256, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripDropDownHelp
        '
        Me.ToolStripDropDownHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForgotToolStripMenuItem, Me.ContactToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.ToolStripDropDownHelp.Image = CType(resources.GetObject("ToolStripDropDownHelp.Image"), System.Drawing.Image)
        Me.ToolStripDropDownHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownHelp.Name = "ToolStripDropDownHelp"
        Me.ToolStripDropDownHelp.ShowDropDownArrow = False
        Me.ToolStripDropDownHelp.Size = New System.Drawing.Size(67, 36)
        Me.ToolStripDropDownHelp.Text = "Help"
        Me.ToolStripDropDownHelp.ToolTipText = "Help"
        '
        'ForgotToolStripMenuItem
        '
        Me.ForgotToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ForgotToolStripMenuItem.Name = "ForgotToolStripMenuItem"
        Me.ForgotToolStripMenuItem.Size = New System.Drawing.Size(382, 34)
        Me.ForgotToolStripMenuItem.Text = "Forgot Username or Password?"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(382, 34)
        Me.ContactToolStripMenuItem.Text = "Contact Support"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(379, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(382, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 625)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.lblOdin)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblOdin As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Feedback As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownFile As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AccountManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownHelp As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ForgotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
