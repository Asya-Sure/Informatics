Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number = TextBoxNumber.Text, sum = 0, counter As Integer
        For counter = -3 To 27
            sum = sum + counter
        Next counter
        TextBoxResult.Text = sum



    End Sub
End Class
