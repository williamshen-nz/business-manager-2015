Imports System.Data.OleDb
Imports Odin.ListviewSort
Imports System.Drawing.Printing

Public Class Travel_Expense___Overview
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Dim dgvPrinter As DataGridViewPrinter
    Private m_SortingColumn As ColumnHeader

    Private Sub Travel_Expense___Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutine to populate the listview
        populateListView()
        'Sets font on the datagridview for printing
        DataGridView.Font = New Font("Segoe UI", 10.5)
        'Focuses on form
        PictureBox.Select()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'Checks if an item is selected in the listview or not
        If lstView.SelectedItems.Count > 0 Then
            'Passes value of TrackingNumber to expense form and opens it
            Dim TrackingNumber As String = lstView.SelectedItems(0).Text
            Travel_Expense.txtTrackingNumber.Text = TrackingNumber
            Travel_Expense.txtTrackingNumber.ReadOnly = True
            Travel_Expense.cboName.Enabled = False
            Travel_Expense.cboName.Text = lstView.SelectedItems(0).SubItems(1).Text
            Travel_Expense.ShowDialog()
            'Output error if no item is selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Checks if an item has been selected or not
        If lstView.SelectedItems.Count > 0 Then
            If My.Settings.accountAdmin = True Then
                'Displays a MsgBox asking user to confirm to delete the record
                Dim Response = MsgBox("Are you sure you want to delete the records for this Travel Expense?" & vbNewLine & "All data " & _
                                      "on the given tracking number WILL be deleted in the Travel Expense table.", MsgBoxStyle.YesNo, "Delete Record")
                If Response = MsgBoxResult.Yes Then
                    'Checks if an item is selected in the listview or not if user response is 'Yes'
                    If lstView.SelectedItems.Count > 0 Then
                        'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                        Dim TrackingNumber As String = lstView.SelectedItems(0).Text
                        Dim cmd As New OleDbCommand("DELETE FROM [Travel Expenses] WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
                        'Opens connection, executes the command and closes the connection
                        connection.Open()
                        cmd.ExecuteNonQuery()
                        connection.Close()
                        'Repopulates the listview
                        populateListView()
                        'Updates label to show status
                        lblDataStatus.Text = "Records deleted."
                        lblDataStatus.ForeColor = Color.Green
                        lblDataStatus.Visible = True
                    End If
                End If
            Else : MsgBox("You are not authorised to carry out this action. You must be an admin.")
            End If
            'Output error if no record has been selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    '//PRINTING
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Checks if an item has been selected or not
        If lstView.SelectedItems.Count > 0 Then
            'Declares variables to be used in query
            Dim TrackingNumber As String = lstView.SelectedItems(0).Text
            Dim Name As String = lstView.SelectedItems(0).SubItems(1).Text
            'Declares OleDbCommand, Data Adapter and Dataset
            Dim cmd As New OleDbCommand("SELECT Format(DateIncurred, 'dd/mm/yy'), Description, BillClient, ExpenseType, ForeignCurrency " & _
                                        "& ' $' & ForeignAmount, ExchangeRate, '$' & NZDAmount, Reimbursed From [Travel Expenses] WHERE " & _
                                        "TrackingNumber = '" & TrackingNumber & "' ORDER BY DateIncurred", connection)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            'Fills dataset with data from table and outputs it to datagridview
            da.FillSchema(dt, SchemaType.Source)
            dt.Columns(2).DataType = GetType(String)
            dt.Columns(5).DataType = GetType(String)
            dt.Columns(7).DataType = GetType(String)
            da.Fill(dt)
            'Displays data on datagridview and sets the column names
            DataGridView.DataSource = dt
            With DataGridView
                .Columns(0).HeaderCell.Value = "Date"
                .Columns(2).HeaderCell.Value = "BC"
                .Columns(3).HeaderCell.Value = "Type"
                .Columns(4).HeaderCell.Value = "Amount"
                .Columns(5).HeaderCell.Value = "XRT"
                .Columns(6).HeaderCell.Value = "NZD"
                .Columns(7).HeaderCell.Value = "Repaid"
            End With
            'Loops through datagridview and replaces True with Yes and False with Nothing for BillClient and
            'False with No for Repaid. Calculates total for the NZD and Reimbursed column (if it is false) of the datagridview
            Dim totalDec As Decimal = 0
            Dim repaidDec As Decimal = 0
            For i = 0 To DataGridView.Rows.Count - 1
                'Checks if cell for Bill Client contains True 
                If DataGridView.Rows(i).Cells(2).Value = "True" Then
                    DataGridView.Rows(i).Cells(2).Value = "Yes"
                Else : DataGridView.Rows(i).Cells(2).Value = ""
                End If
                'Checks if cell for Repaid contains True 
                If DataGridView.Rows(i).Cells(7).Value = "True" Then
                    DataGridView.Rows(i).Cells(7).Value = "Yes"
                Else
                    DataGridView.Rows(i).Cells(7).Value = "No"
                    repaidDec += DataGridView.Rows(i).Cells(6).Value
                End If
                'Sums the values in the NZD column
                totalDec = totalDec + DataGridView.Rows(i).Cells(6).Value
            Next i
            'Rounds the total variables to 2 decimal points and converts them to string with $ symbol
            totalDec = Decimal.Round(totalDec, 2, MidpointRounding.AwayFromZero)
            repaidDec = Decimal.Round(repaidDec, 2, MidpointRounding.AwayFromZero)
            Dim totalStr As String = "$" & CStr(totalDec)
            Dim repaidStr As String = "$" & CStr(repaidDec)
            'Adds new row to DataTable to update the datagridview. Sets values in rows then adds
            Dim newRow As DataRow = dt.NewRow
            For i = 0 To 5
                newRow.Item(i) = ""
            Next
            newRow.Item(6) = totalStr
            newRow.Item(7) = repaidStr
            dt.Rows.Add(newRow)
            'Runs function to set up printing
            If SetupThePrinting(TrackingNumber & " - " & Name) Then
                'Declares and opens print preview dialog
                Dim ppd As PrintPreviewDialog = New PrintPreviewDialog()
                ppd.Document = pntDocument
                ppd.Height = Screen.PrimaryScreen.Bounds.Height / 1.5
                ppd.Width = Screen.PrimaryScreen.Bounds.Width / 2.5
                ppd.FindForm().StartPosition = FormStartPosition.CenterScreen
                ppd.Text = "Travel Expenses"
                ppd.ShowDialog()
            End If
        Else : MsgBox("Please select a record from the table.") 'If user did not select a listview item
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
        pntDocument.DocumentName = "Travel Expense"
        pntDocument.PrinterSettings = pd.PrinterSettings
        pntDocument.DefaultPageSettings = pd.PrinterSettings.DefaultPageSettings
        pntDocument.DefaultPageSettings.Margins = New Margins(20, 20, 20, 20)
        dgvPrinter = New DataGridViewPrinter(DataGridView, pntDocument, True, True, title, New Font("Segoe UI", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Return True
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Opens search box form and passes relevant function name
        SearchBox.lblFunction.Text = "TravelExpense"
        SearchBox.ShowDialog()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Opens the form to input or view travel expenses
        Travel_Expense.ShowDialog()
    End Sub

    Private Sub Travel_Expense_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Shows the main menu form upon closing of this form
        MainMenu.Show()
    End Sub

    Public Sub populateListView()
        'Clears and enables the listview
        lstView.Items.Clear()
        lstView.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From [Travel Expenses] ORDER BY TrackingNumber", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("TrackingNumber").ToString)
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("DateIncurred"))
            newitem.SubItems.Add(dr.Item("NZDAmount"))
            newitem.SubItems.Add(dr.Item("Reimbursed"))
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
        'Checks that the listview contains at least 2 items
        If Not lstView.Items.Count <= 1 Then
            'Declares variables used for new listviewitem
            Dim TrackingNumber As String
            Dim Name As String
            Dim dateFrom As Date
            Dim dateTo As Date
            Dim NZDAmount As Decimal
            Dim Reimbursed As Boolean
            'Sets variables according to their items and subitems in the first item in the listview
            TrackingNumber = lstView.Items(0).Text
            Name = lstView.Items(0).SubItems(1).Text
            dateFrom = lstView.Items(0).SubItems(2).Text
            dateTo = lstView.Items(0).SubItems(2).Text
            NZDAmount = lstView.Items(0).SubItems(3).Text
            Reimbursed = lstView.Items(0).SubItems(4).Text
            'Declares variable and sets it to length of listview minus one
            Dim lstViewLength As Integer = lstView.Items.Count - 1
            'Loops from the second item in listview to the last currently present
            For x = 1 To lstViewLength
                'Checks if the TrackingNumber in this item is equal to the previous one
                If lstView.Items(x).Text = TrackingNumber Then
                    'Checks if the date in this item is smaller than the dateFrom (minimum date)
                    If dateFrom > CDate(lstView.Items(x).SubItems(2).Text) Then
                        dateFrom = CDate(lstView.Items(x).SubItems(2).Text)
                    End If
                    'Checks if the date in this item is smaller than the dateTo (maximum date)
                    If dateTo < CDate(lstView.Items(x).SubItems(2).Text) Then
                        dateTo = CDate(lstView.Items(x).SubItems(2).Text)
                    End If
                    'Sets the NZDAmount as the current amount plus the value in the current listview item
                    NZDAmount = NZDAmount + CDec(lstView.Items(x).SubItems(3).Text)
                    'Checks if the expense has been reimbursed or not
                    If lstView.Items(x).SubItems(4).Text = False Then
                        'Sets the boolean for Reimbursed to false
                        Reimbursed = False
                    End If
                    'Checks if the end of the initial listview has been reached  or not
                    If x = lstViewLength Then
                        'Rounds the NZDAmount accordingly (2 decimal places)
                        NZDAmount = Decimal.Round(NZDAmount, 2, MidpointRounding.AwayFromZero)
                        'Adds a new listview item and gives the subitems their values
                        Dim i As ListViewItem = lstView.Items.Add(TrackingNumber)
                        i.SubItems.Add(Name)
                        i.SubItems.Add(dateFrom & " - " & dateTo)
                        i.SubItems.Add(NZDAmount)
                        i.SubItems.Add(Reimbursed)
                    End If
                    'In the case that the current listview item's tracking number is not equal to the previous one
                ElseIf lstView.Items(x).Text <> TrackingNumber Then
                    'Rounds the NZDAmount accordingly to 2 decimal places
                    NZDAmount = Decimal.Round(NZDAmount, 2, MidpointRounding.AwayFromZero)
                    'Adds a new listview item and gives the subitems their values
                    Dim i As ListViewItem = lstView.Items.Add(TrackingNumber)
                    i.SubItems.Add(Name)
                    i.SubItems.Add(dateFrom & " - " & dateTo)
                    i.SubItems.Add(NZDAmount)
                    i.SubItems.Add(Reimbursed)
                    'Sets the variables to the current listview items contents
                    TrackingNumber = lstView.Items(x).Text
                    Name = lstView.Items(x).SubItems(1).Text
                    dateFrom = lstView.Items(x).SubItems(2).Text
                    dateTo = lstView.Items(x).SubItems(2).Text
                    NZDAmount = lstView.Items(x).SubItems(3).Text
                    Reimbursed = lstView.Items(x).SubItems(4).Text
                End If
            Next x
            'Reverse loop from the initial listview length to the first record to delete the items
            For x = lstViewLength To 0 Step -1
                'Deletes the initial listview items
                lstView.Items(x).Remove()
            Next
        End If
    End Sub
End Class