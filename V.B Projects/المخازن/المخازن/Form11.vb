Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub كتلوج_الاصنافBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles كتلوج_الاصنافBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.كتلوج_الاصنافBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.كتلوج_الاصناف' table. You can move, or remove it, as needed.
        Me.كتلوج_الاصنافTableAdapter.Fill(Me.مخازنDataSet.كتلوج_الاصناف)

    End Sub
End Class