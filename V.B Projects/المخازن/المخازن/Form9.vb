Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub جدول_مخازن___اصنافBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles جدول_مخازن___اصنافBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.جدول_مخازن___اصنافBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet._جدول_مخازن___اصناف' table. You can move, or remove it, as needed.
        Me.جدول_مخازن___اصنافTableAdapter.Fill(Me.مخازنDataSet._جدول_مخازن___اصناف)

    End Sub
End Class