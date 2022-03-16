<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim رقم_الصنفLabel As System.Windows.Forms.Label
        Dim رقم_المخزنLabel As System.Windows.Forms.Label
        Dim السنه_الماليهLabel As System.Windows.Forms.Label
        Dim الرصيدLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.مخازنDataSet = New المخازن.مخازنDataSet()
        Me.الارصدة_الافتتاحيةBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.الارصدة_الافتتاحيةTableAdapter = New المخازن.مخازنDataSetTableAdapters.الارصدة_الافتتاحيةTableAdapter()
        Me.TableAdapterManager = New المخازن.مخازنDataSetTableAdapters.TableAdapterManager()
        Me.الارصدة_الافتتاحيةBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.الارصدة_الافتتاحيةBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.رقم_الصنفTextBox = New System.Windows.Forms.TextBox()
        Me.رقم_المخزنTextBox = New System.Windows.Forms.TextBox()
        Me.السنه_الماليهDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.الرصيدTextBox = New System.Windows.Forms.TextBox()
        رقم_الصنفLabel = New System.Windows.Forms.Label()
        رقم_المخزنLabel = New System.Windows.Forms.Label()
        السنه_الماليهLabel = New System.Windows.Forms.Label()
        الرصيدLabel = New System.Windows.Forms.Label()
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.الارصدة_الافتتاحيةBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.الارصدة_الافتتاحيةBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.الارصدة_الافتتاحيةBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(784, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 74)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "عودة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'مخازنDataSet
        '
        Me.مخازنDataSet.CaseSensitive = True
        Me.مخازنDataSet.DataSetName = "مخازنDataSet"
        Me.مخازنDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'الارصدة_الافتتاحيةBindingSource
        '
        Me.الارصدة_الافتتاحيةBindingSource.DataMember = "الارصدة الافتتاحية"
        Me.الارصدة_الافتتاحيةBindingSource.DataSource = Me.مخازنDataSet
        '
        'الارصدة_الافتتاحيةTableAdapter
        '
        Me.الارصدة_الافتتاحيةTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = المخازن.مخازنDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.الاذنTableAdapter = Nothing
        Me.TableAdapterManager.الارصدة_الافتتاحيةTableAdapter = Me.الارصدة_الافتتاحيةTableAdapter
        Me.TableAdapterManager.البلدTableAdapter = Nothing
        Me.TableAdapterManager.المخزنTableAdapter = Nothing
        Me.TableAdapterManager.الوحداتTableAdapter = Nothing
        Me.TableAdapterManager.بطاقة_الصنفTableAdapter = Nothing
        Me.TableAdapterManager.جدول_طلبات_الصرف_اصنافTableAdapter = Nothing
        Me.TableAdapterManager.جدول_مخازن___اصنافTableAdapter = Nothing
        Me.TableAdapterManager.طلبات_الصرفTableAdapter = Nothing
        Me.TableAdapterManager.كتلوج_الاصنافTableAdapter = Nothing
        '
        'الارصدة_الافتتاحيةBindingNavigator
        '
        Me.الارصدة_الافتتاحيةBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.الارصدة_الافتتاحيةBindingNavigator.BindingSource = Me.الارصدة_الافتتاحيةBindingSource
        Me.الارصدة_الافتتاحيةBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.الارصدة_الافتتاحيةBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.الارصدة_الافتتاحيةBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.الارصدة_الافتتاحيةBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.الارصدة_الافتتاحيةBindingNavigatorSaveItem})
        Me.الارصدة_الافتتاحيةBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.الارصدة_الافتتاحيةBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.الارصدة_الافتتاحيةBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.الارصدة_الافتتاحيةBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.الارصدة_الافتتاحيةBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.الارصدة_الافتتاحيةBindingNavigator.Name = "الارصدة_الافتتاحيةBindingNavigator"
        Me.الارصدة_الافتتاحيةBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.الارصدة_الافتتاحيةBindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.الارصدة_الافتتاحيةBindingNavigator.TabIndex = 2
        Me.الارصدة_الافتتاحيةBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'الارصدة_الافتتاحيةBindingNavigatorSaveItem
        '
        Me.الارصدة_الافتتاحيةBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.الارصدة_الافتتاحيةBindingNavigatorSaveItem.Image = CType(resources.GetObject("الارصدة_الافتتاحيةBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.الارصدة_الافتتاحيةBindingNavigatorSaveItem.Name = "الارصدة_الافتتاحيةBindingNavigatorSaveItem"
        Me.الارصدة_الافتتاحيةBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.الارصدة_الافتتاحيةBindingNavigatorSaveItem.Text = "Save Data"
        '
        'رقم_الصنفLabel
        '
        رقم_الصنفLabel.AutoSize = True
        رقم_الصنفLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        رقم_الصنفLabel.Location = New System.Drawing.Point(409, 290)
        رقم_الصنفLabel.Name = "رقم_الصنفLabel"
        رقم_الصنفLabel.Size = New System.Drawing.Size(103, 24)
        رقم_الصنفLabel.TabIndex = 2
        رقم_الصنفLabel.Text = ":رقم الصنف"
        '
        'رقم_الصنفTextBox
        '
        Me.رقم_الصنفTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.الارصدة_الافتتاحيةBindingSource, "رقم الصنف", True))
        Me.رقم_الصنفTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.رقم_الصنفTextBox.Location = New System.Drawing.Point(77, 290)
        Me.رقم_الصنفTextBox.Name = "رقم_الصنفTextBox"
        Me.رقم_الصنفTextBox.Size = New System.Drawing.Size(200, 32)
        Me.رقم_الصنفTextBox.TabIndex = 3
        '
        'رقم_المخزنLabel
        '
        رقم_المخزنLabel.AutoSize = True
        رقم_المخزنLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        رقم_المخزنLabel.Location = New System.Drawing.Point(402, 356)
        رقم_المخزنLabel.Name = "رقم_المخزنLabel"
        رقم_المخزنLabel.Size = New System.Drawing.Size(110, 24)
        رقم_المخزنLabel.TabIndex = 4
        رقم_المخزنLabel.Text = ":رقم المخزن"
        '
        'رقم_المخزنTextBox
        '
        Me.رقم_المخزنTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.الارصدة_الافتتاحيةBindingSource, "رقم المخزن", True))
        Me.رقم_المخزنTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.رقم_المخزنTextBox.Location = New System.Drawing.Point(77, 353)
        Me.رقم_المخزنTextBox.Name = "رقم_المخزنTextBox"
        Me.رقم_المخزنTextBox.Size = New System.Drawing.Size(200, 32)
        Me.رقم_المخزنTextBox.TabIndex = 5
        '
        'السنه_الماليهLabel
        '
        السنه_الماليهLabel.AutoSize = True
        السنه_الماليهLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        السنه_الماليهLabel.Location = New System.Drawing.Point(402, 233)
        السنه_الماليهLabel.Name = "السنه_الماليهLabel"
        السنه_الماليهLabel.Size = New System.Drawing.Size(126, 24)
        السنه_الماليهLabel.TabIndex = 6
        السنه_الماليهLabel.Text = ":السنه الماليه"
        '
        'السنه_الماليهDateTimePicker
        '
        Me.السنه_الماليهDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.الارصدة_الافتتاحيةBindingSource, "السنه الماليه", True))
        Me.السنه_الماليهDateTimePicker.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.السنه_الماليهDateTimePicker.Location = New System.Drawing.Point(77, 227)
        Me.السنه_الماليهDateTimePicker.Name = "السنه_الماليهDateTimePicker"
        Me.السنه_الماليهDateTimePicker.Size = New System.Drawing.Size(200, 32)
        Me.السنه_الماليهDateTimePicker.TabIndex = 7
        '
        'الرصيدLabel
        '
        الرصيدLabel.AutoSize = True
        الرصيدLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        الرصيدLabel.Location = New System.Drawing.Point(426, 169)
        الرصيدLabel.Name = "الرصيدLabel"
        الرصيدLabel.Size = New System.Drawing.Size(69, 24)
        الرصيدLabel.TabIndex = 8
        الرصيدLabel.Text = ":الرصيد"
        '
        'الرصيدTextBox
        '
        Me.الرصيدTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.الارصدة_الافتتاحيةBindingSource, "الرصيد", True))
        Me.الرصيدTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.الرصيدTextBox.Location = New System.Drawing.Point(77, 166)
        Me.الرصيدTextBox.Name = "الرصيدTextBox"
        Me.الرصيدTextBox.Size = New System.Drawing.Size(200, 32)
        Me.الرصيدTextBox.TabIndex = 9
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 475)
        Me.Controls.Add(رقم_الصنفLabel)
        Me.Controls.Add(Me.رقم_الصنفTextBox)
        Me.Controls.Add(رقم_المخزنLabel)
        Me.Controls.Add(Me.رقم_المخزنTextBox)
        Me.Controls.Add(السنه_الماليهLabel)
        Me.Controls.Add(Me.السنه_الماليهDateTimePicker)
        Me.Controls.Add(الرصيدLabel)
        Me.Controls.Add(Me.الرصيدTextBox)
        Me.Controls.Add(Me.الارصدة_الافتتاحيةBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "الارصدة الافتتاحية"
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.الارصدة_الافتتاحيةBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.الارصدة_الافتتاحيةBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.الارصدة_الافتتاحيةBindingNavigator.ResumeLayout(False)
        Me.الارصدة_الافتتاحيةBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents مخازنDataSet As مخازنDataSet
    Friend WithEvents الارصدة_الافتتاحيةBindingSource As BindingSource
    Friend WithEvents الارصدة_الافتتاحيةTableAdapter As مخازنDataSetTableAdapters.الارصدة_الافتتاحيةTableAdapter
    Friend WithEvents TableAdapterManager As مخازنDataSetTableAdapters.TableAdapterManager
    Friend WithEvents الارصدة_الافتتاحيةBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents الارصدة_الافتتاحيةBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents رقم_الصنفTextBox As TextBox
    Friend WithEvents رقم_المخزنTextBox As TextBox
    Friend WithEvents السنه_الماليهDateTimePicker As DateTimePicker
    Friend WithEvents الرصيدTextBox As TextBox
End Class
