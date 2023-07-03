Public Class Dashboard
    Sub SwitchPanel(ByVal Panel As Form)
        DashboardContainer.Controls.Clear()
        Panel.TopLevel = False
        DashboardContainer.Controls.Add(Panel)
        Panel.Show()
    End Sub

    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles ProductButton.Click
        SwitchPanel(LoginForm)
    End Sub
End Class