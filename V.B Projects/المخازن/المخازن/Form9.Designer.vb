<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Dim السنه_الماليهLabel As System.Windows.Forms.Label
        Dim رقم_المخزنLabel As System.Windows.Forms.Label
        Dim رقم_الصنفLabel As System.Windows.Forms.Label
        Dim رقم_الاذنLabel As System.Windows.Forms.Label
        Dim الكمية_الافتتاحيةLabel As System.Windows.Forms.Label
        Dim الكمية_الواردةLabel As System.Windows.Forms.Label
        Dim الكمية_المنصرفةLabel As System.Windows.Forms.Label
        Dim تاريخLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.مخازنDataSet = New المخازن.مخازنDataSet()
        Me.جدول_مخازن___اصنافBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.جدول_مخازن___اصنافTableAdapter = New المخازن.مخازنDataSetTableAdapters.جدول_مخازن___اصنافTableAdapter()
        Me.TableAdapterManager = New المخازن.مخازنDataSetTableAdapters.TableAdapterManager()
        Me.جدول_مخازن___اصنافBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.جدول_مخازن___اصنافBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.السنه_الماليهDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.رقم_المخزنTextBox = New System.Windows.Forms.TextBox()
        Me.رقم_الصنفTextBox = New System.Windows.Forms.TextBox()
        Me.رقم_الاذنTextBox = New System.Windows.Forms.TextBox()
        Me.الكمية_الافتتاحيةTextBox = New System.Windows.Forms.TextBox()
        Me.الكمية_الواردةTextBox = New System.Windows.Forms.TextBox()
        Me.الكمية_المنصرفةTextBox = New System.Windows.Forms.TextBox()
        Me.تاريخDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        السنه_الماليهLabel = New System.Windows.Forms.Label()
        رقم_المخزنLabel = New System.Windows.Forms.Label()
        رقم_الصنفLabel = New System.Windows.Forms.Label()
        رقم_الاذنLabel = New System.Windows.Forms.Label()
        الكمية_الافتتاحيةLabel = New System.Windows.Forms.Label()
        الكمية_الواردةLabel = New System.Windows.Forms.Label()
        الكمية_المنصرفةLabel = New System.Windows.Forms.Label()
        تاريخLabel = New System.Windows.Forms.Label()
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.جدول_مخازن___اصنافBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.جدول_مخازن___اصنافBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.جدول_مخازن___اصنافBindingNavigator.SuspendLayout()
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
        'جدول_مخازن___اصنافBindingSource
        '
        Me.جدول_مخازن___اصنافBindingSource.DataMember = "جدول مخازن - اصناف"
        Me.جدول_مخازن___اصنافBindingSource.DataSource = Me.مخازنDataSet
        '
        'جدول_مخازن___اصنافTableAdapter
        '
        Me.جدول_مخازن___اصنافTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.جدول_مخازن___اصنافTableAdapter = Me.جدول_مخازن___اصنافTableAdapter
        Me.TableAdapterManager.طلبات_الصرفTableAdapter = Nothing
        Me.TableAdapterManager.كتلوج_الاصنافTableAdapter = Nothing
        '
        'جدول_مخازن___اصنافBindingNavigator
        '
        Me.جدول_مخازن___اصنافBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.جدول_مخازن___اصنافBindingNavigator.BindingSource = Me.جدول_مخازن___اصنافBindingSource
        Me.جدول_مخازن___اصنافBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.جدول_مخازن___اصنافBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.جدول_مخازن___اصنافBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.جدول_مخازن___اصنافBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.جدول_مخازن___اصنافBindingNavigatorSaveItem})
        Me.جدول_مخازن___اصنافBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.جدول_مخازن___اصنافBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.جدول_مخازن___اصنافBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.جدول_مخازن___اصنافBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.جدول_مخازن___اصنافBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.جدول_مخازن___اصنافBindingNavigator.Name = "جدول_مخازن___اصنافBindingNavigator"
        Me.جدول_مخازن___اصنافBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.جدول_مخازن___اصنافBindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.جدول_مخازن___اصنافBindingNavigator.TabIndex = 2
        Me.جدول_مخازن___اصنافBindingNavigator.Text = "BindingNavigator1"
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
        'جدول_مخازن___اصنافBindingNavigatorSaveItem
        '
        Me.جدول_مخازن___اصنافBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.جدول_مخازن___اصنافBindingNavigatorSaveItem.Image = CType(resources.GetObject("جدول_مخازن___اصنافBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.جدول_مخازن___اصنافBindingNavigatorSaveItem.Name = "جدول_مخازن___اصنافBindingNavigatorSaveItem"
        Me.جدول_مخازن___اصنافBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.جدول_مخازن___اصنافBindingNavigatorSaveItem.Text = "Save Data"
        '
        'السنه_الماليهLabel
        '
        السنه_الماليهLabel.AutoSize = True
        السنه_الماليهLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        السنه_الماليهLabel.Location = New System.Drawing.Point(428, 163)
        السنه_الماليهLabel.Name = "السنه_الماليهLabel"
        السنه_الماليهLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        السنه_الماليهLabel.Size = New System.Drawing.Size(153, 29)
        السنه_الماليهLabel.TabIndex = 2
        السنه_الماليهLabel.Text = "السنه الماليه:"
        '
        'السنه_الماليهDateTimePicker
        '
        Me.السنه_الماليهDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.جدول_مخازن___اصنافBindingSource, "السنه الماليه", True))
        Me.السنه_الماليهDateTimePicker.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.السنه_الماليهDateTimePicker.Location = New System.Drawing.Point(32, 159)
        Me.السنه_الماليهDateTimePicker.Name = "السنه_الماليهDateTimePicker"
        Me.السنه_الماليهDateTimePicker.Size = New System.Drawing.Size(344, 36)
        Me.السنه_الماليهDateTimePicker.TabIndex = 3
        '
        'رقم_المخزنLabel
        '
        رقم_المخزنLabel.AutoSize = True
        رقم_المخزنLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        رقم_المخزنLabel.Location = New System.Drawing.Point(428, 192)
        رقم_المخزنLabel.Name = "رقم_المخزنLabel"
        رقم_المخزنLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_المخزنLabel.Size = New System.Drawing.Size(134, 29)
        رقم_المخزنLabel.TabIndex = 4
        رقم_المخزنLabel.Text = "رقم المخزن:"
        '
        'رقم_المخزنTextBox
        '
        Me.رقم_المخزنTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.جدول_مخازن___اصنافBindingSource, "رقم المخزن", True))
        Me.رقم_المخزنTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.رقم_المخزنTextBox.Location = New System.Drawing.Point(32, 189)
        Me.رقم_المخزنTextBox.Name = "رقم_المخزنTextBox"
        Me.رقم_المخزنTextBox.Size = New System.Drawing.Size(344, 36)
        Me.رقم_المخزنTextBox.TabIndex = 5
        '
        'رقم_الصنفLabel
        '
        رقم_الصنفLabel.AutoSize = True
        رقم_الصنفLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        رقم_الصنفLabel.Location = New System.Drawing.Point(428, 222)
        رقم_الصنفLabel.Name = "رقم_الصنفLabel"
        رقم_الصنفLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_الصنفLabel.Size = New System.Drawing.Size(125, 29)
        رقم_الصنفLabel.TabIndex = 6
        رقم_الصنفLabel.Text = "رقم الصنف:"
        '
        'رقم_الصنفTextBox
        '
        Me.رقم_الصنفTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.جدول_مخازن___اصنافBindingSource, "رقم الصنف", True))
        Me.رقم_الصنفTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.رقم_الصنفTextBox.Location = New System.Drawing.Point(32, 219)
        Me.رقم_الصنفTextBox.Name = "رقم_الصنفTextBox"
        Me.رقم_الصنفTextBox.Size = New System.Drawing.Size(344, 36)
        Me.رقم_الصنفTextBox.TabIndex = 7
        '
        'رقم_الاذنLabel
        '
        رقم_الاذنLabel.AutoSize = True
        رقم_الاذنLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        رقم_الاذنLabel.Location = New System.Drawing.Point(428, 252)
        رقم_الاذنLabel.Name = "رقم_الاذنLabel"
        رقم_الاذنLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_الاذنLabel.Size = New System.Drawing.Size(112, 29)
        رقم_الاذنLabel.TabIndex = 8
        رقم_الاذنLabel.Text = "رقم الاذن:"
        '
        'رقم_الاذنTextBox
        '
        Me.رقم_الاذنTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.جدول_مخازن___اصنافBindingSource, "رقم الاذن", True))
        Me.رقم_الاذنTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.رقم_الاذنTextBox.Location = New System.Drawing.Point(32, 249)
        Me.رقم_الاذنTextBox.Name = "رقم_الاذنTextBox"
        Me.رقم_الاذنTextBox.Size = New System.Drawing.Size(344, 36)
        Me.رقم_الاذنTextBox.TabIndex = 9
        '
        'الكمية_الافتتاحيةLabel
        '
        الكمية_الافتتاحيةLabel.AutoSize = True
        الكمية_الافتتاحيةLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        الكمية_الافتتاحيةLabel.Location = New System.Drawing.Point(428, 282)
        الكمية_الافتتاحيةLabel.Name = "الكمية_الافتتاحيةLabel"
        الكمية_الافتتاحيةLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الكمية_الافتتاحيةLabel.Size = New System.Drawing.Size(184, 29)
        الكمية_الافتتاحيةLabel.TabIndex = 10
        الكمية_الافتتاحيةLabel.Text = "الكمية الافتتاحية:"
        '
        'الكمية_الافتتاحيةTextBox
        '
        Me.الكمية_الافتتاحيةTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.جدول_مخازن___اصنافBindingSource, "الكمية الافتتاحية", True))
        Me.الكمية_الافتتاحيةTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.الكمية_الافتتاحيةTextBox.Location = New System.Drawing.Point(32, 279)
        Me.الكمية_الافتتاحيةTextBox.Name = "الكمية_الافتتاحيةTextBox"
        Me.الكمية_الافتتاحيةTextBox.Size = New System.Drawing.Size(344, 36)
        Me.الكمية_الافتتاحيةTextBox.TabIndex = 11
        '
        'الكمية_الواردةLabel
        '
        الكمية_الواردةLabel.AutoSize = True
        الكمية_الواردةLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        الكمية_الواردةLabel.Location = New System.Drawing.Point(428, 312)
        الكمية_الواردةLabel.Name = "الكمية_الواردةLabel"
        الكمية_الواردةLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الكمية_الواردةLabel.Size = New System.Drawing.Size(153, 29)
        الكمية_الواردةLabel.TabIndex = 12
        الكمية_الواردةLabel.Text = "الكمية الواردة:"
        '
        'الكمية_الواردةTextBox
        '
        Me.الكمية_الواردةTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.جدول_مخازن___اصنافBindingSource, "الكمية الواردة", True))
        Me.الكمية_الواردةTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.الكمية_الواردةTextBox.Location = New System.Drawing.Point(32, 309)
        Me.الكمية_الواردةTextBox.Name = "الكمية_الواردةTextBox"
        Me.الكمية_الواردةTextBox.Size = New System.Drawing.Size(344, 36)
        Me.الكمية_الواردةTextBox.TabIndex = 13
        '
        'الكمية_المنصرفةLabel
        '
        الكمية_المنصرفةLabel.AutoSize = True
        الكمية_المنصرفةLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        الكمية_المنصرفةLabel.Location = New System.Drawing.Point(428, 342)
        الكمية_المنصرفةLabel.Name = "الكمية_المنصرفةLabel"
        الكمية_المنصرفةLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الكمية_المنصرفةLabel.Size = New System.Drawing.Size(180, 29)
        الكمية_المنصرفةLabel.TabIndex = 14
        الكمية_المنصرفةLabel.Text = "الكمية المنصرفة:"
        '
        'الكمية_المنصرفةTextBox
        '
        Me.الكمية_المنصرفةTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.جدول_مخازن___اصنافBindingSource, "الكمية المنصرفة", True))
        Me.الكمية_المنصرفةTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.الكمية_المنصرفةTextBox.Location = New System.Drawing.Point(32, 339)
        Me.الكمية_المنصرفةTextBox.Name = "الكمية_المنصرفةTextBox"
        Me.الكمية_المنصرفةTextBox.Size = New System.Drawing.Size(344, 36)
        Me.الكمية_المنصرفةTextBox.TabIndex = 15
        '
        'تاريخLabel
        '
        تاريخLabel.AutoSize = True
        تاريخLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        تاريخLabel.Location = New System.Drawing.Point(428, 373)
        تاريخLabel.Name = "تاريخLabel"
        تاريخLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        تاريخLabel.Size = New System.Drawing.Size(68, 29)
        تاريخLabel.TabIndex = 16
        تاريخLabel.Text = "تاريخ:"
        '
        'تاريخDateTimePicker
        '
        Me.تاريخDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.جدول_مخازن___اصنافBindingSource, "تاريخ", True))
        Me.تاريخDateTimePicker.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.تاريخDateTimePicker.Location = New System.Drawing.Point(32, 369)
        Me.تاريخDateTimePicker.Name = "تاريخDateTimePicker"
        Me.تاريخDateTimePicker.Size = New System.Drawing.Size(344, 36)
        Me.تاريخDateTimePicker.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(423, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 30)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "جدول مخازن - اصناف"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(السنه_الماليهLabel)
        Me.Controls.Add(Me.السنه_الماليهDateTimePicker)
        Me.Controls.Add(رقم_المخزنLabel)
        Me.Controls.Add(Me.رقم_المخزنTextBox)
        Me.Controls.Add(رقم_الصنفLabel)
        Me.Controls.Add(Me.رقم_الصنفTextBox)
        Me.Controls.Add(رقم_الاذنLabel)
        Me.Controls.Add(Me.رقم_الاذنTextBox)
        Me.Controls.Add(الكمية_الافتتاحيةLabel)
        Me.Controls.Add(Me.الكمية_الافتتاحيةTextBox)
        Me.Controls.Add(الكمية_الواردةLabel)
        Me.Controls.Add(Me.الكمية_الواردةTextBox)
        Me.Controls.Add(الكمية_المنصرفةLabel)
        Me.Controls.Add(Me.الكمية_المنصرفةTextBox)
        Me.Controls.Add(تاريخLabel)
        Me.Controls.Add(Me.تاريخDateTimePicker)
        Me.Controls.Add(Me.جدول_مخازن___اصنافBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form9"
        Me.Text = "جدول مخازن-اصناف"
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.جدول_مخازن___اصنافBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.جدول_مخازن___اصنافBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.جدول_مخازن___اصنافBindingNavigator.ResumeLayout(False)
        Me.جدول_مخازن___اصنافBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents مخازنDataSet As مخازنDataSet
    Friend WithEvents جدول_مخازن___اصنافBindingSource As BindingSource
    Friend WithEvents جدول_مخازن___اصنافTableAdapter As مخازنDataSetTableAdapters.جدول_مخازن___اصنافTableAdapter
    Friend WithEvents TableAdapterManager As مخازنDataSetTableAdapters.TableAdapterManager
    Friend WithEvents جدول_مخازن___اصنافBindingNavigator As BindingNavigator
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
    Friend WithEvents جدول_مخازن___اصنافBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents السنه_الماليهDateTimePicker As DateTimePicker
    Friend WithEvents رقم_المخزنTextBox As TextBox
    Friend WithEvents رقم_الصنفTextBox As TextBox
    Friend WithEvents رقم_الاذنTextBox As TextBox
    Friend WithEvents الكمية_الافتتاحيةTextBox As TextBox
    Friend WithEvents الكمية_الواردةTextBox As TextBox
    Friend WithEvents الكمية_المنصرفةTextBox As TextBox
    Friend WithEvents تاريخDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
