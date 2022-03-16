Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub بطاقة_الصنفBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles بطاقة_الصنفBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.بطاقة_الصنفBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet.بطاقة_الصنف' table. You can move, or remove it, as needed.
        Me.بطاقة_الصنفTableAdapter.Fill(Me.مخازنDataSet.بطاقة_الصنف)

    End Sub
End Class