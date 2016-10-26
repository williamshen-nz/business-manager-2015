Imports System.Data.OleDb
Imports System.Net.Mail

Public Class Business_Expense_Applications___View_and_Edit
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Dim Approved As Boolean

    Private Sub Business_Expense_Applications___View_and_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the connection and declares a new OleDbCommand and Reader and fills datatable with data from BEA table
        Dim TrackingNumber As String = lblTracking.Text
        connection.Open()
        Dim dt As New DataTable()
        Using da As New OleDbDataAdapter("SELECT * FROM BEA WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
            da.Fill(dt)
        End Using
        'Closes the connection
        connection.Close()
        'Sets values in textboxes to data in datatable
        txtName.Text = dt.Rows(0)("FullName").ToString
        txtEmail.Text = dt.Rows(0)("Email").ToString
        txtDescription.Text = dt.Rows(0)("ItemDescription").ToString
        txtQuantity.Text = dt.Rows(0)("Quantity").ToString
        txtUnit.Text = dt.Rows(0)("UnitPrice").ToString
        txtTotal.Text = dt.Rows(0)("TotalPrice").ToString
        txtVendor.Text = dt.Rows(0)("Vendor").ToString
        rtbReason.Text = dt.Rows(0)("Reason").ToString
        chkApproved.Checked = dt.Rows(0)("Approved")
        'Checks if user is an admin or not
        If My.Settings.accountAdmin = True Then
            'Enables textbox to change the name and checkbox to approve the application
            txtName.ReadOnly = False
            chkApproved.Enabled = True
        End If
        'Sets "Approved" variable to true or false which will be used in sending email to user.
        If chkApproved.Checked = False Then
            Approved = False
        Else
            Approved = True
        End If
        'Focuses the form
        PictureBox.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        'Closes the form if user selects 'Yes'
        If Response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Displays a MsgBox asking user to confirm to delete the application
        Dim Response = MsgBox("Are you sure you want to delete this Business Expense Application?", MsgBoxStyle.YesNo,
                              "Delete Application")
        If Response = MsgBoxResult.Yes Then
            'Declares a new OleDbCommand which deletes the record if response is yes
            Dim TrackingNumber As String = lblTracking.Text
            Dim cmd As New OleDbCommand("DELETE FROM BEA WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Closes the form
            Me.Close()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Validation() Then
            'Declares the new OleDbCommand and gives it parameters
            Dim cmd As New OleDbCommand("UPDATE BEA SET FullName = ?, Email = ?, ItemDescription = ?, Quantity = ?, " & _
                                        "UnitPrice = ?, TotalPrice = ?, Vendor = ?, Reason = ?, Approved = ?" & _
                                        "WHERE TrackingNumber = '" & lblTracking.Text & "'", connection)
            cmd.Parameters.AddWithValue("@p1", txtName.Text)
            cmd.Parameters.AddWithValue("@p2", txtEmail.Text)
            cmd.Parameters.AddWithValue("@p3", txtDescription.Text)
            cmd.Parameters.AddWithValue("@p4", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@p5", txtUnit.Text)
            cmd.Parameters.AddWithValue("@p6", txtTotal.Text)
            cmd.Parameters.AddWithValue("@p7", txtVendor.Text)
            cmd.Parameters.AddWithValue("@p8", rtbReason.Text)
            cmd.Parameters.AddWithValue("@p9", chkApproved.Checked)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful update on Overview form
            Business_Expense_Application___Overview.lblDataStatus.Text = "Record successfully updated."
            Business_Expense_Application___Overview.lblDataStatus.ForeColor = Color.Green
            Business_Expense_Application___Overview.lblDataStatus.Visible = True
            'If the checkbox was initially unchecked and is now checked then try send email
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
            'Closes form once record has been updated
            Me.Close()
        End If
    End Sub

    Private Function Validation()
        'First checks if all the textboxesand the richtextbox contain text
        If txtName.Text <> "" And txtEmail.Text <> "" And txtDescription.Text <> "" And txtQuantity.Text <> "" And txtUnit.Text <> "" _
        And txtTotal.Text <> "" And txtVendor.Text <> "" And rtbReason.Text <> "" Then
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

    Private Sub Business_Expense_Application___View_and_Edit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'When the form closes, subroutines will be run to repopulate the listviews on the overview form
        Business_Expense_Application___Overview.populateListViewPending()
        Business_Expense_Application___Overview.populateListViewApproved()
        'Closes form completely
        Me.Dispose()
    End Sub

    Private Sub SendEmail()
        'Disables the form
        Me.Enabled = False
        'Output to show that validation was successful.
        lblStatus.ForeColor = Color.ForestGreen
        lblStatus.Text = "Validation successful - Adding application to database and sending email for approval. Please wait a moment..."
        'Creates new message and declares Name variable
        Dim Email As New MailMessage()
        Dim Name As String = txtName.Text
        'Sets the email preferences
        Email.From = New MailAddress("shen.odinhealth@gmail.com")
        Email.[To].Add(txtEmail.Text)
        'Sets the content of the email and formats it
        Email.Subject = "Approval - Business Expense Application #" & lblTracking.Text
        Email.Body = "<H2>Business Expense Application for " & Name & " has been approved.</H2>" & "Date of Approval: " & DateTime.Today & _
            "<BR>Details for " & lblTracking.Text & "<BR><BR>Item Description: " & txtDescription.Text & " (Quantity: " & txtQuantity.Text & _
            ")<BR>Unit Price: $" & txtUnit.Text & " NZD<BR>Total Price: $" & txtTotal.Text & " NZD<BR>Vendor: " & _
            txtVendor.Text & "<BR><BR>Reason for Expense: " & rtbReason.Text & "<BR><BR>" & _
            "You have been approved for this business expense. You may now go ahead and purchase the relevant expense!"
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
        'Enables form
        Me.Enabled = True
    End Sub

    Private Sub TotalCost_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged, txtQuantity.TextChanged
        'Declares variables and sets them to the values in the relevant textboxes
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