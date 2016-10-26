<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Business_Expense___Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Business_Expense___Overview))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.TotalCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TrackingNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.lstViewPending = New System.Windows.Forms.ListView()
        Me.DateIncurred = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lstViewCompleted = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblDataStatus = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblFilterStatus = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.chkFilterName = New System.Windows.Forms.CheckBox()
        Me.chkFilterDate = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkCompleted = New System.Windows.Forms.CheckBox()
        Me.chkPending = New System.Windows.Forms.CheckBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.pntDocument = New System.Drawing.Printing.PrintDocument()
        Me.chkTotal = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnDelete.Location = New System.Drawing.Point(196, 705)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 51)
        Me.btnDelete.TabIndex = 118
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label10.Location = New System.Drawing.Point(17, 659)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(391, 32)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Select a row from the tables above:"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnSearch.Location = New System.Drawing.Point(775, 705)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(152, 51)
        Me.btnSearch.TabIndex = 119
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 32)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Completed Reimbursement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 32)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Pending Reimbursement"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(15, 18)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(465, 46)
        Me.lblDescription.TabIndex = 113
        Me.lblDescription.Text = "Business Expense - Overview"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnEdit.Location = New System.Drawing.Point(23, 705)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(164, 51)
        Me.btnEdit.TabIndex = 111
        Me.btnEdit.Text = "View or Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'TotalCost
        '
        Me.TotalCost.Text = "Total Cost"
        Me.TotalCost.Width = 180
        '
        'Description
        '
        Me.Description.Text = "Item Description"
        Me.Description.Width = 400
        '
        'FullName
        '
        Me.FullName.Text = "Full Name"
        Me.FullName.Width = 200
        '
        'TrackingNumber
        '
        Me.TrackingNumber.Text = "Tracking No."
        Me.TrackingNumber.Width = 150
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1179, 86)
        Me.PictureBox.TabIndex = 112
        Me.PictureBox.TabStop = False
        '
        'lstViewPending
        '
        Me.lstViewPending.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TrackingNumber, Me.FullName, Me.DateIncurred, Me.Description, Me.TotalCost})
        Me.lstViewPending.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstViewPending.FullRowSelect = True
        Me.lstViewPending.GridLines = True
        Me.lstViewPending.Location = New System.Drawing.Point(23, 146)
        Me.lstViewPending.MultiSelect = False
        Me.lstViewPending.Name = "lstViewPending"
        Me.lstViewPending.Size = New System.Drawing.Size(1122, 182)
        Me.lstViewPending.TabIndex = 110
        Me.lstViewPending.UseCompatibleStateImageBehavior = False
        Me.lstViewPending.View = System.Windows.Forms.View.Details
        '
        'DateIncurred
        '
        Me.DateIncurred.Text = "Date Incurred"
        Me.DateIncurred.Width = 160
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnNew.Location = New System.Drawing.Point(938, 705)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(207, 51)
        Me.btnNew.TabIndex = 109
        Me.btnNew.Text = "New Expense"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lstViewCompleted
        '
        Me.lstViewCompleted.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lstViewCompleted.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstViewCompleted.FullRowSelect = True
        Me.lstViewCompleted.GridLines = True
        Me.lstViewCompleted.Location = New System.Drawing.Point(23, 393)
        Me.lstViewCompleted.MultiSelect = False
        Me.lstViewCompleted.Name = "lstViewCompleted"
        Me.lstViewCompleted.Size = New System.Drawing.Size(1122, 252)
        Me.lstViewCompleted.TabIndex = 121
        Me.lstViewCompleted.UseCompatibleStateImageBehavior = False
        Me.lstViewCompleted.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tracking No."
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Full Name"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date Incurred"
        Me.ColumnHeader8.Width = 160
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Item Description"
        Me.ColumnHeader9.Width = 400
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Total Cost"
        Me.ColumnHeader10.Width = 180
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnPrint.Location = New System.Drawing.Point(958, 952)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(152, 51)
        Me.btnPrint.TabIndex = 123
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.lblDataStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDataStatus.Location = New System.Drawing.Point(355, 710)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(414, 43)
        Me.lblDataStatus.TabIndex = 124
        Me.lblDataStatus.Text = "Record successfully deleted."
        Me.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDataStatus.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.Location = New System.Drawing.Point(-5, 780)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1197, 4)
        Me.PictureBox4.TabIndex = 125
        Me.PictureBox4.TabStop = False
        '
        'lblFilterStatus
        '
        Me.lblFilterStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblFilterStatus.ForeColor = System.Drawing.Color.Red
        Me.lblFilterStatus.Location = New System.Drawing.Point(381, 959)
        Me.lblFilterStatus.Name = "lblFilterStatus"
        Me.lblFilterStatus.Size = New System.Drawing.Size(411, 40)
        Me.lblFilterStatus.TabIndex = 156
        Me.lblFilterStatus.Text = "No data found."
        Me.lblFilterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFilterStatus.Visible = False
        '
        'cboName
        '
        Me.cboName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(277, 900)
        Me.cboName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(430, 39)
        Me.cboName.TabIndex = 150
        '
        'chkFilterName
        '
        Me.chkFilterName.AutoSize = True
        Me.chkFilterName.Location = New System.Drawing.Point(23, 900)
        Me.chkFilterName.Name = "chkFilterName"
        Me.chkFilterName.Size = New System.Drawing.Size(213, 36)
        Me.chkFilterName.TabIndex = 149
        Me.chkFilterName.Text = "Employee Name"
        Me.chkFilterName.UseVisualStyleBackColor = True
        '
        'chkFilterDate
        '
        Me.chkFilterDate.AutoSize = True
        Me.chkFilterDate.Location = New System.Drawing.Point(23, 841)
        Me.chkFilterDate.Name = "chkFilterDate"
        Me.chkFilterDate.Size = New System.Drawing.Size(233, 36)
        Me.chkFilterDate.TabIndex = 146
        Me.chkFilterDate.Text = "Expenses Between"
        Me.chkFilterDate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(80, 843)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 32)
        Me.Label4.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(463, 843)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 32)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "and"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.dtpDateTo.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(529, 841)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDateTo.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(178, 39)
        Me.dtpDateTo.TabIndex = 148
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateFrom.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(277, 841)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDateFrom.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(178, 39)
        Me.dtpDateFrom.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 793)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 32)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Print by:"
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Location = New System.Drawing.Point(756, 841)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(331, 36)
        Me.chkCompleted.TabIndex = 157
        Me.chkCompleted.Text = "Completed Reimbursement"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'chkPending
        '
        Me.chkPending.AutoSize = True
        Me.chkPending.Location = New System.Drawing.Point(756, 900)
        Me.chkPending.Name = "chkPending"
        Me.chkPending.Size = New System.Drawing.Size(301, 36)
        Me.chkPending.TabIndex = 158
        Me.chkPending.Text = "Pending Reimbursement"
        Me.chkPending.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(23, 958)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(170, 36)
        Me.chkAll.TabIndex = 159
        Me.chkAll.Text = "Print all data"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(23, 146)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(1122, 166)
        Me.DataGridView.TabIndex = 160
        Me.DataGridView.Visible = False
        '
        'pntDocument
        '
        '
        'chkTotal
        '
        Me.chkTotal.AutoSize = True
        Me.chkTotal.Location = New System.Drawing.Point(809, 962)
        Me.chkTotal.Name = "chkTotal"
        Me.chkTotal.Size = New System.Drawing.Size(143, 36)
        Me.chkTotal.TabIndex = 161
        Me.chkTotal.Text = "Find Total"
        Me.chkTotal.UseVisualStyleBackColor = True
        '
        'Business_Expense___Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 1026)
        Me.Controls.Add(Me.chkTotal)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.chkPending)
        Me.Controls.Add(Me.chkCompleted)
        Me.Controls.Add(Me.lblFilterStatus)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.chkFilterName)
        Me.Controls.Add(Me.chkFilterDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblDataStatus)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lstViewCompleted)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.lstViewPending)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.DataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Business_Expense___Overview"
        Me.Text = "Business Expense - Overview"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents TotalCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents FullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents TrackingNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lstViewPending As System.Windows.Forms.ListView
    Friend WithEvents DateIncurred As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lstViewCompleted As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblDataStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFilterStatus As System.Windows.Forms.Label
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents chkFilterName As System.Windows.Forms.CheckBox
    Friend WithEvents chkFilterDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkCompleted As System.Windows.Forms.CheckBox
    Friend WithEvents chkPending As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pntDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents chkTotal As System.Windows.Forms.CheckBox
End Class
