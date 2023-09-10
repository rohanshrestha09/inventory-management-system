Public Class UpdateProductForm
    Public Shared ProductID As String

    Private Sub UpdateProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            Dim SelectedProduct = Product.GetProduct(ProductID)

            ProductName.Text = SelectedProduct.Item("name")

            ProductSkuName.Text = SelectedProduct.Item("sku_name")

            Price.Text = SelectedProduct.Item("price")

            Quantity.Text = SelectedProduct.Item("quantity")

            Description.Text = SelectedProduct.Item("description")

            Brand.Text = SelectedProduct.Item("brand")

            Category.Text = SelectedProduct.Item("category")

            If (AuthUser.Item("role") <> "ADMIN") Then
                UpdateProductButton.Enabled = False
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub UpdateProductButton_Click(sender As Object, e As EventArgs) Handles UpdateProductButton.Click
        Try
            Dim CreateProductArgs = New CreateProductArgs With {
                .ProductID = ProductID,
                .ProductName = ProductName.Text,
                .ProductSkuName = ProductSkuName.Text,
                .Price = Decimal.Parse(Price.Text),
                .Quantity = Integer.Parse(Quantity.Text),
                .Description = Description.Text,
                .Brand = Brand.Text,
                .Category = Category.Text
            }

            Product.UpdateProduct(CreateProductArgs)

            MsgBox("Product Updated")

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

    Private Sub DeleteProductButton_Click(sender As Object, e As EventArgs) Handles DeleteProductButton.Click
        Dim Action = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Action = DialogResult.Yes Then
            Try
                Product.DeleteProduct(ProductID)

                MsgBox("Product Deleted")

                Dashboard.DashboardContainer.Controls.Clear()

                ProductForm.TopLevel = False

                Dashboard.DashboardContainer.Controls.Add(ProductForm)

                Dim DataTable = Product.GetAllProducts(ProductForm.SearchInput.Text)

                ProductForm.ProductsTable.DataSource = DataTable

                ProductForm.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class