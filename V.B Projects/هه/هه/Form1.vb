Public Class Form1
    Dim x As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay()
        If x < 3 Then
            PictureBox1.Image = Image.FromFile("C:\Users\Mahmoud\Desktop\vidd\WhatsApp" & x & ".jpeg")
            x += 1

        Else
            x = 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = 1
    End Sub
End Class
