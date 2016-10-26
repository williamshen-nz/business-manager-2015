Imports System.Data.OleDb

Public Class Investment___Edit
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Investment___Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the connection and declares a new OleDbCommand and Reader
        Dim ID As String = txtID.Text
        connection.Open()
        Dim dt As New DataTable()
        'Fills datatable with data from the investments table
        Using da As New OleDbDataAdapter("SELECT * FROM Investments WHERE ID = " & ID, connection)
            da.Fill(dt)
        End Using
        'Closes the connection
        connection.Close()
        'Sets values in textboxes to data in datatable
        txtInvestor.Text = dt.Rows(0)("Investor").ToString
        dtpDate.Value = dt.Rows(0)("DateInvested")
        txtAmount.Text = dt.Rows(0)("InjectionAmount").ToString
        'Focuses the form
        PictureBox.Select()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Runs Validation function and sees if it returns true
        If Validation() Then
            'Declares the new OleDbCommand and gives it parameters
            Dim cmd As New OleDbCommand("UPDATE Investments SET Investor = ?, DateInvested = ?, InjectionAmount = ? " & _
                                        "WHERE ID =" & txtID.Text, connection)
            cmd.Parameters.AddWithValue("@p1", txtInvestor.Text)
            cmd.Parameters.AddWithValue("@p2", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("@p3", txtAmount.Text)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output on the main investment form to show successful updating
            Investment.lblDataStatus.Text = "Record successfully updated."
            Investment.lblDataStatus.ForeColor = Color.Green
            Investment.lblDataStatus.Visible = True
            'Closes the form
            Me.Close()
        End If
    End Sub

    Private Function Validation()
        'First checks if all the textboxes contain text
        If txtInvestor.Text <> "" And txtAmount.Text <> "" Then
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
        'Closes form if user selects 'Yes'
        If Response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Investment___Edit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Runs subroutine to repopulate the listview on the main investment form upon closing of this form
        Investment.populateListView()
        'Closes form completely
        Me.Dispose()
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub
End Class