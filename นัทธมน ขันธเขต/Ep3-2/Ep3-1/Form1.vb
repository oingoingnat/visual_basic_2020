Public Class Form1
    Dim Birds As Short
    Dim Insects As Integer
    Dim WorldPop As Long
    Dim price As String
    Dim FullName As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Short")
        ListBox1.Items.Add("Integer")
        ListBox1.Items.Add("long")
        ListBox1.Items.Add("single")
        ListBox1.Items.Add("FullName")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Birds = 12500
                Label3.Text = Birds
            Case 1
                Insects = 37500000
                Label3.Text = Insects
            Case 2
                WorldPop = 899.99
                Label3.Text = WorldPop

            Case 3
                price = "oing"
                Label3.Text = price
            Case 4
                FullName = "นัทธมน ขันธเขต"
                Label3.Text = FullName


        End Select
    End Sub
End Class
