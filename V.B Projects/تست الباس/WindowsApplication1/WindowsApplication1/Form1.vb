Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pw As String
        pw = TextBox1.Text
        pw = Trim(pw)
        pw = LCase(pw)
        If pw = "mahmoud" Then
            MsgBox("welcome")
        ElseIf MsgBox("ادخل الرقم بريقة صحيحة")
        End If
    End Sub
End Class
