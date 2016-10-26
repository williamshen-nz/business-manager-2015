Public Class textFormatting
    Shared Sub numbersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Checks if keypress is not a backspace
        If e.KeyChar <> Chr(&H8) Then
            'Checks if keypress is not a digit
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Shared Sub twoDecimalPoints(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Handles the event if the key pressed is not a digit or a decimal point
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        Else
            'Handles the keypress if it is a decimal and it currently does exist (does not allow two decimal points)
            If e.KeyChar = "." And sender.Text.IndexOf(".") <> -1 Then
                e.Handled = True
            ElseIf e.KeyChar = "." Then 'If the keypress is a decimal point and none exists then allows input
                e.Handled = False
            ElseIf Char.IsDigit(e.KeyChar) Then  'If the keypress is a digit then checks if there is a decimal point
                If sender.Text.IndexOf(".") <> -1 Then
                    'Handles if there are 2 numbers after the decimal point
                    If sender.Text.Length >= sender.Text.IndexOf(".") + 3 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
        'Allow backspace in textbox
        If e.KeyChar = Chr(&H8) Then
            e.Handled = False
        End If
    End Sub
End Class
