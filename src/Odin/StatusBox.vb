Public Class StatusBox
    Private Sub StatusBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Focuses on the OK button
        btnOK.Select()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Closes the form
        Me.Close()
    End Sub
End Class