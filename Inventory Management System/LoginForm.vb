Public Class LoginForm

    Public Shared UserID As String
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            Dim Record = User.Login(PhoneNumberInput.Text, PasswordInput.Text)

            UserID = Record.Item("user_id")

            Hide()

            Dashboard.ShowDialog()
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
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
