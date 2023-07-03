

Public Class Dashboard
    Private Sub SwitchPanel(ByVal Form As Form, ActivePanel As Panel)
        DashboardContainer.Controls.Clear()
        Form.TopLevel = False
        DashboardContainer.Controls.Add(Form)
        Form.Show()

        Dim Panels = New Panel() {DashboardPanel, ProductPanel, OrderPanel, AccountPanel}

        For Each Panel In Panels
            Panel.BackColor = If(ActivePanel Is Panel, Color.FromArgb(CByte(184), CByte(135), CByte(70)), Color.Transparent)
        Next
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(DashboardForm, DashboardPanel)
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        SwitchPanel(DashboardForm, DashboardPanel)
    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        SwitchPanel(OrderForm, OrderPanel)
    End Sub
End Class