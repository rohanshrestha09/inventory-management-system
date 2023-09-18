Public Class Account
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            UserName.Text = AuthUser.Item("name")

            Phone.Text = AuthUser.Item("phone")

            Address.Text = AuthUser.Item("address")

            ShopName.Text = AuthUser.Item("shop_name")

            DateOfBirth.Text = AuthUser.Item("date_of_birth")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.Connection.Close()
        End Try
    End Sub

    Private Sub UpdateProfileButton_Click(sender As Object, e As EventArgs) Handles UpdateProfileButton.Click
        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            Dim UpdateUserArgs = New UpdateUserArgs With {
                .UserID = LoginForm.UserID,
                .UserName = UserName.Text,
                .Address = Address.Text,
                .ShopName = ShopName.Text,
                .Password = If(Password.Text = "", AuthUser.Item("password"), Password.Text)
            }

            User.UpdateUser(UpdateUserArgs)

            MsgBox("User Updated")

            AuthUser = User.GetUser(LoginForm.UserID)

            Password.Text = ""

            DashboardForm.UserName.Text = $"Welcome {AuthUser.Item("name")}"

            DashboardForm.Address.Text = AuthUser.Item("address")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.Connection.Close()
        End Try

    End Sub
End Class