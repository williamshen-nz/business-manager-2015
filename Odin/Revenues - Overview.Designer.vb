<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Revenues___Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Revenues___Overview))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.PONumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InvoiceNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InvoiceDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblDataStatus = New System.Windows.Forms.Label()
        Me.chkFilterDate = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnFilterClear = New System.Windows.Forms.Button()
        Me.lblFilterStatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnDelete.Location = New System.Drawing.Point(203, 704)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 51)
        Me.btnDelete.TabIndex = 131
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label10.Location = New System.Drawing.Point(24, 658)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(391, 32)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Select a row from the tables above:"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnSearch.Location = New System.Drawing.Point(627, 704)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(133, 51)
        Me.btnSearch.TabIndex = 132
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 32)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Revenue Records"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(13, 19)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(343, 46)
        Me.lblDescription.TabIndex = 127
        Me.lblDescription.Text = "Revenues - Overview"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnEdit.Location = New System.Drawing.Point(30, 704)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(164, 51)
        Me.btnEdit.TabIndex = 125
        Me.btnEdit.Text = "View or Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1004, 86)
        Me.PictureBox.TabIndex = 126
        Me.PictureBox.TabStop = False
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PONumber, Me.InvoiceNumber, Me.InvoiceDate, Me.Customer, Me.Total})
        Me.lstView.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstView.FullRowSelect = True
        Me.lstView.GridLines = True
        Me.lstView.Location = New System.Drawing.Point(21, 147)
        Me.lstView.MultiSelect = False
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(957, 498)
        Me.lstView.TabIndex = 124
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'PONumber
        '
        Me.PONumber.Text = "PO Number"
        Me.PONumber.Width = 150
        '
        'InvoiceNumber
        '
        Me.InvoiceNumber.Text = "Invoice No."
        Me.InvoiceNumber.Width = 150
        '
        'InvoiceDate
        '
        Me.InvoiceDate.Text = "Date"
        Me.InvoiceDate.Width = 130
        '
        'Customer
        '
        Me.Customer.Text = "Customer"
        Me.Customer.Width = 350
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.Width = 150
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnNew.Location = New System.Drawing.Point(771, 704)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(207, 51)
        Me.btnNew.TabIndex = 133
        Me.btnNew.Text = "New Revenue"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.lblDataStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDataStatus.Location = New System.Drawing.Point(343, 699)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(278, 62)
        Me.lblDataStatus.TabIndex = 136
        Me.lblDataStatus.Text = "Record deleted."
        Me.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDataStatus.Visible = False
        '
        'chkFilterDate
        '
        Me.chkFilterDate.AutoSize = True
        Me.chkFilterDate.Location = New System.Drawing.Point(24, 840)
        Me.chkFilterDate.Name = "chkFilterDate"
        Me.chkFilterDate.Size = New System.Drawing.Size(239, 36)
        Me.chkFilterDate.TabIndex = 139
        Me.chkFilterDate.Text = "Payments Between"
        Me.chkFilterDate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(450, 844)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 32)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "and"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.dtpDateTo.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(513, 840)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDateTo.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(175, 39)
        Me.dtpDateTo.TabIndex = 141
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateFrom.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(271, 840)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDateFrom.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(171, 39)
        Me.dtpDateFrom.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 796)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Filter by:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(0, 773)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1039, 4)
        Me.PictureBox4.TabIndex = 142
        Me.PictureBox4.TabStop = False
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnFilter.Location = New System.Drawing.Point(707, 834)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(141, 51)
        Me.btnFilter.TabIndex = 145
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnFilterClear
        '
        Me.btnFilterClear.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnFilterClear.Location = New System.Drawing.Point(854, 834)
        Me.btnFilterClear.Name = "btnFilterClear"
        Me.btnFilterClear.Size = New System.Drawing.Size(124, 51)
        Me.btnFilterClear.TabIndex = 146
        Me.btnFilterClear.Text = "Clear"
        Me.btnFilterClear.UseVisualStyleBackColor = True
        '
        'lblFilterStatus
        '
        Me.lblFilterStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblFilterStatus.ForeColor = System.Drawing.Color.Red
        Me.lblFilterStatus.Location = New System.Drawing.Point(633, 894)
        Me.lblFilterStatus.Name = "lblFilterStatus"
        Me.lblFilterStatus.Size = New System.Drawing.Size(345, 39)
        Me.lblFilterStatus.TabIndex = 147
        Me.lblFilterStatus.Text = "No data found."
        Me.lblFilterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFilterStatus.Visible = False
        '
        'Revenues___Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 942)
        Me.Controls.Add(Me.lblFilterStatus)
        Me.Controls.Add(Me.btnFilterClear)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.chkFilterDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblDataStatus)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.btnNew)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Revenues___Overview"
        Me.Text = "Revenues - Overview"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents PONumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents InvoiceNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents InvoiceDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblDataStatus As System.Windows.Forms.Label
    Friend WithEvents chkFilterDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnFilterClear As System.Windows.Forms.Button
    Friend WithEvents lblFilterStatus As System.Windows.Forms.Label
End Class
