Imports System.IO.Pipelines

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

    Private Sub OrdersTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersTable.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim OrderID As String = OrdersTable.Rows(e.RowIndex).Cells("Order ID").Value.ToString()

            Dashboard.DashboardContainer.Controls.Clear()

            UpdateOrderForm.TopLevel = False

            Dashboard.DashboardContainer.Controls.Add(UpdateOrderForm)

            UpdateOrderForm.OrderID = OrderID

            UpdateOrderForm.Show()

            Try
                Dim AuthUser = User.GetUser(LoginForm.UserID)

                Dim SelectedOrder = Order.GetOrder(OrderID)

                UpdateOrderForm.TotalAmount.Text = SelectedOrder.Item("total_amount")

                UpdateOrderForm.TotalUnits.Text = SelectedOrder.Item("total_units")

                UpdateOrderForm.TotalPaidAmount.Text = SelectedOrder.Item("total_paid_amount")

                UpdateOrderForm.DeliveryStatus.Text = SelectedOrder.Item("delivery_status")

                UpdateOrderForm.PaymentMethod.Text = SelectedOrder.Item("payment_method")

                UpdateOrderForm.Price.Text = SelectedOrder.Item("price")

                UpdateOrderForm.Brand.Text = SelectedOrder.Item("brand")

                UpdateOrderForm.Quantity.Text = SelectedOrder.Item("quantity")

                UpdateOrderForm.Products.SelectedValue = Integer.Parse(SelectedOrder.Item("product_id"))

                UpdateOrderForm.ShopName.Text = SelectedOrder.Item("shop_name")

                UpdateOrderForm.Customers.SelectedValue = Integer.Parse(SelectedOrder.Item("user_id"))

                If (AuthUser.Item("role") <> "ADMIN") Then
                    UpdateOrderForm.UpdateOrderButton.Enabled = False
                End If
            Catch Ex As Exception
                MsgBox(Ex.Message)
            End Try
        End If
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
