Imports System.Data.OleDb

Public Class Revenues___New
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Revenues___New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Focuses the PO Number textbox
        txtPONumber.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Runs Validation function
        If Validation() Then
            'Try to add the new record into the Revenues table
            Try
                'Declares the new OleDbCommand
                Dim cmd As New OleDbCommand("INSERT INTO Revenues (PONumber, InvoiceNumber, InvoiceDate, Customer, Subtotal, " & _
                                            "GST, Total) VALUES (@PONumber, @InvoiceNumber, @InvoiceDate, @Customer, " & _
                                            "@Subtotal, @GST, @Total)", connection)
                'Gives the parameters its values
                cmd.Parameters.AddWithValue("PONumber", txtPONumber.Text)
                cmd.Parameters.AddWithValue("InvoiceNumber", txtInvoiceNumber.Text)
                cmd.Parameters.AddWithValue("InvoiceDate", dtpDate.Value.Date)
                cmd.Parameters.AddWithValue("Customer", txtCustomer.Text)
                cmd.Parameters.AddWithValue("Subtotal", txtSubtotal.Text)
                cmd.Parameters.AddWithValue("GST", txtGST.Text)
                cmd.Parameters.AddWithValue("Total", txtTotal.Text)
                'Opens database connection, executes query and closes the database
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                'Feedback to show successful insertion
                lblStatus.ForeColor = Color.Green
                lblStatus.Text = "Revenue successfully saved."
                'Output to show successful insert on Overview form and closes form completely
                Revenues___Overview.lblDataStatus.Text = "Record added."
                Revenues___Overview.lblDataStatus.Visible = True
                Me.Dispose()
            Catch
                'In the case where the OleDbCommand could not be executed, closes the connection
                connection.Close()
                'Output to show there is an error
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "A record for the PO Number already exists."
            End Try
        End If
    End Sub

    Private Function Validation()
        'Checks if textboxes all contain text
        If txtPONumber.Text <> "" And txtInvoiceNumber.Text <> "" And txtCustomer.Text <> "" And _
            txtSubtotal.Text <> "" And txtGST.Text <> "" And txtTotal.Text <> "" Then
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
        'Closes form completely if user clicks 'Yes'
        If Response = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Revenues___New_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Closes form completely and runs subroutine to populate the listview on the overview form
        Me.Dispose()
        Revenues___Overview.populateListView()
    End Sub

    Private Sub Calculation_TextChanged(sender As Object, e As EventArgs) Handles txtSubtotal.TextChanged, txtGST.TextChanged
        'Declares and gives values to the variables from their relevant textboxes
        Dim subtotal, GST, total As Double
        subtotal = Val(txtSubtotal.Text)
        GST = Val(txtGST.Text)
        'Adds value in Subtotal textbox and GST to give the total    
        total = subtotal + GST
        txtTotal.Text = total
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubtotal.KeyPress,
        txtGST.KeyPress, txtTotal.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub
End Class