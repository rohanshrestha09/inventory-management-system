Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            UserName.Text = $"Welcome {AuthUser.Item("name")}"

            PhoneNumber.Text = AuthUser.Item("phone")

            Address.Text = AuthUser.Item("address")

            DateOfBirth.Text = AuthUser.Item("date_of_birth")

            RegisteredAt.Text = AuthUser.Item("created_at")

            Dim GetAllOrdersArgs = New GetAllOrdersArgs With {
                .Page = 1,
                .Size = 4,
                .UserID = If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id")))
            }

            Dim DataTable = Order.GetMostRecentOrders(GetAllOrdersArgs)

            RecentOrdersTable.DataSource = DataTable
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub OrdersKPITimeSelector_SelectedValueChanged(sender As Object, e As EventArgs) Handles OrderKPITimeSelector.SelectedValueChanged
        MsgBox(OrderKPITimeSelector.SelectedItem.ToString())
    End Sub
End Class