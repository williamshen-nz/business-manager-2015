<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Investment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Investment))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvestor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAddStatus = New System.Windows.Forms.Label()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Investor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InvestmentDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InjectionAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblDataStatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(9, 17)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(192, 46)
        Me.lblDescription.TabIndex = 53
        Me.lblDescription.Text = "Investment"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(703, 86)
        Me.PictureBox.TabIndex = 52
        Me.PictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(13, 787)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 32)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(19, 825)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDate.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(178, 38)
        Me.dtpDate.TabIndex = 2
        '
        'txtInvestor
        '
        Me.txtInvestor.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtInvestor.Location = New System.Drawing.Point(19, 734)
        Me.txtInvestor.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtInvestor.MaxLength = 50
        Me.txtInvestor.Name = "txtInvestor"
        Me.txtInvestor.Size = New System.Drawing.Size(647, 38)
        Me.txtInvestor.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(13, 696)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 32)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Investor"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtAmount.Location = New System.Drawing.Point(223, 825)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(149, 38)
        Me.txtAmount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(217, 787)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 32)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Amount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(380, 825)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 32)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "NZD"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnAdd.Location = New System.Drawing.Point(493, 815)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(173, 48)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAddStatus
        '
        Me.lblAddStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblAddStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblAddStatus.Location = New System.Drawing.Point(13, 875)
        Me.lblAddStatus.Name = "lblAddStatus"
        Me.lblAddStatus.Size = New System.Drawing.Size(662, 43)
        Me.lblAddStatus.TabIndex = 94
        Me.lblAddStatus.Text = "Enter all relevant data into the controls and press ""Add""."
        Me.lblAddStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Investor, Me.InvestmentDate, Me.InjectionAmount})
        Me.lstView.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstView.FullRowSelect = True
        Me.lstView.GridLines = True
        Me.lstView.Location = New System.Drawing.Point(17, 111)
        Me.lstView.MultiSelect = False
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(658, 496)
        Me.lstView.TabIndex = 97
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 50
        '
        'Investor
        '
        Me.Investor.Text = "Investor"
        Me.Investor.Width = 310
        '
        'InvestmentDate
        '
        Me.InvestmentDate.Text = "Date"
        Me.InvestmentDate.Width = 150
        '
        'InjectionAmount
        '
        Me.InjectionAmount.Text = "Amount"
        Me.InjectionAmount.Width = 120
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.Location = New System.Drawing.Point(-9, 680)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(710, 4)
        Me.PictureBox4.TabIndex = 54
        Me.PictureBox4.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnEdit.Location = New System.Drawing.Point(19, 618)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(134, 48)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnDelete.Location = New System.Drawing.Point(541, 618)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 48)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.lblDataStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDataStatus.Location = New System.Drawing.Point(159, 621)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(376, 43)
        Me.lblDataStatus.TabIndex = 98
        Me.lblDataStatus.Text = "Record deleted."
        Me.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDataStatus.Visible = False
        '
        'Investment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 926)
        Me.Controls.Add(Me.lblDataStatus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblAddStatus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtInvestor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Investment"
        Me.Text = "Investment"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvestor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblAddStatus As System.Windows.Forms.Label
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Investor As System.Windows.Forms.ColumnHeader
    Friend WithEvents InvestmentDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents InjectionAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblDataStatus As System.Windows.Forms.Label
End Class
