<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Travel_Expense___Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Travel_Expense___Overview))
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.TrackingNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Period = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AmountNZD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Reimbursed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDataStatus = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.pntDocument = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(821, 578)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(175, 51)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "New Expense"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(676, 578)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(135, 51)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(21, 578)
        Me.btnView.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(163, 51)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View or Edit"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(194, 578)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(140, 51)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TrackingNumber, Me.FullName, Me.Period, Me.AmountNZD, Me.Reimbursed})
        Me.lstView.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstView.FullRowSelect = True
        Me.lstView.GridLines = True
        Me.lstView.Location = New System.Drawing.Point(21, 103)
        Me.lstView.MultiSelect = False
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(975, 462)
        Me.lstView.TabIndex = 98
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'TrackingNumber
        '
        Me.TrackingNumber.Text = "Tracking No."
        Me.TrackingNumber.Width = 160
        '
        'FullName
        '
        Me.FullName.Text = "Name"
        Me.FullName.Width = 225
        '
        'Period
        '
        Me.Period.Text = "Period"
        Me.Period.Width = 260
        '
        'AmountNZD
        '
        Me.AmountNZD.Text = "Amount (NZD)"
        Me.AmountNZD.Width = 170
        '
        'Reimbursed
        '
        Me.Reimbursed.Text = "Reimbursed"
        Me.Reimbursed.Width = 130
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.lblDataStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDataStatus.Location = New System.Drawing.Point(333, 583)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(200, 43)
        Me.lblDataStatus.TabIndex = 99
        Me.lblDataStatus.Text = "Records deleted."
        Me.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDataStatus.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(13, 18)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(423, 46)
        Me.lblDescription.TabIndex = 101
        Me.lblDescription.Text = "Travel Expense - Overview"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1015, 85)
        Me.PictureBox.TabIndex = 100
        Me.PictureBox.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(541, 578)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 51)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(63, 172)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(891, 358)
        Me.DataGridView.TabIndex = 103
        Me.DataGridView.Visible = False
        '
        'pntDocument
        '
        '
        'Travel_Expense___Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 648)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblDataStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Travel_Expense___Overview"
        Me.Text = "Travel Expense - Overview"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents TrackingNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents FullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Period As System.Windows.Forms.ColumnHeader
    Friend WithEvents AmountNZD As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDataStatus As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Reimbursed As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pntDocument As System.Drawing.Printing.PrintDocument
End Class
