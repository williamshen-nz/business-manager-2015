Imports System.Data.OleDb
Imports Odin.ListviewSort
Imports System.Drawing.Printing

Public Class Business_Expense___Overview
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Dim dgvPrinter As DataGridViewPrinter
    Private m_SortingColumn As ColumnHeader

    Private Sub Business_Expense___Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutines to populate listviews and combobox
        populateListViewPending()
        populateListViewCompleted()
        populateCBO()
        'Sets minimum value of the DateTo datepicker to the value of the DateFrom datepicker
        dtpDateTo.MinDate = dtpDateFrom.Value.Date
        'Sets font on the datagridview for printing
        DataGridView.Font = New Font("Segoe UI", 12)
        'Focuses on form
        PictureBox.Select()
    End Sub

    Public Sub populateListViewPending()
        'Clears and enables listview
        lstViewPending.Items.Clear()
        lstViewPending.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From [Business Expenses] WHERE Reimbursed = False ORDER BY TrackingNumber", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Business Expenses table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("TrackingNumber").ToString)
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("DateIncurred"))
            newitem.SubItems.Add(dr.Item("Description").ToString)
            newitem.SubItems.Add(dr.Item("TotalPrice"))
            lstViewPending.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
    End Sub

    Public Sub populateListViewCompleted()
        'Clears and enables listview
        lstViewCompleted.Items.Clear()
        lstViewCompleted.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From [Business Expenses] WHERE Reimbursed = True ORDER BY TrackingNumber", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Business Expenses table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("TrackingNumber").ToString)
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("DateIncurred"))
            newitem.SubItems.Add(dr.Item("Description").ToString)
            newitem.SubItems.Add(dr.Item("TotalPrice"))
            lstViewCompleted.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
    End Sub

    Private Sub populateCBO()
        'Declares DataSet and fills it up with data from Username Column in database
        Dim ds As New DataSet()
        Using da As New OleDbDataAdapter("SELECT FullName FROM Accounts", connection)
            da.Fill(ds, "FullName")
        End Using
        'Loads DataSet data into a DataView, sorts it then writes it to a DataTable
        Dim view As New DataView(ds.Tables("FullName"))
        view.Sort = "FullName"
        Dim sorted As DataTable = view.ToTable()
        'Populates comboboxes with contents of the new Datatable
        With cboName
            .DisplayMember = "FullName"
            .DataSource = view
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Checks if an item is selected in the listview or not
        If lstViewPending.SelectedItems.Count > 0 Then
            'Passes value of ID to Edit form and opens it
            Dim TrackingNumber As String = lstViewPending.SelectedItems(0).Text
            Business_Expense___View_and_Edit.txtTrackingNumber.Text = TrackingNumber
            Business_Expense___View_and_Edit.ShowDialog()
        ElseIf lstViewCompleted.SelectedItems.Count > 0 Then
            'Passes value of ID to Edit form and opens it
            Dim TrackingNumber As String = lstViewCompleted.SelectedItems(0).Text
            Business_Expense___View_and_Edit.txtTrackingNumber.Text = TrackingNumber
            Business_Expense___View_and_Edit.ShowDialog()
            'Output to user if nothing has been selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Opens search box form and passes relevant function name
        SearchBox.lblFunction.Text = "BusinessExpense"
        SearchBox.ShowDialog()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Opens the form for a new business expense
        Business_Expense___New.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Checks if either listviews has a line selected or not
        If lstViewPending.SelectedItems.Count > 0 Or lstViewCompleted.SelectedItems.Count > 0 Then
            'Displays a MsgBox asking user to confirm to delete the record
            Dim Response = MsgBox("Are you sure you want to delete this Business Expense Record?", MsgBoxStyle.YesNo,
                                  "Delete Business Expense Record")
            If Response = MsgBoxResult.Yes Then
                'Checks if an item is selected in the listview or not
                If lstViewPending.SelectedItems.Count > 0 Then
                    'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                    Dim pending As String = lstViewPending.SelectedItems(0).Text
                    Dim cmd As New OleDbCommand("DELETE FROM [Business Expenses] WHERE TrackingNumber = '" & pending & "'", connection)
                    'Opens connection, executes the command and closes the connection
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    'Repopulates the listview
                    populateListViewPending()
                    'Output to show successful deletion
                    lblDataStatus.Text = "Record successfully deleted."
                    lblDataStatus.ForeColor = Color.Green
                    lblDataStatus.Visible = True
                ElseIf lstViewCompleted.SelectedItems.Count > 0 Then
                    'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                    Dim completed As String = lstViewCompleted.SelectedItems(0).Text
                    Dim cmd As New OleDbCommand("DELETE FROM [Business Expenses] WHERE TrackingNumber = '" & completed & "'", connection)
                    'Opens connection, executes the command and closes the connection
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    'Repopulates the listview
                    populateListViewCompleted()
                    'Output to show successful deletion
                    lblDataStatus.Text = "Record successfully deleted."
                    lblDataStatus.ForeColor = Color.Green
                    lblDataStatus.Visible = True
                End If
            End If
            'Output if user has not selected a line from either of the listviews
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If chkFilterDate.Checked = True Or chkFilterName.Checked = True Or chkCompleted.Checked = True Or
            chkPending.Checked = True Or chkAll.Checked = True Then
            'Declares cmd as OleDbCommand, x as a counter and if a checkbox it checked as a relevant 2^i value
            Dim cmd As OleDbCommand
            'Declares strings to be used in OleDbCommand
            Dim query As String = "SELECT TrackingNumber, FullName, Format(DateIncurred, 'dd/mm/yy'), Description & ' x' & Quantity, Vendor, " & _
                "'$' & TotalPrice AS Total, Reimbursed From [Business Expenses] WHERE "
            Dim dateQuery As String = "(DateIncurred BETWEEN @DateFrom AND @DateTo) "
            Dim name As String = "FullName = @FullName "
            Dim reimbursed As String = "Reimbursed = @Reimbursed "
            Dim order As String = "ORDER BY DateIncurred"
            Dim x As Integer = 0
            'Used for the different combinations
            If chkFilterDate.Checked = True Then x = 1
            If chkFilterName.Checked = True Then x = x + 2
            If chkCompleted.Checked = True Then x = x + 4
            If chkPending.Checked = True Then x = x + 8
            If chkAll.Checked = True Then x = 16
            'Selects the different cases. 15 possibilities + 1 possibility for chkAll
            Select Case x
                'Declares relevant OleDbCommands and gives them the parameters
                Case 1 'Date only
                    cmd = New OleDbCommand(query & dateQuery & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                Case 2 'Name only
                    cmd = New OleDbCommand(query & name & order, connection)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                Case 3 'Date and Name
                    cmd = New OleDbCommand(query & dateQuery & "AND " & name & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                Case 4 'Completed only
                    cmd = New OleDbCommand(query & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@Reimbursed", True)
                Case 5 'Date and Completed
                    cmd = New OleDbCommand(query & dateQuery & "AND " & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                    cmd.Parameters.AddWithValue("@Reimbursed", True)
                Case 6 'Name and Completed
                    cmd = New OleDbCommand(query & name & "AND " & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                    cmd.Parameters.AddWithValue("@Reimbursed", True)
                Case 7 'Date, Name and Completed
                    cmd = New OleDbCommand(query & dateQuery & "AND " & name & "AND " & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                    cmd.Parameters.AddWithValue("@Reimbursed", True)
                Case 8 'Pending only
                    cmd = New OleDbCommand(query & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@Reimbursed", False)
                Case 9 'Date and Pending
                    cmd = New OleDbCommand(query & dateQuery & "AND " & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                    cmd.Parameters.AddWithValue("@Reimbursed", False)
                Case 10 'Name and Pending
                    cmd = New OleDbCommand(query & name & "AND " & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                    cmd.Parameters.AddWithValue("@Reimbursed", False)
                Case 11 'Date, Name and Pending
                    cmd = New OleDbCommand(query & dateQuery & "AND " & name & "AND " & reimbursed & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                    cmd.Parameters.AddWithValue("@Reimbursed", False)
                Case 12 'Completed and Pending (same as everything)
                    cmd = New OleDbCommand(query.Substring(0, query.Length - 6) & order, connection)
                Case 13 'Date, Completed and Pending (same as Date only)
                    cmd = New OleDbCommand(query & dateQuery & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                Case 14 'Name, Completed and Pending (same as Name only)
                    cmd = New OleDbCommand(query & name & order, connection)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                Case 15 'Date, Name, Completed, Pending (same as Date and Name only)
                    cmd = New OleDbCommand(query & dateQuery & "AND " & name & order, connection)
                    cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                Case 16 'All checkbox is checked
                    cmd = New OleDbCommand(query.Substring(0, query.Length - 6) & order, connection)
            End Select
            'Declares data adapter. Declares datatable and fills it
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            'Changes datatype of Reimbursed column if print all data is checked
            If chkAll.Checked = True Then
                da.FillSchema(dt, SchemaType.Source)
                dt.Columns(6).DataType = GetType(String)
                da.Fill(dt)
            Else : da.Fill(dt)
            End If
            'Displays data on datagridview and sets the column names
            DataGridView.DataSource = dt
            With DataGridView
                .Columns(0).HeaderCell.Value = "Tracking No."
                .Columns(1).HeaderCell.Value = "Name"
                .Columns(2).HeaderCell.Value = "Date"
                .Columns(3).HeaderCell.Value = "Description & Qty"
                .Columns(5).HeaderCell.Value = "Total"
            End With
            'Checks if datagridview is empty (i.e. no data found)
            If DataGridView.Rows.Count <> 1 Then
                'If user checked checkbox to calculate total
                If chkTotal.Checked = True Then
                    'Calculates total for the Total column of the datagridview
                    Dim totalDec As Decimal = 0
                    For i = 0 To DataGridView.Rows.Count - 1
                        totalDec = totalDec + DataGridView.Rows(i).Cells(5).Value
                    Next i
                    Dim totalStr As String = "$" & CStr(totalDec)
                    'Adds new row to DataTable to update the datagridview. Sets values in rows then adds
                    Dim newRow As DataRow = dt.NewRow
                    For i = 0 To 3
                        newRow.Item(i) = ""
                    Next
                    newRow.Item(4) = "TOTAL ="
                    newRow.Item(5) = totalStr
                    If chkAll.Checked = True Then
                        newRow.Item(6) = ""
                    Else
                        'Checking if all the records have been reimbursed or not
                        Dim rBool As Boolean = True
                        'Loops through datagridview to find any False reimbursed values
                        For i = 0 To DataGridView.Rows.Count - 2
                            If DataGridView.Rows(i).Cells(6).Value = False Then
                                rBool = False
                            End If
                        Next i
                        'Sets value for Reimbrused field
                        newRow.Item(6) = rBool
                    End If
                    'Adds the row to the datatable and updates the datagridview
                    dt.Rows.Add(newRow)
                End If
                'Runs function to set up for printing
                If SetupThePrinting("Business Expenses") Then
                    'Declares print preview dialog and opens it
                    Dim ppd As PrintPreviewDialog = New PrintPreviewDialog()
                    ppd.Document = pntDocument
                    ppd.Height = Screen.PrimaryScreen.Bounds.Height / 1.5
                    ppd.Width = Screen.PrimaryScreen.Bounds.Width / 2.5
                    ppd.FindForm().StartPosition = FormStartPosition.CenterScreen
                    ppd.Text = "Business Expenses"
                    ppd.ShowDialog()
                    'Output to user to show success
                    lblDataStatus.ForeColor = Color.Green
                    lblDataStatus.Text = "Successful print operation."
                End If
            Else
                'Output if no data was found
                lblFilterStatus.Visible = True
                lblFilterStatus.ForeColor = Color.Red
                lblFilterStatus.Text = "No data found."
            End If
        Else
            'Feedback to show none of the checkboxes where checked
            lblFilterStatus.Text = "Please select the filters."
            lblFilterStatus.ForeColor = Color.Red
            lblFilterStatus.Visible = True
        End If
    End Sub

    Private Sub pntDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pntDocument.PrintPage
        'Checks if there are any more pages
        Dim more As Boolean = dgvPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub

    Private Function SetupThePrinting(ByVal title As String) As Boolean
        'Declares print dialog and sets properties
        Dim pd As PrintDialog = New PrintDialog()
        pd.AllowCurrentPage = False
        pd.AllowPrintToFile = False
        pd.AllowSelection = False
        pd.AllowSomePages = False
        pd.PrintToFile = False
        pd.ShowHelp = False
        pd.ShowNetwork = False
        'Function returns false if user cancels
        If pd.ShowDialog() <> DialogResult.OK Then
            Return False
        End If
        'Sets properties for the print document and sets the data
        pntDocument.DocumentName = "Business Expense"
        pntDocument.PrinterSettings = pd.PrinterSettings
        pntDocument.DefaultPageSettings = pd.PrinterSettings.DefaultPageSettings
        pntDocument.DefaultPageSettings.Margins = New Margins(20, 20, 20, 20)
        dgvPrinter = New DataGridViewPrinter(DataGridView, pntDocument, True, True, title, New Font("Segoe UI", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Return True
    End Function

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        'Unchecks other checkboxes if all checkbox is checked
        If chkAll.Checked = True Then
            chkFilterDate.Checked = False
            chkFilterName.Checked = False
            chkCompleted.Checked = False
            chkPending.Checked = False
            chkAll.Checked = True
        End If
    End Sub

    Private Sub chkOthers_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterDate.CheckedChanged, chkFilterName.CheckedChanged, _
        chkCompleted.CheckedChanged, chkPending.CheckedChanged
        'Sets the checkbox for All to false if any of the other checkboxes have their checks changed
        chkAll.Checked = False
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        'Sets minimum value of the DateTo datepicker to the value of the DateFrom datepicker
        dtpDateTo.MinDate = dtpDateFrom.Value.Date
    End Sub

    Private Sub Business_Expense___Overview_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Shows the main menu upon the closing of the form
        MainMenu.Show()
    End Sub

    Private Sub lstViewPending_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstViewPending.ColumnClick
        'Get the new sorting column to be sorted
        Dim new_sorting_column As ColumnHeader = lstViewPending.Columns(e.Column)
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
        lstViewPending.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        lstViewPending.Sort()
    End Sub

    Private Sub lstViewApproved_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstViewCompleted.ColumnClick
        'Get the new sorting column to be sorted
        Dim new_sorting_column As ColumnHeader = lstViewCompleted.Columns(e.Column)
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
        lstViewCompleted.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        lstViewCompleted.Sort()
    End Sub
End Class