Imports System.Data.OleDb

Public Class SearchBox
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub SearchBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Focuses on textbox control
        txtSearch.Select()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSearch.KeyDown
        'Calls subroutine of the search button when enter key is pressed in the search textbox
        If e.KeyCode = Keys.Enter Then
            Call btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Checks which search function has been passed over by the overview form and runs appropriate subroutine
        If lblFunction.Text = "TEA" Then
            TEA()
        ElseIf lblFunction.Text = "BEA" Then
            BEA()
        ElseIf lblFunction.Text = "TravelExpense" Then
            TravelExpense()
        ElseIf lblFunction.Text = "BusinessExpense" Then
            BusinessExpense()
        ElseIf lblFunction.Text = "Revenues" Then
            Revenues()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Completely closes the form
        Me.Dispose()
    End Sub

    Private Sub TEA()
        Dim Search As String = txtSearch.Text
        'Selects TrackingNumber field from the Accounts table 
        Dim cmd As New OleDbCommand("SELECT TrackingNumber FROM TEA WHERE TrackingNumber = @TrackingNumber;", connection)
        cmd.Parameters.AddWithValue("@TrackingNumber", Search)
        'Declares and initializes data reader which retrieves data under the TrackingNumber field
        Dim dr As OleDbDataReader
        connection.Open()
        dr = cmd.ExecuteReader
        'Checks if the TrackingNumber column contains the text in the Search textbox
        If dr.HasRows = False Then
            'Sets labels in StatusBox form for output to show no tracking number exists
            StatusBox.lblStatus.Text = "Record not found."
            StatusBox.lblDescription.Text = "A record for the tracking number does not exist in the database."
            StatusBox.ShowDialog()
            'Closes data reader and command
            dr.Close()
            cmd.Dispose()
            'Closes the connection and form
            connection.Close()
            Me.Dispose()
        Else
            'In the case if the TrackingNumber exists in the database. Closes data reader
            dr.Close()
            'Sets the tracking number on the view and edit form and opens it
            Travel_Application___View_and_Edit.lblTracking.Text = Search
            Travel_Application___View_and_Edit.ShowDialog()
            'Closes the connection and form
            connection.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub BEA()
        Dim Search As String = txtSearch.Text
        'Selects TrackingNumber field from the Accounts table 
        Dim cmd As New OleDbCommand("SELECT TrackingNumber FROM BEA WHERE TrackingNumber = @TrackingNumber;", connection)
        cmd.Parameters.AddWithValue("@TrackingNumber", Search)
        'Declares and initializes data reader which retrieves data under the TrackingNumber field
        Dim dr As OleDbDataReader
        connection.Open()
        dr = cmd.ExecuteReader
        'Checks if the TrackingNumber column contains the text in the Search textbox
        If dr.HasRows = False Then
            'Sets labels in StatusBox form for output to show no tracking number exists
            StatusBox.lblStatus.Text = "Record not found."
            StatusBox.lblDescription.Text = "A record for the tracking number does not exist in the database."
            StatusBox.ShowDialog()
            'Closes data reader, command, connection and form
            dr.Close()
            cmd.Dispose()
            connection.Close()
            Me.Dispose()
        Else
            'In the case if the TrackingNumber existed in the database closes datareader
            dr.Close()
            'Sets tracking number in the view and edit form and opens it
            Business_Expense_Applications___View_and_Edit.lblTracking.Text = Search
            Business_Expense_Applications___View_and_Edit.ShowDialog()
            'Closes connection and form
            connection.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub TravelExpense()
        Dim Search As String = txtSearch.Text
        'Selects TrackingNumber field from the Accounts table 
        Dim cmd As New OleDbCommand("SELECT TrackingNumber FROM [Travel Expenses] WHERE TrackingNumber = @TrackingNumber;", connection)
        cmd.Parameters.AddWithValue("@TrackingNumber", Search)
        'Declares and initializes data reader which retrieves data under the TrackingNumber field
        Dim dr As OleDbDataReader
        connection.Open()
        dr = cmd.ExecuteReader
        'Checks if the TrackingNumber column contains the text in the Search textbox
        If dr.HasRows = False Then
            'Sets labels in StatusBox form for output to show no tracking number exists
            StatusBox.lblStatus.Text = "Record not found."
            StatusBox.lblDescription.Text = "A record for the tracking number does not exist in the database."
            StatusBox.ShowDialog()
            'Closes data reader, command, connection and form
            dr.Close()
            cmd.Dispose()
            connection.Close()
            Me.Dispose()
        Else
            'In the case if the TrackingNumber exists in the database closes datareader
            dr.Close()
            'Sets tracking number in view and edit form and opens it
            Travel_Expense.txtTrackingNumber.Text = Search
            Travel_Expense.txtTrackingNumber.ReadOnly = True
            Travel_Expense.ShowDialog()
            'Closes connection and form
            connection.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub BusinessExpense()
        Dim Search As String = txtSearch.Text
        'Selects TrackingNumber field from the Accounts table 
        Dim cmd As New OleDbCommand("SELECT TrackingNumber FROM [Business Expenses] WHERE TrackingNumber = @TrackingNumber;", connection)
        cmd.Parameters.AddWithValue("@TrackingNumber", Search)
        'Declares and initializes data reader which retrieves data under the TrackingNumber field
        Dim dr As OleDbDataReader
        connection.Open()
        dr = cmd.ExecuteReader
        'Checks if the TrackingNumber column contains the text in the Search textbox
        If dr.HasRows = False Then
            'Sets labels in StatusBox form for output to show no tracking number exists
            StatusBox.lblStatus.Text = "Record not found."
            StatusBox.lblDescription.Text = "A record for the tracking number does not exist in the database."
            StatusBox.ShowDialog()
            'Closes data reader, command, connection and form
            dr.Close()
            cmd.Dispose()
            connection.Close()
            Me.Dispose()
        Else
            'In the case if the TrackingNumber exists in the database closes datareader
            dr.Close()
            'Sets tracking number in view and edit form and opens it
            Business_Expense___View_and_Edit.txtTrackingNumber.Text = Search
            Business_Expense___View_and_Edit.ShowDialog()
            'Closes connection and form
            connection.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub Revenues()
        Dim Search As String = txtSearch.Text
        'Selects TrackingNumber field from the Accounts table 
        Dim cmd As New OleDbCommand("SELECT PONumber FROM Revenues WHERE PONumber = @PONumber;", connection)
        cmd.Parameters.AddWithValue("@PONumber", Search)
        'Declares and initializes data reader which retrieves data under the TrackingNumber field
        Dim dr As OleDbDataReader
        connection.Open()
        dr = cmd.ExecuteReader
        'Checks if the PONumber column contains the text in the Search textbox
        If dr.HasRows = False Then
            'Sets labels in StatusBox form for output to show no tracking number exists
            StatusBox.lblStatus.Text = "Record not found."
            StatusBox.lblDescription.Text = "A record for PO number does not exist in the database."
            StatusBox.ShowDialog()
            'Closes data reader, command, connection and form
            dr.Close()
            cmd.Dispose()
            connection.Close()
            Me.Dispose()
        Else
            'In the case if the PONumber exists in the database closes datareader
            dr.Close()
            'Sets PONumber in view and edit form and opens it
            Revenues___View_and_Edit.txtPONumber.Text = Search
            Revenues___View_and_Edit.ShowDialog()
            'Closes connection and form
            connection.Close()
            Me.Dispose()
        End If
    End Sub
End Class