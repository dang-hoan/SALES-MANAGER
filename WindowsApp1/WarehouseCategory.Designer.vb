<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WarehouseCategory
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseCategory))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtNumberOfImport = New System.Windows.Forms.TextBox()
        Me.txtNumberOfExport = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.Warehouse = New LibraryDataset.Warehouse()
        Me.dgvWarehouseSearch = New System.Windows.Forms.DataGridView()
        Me.CheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WareHouseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfImportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfExportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingNav = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox1.SuspendLayout()
        CType(Me.Warehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWarehouseSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(48, 85)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(135, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Warehouse name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(48, 38)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(130, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Warehouse code"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(268, 36)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(433, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "WAREHOUSE CATEGORY"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnExport)
        Me.groupBox1.Controls.Add(Me.btnSearch)
        Me.groupBox1.Controls.Add(Me.txtAddress)
        Me.groupBox1.Controls.Add(Me.txtNumberOfImport)
        Me.groupBox1.Controls.Add(Me.txtNumberOfExport)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.txtCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(70, 89)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(832, 243)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.SandyBrown
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(438, 178)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnExport.Size = New System.Drawing.Size(139, 48)
        Me.btnExport.TabIndex = 27
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(255, 178)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSearch.Size = New System.Drawing.Size(139, 48)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(193, 129)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtAddress.TabIndex = 24
        '
        'txtNumberOfImport
        '
        Me.txtNumberOfImport.Location = New System.Drawing.Point(615, 35)
        Me.txtNumberOfImport.Name = "txtNumberOfImport"
        Me.txtNumberOfImport.Size = New System.Drawing.Size(164, 26)
        Me.txtNumberOfImport.TabIndex = 22
        '
        'txtNumberOfExport
        '
        Me.txtNumberOfExport.Location = New System.Drawing.Point(615, 84)
        Me.txtNumberOfExport.Name = "txtNumberOfExport"
        Me.txtNumberOfExport.Size = New System.Drawing.Size(164, 26)
        Me.txtNumberOfExport.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Number of export"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Number of import"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(193, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(193, 38)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(117, 26)
        Me.txtCode.TabIndex = 2
        '
        'bDelete
        '
        Me.bDelete.BackColor = System.Drawing.Color.SandyBrown
        Me.bDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDelete.Image = CType(resources.GetObject("bDelete.Image"), System.Drawing.Image)
        Me.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDelete.Location = New System.Drawing.Point(518, 755)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(150, 55)
        Me.bDelete.TabIndex = 17
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAdd.Location = New System.Drawing.Point(300, 755)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(150, 55)
        Me.bAdd.TabIndex = 16
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'Warehouse
        '
        Me.Warehouse.DataSetName = "Warehouse"
        Me.Warehouse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvWarehouseSearch
        '
        Me.dgvWarehouseSearch.AllowUserToAddRows = False
        Me.dgvWarehouseSearch.AllowUserToDeleteRows = False
        Me.dgvWarehouseSearch.AutoGenerateColumns = False
        Me.dgvWarehouseSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvWarehouseSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWarehouseSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.WareHouseNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.NumberOfImportDataGridViewTextBoxColumn, Me.NumberOfExportDataGridViewTextBoxColumn})
        Me.dgvWarehouseSearch.DataMember = "WareHouse"
        Me.dgvWarehouseSearch.DataSource = Me.Warehouse
        Me.dgvWarehouseSearch.Location = New System.Drawing.Point(70, 348)
        Me.dgvWarehouseSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvWarehouseSearch.Name = "dgvWarehouseSearch"
        Me.dgvWarehouseSearch.ReadOnly = True
        Me.dgvWarehouseSearch.RowHeadersVisible = False
        Me.dgvWarehouseSearch.RowHeadersWidth = 62
        Me.dgvWarehouseSearch.RowTemplate.Height = 33
        Me.dgvWarehouseSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWarehouseSearch.Size = New System.Drawing.Size(832, 349)
        Me.dgvWarehouseSearch.TabIndex = 20
        '
        'CheckBoxColumn
        '
        Me.CheckBoxColumn.HeaderText = ""
        Me.CheckBoxColumn.MinimumWidth = 8
        Me.CheckBoxColumn.Name = "CheckBoxColumn"
        Me.CheckBoxColumn.ReadOnly = True
        Me.CheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CheckBoxColumn.Width = 48
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'WareHouseNameDataGridViewTextBoxColumn
        '
        Me.WareHouseNameDataGridViewTextBoxColumn.DataPropertyName = "WareHouseName"
        Me.WareHouseNameDataGridViewTextBoxColumn.HeaderText = "Warehouse name"
        Me.WareHouseNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WareHouseNameDataGridViewTextBoxColumn.Name = "WareHouseNameDataGridViewTextBoxColumn"
        Me.WareHouseNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.WareHouseNameDataGridViewTextBoxColumn.Width = 150
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 150
        '
        'NumberOfImportDataGridViewTextBoxColumn
        '
        Me.NumberOfImportDataGridViewTextBoxColumn.DataPropertyName = "NumberOfImport"
        Me.NumberOfImportDataGridViewTextBoxColumn.HeaderText = "Number of import"
        Me.NumberOfImportDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NumberOfImportDataGridViewTextBoxColumn.Name = "NumberOfImportDataGridViewTextBoxColumn"
        Me.NumberOfImportDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberOfImportDataGridViewTextBoxColumn.Width = 150
        '
        'NumberOfExportDataGridViewTextBoxColumn
        '
        Me.NumberOfExportDataGridViewTextBoxColumn.DataPropertyName = "NumberOfExport"
        Me.NumberOfExportDataGridViewTextBoxColumn.HeaderText = "Number of export"
        Me.NumberOfExportDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NumberOfExportDataGridViewTextBoxColumn.Name = "NumberOfExportDataGridViewTextBoxColumn"
        Me.NumberOfExportDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberOfExportDataGridViewTextBoxColumn.Width = 150
        '
        'bindingNav
        '
        Me.bindingNav.AddNewItem = Nothing
        Me.bindingNav.AutoSize = False
        Me.bindingNav.CountItem = Me.BindingNavigatorCountItem
        Me.bindingNav.DeleteItem = Nothing
        Me.bindingNav.Dock = System.Windows.Forms.DockStyle.None
        Me.bindingNav.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.bindingNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.bindingNav.Location = New System.Drawing.Point(319, 699)
        Me.bindingNav.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bindingNav.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bindingNav.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bindingNav.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bindingNav.Name = "bindingNav"
        Me.bindingNav.PositionItem = Me.BindingNavigatorPositionItem
        Me.bindingNav.Size = New System.Drawing.Size(331, 31)
        Me.bindingNav.TabIndex = 34
        Me.bindingNav.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'WarehouseCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 840)
        Me.Controls.Add(Me.bindingNav)
        Me.Controls.Add(Me.dgvWarehouseSearch)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label7)
        Me.Name = "WarehouseCategory"
        Me.Text = "Product Category"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.Warehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWarehouseSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNav.ResumeLayout(False)
        Me.bindingNav.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtName As System.Windows.Forms.TextBox
    Private txtCode As System.Windows.Forms.TextBox
    Private WithEvents bDelete As Button
    Private WithEvents bAdd As Button
    Private WithEvents Label8 As Label
    Private WithEvents txtNumberOfExport As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Private WithEvents txtNumberOfImport As TextBox
    Private WithEvents txtAddress As TextBox
    Friend WithEvents Warehouse As LibraryDataset.Warehouse
    Private WithEvents btnExport As Button
    Private WithEvents btnSearch As Button
    Friend WithEvents dgvWarehouseSearch As DataGridView
    Friend WithEvents bindingNav As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WareHouseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfImportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfExportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
