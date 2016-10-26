<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wages___Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wages___Overview))
        Me.lstView = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateFrom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.datePaid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NetPay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkFilterDate = New System.Windows.Forms.CheckBox()
        Me.chkFilterName = New System.Windows.Forms.CheckBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnFilterClear = New System.Windows.Forms.Button()
        Me.lblFilterStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblDataStatus = New System.Windows.Forms.Label()
        Me.rdbAll = New System.Windows.Forms.RadioButton()
        Me.rdbFiltered = New System.Windows.Forms.RadioButton()
        Me.pntDialog = New System.Windows.Forms.PrintDialog()
        Me.pntPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.pntDocument = New System.Drawing.Printing.PrintDocument()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.dateFrom, Me.dateTo, Me.FullName, Me.datePaid, Me.NetPay})
        Me.lstView.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstView.FullRowSelect = True
        Me.lstView.GridLines = True
        Me.lstView.Location = New System.Drawing.Point(20, 106)
        Me.lstView.MultiSelect = False
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(986, 449)
        Me.lstView.TabIndex = 98
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 50
        '
        'dateFrom
        '
        Me.dateFrom.Text = "From"
        Me.dateFrom.Width = 150
        '
        'dateTo
        '
        Me.dateTo.Text = "To"
        Me.dateTo.Width = 150
        '
        'FullName
        '
        Me.FullName.Text = "Employee Name"
        Me.FullName.Width = 300
        '
        'datePaid
        '
        Me.datePaid.Text = "Date Paid"
        Me.datePaid.Width = 150
        '
        'NetPay
        '
        Me.NetPay.Text = "Net Pay"
        Me.NetPay.Width = 150
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnDelete.Location = New System.Drawing.Point(189, 615)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 51)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label10.Location = New System.Drawing.Point(10, 569)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(391, 32)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Select a row from the tables above:"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnEdit.Location = New System.Drawing.Point(16, 615)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(164, 51)
        Me.btnEdit.TabIndex = 1
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
        Me.PictureBox.Size = New System.Drawing.Size(1028, 86)
        Me.PictureBox.TabIndex = 123
        Me.PictureBox.TabStop = False
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnNew.Location = New System.Drawing.Point(812, 615)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(194, 51)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New Record"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(300, 46)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Wages - Overview"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(-4, 688)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1039, 4)
        Me.PictureBox4.TabIndex = 134
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 710)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Filter by:"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateFrom.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(274, 758)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDateFrom.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(178, 39)
        Me.dtpDateFrom.TabIndex = 6
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.dtpDateTo.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(526, 758)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDateTo.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(178, 39)
        Me.dtpDateTo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(460, 760)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 32)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "and"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(77, 760)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 32)
        Me.Label4.TabIndex = 139
        '
        'chkFilterDate
        '
        Me.chkFilterDate.AutoSize = True
        Me.chkFilterDate.Location = New System.Drawing.Point(20, 758)
        Me.chkFilterDate.Name = "chkFilterDate"
        Me.chkFilterDate.Size = New System.Drawing.Size(239, 36)
        Me.chkFilterDate.TabIndex = 5
        Me.chkFilterDate.Text = "Payments Between"
        Me.chkFilterDate.UseVisualStyleBackColor = True
        '
        'chkFilterName
        '
        Me.chkFilterName.AutoSize = True
        Me.chkFilterName.Location = New System.Drawing.Point(20, 816)
        Me.chkFilterName.Name = "chkFilterName"
        Me.chkFilterName.Size = New System.Drawing.Size(213, 36)
        Me.chkFilterName.TabIndex = 8
        Me.chkFilterName.Text = "Employee Name"
        Me.chkFilterName.UseVisualStyleBackColor = True
        '
        'cboName
        '
        Me.cboName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(274, 813)
        Me.cboName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboName.MaxLength = 80
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(430, 39)
        Me.cboName.TabIndex = 9
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnFilter.Location = New System.Drawing.Point(549, 872)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(155, 47)
        Me.btnFilter.TabIndex = 10
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnFilterClear
        '
        Me.btnFilterClear.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnFilterClear.Location = New System.Drawing.Point(378, 872)
        Me.btnFilterClear.Name = "btnFilterClear"
        Me.btnFilterClear.Size = New System.Drawing.Size(155, 47)
        Me.btnFilterClear.TabIndex = 11
        Me.btnFilterClear.Text = "Clear Filter"
        Me.btnFilterClear.UseVisualStyleBackColor = True
        '
        'lblFilterStatus
        '
        Me.lblFilterStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblFilterStatus.ForeColor = System.Drawing.Color.Red
        Me.lblFilterStatus.Location = New System.Drawing.Point(10, 861)
        Me.lblFilterStatus.Name = "lblFilterStatus"
        Me.lblFilterStatus.Size = New System.Drawing.Size(352, 69)
        Me.lblFilterStatus.TabIndex = 145
        Me.lblFilterStatus.Text = "No data found."
        Me.lblFilterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFilterStatus.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(754, 710)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 32)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Printing Options:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(728, 689)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(2, 255)
        Me.PictureBox2.TabIndex = 147
        Me.PictureBox2.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnPrint.Location = New System.Drawing.Point(760, 872)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(139, 47)
        Me.btnPrint.TabIndex = 150
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lblDataStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDataStatus.Location = New System.Drawing.Point(358, 606)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(438, 69)
        Me.lblDataStatus.TabIndex = 151
        Me.lblDataStatus.Text = "Record successfully updated."
        Me.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDataStatus.Visible = False
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Location = New System.Drawing.Point(760, 758)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(172, 36)
        Me.rdbAll.TabIndex = 152
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "Print all Data"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'rdbFiltered
        '
        Me.rdbFiltered.AutoSize = True
        Me.rdbFiltered.Location = New System.Drawing.Point(760, 816)
        Me.rdbFiltered.Name = "rdbFiltered"
        Me.rdbFiltered.Size = New System.Drawing.Size(228, 36)
        Me.rdbFiltered.TabIndex = 153
        Me.rdbFiltered.TabStop = True
        Me.rdbFiltered.Text = "Print Filtered Data"
        Me.rdbFiltered.UseVisualStyleBackColor = True
        '
        'pntDialog
        '
        Me.pntDialog.UseEXDialog = True
        '
        'pntPreview
        '
        Me.pntPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.pntPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.pntPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.pntPreview.Enabled = True
        Me.pntPreview.Icon = CType(resources.GetObject("pntPreview.Icon"), System.Drawing.Icon)
        Me.pntPreview.Name = "pntPreview"
        Me.pntPreview.Visible = False
        '
        'pntDocument
        '
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(83, 175)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(849, 345)
        Me.DataGridView.TabIndex = 154
        Me.DataGridView.Visible = False
        '
        'Wages___Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 939)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.rdbFiltered)
        Me.Controls.Add(Me.rdbAll)
        Me.Controls.Add(Me.lblDataStatus)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFilterStatus)
        Me.Controls.Add(Me.btnFilterClear)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.chkFilterName)
        Me.Controls.Add(Me.chkFilterDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lstView)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Wages___Overview"
        Me.Text = "Wages - Overview"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateFrom As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateTo As System.Windows.Forms.ColumnHeader
    Friend WithEvents FullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents datePaid As System.Windows.Forms.ColumnHeader
    Friend WithEvents NetPay As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkFilterDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkFilterName As System.Windows.Forms.CheckBox
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnFilterClear As System.Windows.Forms.Button
    Friend WithEvents lblFilterStatus As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblDataStatus As System.Windows.Forms.Label
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFiltered As System.Windows.Forms.RadioButton
    Friend WithEvents pntDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents pntPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pntDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
End Class
