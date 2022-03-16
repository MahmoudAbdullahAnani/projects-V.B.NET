Public Class Form1
    Dim AllText As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OFD.Filter = "نص|*.docx|pdf|*.pdf|نص|*.doc"
        OFD.ShowDialog()
        TextBox1.Text = My.Computer.FileSystem.ReadAllText(OFD.FileName)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SFD.Filter = "نص|*.docx|pdf|*.pdf|نص|*.doc"
        SFD.ShowDialog()
        FileOpen(10, SFD.FileName, OpenMode.Output)
        PrintLine(10, TextBox1.Text)
        FileClose(10)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        TextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class
