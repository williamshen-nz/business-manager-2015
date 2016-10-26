Imports System.Data.OleDb
Imports Odin.ListviewSort

Public Class Revenues___Overview
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Private m_SortingColumn As ColumnHeader

    Private Sub Revenues___Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutine to populate the listview
        populateListView()
        'Focuses the form
        PictureBox.Select()
        'Sets the minimum date of the DateTo date picker to the value of the DateFrom date picker
        dtpDateTo.MinDate = dtpDateFrom.Value.Date
    End Sub

    Public Sub populateListView()
        'Clears and enables the listview
        lstView.Items.Clear()
        lstView.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From Revenues ORDER BY InvoiceDate", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("PONumber").ToString)
            newitem.SubItems.Add(dr.Item("InvoiceNumber").ToString)
            newitem.SubItems.Add(dr.Item("InvoiceDate"))
            newitem.SubItems.Add(dr.Item("Customer").ToString)
            newitem.SubItems.Add(dr.Item("Total"))
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
    End Sub
   
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Checks if an item is selected in the listview or not
        If lstView.SelectedItems.Count > 0 Then
            'Displays a MsgBox asking user to confirm to delete the record
            Dim Response = MsgBox("Are you sure you want to delete this Revenue record?", MsgBoxStyle.YesNo, "Delete Record")
            If Response = MsgBoxResult.Yes Then
                'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                Dim PONumber As String = lstView.SelectedItems(0).Text
                Dim cmd As New OleDbCommand("DELETE FROM Revenues WHERE PONumber = '" & PONumber & "'", connection)
                'Opens connection, executes the command and closes the connection
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                'Output to show success
                lblDataStatus.ForeColor = Color.Green
                lblDataStatus.Text = "Record deleted."
                'Repopulates the listview
                populateListView()
            End If
            'Outputs error if user has not selected an item in the listview
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Shows the form for a new revenue record
        Revenues___New.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Checks if an item is selected in the listview or not
        If lstView.SelectedItems.Count > 0 Then
            'Passes value of ID to Edit form
            Dim PONumber As String = lstView.SelectedItems(0).Text
            Revenues___View_and_Edit.txtPONumber.Text = PONumber
            Revenues___View_and_Edit.ShowDialog()
            'Output error if no item is selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub Revenues___Overview_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Opens the main menu form upon closing of this form
        MainMenu.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Opens SearchBox form and passes appropriate text in textboxes
        SearchBox.lblStatus.Text = "Please enter the PO Number."
        SearchBox.lblFunction.Text = "Revenues"
        SearchBox.ShowDialog()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        'Checks if the filterdate checkbox is checked or not
        If chkFilterDate.Checked = True Then
            'Clears the listview
            lstView.Items.Clear()
            'Opens connection, declares OleDbCommand and OleDbReader and executes
            connection.Open()
            Dim cmd As New OleDbCommand("SELECT * From Revenues WHERE InvoiceDate BETWEEN @DateFrom AND @DateTo " & _
                                        "ORDER BY InvoiceDate", connection)
            cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
            cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            'Loops the Revenues table of the database and adds each record to a new ListViewItem
            Do While dr.Read()
                Dim newitem As New ListViewItem(dr.Item("PONumber").ToString)
                newitem.SubItems.Add(dr.Item("InvoiceNumber").ToString)
                newitem.SubItems.Add(dr.Item("InvoiceDate"))
                newitem.SubItems.Add(dr.Item("Customer").ToString)
                newitem.SubItems.Add(dr.Item("Total"))
                lstView.Items.Add(newitem)
            Loop
            'Closes the connection
            connection.Close()
            'Checks if any data was found
            If lstView.Items.Count = 0 Then
                'Output to show that no data was found
                lblFilterStatus.Text = "No data found."
                lblFilterStatus.ForeColor = Color.Red
                lblFilterStatus.Visible = True
                populateListView()
            ElseIf lstView.Items.Count <> 0 Then
                'Output to show that data was successfully filtered
                lblFilterStatus.Text = "Data successfully filtered."
                lblFilterStatus.ForeColor = Color.Green
                lblFilterStatus.Visible = True
            End If
        Else
            'Feedback to show that the checkbox was not checked
            lblFilterStatus.Text = "Please select the filter."
            lblFilterStatus.ForeColor = Color.Red
            lblFilterStatus.Visible = True
        End If
    End Sub

    Private Sub btnFilterClear_Click(sender As Object, e As EventArgs) Handles btnFilterClear.Click
        'Runs subroutine to clear and populate the listview
        populateListView()
        chkFilterDate.Checked = False
        dtpDateFrom.Value = DateTime.Today
        dtpDateTo.Value = DateTime.Today
        lblFilterStatus.Visible = False
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        'Sets the minimum DateTo datepicker to the value of the DateFrom datepicker 
        dtpDateTo.MinDate = dtpDateFrom.Value.Date
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