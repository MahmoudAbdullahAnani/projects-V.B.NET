Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub الارصدة_الافتتاحيةBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles الارصدة_الافتتاحيةBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.الارصدة_الافتتاحيةBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.الارصدة_الافتتاحية' table. You can move, or remove it, as needed.
        Me.الارصدة_الافتتاحيةTableAdapter.Fill(Me.مخازنDataSet.الارصدة_الافتتاحية)

    End Sub
End Class