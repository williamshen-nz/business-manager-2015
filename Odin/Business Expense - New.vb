Imports System.Data.OleDb

Public Class Business_Expense___New
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Business_Expense___New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enable textbox for Name if user is an admin
        If My.Settings.accountAdmin = True Then
            txtName.ReadOnly = False
        End If
        'Focuses on Tracking Number textbox
        txtTrackingNumber.Select()
    End Sub

    Private Sub txtTrackingNumber_TextChanged(sender As Object, e As EventArgs) Handles txtTrackingNumber.TextChanged
        'Clears the textboxes
        txtName.Text = ""
        txtDescription.Text = ""
        txtQuantity.Text = ""
        txtUnit.Text = ""
        txtTotal.Text = ""
        txtVendor.Text = ""
        Try
            'Opens the connection and declares a new OleDbCommand and Reader
            Dim TrackingNumber As String = txtTrackingNumber.Text
            connection.Open()
            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter("SELECT * FROM BEA WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
                da.Fill(dt)
            End Using
            'Closes the connection
            connection.Close()
            'Sets values in textboxes to data in datatable if it exists
            txtName.Text = dt.Rows(0)("FullName").ToString
            txtDescription.Text = dt.Rows(0)("ItemDescription").ToString
            txtQuantity.Text = dt.Rows(0)("Quantity").ToString
            txtUnit.Text = dt.Rows(0)("UnitPrice").ToString
            txtTotal.Text = dt.Rows(0)("TotalPrice").ToString
            txtVendor.Text = dt.Rows(0)("Vendor").ToString
        Catch
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Validation() Then
            Try
                'Declares the new OleDbCommand
                Dim cmd As New OleDbCommand("INSERT INTO [Business Expenses] (TrackingNumber, FullName, DateIncurred, Description, " & _
                                            "Quantity, UnitPrice, TotalPrice, ReimbursementRequired, PaymentMethod, Vendor, Reimbursed) " & _
                                            "VALUES (@TrackingNumber, @FullName, @DateIncurred, @Description, @Quantity, @UnitPrice, " & _
                                            "@TotalPrice, @ReimbursementRequired, @PaymentMethod, @Vendor, @Reimbursed)", connection)
                'Gives the parameters its values
                cmd.Parameters.AddWithValue("TrackingNumber", txtTrackingNumber.Text)
                cmd.Parameters.AddWithValue("FullName", txtName.Text)
                cmd.Parameters.AddWithValue("DateIncurred", dtpDate.Value.Date)
                cmd.Parameters.AddWithValue("Description", txtDescription.Text)
                cmd.Parameters.AddWithValue("Quantity", txtQuantity.Text)
                cmd.Parameters.AddWithValue("UnitPrice", txtUnit.Text)
                cmd.Parameters.AddWithValue("TotalPrice", txtTotal.Text)
                cmd.Parameters.AddWithValue("ReimbursementRequired", chkReimbursement.Checked)
                cmd.Parameters.AddWithValue("PaymentMethod", cboMethod.Text)
                cmd.Parameters.AddWithValue("Vendor", txtVendor.Text)
                'If reimbursement is not required then reimbursed is set to true
                If chkReimbursement.Checked = False Then
                    cmd.Parameters.AddWithValue("Reimbursed", True)
                Else : cmd.Parameters.AddWithValue("Reimbursed", False)
                End If
                'Opens database connection, executes query and closes the database
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                'Output to show successful updation on Overview form
                Business_Expense___Overview.lblDataStatus.Text = "Record successfully added."
                Business_Expense___Overview.lblDataStatus.ForeColor = Color.Green
                Business_Expense___Overview.lblDataStatus.Visible = True
                'Closes the form completely
                Me.Dispose()
            Catch
                'Closes the connection and shows output to user to show an error
                connection.Close()
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "A record for the tracking number already exists."
            End Try
        End If
    End Sub

    Private Function Validation()
        'Checks if all the textboxes or combobox contain text
        If txtTrackingNumber.Text <> "" And txtName.Text <> "" And txtDescription.Text <> "" And cboMethod.Text <> "" And _
            txtQuantity.Text <> "" And txtUnit.Text <> "" And txtTotal.Text <> "" And txtVendor.Text <> "" Then
            Return True
        Else
            'Output to show that one or more of the textboxes have not been filled.
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Please ensure all fields are filled out correctly."
            Return False
        End If
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        'Completely closes form if user selects 'Yes'
        If Response = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Business_Expense___New_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Completely closes form and runs subroutines to refresh the listviews
        Me.Dispose()
        Business_Expense___Overview.populateListViewPending()
        Business_Expense___Overview.populateListViewCompleted()
    End Sub

    Private Sub TotalCost_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged, txtQuantity.TextChanged
        'Declares variables and set them equal to the value in their respective textboxes
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

    Private Sub cboMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMethod.SelectedIndexChanged
        'Disables the checkbox when the payment method is company
        If cboMethod.Text = "Company" Then
            chkReimbursement.Checked = False
            chkReimbursement.Enabled = False
        ElseIf cboMethod.Text = "Personal" Then 'Checks the checkbox if payment method is personal
            chkReimbursement.Enabled = True
            chkReimbursement.Checked = True
        Else : chkReimbursement.Enabled = True
        End If
    End Sub
End Class