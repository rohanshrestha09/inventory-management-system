Public Class UpdateOrderForm
    Public Shared OrderID As String

    Private ProductList As ProductJSON()

    Private UserList As UserJSON()

    Private Sub UpdateOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DeliveryStatus.Items.AddRange(DeliveryStatusEnum.GetCollection())

        DeliveryStatus.SelectedItem = DeliveryStatusEnum.IN_PROCESS

        PaymentMethod.Items.AddRange(PaymentMethodEnum.GetCollection())

        PaymentMethod.SelectedItem = PaymentMethodEnum.CASH

        Dim ProductDictionary As New Dictionary(Of Integer, String)()

        Dim UserDictionary As New Dictionary(Of Integer, String)()

        Try
            ProductList = Product.GetAllProductsJSON()

            For Each Product In ProductList
                ProductDictionary.Add(Product.ProductID, Product.ProductName)
            Next

            Products.DataSource = New BindingSource(ProductDictionary, Nothing)

            Products.DisplayMember = "Value"

            Products.ValueMember = "Key"
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try

        Try
            UserList = User.GetAllUsersJSON()

            For Each User In UserList
                UserDictionary.Add(User.UserID, User.UserName & " " & User.Phone & " " & User.ShopName)
            Next

            Customers.DataSource = New BindingSource(UserDictionary, Nothing)

            Customers.DisplayMember = "Value"

            Customers.ValueMember = "Key"
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try

        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            Dim SelectedOrder = Order.GetOrder(OrderID)

            TotalAmount.Text = SelectedOrder.Item("total_amount")

            TotalUnits.Text = SelectedOrder.Item("total_units")

            TotalPaidAmount.Text = SelectedOrder.Item("total_paid_amount")

            DeliveryStatus.Text = SelectedOrder.Item("delivery_status")

            PaymentMethod.Text = SelectedOrder.Item("payment_method")

            Price.Text = SelectedOrder.Item("price")

            Brand.Text = SelectedOrder.Item("brand")

            Quantity.Text = SelectedOrder.Item("quantity")

            Products.SelectedValue = Integer.Parse(SelectedOrder.Item("product_id"))

            ShopName.Text = SelectedOrder.Item("shop_name")

            Customers.SelectedValue = Integer.Parse(SelectedOrder.Item("user_id"))

            If (AuthUser.Item("role") <> "ADMIN") Then
                UpdateOrderButton.Enabled = False
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub Products_SelectedValueChanged(sender As Object, e As EventArgs) Handles Products.SelectedValueChanged, TotalUnits.TextChanged
        If (Products.SelectedValue Is Nothing OrElse TypeOf Products.SelectedValue IsNot Integer) Then Return

        Dim SelectedProductID As Integer = Products.SelectedValue

        Dim SelectedProduct As ProductJSON = ProductList.FirstOrDefault(Function(P) P.ProductID = SelectedProductID)

        If SelectedProduct IsNot Nothing Then
            Dim CurrentTotalUnits As Integer

            If Integer.TryParse(TotalUnits.Text, CurrentTotalUnits) Then
                TotalAmount.Text = (CurrentTotalUnits * SelectedProduct.Price).ToString()
            Else
                TotalAmount.Text = "0"
            End If
        End If

        If sender Is Products Then
            Price.Text = SelectedProduct.Price

            Quantity.Text = SelectedProduct.Quantity

            Brand.Text = SelectedProduct.Brand

            Category.Text = SelectedProduct.Category
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dashboard.DashboardContainer.Controls.Clear()

        OrderForm.TopLevel = False

        Dashboard.DashboardContainer.Controls.Add(OrderForm)

        OrderForm.Show()
    End Sub

    Private Sub DeleteOrderButton_Click(sender As Object, e As EventArgs) Handles DeleteOrderButton.Click
        Dim Action = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Action = DialogResult.Yes Then
            Try
                Order.DeleteOrder(OrderID)

                MsgBox("Order Deleted")

                Dashboard.DashboardContainer.Controls.Clear()

                OrderForm.TopLevel = False

                Dashboard.DashboardContainer.Controls.Add(OrderForm)

                Dim AuthUser = User.GetUser(LoginForm.UserID)

                Dim GetAllOrdersArgs = New GetAllOrdersArgs With {
                .Search = OrderForm.SearchInput.Text,
                  .UserID = If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id")))
                }

                Dim DataTable = Order.GetAllOrders(GetAllOrdersArgs)

                OrderForm.OrdersTable.DataSource = DataTable

                If (AuthUser.Item("role") <> "ADMIN") Then
                    OrderForm.CreateOrderButton.Enabled = False
                End If

                OrderForm.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub UpdateOrderButton_Click(sender As Object, e As EventArgs) Handles UpdateOrderButton.Click
        Try
            Dim CreateOrderArgs = New CreateOrderArgs With {
                .OrderID = OrderID,
                .DeliveryStatus = DeliveryStatus.Text,
                .PaymentMethod = PaymentMethod.Text,
                .TotalAmount = Double.Parse(TotalAmount.Text),
                .TotalPaidAmount = Double.Parse(TotalPaidAmount.Text),
                .TotalUnits = Double.Parse(TotalUnits.Text)
            }

            Order.UpdateOrder(CreateOrderArgs)

            MsgBox("Order Updated")

            Dashboard.DashboardContainer.Controls.Clear()

            OrderForm.TopLevel = False

            Dashboard.DashboardContainer.Controls.Add(OrderForm)

            Dim AuthUser = User.GetUser(LoginForm.UserID)

            Dim GetAllOrdersArgs = New GetAllOrdersArgs With {
                .Search = "",
                  .UserID = If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id")))
            }

            Dim DataTable = Order.GetAllOrders(GetAllOrdersArgs)

            OrderForm.OrdersTable.DataSource = DataTable

            OrderForm.Show()

            DashboardForm.RecentOrdersTable.DataSource = Order.GetMostRecentOrders(New GetAllOrdersArgs With {
               .Page = 1,
               .Size = 4,
               .UserID = If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id")))
           })

            Dim OrderAnalytics = Order.GetOrderAnalytics(If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id"))))

            If (OrderAnalytics IsNot Nothing) Then
                DashboardForm.TotalOrders.Text = OrderAnalytics.Item("total_orders")

                DashboardForm.TotalOrdersDelivered.Text = OrderAnalytics.Item("total_orders_delivered")

                DashboardForm.TotalOrdersAmount.Text = "Rs. " & OrderAnalytics.Item("total_orders_amount")
            End If

            Dim MostBoughtProduct = Product.GetMostBoughtProduct(If(AuthUser.Item("role") = "ADMIN", 0, Integer.Parse(AuthUser.Item("user_id"))))

            If (MostBoughtProduct IsNot Nothing) Then
                DashboardForm.MostBoughtProductName.Text = MostBoughtProduct.Item("product_name")

                DashboardForm.MostBoughtProductTotalAmount.Text = "Rs. " & MostBoughtProduct.Item("total_amount")

                DashboardForm.MostBoughtProductTotalUnits.Text = MostBoughtProduct.Item("total_units")
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Database.Connection.Close()
        End Try

    End Sub
End Class