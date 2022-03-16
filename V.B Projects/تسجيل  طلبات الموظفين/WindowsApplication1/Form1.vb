Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, s, h, k, o, t, z As String
        Dim d, y As Integer
        Dim n_date As Date
        a = TextBox1.Text
        b = TextBox5.Text
        c = TextBox6.Text
        d = TextBox2.Text
        y = TextBox4.Text
        n_date = CDate(TextBox3.Text)
        s = ComboBox1.SelectedItem
        h = ComboBox2.SelectedItem
        k = CheckedListBox1.SelectedItem
        o = ListBox1.SelectedItem
        If RadioButton1.Checked = True Then
            t = "مصري"
        Else RadioButton2.Checked = True
            t = "جنسية اخري"
        End If
        If RadioButton3.Checked = True Then
            z = "ذكر"
        Else RadioButton4.Checked = True
            z = "انثي"
        End If
        MsgBox(a & "" & vbCrLf & b & "" & vbCrLf & "" & "" & c & "" & vbCrLf & d & "" & vbCrLf & y & "" & vbCrLf & n_date & "" & vbCrLf & s & "" & vbCrLf & h & "" & vbCrLf & k & "" & vbCrLf & o & "" & vbCrLf & t & "" & vbCrLf & z & vbCrLf)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
