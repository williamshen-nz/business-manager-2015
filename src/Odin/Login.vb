Imports System.Data.OleDb

Public Class Login
    'Declares number of Attempts and database connection
    Dim Attempts As Integer = 1
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enables controls on the form
        enableControls()
        '//THIS CODE NEEDS TO BE REMOVED ON FINAL BUILD//
        txtUsername.Text = "william.shen"
        txtPassword.Text = "password"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Sets database connection string again incase database location was changed
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
        'Modifies the text in the username to all lowercase for checking in the database
        Dim Username As String = txtUsername.Text
        Username.ToLower()
        'Opens connection
        connection.Open()
        'Selects Username field from the Accounts table 
        Dim cmdUser As New OleDbCommand("SELECT Username FROM Accounts WHERE Username = @Username;", connection)
        cmdUser.Parameters.AddWithValue("@Username", Username)
        'Declares and initializes data reader which retrieves data under the Username field
        Dim readerUsername As OleDbDataReader
        readerUsername = cmdUser.ExecuteReader
        'Checks if the Username column contains the text in the Username textbox
        If readerUsername.HasRows = False Then
            'Sets the value of Attempt one number higher
            Attempts = Attempts + 1
            'Sets the text in the label and resets the Password textbox
            lblStatus.Visible = True
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "The username or password you have entered is incorrect." & vbNewLine & "Attempt " & Attempts & " of 5"
            txtPassword.Text = ""
            'Closes data reader and command
            readerUsername.Close()
            cmdUser.Dispose()
        Else
            'In the case if the Username exists in the database
            readerUsername.Close()
            'Declares and initializes command and reader
            Dim cmdPassword As New OleDbCommand("SELECT * FROM Accounts WHERE Username = @Username;", connection)
            cmdPassword.Parameters.AddWithValue("@Username", txtUsername.Text)
            Dim readerPassword As OleDbDataReader
            readerPassword = cmdPassword.ExecuteReader
            'Reads the database to see if the Username corresponds with the text in the Password textbox
            If readerPassword.Read() Then
                If readerPassword("Password").ToString = txtPassword.Text Then
                    connection.Close()
                    'Runs subroutine to check if user has 'Admin' permission
                    adminCheck()
                    'Resets form and starts timer to open main menu form
                    disableControls()
                    'Output to show correct username and password
                    lblStatus.Text = "Correct password entered. The system will now login."
                    lblStatus.ForeColor = Color.Green
                    lblStatus.Visible = True
                    Feedback.Start()
                Else
                    'Sets the value of Attempt one number higher
                    Attempts = Attempts + 1
                    'Sets the text in the label and resets the Password textbox
                    lblStatus.Visible = True
                    lblStatus.ForeColor = Color.Red
                    lblStatus.Text = "The username or password you have entered is incorrect." & vbNewLine & "Attempt " & Attempts & " of 5"
                    txtPassword.Text = ""
                End If
            End If
            'Closes reader and data reader
            readerPassword.Close()
        End If
        'Closes the connection
        connection.Close()
        'Checks if number of attempts exceeds 5. If so then the program will close
        If Attempts >= 6 Then
            MsgBox("Maximum number of attempts reached. Program will exit.")
            Application.Exit()
        End If
    End Sub

    Private Sub Feedback_Tick(sender As Object, e As EventArgs) Handles Feedback.Tick
        'Resets form
        lblStatus.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        Attempts = 1
        'Opens Menu form and closes login form with a 1 second delay
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPassword.KeyDown
        'Calls subroutine of the login button when enter key is pressed in the Password textbox
        If e.KeyCode = Keys.Enter Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtUsername.KeyDown
        'Calls subroutine of the login button when enter key is pressed in the Password textbox
        If e.KeyCode = Keys.Enter Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub adminCheck()
        'Sets database connection string again incase database location was changed
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
        'Converts Username string to lowercase for database checking
        Dim Username As String = txtUsername.Text
        Username.ToLower()
        My.Settings.accountUsername = Username
        'Opens connection
        connection.Open()
        'Selects Admin field from the Accounts table 
        Dim cmdAdmin As New OleDbCommand("SELECT FullName, Admin FROM Accounts WHERE Username = @Username;", connection)
        cmdAdmin.Parameters.AddWithValue("@Username", Username)
        'Declares data reader and executes it
        Dim dr As OleDbDataReader = cmdAdmin.ExecuteReader
        dr.Read()
        'Sets settings variable for account FullName
        My.Settings.accountFullName = dr.Item("FullName")
        'Checks if the Admin field is checked or not
        If dr.Item("Admin") = True Then
            My.Settings.accountAdmin = True
        Else : My.Settings.accountAdmin = False
        End If
        connection.Close()
    End Sub

    Private Sub disableControls()
        'Disables controls
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        btnLogin.Enabled = False
        ToolStrip.Enabled = False
    End Sub

    Private Sub enableControls()
        'Enables controls
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        btnLogin.Enabled = True
        ToolStrip.Enabled = True
    End Sub

    Private Sub AccountManagerToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AccountManagerToolStripMenuItem.Click
        'Opens the Account Manager
        AccountManager.ShowDialog()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program
        Application.Exit()
    End Sub
    Private Sub ForgotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForgotToolStripMenuItem.Click
        'Output to display help to user
        MsgBox("Please contact your Administrator who will be able to give you your Username and Password if necessary." & vbNewLine &
               vbNewLine & "Use the Account Manager if you know the Master Password to view account information. (File -> Account Manager)")
    End Sub
    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        'Opens contact form
        Contact.ShowDialog()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Opens the About form
        About.ShowDialog()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        'Opens the settings form
        Settings.ShowDialog()
    End Sub
End Class
