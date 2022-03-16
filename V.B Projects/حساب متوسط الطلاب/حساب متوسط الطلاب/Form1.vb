Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim degree(19), i, sum As Single
        For i = 0 To 19
            degree(i) = InputBox("ادخل الدرجة")
            sum += degree(i)

        Next

        MsgBox(sum / 20)

    End Sub
End Class
