Imports MySql.Data.MySqlClient

Public Class PaymentMethodEnum
    Public Const CASH = "CASH"
    Public Const KHALTI = "KHALTI"
    Public Const ESEWA = "ESEWA"
    Public Const BANK = "BANK"

    Public Shared Function GetCollection() As String()
        Return {CASH, KHALTI, ESEWA, BANK}
    End Function
End Class

Public Class DeliveryStatusEnum
    Public Const COMPLETED = "COMPLETED"
    Public Const IN_PROCESS = "IN_PROCESS"
    Public Const CANCELLED = "CANCELLED"

    Public Shared Function GetCollection() As String()
        Return {COMPLETED, IN_PROCESS, CANCELLED}
    End Function
End Class

Public Class Order
    Public Shared Function GetMostRecentOrders(ByVal GetAllOrdersArgs As GetAllOrdersArgs) As DataTable
        Database.Connection.Open()

        Dim Query As String = "SELECT order_id as 'Order ID', users.name as 'Customer', users.shop_name as 'Shop Name', total_amount as 'Total Order Amount', orders.created_at as 'Ordered At', delivery_status as 'Delivery Status', payment_method as 'Payment Method' " &
            "FROM orders INNER JOIN users on users.user_id = orders.user_id " &
            "WHERE (users.user_id = @UserID OR @UserID IS NULL) " &
            "ORDER BY orders.created_at DESC " &
            If(GetAllOrdersArgs.Size > 0, "LIMIT @Size OFFSET @Page", "")

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@Search", "%" & GetAllOrdersArgs.Search & "%")

        Command.Parameters.AddWithValue("@UserId", If(GetAllOrdersArgs.UserID = 0, DBNull.Value, GetAllOrdersArgs.UserID))

        Command.Parameters.AddWithValue("@Size", GetAllOrdersArgs.Size)

        Command.Parameters.AddWithValue("@Page", (GetAllOrdersArgs.Page - 1) * GetAllOrdersArgs.Size)

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataTable As New DataTable()

        Adapter.Fill(DataTable)

        Database.Connection.Close()

        Return DataTable
    End Function

    Public Shared Function GetAllOrders(ByVal GetAllOrdersArgs As GetAllOrdersArgs) As DataTable
        Database.Connection.Open()

        Dim Query As String = "SELECT o.order_id as 'Order ID', u.name as 'Customer', u.shop_name as 'Shop Name', p.name as 'Product', p.quantity as 'Quantity', o.total_units as 'Total Units', o.total_amount as 'Total Amount', o.total_paid_amount as 'Paid Amount', o.created_at as 'Ordered At', o.delivery_status as 'Delivery Status', o.payment_method as 'Payment Method' " &
            "FROM orders o INNER JOIN users u on u.user_id = o.user_id INNER JOIN products p on p.product_id = o.product_id " &
            "WHERE (u.name LIKE @Search) AND (u.user_id = @UserID OR @UserID IS NULL) " &
            "ORDER BY o.created_at DESC " &
            If(GetAllOrdersArgs.Size > 0, "LIMIT @Size OFFSET @Page", "")

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@Search", "%" & GetAllOrdersArgs.Search & "%")

        Command.Parameters.AddWithValue("@UserId", If(GetAllOrdersArgs.UserID = 0, DBNull.Value, GetAllOrdersArgs.UserID))

        Command.Parameters.AddWithValue("@Size", GetAllOrdersArgs.Size)

        Command.Parameters.AddWithValue("@Page", (GetAllOrdersArgs.Page - 1) * GetAllOrdersArgs.Size)

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataTable As New DataTable()

        Adapter.Fill(DataTable)

        Database.Connection.Close()

        Return DataTable
    End Function

    Public Shared Function CreateOrder(ByVal CreateOrderArgs As CreateOrderArgs)
        Database.Connection.Open()

        Dim Query As String = "insert into orders (user_id, product_id, total_amount, total_paid_amount, total_units, delivery_status, payment_method) " &
        "values (@UserID, @ProductID, @TotalAmount, @TotalPaidAmount, @TotalUnits, @DeliveryStatus, @PaymentMethod)"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@UserID", CreateOrderArgs.UserID)

        Command.Parameters.AddWithValue("@ProductID", CreateOrderArgs.ProductID)

        Command.Parameters.AddWithValue("@TotalAmount", CreateOrderArgs.TotalAmount)

        Command.Parameters.AddWithValue("@TotalPaidAmount", CreateOrderArgs.TotalPaidAmount)

        Command.Parameters.AddWithValue("@TotalUnits", CreateOrderArgs.TotalUnits)

        Command.Parameters.AddWithValue("@DeliveryStatus", CreateOrderArgs.DeliveryStatus)

        Command.Parameters.AddWithValue("@PaymentMethod", CreateOrderArgs.PaymentMethod)

        If Command.ExecuteNonQuery() < 0 Then
            Database.Connection.Close()
            Throw New Exception("Something went wrong")
        End If

        Database.Connection.Close()
    End Function

    Public Shared Function GetOrderAnalytics(ByVal UserID As Integer) As DataRow
        Database.Connection.Open()

        Dim Query As String = "SELECT count(order_id) as 'total_orders', sum(total_amount) as 'total_orders_amount', sum(case when delivery_status = 'COMPLETED' then 1 else 0 end) as 'total_orders_delivered' FROM orders " &
                "WHERE (orders.user_id = @UserID OR @UserID IS NULL)"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@UserId", If(UserID = 0, DBNull.Value, UserID))

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet, "orders")

        Dim Record As DataRow = Nothing

        If DataSet.Tables("orders").Rows.Count > 0 Then
            Record = DataSet.Tables("orders").Rows(0)
        End If

        Database.Connection.Close()

        Return Record
    End Function

    Public Shared Function GetOrder(ByVal OrderID As Integer) As DataRow
        Database.Connection.Open()

        Dim Query As String = "SELECT * FROM orders INNER JOIN users ON users.user_id = orders.user_id INNER JOIN products on products.product_id = orders.product_id WHERE order_id = @OrderID;"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@OrderID", OrderID)

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet, "orders")

        Dim Record As DataRow

        If DataSet.Tables("orders").Rows.Count > 0 Then
            Record = DataSet.Tables("orders").Rows(0)
        Else
            Database.Connection.Close()
            Throw New Exception("Record not found")
        End If

        Database.Connection.Close()

        Return Record
    End Function

    Public Shared Function UpdateOrder(ByVal CreateOrderArgs As CreateOrderArgs)
        Database.Connection.Open()

        Dim Query As String = "UPDATE orders SET total_amount = @TotalAmount, total_paid_amount = @TotalPaidAmount, total_units = @TotalUnits, delivery_status = @DeliveryStatus, payment_method = @PaymentMethod where order_id = @OrderID;"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@OrderID", CreateOrderArgs.OrderID)

        Command.Parameters.AddWithValue("@TotalAmount", CreateOrderArgs.TotalAmount)

        Command.Parameters.AddWithValue("@TotalPaidAmount", CreateOrderArgs.TotalPaidAmount)

        Command.Parameters.AddWithValue("@TotalUnits", CreateOrderArgs.TotalUnits)

        Command.Parameters.AddWithValue("@DeliveryStatus", CreateOrderArgs.DeliveryStatus)

        Command.Parameters.AddWithValue("@PaymentMethod", CreateOrderArgs.PaymentMethod)

        If Command.ExecuteNonQuery() < 0 Then
            Database.Connection.Close()
            Throw New Exception("Something went wrong")
        End If

        Database.Connection.Close()
    End Function

    Public Shared Function DeleteOrder(ByVal OrderID As Integer)
        Database.Connection.Open()

        Dim Query As String = "DELETE FROM orders where order_id = @OrderID;"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@OrderID", OrderID)

        If Command.ExecuteNonQuery() < 0 Then
            Database.Connection.Close()
            Throw New Exception("Something went wrong")
        End If

        Database.Connection.Close()
    End Function
End Class

Public Class GetAllOrdersArgs
    Public UserID As Integer
    Public Search As String
    Public Page As Integer
    Public Size As Integer
End Class

Public Class CreateOrderArgs
    Public OrderID As Integer
    Public UserID As Integer
    Public ProductID As Integer
    Public TotalUnits As Integer
    Public TotalAmount As Double
    Public TotalPaidAmount As Double
    Public DeliveryStatus As String
    Public PaymentMethod As String
End Class