Public Class CreateProductForm
    Private Sub CreateProductButton_Click(sender As Object, e As EventArgs) Handles CreateProductButton.Click
        Try
            Dim CreateProductArgs = New CreateProductArgs With {
                .ProductName = ProductName.Text,
                .ProductSkuName = ProductSkuName.Text,
                .Price = Decimal.Parse(Price.Text),
                .Quantity = Integer.Parse(Quantity.Text),
                .Description = Description.Text,
                .Brand = Brand.Text,
                .Category = Category.Text
            }

            Product.CreateProduct(CreateProductArgs)

            MsgBox("Product Created")

            Dashboard.DashboardContainer.Controls.Clear()

            ProductForm.TopLevel = False

            Dashboard.DashboardContainer.Controls.Add(ProductForm)

            Dim DataTable = Product.GetAllProducts(ProductForm.SearchInput.Text)

            ProductForm.ProductsTable.DataSource = DataTable

            ProductForm.Show()
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dashboard.DashboardContainer.Controls.Clear()

        ProductForm.TopLevel = False

        Dashboard.DashboardContainer.Controls.Add(ProductForm)

        ProductForm.Show()
    End Sub
End Class