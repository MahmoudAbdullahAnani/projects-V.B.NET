Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x(9), a As String
        For i = 0 To 9
            x(i) = InputBox("ادخل عمر الطالب")

        Next
        For i = 0 To 9
            a += x(i)
        Next


        MsgBox(a / 50)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
