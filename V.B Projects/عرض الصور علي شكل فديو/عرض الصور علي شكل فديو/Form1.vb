Public Class Form1
    Dim x As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = TimeOfDay()
        x = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay()
        If x < 7 Then
            PictureBox1.Image = Image.FromFile("D:\photos\Jun 06\test" & x & ".jpg")
            x += x
        Else
            x = 1
        End If
    End Sub

End Class
