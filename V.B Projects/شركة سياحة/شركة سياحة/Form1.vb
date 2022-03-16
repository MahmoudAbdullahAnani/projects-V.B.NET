Public Class Form1
    Public a, w, n, b As String
    Public x As Single
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        x = TextBox2.Text
        n = DateTimePicker1.Text
        w = ListBox1.SelectedItem
        If RadioButton1.Checked Then
            b = "داخلية"
        ElseIf RadioButton2.Checked Then
            b = "خارجية"
        End If
        MsgBox(a & "" & x & "" & n & "" & w & "" & b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
