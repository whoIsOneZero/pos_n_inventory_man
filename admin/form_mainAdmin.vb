Public Class form_mainAdmin
    Private Sub btn_manageProducts_Click(sender As Object, e As EventArgs) Handles btn_manageProducts.Click
        form_manageProducts.ShowDialog()

    End Sub

    Private Sub btn_manageStock_Click(sender As Object, e As EventArgs) Handles btn_manageStock.Click
        form_manageStock.ShowDialog()
    End Sub

    Private Sub btn_manageUsers_Click(sender As Object, e As EventArgs) Handles btn_manageUsers.Click
        form_manageUser.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        form_login.Show()
    End Sub
End Class