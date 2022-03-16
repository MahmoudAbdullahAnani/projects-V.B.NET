Public Class Form1
    Public employee(4), sum As Single 'الكود دا يصحبي عشان يبق عامل علي كل الي حوي الفورمه 

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End 'الكود دا يصحبي عشان يقفل البرنامج
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For x = 0 To 4 ' الكو دا يا صحبي عشان يظهر صندوق الاخال 5 مرات
            employee(x) = InputBox("ادخل المرتب")
        Next
        For x = 0 To 4 'الكود ياصحبي عشان يجمع الي دخلته فوق 
            sum += employee(x)
        Next
        MsgBox(sum) ' دا بق عشان يظهر العبط الي انت عامله 

    End Sub 'احلي مسي عليك 

    Private Sub Button1_SizeChanged(sender As Object, e As EventArgs) Handles Button1.SizeChanged

    End Sub

    Private Sub Button1_AutoSizeChanged(sender As Object, e As EventArgs) Handles Button1.AutoSizeChanged

    End Sub
End Class
