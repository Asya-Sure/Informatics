Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x0, y0, x, y, r1, r2 As Integer
        x0 = TextBoxX0.Text
        y0 = TextBoxY0.Text
        x = TextBoxX.Text
        y = TextBoxY.Text
        r1 = TextBoxR1.Text
        r2 = TextBoxR2.Text

        If (r1) ^ 2 <= (x - x0) ^ 2 + (y - y0) ^ 2 <= (r2) ^ 2 Then
            TextBoxResult.Text = "Точка А належить площі кіл"
        Else
            TextBoxResult.Text = "Точка А не належить площі кіл"
        End If


    End Sub
End Class
