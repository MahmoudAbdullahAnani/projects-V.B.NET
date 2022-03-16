Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub طلبات_الصرفBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles طلبات_الصرفBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.طلبات_الصرفBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.طلبات_الصرف' table. You can move, or remove it, as needed.
        Me.طلبات_الصرفTableAdapter.Fill(Me.مخازنDataSet.طلبات_الصرف)

    End Sub
End Class