Imports System.Data.OleDb

Public Class Wages___New
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Wages___New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs subroutine to populate the combobox
        populateCBO()
        'Focuses the form
        PictureBox.Select()
        'Sets minimum value of the End datepicker to the value of the Start datepicker
        dtpEnd.MinDate = dtpStart.Value.Date
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Runs validation function
        If Validation() Then
            'Declares the new OleDbCommand
            Dim cmd As New OleDbCommand("INSERT INTO Wages (StartDate, EndDate, FullName, DatePaid, GrossPay, " & _
                                        "PAYE, KiwiSaver, NetPay) " & _
                                        "VALUES (@StartDate, @EndDate, @FullName, @DatePaid, @GrossPay, @PAYE, " & _
                                        "@KiwiSaver, @NetPay)", connection)
            'Gives the parameters its values
            cmd.Parameters.AddWithValue("StartDate", dtpStart.Value.Date)
            cmd.Parameters.AddWithValue("EndDate", dtpEnd.Value.Date)
            cmd.Parameters.AddWithValue("FullName", cboName.Text)
            cmd.Parameters.AddWithValue("DatePaid", dtpPaid.Value.Date)
            cmd.Parameters.AddWithValue("GrossPay", txtGross.Text)
            cmd.Parameters.AddWithValue("PAYE", txtPAYE.Text)
            cmd.Parameters.AddWithValue("KiwiSaver", txtKiwiSaver.Text)
            cmd.Parameters.AddWithValue("NetPay", txtNet.Text)
            'Opens database connection, executes query and closes the database
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output to show successful insertion of record
            lblStatus.ForeColor = Color.Green
            lblStatus.Text = "Wage payment successfully added into database."
            'Sets the labels on the overview form to show success
            Wages___Overview.lblDataStatus.Text = "Record successfully added."
            Wages___Overview.lblDataStatus.Visible = True
            'Runs subroutine to clear the form
            clearForm()
        End If
    End Sub

    Function Validation()
        'Checks if textboxes contain text, if the values of the textboxes are appropriately 'sized' and the dates are correct
        If txtGross.Text <> "" And txtPAYE.Text <> "" And txtKiwiSaver.Text <> "" And txtNet.Text <> "" And _
             Val(txtNet.Text) > "0" And Val(txtGross.Text) > Val(txtPAYE.Text) And Val(txtGross.Text) > Val(txtKiwiSaver.Text) Then
            Return True
        Else
            'Output to show that one or more of the textboxes have not been filled.
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Please ensure all fields are filled out correctly."
            Return False
        End If
        Return False
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

    Private Sub PayAddition_TextChanged(sender As Object, e As EventArgs) Handles txtGross.TextChanged, txtPAYE.TextChanged, txtKiwiSaver.TextChanged
        'Declares variables and sets values according to the textboxes
        Dim g, p, k, t As Double
        g = Val(txtGross.Text)
        p = Val(txtPAYE.Text)
        k = Val(txtKiwiSaver.Text)
        'Subtracts the values in the textboxes for wages
        t = g - p - k
        txtNet.Text = t
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGross.KeyPress,
      txtPAYE.KeyPress, txtKiwiSaver.KeyPress, txtNet.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub

    Private Sub clearForm()
        'Resets controls
        dtpStart.Value = DateTime.Today
        dtpEnd.Value = DateTime.Today
        dtpPaid.Value = DateTime.Today
        txtGross.Text = ""
        txtPAYE.Text = ""
        txtKiwiSaver.Text = ""
        txtNet.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        If Response = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
        'Sets minimum value of the End datepicker to the value of the Start datepicker
        dtpEnd.MinDate = dtpStart.Value.Date
    End Sub

    Private Sub Wages___New_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Closes form completely and repopulates the listview on the overview form
        Me.Dispose()
        Wages___Overview.populateListView()
    End Sub
End Class