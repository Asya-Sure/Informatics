Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number = TextBoxNumber.Text, counter, sum As Integer
        sum = 0
        For counter = -3 To number
            If number >= -3 And number <= 27 And number Mod 3 = 0 Then
                sum = sum + counter

            End If
        Next counter
        TextBoxResult.Text = sum
    End Sub
End Class
