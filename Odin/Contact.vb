Imports System.Net.Mail

Public Class Contact
    Private Sub rtbMessage_TextChanged(sender As Object, e As EventArgs) Handles rtbMessage.TextChanged
        'Retrieves the length of the characters inside the RichTextBox and updates the label
        Dim number As Integer = rtbMessage.TextLength
        lblCounter.Text = number & "/1000"
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Runs the validation subroutine and sees if it returns true
        If Validation() Then
            'Tries sending an email
            Try
                'Runs subroutine to send an email
                SendEmail()
            Catch ex As Exception
                'Output to show an error if there is an error sending the email
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Something went wrong. The email could not be sent, please try again later."
            End Try
        End If
    End Sub

    Private Function Validation()
        'Checks that the textboxes and richtextbox contain text and the checkbox is checked
        If txtName.Text <> "" And txtEmail.Text <> "" And rtbMessage.Text <> "" And chkSpam.Checked = True Then
            'Validates the email address. Throws error if the address is in the wrong format
            Try
                'The function returns true if email address is valid
                Dim Email As New MailAddress(txtEmail.Text)
                Return True
            Catch
                'Output to show that email address format was incorrect.
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Please check that the email address you entered was in a correct format."
                Return False
            End Try
        Else
            'Outputs to user that they have not filled in all necessary fields
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Please ensure that all fields are filled out and the 'checkbox' is checked."
            Return False
        End If
    End Function

    Private Sub SendEmail()
        'Creates new message
        Dim Email As New MailMessage()
        'Sets the email preferences
        Email.From = New MailAddress(txtEmail.Text)
        Email.[To].Add("w.shen+odin@kings.net.nz")
        'Sets the content of the email
        Email.Subject = "Odin Support Request from " & txtName.Text
        Email.Body = "<H2>Support Request for 'Odin Health Business Manager'</H2>" & "Time Submitted: " & _
           DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & "<BR>Name: " & txtName.Text & "<BR>Email Address: " & _
           txtEmail.Text & "<BR><BR><u>Problem Description:</u><BR>" & rtbMessage.Text
        Email.IsBodyHtml = True
        'Sets the server to send the email
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New Net.NetworkCredential("shen.odinhealth@gmail.com", "c9dMy6RKPr")
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Host = "smtp.gmail.com"
        'Sends the email and shows feedback
        disableControls()
        smtp.Send(Email)
        lblStatus.ForeColor = Color.Green
        lblStatus.Text = "Your message has been successfully sent. Thank You."
        'Resets controls
        txtName.Focus()
        resetControls()
    End Sub

    Private Sub disableControls()
        'Disables controls on form.
        txtName.Enabled = False
        txtEmail.Enabled = False
        rtbMessage.Enabled = False
        chkSpam.Enabled = False
        btnSend.Enabled = False
    End Sub

    Private Sub resetControls()
        'Enables and clears controls and textboxes
        txtName.Enabled = True
        txtName.Text = ""
        txtEmail.Enabled = True
        txtEmail.Text = ""
        rtbMessage.Enabled = True
        rtbMessage.Text = ""
        chkSpam.Checked = False
        chkSpam.Enabled = True
        btnSend.Enabled = True
    End Sub

    Private Sub Contact_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Closes form completely upon closing
        Me.Dispose()
    End Sub
End Class