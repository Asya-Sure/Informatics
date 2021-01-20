Public Class Form1
    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click

        Dim numberMore = TextBoxMore.Text, numberLess = TextBoxLess.Text, counter As Integer
        For counter = numberMore To numberLess
            If Not counter Mod 2 = 0 Then
                TextBoxResult.Text = TextBoxResult.Text + " " + counter.ToString
            End If


        Next counter

    End Sub
End Class
