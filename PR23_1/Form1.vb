Public Class Form1
    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim number = TextBoxN.Text, counter As Integer

        For counter = 0 To number Step +2
            TextBoxResult.Text = TextBoxResult.Text + " " + counter.ToString
        Next counter


    End Sub


End Class
