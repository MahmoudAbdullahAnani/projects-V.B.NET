Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arry() As String
        arry = TextBox1.Lines
        MsgBox(arry.GetUpperBound(0))



    End Sub
End Class
