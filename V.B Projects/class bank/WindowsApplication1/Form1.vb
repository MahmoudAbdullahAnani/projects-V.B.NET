Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bank1 As New bank()
        bank1.clieut = "محمود"
        bank1.Account = 1
        bank1.Acc_no = 5
        MsgBox(bank1.clieut & vbCrLf & bank1.Account & vbCrLf & bank1.Acc_no)
    End Sub
End Class
Class bank
    Public clieut As String
    Public Account As Single
    Public Acc_no As Integer
    Sub now()
        Account += 100
    End Sub
    Sub now(ByVal _clieut As String, ByVal _Account As Single, ByVal Acc_no As Integer)
        clieut = _clieut
        Account = _Account
        Acc_no = Acc_no
    End Sub
    Sub deposite(ByVal x As Single)
        Account += x
    End Sub
    Sub withdrow(ByVal _x As Single)
        Account -= _x
    End Sub
    Sub display()
        MsgBox(Account.ToString)
    End Sub
End Class

