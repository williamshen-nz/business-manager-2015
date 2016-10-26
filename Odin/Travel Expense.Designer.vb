<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Travel_Expense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Travel_Expense))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTrackingNumber = New System.Windows.Forms.TextBox()
        Me.txtForeign = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cboExpenseType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkBillClient = New System.Windows.Forms.CheckBox()
        Me.chkReimburse = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboCurrency = New System.Windows.Forms.ComboBox()
        Me.txtExchangeRate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateIncurred = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExpenseType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NZD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Reimbursed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNew = New System.Windows.Forms.Button()
        Me.chkReimbursed = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.lblDataStatus = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnReimburseAll = New System.Windows.Forms.Button()
        Me.lblNZDAmount = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.pntDocument = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(12, 19)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(348, 46)
        Me.lblDescription.TabIndex = 54
        Me.lblDescription.Text = "Travel Expense - New"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(869, 85)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 32)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Tracking Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 32)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Foreign Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(606, 376)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 32)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "NZD Amount"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(782, 423)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 32)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "NZD"
        '
        'txtTrackingNumber
        '
        Me.txtTrackingNumber.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtTrackingNumber.Location = New System.Drawing.Point(23, 138)
        Me.txtTrackingNumber.MaxLength = 10
        Me.txtTrackingNumber.Name = "txtTrackingNumber"
        Me.txtTrackingNumber.Size = New System.Drawing.Size(194, 38)
        Me.txtTrackingNumber.TabIndex = 1
        '
        'txtForeign
        '
        Me.txtForeign.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtForeign.Location = New System.Drawing.Point(23, 421)
        Me.txtForeign.MaxLength = 10
        Me.txtForeign.Name = "txtForeign"
        Me.txtForeign.Size = New System.Drawing.Size(178, 38)
        Me.txtForeign.TabIndex = 9
        Me.txtForeign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.Location = New System.Drawing.Point(0, 546)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(873, 3)
        Me.PictureBox4.TabIndex = 80
        Me.PictureBox4.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(691, 476)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(132, 53)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(550, 476)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 53)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(17, 187)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 32)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Date Incurred"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(23, 225)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDate.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(178, 39)
        Me.dtpDate.TabIndex = 3
        '
        'cboExpenseType
        '
        Me.cboExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpenseType.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.cboExpenseType.FormattingEnabled = True
        Me.cboExpenseType.Items.AddRange(New Object() {"Accommodation", "Airfares", "Courier", "Dry Cleaning", "Entertainment", "Internet", "Meals", "Medical", "Mobile Phones", "Private Transport", "Public Transport", "Taxi", "Other"})
        Me.cboExpenseType.Location = New System.Drawing.Point(244, 225)
        Me.cboExpenseType.Name = "cboExpenseType"
        Me.cboExpenseType.Size = New System.Drawing.Size(262, 39)
        Me.cboExpenseType.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(238, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 32)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Expense Type"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(544, 187)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(200, 32)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "Payment Method"
        '
        'cboPaymentMethod
        '
        Me.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentMethod.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.cboPaymentMethod.FormattingEnabled = True
        Me.cboPaymentMethod.Items.AddRange(New Object() {"Personal", "Company", "Other"})
        Me.cboPaymentMethod.Location = New System.Drawing.Point(550, 225)
        Me.cboPaymentMethod.Name = "cboPaymentMethod"
        Me.cboPaymentMethod.Size = New System.Drawing.Size(262, 39)
        Me.cboPaymentMethod.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtDescription.Location = New System.Drawing.Point(23, 320)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(568, 38)
        Me.txtDescription.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 32)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Item Description"
        '
        'chkBillClient
        '
        Me.chkBillClient.AutoSize = True
        Me.chkBillClient.Location = New System.Drawing.Point(624, 330)
        Me.chkBillClient.Name = "chkBillClient"
        Me.chkBillClient.Size = New System.Drawing.Size(149, 36)
        Me.chkBillClient.TabIndex = 8
        Me.chkBillClient.Text = "Bill Client?"
        Me.chkBillClient.UseVisualStyleBackColor = True
        '
        'chkReimburse
        '
        Me.chkReimburse.AutoSize = True
        Me.chkReimburse.Location = New System.Drawing.Point(624, 284)
        Me.chkReimburse.Name = "chkReimburse"
        Me.chkReimburse.Size = New System.Drawing.Size(161, 36)
        Me.chkReimburse.TabIndex = 7
        Me.chkReimburse.Text = "Reimburse?"
        Me.chkReimburse.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(215, 382)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 32)
        Me.Label18.TabIndex = 110
        '
        'cboCurrency
        '
        Me.cboCurrency.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.cboCurrency.FormattingEnabled = True
        Me.cboCurrency.ItemHeight = 31
        Me.cboCurrency.Items.AddRange(New Object() {"AUD", "CAD", "EUR", "GBP", "HKD", "JPY", "NZD", "RMB", "USD"})
        Me.cboCurrency.Location = New System.Drawing.Point(210, 420)
        Me.cboCurrency.MaxLength = 3
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Size = New System.Drawing.Size(83, 39)
        Me.cboCurrency.TabIndex = 109
        Me.cboCurrency.Text = "RMB"
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.txtExchangeRate.Location = New System.Drawing.Point(358, 420)
        Me.txtExchangeRate.MaxLength = 10
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Size = New System.Drawing.Size(178, 38)
        Me.txtExchangeRate.TabIndex = 11
        Me.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(352, 375)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(170, 32)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = "Exchange Rate"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(21, 468)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(485, 69)
        Me.lblStatus.TabIndex = 113
        Me.lblStatus.Text = "Please enter the Tracking Number."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.DateIncurred, Me.ItemDescription, Me.ExpenseType, Me.NZD, Me.Reimbursed})
        Me.lstView.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstView.FullRowSelect = True
        Me.lstView.GridLines = True
        Me.lstView.Location = New System.Drawing.Point(20, 566)
        Me.lstView.MultiSelect = False
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(831, 286)
        Me.lstView.TabIndex = 114
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 55
        '
        'DateIncurred
        '
        Me.DateIncurred.Text = "Date"
        Me.DateIncurred.Width = 130
        '
        'ItemDescription
        '
        Me.ItemDescription.Text = "Description"
        Me.ItemDescription.Width = 260
        '
        'ExpenseType
        '
        Me.ExpenseType.Text = "Type"
        Me.ExpenseType.Width = 115
        '
        'NZD
        '
        Me.NZD.Text = "NZD"
        Me.NZD.Width = 115
        '
        'Reimbursed
        '
        Me.Reimbursed.Text = "Reimbursed"
        Me.Reimbursed.Width = 130
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(669, 866)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(182, 53)
        Me.btnNew.TabIndex = 20
        Me.btnNew.Text = "New Expense"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'chkReimbursed
        '
        Me.chkReimbursed.AutoSize = True
        Me.chkReimbursed.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.chkReimbursed.ForeColor = System.Drawing.Color.White
        Me.chkReimbursed.Location = New System.Drawing.Point(676, 28)
        Me.chkReimbursed.Name = "chkReimbursed"
        Me.chkReimbursed.Size = New System.Drawing.Size(175, 36)
        Me.chkReimbursed.TabIndex = 13
        Me.chkReimbursed.Text = "Reimbursed?"
        Me.chkReimbursed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkReimbursed.UseVisualStyleBackColor = False
        Me.chkReimbursed.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(691, 476)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(132, 53)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(20, 865)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(163, 53)
        Me.btnView.TabIndex = 18
        Me.btnView.Text = "View or Edit"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(501, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(38, 32)
        Me.lblID.TabIndex = 181
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'btnDelete1
        '
        Me.btnDelete1.Enabled = False
        Me.btnDelete1.Location = New System.Drawing.Point(550, 476)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(126, 53)
        Me.btnDelete1.TabIndex = 17
        Me.btnDelete1.Text = "Delete"
        Me.btnDelete1.UseVisualStyleBackColor = True
        '
        'btnDelete2
        '
        Me.btnDelete2.Location = New System.Drawing.Point(192, 865)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(126, 53)
        Me.btnDelete2.TabIndex = 19
        Me.btnDelete2.Text = " Delete"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.lblDataStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDataStatus.Location = New System.Drawing.Point(342, 871)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(321, 43)
        Me.lblDataStatus.TabIndex = 182
        Me.lblDataStatus.Text = "Record deleted."
        Me.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDataStatus.Visible = False
        '
        'cboName
        '
        Me.cboName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(244, 138)
        Me.cboName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboName.MaxLength = 80
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(568, 39)
        Me.cboName.TabIndex = 183
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(537, 866)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(126, 53)
        Me.btnPrint.TabIndex = 184
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnReimburseAll
        '
        Me.btnReimburseAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnReimburseAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReimburseAll.ForeColor = System.Drawing.Color.Black
        Me.btnReimburseAll.Location = New System.Drawing.Point(331, 866)
        Me.btnReimburseAll.Name = "btnReimburseAll"
        Me.btnReimburseAll.Size = New System.Drawing.Size(194, 52)
        Me.btnReimburseAll.TabIndex = 185
        Me.btnReimburseAll.Text = "All Reimbursed"
        Me.btnReimburseAll.UseVisualStyleBackColor = False
        Me.btnReimburseAll.Visible = False
        '
        'lblNZDAmount
        '
        Me.lblNZDAmount.BackColor = System.Drawing.Color.White
        Me.lblNZDAmount.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!)
        Me.lblNZDAmount.Location = New System.Drawing.Point(612, 420)
        Me.lblNZDAmount.Name = "lblNZDAmount"
        Me.lblNZDAmount.Size = New System.Drawing.Size(164, 36)
        Me.lblNZDAmount.TabIndex = 186
        Me.lblNZDAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(106, 632)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(657, 193)
        Me.DataGridView.TabIndex = 187
        Me.DataGridView.Visible = False
        '
        'pntDocument
        '
        '
        'Travel_Expense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 931)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.lblNZDAmount)
        Me.Controls.Add(Me.btnReimburseAll)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.lblDataStatus)
        Me.Controls.Add(Me.btnDelete2)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.chkReimbursed)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtExchangeRate)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cboCurrency)
        Me.Controls.Add(Me.chkReimburse)
        Me.Controls.Add(Me.chkBillClient)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cboPaymentMethod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboExpenseType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtForeign)
        Me.Controls.Add(Me.txtTrackingNumber)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Travel_Expense"
        Me.ShowInTaskbar = False
        Me.Text = "Travel Expense"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTrackingNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtForeign As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboExpenseType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkBillClient As System.Windows.Forms.CheckBox
    Friend WithEvents chkReimburse As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents txtExchangeRate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateIncurred As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents NZD As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents chkReimbursed As System.Windows.Forms.CheckBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnDelete1 As System.Windows.Forms.Button
    Friend WithEvents btnDelete2 As System.Windows.Forms.Button
    Friend WithEvents lblDataStatus As System.Windows.Forms.Label
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents Reimbursed As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExpenseType As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnReimburseAll As System.Windows.Forms.Button
    Friend WithEvents lblNZDAmount As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pntDocument As System.Drawing.Printing.PrintDocument
End Class
