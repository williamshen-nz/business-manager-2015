Imports System.Data.OleDb

Public Class AccountManager
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adds the columns and sizes for the listview box
        lstView.Columns.Add("Username", 130, HorizontalAlignment.Left)
        lstView.Columns.Add("Password", 130, HorizontalAlignment.Left)
        lstView.Columns.Add("Full Name", 130, HorizontalAlignment.Left)
        lstView.Columns.Add("Admin", 70, HorizontalAlignment.Left)
        lstView.View = View.Details
        'Runs subroutine to populate the combination boxes
        populateCBO()
        'Focuses form on the enable textbox
        txtEnable.Select()
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        'Checks if password is correct or not
        If txtEnable.Text = "password" Then
            'Disable Enable controls
            btnEnable.Enabled = False
            txtEnable.Enabled = False
            'Runs subroutine to enable controls
            controlsEnable()
            'Feedback for user to show success
            lblAdmin.Text = "Correct password."
            lblAdmin.ForeColor = Color.Lime
            lblAdmin.Visible = True
            txtEnable.Text = ""
        Else
            'Feedback for incorrect password
            lblAdmin.Text = "Incorrect password."
            lblAdmin.ForeColor = Color.Red
            lblAdmin.Visible = True
            'Resets textbox contents
            txtEnable.Text = ""
        End If
    End Sub

    Private Sub txtEnable_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtEnable.KeyDown
        'Calls subroutine of the enable button when enter key is pressed in the Password textbox
        If e.KeyCode = Keys.Enter Then
            Call btnEnable_Click(sender, e)
        End If
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        'Sets the variable which will be used in the Insert query to add the 'Admin' Yes/No field.
        Dim Admin As Integer
        If chkAdminAdd.Checked = True Then
            Admin = 1
        Else : Admin = 0
        End If
        'Converts Username into lowercase
        Dim Username As String = txtUsernameAdd.Text
        Username = Username.ToLower()
        'If checkbox is checked and textboxes contain text (validation)
        If txtUsernameAdd.Text <> "" AndAlso txtPasswordAdd.Text <> "" AndAlso txtNameAdd.Text <> "" Then
            Try
                'Declares OleDbCommand as gives the parameters and relevant fields to insert data from textboxes into
                Dim cmd As New OleDbCommand("INSERT INTO Accounts ([Username],[Password],[FullName],[Admin])" + "VALUES ('" & Username &
                                            "','" & txtPasswordAdd.Text & "','" & txtNameAdd.Text & "','" & Admin & "');", connection)
                'Opens connection, executes the OleDbCommand and closes the connection
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                'Feedback for user to show success
                lblAddConfirm.Text = "Account successfully added."
                lblAddConfirm.ForeColor = Color.Green
                lblAddConfirm.Visible = True
                lstView.Items.Clear()
                'Clears textboxes and checkbox and runs subroutine to populate combobox
                txtUsernameAdd.Text = ""
                txtPasswordAdd.Text = ""
                txtNameAdd.Text = ""
                'Resets checkbox and populates the combobox again
                chkAdminAdd.Checked = False
                populateCBO()
            Catch ex As Exception
                'Closes the connection
                connection.Close()
                'Output to user to show an error occurred
                MsgBox("Something went wrong." & vbNewLine & "The Username you entered most probably already exists in the database.")
            End Try
        Else
            'Feedback to show checkbox is not checked or textboxes are empty
            lblAddConfirm.Text = "Please confirm the details."
            lblAddConfirm.ForeColor = Color.Red
            lblAddConfirm.Visible = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Verify that the user wants to delete the account
        If chkDelete.Checked = True Then
            'Opens database connection
            connection.Open()
            'Declares a new OleDbCommand which deletes the record which contains the text from the 'Delete' combobox
            Dim cmd As New OleDbCommand("DELETE FROM Accounts WHERE Username ='" & cboDelete.Text & "'", connection)
            'Executes the command and closes the connection
            cmd.ExecuteNonQuery()
            connection.Close()
            'Repopulates the comboboxes
            populateCBO()
            'Feedback for user to show success and resets relevant controls
            lblDelete.Text = "Account has been deleted."
            lblDelete.ForeColor = Color.Green
            lblDelete.Visible = True
            'Resets relevant parts of the form
            chkDelete.Checked = False
            lstView.Items.Clear()
        Else
            'Feedback to show checkbox is not checked
            lblDelete.Text = "Please confirm your choice."
            lblDelete.ForeColor = Color.Red
            lblDelete.Visible = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Checks if the textboxes all contain text (validation)
        If txtPasswordUpdate.Text <> "" And txtNameUpdate.Text <> "" Then
            'Declares a new OleDbCommand which deletes the record which contains the text from the 'Delete' combobox
            Dim cmdDelete As New OleDbCommand("DELETE FROM Accounts WHERE Username ='" & cboUsernameUpdate.Text & "'", connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmdDelete.ExecuteNonQuery()
            connection.Close()
            'Sets the variable which will be used in the Insert query to update the 'Admin' Yes/No field.
            Dim Admin As Integer
            If chkAdminUpdate.Checked = True Then
                Admin = 1
            Else : Admin = 0
            End If
            'Declares OleDbCommand as gives the parameters and relevant fields to insert data from textboxes into
            Dim cmdAdd As New OleDbCommand("INSERT INTO Accounts ([Username],[Password],[FullName],[Admin])" +
                                           "VALUES ('" & cboUsernameUpdate.Text & "','" & txtPasswordUpdate.Text & _
                                           "','" & txtNameUpdate.Text & "','" & Admin & "');", connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmdAdd.ExecuteNonQuery()
            connection.Close()
            'Repopulates the comboboxes
            populateCBO()
            'Feedback for user to show success and resets relevant controls
            lblUpdate.Text = "Account has been updated."
            lblUpdate.ForeColor = Color.Green
            lblUpdate.Visible = True
            'Resets relevants parts of the form
            txtPasswordUpdate.Text = ""
            txtNameUpdate.Text = ""
            chkAdminUpdate.Checked = False
            lstView.Items.Clear()
        Else
            'Feedback to show validation was not successful
            lblUpdate.Text = "Please confirm the details."
            lblUpdate.ForeColor = Color.Red
            lblUpdate.Visible = True
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'Enables the listview and clears any existing items
        lstView.Enabled = True
        lstView.Items.Clear()
        'Opens the connection and declares a new OleDbCommand and DataReader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From Accounts ORDER BY Username", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table and adds each record to a new ListViewItem then displays it
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("Username").ToString)
            newitem.SubItems.Add(dr.Item("Password").ToString)
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("Admin"))
            lstView.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
        'Resizes the ListView to fit the data.
        Dim width As Integer
        For i As Integer = 0 To lstView.Columns.Count - 1
            lstView.Columns(i).Width = -2
            width += lstView.Columns(i).Width
        Next i
    End Sub

    Private Sub btnViewClear_Click(sender As Object, e As EventArgs) Handles btnViewClear.Click
        'Clears the contents of the list view
        lstView.Enabled = False
        lstView.Items.Clear()
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        'Runs subroutine to disable the controls on the form
        controlsDisable()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form completely
        Me.Dispose()
    End Sub

    Private Sub populateCBO()
        Try
            'Declares DataSet and fills it up with data from Username Column in database
            Dim ds As New DataSet()
            connection.Open()
            Using da As New OleDbDataAdapter("SELECT Username FROM Accounts", connection)
                da.Fill(ds, "Username")
            End Using
            connection.Close()
            'Loads DataSet data into a DataView, sorts it then writes it to a DataTable
            Dim view As New DataView(ds.Tables("Username"))
            view.Sort = "Username"
            Dim sorted As DataTable = view.ToTable()
            'Populates comboboxes with contents of the new Datatable
            With cboUsernameUpdate
                .DisplayMember = "Username"
                .DataSource = view
                .SelectedIndex = 0
            End With
            With cboDelete
                .DisplayMember = "Username"
                .DataSource = view
                .SelectedIndex = 0
            End With
        Catch ex As Exception
            'Runs the following code if an error occurs (for an empty table)
            cboUsernameUpdate.DataSource = Nothing
            cboDelete.DataSource = Nothing
            MsgBox("The table 'Accounts' is empty")
        End Try
    End Sub

    Private Sub AccountManager_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'When the form is closed, it is completely closed
        Me.Dispose()
    End Sub

    Private Sub controlsDisable()
        'Controls to disable and clear account management editing
        grpNew.Enabled = False
        grpDelete.Enabled = False
        grpChange.Enabled = False
        grpView.Enabled = False
        btnLock.Enabled = False
        btnView.Enabled = False
        txtEnable.Enabled = True
        btnEnable.Enabled = True
        lblAdmin.Text = ""
        txtEnable.Focus()
        lstView.Items.Clear()
    End Sub

    Private Sub controlsEnable()
        'Controls to enable account management editing
        grpNew.Enabled = True
        grpDelete.Enabled = True
        grpChange.Enabled = True
        grpView.Enabled = True
        btnLock.Enabled = True
        btnView.Enabled = True
    End Sub
End Class