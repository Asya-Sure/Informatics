Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        x = TextBoxX.Text
        y = TextBoxY.Text

        If 0 <= x <= 3.14 And y <= Math.Sin(x) Then
            TextBoxResult.Text = "належить"
        Else
            TextBoxResult.Text = "не належить"
        End If
    End Sub
End Class
