Imports MySql.Data.MySqlClient

Public Class Order
    Public Function GetPaginatedOrders(ByVal Page As Integer, Size As Integer)
        Dim Data As Object(,) = Nothing

        Dim RowIndex As Integer = 0


        Database.Connection.Open()

        Dim Query As String = $"SELECT * FROM orders LIMIT {Size} OFFSET {Page - 1}"

        Dim Command As New MySqlCommand(Query)

        Database.Connection.Close()

        Return Data
    End Function

    'Public Function GetAllOrders(ByVal Search As String)
    '    Dim Data As Object(,) = Nothing

    '    Dim RowIndex As Integer = 0

    '    Using Connection As New SqlConnection(DatabaseConnection.ConnectionString)
    '        Connection.Open()

    '        Dim Query As String = $"SELECT * FROM orders WHERE customers LIKE %{Search}%"

    '        Using Command As New SqlCommand(Query, Connection)
    '            Using Reader As SqlDataReader = Command.ExecuteReader()
    '                While Reader.Read()
    '                    Data(RowIndex, 0) = Reader("Column1").ToString()
    '                    Data(RowIndex, 1) = Convert.ToInt32(Reader("Column2"))
    '                    Data(RowIndex, 2) = Convert.ToDateTime(Reader("Column3"))

    '                    RowIndex += 1
    '                End While
    '            End Using
    '        End Using

    '        Connection.Close()
    '    End Using

    '    Return Data
    'End Function

    'Public Function CreateOrder(ByVal CreateOrderArgs As CreateOrderArgs)
    '    Using Connection As New SqlConnection(DatabaseConnection.ConnectionString)
    '        Connection.Open()

    '        Dim Query As String = "INSERT INTO TableName (Column1, Column2, Column3) VALUES (@Value1, @Value2, @Value3)"

    '        Using Command As New SqlCommand(Query, Connection)
    '            Command.Parameters.AddWithValue("@Value1", CreateOrderArgs.UserID)
    '            Command.Parameters.AddWithValue("@Value2", CreateOrderArgs.ProductID)
    '            Command.Parameters.AddWithValue("@Value3", CreateOrderArgs.DeliveryStatus)

    '            Command.ExecuteNonQuery()
    '        End Using

    '        Connection.Close()
    '    End Using
    'End Function
End Class

Public Class CreateOrderArgs
    Public UserID As String
    Public ProductID As String
    Public DeliveryStatus As String
    Public PaymentMethod As String
End Class