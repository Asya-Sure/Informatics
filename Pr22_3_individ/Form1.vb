Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l, m As Integer
        m = TextBoxM.Text
        If m + 15 >= 1 Then
            l = (1 + m ^ 2) ^ 1 / 2
            TextBoxL.Text = l
            If m + 15 > 1 Then
                l = 1 + 24 * m
                TextBoxL.Text = l
            End If
        End If
    End Sub

End Class
