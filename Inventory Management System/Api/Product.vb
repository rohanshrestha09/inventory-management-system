Imports MySql.Data.MySqlClient

Public Class Product
    Public Shared Function GetAllProducts(ByVal Search As String) As DataTable
        Database.Connection.Open()

        Dim Query As String = $"SELECT product_id as 'Product ID', name as 'Name', sku_name as 'SKU Name', price as 'Price', quantity as 'Quantity', brand as 'Brand', category as 'Category' FROM products WHERE name LIKE @Search ORDER BY created_at DESC"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@Search", "%" & Search & "%")

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataTable As New DataTable()

        Adapter.Fill(DataTable)

        Database.Connection.Close()

        Return DataTable
    End Function

    Public Shared Function CreateProduct(ByVal CreateProductArgs As CreateProductArgs)
        Database.Connection.Open()

        Dim Query As String = "INSERT INTO products (name, sku_name, price, quantity, description, brand, category) " &
                              "VALUES (@ProductName, @ProductSkuName, @Price, @Quantity, @Description, @Brand, @Category)"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@productName", CreateProductArgs.ProductName)

        Command.Parameters.AddWithValue("@ProductSkuName", CreateProductArgs.ProductSkuName)

        Command.Parameters.AddWithValue("@Price", CreateProductArgs.Price)

        Command.Parameters.AddWithValue("@Quantity", CreateProductArgs.Quantity)

        Command.Parameters.AddWithValue("@Description", CreateProductArgs.Description)

        Command.Parameters.AddWithValue("@Brand", CreateProductArgs.Brand)

        Command.Parameters.AddWithValue("@Category", CreateProductArgs.Category)

        If Command.ExecuteNonQuery() < 0 Then
            Database.Connection.Close()
            Throw New Exception("Something went wrong")
        End If

        Database.Connection.Close()
    End Function
End Class

Public Class CreateProductArgs
    Public ProductName As String
    Public ProductSkuName As String
    Public Price As Decimal
    Public Quantity As Integer
    Public Description As String
    Public Brand As String
    Public Category As String
End Class
