Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        x = TextBoxX.Text
        y = TextBoxY.Text
        If x < 0 Then
            z = x ^ 2 + y
            TextBoxZ.Text = Z
        Else
            z = x ^ 2 + x
            TextBoxZ.Text = Z

        End If

    End Sub
End Class
