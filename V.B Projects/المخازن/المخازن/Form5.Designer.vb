<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim رقم_المخزنLabel As System.Windows.Forms.Label
        Dim اسم_المخزنLabel As System.Windows.Forms.Label
        Dim ملاحظاتLabel As System.Windows.Forms.Label
        Dim بلد_المخزنLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.مخازنDataSet = New المخازن.مخازنDataSet()
        Me.المخزنBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.المخزنTableAdapter = New المخازن.مخازنDataSetTableAdapters.المخزنTableAdapter()
        Me.TableAdapterManager = New المخازن.مخازنDataSetTableAdapters.TableAdapterManager()
        Me.المخزنBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.المخزنBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.رقم_المخزنTextBox = New System.Windows.Forms.TextBox()
        Me.اسم_المخزنTextBox = New System.Windows.Forms.TextBox()
        Me.ملاحظاتTextBox = New System.Windows.Forms.TextBox()
        Me.بلد_المخزنTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        رقم_المخزنLabel = New System.Windows.Forms.Label()
        اسم_المخزنLabel = New System.Windows.Forms.Label()
        ملاحظاتLabel = New System.Windows.Forms.Label()
        بلد_المخزنLabel = New System.Windows.Forms.Label()
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.المخزنBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.المخزنBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.المخزنBindingNavigator.SuspendLayout()
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
        'المخزنBindingSource
        '
        Me.المخزنBindingSource.DataMember = "المخزن"
        Me.المخزنBindingSource.DataSource = Me.مخازنDataSet
        '
        'المخزنTableAdapter
        '
        Me.المخزنTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = المخازن.مخازنDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.الاذنTableAdapter = Nothing
        Me.TableAdapterManager.الارصدة_الافتتاحيةTableAdapter = Nothing
        Me.TableAdapterManager.البلدTableAdapter = Nothing
        Me.TableAdapterManager.المخزنTableAdapter = Me.المخزنTableAdapter
        Me.TableAdapterManager.الوحداتTableAdapter = Nothing
        Me.TableAdapterManager.بطاقة_الصنفTableAdapter = Nothing
        Me.TableAdapterManager.جدول_طلبات_الصرف_اصنافTableAdapter = Nothing
        Me.TableAdapterManager.جدول_مخازن___اصنافTableAdapter = Nothing
        Me.TableAdapterManager.طلبات_الصرفTableAdapter = Nothing
        Me.TableAdapterManager.كتلوج_الاصنافTableAdapter = Nothing
        '
        'المخزنBindingNavigator
        '
        Me.المخزنBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.المخزنBindingNavigator.BindingSource = Me.المخزنBindingSource
        Me.المخزنBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.المخزنBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.المخزنBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.المخزنBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.المخزنBindingNavigatorSaveItem})
        Me.المخزنBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.المخزنBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.المخزنBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.المخزنBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.المخزنBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.المخزنBindingNavigator.Name = "المخزنBindingNavigator"
        Me.المخزنBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.المخزنBindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.المخزنBindingNavigator.TabIndex = 2
        Me.المخزنBindingNavigator.Text = "BindingNavigator1"
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
        'المخزنBindingNavigatorSaveItem
        '
        Me.المخزنBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.المخزنBindingNavigatorSaveItem.Image = CType(resources.GetObject("المخزنBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.المخزنBindingNavigatorSaveItem.Name = "المخزنBindingNavigatorSaveItem"
        Me.المخزنBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.المخزنBindingNavigatorSaveItem.Text = "Save Data"
        '
        'رقم_المخزنLabel
        '
        رقم_المخزنLabel.AutoSize = True
        رقم_المخزنLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        رقم_المخزنLabel.Location = New System.Drawing.Point(504, 195)
        رقم_المخزنLabel.Name = "رقم_المخزنLabel"
        رقم_المخزنLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_المخزنLabel.Size = New System.Drawing.Size(110, 24)
        رقم_المخزنLabel.TabIndex = 2
        رقم_المخزنLabel.Text = "رقم المخزن:"
        '
        'رقم_المخزنTextBox
        '
        Me.رقم_المخزنTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.المخزنBindingSource, "رقم المخزن", True))
        Me.رقم_المخزنTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.رقم_المخزنTextBox.Location = New System.Drawing.Point(299, 192)
        Me.رقم_المخزنTextBox.Name = "رقم_المخزنTextBox"
        Me.رقم_المخزنTextBox.Size = New System.Drawing.Size(172, 32)
        Me.رقم_المخزنTextBox.TabIndex = 3
        '
        'اسم_المخزنLabel
        '
        اسم_المخزنLabel.AutoSize = True
        اسم_المخزنLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        اسم_المخزنLabel.Location = New System.Drawing.Point(504, 225)
        اسم_المخزنLabel.Name = "اسم_المخزنLabel"
        اسم_المخزنLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        اسم_المخزنLabel.Size = New System.Drawing.Size(120, 24)
        اسم_المخزنLabel.TabIndex = 4
        اسم_المخزنLabel.Text = "اسم المخزن:"
        '
        'اسم_المخزنTextBox
        '
        Me.اسم_المخزنTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.المخزنBindingSource, "اسم المخزن", True))
        Me.اسم_المخزنTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.اسم_المخزنTextBox.Location = New System.Drawing.Point(299, 222)
        Me.اسم_المخزنTextBox.Name = "اسم_المخزنTextBox"
        Me.اسم_المخزنTextBox.Size = New System.Drawing.Size(172, 32)
        Me.اسم_المخزنTextBox.TabIndex = 5
        '
        'ملاحظاتLabel
        '
        ملاحظاتLabel.AutoSize = True
        ملاحظاتLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        ملاحظاتLabel.Location = New System.Drawing.Point(504, 255)
        ملاحظاتLabel.Name = "ملاحظاتLabel"
        ملاحظاتLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ملاحظاتLabel.Size = New System.Drawing.Size(90, 24)
        ملاحظاتLabel.TabIndex = 6
        ملاحظاتLabel.Text = "ملاحظات:"
        '
        'ملاحظاتTextBox
        '
        Me.ملاحظاتTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.المخزنBindingSource, "ملاحظات", True))
        Me.ملاحظاتTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ملاحظاتTextBox.Location = New System.Drawing.Point(299, 252)
        Me.ملاحظاتTextBox.Name = "ملاحظاتTextBox"
        Me.ملاحظاتTextBox.Size = New System.Drawing.Size(172, 32)
        Me.ملاحظاتTextBox.TabIndex = 7
        '
        'بلد_المخزنLabel
        '
        بلد_المخزنLabel.AutoSize = True
        بلد_المخزنLabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        بلد_المخزنLabel.Location = New System.Drawing.Point(504, 285)
        بلد_المخزنLabel.Name = "بلد_المخزنLabel"
        بلد_المخزنLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        بلد_المخزنLabel.Size = New System.Drawing.Size(105, 24)
        بلد_المخزنLabel.TabIndex = 8
        بلد_المخزنLabel.Text = "بلد المخزن:"
        '
        'بلد_المخزنTextBox
        '
        Me.بلد_المخزنTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.المخزنBindingSource, "بلد المخزن", True))
        Me.بلد_المخزنTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.بلد_المخزنTextBox.Location = New System.Drawing.Point(299, 282)
        Me.بلد_المخزنTextBox.Name = "بلد_المخزنTextBox"
        Me.بلد_المخزنTextBox.Size = New System.Drawing.Size(172, 32)
        Me.بلد_المخزنTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(441, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "المخزن"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(رقم_المخزنLabel)
        Me.Controls.Add(Me.رقم_المخزنTextBox)
        Me.Controls.Add(اسم_المخزنLabel)
        Me.Controls.Add(Me.اسم_المخزنTextBox)
        Me.Controls.Add(ملاحظاتLabel)
        Me.Controls.Add(Me.ملاحظاتTextBox)
        Me.Controls.Add(بلد_المخزنLabel)
        Me.Controls.Add(Me.بلد_المخزنTextBox)
        Me.Controls.Add(Me.المخزنBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form5"
        Me.Text = "المخزن"
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.المخزنBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.المخزنBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.المخزنBindingNavigator.ResumeLayout(False)
        Me.المخزنBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents مخازنDataSet As مخازنDataSet
    Friend WithEvents المخزنBindingSource As BindingSource
    Friend WithEvents المخزنTableAdapter As مخازنDataSetTableAdapters.المخزنTableAdapter
    Friend WithEvents TableAdapterManager As مخازنDataSetTableAdapters.TableAdapterManager
    Friend WithEvents المخزنBindingNavigator As BindingNavigator
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
    Friend WithEvents المخزنBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents رقم_المخزنTextBox As TextBox
    Friend WithEvents اسم_المخزنTextBox As TextBox
    Friend WithEvents ملاحظاتTextBox As TextBox
    Friend WithEvents بلد_المخزنTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
