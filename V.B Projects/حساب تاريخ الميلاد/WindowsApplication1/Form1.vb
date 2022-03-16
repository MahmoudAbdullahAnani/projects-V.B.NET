Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c, s, w, d, v, f, r, t, y As Integer
        c = TextBox1.Text
        s = TextBox2.Text
        w = TextBox3.Text
        d = TextBox4.Text
        v = TextBox6.Text
        f = TextBox5.Text
        r = w - f
        t = c - v
        y = s - d
        If y = -y Then
            y = -1 * y
        End If
        If t = -t Then
            t = -1 * t
        End If
        Label7.Text = r
        Label8.Text = t
        Label9.Text = y

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        TextBox3.Focus()


    End Sub
End Class
