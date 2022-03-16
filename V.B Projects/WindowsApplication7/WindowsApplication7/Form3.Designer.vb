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
        Dim IDLabel As System.Windows.Forms.Label
        Dim حالة_السريرLabel As System.Windows.Forms.Label
        Dim المساحةLabel As System.Windows.Forms.Label
        Dim متاحLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TestDataSet = New WindowsApplication7.testDataSet()
        Me.السريرBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.السريرTableAdapter = New WindowsApplication7.testDataSetTableAdapters.السريرTableAdapter()
        Me.TableAdapterManager = New WindowsApplication7.testDataSetTableAdapters.TableAdapterManager()
        Me.السريرBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.السريرBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.حالة_السريرTextBox = New System.Windows.Forms.TextBox()
        Me.المساحةTextBox = New System.Windows.Forms.TextBox()
        Me.متاحCheckBox = New System.Windows.Forms.CheckBox()
        IDLabel = New System.Windows.Forms.Label()
        حالة_السريرLabel = New System.Windows.Forms.Label()
        المساحةLabel = New System.Windows.Forms.Label()
        متاحLabel = New System.Windows.Forms.Label()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.السريرBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.السريرBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.السريرBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(847, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 61)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "عودة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'السريرBindingSource
        '
        Me.السريرBindingSource.DataMember = "السرير"
        Me.السريرBindingSource.DataSource = Me.TestDataSet
        '
        'السريرTableAdapter
        '
        Me.السريرTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApplication7.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.السريرTableAdapter = Me.السريرTableAdapter
        Me.TableAdapterManager.المريضTableAdapter = Nothing
        '
        'السريرBindingNavigator
        '
        Me.السريرBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.السريرBindingNavigator.BindingSource = Me.السريرBindingSource
        Me.السريرBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.السريرBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.السريرBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.السريرBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.السريرBindingNavigatorSaveItem})
        Me.السريرBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.السريرBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.السريرBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.السريرBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.السريرBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.السريرBindingNavigator.Name = "السريرBindingNavigator"
        Me.السريرBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.السريرBindingNavigator.Size = New System.Drawing.Size(1021, 27)
        Me.السريرBindingNavigator.TabIndex = 2
        Me.السريرBindingNavigator.Text = "BindingNavigator1"
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
        'السريرBindingNavigatorSaveItem
        '
        Me.السريرBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.السريرBindingNavigatorSaveItem.Image = CType(resources.GetObject("السريرBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.السريرBindingNavigatorSaveItem.Name = "السريرBindingNavigatorSaveItem"
        Me.السريرBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.السريرBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(347, 236)
        IDLabel.Name = "IDLabel"
        IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel.Size = New System.Drawing.Size(27, 17)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.السريرBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(94, 236)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(172, 24)
        Me.IDTextBox.TabIndex = 3
        '
        'حالة_السريرLabel
        '
        حالة_السريرLabel.AutoSize = True
        حالة_السريرLabel.Location = New System.Drawing.Point(347, 266)
        حالة_السريرLabel.Name = "حالة_السريرLabel"
        حالة_السريرLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        حالة_السريرLabel.Size = New System.Drawing.Size(80, 17)
        حالة_السريرLabel.TabIndex = 4
        حالة_السريرLabel.Text = "حالة السرير:"
        '
        'حالة_السريرTextBox
        '
        Me.حالة_السريرTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.السريرBindingSource, "حالة السرير", True))
        Me.حالة_السريرTextBox.Location = New System.Drawing.Point(94, 266)
        Me.حالة_السريرTextBox.Name = "حالة_السريرTextBox"
        Me.حالة_السريرTextBox.Size = New System.Drawing.Size(172, 24)
        Me.حالة_السريرTextBox.TabIndex = 5
        '
        'المساحةLabel
        '
        المساحةLabel.AutoSize = True
        المساحةLabel.Location = New System.Drawing.Point(347, 296)
        المساحةLabel.Name = "المساحةLabel"
        المساحةLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        المساحةLabel.Size = New System.Drawing.Size(65, 17)
        المساحةLabel.TabIndex = 6
        المساحةLabel.Text = "المساحة:"
        '
        'المساحةTextBox
        '
        Me.المساحةTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.السريرBindingSource, "المساحة", True))
        Me.المساحةTextBox.Location = New System.Drawing.Point(94, 296)
        Me.المساحةTextBox.Name = "المساحةTextBox"
        Me.المساحةTextBox.Size = New System.Drawing.Size(172, 24)
        Me.المساحةTextBox.TabIndex = 7
        '
        'متاحLabel
        '
        متاحLabel.AutoSize = True
        متاحLabel.Location = New System.Drawing.Point(347, 328)
        متاحLabel.Name = "متاحLabel"
        متاحLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        متاحLabel.Size = New System.Drawing.Size(38, 17)
        متاحLabel.TabIndex = 8
        متاحLabel.Text = "متاح:"
        '
        'متاحCheckBox
        '
        Me.متاحCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.السريرBindingSource, "متاح", True))
        Me.متاحCheckBox.Location = New System.Drawing.Point(94, 326)
        Me.متاحCheckBox.Name = "متاحCheckBox"
        Me.متاحCheckBox.Size = New System.Drawing.Size(172, 24)
        Me.متاحCheckBox.TabIndex = 9
        Me.متاحCheckBox.Text = "CheckBox1"
        Me.متاحCheckBox.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 520)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(حالة_السريرLabel)
        Me.Controls.Add(Me.حالة_السريرTextBox)
        Me.Controls.Add(المساحةLabel)
        Me.Controls.Add(Me.المساحةTextBox)
        Me.Controls.Add(متاحLabel)
        Me.Controls.Add(Me.متاحCheckBox)
        Me.Controls.Add(Me.السريرBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.السريرBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.السريرBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.السريرBindingNavigator.ResumeLayout(False)
        Me.السريرBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents السريرBindingSource As BindingSource
    Friend WithEvents السريرTableAdapter As testDataSetTableAdapters.السريرTableAdapter
    Friend WithEvents TableAdapterManager As testDataSetTableAdapters.TableAdapterManager
    Friend WithEvents السريرBindingNavigator As BindingNavigator
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
    Friend WithEvents السريرBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents حالة_السريرTextBox As TextBox
    Friend WithEvents المساحةTextBox As TextBox
    Friend WithEvents متاحCheckBox As CheckBox
End Class
