Public Class form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub الاذنBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles الاذنBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.الاذنBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.الاذن' table. You can move, or remove it, as needed.
        Me.الاذنTableAdapter.Fill(Me.مخازنDataSet.الاذن)

    End Sub
End Class