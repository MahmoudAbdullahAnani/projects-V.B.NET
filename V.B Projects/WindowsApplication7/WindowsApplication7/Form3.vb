Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub السريرBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles السريرBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.السريرBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.السرير' table. You can move, or remove it, as needed.
        Me.السريرTableAdapter.Fill(Me.TestDataSet.السرير)

    End Sub
End Class