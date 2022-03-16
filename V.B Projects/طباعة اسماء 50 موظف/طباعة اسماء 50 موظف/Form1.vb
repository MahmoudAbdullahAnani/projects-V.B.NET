Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
    Public Sub bill(ByVal s As Single, ByVal n As Single)
        If s < 200 Then
            n += s * 50
            'MsgBox(":الفاتورة" & n)

        Else
            n += s * 75
        End If
        ' MsgBox(":الفاتورة" & n)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bill(TextBox1.Text)

    End Sub

    Private Sub bill(v As Single)
        Throw New NotImplementedException()
    End Sub
End Class
