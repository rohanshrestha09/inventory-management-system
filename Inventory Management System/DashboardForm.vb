Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim AuthUser = User.GetUser(LoginForm.UserID)

        UserName.Text = $"Welcome {AuthUser.Item("name")}"

        PhoneNumber.Text = AuthUser.Item("phone")

        Address.Text = AuthUser.Item("address")

        DateOfBirth.Text = AuthUser.Item("date_of_birth")

        RegisteredAt.Text = AuthUser.Item("created_at")

        Dim RowsData As Object = {
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"}
            }

        For rowIndex As Integer = 0 To RowsData.GetUpperBound(0)
            Dim Row = New DataGridViewRow()

            Row.CreateCells(RecentOrdersTable)

            For colIndex As Integer = 0 To RowsData.GetUpperBound(1)
                Row.Cells(colIndex).Value = RowsData(rowIndex, colIndex)
            Next colIndex

            RecentOrdersTable.Rows.Add(Row)
        Next rowIndex

    End Sub

    Private Sub OrdersKPITimeSelector_SelectedValueChanged(sender As Object, e As EventArgs) Handles OrderKPITimeSelector.SelectedValueChanged
        MsgBox(OrderKPITimeSelector.SelectedItem.ToString())
    End Sub
End Class