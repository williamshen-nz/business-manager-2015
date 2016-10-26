Imports System.Data.OleDb
Imports Odin.ListviewSort
Imports System.Drawing.Printing

Public Class Travel_Expense
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Dim dgvPrinter As DataGridViewPrinter
    Private m_SortingColumn As ColumnHeader

    Private Sub Travel_Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutine to populate the combobox with names
        populateCBO()
        'Sets font on the datagridview for printing
        DataGridView.Font = New Font("Segoe UI", 11.5)
        'Calls relevant subroutine to accomodate with View and Edit form open to fill in name
        Call txtTrackingNumber_TextChanged(sender, e)
    End Sub

    '//CODE FOR BUTTONS//
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Runs function validation and continues if it returns true
        If Validation() Then
            'Sets Reimbursed as True if user doesn't require reimbursement
            Dim Reimbursed As Boolean
            If chkReimburse.Checked = False Then
                Reimbursed = True
            Else : Reimbursed = False
            End If
            'Declares the new OleDbCommand
            Dim cmd As New OleDbCommand("INSERT INTO [Travel Expenses] (TrackingNumber, FullName, DateIncurred, ExpenseType, Description, " & _
                                        "BillClient, Reimburse, PaymentMethod, ForeignAmount, ForeignCurrency, ExchangeRate, NZDAmount, " & _
                                        "Reimbursed) VALUES (@TrackingNumber, @FullName, @DateIncurred, @ExpenseType, @Description, " & _
                                        "@BillClient, @Reimburse, @PaymentMethod, @ForeignAmount, @ForeignCurrency, @ExchangeRate, " & _
                                        "@NZDAmount, @Reimbursed)", connection)
            'Gives the parameters its values
            cmd.Parameters.AddWithValue("TrackingNumber", txtTrackingNumber.Text)
            cmd.Parameters.AddWithValue("FullName", cboName.Text)
            cmd.Parameters.AddWithValue("DateIncurred", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("ExpenseType", cboExpenseType.Text)
            cmd.Parameters.AddWithValue("Description", txtDescription.Text)
            cmd.Parameters.AddWithValue("BillClient", chkBillClient.Checked)
            cmd.Parameters.AddWithValue("Reimburse", chkReimburse.Checked)
            cmd.Parameters.AddWithValue("PaymentMethod", cboPaymentMethod.Text)
            cmd.Parameters.AddWithValue("ForeignAmount", txtForeign.Text)
            cmd.Parameters.AddWithValue("ForeignCurrency", cboCurrency.Text)
            cmd.Parameters.AddWithValue("ExchangeRate", txtExchangeRate.Text)
            cmd.Parameters.AddWithValue("NZDAmount", lblNZDAmount.Text)
            cmd.Parameters.AddWithValue("Reimbursed", Reimbursed)
            'Opens database connection, executes query and closes the database
            Try
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                'Output to show success
                lblStatus.ForeColor = Color.Green
                lblStatus.Text = "Travel Expense successfully saved."
                'Locks the tracking number and name controls
                txtTrackingNumber.ReadOnly = True
                cboName.Enabled = False
                'Runs subroutine to repopulate the listview and clears existing data on form
                populateListView()
                clearForm()
            Catch
                'Output in case data could not be saved for any reason
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "An error occurred. The expense was not successfully saved."
            End Try
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'Checks if an item is selected in the listview or not
        If lstView.SelectedItems.Count > 0 Then
            'Brings the relevant buttons to the front, enables them and shows checkbox
            btnReimburseAll.Visible = True
            btnUpdate.BringToFront()
            btnUpdate.Enabled = True
            btnDelete1.BringToFront()
            btnDelete1.Enabled = True
            chkReimbursed.Visible = True
            'Disables the buttons for new expense
            btnSave.Enabled = False
            btnClear.Enabled = False
            'Sets description label for the form and sets the textbox for trackingnumber to read only
            lblDescription.Text = "Travel Expense - View and Edit"
            txtTrackingNumber.ReadOnly = True
            cboName.Enabled = False
            'Sets text in the label as the ID for loading data
            lblID.Text = lstView.SelectedItems(0).Text
            'Opens the connection and declares a new OleDbCommand and Reader
            connection.Open()
            Dim dt As New DataTable()
            'Fills datatable with data from the investments table
            Using da As New OleDbDataAdapter("SELECT * FROM [Travel Expenses] WHERE ID = " & lblID.Text, connection)
                da.Fill(dt)
            End Using
            'Closes the connection
            connection.Close()
            'Sets values in textboxes to data in datatable
            txtTrackingNumber.Text = dt.Rows(0)("TrackingNumber").ToString
            cboName.Text = dt.Rows(0)("FullName").ToString
            dtpDate.Value = dt.Rows(0)("DateIncurred")
            cboExpenseType.Text = dt.Rows(0)("ExpenseType").ToString
            txtDescription.Text = dt.Rows(0)("Description").ToString
            chkBillClient.Checked = dt.Rows(0)("BillClient")
            chkReimburse.Checked = dt.Rows(0)("Reimburse")
            cboPaymentMethod.Text = dt.Rows(0)("PaymentMethod").ToString
            txtForeign.Text = dt.Rows(0)("ForeignAmount")
            cboCurrency.Text = dt.Rows(0)("ForeignCurrency").ToString
            txtExchangeRate.Text = dt.Rows(0)("ExchangeRate")
            lblNZDAmount.Text = dt.Rows(0)("NZDAmount")
            chkReimbursed.Checked = dt.Rows(0)("Reimbursed")
            'Updates label to show status
            lblStatus.Text = "Record successfully loaded. Please make any desired changes and click 'Update'."
            lblStatus.ForeColor = Color.Green
            'Output error if no item is selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Runs Validation function and sees if it returns true
        If Validation() Then
            'Declares the new OleDbCommand and gives it parameters values
            Dim cmd As New OleDbCommand("UPDATE [Travel Expenses] SET FullName = ?, DateIncurred = ?, ExpenseType = ?, Description = ?, " & _
                                        "BillClient = ?, Reimburse = ?, PaymentMethod = ?, ForeignAmount = ?, ForeignCurrency = ?, " & _
                                        "ExchangeRate = ?, NZDAmount = ?, Reimbursed = ? WHERE ID = " & lblID.Text, connection)
            cmd.Parameters.AddWithValue("@p1", cboName.Text)
            cmd.Parameters.AddWithValue("@p2", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("@p3", cboExpenseType.Text)
            cmd.Parameters.AddWithValue("@p4", txtDescription.Text)
            cmd.Parameters.AddWithValue("@p5", chkBillClient.Checked)
            cmd.Parameters.AddWithValue("@p6", chkReimburse.Checked)
            cmd.Parameters.AddWithValue("@p7", cboPaymentMethod.Text)
            cmd.Parameters.AddWithValue("@p8", txtForeign.Text)
            cmd.Parameters.AddWithValue("@p9", cboCurrency.Text)
            cmd.Parameters.AddWithValue("@p10", txtExchangeRate.Text)
            cmd.Parameters.AddWithValue("@p11", lblNZDAmount.Text)
            cmd.Parameters.AddWithValue("@p12", chkReimbursed.Checked)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show success
            lblStatus.Text = "Record successfully updated. Please enter a new expense or select another option."
            lblStatus.ForeColor = Color.Green
            'Runs subroutine to repopulate listview and calls subroutine to reset the form 
            populateListView()
            Call btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        'Displays a MsgBox asking user to confirm to delete the record
        Dim Response = MsgBox("Are you sure you want to delete this Travel Expense record?", MsgBoxStyle.YesNo, "Delete Record")
        'If user responds 'Yes' to the MsgBox
        If Response = MsgBoxResult.Yes Then
            'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
            Dim cmd As New OleDbCommand("DELETE FROM [Travel Expenses] WHERE ID = " & lblID.Text, connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Repopulates the listview and resets the form
            populateListView()
            Call btnNew_Click(sender, e)
            'Updates label to show status
            lblDataStatus.Text = "Record deleted."
            lblDataStatus.ForeColor = Color.Green
            lblDataStatus.Visible = True
        End If
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        'Checks if an item has been selected or not
        If lstView.SelectedItems.Count > 0 Then
            'Displays a MsgBox asking user to confirm to delete the record
            Dim Response = MsgBox("Are you sure you want to delete this Travel Expense record?", MsgBoxStyle.YesNo, "Delete Record")
            If Response = MsgBoxResult.Yes Then
                'Checks if an item is selected in the listview or not if user response is 'Yes'
                If lstView.SelectedItems.Count > 0 Then
                    'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                    Dim ID As String = lstView.SelectedItems(0).Text
                    Dim cmd As New OleDbCommand("DELETE FROM [Travel Expenses] WHERE ID = " & ID, connection)
                    'Opens connection, executes the command and closes the connection
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    'Repopulates the listview and resets the form
                    populateListView()
                    Call btnNew_Click(sender, e)
                    'Updates label to show status
                    lblDataStatus.Text = "Record deleted."
                    lblDataStatus.ForeColor = Color.Green
                    lblDataStatus.Visible = True
                End If
            End If
            'Output error if no record has been selected
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Brings relevant buttons to the front
        btnSave.BringToFront()
        btnSave.Enabled = True
        btnClear.BringToFront()
        btnClear.Enabled = True
        'Disables the buttons for updating expense and hides the reimbursed checkbox
        btnReimburseAll.Visible = False
        btnUpdate.Enabled = False
        btnDelete1.Enabled = False
        chkReimbursed.Visible = False
        'Runs subroutine to clear the form
        clearForm()
        'Updates the labels to show user what to do
        lblDescription.Text = "Travel Expense - New"
        lblStatus.Text = "Please enter relevant data and press save."
        lblStatus.ForeColor = Color.FromArgb(22, 88, 153)
    End Sub

    Private Sub btnReimburseAll_Click(sender As Object, e As EventArgs) Handles btnReimburseAll.Click
        'Displays a MsgBox asking user to confirm that all records are reimbursed
        Dim Response = MsgBox("Have all records for the Travel Expense #" & txtTrackingNumber.Text & " been reimbursed fully?",
                              MsgBoxStyle.YesNo, "Confirmation")
        If Response = MsgBoxResult.Yes Then
            'Declares the new OleDbCommand and gives it parameters values if user selects 'Yes'
            Dim cmd As New OleDbCommand("UPDATE [Travel Expenses] SET Reimbursed = True WHERE TrackingNumber = '" & _
                                        txtTrackingNumber.Text & "'", connection)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show success
            lblStatus.Text = "Record successfully updated. Please enter a new expense or select another option."
            lblStatus.ForeColor = Color.Green
            populateListView()
            Call btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Runs subroutine to clear the form
        clearForm()
    End Sub

    '//PRINTING
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Declares variables to be used in query
        Dim TrackingNumber As String = txtTrackingNumber.Text
        Dim Name As String = cboName.Text
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

    '//SUBROUTINES AND FUNCTIONS (NOT CONTROL BASED)
    Private Function Validation()
        'Checks if the textboxes and combobox contain text
        If txtTrackingNumber.Text <> "" And cboName.Text <> "" And cboExpenseType.Text <> "" And cboPaymentMethod.Text <> "" And _
            txtDescription.Text <> "" And txtForeign.Text <> "" And txtExchangeRate.Text <> "" And lblNZDAmount.Text <> "" And _
            cboCurrency.Text.Length = 3 Then 'Checks that the length of the text in the currency combobox is 3
            Return True
        Else
            'Output to show validation was not successful
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Please ensure all fields contain valid data."
            Return False
        End If
    End Function

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

    Private Sub populateListView()
        'Clears and enables the listview
        lstView.Items.Clear()
        lstView.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From [Travel Expenses] WHERE TrackingNumber = '" & _
                                    txtTrackingNumber.Text & "' ORDER BY DateIncurred", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Travel Expenses table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("ID").ToString)
            newitem.SubItems.Add(dr.Item("DateIncurred"))
            newitem.SubItems.Add(dr.Item("Description").ToString)
            newitem.SubItems.Add(dr.Item("ExpenseType"))
            newitem.SubItems.Add(dr.Item("NZDAmount"))
            newitem.SubItems.Add(dr.Item("Reimbursed"))
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
    End Sub

    Private Sub clearForm()
        'Clears the controls that require resetting
        dtpDate.Value = DateTime.Today
        txtDescription.Text = ""
        chkBillClient.Checked = False
        chkReimburse.Checked = False
        txtForeign.Text = ""
        txtExchangeRate.Text = cboCurrency.Text & " to NZD"
        lblNZDAmount.Text = ""
        lblDataStatus.Visible = False
        'Sets the indexes of the comboboxes to show no text
        cboExpenseType.SelectedIndex = -1
        cboPaymentMethod.SelectedIndex = -1
    End Sub

    Private Sub Travel_Expense_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Runs subroutine to repopulate listview on the overview form
        Travel_Expense___Overview.populateListView()
        'Closes form completely
        Me.Dispose()
    End Sub

    '//OTHER CONTROL BASED SUBROUTINES
    Private Sub txtTrackingNumber_TextChanged(sender As Object, e As EventArgs) Handles txtTrackingNumber.TextChanged
        'Converts the text in textbox to uppercase and sets it
        Dim Tracking As String = txtTrackingNumber.Text
        txtTrackingNumber.Text = Tracking.ToUpper()
        txtTrackingNumber.Select(txtTrackingNumber.Text.Length, 0)
        Try
            'Opens the connection and declares a new OleDbCommand and datatable
            Dim TrackingNumber As String = txtTrackingNumber.Text
            connection.Open()
            Dim dt As New DataTable()
            'Uses data from the travel expense application table to fill in the FullName textbox
            Using da As New OleDbDataAdapter("SELECT FullName FROM TEA WHERE TrackingNumber = '" & TrackingNumber & "'", connection)
                da.Fill(dt)
            End Using
            'Closes the connection
            connection.Close()
            'Sets values in combobox to data in datatable
            cboName.Text = dt.Rows(0)("FullName").ToString
            cboName.Enabled = False
            populateListView()
        Catch
            'Clears the listview and enables the combobox if an error occurred
            lstView.Items.Clear()
            cboName.Enabled = True
        End Try
    End Sub

    Private Sub cboPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentMethod.SelectedIndexChanged
        'Checks which payment method the user has selected
        If cboPaymentMethod.Text = "Personal" Then
            'Sets the reimburse checkbox to true
            chkReimburse.Enabled = True
            chkReimburse.Checked = True
        ElseIf cboPaymentMethod.Text = "Company" Then
            'Disables and sets checkbox to unchecked
            chkReimburse.Checked = False
            chkReimburse.Enabled = False
        Else : chkReimburse.Enabled = True
        End If
    End Sub

    Private Sub Calculation_TextChanged(sender As Object, e As EventArgs) Handles txtForeign.TextChanged, txtExchangeRate.TextChanged
        'Adds the values in the textboxes for estimated costs and adds them together
        Dim foreign, exchange, nzd As Double
        foreign = Val(txtForeign.Text)
        exchange = Val(txtExchangeRate.Text)
        nzd = foreign * exchange
        lblNZDAmount.Text = nzd
    End Sub

    Private Sub cboCurrency_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCurrency.KeyPress
        'Does not allow numbers, punctuation, etc. into the combobox
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        'Allow backspace in textbox
        If e.KeyChar = Chr(&H8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboCurrency_TextChanged(sender As Object, e As EventArgs) Handles cboCurrency.TextChanged
        'Converts the text in the combobox to full capitals
        Dim currency As String = cboCurrency.Text
        currency = currency.ToUpper
        cboCurrency.Text = currency
        'Sets cursor to end of combobox
        cboCurrency.Select(cboCurrency.Text.Length, 0)
    End Sub

    Private Sub cboCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCurrency.SelectedIndexChanged
        'Sets the text to the allow the user to know what to input (e.g. RMB to NZD)
        txtExchangeRate.Text = cboCurrency.Text & " to NZD"
    End Sub

    Private Sub txtExchangeRate_Click(sender As Object, e As EventArgs) Handles txtExchangeRate.Click
        If txtExchangeRate.Text.Contains("NZD") Then
            'Clears the textbox upon clicking if text contains NZD
            txtExchangeRate.Text = ""
        End If
    End Sub

    Private Sub txtExchangeRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExchangeRate.KeyPress
        'Allows numbers and decimals to be input into the textbox
        Dim dot As Integer
        If Not e.KeyChar = "." And Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        'Allow backspace in textbox
        If e.KeyChar = Chr(&H8) Then
            e.Handled = False
        End If
        'Checks if the text in the textbox already contains a dot or not
        If e.KeyChar = "." And Not txtExchangeRate.Text.IndexOf(".") = -1 Then
            e.Handled = False
            dot = txtExchangeRate.Text.IndexOf(".")
            If dot > -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtForeign_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtForeign.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub

    Private Sub lblNZDAmount_TextChanged(sender As Object, e As EventArgs) Handles lblNZDAmount.TextChanged
        Try
            'Rounds the value in the label to 2 decimal points
            lblNZDAmount.Text = Decimal.Round(lblNZDAmount.Text, 2, MidpointRounding.AwayFromZero)
        Catch
        End Try
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