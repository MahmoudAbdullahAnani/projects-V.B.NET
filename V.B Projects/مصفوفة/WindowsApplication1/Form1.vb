Public Class Form1
    Dim mahmoud(), c, s As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mahmoud = TextBox1.Lines
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mahmoud = TextBox1.Lines
        MsgBox(mahmoud.Length)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mahmoud = TextBox1.Lines
        Array.Sort(mahmoud)
        TextBox1.Lines = mahmoud
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mahmoud = TextBox1.Lines
        Array.Reverse(mahmoud)
        TextBox1.Lines = mahmoud
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mahmoud = TextBox1.Lines
        s = InputBox("ادخل عنصر البحث")
        If s = "" Then
            MsgBox("يجب ان تكمل البيانات")
            Exit Sub
        End If
        s = Array.IndexOf(mahmoud, s)
        MsgBox(s)


    End Sub
End Class
