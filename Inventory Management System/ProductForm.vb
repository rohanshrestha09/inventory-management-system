Public Class ProductForm
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DataTable = Product.GetAllProducts(SearchInput.Text)

            ProductsTable.DataSource = DataTable
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
            Dim DataTable = Product.GetAllProducts(SearchInput.Text)

            ProductsTable.DataSource = DataTable
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub
End Class