Public Class SettingsVariables
    Private Sub SettingsVariables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Focuses on the enable textbox
        txtEnable.Select()
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        'Checks the password in the textbox
        If txtEnable.Text = "password" Then
            'Fills in the textboxes with the appropriate variables
            txtdbLocation.Text = My.Settings.dbLocation
            txtbackupDate.Text = My.Settings.backupDate
            txtaccountAdmin.Text = My.Settings.accountAdmin
            txtaccountUsername.Text = My.Settings.accountUsername
            txtaccountFullName.Text = My.Settings.accountFullName
            txtapplicationEmail.Text = My.Settings.applicationEmail
            txtTEADate.Text = My.Settings.TEADate
            txtTEACount.Text = My.Settings.TEACount
            txtBEADate.Text = My.Settings.BEADate
            txtBEACount.Text = My.Settings.BEACount
            'Feedback for user to show success
            lblAdmin.Text = "Correct password."
            lblAdmin.ForeColor = Color.Lime
            lblAdmin.Visible = True
            'Resets enable textbox contents
            txtEnable.Text = ""
        Else
            'Feedback for incorrect password
            lblAdmin.Text = "Incorrect password."
            lblAdmin.ForeColor = Color.Red
            lblAdmin.Visible = True
            'Resets textbox contents
            txtEnable.Text = ""
        End If
    End Sub

    Private Sub txtEnable_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtEnable.KeyDown
        'Calls subroutine of the enable button when enter key is pressed in the Enable textbox
        If e.KeyCode = Keys.Enter Then
            Call btnEnable_Click(sender, e)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form completely
        Me.Dispose()
    End Sub

    Private Sub SettingsVariables_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Closes the form completely
        Me.Dispose()
    End Sub
End Class