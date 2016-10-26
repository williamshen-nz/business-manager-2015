Imports System.Data.OleDb
Imports Odin.ListviewSort
Imports System.Drawing.Printing

Public Class Wages___Overview
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Dim dgvPrinter As DataGridViewPrinter
    Private m_SortingColumn As ColumnHeader

    Private Sub Wages___Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutines to populate the listview and the combobox
        populateListView()
        populateCBO()
        'Sets minimum value of the DateTo datepicker to the value of the DateFrom datepicker
        dtpDateTo.MinDate = dtpDateFrom.Value.Date
        'Sets font on the datagridview for printing
        DataGridView.Font = New Font("Segoe UI", 11.5)
        'Focuses form
        PictureBox.Select()
    End Sub

    Public Sub populateListView()
        'Clears and enables the listview
        lstView.Items.Clear()
        lstView.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From Wages ORDER BY ID", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("ID").ToString)
            newitem.SubItems.Add(dr.Item("StartDate"))
            newitem.SubItems.Add(dr.Item("EndDate"))
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("DatePaid"))
            newitem.SubItems.Add(dr.Item("NetPay").ToString)
            lstView.Items.Add(newitem)
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Opens the form for a new wage payment
        Wages___New.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Checks if an item is selected in the listview 
        If lstView.SelectedItems.Count > 0 Then
            'Displays a MsgBox asking user to confirm to delete the record
            Dim Response = MsgBox("Are you sure you want to delete this Wage Payment?", MsgBoxStyle.YesNo, "Delete Wage Payment")
            If Response = MsgBoxResult.Yes Then
                'Checks if an item is selected in the listview or not
                'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                Dim ID As String = lstView.SelectedItems(0).Text
                Dim cmd As New OleDbCommand("DELETE FROM Wages WHERE ID = " & ID, connection)
                'Opens connection, executes the command and closes the connection
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                'Output to show success
                lblDataStatus.Visible = True
                lblDataStatus.ForeColor = Color.Green
                lblDataStatus.Text = "Record successfully deleted."
                'Repopulates the listview
                populateListView()
            End If
            'Output to tell user to select a record
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Checks if an item is selected in the listview or not
        If lstView.SelectedItems.Count > 0 Then
            'Passes value of ID to Edit form and opens it
            Dim ID As String = lstView.SelectedItems(0).Text
            Wages___View_and_Edit.txtID.Text = ID
            Wages___View_and_Edit.ShowDialog()
            'Output to tell user to select a record
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnFilterClear_Click(sender As Object, e As EventArgs) Handles btnFilterClear.Click
        'Runs subroutine to clear and populate the listview
        populateListView()
        populateCBO()
        chkFilterDate.Checked = False
        chkFilterName.Checked = False
        dtpDateFrom.Value = DateTime.Today
        dtpDateTo.Value = DateTime.Today
        lblFilterStatus.Visible = False
    End Sub

    Private Sub Wages___Overview_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Opens main menu form upon closing of this form
        MainMenu.Show()
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        'Sets minimum value of the DateTo datepicker to the value of the DateFrom datepicker
        dtpDateTo.MinDate = dtpDateFrom.Value.Date
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        'Checks which checkboxes have been checked and runs subroutines accordingly
        If chkFilterDate.Checked = True And chkFilterName.Checked = True Then
            filterDateName()
        ElseIf chkFilterDate.Checked = True Then
            filterDate()
        ElseIf chkFilterName.Checked = True Then
            filterName()
        Else
            'Feedback to show none of the checkboxes where checked
            lblFilterStatus.Text = "Please select the filters."
            lblFilterStatus.ForeColor = Color.Red
            lblFilterStatus.Visible = True
        End If
    End Sub

    Private Sub filterDateName()
        'Clears the listview
        lstView.Items.Clear()
        'Opens connection, declares OleDbCommand and OleDbReader and executes
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From Wages WHERE (StartDate BETWEEN @DateFrom AND @DateTo " & _
                                    "OR EndDate BETWEEN @DateFrom AND @DateTo) AND FullName = @FullName ORDER BY ID", connection)
        cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
        cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
        cmd.Parameters.AddWithValue("@FullName", cboName.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("ID").ToString)
            newitem.SubItems.Add(dr.Item("StartDate"))
            newitem.SubItems.Add(dr.Item("EndDate"))
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("DatePaid"))
            newitem.SubItems.Add(dr.Item("NetPay").ToString)
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection and runs subroutine to check if data was found
        connection.Close()
        filterCheck()
    End Sub

    Private Sub filterDate()
        'Clears the listview
        lstView.Items.Clear()
        'Opens connection, declares OleDbCommand and OleDbReader and executes
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From Wages WHERE StartDate BETWEEN @DateFrom AND @DateTo " & _
                                    "OR EndDate BETWEEN @DateFrom AND @DateTo ORDER BY ID", connection)
        cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.Date)
        cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.Date)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("ID").ToString)
            newitem.SubItems.Add(dr.Item("StartDate"))
            newitem.SubItems.Add(dr.Item("EndDate"))
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("DatePaid"))
            newitem.SubItems.Add(dr.Item("NetPay").ToString)
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection and runs subroutine to check if data was found
        connection.Close()
        filterCheck()
    End Sub

    Private Sub filterName()
        'Clears the listview
        lstView.Items.Clear()
        'Opens connection, declares OleDbCommand and OleDbReader and executes
        connection.Open()
        Dim cmd As New OleDbCommand("Select * From Wages WHERE FullName = '" & cboName.Text & "' ORDER BY ID", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("ID").ToString)
            newitem.SubItems.Add(dr.Item("StartDate"))
            newitem.SubItems.Add(dr.Item("EndDate"))
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("DatePaid"))
            newitem.SubItems.Add(dr.Item("NetPay").ToString)
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection and runs subroutine to check if data was found
        connection.Close()
        filterCheck()
    End Sub

    Private Sub filterCheck()
        'Checks if any data was found
        If lstView.Items.Count = 0 Then
            'Output if no data was found
            lblFilterStatus.Text = "No data found."
            lblFilterStatus.ForeColor = Color.Red
            lblFilterStatus.Visible = True
            populateListView()
        ElseIf lstView.Items.Count <> 0 Then
            'Output if data was found
            lblFilterStatus.Text = "Data successfully filtered."
            lblFilterStatus.ForeColor = Color.Green
            lblFilterStatus.Visible = True
        End If
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


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Declares query for the OleDbCommand
        Dim query As String = "SELECT Format(StartDate, 'dd/mm/yy') & ' - ' & Format(EndDate, 'dd/mm/yy'), " & _
            "FullName, Format(DatePaid, 'dd/mm/yy'), '$' & GrossPay, '$' & PAYE, '$' & KiwiSaver, '$' & NetPay FROM Wages"
        'Checks which radio button is checked
        If rdbAll.Checked = True Then
            'Opens connection, declares OleDbCommand and OleDbDataAdapter. Fills dataset
            connection.Open()
            Dim cmd As New OleDbCommand(query, connection)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, "Wages")
            'Sets datasource in the data grid view and runs subroutine to change header names
            DataGridView.DataSource = ds.Tables("Wages").DefaultView
            formatDGV()
            connection.Close()
            'Runs function to setup the printing
            If SetupThePrinting("Wages - All") Then
                'Declares PrintPreviewDialog then shows it accordingly
                Dim ppd As PrintPreviewDialog = New PrintPreviewDialog()
                ppd.Document = pntDocument
                ppd.Height = Screen.PrimaryScreen.Bounds.Height / 1.5
                ppd.Width = Screen.PrimaryScreen.Bounds.Width / 2.5
                ppd.FindForm().StartPosition = FormStartPosition.CenterScreen
                ppd.Text = "Wages"
                ppd.ShowDialog()
            End If
        ElseIf rdbFiltered.Checked = True Then
            connection.Open()
            Dim ds As DataSet = New DataSet()
            'Loops through all items in the listview
            For i = 0 To lstView.Items.Count - 1
                'Declares ID, OleDbCommand and adapter. Fills dataset 
                Dim ID As Integer = lstView.Items(i).Text
                Dim cmd As New OleDbCommand(query & " WHERE ID =" & ID, connection)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                da.Fill(ds, "Wages")
            Next i
            'Sets datasource in the data grid view , runs subroutine to change header names
            DataGridView.DataSource = ds.Tables("Wages").DefaultView
            formatDGV()
            connection.Close()
            'Runs function to setup the printing
            If SetupThePrinting("Wages - Filtered") Then
                'Declares PrintPreviewDialog then shows it accordingly
                Dim ppd As PrintPreviewDialog = New PrintPreviewDialog()
                ppd.Document = pntDocument
                ppd.Height = Screen.PrimaryScreen.Bounds.Height / 1.5
                ppd.Width = Screen.PrimaryScreen.Bounds.Width / 2.5
                ppd.FindForm().StartPosition = FormStartPosition.CenterScreen
                ppd.Text = "Wages"
                ppd.ShowDialog()
            End If
        Else : MsgBox("Please select a radio button.") 'Output to user asking to select a radio button
        End If
    End Sub

    Private Sub formatDGV()
        'Formatting the headercells for the datagridview
        With DataGridView
            .Columns(0).HeaderCell.Value = "Dates"
            .Columns(1).HeaderCell.Value = "Name"
            .Columns(2).HeaderCell.Value = "Date Paid"
            .Columns(3).HeaderCell.Value = "Gross Pay"
            .Columns(4).HeaderCell.Value = "PAYE"
            .Columns(5).HeaderCell.Value = "KiwiSaver"
            .Columns(6).HeaderCell.Value = "Net Pay"
        End With
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
        pntDocument.DocumentName = "Wages"
        pntDocument.PrinterSettings = pd.PrinterSettings
        pntDocument.DefaultPageSettings = pd.PrinterSettings.DefaultPageSettings
        pntDocument.DefaultPageSettings.Margins = New Margins(20, 20, 20, 20)
        dgvPrinter = New DataGridViewPrinter(DataGridView, pntDocument, True, True, title, New Font("Segoe UI", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Return True
    End Function
End Class