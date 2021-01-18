Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C As Integer
        A = TextBox_A.Text
        B = TextBox_B.Text
        C = TextBox_Number.Text

        If C >= A And C <= B Then
            TextBox_Result.Text = "да!"
        Else
            TextBox_Result.Text = "нет"

        End If

    End Sub

End Class
