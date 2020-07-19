Public Class Form1
    Dim Price, num, total As String
    Dim Steam As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        num = TextBox2.Text
        total = Price * num
        Label5.Text = total
        Steam = total / 50
        Label6.Text = Steam
    End Sub

End Class
