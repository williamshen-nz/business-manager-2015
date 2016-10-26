Imports System.Data.OleDb


Public Class Revenues___View_and_Edit
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Revenues___View_and_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the connection and declares a new OleDbCommand and Reader
        Dim PONumber As String = txtPONumber.Text
        connection.Open()
        Dim dt As New DataTable()
        'Fills datatable with data from the Revenues table
        Using da As New OleDbDataAdapter("SELECT * FROM Revenues WHERE PONumber = '" & PONumber & "'", connection)
            da.Fill(dt)
        End Using
        'Closes the connection
        connection.Close()
        'Sets values in textboxes and date time pickers to data in datatable
        txtInvoiceNumber.Text = dt.Rows(0)("InvoiceNumber").ToString
        dtpDate.Value = dt.Rows(0)("InvoiceDate")
        txtCustomer.Text = dt.Rows(0)("Customer").ToString
        txtSubtotal.Text = dt.Rows(0)("Subtotal")
        txtGST.Text = dt.Rows(0)("GST")
        txtTotal.Text = dt.Rows(0)("Total")
        PictureBox.Select()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Runs Validation function
        If Validation() Then
            'Declares the new OleDbCommand and gives it parameters
            Dim cmd As New OleDbCommand("UPDATE Revenues SET InvoiceNumber = ?, InvoiceDate = ?, Customer = ?, Subtotal = ?, " & _
                                        "GST = ?, Total = ? WHERE PONumber = '" & txtPONumber.Text & "'", connection)
            cmd.Parameters.AddWithValue("@p1", txtInvoiceNumber.Text)
            cmd.Parameters.AddWithValue("@p2", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("@p3", txtCustomer.Text)
            cmd.Parameters.AddWithValue("@p4", txtSubtotal.Text)
            cmd.Parameters.AddWithValue("@p5", txtGST.Text)
            cmd.Parameters.AddWithValue("@p6", txtTotal.Text)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful insert on Overview form
            Revenues___Overview.lblDataStatus.Text = "Record updated."
            Revenues___Overview.lblDataStatus.Visible = True
            'Closes form
            Me.Close()
        End If
    End Sub

    Private Function Validation()
        'Check if textboxes all contain text
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Displays MsgBox asking user to select Yes or No
        Dim Response = MsgBox("Are you sure you want to delete this Business Expense Application?", MsgBoxStyle.YesNo, "Delete Application")
        If Response = MsgBoxResult.Yes Then
            'Declares a new OleDbCommand which deletes the record if response is 'Yes'
            Dim PONumber As String = txtPONumber.Text
            Dim cmd As New OleDbCommand("DELETE FROM Revenues WHERE PONumber = '" & PONumber & "'", connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful insert on Overview form
            Revenues___Overview.lblDataStatus.Text = "Record deleted."
            Revenues___Overview.lblDataStatus.Visible = True
            'Closes form
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        'Closes form if user responds 'Yes'
        If Response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Revenues___View_and_Edit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Runs subroutine on overview form to repopulate the listview
        Revenues___Overview.populateListView()
        'Closes form completely
        Me.Dispose()
    End Sub

    Private Sub Calculation_TextChanged(sender As Object, e As EventArgs) Handles txtSubtotal.TextChanged, txtGST.TextChanged
        'Declares variables and assigns them values based on their relevant textboxes
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