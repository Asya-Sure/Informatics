Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        x = TextBoxX.Text
        y = TextBoxY.Text
        Dim znak As String
        znak = ComboBoxS.Text
        If znak = "+" Then
            z = x + y
            Text = z
        ElseIf znak = "-" Then
            z = x - y
            Text = z
        ElseIf znak = "*" Then
            z = x * y
            Text = z
        ElseIf znak = "/" Then
            z = x / y
            Text = z
        ElseIf znak = "^" Then
            z = x ^ y
            Text = z

        End If

    End Sub

    Private Sub ComboBox_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxS.Items.Add("+")
        ComboBoxS.Items.Add("-")
        ComboBoxS.Items.Add("*")
        ComboBoxS.Items.Add("/")

    End Sub
End Class
