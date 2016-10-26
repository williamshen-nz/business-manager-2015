<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Business_Expense_Application___Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Business_Expense_Application___Overview))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.TotalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TrackingNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.lstViewPending = New System.Windows.Forms.ListView()
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lstViewApproved = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDataStatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnDelete.Location = New System.Drawing.Point(192, 843)
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
        Me.Label10.Location = New System.Drawing.Point(13, 797)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(391, 32)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Select a row from the tables above:"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnSearch.Location = New System.Drawing.Point(712, 843)
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
        Me.Label1.Location = New System.Drawing.Point(13, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 32)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Past Applications (Approved)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 32)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Pending Applications (Unapproved)"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(11, 19)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(665, 46)
        Me.lblDescription.TabIndex = 113
        Me.lblDescription.Text = "Business Expense Applications - Overview"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnEdit.Location = New System.Drawing.Point(19, 843)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(164, 51)
        Me.btnEdit.TabIndex = 111
        Me.btnEdit.Text = "View or Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'TotalPrice
        '
        Me.TotalPrice.Text = "Total Price"
        Me.TotalPrice.Width = 175
        '
        'Description
        '
        Me.Description.Text = "Description"
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
        Me.PictureBox.Size = New System.Drawing.Size(1104, 86)
        Me.PictureBox.TabIndex = 112
        Me.PictureBox.TabStop = False
        '
        'lstViewPending
        '
        Me.lstViewPending.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TrackingNumber, Me.FullName, Me.Description, Me.Quantity, Me.TotalPrice})
        Me.lstViewPending.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstViewPending.FullRowSelect = True
        Me.lstViewPending.GridLines = True
        Me.lstViewPending.Location = New System.Drawing.Point(19, 147)
        Me.lstViewPending.MultiSelect = False
        Me.lstViewPending.Name = "lstViewPending"
        Me.lstViewPending.Size = New System.Drawing.Size(1063, 218)
        Me.lstViewPending.TabIndex = 110
        Me.lstViewPending.UseCompatibleStateImageBehavior = False
        Me.lstViewPending.View = System.Windows.Forms.View.Details
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 110
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnNew.Location = New System.Drawing.Point(875, 843)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(207, 51)
        Me.btnNew.TabIndex = 109
        Me.btnNew.Text = "New Application"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lstViewApproved
        '
        Me.lstViewApproved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstViewApproved.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstViewApproved.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lstViewApproved.FullRowSelect = True
        Me.lstViewApproved.GridLines = True
        Me.lstViewApproved.Location = New System.Drawing.Point(19, 429)
        Me.lstViewApproved.MultiSelect = False
        Me.lstViewApproved.Name = "lstViewApproved"
        Me.lstViewApproved.Size = New System.Drawing.Size(1063, 360)
        Me.lstViewApproved.TabIndex = 121
        Me.lstViewApproved.UseCompatibleStateImageBehavior = False
        Me.lstViewApproved.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tracking No."
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Full Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 400
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity"
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total Price"
        Me.ColumnHeader5.Width = 175
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.lblDataStatus.ForeColor = System.Drawing.Color.Green
        Me.lblDataStatus.Location = New System.Drawing.Point(346, 837)
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(358, 62)
        Me.lblDataStatus.TabIndex = 126
        Me.lblDataStatus.Text = "Record successfully deleted."
        Me.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDataStatus.Visible = False
        '
        'Business_Expense_Application___Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 908)
        Me.Controls.Add(Me.lblDataStatus)
        Me.Controls.Add(Me.lstViewApproved)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Business_Expense_Application___Overview"
        Me.Text = "Business Expense Application - Overview"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TotalPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents FullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents TrackingNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lstViewPending As System.Windows.Forms.ListView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstViewApproved As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDataStatus As System.Windows.Forms.Label
End Class
