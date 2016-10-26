<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownView = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MainMenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountManagerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TravelApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusinessExpenseApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TravelExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusinessExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RevenuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownHelp = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTravelApplication = New System.Windows.Forms.Button()
        Me.btnBusinessApplication = New System.Windows.Forms.Button()
        Me.btnRevenues = New System.Windows.Forms.Button()
        Me.btnTravelExpenses = New System.Windows.Forms.Button()
        Me.btnBusinessExpenses = New System.Windows.Forms.Button()
        Me.btnWages = New System.Windows.Forms.Button()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.btnInvestment = New System.Windows.Forms.Button()
        Me.btnAccountManager = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.DateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EasterEgg = New System.Windows.Forms.PictureBox()
        Me.ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EasterEgg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownFile, Me.ToolStripDropDownView, Me.ToolStripDropDownHelp})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip.Size = New System.Drawing.Size(1353, 39)
        Me.ToolStrip.TabIndex = 14
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripDropDownFile
        '
        Me.ToolStripDropDownFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountManagerToolStripMenuItem, Me.SettingsToolStripSeparator, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownFile.ForeColor = System.Drawing.Color.Black
        Me.ToolStripDropDownFile.Image = CType(resources.GetObject("ToolStripDropDownFile.Image"), System.Drawing.Image)
        Me.ToolStripDropDownFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownFile.Name = "ToolStripDropDownFile"
        Me.ToolStripDropDownFile.ShowDropDownArrow = False
        Me.ToolStripDropDownFile.Size = New System.Drawing.Size(52, 36)
        Me.ToolStripDropDownFile.Text = "File"
        Me.ToolStripDropDownFile.ToolTipText = "File"
        '
        'AccountManagerToolStripMenuItem
        '
        Me.AccountManagerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
        Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(256, 34)
        Me.AccountManagerToolStripMenuItem.Text = "Account Manager"
        '
        'SettingsToolStripSeparator
        '
        Me.SettingsToolStripSeparator.Name = "SettingsToolStripSeparator"
        Me.SettingsToolStripSeparator.Size = New System.Drawing.Size(253, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(256, 34)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(253, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(256, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(256, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripDropDownView
        '
        Me.ToolStripDropDownView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem1, Me.AccountManagerToolStripMenuItem1, Me.SettingsToolStripMenuItem1, Me.ContactSupportToolStripMenuItem, Me.ToolStripSeparator3, Me.TravelApplicationToolStripMenuItem, Me.BusinessExpenseApplicationToolStripMenuItem, Me.ToolStripSeparator4, Me.TravelExpensesToolStripMenuItem, Me.BusinessExpensesToolStripMenuItem, Me.ToolStripSeparator5, Me.RevenuesToolStripMenuItem, Me.InvestmentToolStripMenuItem, Me.WagesToolStripMenuItem})
        Me.ToolStripDropDownView.ForeColor = System.Drawing.Color.Black
        Me.ToolStripDropDownView.Image = CType(resources.GetObject("ToolStripDropDownView.Image"), System.Drawing.Image)
        Me.ToolStripDropDownView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownView.Name = "ToolStripDropDownView"
        Me.ToolStripDropDownView.ShowDropDownArrow = False
        Me.ToolStripDropDownView.Size = New System.Drawing.Size(68, 36)
        Me.ToolStripDropDownView.Text = "View"
        Me.ToolStripDropDownView.ToolTipText = "View"
        '
        'MainMenuToolStripMenuItem1
        '
        Me.MainMenuToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.MainMenuToolStripMenuItem1.Name = "MainMenuToolStripMenuItem1"
        Me.MainMenuToolStripMenuItem1.Size = New System.Drawing.Size(364, 34)
        Me.MainMenuToolStripMenuItem1.Text = "Main Menu"
        '
        'AccountManagerToolStripMenuItem1
        '
        Me.AccountManagerToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.AccountManagerToolStripMenuItem1.Name = "AccountManagerToolStripMenuItem1"
        Me.AccountManagerToolStripMenuItem1.Size = New System.Drawing.Size(364, 34)
        Me.AccountManagerToolStripMenuItem1.Text = "Account Manager"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(364, 34)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'ContactSupportToolStripMenuItem
        '
        Me.ContactSupportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ContactSupportToolStripMenuItem.Name = "ContactSupportToolStripMenuItem"
        Me.ContactSupportToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.ContactSupportToolStripMenuItem.Text = "Contact Support"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(361, 6)
        '
        'TravelApplicationToolStripMenuItem
        '
        Me.TravelApplicationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.TravelApplicationToolStripMenuItem.Name = "TravelApplicationToolStripMenuItem"
        Me.TravelApplicationToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.TravelApplicationToolStripMenuItem.Text = "Travel Application"
        '
        'BusinessExpenseApplicationToolStripMenuItem
        '
        Me.BusinessExpenseApplicationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.BusinessExpenseApplicationToolStripMenuItem.Name = "BusinessExpenseApplicationToolStripMenuItem"
        Me.BusinessExpenseApplicationToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.BusinessExpenseApplicationToolStripMenuItem.Text = "Business Expense Application"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(361, 6)
        '
        'TravelExpensesToolStripMenuItem
        '
        Me.TravelExpensesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.TravelExpensesToolStripMenuItem.Name = "TravelExpensesToolStripMenuItem"
        Me.TravelExpensesToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.TravelExpensesToolStripMenuItem.Text = "Travel Expenses"
        '
        'BusinessExpensesToolStripMenuItem
        '
        Me.BusinessExpensesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.BusinessExpensesToolStripMenuItem.Name = "BusinessExpensesToolStripMenuItem"
        Me.BusinessExpensesToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.BusinessExpensesToolStripMenuItem.Text = "Business Expenses"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(361, 6)
        '
        'RevenuesToolStripMenuItem
        '
        Me.RevenuesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.RevenuesToolStripMenuItem.Name = "RevenuesToolStripMenuItem"
        Me.RevenuesToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.RevenuesToolStripMenuItem.Text = "Revenues"
        '
        'InvestmentToolStripMenuItem
        '
        Me.InvestmentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.InvestmentToolStripMenuItem.Name = "InvestmentToolStripMenuItem"
        Me.InvestmentToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.InvestmentToolStripMenuItem.Text = "Investment"
        '
        'WagesToolStripMenuItem
        '
        Me.WagesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.WagesToolStripMenuItem.Name = "WagesToolStripMenuItem"
        Me.WagesToolStripMenuItem.Size = New System.Drawing.Size(364, 34)
        Me.WagesToolStripMenuItem.Text = "Wages"
        '
        'ToolStripDropDownHelp
        '
        Me.ToolStripDropDownHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.ToolStripDropDownHelp.ForeColor = System.Drawing.Color.Black
        Me.ToolStripDropDownHelp.Image = CType(resources.GetObject("ToolStripDropDownHelp.Image"), System.Drawing.Image)
        Me.ToolStripDropDownHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownHelp.Name = "ToolStripDropDownHelp"
        Me.ToolStripDropDownHelp.ShowDropDownArrow = False
        Me.ToolStripDropDownHelp.Size = New System.Drawing.Size(67, 36)
        Me.ToolStripDropDownHelp.Text = "Help"
        Me.ToolStripDropDownHelp.ToolTipText = "Help"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(245, 34)
        Me.ContactToolStripMenuItem.Text = "Contact Support"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(242, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(245, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnTravelApplication
        '
        Me.btnTravelApplication.BackgroundImage = CType(resources.GetObject("btnTravelApplication.BackgroundImage"), System.Drawing.Image)
        Me.btnTravelApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTravelApplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnTravelApplication.FlatAppearance.BorderSize = 5
        Me.btnTravelApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnTravelApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnTravelApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTravelApplication.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnTravelApplication.ForeColor = System.Drawing.Color.White
        Me.btnTravelApplication.Location = New System.Drawing.Point(21, 174)
        Me.btnTravelApplication.Name = "btnTravelApplication"
        Me.btnTravelApplication.Size = New System.Drawing.Size(250, 250)
        Me.btnTravelApplication.TabIndex = 21
        Me.btnTravelApplication.Text = "Travel Application"
        Me.btnTravelApplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTravelApplication.UseVisualStyleBackColor = True
        '
        'btnBusinessApplication
        '
        Me.btnBusinessApplication.BackgroundImage = CType(resources.GetObject("btnBusinessApplication.BackgroundImage"), System.Drawing.Image)
        Me.btnBusinessApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBusinessApplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBusinessApplication.FlatAppearance.BorderSize = 5
        Me.btnBusinessApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnBusinessApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnBusinessApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBusinessApplication.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnBusinessApplication.ForeColor = System.Drawing.Color.White
        Me.btnBusinessApplication.Location = New System.Drawing.Point(286, 174)
        Me.btnBusinessApplication.Name = "btnBusinessApplication"
        Me.btnBusinessApplication.Size = New System.Drawing.Size(250, 250)
        Me.btnBusinessApplication.TabIndex = 22
        Me.btnBusinessApplication.Text = "Business Application"
        Me.btnBusinessApplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBusinessApplication.UseVisualStyleBackColor = True
        '
        'btnRevenues
        '
        Me.btnRevenues.BackgroundImage = CType(resources.GetObject("btnRevenues.BackgroundImage"), System.Drawing.Image)
        Me.btnRevenues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRevenues.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRevenues.FlatAppearance.BorderSize = 5
        Me.btnRevenues.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnRevenues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnRevenues.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRevenues.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnRevenues.ForeColor = System.Drawing.Color.White
        Me.btnRevenues.Location = New System.Drawing.Point(551, 174)
        Me.btnRevenues.Name = "btnRevenues"
        Me.btnRevenues.Size = New System.Drawing.Size(250, 250)
        Me.btnRevenues.TabIndex = 23
        Me.btnRevenues.Text = "Revenues"
        Me.btnRevenues.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRevenues.UseVisualStyleBackColor = True
        '
        'btnTravelExpenses
        '
        Me.btnTravelExpenses.BackgroundImage = CType(resources.GetObject("btnTravelExpenses.BackgroundImage"), System.Drawing.Image)
        Me.btnTravelExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTravelExpenses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.btnTravelExpenses.FlatAppearance.BorderSize = 5
        Me.btnTravelExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.btnTravelExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnTravelExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTravelExpenses.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnTravelExpenses.ForeColor = System.Drawing.Color.White
        Me.btnTravelExpenses.Location = New System.Drawing.Point(816, 174)
        Me.btnTravelExpenses.Name = "btnTravelExpenses"
        Me.btnTravelExpenses.Size = New System.Drawing.Size(250, 250)
        Me.btnTravelExpenses.TabIndex = 24
        Me.btnTravelExpenses.Text = "Travel Expenses"
        Me.btnTravelExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTravelExpenses.UseVisualStyleBackColor = True
        '
        'btnBusinessExpenses
        '
        Me.btnBusinessExpenses.BackgroundImage = CType(resources.GetObject("btnBusinessExpenses.BackgroundImage"), System.Drawing.Image)
        Me.btnBusinessExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBusinessExpenses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnBusinessExpenses.FlatAppearance.BorderSize = 5
        Me.btnBusinessExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnBusinessExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnBusinessExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBusinessExpenses.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnBusinessExpenses.ForeColor = System.Drawing.Color.White
        Me.btnBusinessExpenses.Location = New System.Drawing.Point(1080, 174)
        Me.btnBusinessExpenses.Name = "btnBusinessExpenses"
        Me.btnBusinessExpenses.Size = New System.Drawing.Size(250, 250)
        Me.btnBusinessExpenses.TabIndex = 25
        Me.btnBusinessExpenses.Text = "Business Expenses"
        Me.btnBusinessExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBusinessExpenses.UseVisualStyleBackColor = True
        '
        'btnWages
        '
        Me.btnWages.BackgroundImage = CType(resources.GetObject("btnWages.BackgroundImage"), System.Drawing.Image)
        Me.btnWages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnWages.FlatAppearance.BorderSize = 5
        Me.btnWages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnWages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnWages.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWages.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnWages.ForeColor = System.Drawing.Color.White
        Me.btnWages.Location = New System.Drawing.Point(551, 441)
        Me.btnWages.Name = "btnWages"
        Me.btnWages.Size = New System.Drawing.Size(250, 250)
        Me.btnWages.TabIndex = 29
        Me.btnWages.Text = "Wages"
        Me.btnWages.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWages.UseVisualStyleBackColor = True
        '
        'btnContact
        '
        Me.btnContact.BackgroundImage = CType(resources.GetObject("btnContact.BackgroundImage"), System.Drawing.Image)
        Me.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnContact.FlatAppearance.BorderSize = 5
        Me.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnContact.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnContact.ForeColor = System.Drawing.Color.White
        Me.btnContact.Location = New System.Drawing.Point(21, 441)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(250, 250)
        Me.btnContact.TabIndex = 27
        Me.btnContact.Text = " Contact Support"
        Me.btnContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'btnInvestment
        '
        Me.btnInvestment.BackgroundImage = CType(resources.GetObject("btnInvestment.BackgroundImage"), System.Drawing.Image)
        Me.btnInvestment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInvestment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnInvestment.FlatAppearance.BorderSize = 5
        Me.btnInvestment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnInvestment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnInvestment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInvestment.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnInvestment.ForeColor = System.Drawing.Color.White
        Me.btnInvestment.Location = New System.Drawing.Point(286, 441)
        Me.btnInvestment.Name = "btnInvestment"
        Me.btnInvestment.Size = New System.Drawing.Size(250, 250)
        Me.btnInvestment.TabIndex = 28
        Me.btnInvestment.Text = "Investment"
        Me.btnInvestment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInvestment.UseVisualStyleBackColor = True
        '
        'btnAccountManager
        '
        Me.btnAccountManager.BackgroundImage = CType(resources.GetObject("btnAccountManager.BackgroundImage"), System.Drawing.Image)
        Me.btnAccountManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAccountManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnAccountManager.FlatAppearance.BorderSize = 5
        Me.btnAccountManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnAccountManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnAccountManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccountManager.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnAccountManager.ForeColor = System.Drawing.Color.White
        Me.btnAccountManager.Location = New System.Drawing.Point(816, 441)
        Me.btnAccountManager.Name = "btnAccountManager"
        Me.btnAccountManager.Size = New System.Drawing.Size(250, 250)
        Me.btnAccountManager.TabIndex = 30
        Me.btnAccountManager.Text = "Account Manager"
        Me.btnAccountManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAccountManager.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = CType(resources.GetObject("btnSettings.BackgroundImage"), System.Drawing.Image)
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 5
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 14.2!)
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(1080, 441)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(250, 250)
        Me.btnSettings.TabIndex = 31
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 716)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1365, 2)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 41)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Welcome to the Main Menu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 32)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Please select the form you wish to get to."
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.White
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(760, 100)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(572, 32)
        Me.lblDate.TabIndex = 34
        Me.lblDate.Text = "Date Goes Here"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(754, 63)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(578, 32)
        Me.lblTime.TabIndex = 37
        Me.lblTime.Text = "Time Goes Here"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimer
        '
        Me.DateTimer.Enabled = True
        Me.DateTimer.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 740)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(731, 35)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "For a simplified menu, use the 'View' option at the top of the form."
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnLogOut.Location = New System.Drawing.Point(1045, 732)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(127, 53)
        Me.btnLogOut.TabIndex = 33
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnExit.Location = New System.Drawing.Point(1197, 732)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 53)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnHelp.Location = New System.Drawing.Point(896, 732)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(127, 53)
        Me.btnHelp.TabIndex = 32
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(0, 42)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1353, 114)
        Me.PictureBox4.TabIndex = 85
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(-2, 157)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1355, 561)
        Me.PictureBox5.TabIndex = 86
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 716)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1355, 89)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(-2, 45)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1357, 110)
        Me.PictureBox3.TabIndex = 88
        Me.PictureBox3.TabStop = False
        '
        'EasterEgg
        '
        Me.EasterEgg.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.EasterEgg.Location = New System.Drawing.Point(805, 430)
        Me.EasterEgg.Name = "EasterEgg"
        Me.EasterEgg.Size = New System.Drawing.Size(5, 5)
        Me.EasterEgg.TabIndex = 89
        Me.EasterEgg.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1353, 797)
        Me.Controls.Add(Me.EasterEgg)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnAccountManager)
        Me.Controls.Add(Me.btnInvestment)
        Me.Controls.Add(Me.btnContact)
        Me.Controls.Add(Me.btnWages)
        Me.Controls.Add(Me.btnBusinessExpenses)
        Me.Controls.Add(Me.btnTravelExpenses)
        Me.Controls.Add(Me.btnRevenues)
        Me.Controls.Add(Me.btnBusinessApplication)
        Me.Controls.Add(Me.btnTravelApplication)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EasterEgg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownFile As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AccountManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownHelp As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownView As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents MainMenuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountManagerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TravelApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusinessExpenseApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TravelExpensesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusinessExpensesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevenuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InvestmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTravelApplication As System.Windows.Forms.Button
    Friend WithEvents btnBusinessApplication As System.Windows.Forms.Button
    Friend WithEvents btnRevenues As System.Windows.Forms.Button
    Friend WithEvents btnTravelExpenses As System.Windows.Forms.Button
    Friend WithEvents btnBusinessExpenses As System.Windows.Forms.Button
    Friend WithEvents btnWages As System.Windows.Forms.Button
    Friend WithEvents btnContact As System.Windows.Forms.Button
    Friend WithEvents btnInvestment As System.Windows.Forms.Button
    Friend WithEvents btnAccountManager As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents DateTimer As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents EasterEgg As System.Windows.Forms.PictureBox
End Class
