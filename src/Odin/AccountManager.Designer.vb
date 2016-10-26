<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountManager))
        Me.chkDelete = New System.Windows.Forms.CheckBox()
        Me.cboDelete = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPasswordUpdate = New System.Windows.Forms.TextBox()
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.btnViewClear = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cboUsernameUpdate = New System.Windows.Forms.ComboBox()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.grpDelete = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.txtEnable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblNewUsername = New System.Windows.Forms.Label()
        Me.txtPasswordAdd = New System.Windows.Forms.TextBox()
        Me.txtUsernameAdd = New System.Windows.Forms.TextBox()
        Me.grpChange = New System.Windows.Forms.GroupBox()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.chkAdminUpdate = New System.Windows.Forms.CheckBox()
        Me.txtNameUpdate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.lblAddConfirm = New System.Windows.Forms.Label()
        Me.chkAdminAdd = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNameAdd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpView.SuspendLayout()
        Me.grpDelete.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChange.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkDelete
        '
        Me.chkDelete.AutoSize = True
        Me.chkDelete.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.chkDelete.Location = New System.Drawing.Point(225, 101)
        Me.chkDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.Size = New System.Drawing.Size(119, 36)
        Me.chkDelete.TabIndex = 6
        Me.chkDelete.Text = "Confirm"
        Me.chkDelete.UseVisualStyleBackColor = True
        '
        'cboDelete
        '
        Me.cboDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDelete.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cboDelete.FormattingEnabled = True
        Me.cboDelete.Location = New System.Drawing.Point(140, 46)
        Me.cboDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDelete.Name = "cboDelete"
        Me.cboDelete.Size = New System.Drawing.Size(344, 39)
        Me.cboDelete.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(852, 735)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 49)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.Enabled = False
        Me.btnLock.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnLock.Location = New System.Drawing.Point(663, 735)
        Me.btnLock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(180, 50)
        Me.btnLock.TabIndex = 24
        Me.btnLock.Text = "Lock Controls"
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(360, 96)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 43)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtPasswordUpdate
        '
        Me.txtPasswordUpdate.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtPasswordUpdate.Location = New System.Drawing.Point(143, 104)
        Me.txtPasswordUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPasswordUpdate.MaxLength = 50
        Me.txtPasswordUpdate.Name = "txtPasswordUpdate"
        Me.txtPasswordUpdate.Size = New System.Drawing.Size(301, 39)
        Me.txtPasswordUpdate.TabIndex = 5
        '
        'grpView
        '
        Me.grpView.Controls.Add(Me.lstView)
        Me.grpView.Controls.Add(Me.btnViewClear)
        Me.grpView.Controls.Add(Me.btnView)
        Me.grpView.Enabled = False
        Me.grpView.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.grpView.Location = New System.Drawing.Point(494, 306)
        Me.grpView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpView.Name = "grpView"
        Me.grpView.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpView.Size = New System.Drawing.Size(499, 416)
        Me.grpView.TabIndex = 23
        Me.grpView.TabStop = False
        Me.grpView.Text = "View Existing Accounts"
        '
        'lstView
        '
        Me.lstView.Enabled = False
        Me.lstView.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.lstView.Location = New System.Drawing.Point(14, 54)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(475, 300)
        Me.lstView.TabIndex = 15
        Me.lstView.UseCompatibleStateImageBehavior = False
        '
        'btnViewClear
        '
        Me.btnViewClear.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.btnViewClear.Location = New System.Drawing.Point(229, 364)
        Me.btnViewClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewClear.Name = "btnViewClear"
        Me.btnViewClear.Size = New System.Drawing.Size(109, 42)
        Me.btnViewClear.TabIndex = 14
        Me.btnViewClear.Text = "Clear"
        Me.btnViewClear.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.btnView.Location = New System.Drawing.Point(345, 364)
        Me.btnView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(144, 42)
        Me.btnView.TabIndex = 13
        Me.btnView.Text = "View Accounts"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'cboUsernameUpdate
        '
        Me.cboUsernameUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsernameUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboUsernameUpdate.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cboUsernameUpdate.FormattingEnabled = True
        Me.cboUsernameUpdate.Location = New System.Drawing.Point(146, 55)
        Me.cboUsernameUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboUsernameUpdate.Name = "cboUsernameUpdate"
        Me.cboUsernameUpdate.Size = New System.Drawing.Size(296, 39)
        Me.cboUsernameUpdate.TabIndex = 1
        '
        'lblDelete
        '
        Me.lblDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDelete.ForeColor = System.Drawing.Color.Red
        Me.lblDelete.Location = New System.Drawing.Point(207, 142)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(277, 32)
        Me.lblDelete.TabIndex = 8
        Me.lblDelete.Text = "Please confirm your choice."
        Me.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDelete.Visible = False
        '
        'grpDelete
        '
        Me.grpDelete.Controls.Add(Me.Label3)
        Me.grpDelete.Controls.Add(Me.btnDelete)
        Me.grpDelete.Controls.Add(Me.chkDelete)
        Me.grpDelete.Controls.Add(Me.cboDelete)
        Me.grpDelete.Controls.Add(Me.lblDelete)
        Me.grpDelete.Enabled = False
        Me.grpDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.grpDelete.Location = New System.Drawing.Point(499, 119)
        Me.grpDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDelete.Name = "grpDelete"
        Me.grpDelete.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDelete.Size = New System.Drawing.Size(494, 183)
        Me.grpDelete.TabIndex = 21
        Me.grpDelete.TabStop = False
        Me.grpDelete.Text = "Delete Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(11, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!)
        Me.lblAdmin.ForeColor = System.Drawing.Color.Lime
        Me.lblAdmin.Location = New System.Drawing.Point(664, 58)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(189, 30)
        Me.lblAdmin.TabIndex = 19
        Me.lblAdmin.Text = "Correct Password."
        Me.lblAdmin.Visible = False
        '
        'txtEnable
        '
        Me.txtEnable.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txtEnable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnable.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.txtEnable.ForeColor = System.Drawing.Color.White
        Me.txtEnable.Location = New System.Drawing.Point(16, 55)
        Me.txtEnable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEnable.MaxLength = 25
        Me.txtEnable.Name = "txtEnable"
        Me.txtEnable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEnable.Size = New System.Drawing.Size(501, 38)
        Me.txtEnable.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(824, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Please enter the Admin password to enable the Account Manager:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1005, 114)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewPassword.Location = New System.Drawing.Point(16, 96)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(115, 32)
        Me.lblNewPassword.TabIndex = 3
        Me.lblNewPassword.Text = "Password"
        Me.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNewUsername
        '
        Me.lblNewUsername.AutoSize = True
        Me.lblNewUsername.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewUsername.Location = New System.Drawing.Point(9, 46)
        Me.lblNewUsername.Name = "lblNewUsername"
        Me.lblNewUsername.Size = New System.Drawing.Size(125, 32)
        Me.lblNewUsername.TabIndex = 2
        Me.lblNewUsername.Text = "Username"
        Me.lblNewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPasswordAdd
        '
        Me.txtPasswordAdd.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtPasswordAdd.Location = New System.Drawing.Point(142, 92)
        Me.txtPasswordAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPasswordAdd.MaxLength = 50
        Me.txtPasswordAdd.Name = "txtPasswordAdd"
        Me.txtPasswordAdd.Size = New System.Drawing.Size(308, 39)
        Me.txtPasswordAdd.TabIndex = 1
        '
        'txtUsernameAdd
        '
        Me.txtUsernameAdd.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtUsernameAdd.Location = New System.Drawing.Point(142, 42)
        Me.txtUsernameAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsernameAdd.MaxLength = 40
        Me.txtUsernameAdd.Name = "txtUsernameAdd"
        Me.txtUsernameAdd.Size = New System.Drawing.Size(308, 39)
        Me.txtUsernameAdd.TabIndex = 0
        '
        'grpChange
        '
        Me.grpChange.Controls.Add(Me.lblUpdate)
        Me.grpChange.Controls.Add(Me.btnUpdate)
        Me.grpChange.Controls.Add(Me.chkAdminUpdate)
        Me.grpChange.Controls.Add(Me.txtNameUpdate)
        Me.grpChange.Controls.Add(Me.Label6)
        Me.grpChange.Controls.Add(Me.Label7)
        Me.grpChange.Controls.Add(Me.Label8)
        Me.grpChange.Controls.Add(Me.txtPasswordUpdate)
        Me.grpChange.Controls.Add(Me.cboUsernameUpdate)
        Me.grpChange.Enabled = False
        Me.grpChange.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.grpChange.Location = New System.Drawing.Point(18, 419)
        Me.grpChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpChange.Name = "grpChange"
        Me.grpChange.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpChange.Size = New System.Drawing.Size(462, 303)
        Me.grpChange.TabIndex = 22
        Me.grpChange.TabStop = False
        Me.grpChange.Text = "Update Account"
        '
        'lblUpdate
        '
        Me.lblUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblUpdate.ForeColor = System.Drawing.Color.Red
        Me.lblUpdate.Location = New System.Drawing.Point(96, 251)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(348, 30)
        Me.lblUpdate.TabIndex = 31
        Me.lblUpdate.Text = "Please confirm the details."
        Me.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUpdate.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(318, 198)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(124, 48)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'chkAdminUpdate
        '
        Me.chkAdminUpdate.AutoSize = True
        Me.chkAdminUpdate.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.chkAdminUpdate.Location = New System.Drawing.Point(193, 205)
        Me.chkAdminUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAdminUpdate.Name = "chkAdminUpdate"
        Me.chkAdminUpdate.Size = New System.Drawing.Size(115, 36)
        Me.chkAdminUpdate.TabIndex = 7
        Me.chkAdminUpdate.Text = "Admin?"
        Me.chkAdminUpdate.UseVisualStyleBackColor = True
        '
        'txtNameUpdate
        '
        Me.txtNameUpdate.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtNameUpdate.Location = New System.Drawing.Point(142, 153)
        Me.txtNameUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNameUpdate.MaxLength = 80
        Me.txtNameUpdate.Name = "txtNameUpdate"
        Me.txtNameUpdate.Size = New System.Drawing.Size(301, 39)
        Me.txtNameUpdate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(14, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 32)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Full Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(22, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 32)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(15, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 32)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Username"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnable.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnEnable.ForeColor = System.Drawing.Color.White
        Me.btnEnable.Location = New System.Drawing.Point(535, 54)
        Me.btnEnable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(121, 39)
        Me.btnEnable.TabIndex = 18
        Me.btnEnable.Text = "Enter"
        Me.btnEnable.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.btnAddAccount)
        Me.grpNew.Controls.Add(Me.lblAddConfirm)
        Me.grpNew.Controls.Add(Me.chkAdminAdd)
        Me.grpNew.Controls.Add(Me.Label5)
        Me.grpNew.Controls.Add(Me.txtNameAdd)
        Me.grpNew.Controls.Add(Me.lblNewPassword)
        Me.grpNew.Controls.Add(Me.lblNewUsername)
        Me.grpNew.Controls.Add(Me.txtPasswordAdd)
        Me.grpNew.Controls.Add(Me.txtUsernameAdd)
        Me.grpNew.Enabled = False
        Me.grpNew.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNew.Location = New System.Drawing.Point(18, 119)
        Me.grpNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNew.Size = New System.Drawing.Size(462, 277)
        Me.grpNew.TabIndex = 15
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "Add New Account"
        '
        'btnAddAccount
        '
        Me.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddAccount.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnAddAccount.Location = New System.Drawing.Point(360, 196)
        Me.btnAddAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(93, 43)
        Me.btnAddAccount.TabIndex = 4
        Me.btnAddAccount.Text = "Add"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'lblAddConfirm
        '
        Me.lblAddConfirm.AutoSize = True
        Me.lblAddConfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblAddConfirm.ForeColor = System.Drawing.Color.Red
        Me.lblAddConfirm.Location = New System.Drawing.Point(214, 241)
        Me.lblAddConfirm.Name = "lblAddConfirm"
        Me.lblAddConfirm.Size = New System.Drawing.Size(237, 28)
        Me.lblAddConfirm.TabIndex = 11
        Me.lblAddConfirm.Text = "Please confirm the details."
        Me.lblAddConfirm.Visible = False
        '
        'chkAdminAdd
        '
        Me.chkAdminAdd.AutoSize = True
        Me.chkAdminAdd.Font = New System.Drawing.Font("Segoe UI Semilight", 12.5!)
        Me.chkAdminAdd.Location = New System.Drawing.Point(240, 201)
        Me.chkAdminAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAdminAdd.Name = "chkAdminAdd"
        Me.chkAdminAdd.Size = New System.Drawing.Size(104, 34)
        Me.chkAdminAdd.TabIndex = 3
        Me.chkAdminAdd.Text = "Admin?"
        Me.chkAdminAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Full Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNameAdd
        '
        Me.txtNameAdd.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.txtNameAdd.Location = New System.Drawing.Point(142, 142)
        Me.txtNameAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNameAdd.MaxLength = 80
        Me.txtNameAdd.Name = "txtNameAdd"
        Me.txtNameAdd.Size = New System.Drawing.Size(308, 39)
        Me.txtNameAdd.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(13, 735)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(551, 43)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "TIP! Resize the columns of the 'View'  box to see more data."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AccountManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 795)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.grpView)
        Me.Controls.Add(Me.grpDelete)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.txtEnable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpChange)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountManager"
        Me.Text = "Account Manager"
        Me.grpView.ResumeLayout(False)
        Me.grpDelete.ResumeLayout(False)
        Me.grpDelete.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChange.ResumeLayout(False)
        Me.grpChange.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkDelete As System.Windows.Forms.CheckBox
    Friend WithEvents cboDelete As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtPasswordUpdate As System.Windows.Forms.TextBox
    Friend WithEvents grpView As System.Windows.Forms.GroupBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents cboUsernameUpdate As System.Windows.Forms.ComboBox
    Friend WithEvents lblDelete As System.Windows.Forms.Label
    Friend WithEvents grpDelete As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdmin As System.Windows.Forms.Label
    Friend WithEvents txtEnable As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents lblNewUsername As System.Windows.Forms.Label
    Friend WithEvents txtPasswordAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernameAdd As System.Windows.Forms.TextBox
    Friend WithEvents grpChange As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnable As System.Windows.Forms.Button
    Friend WithEvents grpNew As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNameAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnAddAccount As System.Windows.Forms.Button
    Friend WithEvents lblAddConfirm As System.Windows.Forms.Label
    Friend WithEvents chkAdminAdd As System.Windows.Forms.CheckBox
    Friend WithEvents txtNameUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnViewClear As System.Windows.Forms.Button
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents chkAdminUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
