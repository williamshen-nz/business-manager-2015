Imports System.Data.OleDb
Imports System.Net.Mail

Public Class Travel_Application___New
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Travel_Application___New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutine to populate the comboboxes
        populateCBO()
        'Selects the users username in the combination box and sets email textbox
        cboName.Text = My.Settings.accountFullName
        txtEmail.Text = My.Settings.accountUsername & "@odinhealth.co.nz"
        'Sets the Tracking Number
        If My.Settings.TEADate = DateTime.Today Then
            'Sets tracking number if the settings variable date is the same as todays date
            lblTracking.Text = "TV" & DateTime.Now.ToString("ddMMyy") & My.Settings.TEACount
        Else
            'Sets the settings variable to todays date if it does not match todays date
            My.Settings.TEADate = DateTime.Today
            'Sets the count for the number of applications to 0
            My.Settings.TEACount = 0
            lblTracking.Text = "TV" & DateTime.Now.ToString("ddMMyy") & My.Settings.TEACount
        End If
        'Focuses on the form
        PictureBox.Select()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Checks if the function returns a true
        If Validation() Then
            Try
                'Declares the new OleDbCommand
                Dim cmd As New OleDbCommand("INSERT INTO TEA (TrackingNumber, FullName, Email, Destinations, Duration, Reason, " & _
                                            "AccomodationCosts, DomesticTravelCosts, InternationalTravelCosts, TotalCost, Approved) " & _
                                            "VALUES (@TrackingNumber, @FullName, @Email, @Destinations, @Duration, @Reason, " & _
                                            "@AccomodationCosts, @DomesticTravelCosts, @InternationalTravelCosts, @TotalCost, @Approved)", connection)
                'Gives the parameters its values
                cmd.Parameters.AddWithValue("TrackingNumber", lblTracking.Text)
                cmd.Parameters.AddWithValue("FullName", cboName.Text)
                cmd.Parameters.AddWithValue("Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("Destinations", txtDestinations.Text)
                cmd.Parameters.AddWithValue("Duration", txtDuration.Text)
                cmd.Parameters.AddWithValue("Reason", rtbReason.Text)
                cmd.Parameters.AddWithValue("AccomodationCosts", txtAccomodation.Text)
                cmd.Parameters.AddWithValue("DomesticTravelCosts", txtDomestic.Text)
                cmd.Parameters.AddWithValue("InternationalTravelCosts", txtInternational.Text)
                cmd.Parameters.AddWithValue("TotalCost", txtTotal.Text)
                cmd.Parameters.AddWithValue("Approved", False)
                'Opens database connection, executes query and closes the database
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                'Adds 1 onto the count for making the application number
                My.Settings.TEACount = My.Settings.TEACount + 1
                'Try running the email sending subroutine
                Try
                    SendEmail()
                    'Output to show successful updation on Overview form
                    Travel_Application___Overview.lblDataStatus.Text = "Record added and email sent."
                    Travel_Application___Overview.lblDataStatus.ForeColor = Color.Green
                    Travel_Application___Overview.lblDataStatus.Visible = True
                    'Closes the form completely
                    Me.Dispose()
                Catch
                    'Output to show record added but email not sent
                    MsgBox("Application successfully added into database but email did not successfully send.")
                    'Output to show successful updation on Overview form
                    Travel_Application___Overview.lblDataStatus.Text = "Record successfully added."
                    Travel_Application___Overview.lblDataStatus.ForeColor = Color.Green
                    Travel_Application___Overview.lblDataStatus.Visible = True
                    'Closes the form completely
                    Me.Dispose()
                End Try
            Catch
                'Shows error if record cannot be inserted
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "A record with the tracking number already exists."
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        'Closes form completely if user selects 'Yes'
        If Response = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        'Update the textbox containing the email when combobox selection is altered
        Dim Name As String = cboName.Text
        Name = Name.ToLower
        Name = Name.Replace(" ", ".")
        txtEmail.Text = Name & "@odinhealth.co.nz"
    End Sub

    Private Function Validation()
        'First checks if all the textboxes contain text
        If txtEmail.Text <> "" And txtDestinations.Text <> "" And txtDuration.Text <> "" And rtbReason.Text <> "" And txtDomestic.Text <> "" _
        And txtInternational.Text <> "" And txtAccomodation.Text <> "" And txtTotal.Text <> "" Then
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

    Private Sub Travel_Application___New_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Closes form completely and runs subroutines to repopulate the listviews
        Me.Dispose()
        Travel_Application___Overview.populateListViewPending()
        Travel_Application___Overview.populateListViewApproved()
    End Sub

    Private Sub populateCBO()
        'Declares DataSet and fills it up with data from Username Column in database
        Dim ds As New DataSet()
        Using da As New OleDbDataAdapter("SELECT FullName FROM Accounts", connection)
            da.Fill(ds, "FullName")
        End Using
        'Loads DataSet data into a DataView, sorts it then writes it to a DataTable
        Dim view As New DataView(ds.Tables("FullName"))
        view.Sort = "FullName"
        Dim sorted As DataTable = view.ToTable()
        'Populates comboboxes with contents of the new Datatable
        With cboName
            .DisplayMember = "FullName"
            .DataSource = view
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub SendEmail()
        'Disables the form
        Me.Enabled = False
        'Output to show that validation was successful.
        lblStatus.ForeColor = Color.ForestGreen
        lblStatus.Text = "Validation successful - Adding application to database and sending email for approval. Please wait a moment..."
        'Creates new message and declares Name variable
        Dim Email As New MailMessage()
        Dim Name As String = cboName.Text
        'Sets the email preferences
        Email.From = New MailAddress(txtEmail.Text)
        Email.[To].Add(My.Settings.applicationEmail)
        'Sets the content of the email
        Email.Subject = "Travel Application #" & lblTracking.Text
        Email.Body = "<H2>Travel Application for " & Name & "</H2>" & "Date of Submission: " & DateTime.Today & "<BR>Return Email: " & _
            txtEmail.Text & "<BR><BR>" & "Destinations: " & txtDestinations.Text & " (Duration: " & txtDuration.Text & " Days)<BR><BR>" & _
            "Reason for Trip: " & rtbReason.Text & "<BR><BR>" & "<u>Estimated Costs:</u>" & "<BR>" & _
            "Domestic Travel Costs: $" & txtDomestic.Text & " NZD<BR>" & "International Travel Costs: $" & _
            txtInternational.Text & " NZD<BR>" & "Accomodation Costs: $" & txtAccomodation.Text & " NZD<BR>" & _
            "Total Costs: $" & txtTotal.Text & " NZD<BR><BR>To approve this application, open the Business " & _
            "Manager program and navigate to the Travel Applications, select the application click the 'View and Edit' button and " & _
            "then tick the approved box and 'Update'"
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
        lblStatus.Text = "Application added into database and email has been successfully sent for approval. Thank You!"
        'Enables the form
        Me.Enabled = True
    End Sub

    Private Sub txtDuration_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuration.KeyPress
        'Runs subroutine on textFormatting class to allow numbers only into textbox
        textFormatting.numbersOnly(sender, e)
    End Sub

    Private Sub CostAddition_TextChanged(sender As Object, e As EventArgs) Handles txtDomestic.TextChanged, txtInternational.TextChanged, txtAccomodation.TextChanged
        'Declares variables and gives them values according to their relevant textboxes
        Dim d, i, a, t As Double
        d = Val(txtDomestic.Text)
        i = Val(txtInternational.Text)
        a = Val(txtAccomodation.Text)
        'Adds the values in the textboxes for estimated costs together to give total
        t = d + i + a
        txtTotal.Text = t
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomestic.KeyPress, txtInternational.KeyPress,
          txtAccomodation.KeyPress, txtTotal.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub
End Class