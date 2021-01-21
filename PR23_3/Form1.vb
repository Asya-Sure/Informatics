Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim mas(4) As Integer
        mas(0) = -2
        mas(1) = 3
        mas(2) = -15
        mas(3) = 6
        For a = 0 To 3
            If mas(a) > 0 Then

                TextBoxPlas.Text = TextBoxPlas.Text & mas(a) & " "
            Else
                TextBoxMinus.Text = TextBoxMinus.Text & mas(a) & " "

            End If

        Next a

    End Sub
End Class
