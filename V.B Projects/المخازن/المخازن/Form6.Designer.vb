﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.مخازنDataSet = New المخازن.مخازنDataSet()
        Me.الوحداتBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.الوحداتTableAdapter = New المخازن.مخازنDataSetTableAdapters.الوحداتTableAdapter()
        Me.TableAdapterManager = New المخازن.مخازنDataSetTableAdapters.TableAdapterManager()
        Me.الوحداتBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.الوحداتBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.الوحداتDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.الوحداتBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.الوحداتBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.الوحداتBindingNavigator.SuspendLayout()
        CType(Me.الوحداتDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'الوحداتBindingSource
        '
        Me.الوحداتBindingSource.DataMember = "الوحدات"
        Me.الوحداتBindingSource.DataSource = Me.مخازنDataSet
        '
        'الوحداتTableAdapter
        '
        Me.الوحداتTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = المخازن.مخازنDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.الاذنTableAdapter = Nothing
        Me.TableAdapterManager.الارصدة_الافتتاحيةTableAdapter = Nothing
        Me.TableAdapterManager.البلدTableAdapter = Nothing
        Me.TableAdapterManager.المخزنTableAdapter = Nothing
        Me.TableAdapterManager.الوحداتTableAdapter = Me.الوحداتTableAdapter
        Me.TableAdapterManager.بطاقة_الصنفTableAdapter = Nothing
        Me.TableAdapterManager.جدول_طلبات_الصرف_اصنافTableAdapter = Nothing
        Me.TableAdapterManager.جدول_مخازن___اصنافTableAdapter = Nothing
        Me.TableAdapterManager.طلبات_الصرفTableAdapter = Nothing
        Me.TableAdapterManager.كتلوج_الاصنافTableAdapter = Nothing
        '
        'الوحداتBindingNavigator
        '
        Me.الوحداتBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.الوحداتBindingNavigator.BindingSource = Me.الوحداتBindingSource
        Me.الوحداتBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.الوحداتBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.الوحداتBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.الوحداتBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.الوحداتBindingNavigatorSaveItem})
        Me.الوحداتBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.الوحداتBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.الوحداتBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.الوحداتBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.الوحداتBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.الوحداتBindingNavigator.Name = "الوحداتBindingNavigator"
        Me.الوحداتBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.الوحداتBindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.الوحداتBindingNavigator.TabIndex = 2
        Me.الوحداتBindingNavigator.Text = "BindingNavigator1"
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
        'الوحداتBindingNavigatorSaveItem
        '
        Me.الوحداتBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.الوحداتBindingNavigatorSaveItem.Image = CType(resources.GetObject("الوحداتBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.الوحداتBindingNavigatorSaveItem.Name = "الوحداتBindingNavigatorSaveItem"
        Me.الوحداتBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.الوحداتBindingNavigatorSaveItem.Text = "Save Data"
        '
        'الوحداتDataGridView
        '
        Me.الوحداتDataGridView.AutoGenerateColumns = False
        Me.الوحداتDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.الوحداتDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.الوحداتDataGridView.DataSource = Me.الوحداتBindingSource
        Me.الوحداتDataGridView.Location = New System.Drawing.Point(12, 170)
        Me.الوحداتDataGridView.Name = "الوحداتDataGridView"
        Me.الوحداتDataGridView.RowTemplate.Height = 26
        Me.الوحداتDataGridView.Size = New System.Drawing.Size(921, 175)
        Me.الوحداتDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "رقم الوحدة"
        Me.DataGridViewTextBoxColumn1.HeaderText = "رقم الوحدة"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "اسم الوحدة"
        Me.DataGridViewTextBoxColumn2.HeaderText = "اسم الوحدة"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(433, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "الوحدات"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.الوحداتDataGridView)
        Me.Controls.Add(Me.الوحداتBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form6"
        Me.Text = "الوحدات"
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.الوحداتBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.الوحداتBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.الوحداتBindingNavigator.ResumeLayout(False)
        Me.الوحداتBindingNavigator.PerformLayout()
        CType(Me.الوحداتDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents مخازنDataSet As مخازنDataSet
    Friend WithEvents الوحداتBindingSource As BindingSource
    Friend WithEvents الوحداتTableAdapter As مخازنDataSetTableAdapters.الوحداتTableAdapter
    Friend WithEvents TableAdapterManager As مخازنDataSetTableAdapters.TableAdapterManager
    Friend WithEvents الوحداتBindingNavigator As BindingNavigator
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
    Friend WithEvents الوحداتBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents الوحداتDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
