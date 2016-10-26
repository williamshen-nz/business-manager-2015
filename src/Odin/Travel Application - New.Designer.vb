<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Travel_Application___New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Travel_Application___New))
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.lblTracking = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDestinations = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtDomestic = New System.Windows.Forms.TextBox()
        Me.txtInternational = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtAccomodation = New System.Windows.Forms.TextBox()
        Me.rtbReason = New System.Windows.Forms.RichTextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1140, 85)
        Me.PictureBox.TabIndex = 21
        Me.PictureBox.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(13, 17)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(398, 46)
        Me.lblDescription.TabIndex = 22
        Me.lblDescription.Text = "Travel Application - New"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(875, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 32)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tracking Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(422, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 32)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Email Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(990, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 32)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Duration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(402, 32)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Please estimate the following costs:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 32)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Reason for Trip"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(382, 32)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Destinations (Countries and Cities)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(548, 533)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(233, 32)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Accomodation Costs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 589)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(285, 32)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "International Travel Costs"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 530)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 32)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Domestic Travel Costs"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(649, 589)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 32)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Total Costs"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(465, 533)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 32)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "NZD"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(466, 592)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 32)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "NZD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(939, 533)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 32)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "NZD"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(939, 589)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 32)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "NZD"
        '
        'cboName
        '
        Me.cboName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(20, 142)
        Me.cboName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboName.MaxLength = 80
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(376, 39)
        Me.cboName.TabIndex = 38
        '
        'lblTracking
        '
        Me.lblTracking.BackColor = System.Drawing.Color.White
        Me.lblTracking.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.lblTracking.Location = New System.Drawing.Point(883, 142)
        Me.lblTracking.Name = "lblTracking"
        Me.lblTracking.Size = New System.Drawing.Size(215, 36)
        Me.lblTracking.TabIndex = 39
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtEmail.Location = New System.Drawing.Point(428, 142)
        Me.txtEmail.MaxLength = 255
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(433, 38)
        Me.txtEmail.TabIndex = 40
        '
        'txtDestinations
        '
        Me.txtDestinations.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtDestinations.Location = New System.Drawing.Point(20, 245)
        Me.txtDestinations.MaxLength = 80
        Me.txtDestinations.Name = "txtDestinations"
        Me.txtDestinations.Size = New System.Drawing.Size(940, 38)
        Me.txtDestinations.TabIndex = 41
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtDuration.Location = New System.Drawing.Point(996, 245)
        Me.txtDuration.MaxLength = 4
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(79, 38)
        Me.txtDuration.TabIndex = 42
        '
        'txtDomestic
        '
        Me.txtDomestic.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtDomestic.Location = New System.Drawing.Point(313, 530)
        Me.txtDomestic.MaxLength = 10
        Me.txtDomestic.Name = "txtDomestic"
        Me.txtDomestic.Size = New System.Drawing.Size(146, 38)
        Me.txtDomestic.TabIndex = 43
        Me.txtDomestic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInternational
        '
        Me.txtInternational.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtInternational.Location = New System.Drawing.Point(313, 589)
        Me.txtInternational.MaxLength = 10
        Me.txtInternational.Name = "txtInternational"
        Me.txtInternational.Size = New System.Drawing.Size(146, 38)
        Me.txtInternational.TabIndex = 44
        Me.txtInternational.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtTotal.Location = New System.Drawing.Point(787, 586)
        Me.txtTotal.MaxLength = 11
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(146, 38)
        Me.txtTotal.TabIndex = 46
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAccomodation
        '
        Me.txtAccomodation.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtAccomodation.Location = New System.Drawing.Point(787, 530)
        Me.txtAccomodation.MaxLength = 10
        Me.txtAccomodation.Name = "txtAccomodation"
        Me.txtAccomodation.Size = New System.Drawing.Size(146, 38)
        Me.txtAccomodation.TabIndex = 45
        Me.txtAccomodation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rtbReason
        '
        Me.rtbReason.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbReason.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.rtbReason.Location = New System.Drawing.Point(20, 345)
        Me.rtbReason.MaxLength = 255
        Me.rtbReason.Name = "rtbReason"
        Me.rtbReason.Size = New System.Drawing.Size(1081, 106)
        Me.rtbReason.TabIndex = 47
        Me.rtbReason.Text = ""
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.Location = New System.Drawing.Point(0, 651)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1140, 3)
        Me.PictureBox4.TabIndex = 48
        Me.PictureBox4.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(969, 680)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(132, 53)
        Me.btnSubmit.TabIndex = 49
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(817, 680)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 53)
        Me.btnClose.TabIndex = 50
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(22, 672)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(772, 69)
        Me.lblStatus.TabIndex = 51
        Me.lblStatus.Text = "Your application will be reviewed before it is approved. An email will be sent to" & _
    " you once it has been approved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(1080, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 28)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Days"
        '
        'Travel_Application___New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 754)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.rtbReason)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtAccomodation)
        Me.Controls.Add(Me.txtInternational)
        Me.Controls.Add(Me.txtDomestic)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtDestinations)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblTracking)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Travel_Application___New"
        Me.ShowInTaskbar = False
        Me.Text = "Travel Application - New"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents lblTracking As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinations As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtDomestic As System.Windows.Forms.TextBox
    Friend WithEvents txtInternational As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAccomodation As System.Windows.Forms.TextBox
    Friend WithEvents rtbReason As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
