Imports System.Data.OleDb

Public Class Business_Expense___View_and_Edit
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Business_Expense___View_and_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the connection and declares a new OleDbCommand and Reader
        Dim TrackingNumber As String = txtTrackingNumber.Text
        connection.Open()
        Dim dt As New DataTable()
        'Fills the datatable with the appropriate data from the Business Expenses table
        Using da As New OleDbDataAdapter("SELECT * FROM [Business Expenses] WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
            da.Fill(dt)
        End Using
        'Closes the connection
        connection.Close()
        'Sets values in textboxes, comboboxes and checkboxes to data in datatable
        txtName.Text = dt.Rows(0)("FullName").ToString
        dtpDate.Value = dt.Rows(0)("DateIncurred")
        txtVendor.Text = dt.Rows(0)("Vendor").ToString
        cboMethod.Text = dt.Rows(0)("PaymentMethod").ToString
        txtDescription.Text = dt.Rows(0)("Description").ToString
        txtQuantity.Text = dt.Rows(0)("Quantity").ToString
        txtUnit.Text = dt.Rows(0)("UnitPrice").ToString
        txtTotal.Text = dt.Rows(0)("TotalPrice").ToString
        chkReimbursementRequired.Checked = dt.Rows(0)("ReimbursementRequired")
        chkReimbursed.Checked = dt.Rows(0)("Reimbursed")
        'Checks if the user is an admin or not
        If My.Settings.accountAdmin = True Then
            'Enables the 'name' textbox and the checkbox for reimbursed
            txtName.ReadOnly = False
            chkReimbursed.Enabled = True
        End If
        'Focuses on form
        PictureBox.Select()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Validation() Then
            'Declares the new OleDbCommand and gives it parameters
            Dim cmd As New OleDbCommand("UPDATE [Business Expenses] SET FullName = ?, DateIncurred = ?, Description = ?, Quantity = ?, " & _
                                        "UnitPrice = ?, TotalPrice = ?, ReimbursementRequired = ?, PaymentMethod = ?, Vendor = ?," & _
                                        "Reimbursed = ? WHERE TrackingNumber = '" & txtTrackingNumber.Text & "'", connection)
            cmd.Parameters.AddWithValue("@p1", txtName.Text)
            cmd.Parameters.AddWithValue("@p2", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("@p3", txtDescription.Text)
            cmd.Parameters.AddWithValue("@p4", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@p5", txtUnit.Text)
            cmd.Parameters.AddWithValue("@p6", txtTotal.Text)
            cmd.Parameters.AddWithValue("@p7", chkReimbursementRequired.Checked)
            cmd.Parameters.AddWithValue("@p8", cboMethod.Text)
            cmd.Parameters.AddWithValue("@p9", txtVendor.Text)
            cmd.Parameters.AddWithValue("@p10", chkReimbursed.Checked)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful updation on Overview form and closes form
            Business_Expense___Overview.lblDataStatus.Text = "Record successfully updated."
            Business_Expense___Overview.lblDataStatus.ForeColor = Color.Green
            Business_Expense___Overview.lblDataStatus.Visible = True
            Me.Close()
        End If
    End Sub

    Private Function Validation()
        'First checks if all the textboxes and comboboxes contain text
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Opens a Yes/No messagebox asking user to confirm to delete the record
        Dim Response = MsgBox("Are you sure you want to delete this Business Expense Application?", MsgBoxStyle.YesNo, "Delete Application")
        'Code if user selects yes
        If Response = MsgBoxResult.Yes Then
            'Declares a new OleDbCommand which deletes the record
            Dim TrackingNumber As String = txtTrackingNumber.Text
            Dim cmd As New OleDbCommand("DELETE FROM [Business Expenses] WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful updation on Overview form
            Business_Expense___Overview.lblDataStatus.Text = "Record successfully deleted."
            Business_Expense___Overview.lblDataStatus.ForeColor = Color.Green
            Business_Expense___Overview.lblDataStatus.Visible = True
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        'Closes the form is user responds yes
        If Response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Business_Expense___View_and_Edit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'When this form closes, subroutines will be run to repopulate the listviews in the overview form
        Business_Expense___Overview.populateListViewPending()
        Business_Expense___Overview.populateListViewCompleted()
        'Closes form completely
        Me.Dispose()
    End Sub

    Private Sub TotalCost_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged, txtQuantity.TextChanged
        'Declares variables and initialises them to the values in the relevant textboxes
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