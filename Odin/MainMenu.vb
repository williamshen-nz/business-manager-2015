Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows the date and time on the labels
        lblTime.Text = DateTime.Now.ToString("dddd dd MMMM yyyy")
        lblDate.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub DateTimer_Tick(sender As Object, e As EventArgs) Handles DateTimer.Tick
        'Code to update the date and time shown on labels
        lblTime.Text = DateTime.Now.ToString("dddd dd MMMM yyyy")
        lblDate.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Displays a MsgBox asking user to confirm to exit the application
        Dim Response = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit")
        If Response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'Closes all the forms if they are open
        Travel_Application___Overview.Close()
        Business_Expense_Application___Overview.Close()
        Revenues___Overview.Close()
        Travel_Expense___Overview.Close()
        Business_Expense___Overview.Close()
        'Placeholder for Profit and Loss Report
        Investment.Close()
        Wages___Overview.Close()
        Settings.Close()
        Contact.Close()
        'Shows the Login form
        Login.Show()
        'Closes Main Menu Form
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Shows help information
        MsgBox("Please click on the button of the relevant function you want to navigate to." & _
               " Alternatively, you can use the 'toolbar' on the top of the window. For further help, " & _
               "consult the user guide or contact support.")
    End Sub

    'Code for the buttons on the main menu form to open the relevant forms and bring them to the front/ show as dialog
    Private Sub btnTravelApplication_Click(sender As Object, e As EventArgs) Handles btnTravelApplication.Click
        Travel_Application___Overview.Show()
        Travel_Application___Overview.BringToFront()
    End Sub
    Private Sub btnBusinessApplication_Click(sender As Object, e As EventArgs) Handles btnBusinessApplication.Click
        Business_Expense_Application___Overview.Show()
        Business_Expense_Application___Overview.BringToFront()
    End Sub
    Private Sub btnRevenues_Click(sender As Object, e As EventArgs) Handles btnRevenues.Click
        Revenues___Overview.Show()
        Revenues___Overview.BringToFront()
    End Sub
    Private Sub btnTravelExpenses_Click(sender As Object, e As EventArgs) Handles btnTravelExpenses.Click
        Travel_Expense___Overview.Show()
        Travel_Expense___Overview.BringToFront()
    End Sub
    Private Sub btnBusinessExpenses_Click(sender As Object, e As EventArgs) Handles btnBusinessExpenses.Click
        Business_Expense___Overview.Show()
        Business_Expense___Overview.BringToFront()
    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        Contact.ShowDialog()
    End Sub
    Private Sub btnInvestment_Click(sender As Object, e As EventArgs) Handles btnInvestment.Click
        Investment.Show()
        Investment.BringToFront()
    End Sub
    Private Sub btnWages_Click(sender As Object, e As EventArgs) Handles btnWages.Click
        Wages___Overview.Show()
        Wages___Overview.BringToFront()
    End Sub
    Private Sub btnAccountManager_Click(sender As Object, e As EventArgs) Handles btnAccountManager.Click
        AccountManager.ShowDialog()
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Settings.ShowDialog()
    End Sub

    'Opens relevant forms and brings them to the front or shows them as a dialog as appropriate
    Private Sub AccountManagerToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AccountManagerToolStripMenuItem.Click
        AccountManager.ShowDialog()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Displays a MsgBox asking user to confirm to exit the application
        Dim Response = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit")
        If Response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Contact.ShowDialog()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub
    Private Sub MainMenuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem1.Click
        Me.Show()
    End Sub
    Private Sub AccountManagerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AccountManagerToolStripMenuItem1.Click
        AccountManager.ShowDialog()
    End Sub
    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        Settings.Show()
        Settings.BringToFront()
    End Sub
    Private Sub ContactSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactSupportToolStripMenuItem.Click
        Contact.ShowDialog()
    End Sub
    Private Sub TravelApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TravelApplicationToolStripMenuItem.Click
        Travel_Application___Overview.Show()
        Travel_Application___Overview.BringToFront()
    End Sub
    Private Sub BusinessExpenseApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusinessExpenseApplicationToolStripMenuItem.Click
        Business_Expense_Application___Overview.Show()
        Business_Expense_Application___Overview.BringToFront()
    End Sub
    Private Sub TravelExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TravelExpensesToolStripMenuItem.Click
        Travel_Expense___Overview.Show()
        Travel_Expense___Overview.BringToFront()
    End Sub
    Private Sub BusinessExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusinessExpensesToolStripMenuItem.Click
        Business_Expense___Overview.Show()
        Business_Expense___Overview.BringToFront()
    End Sub
    Private Sub RevenuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevenuesToolStripMenuItem.Click
        Revenues___Overview.Show()
        Revenues___Overview.BringToFront()
    End Sub
    Private Sub InvestmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvestmentToolStripMenuItem.Click
        Investment.Show()
        Investment.BringToFront()
    End Sub
    Private Sub WagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WagesToolStripMenuItem.Click
        Wages___Overview.Show()
        Wages___Overview.BringToFront()
    End Sub

    Private Sub EasterEgg_Click(sender As Object, e As EventArgs) Handles EasterEgg.Click
        StatusBox.lblStatus.Text = "Easter Egg!"
        StatusBox.lblDescription.Text = "Thank you for supporting the developer."
        StatusBox.ShowDialog()
    End Sub
End Class