<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contact))
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rtbMessage = New System.Windows.Forms.RichTextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkSpam = New System.Windows.Forms.CheckBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lblName.Location = New System.Drawing.Point(28, 118)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(105, 42)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.txtName.Location = New System.Drawing.Point(37, 163)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.MaxLength = 80
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(451, 43)
        Me.txtName.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.White
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lblEmail.Location = New System.Drawing.Point(28, 212)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(105, 52)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.txtEmail.Location = New System.Drawing.Point(37, 265)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.MaxLength = 254
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(451, 43)
        Me.txtEmail.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 317)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 52)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Message:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(15, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(488, 588)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'rtbMessage
        '
        Me.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbMessage.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.rtbMessage.Location = New System.Drawing.Point(0, 0)
        Me.rtbMessage.MaxLength = 1000
        Me.rtbMessage.Name = "rtbMessage"
        Me.rtbMessage.Size = New System.Drawing.Size(450, 285)
        Me.rtbMessage.TabIndex = 3
        Me.rtbMessage.Text = ""
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 32.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(3, 7)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(437, 72)
        Me.lblDescription.TabIndex = 15
        Me.lblDescription.Text = "Contact Support"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(517, 97)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'lblCounter
        '
        Me.lblCounter.BackColor = System.Drawing.Color.White
        Me.lblCounter.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.ForeColor = System.Drawing.Color.Black
        Me.lblCounter.Location = New System.Drawing.Point(362, 663)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(127, 28)
        Me.lblCounter.TabIndex = 16
        Me.lblCounter.Text = "0/1000"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(367, 712)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(137, 62)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rtbMessage)
        Me.Panel1.Location = New System.Drawing.Point(37, 370)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 287)
        Me.Panel1.TabIndex = 20
        '
        'chkSpam
        '
        Me.chkSpam.AutoSize = True
        Me.chkSpam.BackColor = System.Drawing.Color.White
        Me.chkSpam.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.chkSpam.Location = New System.Drawing.Point(40, 663)
        Me.chkSpam.Name = "chkSpam"
        Me.chkSpam.Size = New System.Drawing.Size(251, 34)
        Me.chkSpam.TabIndex = 4
        Me.chkSpam.Text = "This Email is not spam."
        Me.chkSpam.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(17, 713)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(345, 58)
        Me.lblStatus.TabIndex = 22
        Me.lblStatus.Text = "The email may take up to 10 seconds to send. Thank you for your patience."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(443, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 782)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.chkSpam)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contact"
        Me.Text = "Contact Support"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rtbMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkSpam As System.Windows.Forms.CheckBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
