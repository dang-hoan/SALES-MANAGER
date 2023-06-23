<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierCategory
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

    Private components As System.ComponentModel.IContainer = Nothing

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierCategory))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.bExport = New System.Windows.Forms.Button()
        Me.bSearch = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWebpage = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.ds_Supplier = New LibraryDataset.Supplier()
        Me.dgvSupplierSearch = New System.Windows.Forms.DataGridView()
        Me.CheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebpageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBox1.SuspendLayout()
        CType(Me.ds_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSupplierSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(30, 78)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(120, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Company name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(30, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(106, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Supplier code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Blue
        Me.label3.Location = New System.Drawing.Point(486, 158)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(78, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Webpage"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(486, 75)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 20)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Phone"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(486, 115)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(68, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Address"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(295, 36)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(378, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "SUPPLIER CATEGORY"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.bExport)
        Me.groupBox1.Controls.Add(Me.bSearch)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtDescription)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.txtWebpage)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.txtAddress)
        Me.groupBox1.Controls.Add(Me.txtPhone)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.txtCode)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Location = New System.Drawing.Point(54, 97)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(853, 269)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Search information"
        '
        'bExport
        '
        Me.bExport.BackColor = System.Drawing.Color.SandyBrown
        Me.bExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExport.Image = CType(resources.GetObject("bExport.Image"), System.Drawing.Image)
        Me.bExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bExport.Location = New System.Drawing.Point(448, 202)
        Me.bExport.Name = "bExport"
        Me.bExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bExport.Size = New System.Drawing.Size(139, 48)
        Me.bExport.TabIndex = 25
        Me.bExport.Text = "Export"
        Me.bExport.UseVisualStyleBackColor = False
        '
        'bSearch
        '
        Me.bSearch.BackColor = System.Drawing.Color.SandyBrown
        Me.bSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSearch.Image = CType(resources.GetObject("bSearch.Image"), System.Drawing.Image)
        Me.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSearch.Location = New System.Drawing.Point(265, 202)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bSearch.Size = New System.Drawing.Size(139, 48)
        Me.bSearch.TabIndex = 24
        Me.bSearch.Text = "Search"
        Me.bSearch.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(166, 112)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(279, 72)
        Me.txtDescription.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(30, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Description"
        '
        'txtWebpage
        '
        Me.txtWebpage.Location = New System.Drawing.Point(576, 155)
        Me.txtWebpage.Name = "txtWebpage"
        Me.txtWebpage.Size = New System.Drawing.Size(233, 26)
        Me.txtWebpage.TabIndex = 17
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(574, 34)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(233, 26)
        Me.txtEmail.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(486, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Email"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(574, 115)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtAddress.TabIndex = 0
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(576, 72)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(233, 26)
        Me.txtPhone.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(166, 75)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(166, 34)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(103, 26)
        Me.txtCode.TabIndex = 2
        '
        'ds_Supplier
        '
        Me.ds_Supplier.DataSetName = "Supplier"
        Me.ds_Supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvSupplierSearch
        '
        Me.dgvSupplierSearch.AllowUserToAddRows = False
        Me.dgvSupplierSearch.AllowUserToDeleteRows = False
        Me.dgvSupplierSearch.AutoGenerateColumns = False
        Me.dgvSupplierSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvSupplierSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplierSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.WebpageDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.dgvSupplierSearch.DataMember = "Supplier"
        Me.dgvSupplierSearch.DataSource = Me.ds_Supplier
        Me.dgvSupplierSearch.Location = New System.Drawing.Point(54, 383)
        Me.dgvSupplierSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSupplierSearch.Name = "dgvSupplierSearch"
        Me.dgvSupplierSearch.ReadOnly = True
        Me.dgvSupplierSearch.RowHeadersVisible = False
        Me.dgvSupplierSearch.RowHeadersWidth = 62
        Me.dgvSupplierSearch.RowTemplate.Height = 33
        Me.dgvSupplierSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplierSearch.Size = New System.Drawing.Size(853, 327)
        Me.dgvSupplierSearch.TabIndex = 9
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
        Me.IdDataGridViewTextBoxColumn.Width = 120
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "Company name"
        Me.CompanyNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        Me.CompanyNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanyNameDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'WebpageDataGridViewTextBoxColumn
        '
        Me.WebpageDataGridViewTextBoxColumn.DataPropertyName = "Webpage"
        Me.WebpageDataGridViewTextBoxColumn.HeaderText = "Webpage"
        Me.WebpageDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WebpageDataGridViewTextBoxColumn.Name = "WebpageDataGridViewTextBoxColumn"
        Me.WebpageDataGridViewTextBoxColumn.ReadOnly = True
        Me.WebpageDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 150
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
        Me.bindingNav.Location = New System.Drawing.Point(319, 712)
        Me.bindingNav.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bindingNav.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bindingNav.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bindingNav.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bindingNav.Name = "bindingNav"
        Me.bindingNav.PositionItem = Me.BindingNavigatorPositionItem
        Me.bindingNav.Size = New System.Drawing.Size(331, 31)
        Me.bindingNav.TabIndex = 33
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
        'bDelete
        '
        Me.bDelete.BackColor = System.Drawing.Color.SandyBrown
        Me.bDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDelete.Image = CType(resources.GetObject("bDelete.Image"), System.Drawing.Image)
        Me.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDelete.Location = New System.Drawing.Point(506, 760)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(150, 55)
        Me.bDelete.TabIndex = 32
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAdd.Location = New System.Drawing.Point(312, 760)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(150, 55)
        Me.bAdd.TabIndex = 31
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 48
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Webpage"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Webpage"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'SupplierCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 840)
        Me.Controls.Add(Me.bindingNav)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.dgvSupplierSearch)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SupplierCategory"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.ds_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSupplierSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNav.ResumeLayout(False)
        Me.bindingNav.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtAddress As System.Windows.Forms.TextBox
    Private txtPhone As System.Windows.Forms.TextBox
    Private txtName As System.Windows.Forms.TextBox
    Private txtCode As System.Windows.Forms.TextBox
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents txtEmail As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents txtWebpage As TextBox
    Private WithEvents txtDescription As TextBox
    Private WithEvents Label4 As Label
    Friend WithEvents ds_Supplier As LibraryDataset.Supplier
    Private WithEvents bExport As Button
    Private WithEvents bSearch As Button
    Friend WithEvents dgvSupplierSearch As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
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
    Private WithEvents bDelete As Button
    Private WithEvents bAdd As Button
    Friend WithEvents CheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents WebpageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
