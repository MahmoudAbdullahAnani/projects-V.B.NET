Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adg(3), i As Integer
        For i = 0 To 3
            adg(i) = InputBox("ادخل عمر الطالب")
        Next
        For i = 0 To 3
            Label1.Text += "عمر الطالب هو" & "" & adg(i).ToString & vbCrLf
        Next
        If adg(i) = "" Then
            MsgBox("ادخل العمر")

        End If
    End Sub
End Class
