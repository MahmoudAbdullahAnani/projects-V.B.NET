Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.جدول_طلبات_الصرف_اصنافBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.مخازنDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'مخازنDataSet._جدول_طلبات_الصرف_اصناف' table. You can move, or remove it, as needed.
        Me.جدول_طلبات_الصرف_اصنافTableAdapter.Fill(Me.مخازنDataSet._جدول_طلبات_الصرف_اصناف)

    End Sub
End Class