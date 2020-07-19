Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prompt, fullName As String
        prompt = "กรุณาป้อนชื่อเเละนามสกุล"
        fullName = InputBox(prompt)
        MsgBox(fullName,, "ชื่อและนามสกุลของคุณ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String
        firstName = "Natthamon"
        Label4.Text = firstName
        firstName = "khanthakhet"
        Label5.Text = firstName
        firstName = "oing"
        Label6.Text = firstName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prompt, fullName As String
        prompt = "กรุณาป้อนชื่อเเละนามสกุล"
        fullName = InputBox(prompt)
        Label4.Text = fullName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class
