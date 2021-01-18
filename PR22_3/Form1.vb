Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X0, Y0, X, Y, R As Integer
        X0 = TextBoxX0.Text
        Y0 = TextBoxY0.Text
        X = TextBoxX.Text
        Y = TextBoxY.Text
        R = TextBoxR.Text

        If ((X - X0) ^ 2 + (Y - Y0) ^ 2) <= R ^ 2 Then
            TextBoxResult.Text = "Точка А налижить площі кола"
        Else
            TextBoxResult.Text = "Точка А не належить площі кола"
        End If

    End Sub
End Class
