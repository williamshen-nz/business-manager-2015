Imports System.Data.OleDb
Imports System.Net.Mail
Imports Odin.textFormatting

Public Class Business_Expensive_Application___New
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Business_Expensive_Application___New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutine to populate the combination box for Name and focuses the controls on the form
        populateCBO()
        PictureBox.Select()
        'Selects the users username in the combination box and sets email textbox
        cboName.Text = My.Settings.accountFullName
        txtEmail.Text = My.Settings.accountUsername & "@odinhealth.co.nz"
        'Sets the Tracking Number.
        If My.Settings.BEADate = DateTime.Today Then
            'Sets tracking number if the settings variable date is the same as todays date
            lblTracking.Text = "BS" & DateTime.Now.ToString("ddMMyy") & My.Settings.BEACount
        Else
            'Sets the settings variable to todays date if it does not match todays date
            My.Settings.BEADate = DateTime.Today
            'Sets the count for the number of applications to 0
            My.Settings.BEACount = 0
            lblTracking.Text = "BS" & DateTime.Now.ToString("ddMMyy") & My.Settings.BEACount
        End If
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        'Update the textbox containing the email when combobox selection is altered
        Dim Name As String = cboName.Text
        Name = Name.ToLower
        Name = Name.Replace(" ", ".")
        txtEmail.Text = Name & "@odinhealth.co.nz"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Checks if the function returned a true
        If Validation() Then
            'Declares the new OleDbCommand
            Dim cmd As New OleDbCommand("INSERT INTO BEA (TrackingNumber, FullName, Email, ItemDescription, Quantity, " & _
                                        "UnitPrice, TotalPrice, Vendor, Reason, Approved) " & _
                                        "VALUES (@TrackingNumber, @FullName, @Email, @ItemDescription, @Quantity, @UnitPrice, " & _
                                        "@TotalPrice, @Vendor, @Reason, @Approved)", connection)
            'Gives the parameters its values
            cmd.Parameters.AddWithValue("TrackingNumber", lblTracking.Text)
            cmd.Parameters.AddWithValue("FullName", cboName.Text)
            cmd.Parameters.AddWithValue("Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("ItemDescription", txtDescription.Text)
            cmd.Parameters.AddWithValue("Quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("UnitPrice", txtUnit.Text)
            cmd.Parameters.AddWithValue("TotalPrice", txtTotal.Text)
            cmd.Parameters.AddWithValue("Vendor", txtVendor.Text)
            cmd.Parameters.AddWithValue("Reason", rtbReason.Text)
            cmd.Parameters.AddWithValue("Approved", False)
            'Opens database connection, executes query and closes the database
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Adds 1 onto the count for making the application number
            My.Settings.BEACount = My.Settings.BEACount + 1
            'Output to show successful update on Overview form
            Travel_Application___Overview.lblDataStatus.Text = "Record successfully added."
            Travel_Application___Overview.lblDataStatus.Visible = True
            'Tries to send an email
            Try
                'Runs subroutine to send an email and sets feedback on the overview form
                SendEmail()
                Travel_Application___Overview.lblDataStatus.Text = "Record added and email sent."
                'Completely closes the form
                Me.Dispose()
            Catch
                'Output to show that there was a problem sending the email but record was added
                lblStatus.ForeColor = Color.Green
                MsgBox("Application successfully added into database but email did not successfully send.")
                'Closes the form completely
                Me.Dispose()
            End Try
        End If
    End Sub

    Private Function Validation()
        'First checks if all the textboxes contain text
        If txtEmail.Text <> "" And txtDescription.Text <> "" And txtQuantity.Text <> "" And txtUnit.Text <> "" And txtTotal.Text <> "" _
        And txtVendor.Text <> "" And rtbReason.Text <> "" Then
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
        'Populates combobox with contents of the new Datatable
        With cboName
            .DisplayMember = "FullName"
            .DataSource = view
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub Business_Expense_Application___New_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Closes form completely and runs subroutines to refresh the listviews on the overview form
        Me.Dispose()
        Business_Expense_Application___Overview.populateListViewPending()
        Business_Expense_Application___Overview.populateListViewApproved()
    End Sub

    Private Sub SendEmail()
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
        Email.Subject = "Business Expense Application #" & lblTracking.Text
        Email.Body = "<H2>Business Expense Application for " & Name & "</H2>" & "Date of Submission: " & DateTime.Today & _
            "<BR>Return Email: " & txtEmail.Text & "<BR><BR>Item Description: " & txtDescription.Text & " (Quantity: " & txtQuantity.Text & _
            ")<BR>" & "Unit Price: $" & txtUnit.Text & " NZD<BR>Total Price: $" & txtTotal.Text & " NZD<BR>Vendor: " & _
            txtVendor.Text & "<BR><BR>Reason for Expense: " & rtbReason.Text & "<BR><BR>" & _
            "To approve this application, open the Business Manager program and navigate to the Business Expense " & _
            "Applications, select the application click the 'View and Edit' button and then tick the approved box and 'Update'."
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
        Me.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        'Completely closes the form if user responds 'Yes'
        If Response = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub TotalCost_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged, txtQuantity.TextChanged
        'Declares appropriate variables and sets them to the values in the relevant textboxes
        Dim quantity, unitCost, total As Double
        quantity = Val(txtQuantity.Text)
        unitCost = Val(txtUnit.Text)
        'Multiplies the value in the quantity textbox with the cost in the unit cost box to give total    
        total = quantity * unitCost
        txtTotal.Text = total
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        'Runs subroutine on textFormatting class to allow numbers only into textbox
        textFormatting.numbersOnly(sender, e)
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnit.KeyPress, txtTotal.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub
End Class