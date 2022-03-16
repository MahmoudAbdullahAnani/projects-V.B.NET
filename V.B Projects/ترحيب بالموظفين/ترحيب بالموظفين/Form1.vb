Public Class Form1
    Dim em(9) As String
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 10
            em(i) = InputBox(":ادخل اسمك")
            MsgBox(em(i) & "" & "  اهلا و مرحبا بك يا")
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
