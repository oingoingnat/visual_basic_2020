Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String
        firstName = "Natthamon"
        Label1.Text = firstName
        firstName = "oing"
        Label2.Text = firstName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prompt, fullname As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        fullname = InputBox(prompt)
        Label1.Text = fullname
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prompt, fullname As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        fullname = InputBox(prompt)
        MsgBox(fullname, , "ชื่อและนามสกุลของคุณ")
    End Sub
End Class
