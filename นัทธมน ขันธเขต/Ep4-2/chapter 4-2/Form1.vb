Public Class Form1
    Dim Username As String
    Dim password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Username = InputBox("กรูณาป้อนชื่อของคูณ")
        password = InputBox("กรุณาใส่รหัสผ่านของคุณ")

        If Username = "นุ๊กเน็ต" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\นัทธมน ขันธเขต\All_Images\photo04.jpg")
        ElseIf Username = "เอส" And password = "0935196026" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\นัทธมน ขันธเขต\All_Images\100733382_1856721801129390_4105055361273167872_n.jpg")
        ElseIf Username = "อิง" And password = "11111" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\นัทธมน ขันธเขต\All_Images\unnamed (1).jpg")
        ElseIf Username = "ปอ" And password = "22222" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\นัทธมน ขันธเขต\All_Images\95903510_1665218953644553_4540252245331717313_n.jpg")


        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
