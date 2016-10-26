Imports System.Net.Mail

Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the text in the labels and textbox
        lblLocationDirectory.Text = My.Settings.dbLocation
        lblBackup.Text = "Last backed up on " & My.Settings.backupDate & "."
        txtApplicationEmail.Text = My.Settings.applicationEmail
        'Focuses form
        PictureBox.Select()
    End Sub

    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        'Declares an OpenFileDialog and assigns it a title
        Dim OpenFD As OpenFileDialog = New OpenFileDialog
        OpenFD.Title = "Select your Database File"
        'Opens file dialog and checks if OK button was pressed or not
        If OpenFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Sets the settings variable for the database location to the file the user selected
            My.Settings.dbLocation = OpenFD.FileName
            'Output to user showing success
            lblLocationDirectory.Text = My.Settings.dbLocation
            lblLocationStatus.Visible = True
            lblLocationStatus.ForeColor = Color.ForestGreen
            lblLocationStatus.Text = "Database Location successfully updated."
            'Displays a MsgBox asking user whether to restart the program
            Dim Response = MsgBox("The program must restart for changes to take full effect. Restart now?", MsgBoxStyle.YesNo, "Restart Odin")
            If Response = MsgBoxResult.Yes Then
                'Restarts application if user selects yes
                Application.Restart()
            Else : MsgBox("Please ensure you restart the program.")
            End If
        Else
            'Output to user showing the database was not updated
            lblLocationStatus.Visible = True
            lblLocationStatus.ForeColor = Color.Red
            lblLocationStatus.Text = "Database Location was not updated."
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        'Declares FolderBrowserDialog and gives it a description.
        Dim FolderBD As FolderBrowserDialog = New FolderBrowserDialog
        FolderBD.Description = "Select the directory where you want the database backed up to."
        'Opens the folder browser dialog and checks if OK button was pressed or not
        If FolderBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Declares the directory and file name for the new file
            Dim Directory As String = FolderBD.SelectedPath & "\OdinHealth Database Backup (" & DateTime.Now.ToString("dd-MM-yyyy") & ").accdb"
            'Copies the file from current database location to user selected directory
            My.Computer.FileSystem.CopyFile(My.Settings.dbLocation, Directory, _
                                            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, _
                                            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            'Output to show success
            lblBackup.ForeColor = Color.ForestGreen
            lblBackup.Text = "Database backed up successfully."
            My.Settings.backupDate = DateTime.Today
        Else
            'Output to show database was not backed up
            lblBackup.Visible = True
            lblBackup.ForeColor = Color.Red
            lblBackup.Text = "Database was not backed up."
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Gives the user help instructions
        MsgBox("To change the directory of the database, click the 'Browse' button and then go to the " &
               "directory of the database, select it and press 'Open'." & vbNewLine & vbNewLine & "To backup the database " &
               "click the 'Backup' button and navigate to the directory where you want the backup to be saved.")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form completely
        Me.Dispose()
    End Sub

    Private Sub btnApplicationEmail_Click(sender As Object, e As EventArgs) Handles btnApplicationEmail.Click
        'Checks if the email address in the textbox is in the correct format or not
        Try
            Dim Email As New MailAddress(txtApplicationEmail.Text)
            'Sets the settins variable to the email in the textbox
            My.Settings.applicationEmail = txtApplicationEmail.Text
            'Output to show email was updated
            lblApplicationEmail.ForeColor = Color.Green
            lblApplicationEmail.Text = "Email successfully updated."
        Catch
            'Output to show error in validating email address
            lblApplicationEmail.ForeColor = Color.Red
            lblApplicationEmail.Text = "Email address in incorrect format."
        End Try
    End Sub

    Private Sub Settings_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Closes the form completely
        Me.Dispose()
    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        'Opens the Settings Variables form
        SettingsVariables.ShowDialog()
    End Sub
End Class