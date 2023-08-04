Public Class OrderForm
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            Dim GetAllOrdersArgs = New GetAllOrdersArgs With {
                .Search = SearchInput.Text,
                  .UserID = If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id")))
            }

            Dim DataTable = Order.GetAllOrders(GetAllOrdersArgs)

            OrdersTable.DataSource = DataTable

            If (AuthUser.Item("role") <> "ADMIN") Then
                CreateOrderButton.Enabled = False
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub SearchInput_GotFocus(sender As Object, e As EventArgs) Handles SearchInput.GotFocus
        SearchInputPanel.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub SearchInput_LostFocus(sender As Object, e As EventArgs) Handles SearchInput.LostFocus
        SearchInputPanel.BorderStyle = BorderStyle.None
    End Sub

    Private Sub SearchInput_TextChanged(sender As Object, e As EventArgs) Handles SearchInput.TextChanged
        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            Dim GetAllOrdersArgs = New GetAllOrdersArgs With {
                .Search = SearchInput.Text,
                  .UserID = If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id")))
            }

            Dim DataTable = Order.GetAllOrders(GetAllOrdersArgs)

            OrdersTable.DataSource = DataTable
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub CreateOrderButton_Click(sender As Object, e As EventArgs) Handles CreateOrderButton.Click
        Dashboard.DashboardContainer.Controls.Clear()

        CreateOrderForm.TopLevel = False

        Dashboard.DashboardContainer.Controls.Add(CreateOrderForm)

        CreateOrderForm.Show()
    End Sub
End Class
