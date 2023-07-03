Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub PhoneNumberInput_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumberInput.TextChanged

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If (PhoneNumberInput.Text = "9800000000" And PasswordInput.Text = "admin") Then
            Hide()
            Dashboard.ShowDialog()

        Else
            MsgBox("Invalid Credentials")
        End If
    End Sub

    Private Sub PasswordInput_TextChanged(sender As Object, e As EventArgs) Handles PasswordInput.TextChanged

    End Sub


    Private Sub ShowPasswordCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckbox.CheckedChanged
        PasswordInput.PasswordChar = If(ShowPasswordCheckbox.Checked, ControlChars.NullChar, "•")
    End Sub

    Private Sub CancelLoginButton_Click(sender As Object, e As EventArgs) Handles CancelLoginButton.Click
        Close()
    End Sub
End Class
