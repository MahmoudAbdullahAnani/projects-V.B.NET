Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As Single
        Dim n, PW As String
        d = TextBox3.Text
        n = TextBox1.Text
        pW = TextBox2.Text
        d = CInt(TextBox3.Text)
        n = RTrim(TextBox1.Text)
        If Len(TextBox1.Text) > 15 Then
            TextBox2.Focus()
        ElseIf MsgBox("ادخل الاسم بطرقة صحيحة")
            Exit Sub
        End If
        pW = LCase(pW)
        pW = Trim(pW)
        If pW = "mostafa" Then
            MsgBox("welcome" & vbCrLf & d & vbCrLf & n)
        ElseIf MsgBox("ادخل الرقم السري بطريقة صحيحة")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_TabIndexChanged(sender As Object, e As EventArgs) Handles Button1.TabIndexChanged

    End Sub

    Private Sub TextBox1_TabIndexChanged(sender As Object, e As EventArgs) Handles TextBox1.TabIndexChanged
        TextBox1.Focus()
    End Sub
End Class
