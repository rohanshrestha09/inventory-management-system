Public Class OrderForm
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RowsData As Object = {
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"},
            {2000, 500000, "Jun 13, 2022", "Delivered", "Esewa"}
}
        For rowIndex As Integer = 0 To RowsData.GetUpperBound(0)
            Dim Row = New DataGridViewRow()

            Row.CreateCells(OrdersTable)

            For colIndex As Integer = 0 To RowsData.GetUpperBound(1)
                Row.Cells(colIndex).Value = RowsData(rowIndex, colIndex)
            Next colIndex

            OrdersTable.Rows.Add(Row)
        Next rowIndex
    End Sub

    Private Sub SearchInput_GotFocus(sender As Object, e As EventArgs) Handles SearchInput.GotFocus
        SearchInputPanel.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub SearchInput_LostFocus(sender As Object, e As EventArgs) Handles SearchInput.LostFocus
        SearchInputPanel.BorderStyle = BorderStyle.None
    End Sub
End Class
