Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub البلدBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles البلدBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.البلدBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.البلد' table. You can move, or remove it, as needed.
        Me.البلدTableAdapter.Fill(Me.مخازنDataSet.البلد)

    End Sub
End Class