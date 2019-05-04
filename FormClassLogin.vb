Public Class FormClassLogin
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Oracle.UserName = UserName.Text
        Oracle.Password = Password.Text
        Oracle.Server = Server.Text

        Oracle.result = Oracle.ResponseType.OK

        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Oracle.Result = Oracle.ResponseType.Cancel

        Me.Close()
    End Sub
End Class
