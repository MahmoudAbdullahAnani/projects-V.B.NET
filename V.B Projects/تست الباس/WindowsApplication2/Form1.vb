Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = TextBox1.Text
        s = RTrim(TextBox1.Text)
        MsgBox(s)
    End Sub
End Class
