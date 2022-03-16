Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub المخزنBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles المخزنBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.المخزنBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.المخزن' table. You can move, or remove it, as needed.
        Me.المخزنTableAdapter.Fill(Me.مخازنDataSet.المخزن)

    End Sub
End Class