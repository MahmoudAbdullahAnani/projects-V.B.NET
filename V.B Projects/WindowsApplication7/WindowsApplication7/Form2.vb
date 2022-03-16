Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub المريضBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles المريضBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.المريضBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.المريض' table. You can move, or remove it, as needed.
        Me.المريضTableAdapter.Fill(Me.TestDataSet.المريض)

    End Sub
End Class