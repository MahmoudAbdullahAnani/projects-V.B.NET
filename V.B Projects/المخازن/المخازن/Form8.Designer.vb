<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.مخازنDataSet = New المخازن.مخازنDataSet()
        Me.جدول_طلبات_الصرف_اصنافBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.جدول_طلبات_الصرف_اصنافTableAdapter = New المخازن.مخازنDataSetTableAdapters.جدول_طلبات_الصرف_اصنافTableAdapter()
        Me.TableAdapterManager = New المخازن.مخازنDataSetTableAdapters.TableAdapterManager()
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.جدول_طلبات_الصرف_اصنافDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.جدول_طلبات_الصرف_اصنافBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.جدول_طلبات_الصرف_اصنافBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.SuspendLayout()
        CType(Me.جدول_طلبات_الصرف_اصنافDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'جدول_طلبات_الصرف_اصنافBindingSource
        '
        Me.جدول_طلبات_الصرف_اصنافBindingSource.DataMember = "جدول طلبات الصرف-اصناف"
        Me.جدول_طلبات_الصرف_اصنافBindingSource.DataSource = Me.مخازنDataSet
        '
        'جدول_طلبات_الصرف_اصنافTableAdapter
        '
        Me.جدول_طلبات_الصرف_اصنافTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.جدول_طلبات_الصرف_اصنافTableAdapter = Me.جدول_طلبات_الصرف_اصنافTableAdapter
        Me.TableAdapterManager.جدول_مخازن___اصنافTableAdapter = Nothing
        Me.TableAdapterManager.طلبات_الصرفTableAdapter = Nothing
        Me.TableAdapterManager.كتلوج_الاصنافTableAdapter = Nothing
        '
        'جدول_طلبات_الصرف_اصنافBindingNavigator
        '
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.BindingSource = Me.جدول_طلبات_الصرف_اصنافBindingSource
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem})
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.Name = "جدول_طلبات_الصرف_اصنافBindingNavigator"
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.TabIndex = 2
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem
        '
        Me.جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem.Image = CType(resources.GetObject("جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem.Name = "جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem"
        Me.جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem.Text = "Save Data"
        '
        'جدول_طلبات_الصرف_اصنافDataGridView
        '
        Me.جدول_طلبات_الصرف_اصنافDataGridView.AutoGenerateColumns = False
        Me.جدول_طلبات_الصرف_اصنافDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.جدول_طلبات_الصرف_اصنافDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.جدول_طلبات_الصرف_اصنافDataGridView.DataSource = Me.جدول_طلبات_الصرف_اصنافBindingSource
        Me.جدول_طلبات_الصرف_اصنافDataGridView.Location = New System.Drawing.Point(12, 182)
        Me.جدول_طلبات_الصرف_اصنافDataGridView.Name = "جدول_طلبات_الصرف_اصنافDataGridView"
        Me.جدول_طلبات_الصرف_اصنافDataGridView.RowTemplate.Height = 26
        Me.جدول_طلبات_الصرف_اصنافDataGridView.Size = New System.Drawing.Size(908, 162)
        Me.جدول_طلبات_الصرف_اصنافDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "رقم الصنف"
        Me.DataGridViewTextBoxColumn1.HeaderText = "رقم الصنف"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "رقم طلبات الصرف"
        Me.DataGridViewTextBoxColumn2.HeaderText = "رقم طلبات الصرف"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "الكمية المطلوبة"
        Me.DataGridViewTextBoxColumn3.HeaderText = "الكمية المطلوبة"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "التاريخ التوريد المطلوب لصنف"
        Me.DataGridViewTextBoxColumn4.HeaderText = "التاريخ التوريد المطلوب لصنف"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(366, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "جدول طلبات الصنف-اصناف"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.جدول_طلبات_الصرف_اصنافDataGridView)
        Me.Controls.Add(Me.جدول_طلبات_الصرف_اصنافBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form8"
        Me.Text = "جدول طلبات الصرف-اصناف"
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.جدول_طلبات_الصرف_اصنافBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.جدول_طلبات_الصرف_اصنافBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.ResumeLayout(False)
        Me.جدول_طلبات_الصرف_اصنافBindingNavigator.PerformLayout()
        CType(Me.جدول_طلبات_الصرف_اصنافDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents مخازنDataSet As مخازنDataSet
    Friend WithEvents جدول_طلبات_الصرف_اصنافBindingSource As BindingSource
    Friend WithEvents جدول_طلبات_الصرف_اصنافTableAdapter As مخازنDataSetTableAdapters.جدول_طلبات_الصرف_اصنافTableAdapter
    Friend WithEvents TableAdapterManager As مخازنDataSetTableAdapters.TableAdapterManager
    Friend WithEvents جدول_طلبات_الصرف_اصنافBindingNavigator As BindingNavigator
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
    Friend WithEvents جدول_طلبات_الصرف_اصنافBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents جدول_طلبات_الصرف_اصنافDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
