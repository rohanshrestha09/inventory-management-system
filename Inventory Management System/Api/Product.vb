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
End Class
