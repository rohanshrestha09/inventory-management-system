Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Order
    Public Function GetPaginatedOrders(ByVal Page As Integer, Size As Integer)
        Database.Connection.Open()

        Dim Query As String = $"SELECT * FROM orders LIMIT @Size OFFSET @Page"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@Size", Size)

        Command.Parameters.AddWithValue("@Page", Page - 1)

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet, "orders")

        Dim Records As DataRowCollection

        Records = DataSet.Tables("orders").Rows

        Database.Connection.Close()

        Return Records
    End Function

    Public Function GetAllOrders(ByVal Search As String)
        Database.Connection.Open()

        Dim Query As String = $"SELECT * FROM orders JOIN users ON orders.user_id = users.user_id WHERE users.name LIKE %@Search%"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@Search", Search)

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet, "orders")

        Dim Records As DataRowCollection

        Records = DataSet.Tables("orders").Rows

        Database.Connection.Close()

        Return Records
    End Function

    Public Function CreateOrder(ByVal CreateOrderArgs As CreateOrderArgs)
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

Public Class CreateOrderArgs
    Public UserID As String
    Public ProductID As String
    Public DeliveryStatus As String
    Public PaymentMethod As String
End Class