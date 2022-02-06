Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rastgele As New Random
        Label1.Text = rastgele.Next(1, 49)
        Label2.Text = rastgele.Next(1, 49)
        Label3.Text = rastgele.Next(1, 49)
        Label4.Text = rastgele.Next(1, 49)
        Label5.Text = rastgele.Next(1, 49)
        Label6.Text = rastgele.Next(1, 49)


        ListBox1.Items.Add(Label1.Text + " " + Label2.Text + " " + Label3.Text + " " + Label4.Text + " " + Label5.Text + " " + Label6.Text + " ")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        Label8.Text = rastgele.Next(1, 49)
    End Sub


End Class
