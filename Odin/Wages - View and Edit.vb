Imports System.Data.OleDb

Public Class Wages___View_and_Edit
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)

    Private Sub Wages___View_and_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the connection and declares a new OleDbCommand and Reader
        Dim ID As String = txtID.Text
        connection.Open()
        Dim dt As New DataTable()
        Using da As New OleDbDataAdapter("SELECT * FROM Wages WHERE ID = " & ID, connection)
            da.Fill(dt)
        End Using
        'Closes the connection
        connection.Close()
        'Sets values in textboxes and date time pickers to data in datatable
        dtpStart.Value = dt.Rows(0)("StartDate")
        dtpEnd.Value = dt.Rows(0)("EndDate")
        txtName.Text = dt.Rows(0)("FullName").ToString
        dtpPaid.Value = dt.Rows(0)("DatePaid")
        txtGross.Text = dt.Rows(0)("GrossPay").ToString
        txtPAYE.Text = dt.Rows(0)("PAYE").ToString
        txtKiwiSaver.Text = dt.Rows(0)("KiwiSaver").ToString
        txtNet.Text = dt.Rows(0)("NetPay").ToString
        'Checks if user is an admin and then enables Name textbox if he/she is
        If My.Settings.accountAdmin = True Then
            txtName.ReadOnly = False
        End If
        'Focuses the form
        PictureBox.Select()
        'Sets minimum value of the End datepicker to the value of the Start datepicker
        dtpEnd.MinDate = dtpStart.Value.Date
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Runs Validation function
        If Validation() Then
            'Declares the new OleDbCommand and gives it parameters
            Dim cmd As New OleDbCommand("UPDATE Wages SET StartDate = ?, EndDate = ?, FullName = ?, DatePaid = ?, " & _
                                        "GrossPay = ?, PAYE = ?, KiwiSaver = ?, NetPay = ? WHERE ID =" & txtID.Text, connection)
            cmd.Parameters.AddWithValue("@p1", dtpStart.Value.Date)
            cmd.Parameters.AddWithValue("@p2", dtpEnd.Value.Date)
            cmd.Parameters.AddWithValue("@p3", txtName.Text)
            cmd.Parameters.AddWithValue("@p4", dtpPaid.Value.Date)
            cmd.Parameters.AddWithValue("@p5", txtGross.Text)
            cmd.Parameters.AddWithValue("@p6", txtPAYE.Text)
            cmd.Parameters.AddWithValue("@p7", txtKiwiSaver.Text)
            cmd.Parameters.AddWithValue("@p8", txtNet.Text)
            'Executes the command and closes form
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output on the overview form for successful updating
            Wages___Overview.lblDataStatus.Text = "Record successfully updated."
            Wages___Overview.lblDataStatus.Visible = True
            'Closes the form
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Displays a MsgBox asking user to confirm to close the form
        Dim Response = MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Close")
        'If user selects 'Yes' then the form is closed
        If Response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Function Validation()
        'Checks if all the textboxes contain text, the values of the relevant textboxes and the dates
        If txtGross.Text <> "" And txtPAYE.Text <> "" And txtKiwiSaver.Text <> "" And txtNet.Text <> "" And _
             Val(txtNet.Text) > "0" And Val(txtGross.Text) > Val(txtPAYE.Text) And Val(txtGross.Text) > Val(txtKiwiSaver.Text) And _
             dtpEnd.Value.Date >= dtpStart.Value.Date Then
            Return True
        Else
            'Output to show that one or more of the textboxes have not been filled.
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Please ensure all fields are filled out correctly."
            Return False
        End If
        Return False
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Displays a MsgBox asking user to confirm to delete the record
        Dim Response = MsgBox("Are you sure you want to delete this Wage Payment?", MsgBoxStyle.YesNo, "Delete Wage Payment")
        If Response = MsgBoxResult.Yes Then
            'Declares a new OleDbCommand which deletes the record which contains the text from the textbox if user selects 'Yes'
            Dim ID As String = txtID.Text
            Dim cmd As New OleDbCommand("DELETE FROM Wages WHERE ID = " & ID, connection)
            'Opens connection, executes the command and closes the connection
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            'Output on overview form
            Wages___Overview.lblDataStatus.Visible = True
            Wages___Overview.lblDataStatus.ForeColor = Color.Green
            Wages___Overview.lblDataStatus.Text = "Record deleted."
            'Closes the form
            Me.Close()
        End If
    End Sub

    Private Sub Wages___View_and_Edit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Runs subroutine to populate the listview on the overview form if this form is closing
        Wages___Overview.populateListView()
        'Closes form completely
        Me.Dispose()
    End Sub

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
        'Sets minimum value of the End datepicker to the value of the Start datepicker
        dtpEnd.MinDate = dtpStart.Value.Date
    End Sub

    Private Sub PayAddition_TextChanged(sender As Object, e As EventArgs) Handles txtGross.TextChanged, txtPAYE.TextChanged, txtKiwiSaver.TextChanged
        'Declares variables and gives them values based on their relevant textboxes
        Dim g, p, k, t As Double
        g = Val(txtGross.Text)
        p = Val(txtPAYE.Text)
        k = Val(txtKiwiSaver.Text)
        'Subtracts the values in the textboxes for the wages
        t = g - p - k
        txtNet.Text = t
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGross.KeyPress,
        txtPAYE.KeyPress, txtKiwiSaver.KeyPress, txtNet.KeyPress
        'Runs subroutine on textFormatting class to allow numbers, 1 decimal point and 2 numbers after the decimal point
        textFormatting.twoDecimalPoints(sender, e)
    End Sub
End Class