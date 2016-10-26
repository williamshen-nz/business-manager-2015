Imports System.Data.OleDb
Imports Odin.ListviewSort

Public Class Investment
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Private m_SortingColumn As ColumnHeader

    Private Sub Investment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutine to populate the listview and focuses the form appropriately
        populateListView()
        PictureBox.Select()
    End Sub

    Public Sub populateListView()
        'Clears and enables the listview
        lstView.Items.Clear()
        lstView.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From Investments ORDER BY ID", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("ID").ToString)
            newitem.SubItems.Add(dr.Item("Investor").ToString)
            newitem.SubItems.Add(dr.Item("DateInvested"))
            newitem.SubItems.Add(dr.Item("InjectionAmount").ToString)
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Checks if an item is selected in the listview or not
        If lstView.SelectedItems.Count > 0 Then
            'Passes value of ID to Edit form and opens it
            Dim ID As String = lstView.SelectedItems(0).Text
            Investment___Edit.txtID.Text = ID
            Investment___Edit.ShowDialog()
            'Output error if no item is selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Checks if an item has been selected or not
        If lstView.SelectedItems.Count > 0 Then
            'Displays a MsgBox asking user to confirm to delete the record
            Dim Response = MsgBox("Are you sure you want to delete this Investment record?", MsgBoxStyle.YesNo,
                                  "Delete Record")
            If Response = MsgBoxResult.Yes Then
                'Checks if an item is selected in the listview or not if user response is 'Yes'
                If lstView.SelectedItems.Count > 0 Then
                    'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                    Dim ID As String = lstView.SelectedItems(0).Text
                    Dim cmd As New OleDbCommand("DELETE FROM Investments WHERE ID = " & ID, connection)
                    'Opens connection, executes the command and closes the connection
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    'Repopulates the listview
                    populateListView()
                    'Updates label to show status
                    lblDataStatus.Text = "Record successfully deleted."
                    lblDataStatus.ForeColor = Color.Green
                    lblDataStatus.Visible = True
                End If
            End If
            'Output error if no record has been selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Runs validation function and checks if it returns true 
        If Validation() Then
            'Declares the new OleDbCommand
            Dim cmd As New OleDbCommand("INSERT INTO Investments (Investor, DateInvested, InjectionAmount) " & _
                                        "VALUES (@Investor, @DateInvested, @InjectionAmount)", connection)
            'Gives the parameters its values
            cmd.Parameters.AddWithValue("Investor", txtInvestor.Text)
            cmd.Parameters.AddWithValue("DateInvested", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("InjectionAmount", txtAmount.Text)
            'Opens database connection, executes query and closes the database
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show record has been added and repopulates listview
            lblAddStatus.ForeColor = Color.Green
            lblAddStatus.Text = "Investment information added into database."
            populateListView()
            'Resets controls
            txtInvestor.Text = ""
            dtpDate.Value = DateTime.Today
            txtAmount.Text = ""
        End If
    End Sub

    Private Function Validation()
        'Checks if all the textboxes contain text
        If txtInvestor.Text <> "" And txtAmount.Text <> "" Then
            Return True
        Else
            'Output to show that one or more of the textboxes have not been filled.
            lblAddStatus.ForeColor = Color.Red
            lblAddStatus.Text = "Please ensure all fields are filled out correctly."
            Return False
        End If
    End Function

    Private Sub Investment_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Opens the main menu form upon closing of the investment form
        MainMenu.Show()
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
       'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub

    Private Sub lstView_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstView.ColumnClick
        'Get the new sorting column to be sorted
        Dim new_sorting_column As ColumnHeader = lstView.Columns(e.Column)
        'Find out the sorting order
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            'Sort column by ascending order
            sort_order = SortOrder.Ascending
        Else
            'Checks if sorting column is the same one
            If new_sorting_column.Equals(m_SortingColumn) Then
                'If it is the same column then the sorting order is switched around
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                'Sort by ascending value
                sort_order = SortOrder.Ascending
            End If
            'Removes the old sort column indicator
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If
        'Displays the new sorting column indicator
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If
        'Creates the comparer and sorts the listview accordingly
        lstView.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        lstView.Sort()
    End Sub
End Class