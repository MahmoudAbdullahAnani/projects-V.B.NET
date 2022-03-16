<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Dim رقم_الكتلوجLabel As System.Windows.Forms.Label
        Dim اسم_الكتلوجLabel As System.Windows.Forms.Label
        Dim ملاحظاتLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.مخازنDataSet = New المخازن.مخازنDataSet()
        Me.كتلوج_الاصنافBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.كتلوج_الاصنافTableAdapter = New المخازن.مخازنDataSetTableAdapters.كتلوج_الاصنافTableAdapter()
        Me.TableAdapterManager = New المخازن.مخازنDataSetTableAdapters.TableAdapterManager()
        Me.كتلوج_الاصنافBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.كتلوج_الاصنافBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.رقم_الكتلوجTextBox = New System.Windows.Forms.TextBox()
        Me.اسم_الكتلوجTextBox = New System.Windows.Forms.TextBox()
        Me.ملاحظاتTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        رقم_الكتلوجLabel = New System.Windows.Forms.Label()
        اسم_الكتلوجLabel = New System.Windows.Forms.Label()
        ملاحظاتLabel = New System.Windows.Forms.Label()
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.كتلوج_الاصنافBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.كتلوج_الاصنافBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.كتلوج_الاصنافBindingNavigator.SuspendLayout()
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
        'كتلوج_الاصنافBindingSource
        '
        Me.كتلوج_الاصنافBindingSource.DataMember = "كتلوج الاصناف"
        Me.كتلوج_الاصنافBindingSource.DataSource = Me.مخازنDataSet
        '
        'كتلوج_الاصنافTableAdapter
        '
        Me.كتلوج_الاصنافTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = المخازن.مخازنDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.الاذنTableAdapter = Nothing
        Me.TableAdapterManager.الارصدة_الافتتاحيةTableAdapter = Nothing
        Me.TableAdapterManager.البلدTableAdapter = Nothing
        Me.TableAdapterManager.المخزنTableAdapter = Nothing
        Me.TableAdapterManager.الوحداتTableAdapter = Nothing
        Me.TableAdapterManager.بطاقة_الصنفTableAdapter = Nothing
        Me.TableAdapterManager.جدول_طلبات_الصرف_اصنافTableAdapter = Nothing
        Me.TableAdapterManager.جدول_مخازن___اصنافTableAdapter = Nothing
        Me.TableAdapterManager.طلبات_الصرفTableAdapter = Nothing
        Me.TableAdapterManager.كتلوج_الاصنافTableAdapter = Me.كتلوج_الاصنافTableAdapter
        '
        'كتلوج_الاصنافBindingNavigator
        '
        Me.كتلوج_الاصنافBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.كتلوج_الاصنافBindingNavigator.BindingSource = Me.كتلوج_الاصنافBindingSource
        Me.كتلوج_الاصنافBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.كتلوج_الاصنافBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.كتلوج_الاصنافBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.كتلوج_الاصنافBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.كتلوج_الاصنافBindingNavigatorSaveItem})
        Me.كتلوج_الاصنافBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.كتلوج_الاصنافBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.كتلوج_الاصنافBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.كتلوج_الاصنافBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.كتلوج_الاصنافBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.كتلوج_الاصنافBindingNavigator.Name = "كتلوج_الاصنافBindingNavigator"
        Me.كتلوج_الاصنافBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.كتلوج_الاصنافBindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.كتلوج_الاصنافBindingNavigator.TabIndex = 2
        Me.كتلوج_الاصنافBindingNavigator.Text = "BindingNavigator1"
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
        'كتلوج_الاصنافBindingNavigatorSaveItem
        '
        Me.كتلوج_الاصنافBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.كتلوج_الاصنافBindingNavigatorSaveItem.Image = CType(resources.GetObject("كتلوج_الاصنافBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.كتلوج_الاصنافBindingNavigatorSaveItem.Name = "كتلوج_الاصنافBindingNavigatorSaveItem"
        Me.كتلوج_الاصنافBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.كتلوج_الاصنافBindingNavigatorSaveItem.Text = "Save Data"
        '
        'رقم_الكتلوجLabel
        '
        رقم_الكتلوجLabel.AutoSize = True
        رقم_الكتلوجLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        رقم_الكتلوجLabel.Location = New System.Drawing.Point(323, 222)
        رقم_الكتلوجLabel.Name = "رقم_الكتلوجLabel"
        رقم_الكتلوجLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_الكتلوجLabel.Size = New System.Drawing.Size(132, 29)
        رقم_الكتلوجLabel.TabIndex = 2
        رقم_الكتلوجLabel.Text = "رقم الكتلوج:"
        '
        'رقم_الكتلوجTextBox
        '
        Me.رقم_الكتلوجTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.كتلوج_الاصنافBindingSource, "رقم الكتلوج", True))
        Me.رقم_الكتلوجTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.رقم_الكتلوجTextBox.Location = New System.Drawing.Point(138, 219)
        Me.رقم_الكتلوجTextBox.Name = "رقم_الكتلوجTextBox"
        Me.رقم_الكتلوجTextBox.Size = New System.Drawing.Size(158, 36)
        Me.رقم_الكتلوجTextBox.TabIndex = 3
        '
        'اسم_الكتلوجLabel
        '
        اسم_الكتلوجLabel.AutoSize = True
        اسم_الكتلوجLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        اسم_الكتلوجLabel.Location = New System.Drawing.Point(323, 252)
        اسم_الكتلوجLabel.Name = "اسم_الكتلوجLabel"
        اسم_الكتلوجLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        اسم_الكتلوجLabel.Size = New System.Drawing.Size(143, 29)
        اسم_الكتلوجLabel.TabIndex = 4
        اسم_الكتلوجLabel.Text = "اسم الكتلوج:"
        '
        'اسم_الكتلوجTextBox
        '
        Me.اسم_الكتلوجTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.كتلوج_الاصنافBindingSource, "اسم الكتلوج", True))
        Me.اسم_الكتلوجTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.اسم_الكتلوجTextBox.Location = New System.Drawing.Point(138, 249)
        Me.اسم_الكتلوجTextBox.Name = "اسم_الكتلوجTextBox"
        Me.اسم_الكتلوجTextBox.Size = New System.Drawing.Size(158, 36)
        Me.اسم_الكتلوجTextBox.TabIndex = 5
        '
        'ملاحظاتLabel
        '
        ملاحظاتLabel.AutoSize = True
        ملاحظاتLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        ملاحظاتLabel.Location = New System.Drawing.Point(323, 282)
        ملاحظاتLabel.Name = "ملاحظاتLabel"
        ملاحظاتLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ملاحظاتLabel.Size = New System.Drawing.Size(109, 29)
        ملاحظاتLabel.TabIndex = 6
        ملاحظاتLabel.Text = "ملاحظات:"
        '
        'ملاحظاتTextBox
        '
        Me.ملاحظاتTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.كتلوج_الاصنافBindingSource, "ملاحظات", True))
        Me.ملاحظاتTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ملاحظاتTextBox.Location = New System.Drawing.Point(138, 279)
        Me.ملاحظاتTextBox.Name = "ملاحظاتTextBox"
        Me.ملاحظاتTextBox.Size = New System.Drawing.Size(158, 36)
        Me.ملاحظاتTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(435, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "كتلوج الاصناف"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(رقم_الكتلوجLabel)
        Me.Controls.Add(Me.رقم_الكتلوجTextBox)
        Me.Controls.Add(اسم_الكتلوجLabel)
        Me.Controls.Add(Me.اسم_الكتلوجTextBox)
        Me.Controls.Add(ملاحظاتLabel)
        Me.Controls.Add(Me.ملاحظاتTextBox)
        Me.Controls.Add(Me.كتلوج_الاصنافBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form11"
        Me.Text = "كتلوج الاصناف"
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.كتلوج_الاصنافBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.كتلوج_الاصنافBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.كتلوج_الاصنافBindingNavigator.ResumeLayout(False)
        Me.كتلوج_الاصنافBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents مخازنDataSet As مخازنDataSet
    Friend WithEvents كتلوج_الاصنافBindingSource As BindingSource
    Friend WithEvents كتلوج_الاصنافTableAdapter As مخازنDataSetTableAdapters.كتلوج_الاصنافTableAdapter
    Friend WithEvents TableAdapterManager As مخازنDataSetTableAdapters.TableAdapterManager
    Friend WithEvents كتلوج_الاصنافBindingNavigator As BindingNavigator
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
    Friend WithEvents كتلوج_الاصنافBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents رقم_الكتلوجTextBox As TextBox
    Friend WithEvents اسم_الكتلوجTextBox As TextBox
    Friend WithEvents ملاحظاتTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
