<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Dim رقم_الصنفLabel As System.Windows.Forms.Label
        Dim اسم_الصنفLabel As System.Windows.Forms.Label
        Dim الوحدة_الخاصه_بالصنفLabel As System.Windows.Forms.Label
        Dim حد_الطلبLabel As System.Windows.Forms.Label
        Dim الحد_الادنيLabel As System.Windows.Forms.Label
        Dim الحد_الاعليLabel As System.Windows.Forms.Label
        Dim ملاحظاتLabel As System.Windows.Forms.Label
        Dim رقم_الكتلوجLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.مخازنDataSet = New المخازن.مخازنDataSet()
        Me.بطاقة_الصنفBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.بطاقة_الصنفTableAdapter = New المخازن.مخازنDataSetTableAdapters.بطاقة_الصنفTableAdapter()
        Me.TableAdapterManager = New المخازن.مخازنDataSetTableAdapters.TableAdapterManager()
        Me.بطاقة_الصنفBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.بطاقة_الصنفBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.رقم_الصنفTextBox = New System.Windows.Forms.TextBox()
        Me.اسم_الصنفTextBox = New System.Windows.Forms.TextBox()
        Me.الوحدة_الخاصه_بالصنفTextBox = New System.Windows.Forms.TextBox()
        Me.حد_الطلبTextBox = New System.Windows.Forms.TextBox()
        Me.الحد_الادنيTextBox = New System.Windows.Forms.TextBox()
        Me.الحد_الاعليTextBox = New System.Windows.Forms.TextBox()
        Me.ملاحظاتTextBox = New System.Windows.Forms.TextBox()
        Me.رقم_الكتلوجTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        رقم_الصنفLabel = New System.Windows.Forms.Label()
        اسم_الصنفLabel = New System.Windows.Forms.Label()
        الوحدة_الخاصه_بالصنفLabel = New System.Windows.Forms.Label()
        حد_الطلبLabel = New System.Windows.Forms.Label()
        الحد_الادنيLabel = New System.Windows.Forms.Label()
        الحد_الاعليLabel = New System.Windows.Forms.Label()
        ملاحظاتLabel = New System.Windows.Forms.Label()
        رقم_الكتلوجLabel = New System.Windows.Forms.Label()
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.بطاقة_الصنفBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.بطاقة_الصنفBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.بطاقة_الصنفBindingNavigator.SuspendLayout()
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
        'بطاقة_الصنفBindingSource
        '
        Me.بطاقة_الصنفBindingSource.DataMember = "بطاقة الصنف"
        Me.بطاقة_الصنفBindingSource.DataSource = Me.مخازنDataSet
        '
        'بطاقة_الصنفTableAdapter
        '
        Me.بطاقة_الصنفTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.بطاقة_الصنفTableAdapter = Me.بطاقة_الصنفTableAdapter
        Me.TableAdapterManager.جدول_طلبات_الصرف_اصنافTableAdapter = Nothing
        Me.TableAdapterManager.جدول_مخازن___اصنافTableAdapter = Nothing
        Me.TableAdapterManager.طلبات_الصرفTableAdapter = Nothing
        Me.TableAdapterManager.كتلوج_الاصنافTableAdapter = Nothing
        '
        'بطاقة_الصنفBindingNavigator
        '
        Me.بطاقة_الصنفBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.بطاقة_الصنفBindingNavigator.BindingSource = Me.بطاقة_الصنفBindingSource
        Me.بطاقة_الصنفBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.بطاقة_الصنفBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.بطاقة_الصنفBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.بطاقة_الصنفBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.بطاقة_الصنفBindingNavigatorSaveItem})
        Me.بطاقة_الصنفBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.بطاقة_الصنفBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.بطاقة_الصنفBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.بطاقة_الصنفBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.بطاقة_الصنفBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.بطاقة_الصنفBindingNavigator.Name = "بطاقة_الصنفBindingNavigator"
        Me.بطاقة_الصنفBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.بطاقة_الصنفBindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.بطاقة_الصنفBindingNavigator.TabIndex = 2
        Me.بطاقة_الصنفBindingNavigator.Text = "BindingNavigator1"
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
        'بطاقة_الصنفBindingNavigatorSaveItem
        '
        Me.بطاقة_الصنفBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.بطاقة_الصنفBindingNavigatorSaveItem.Image = CType(resources.GetObject("بطاقة_الصنفBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.بطاقة_الصنفBindingNavigatorSaveItem.Name = "بطاقة_الصنفBindingNavigatorSaveItem"
        Me.بطاقة_الصنفBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.بطاقة_الصنفBindingNavigatorSaveItem.Text = "Save Data"
        '
        'رقم_الصنفLabel
        '
        رقم_الصنفLabel.AutoSize = True
        رقم_الصنفLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        رقم_الصنفLabel.Location = New System.Drawing.Point(341, 180)
        رقم_الصنفLabel.Name = "رقم_الصنفLabel"
        رقم_الصنفLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_الصنفLabel.Size = New System.Drawing.Size(125, 29)
        رقم_الصنفLabel.TabIndex = 2
        رقم_الصنفLabel.Text = "رقم الصنف:"
        '
        'رقم_الصنفTextBox
        '
        Me.رقم_الصنفTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "رقم الصنف", True))
        Me.رقم_الصنفTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.رقم_الصنفTextBox.Location = New System.Drawing.Point(136, 180)
        Me.رقم_الصنفTextBox.Name = "رقم_الصنفTextBox"
        Me.رقم_الصنفTextBox.Size = New System.Drawing.Size(164, 36)
        Me.رقم_الصنفTextBox.TabIndex = 3
        '
        'اسم_الصنفLabel
        '
        اسم_الصنفLabel.AutoSize = True
        اسم_الصنفLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        اسم_الصنفLabel.Location = New System.Drawing.Point(341, 210)
        اسم_الصنفLabel.Name = "اسم_الصنفLabel"
        اسم_الصنفLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        اسم_الصنفLabel.Size = New System.Drawing.Size(136, 29)
        اسم_الصنفLabel.TabIndex = 4
        اسم_الصنفLabel.Text = "اسم الصنف:"
        '
        'اسم_الصنفTextBox
        '
        Me.اسم_الصنفTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "اسم الصنف", True))
        Me.اسم_الصنفTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.اسم_الصنفTextBox.Location = New System.Drawing.Point(136, 210)
        Me.اسم_الصنفTextBox.Name = "اسم_الصنفTextBox"
        Me.اسم_الصنفTextBox.Size = New System.Drawing.Size(164, 36)
        Me.اسم_الصنفTextBox.TabIndex = 5
        '
        'الوحدة_الخاصه_بالصنفLabel
        '
        الوحدة_الخاصه_بالصنفLabel.AutoSize = True
        الوحدة_الخاصه_بالصنفLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        الوحدة_الخاصه_بالصنفLabel.Location = New System.Drawing.Point(341, 240)
        الوحدة_الخاصه_بالصنفLabel.Name = "الوحدة_الخاصه_بالصنفLabel"
        الوحدة_الخاصه_بالصنفLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الوحدة_الخاصه_بالصنفLabel.Size = New System.Drawing.Size(238, 29)
        الوحدة_الخاصه_بالصنفLabel.TabIndex = 6
        الوحدة_الخاصه_بالصنفLabel.Text = "الوحدة الخاصه بالصنف:"
        '
        'الوحدة_الخاصه_بالصنفTextBox
        '
        Me.الوحدة_الخاصه_بالصنفTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "الوحدة الخاصه بالصنف", True))
        Me.الوحدة_الخاصه_بالصنفTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.الوحدة_الخاصه_بالصنفTextBox.Location = New System.Drawing.Point(136, 240)
        Me.الوحدة_الخاصه_بالصنفTextBox.Name = "الوحدة_الخاصه_بالصنفTextBox"
        Me.الوحدة_الخاصه_بالصنفTextBox.Size = New System.Drawing.Size(164, 36)
        Me.الوحدة_الخاصه_بالصنفTextBox.TabIndex = 7
        '
        'حد_الطلبLabel
        '
        حد_الطلبLabel.AutoSize = True
        حد_الطلبLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        حد_الطلبLabel.Location = New System.Drawing.Point(341, 270)
        حد_الطلبLabel.Name = "حد_الطلبLabel"
        حد_الطلبLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        حد_الطلبLabel.Size = New System.Drawing.Size(118, 29)
        حد_الطلبLabel.TabIndex = 8
        حد_الطلبLabel.Text = "حد الطلب:"
        '
        'حد_الطلبTextBox
        '
        Me.حد_الطلبTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "حد الطلب", True))
        Me.حد_الطلبTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.حد_الطلبTextBox.Location = New System.Drawing.Point(136, 270)
        Me.حد_الطلبTextBox.Name = "حد_الطلبTextBox"
        Me.حد_الطلبTextBox.Size = New System.Drawing.Size(164, 36)
        Me.حد_الطلبTextBox.TabIndex = 9
        '
        'الحد_الادنيLabel
        '
        الحد_الادنيLabel.AutoSize = True
        الحد_الادنيLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        الحد_الادنيLabel.Location = New System.Drawing.Point(341, 300)
        الحد_الادنيLabel.Name = "الحد_الادنيLabel"
        الحد_الادنيLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الحد_الادنيLabel.Size = New System.Drawing.Size(134, 29)
        الحد_الادنيLabel.TabIndex = 10
        الحد_الادنيLabel.Text = "الحد الادني:"
        '
        'الحد_الادنيTextBox
        '
        Me.الحد_الادنيTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "الحد الادني", True))
        Me.الحد_الادنيTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.الحد_الادنيTextBox.Location = New System.Drawing.Point(136, 300)
        Me.الحد_الادنيTextBox.Name = "الحد_الادنيTextBox"
        Me.الحد_الادنيTextBox.Size = New System.Drawing.Size(164, 36)
        Me.الحد_الادنيTextBox.TabIndex = 11
        '
        'الحد_الاعليLabel
        '
        الحد_الاعليLabel.AutoSize = True
        الحد_الاعليLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        الحد_الاعليLabel.Location = New System.Drawing.Point(341, 330)
        الحد_الاعليLabel.Name = "الحد_الاعليLabel"
        الحد_الاعليLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الحد_الاعليLabel.Size = New System.Drawing.Size(138, 29)
        الحد_الاعليLabel.TabIndex = 12
        الحد_الاعليLabel.Text = "الحد الاعلي:"
        '
        'الحد_الاعليTextBox
        '
        Me.الحد_الاعليTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "الحد الاعلي", True))
        Me.الحد_الاعليTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.الحد_الاعليTextBox.Location = New System.Drawing.Point(136, 330)
        Me.الحد_الاعليTextBox.Name = "الحد_الاعليTextBox"
        Me.الحد_الاعليTextBox.Size = New System.Drawing.Size(164, 36)
        Me.الحد_الاعليTextBox.TabIndex = 13
        '
        'ملاحظاتLabel
        '
        ملاحظاتLabel.AutoSize = True
        ملاحظاتLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        ملاحظاتLabel.Location = New System.Drawing.Point(341, 360)
        ملاحظاتLabel.Name = "ملاحظاتLabel"
        ملاحظاتLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ملاحظاتLabel.Size = New System.Drawing.Size(109, 29)
        ملاحظاتLabel.TabIndex = 14
        ملاحظاتLabel.Text = "ملاحظات:"
        '
        'ملاحظاتTextBox
        '
        Me.ملاحظاتTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "ملاحظات", True))
        Me.ملاحظاتTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ملاحظاتTextBox.Location = New System.Drawing.Point(136, 360)
        Me.ملاحظاتTextBox.Name = "ملاحظاتTextBox"
        Me.ملاحظاتTextBox.Size = New System.Drawing.Size(164, 36)
        Me.ملاحظاتTextBox.TabIndex = 15
        '
        'رقم_الكتلوجLabel
        '
        رقم_الكتلوجLabel.AutoSize = True
        رقم_الكتلوجLabel.Font = New System.Drawing.Font("Tahoma", 14.0!)
        رقم_الكتلوجLabel.Location = New System.Drawing.Point(341, 390)
        رقم_الكتلوجLabel.Name = "رقم_الكتلوجLabel"
        رقم_الكتلوجLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_الكتلوجLabel.Size = New System.Drawing.Size(132, 29)
        رقم_الكتلوجLabel.TabIndex = 16
        رقم_الكتلوجLabel.Text = "رقم الكتلوج:"
        '
        'رقم_الكتلوجTextBox
        '
        Me.رقم_الكتلوجTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.بطاقة_الصنفBindingSource, "رقم الكتلوج", True))
        Me.رقم_الكتلوجTextBox.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.رقم_الكتلوجTextBox.Location = New System.Drawing.Point(136, 390)
        Me.رقم_الكتلوجTextBox.Name = "رقم_الكتلوجTextBox"
        Me.رقم_الكتلوجTextBox.Size = New System.Drawing.Size(164, 36)
        Me.رقم_الكتلوجTextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(452, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 30)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "بطاقة الصنف"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(رقم_الصنفLabel)
        Me.Controls.Add(Me.رقم_الصنفTextBox)
        Me.Controls.Add(اسم_الصنفLabel)
        Me.Controls.Add(Me.اسم_الصنفTextBox)
        Me.Controls.Add(الوحدة_الخاصه_بالصنفLabel)
        Me.Controls.Add(Me.الوحدة_الخاصه_بالصنفTextBox)
        Me.Controls.Add(حد_الطلبLabel)
        Me.Controls.Add(Me.حد_الطلبTextBox)
        Me.Controls.Add(الحد_الادنيLabel)
        Me.Controls.Add(Me.الحد_الادنيTextBox)
        Me.Controls.Add(الحد_الاعليLabel)
        Me.Controls.Add(Me.الحد_الاعليTextBox)
        Me.Controls.Add(ملاحظاتLabel)
        Me.Controls.Add(Me.ملاحظاتTextBox)
        Me.Controls.Add(رقم_الكتلوجLabel)
        Me.Controls.Add(Me.رقم_الكتلوجTextBox)
        Me.Controls.Add(Me.بطاقة_الصنفBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form7"
        Me.Text = "بطاقة الصنف"
        CType(Me.مخازنDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.بطاقة_الصنفBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.بطاقة_الصنفBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.بطاقة_الصنفBindingNavigator.ResumeLayout(False)
        Me.بطاقة_الصنفBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents مخازنDataSet As مخازنDataSet
    Friend WithEvents بطاقة_الصنفBindingSource As BindingSource
    Friend WithEvents بطاقة_الصنفTableAdapter As مخازنDataSetTableAdapters.بطاقة_الصنفTableAdapter
    Friend WithEvents TableAdapterManager As مخازنDataSetTableAdapters.TableAdapterManager
    Friend WithEvents بطاقة_الصنفBindingNavigator As BindingNavigator
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
    Friend WithEvents بطاقة_الصنفBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents رقم_الصنفTextBox As TextBox
    Friend WithEvents اسم_الصنفTextBox As TextBox
    Friend WithEvents الوحدة_الخاصه_بالصنفTextBox As TextBox
    Friend WithEvents حد_الطلبTextBox As TextBox
    Friend WithEvents الحد_الادنيTextBox As TextBox
    Friend WithEvents الحد_الاعليTextBox As TextBox
    Friend WithEvents ملاحظاتTextBox As TextBox
    Friend WithEvents رقم_الكتلوجTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
