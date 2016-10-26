<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSupport = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(128, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "v 1.0.0"
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.BackColor = System.Drawing.Color.White
        Me.lblSupport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSupport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline)
        Me.lblSupport.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblSupport.Location = New System.Drawing.Point(128, 98)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(278, 28)
        Me.lblSupport.TabIndex = 11
        Me.lblSupport.Text = "Queries and Technical Support"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClose.Location = New System.Drawing.Point(445, 98)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 38)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.White
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblCopyright.Location = New System.Drawing.Point(334, 24)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(229, 37)
        Me.lblCopyright.TabIndex = 8
        Me.lblCopyright.Text = "Business Manager"
        '
        'lblSoftware
        '
        Me.lblSoftware.AutoSize = True
        Me.lblSoftware.BackColor = System.Drawing.Color.White
        Me.lblSoftware.Font = New System.Drawing.Font("Segoe UI Semibold", 23.0!, System.Drawing.FontStyle.Bold)
        Me.lblSoftware.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblSoftware.Location = New System.Drawing.Point(115, 13)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(226, 52)
        Me.lblSoftware.TabIndex = 7
        Me.lblSoftware.Text = "OdinHealth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(389, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Build Date: 01/07/15"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(577, 142)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.White
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(25, 23)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(80, 80)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 9
        Me.picLogo.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 161)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSupport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblSoftware)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSupport As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblSoftware As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
End Class
