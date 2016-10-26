<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Investment___Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Investment___Edit))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvestor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(156, 269)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(528, 43)
        Me.lblStatus.TabIndex = 103
        Me.lblStatus.Text = "Update all relevant data and press ""Update""."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(507, 203)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(168, 49)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label13.Location = New System.Drawing.Point(409, 213)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 32)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "NZD"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtAmount.Location = New System.Drawing.Point(226, 213)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(175, 39)
        Me.txtAmount.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(220, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 32)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 175)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 32)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(22, 213)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDate.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(178, 39)
        Me.dtpDate.TabIndex = 3
        '
        'txtInvestor
        '
        Me.txtInvestor.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtInvestor.Location = New System.Drawing.Point(117, 123)
        Me.txtInvestor.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtInvestor.MaxLength = 50
        Me.txtInvestor.Name = "txtInvestor"
        Me.txtInvestor.Size = New System.Drawing.Size(558, 39)
        Me.txtInvestor.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(111, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 32)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Investor"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(14, 14)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(283, 46)
        Me.lblDescription.TabIndex = 105
        Me.lblDescription.Text = "Investment - Edit"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(696, 76)
        Me.PictureBox.TabIndex = 104
        Me.PictureBox.TabStop = False
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtID.Location = New System.Drawing.Point(22, 123)
        Me.txtID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtID.MaxLength = 50
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(79, 39)
        Me.txtID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(16, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 32)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "ID"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnClose.Location = New System.Drawing.Point(22, 269)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 45)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Investment___Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 332)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtInvestor)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Investment___Edit"
        Me.ShowInTaskbar = False
        Me.Text = "Investment - Edit"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvestor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
