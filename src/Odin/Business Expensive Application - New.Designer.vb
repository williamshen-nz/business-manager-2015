<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Business_Expensive_Application___New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Business_Expensive_Application___New))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.rtbReason = New System.Windows.Forms.RichTextBox()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTracking = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(15, 590)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(772, 69)
        Me.lblStatus.TabIndex = 82
        Me.lblStatus.Text = "Your application will be reviewed before it is approved. An email will be sent to" & _
    " you once it has been approved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(810, 598)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 53)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(962, 598)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(132, 53)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.Location = New System.Drawing.Point(-7, 569)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1140, 3)
        Me.PictureBox4.TabIndex = 79
        Me.PictureBox4.TabStop = False
        '
        'rtbReason
        '
        Me.rtbReason.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbReason.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.rtbReason.Location = New System.Drawing.Point(20, 433)
        Me.rtbReason.MaxLength = 255
        Me.rtbReason.Name = "rtbReason"
        Me.rtbReason.Size = New System.Drawing.Size(1081, 106)
        Me.rtbReason.TabIndex = 9
        Me.rtbReason.Text = ""
        '
        'txtVendor
        '
        Me.txtVendor.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtVendor.Location = New System.Drawing.Point(660, 338)
        Me.txtVendor.MaxLength = 50
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(383, 38)
        Me.txtVendor.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtTotal.Location = New System.Drawing.Point(341, 338)
        Me.txtTotal.MaxLength = 14
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(177, 38)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtUnit.Location = New System.Drawing.Point(21, 338)
        Me.txtUnit.MaxLength = 10
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(177, 38)
        Me.txtUnit.TabIndex = 6
        Me.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtQuantity.Location = New System.Drawing.Point(995, 251)
        Me.txtQuantity.MaxLength = 5
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(105, 38)
        Me.txtQuantity.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtDescription.Location = New System.Drawing.Point(19, 251)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(940, 38)
        Me.txtDescription.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtEmail.Location = New System.Drawing.Point(427, 148)
        Me.txtEmail.MaxLength = 255
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(433, 38)
        Me.txtEmail.TabIndex = 2
        '
        'lblTracking
        '
        Me.lblTracking.BackColor = System.Drawing.Color.White
        Me.lblTracking.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.lblTracking.Location = New System.Drawing.Point(882, 148)
        Me.lblTracking.Name = "lblTracking"
        Me.lblTracking.Size = New System.Drawing.Size(215, 36)
        Me.lblTracking.TabIndex = 3
        '
        'cboName
        '
        Me.cboName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(19, 148)
        Me.cboName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboName.MaxLength = 80
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(376, 39)
        Me.cboName.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(525, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 32)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "NZD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(204, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 32)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "NZD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(333, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 32)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Total Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 32)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Unit Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 32)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Item Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 32)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Reason for Purchase"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(989, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 32)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 32)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(874, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 32)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Tracking Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Employee Name"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(12, 21)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(575, 46)
        Me.lblDescription.TabIndex = 53
        Me.lblDescription.Text = "Business Expense Application - New"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1129, 85)
        Me.PictureBox.TabIndex = 52
        Me.PictureBox.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(654, 296)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 32)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Vendor"
        '
        'Business_Expensive_Application___New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 670)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.rtbReason)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblTracking)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Business_Expensive_Application___New"
        Me.ShowInTaskbar = False
        Me.Text = "Business Expense Application - New"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents rtbReason As System.Windows.Forms.RichTextBox
    Friend WithEvents txtVendor As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblTracking As System.Windows.Forms.Label
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
End Class
