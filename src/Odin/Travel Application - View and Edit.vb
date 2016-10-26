Imports System.Data.OleDb
Imports System.Net.Mail

Public Class Travel_Application___View_and_Edit
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Dim Approved As Boolean

    Private Sub Travel_Application___View_and_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the connection and declares a new OleDbCommand and Reader
        Dim TrackingNumber As String = lblTracking.Text
        connection.Open()
        Dim dt As New DataTable()
        'Fills datatable with data from the TEA table
        Using da As New OleDbDataAdapter("SELECT * FROM TEA WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
            da.Fill(dt)
        End Using
        'Closes the connection
        connection.Close()
        'Sets values in textboxes to data in datatable
        txtName.Text = dt.Rows(0)("FullName").ToString
        txtEmail.Text = dt.Rows(0)("Email").ToString
        txtDestinations.Text = dt.Rows(0)("Destinations").ToString
        txtDuration.Text = dt.Rows(0)("Duration").ToString
        rtbReason.Text = dt.Rows(0)("Reason").ToString
        txtAccomodation.Text = dt.Rows(0)("AccomodationCosts").ToString
        txtDomestic.Text = dt.Rows(0)("DomesticTravelCosts").ToString
        txtInternational.Text = dt.Rows(0)("InternationalTravelCosts").ToString
        txtTotal.Text = dt.Rows(0)("TotalCost").ToString
        chkApproved.Checked = dt.Rows(0)("Approved")
        If My.Settings.accountAdmin = True Then
            txtName.ReadOnly = False
            chkApproved.Enabled = True
        End If
        'Sets "Approved" variable to true or false to be used in sending email to user.
        If chkApproved.Checked = False Then
            Approved = False
        Else
            Approved = True
        End If
        'Focuses form
        PictureBox.Select()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Runs Validation function and checks if it is true
        If Validation() Then
            'Declares the new OleDbCommand and gives it parameters
            Dim cmd As New OleDbCommand("UPDATE TEA SET FullName = ?, Email = ?, Destinations = ?, Duration = ?, Reason = ?, " & _
                                        "AccomodationCosts = ?, DomesticTravelCosts = ?, InternationalTravelCosts = ?, " & _
                                        "TotalCost = ?, Approved = ? WHERE TrackingNumber = '" & lblTracking.Text & "'", connection)
            cmd.Parameters.AddWithValue("@p1", txtName.Text)
            cmd.Parameters.AddWithValue("@p2", txtEmail.Text)
            cmd.Parameters.AddWithValue("@p3", txtDestinations.Text)
            cmd.Parameters.AddWithValue("@p4", txtDuration.Text)
            cmd.Parameters.AddWithValue("@p5", rtbReason.Text)
            cmd.Parameters.AddWithValue("@p6", txtAccomodation.Text)
            cmd.Parameters.AddWithValue("@p7", txtDomestic.Text)
            cmd.Parameters.AddWithValue("@p8", txtInternational.Text)
            cmd.Parameters.AddWithValue("@p9", txtTotal.Text)
            cmd.Parameters.AddWithValue("@p10", chkApproved.Checked)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful update on Overview form
            Travel_Application___Overview.lblDataStatus.Text = "Record successfully updated."
            Travel_Application___Overview.lblDataStatus.ForeColor = Color.Green
            Travel_Application___Overview.lblDataStatus.Visible = True
            'If the checkbox was initially unchecked and is now checked then send email
            If Approved = False And chkApproved.Checked = True Then
                Try
                    'Runs subroutine to send email
                    SendEmail()
                    'Output to show successful update and email sent on Overview form and closes form
                    Travel_Application___Overview.lblDataStatus.Text = "Record updated and email sent."
                    Me.Close()
                Catch
                    'Output in case email doesn't send and closes form
                    MsgBox("Email could not be successfully sent but record was updated.")
                    Me.Close()
                End Try
            End If
            'Closes form
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Displays a MsgBox asking user to confirm to delete the application
        Dim Response = MsgBox("Are you sure you want to delete this Travel Expense Application?", MsgBoxStyle.YesNo, "Delete Application")
        If Response = MsgBoxResult.Yes Then
            'Declares a new OleDbCommand which deletes the record if user selects 'Yes'
            Dim TrackingNumber As String = lblTracking.Text
            Dim cmd As New OleDbCommand("DELETE FROM TEA WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful updation on Overview form
            Travel_Application___Overview.lblDataStatus.Text = "Record successfully deleted."
            Travel_Application___Overview.lblDataStatus.ForeColor = Color.Green
            Travel_Application___Overview.lblDataStatus.Visible = True
            'Closes form
            Me.Close()
        End If
    End Sub

    Private Function Validation()
        'First checks if all the textboxes and richtextbox contain text
        If txtName.Text <> "" And txtEmail.Text <> "" And txtDestinations.Text <> "" And txtDuration.Text <> "" And rtbReason.Text <> "" _
            And txtDomestic.Text <> "" And txtInternational.Text <> "" And txtAccomodation.Text <> "" And txtTotal.Text <> "" Then
            'Validates the email address. Throws error if the address is in the wrong format
            Try
                'The function returns true 
                Dim Email As New MailAddress(txtEmail.Text)
                Return True
            Catch
                'Output to show that email address format was incorrect.
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Please check that the email address you entered was in a correct format."
                Return False
            End Try
        Else
            'Output to show that one or more of the textboxes have not been filled.
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Please ensure all fields are filled out correctly."
            Return False
        End If
    End Function

    Private Sub Travel_Application___View_and_Edit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Run subroutines to repopulate the listviews on the overview form
        Travel_Application___Overview.populateListViewPending()
        Travel_Application___Overview.populateListViewApproved()
        'Closes form completely
        Me.Dispose()
    End Sub

    Private Sub SendEmail()
        'Disables form controls
        Me.Enabled = False
        'Output to show that validation was successful.
        lblStatus.ForeColor = Color.ForestGreen
        lblStatus.Text = "Updating application and sending email to user. Please wait a moment..."
        'Creates new message and declares Name variable
        Dim Email As New MailMessage()
        Dim Name As String = txtName.Text
        'Sets the email preferences
        Email.From = New MailAddress("shen.odinhealth@gmail.com")
        Email.[To].Add(txtEmail.Text)
        'Sets the content of the email and formats it
        Email.Subject = "Approval - Travel Application #" & lblTracking.Text
        Email.Body = "<H2>Travel Application for " & Name & " has been approved.</H2>" & "Date of Approval: " & DateTime.Today & "<BR>Details for #" & _
            lblTracking.Text & "<BR><BR>" & "Destinations: " & txtDestinations.Text & " (Duration: " & txtDuration.Text & " Days)<BR><BR>" & _
            "Reason for Trip: " & rtbReason.Text & "<BR><BR>" & "<u>Estimated Costs:</u>" & "<BR>" & _
            "Domestic Travel Costs: $" & txtDomestic.Text & " NZD<BR>" & "International Travel Costs: $" & _
            txtInternational.Text & " NZD<BR>" & "Accomodation Costs: $" & txtAccomodation.Text & " NZD<BR>" & _
            "Total Costs: $" & txtTotal.Text & " NZD<BR><BR>You have been approved for this travel application. You may now " & _
            "go ahead and book or purchase the relevant expenses. Have a safe journey!"
        Email.IsBodyHtml = True
        'Sets the server to send the email
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New Net.NetworkCredential("shen.odinhealth@gmail.com", "c9dMy6RKPr")
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Host = "smtp.gmail.com"
        'Sends the email and shows feedback
        smtp.Send(Email)
        lblStatus.ForeColor = Color.Green
        lblStatus.Text = "Application updated and email has been successfully sent."
        'Enables form controls
        Me.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        If Response = MsgBoxResult.Yes Then
            Me.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub CostAddition_TextChanged(sender As Object, e As EventArgs) Handles txtDomestic.TextChanged, txtInternational.TextChanged, txtAccomodation.TextChanged
        'Declares variables and assigns them values based on their relevant textboxes
        Dim d, i, a, t As Double
        d = Val(txtDomestic.Text)
        i = Val(txtInternational.Text)
        a = Val(txtAccomodation.Text)
        'Adds the values in the textboxes for estimated costs and adds them together
        t = d + i + a
        txtTotal.Text = t
    End Sub

    Private Sub txtDuration_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuration.KeyPress
        'Runs subroutine on textFormatting class to allow numbers only into textbox
        textFormatting.numbersOnly(sender, e)
    End Sub

    Private Sub txtDomestic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomestic.KeyPress, txtInternational.KeyPress,
        txtAccomodation.KeyPress, txtTotal.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub
End Class