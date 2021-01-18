Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        x = TextBoxNumber.Text
        If x = 8 Then
            TextBoxResult.Text = "Введене число дорівнює 8"
            BackColor = Color.Red
        Else
            TextBoxResult.Text = "Введенне число нe рівне 8"
            BackColor = Color.Blue
            If x = 10 Then
                TextBoxResult.Text = "Введене число дорівнює 10"
                BackColor = Color.Red
            Else
                TextBoxResult.Text = "Введенне число нe рівне"
                BackColor = Color.Blue

            End If
        End If
    End Sub
End Class
