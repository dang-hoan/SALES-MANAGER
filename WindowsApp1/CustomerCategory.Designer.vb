<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerCategory))
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbGender = New System.Windows.Forms.CheckBox()
        Me.cbBirthDay = New System.Windows.Forms.CheckBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtBirthDay = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
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
        Me.Person = New LibraryDataset.Person()
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView()
        Me.CheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDeleteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeleteDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeleteByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNav.SuspendLayout()
        CType(Me.Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(284, 36)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(404, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "CUSTOMER CATEGORY"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbGender)
        Me.groupBox1.Controls.Add(Me.cbBirthDay)
        Me.groupBox1.Controls.Add(Me.btnExport)
        Me.groupBox1.Controls.Add(Me.btnSearch)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.dtBirthDay)
        Me.groupBox1.Controls.Add(Me.txtAddress)
        Me.groupBox1.Controls.Add(Me.txtPhone)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.txtCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.GroupBox2)
        Me.groupBox1.Location = New System.Drawing.Point(54, 90)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(853, 287)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Search information"
        '
        'cbGender
        '
        Me.cbGender.AutoSize = True
        Me.cbGender.Location = New System.Drawing.Point(27, 124)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(22, 21)
        Me.cbGender.TabIndex = 32
        Me.cbGender.UseVisualStyleBackColor = True
        '
        'cbBirthDay
        '
        Me.cbBirthDay.AutoSize = True
        Me.cbBirthDay.Location = New System.Drawing.Point(464, 76)
        Me.cbBirthDay.Name = "cbBirthDay"
        Me.cbBirthDay.Size = New System.Drawing.Size(22, 21)
        Me.cbBirthDay.TabIndex = 30
        Me.cbBirthDay.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.SandyBrown
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(448, 218)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnExport.Size = New System.Drawing.Size(139, 48)
        Me.btnExport.TabIndex = 29
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
        Me.btnSearch.Location = New System.Drawing.Point(265, 218)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSearch.Size = New System.Drawing.Size(139, 48)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(590, 28)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(233, 26)
        Me.txtEmail.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(489, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Email"
        '
        'dtBirthDay
        '
        Me.dtBirthDay.CustomFormat = "dd/MM/yyyy"
        Me.dtBirthDay.Enabled = False
        Me.dtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBirthDay.Location = New System.Drawing.Point(592, 74)
        Me.dtBirthDay.Name = "dtBirthDay"
        Me.dtBirthDay.Size = New System.Drawing.Size(233, 26)
        Me.dtBirthDay.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(590, 168)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtAddress.TabIndex = 0
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(590, 122)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(233, 26)
        Me.txtPhone.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(184, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(184, 31)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(121, 26)
        Me.txtCode.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(51, 31)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(117, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Customer code"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(51, 74)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Customer name"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(51, 124)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(63, 20)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Gender"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(489, 171)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(68, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Address"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Blue
        Me.label3.Location = New System.Drawing.Point(487, 77)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(70, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "BirthDay"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(489, 122)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 20)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Phone"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdFemale)
        Me.GroupBox2.Controls.Add(Me.rdMale)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 50)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Enabled = False
        Me.rdFemale.ForeColor = System.Drawing.Color.Blue
        Me.rdFemale.Location = New System.Drawing.Point(126, 17)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(87, 24)
        Me.rdFemale.TabIndex = 11
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Enabled = False
        Me.rdMale.ForeColor = System.Drawing.Color.Blue
        Me.rdMale.Location = New System.Drawing.Point(17, 17)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(68, 24)
        Me.rdMale.TabIndex = 10
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'bDelete
        '
        Me.bDelete.BackColor = System.Drawing.Color.SandyBrown
        Me.bDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDelete.Image = CType(resources.GetObject("bDelete.Image"), System.Drawing.Image)
        Me.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDelete.Location = New System.Drawing.Point(521, 762)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(150, 55)
        Me.bDelete.TabIndex = 37
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAdd.Location = New System.Drawing.Point(297, 762)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(150, 55)
        Me.bAdd.TabIndex = 36
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
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
        Me.bindingNav.Location = New System.Drawing.Point(319, 709)
        Me.bindingNav.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bindingNav.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bindingNav.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bindingNav.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bindingNav.Name = "bindingNav"
        Me.bindingNav.PositionItem = Me.BindingNavigatorPositionItem
        Me.bindingNav.Size = New System.Drawing.Size(331, 31)
        Me.bindingNav.TabIndex = 39
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
        'Person
        '
        Me.Person.DataSetName = "Person"
        Me.Person.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.AllowUserToAddRows = False
        Me.dgvCustomerSearch.AllowUserToDeleteRows = False
        Me.dgvCustomerSearch.AutoGenerateColumns = False
        Me.dgvCustomerSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBoxColumn, Me.IdColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.BirthDate, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.GenderNameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.RoleNameDataGridViewTextBoxColumn, Me.RoleIdDataGridViewTextBoxColumn, Me.IsDeleteDataGridViewCheckBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.StatusIdDataGridViewTextBoxColumn, Me.CreateDateDataGridViewTextBoxColumn, Me.CreateByDataGridViewTextBoxColumn, Me.UpdateDateDataGridViewTextBoxColumn, Me.UpdateByDataGridViewTextBoxColumn, Me.DeleteDateDataGridViewTextBoxColumn, Me.DeleteByDataGridViewTextBoxColumn, Me.DataGridViewCheckBoxColumn1})
        Me.dgvCustomerSearch.DataMember = "PersonView"
        Me.dgvCustomerSearch.DataSource = Me.Person
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(54, 391)
        Me.dgvCustomerSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.ReadOnly = True
        Me.dgvCustomerSearch.RowHeadersVisible = False
        Me.dgvCustomerSearch.RowHeadersWidth = 62
        Me.dgvCustomerSearch.RowTemplate.Height = 33
        Me.dgvCustomerSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(853, 316)
        Me.dgvCustomerSearch.TabIndex = 40
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
        'IdColumn
        '
        Me.IdColumn.DataPropertyName = "Id"
        Me.IdColumn.HeaderText = "Id"
        Me.IdColumn.MinimumWidth = 8
        Me.IdColumn.Name = "IdColumn"
        Me.IdColumn.ReadOnly = True
        Me.IdColumn.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'BirthDate
        '
        Me.BirthDate.DataPropertyName = "BirthDate"
        Me.BirthDate.HeaderText = "Birthday"
        Me.BirthDate.MinimumWidth = 8
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.ReadOnly = True
        Me.BirthDate.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'GenderNameDataGridViewTextBoxColumn
        '
        Me.GenderNameDataGridViewTextBoxColumn.DataPropertyName = "GenderName"
        Me.GenderNameDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenderNameDataGridViewTextBoxColumn.Name = "GenderNameDataGridViewTextBoxColumn"
        Me.GenderNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderNameDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'RoleNameDataGridViewTextBoxColumn
        '
        Me.RoleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName"
        Me.RoleNameDataGridViewTextBoxColumn.HeaderText = "Role name"
        Me.RoleNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RoleNameDataGridViewTextBoxColumn.Name = "RoleNameDataGridViewTextBoxColumn"
        Me.RoleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoleNameDataGridViewTextBoxColumn.Visible = False
        Me.RoleNameDataGridViewTextBoxColumn.Width = 150
        '
        'RoleIdDataGridViewTextBoxColumn
        '
        Me.RoleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId"
        Me.RoleIdDataGridViewTextBoxColumn.HeaderText = "RoleId"
        Me.RoleIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RoleIdDataGridViewTextBoxColumn.Name = "RoleIdDataGridViewTextBoxColumn"
        Me.RoleIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoleIdDataGridViewTextBoxColumn.Visible = False
        Me.RoleIdDataGridViewTextBoxColumn.Width = 150
        '
        'IsDeleteDataGridViewCheckBoxColumn
        '
        Me.IsDeleteDataGridViewCheckBoxColumn.DataPropertyName = "IsDelete"
        Me.IsDeleteDataGridViewCheckBoxColumn.HeaderText = "IsDelete"
        Me.IsDeleteDataGridViewCheckBoxColumn.MinimumWidth = 8
        Me.IsDeleteDataGridViewCheckBoxColumn.Name = "IsDeleteDataGridViewCheckBoxColumn"
        Me.IsDeleteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsDeleteDataGridViewCheckBoxColumn.Visible = False
        Me.IsDeleteDataGridViewCheckBoxColumn.Width = 150
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        Me.PasswordDataGridViewTextBoxColumn.Width = 150
        '
        'StatusIdDataGridViewTextBoxColumn
        '
        Me.StatusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId"
        Me.StatusIdDataGridViewTextBoxColumn.HeaderText = "StatusId"
        Me.StatusIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StatusIdDataGridViewTextBoxColumn.Name = "StatusIdDataGridViewTextBoxColumn"
        Me.StatusIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusIdDataGridViewTextBoxColumn.Visible = False
        Me.StatusIdDataGridViewTextBoxColumn.Width = 150
        '
        'CreateDateDataGridViewTextBoxColumn
        '
        Me.CreateDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate"
        Me.CreateDateDataGridViewTextBoxColumn.HeaderText = "CreateDate"
        Me.CreateDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CreateDateDataGridViewTextBoxColumn.Name = "CreateDateDataGridViewTextBoxColumn"
        Me.CreateDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreateDateDataGridViewTextBoxColumn.Visible = False
        Me.CreateDateDataGridViewTextBoxColumn.Width = 150
        '
        'CreateByDataGridViewTextBoxColumn
        '
        Me.CreateByDataGridViewTextBoxColumn.DataPropertyName = "CreateBy"
        Me.CreateByDataGridViewTextBoxColumn.HeaderText = "CreateBy"
        Me.CreateByDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CreateByDataGridViewTextBoxColumn.Name = "CreateByDataGridViewTextBoxColumn"
        Me.CreateByDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreateByDataGridViewTextBoxColumn.Visible = False
        Me.CreateByDataGridViewTextBoxColumn.Width = 150
        '
        'UpdateDateDataGridViewTextBoxColumn
        '
        Me.UpdateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate"
        Me.UpdateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate"
        Me.UpdateDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UpdateDateDataGridViewTextBoxColumn.Name = "UpdateDateDataGridViewTextBoxColumn"
        Me.UpdateDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.UpdateDateDataGridViewTextBoxColumn.Visible = False
        Me.UpdateDateDataGridViewTextBoxColumn.Width = 150
        '
        'UpdateByDataGridViewTextBoxColumn
        '
        Me.UpdateByDataGridViewTextBoxColumn.DataPropertyName = "UpdateBy"
        Me.UpdateByDataGridViewTextBoxColumn.HeaderText = "UpdateBy"
        Me.UpdateByDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UpdateByDataGridViewTextBoxColumn.Name = "UpdateByDataGridViewTextBoxColumn"
        Me.UpdateByDataGridViewTextBoxColumn.ReadOnly = True
        Me.UpdateByDataGridViewTextBoxColumn.Visible = False
        Me.UpdateByDataGridViewTextBoxColumn.Width = 150
        '
        'DeleteDateDataGridViewTextBoxColumn
        '
        Me.DeleteDateDataGridViewTextBoxColumn.DataPropertyName = "DeleteDate"
        Me.DeleteDateDataGridViewTextBoxColumn.HeaderText = "DeleteDate"
        Me.DeleteDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DeleteDateDataGridViewTextBoxColumn.Name = "DeleteDateDataGridViewTextBoxColumn"
        Me.DeleteDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeleteDateDataGridViewTextBoxColumn.Visible = False
        Me.DeleteDateDataGridViewTextBoxColumn.Width = 150
        '
        'DeleteByDataGridViewTextBoxColumn
        '
        Me.DeleteByDataGridViewTextBoxColumn.DataPropertyName = "DeleteBy"
        Me.DeleteByDataGridViewTextBoxColumn.HeaderText = "DeleteBy"
        Me.DeleteByDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DeleteByDataGridViewTextBoxColumn.Name = "DeleteByDataGridViewTextBoxColumn"
        Me.DeleteByDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeleteByDataGridViewTextBoxColumn.Visible = False
        Me.DeleteByDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Gender"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Gender"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 150
        '
        'CustomerCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 840)
        Me.Controls.Add(Me.dgvCustomerSearch)
        Me.Controls.Add(Me.bindingNav)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerCategory"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNav.ResumeLayout(False)
        Me.bindingNav.PerformLayout()
        CType(Me.Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private label7 As System.Windows.Forms.Label
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents cbGender As CheckBox
    Friend WithEvents cbBirthDay As CheckBox
    Private WithEvents btnExport As Button
    Private WithEvents btnSearch As Button
    Private WithEvents txtEmail As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents dtBirthDay As DateTimePicker
    Private WithEvents txtAddress As TextBox
    Private WithEvents txtPhone As TextBox
    Private WithEvents txtName As TextBox
    Private WithEvents txtCode As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents rdFemale As RadioButton
    Private WithEvents rdMale As RadioButton
    Private WithEvents bDelete As Button
    Private WithEvents bAdd As Button
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
    Friend WithEvents Person As LibraryDataset.Person
    Friend WithEvents dgvCustomerSearch As DataGridView
    Friend WithEvents CheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BirthDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents GenderNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RoleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsDeleteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreateDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreateByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdateDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdateByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeleteDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeleteByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
