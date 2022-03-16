Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub الوحداتBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles الوحداتBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.الوحداتBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.الوحدات' table. You can move, or remove it, as needed.
        Me.الوحداتTableAdapter.Fill(Me.مخازنDataSet.الوحدات)

    End Sub
End Class