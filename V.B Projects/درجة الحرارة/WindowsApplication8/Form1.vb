Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        watherd(TextBox1.Text)
    End Sub
    Sub watherd(ByVal s As Single)
        If s > 25 Then
            MsgBox("sunny")
        Else
            MsgBox("cloude")
        End If
    End Sub

End Class
