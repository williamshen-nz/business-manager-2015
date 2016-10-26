<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Business_Expense___New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Business_Expense___New))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTrackingNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.chkReimbursement = New System.Windows.Forms.CheckBox()
        Me.cboMethod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(224, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 32)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "Vendor"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(14, 517)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(518, 69)
        Me.lblStatus.TabIndex = 108
        Me.lblStatus.Text = "Enter the Tracking Number and all relevant data will 'appear'."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(538, 525)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 53)
        Me.btnClose.TabIndex = 122
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(690, 525)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(132, 53)
        Me.btnSave.TabIndex = 123
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.Location = New System.Drawing.Point(0, 499)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(866, 2)
        Me.PictureBox4.TabIndex = 105
        Me.PictureBox4.TabStop = False
        '
        'txtVendor
        '
        Me.txtVendor.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtVendor.Location = New System.Drawing.Point(230, 243)
        Me.txtVendor.MaxLength = 50
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(379, 38)
        Me.txtVendor.TabIndex = 114
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtTotal.Location = New System.Drawing.Point(295, 437)
        Me.txtTotal.MaxLength = 14
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(177, 38)
        Me.txtTotal.TabIndex = 120
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtUnit.Location = New System.Drawing.Point(23, 437)
        Me.txtUnit.MaxLength = 10
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(177, 38)
        Me.txtUnit.TabIndex = 119
        Me.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtQuantity.Location = New System.Drawing.Point(717, 345)
        Me.txtQuantity.MaxLength = 5
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(105, 38)
        Me.txtQuantity.TabIndex = 118
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtDescription.Location = New System.Drawing.Point(23, 345)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(670, 38)
        Me.txtDescription.TabIndex = 117
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(479, 440)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 32)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "NZD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(206, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 32)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "NZD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(287, 395)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 32)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Total Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 32)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Unit Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 32)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Item Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(711, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 32)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Employee Name"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(12, 18)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(390, 46)
        Me.lblDescription.TabIndex = 85
        Me.lblDescription.Text = "Business Expense - New"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(847, 85)
        Me.PictureBox.TabIndex = 84
        Me.PictureBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 32)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Tracking Number"
        '
        'txtTrackingNumber
        '
        Me.txtTrackingNumber.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtTrackingNumber.Location = New System.Drawing.Point(26, 146)
        Me.txtTrackingNumber.MaxLength = 10
        Me.txtTrackingNumber.Name = "txtTrackingNumber"
        Me.txtTrackingNumber.Size = New System.Drawing.Size(206, 38)
        Me.txtTrackingNumber.TabIndex = 111
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtName.Location = New System.Drawing.Point(263, 146)
        Me.txtName.MaxLength = 80
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(562, 38)
        Me.txtName.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(20, 205)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 32)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Date Purchased"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(23, 243)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDate.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpDate.Size = New System.Drawing.Size(178, 38)
        Me.dtpDate.TabIndex = 113
        '
        'chkReimbursement
        '
        Me.chkReimbursement.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkReimbursement.Location = New System.Drawing.Point(601, 417)
        Me.chkReimbursement.Name = "chkReimbursement"
        Me.chkReimbursement.Size = New System.Drawing.Size(217, 71)
        Me.chkReimbursement.TabIndex = 121
        Me.chkReimbursement.Text = "Reimbursement required?"
        Me.chkReimbursement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkReimbursement.UseVisualStyleBackColor = True
        '
        'cboMethod
        '
        Me.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMethod.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.cboMethod.FormattingEnabled = True
        Me.cboMethod.Items.AddRange(New Object() {"Personal", "Company", "Other"})
        Me.cboMethod.Location = New System.Drawing.Point(640, 242)
        Me.cboMethod.Name = "cboMethod"
        Me.cboMethod.Size = New System.Drawing.Size(185, 39)
        Me.cboMethod.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(634, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 32)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Payment Method"
        '
        'Business_Expense___New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 598)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMethod)
        Me.Controls.Add(Me.chkReimbursement)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtTrackingNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Business_Expense___New"
        Me.ShowInTaskbar = False
        Me.Text = "Business Expense - New"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtVendor As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTrackingNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkReimbursement As System.Windows.Forms.CheckBox
    Friend WithEvents cboMethod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
