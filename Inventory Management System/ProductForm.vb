Public Class ProductForm
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AuthUser = User.GetUser(LoginForm.UserID)

            Dim DataTable = Product.GetAllProducts(SearchInput.Text)

            ProductsTable.DataSource = DataTable

            If (AuthUser.Item("role") <> "ADMIN") Then
                CreateProductButton.Enabled = False
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub ProductsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsTable.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim ProductID As String = ProductsTable.Rows(e.RowIndex).Cells("Product ID").Value.ToString()

            Dashboard.DashboardContainer.Controls.Clear()

            UpdateProductForm.TopLevel = False

            Dashboard.DashboardContainer.Controls.Add(UpdateProductForm)

            UpdateProductForm.ProductID = ProductID

            UpdateProductForm.Show()
        End If
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

    Private Sub CreateProductButton_Click(sender As Object, e As EventArgs) Handles CreateProductButton.Click
        Dashboard.DashboardContainer.Controls.Clear()

        CreateProductForm.TopLevel = False

        Dashboard.DashboardContainer.Controls.Add(CreateProductForm)

        CreateProductForm.Show()
    End Sub
End Class