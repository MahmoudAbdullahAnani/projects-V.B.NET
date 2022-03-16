Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, sdegree(4) As Integer

        For i = 0 To 4
            sdegree(i) = InputBox("ادخل الدرجة")

        Next

        ' For i = 0 To 4
        Label1.Text += sdegree(0)
        Label1.Text += sdegree(1)
        Label1.Text += sdegree(2)
        Label1.Text += sdegree(3)
        ' Next
    End Sub
End Class
