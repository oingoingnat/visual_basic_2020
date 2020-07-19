Public Class Form1
    Dim Price, Num, tel, jai, Sudti As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Num = TextBox2.Text
        tel = Price * Num
        Label4.Text = tel

        jai = TextBox4.Text
        Sudti = jai - tel
        Label7.Text = Sudti
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
