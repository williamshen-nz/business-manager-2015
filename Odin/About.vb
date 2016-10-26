Public Class About
    Private Sub lblSupport_Click(sender As Object, e As EventArgs) Handles lblSupport.Click
        'Shows the form to contact support
        Contact.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes this form
        Me.Close()
    End Sub
End Class