Imports MySql.Data.MySqlClient

Public Class Order
    Public Shared Function GetMostRecentOrders(ByVal GetAllOrdersArgs As GetAllOrdersArgs) As DataTable
        Database.Connection.Open()

        Dim Query As String = "SELECT order_id as 'Order ID', total_amount as 'Total Order Amount', created_at as 'Ordered At', delivery_status as 'Delivery Status', payment_method as 'Payment Method' " &
            "WHERE (users.user_id = @UserID OR @UserID IS NULL) " &
            "ORDER BY created_at DESC " &
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

        Dim Query As String = "SELECT orders.order_id as 'Order ID', users.name as 'Customer', users.shop_name as 'Shop Name', orders.total_amount as 'Total Order Amount', orders.created_at as 'Ordered At', orders.delivery_status as 'Delivery Status', orders.payment_method as 'Payment Method' " &
            "FROM orders INNER JOIN users on users.user_id = orders.user_id " &
            "WHERE (users.name LIKE @Search) AND (users.user_id = @UserID OR @UserID IS NULL) " &
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

    Public Shared Function CreateOrder(ByVal CreateOrderArgs As CreateOrderArgs)
        Database.Connection.Open()

        Dim Query As String = "INSERT INTO TableName (Column1, Column2, Column3) VALUES (@Value1, @Value2, @Value3)"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@Value1", CreateOrderArgs.UserID)

        Command.Parameters.AddWithValue("@Value2", CreateOrderArgs.ProductID)

        Command.Parameters.AddWithValue("@Value3", CreateOrderArgs.DeliveryStatus)

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
    Public UserID As String
    Public ProductID As String
    Public DeliveryStatus As String
    Public PaymentMethod As String
End Class