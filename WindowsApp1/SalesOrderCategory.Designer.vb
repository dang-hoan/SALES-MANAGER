<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesOrderCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesOrderCategory))
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPaymentMethod = New System.Windows.Forms.CheckBox()
        Me.cbbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.cbShipDate = New System.Windows.Forms.CheckBox()
        Me.cbOrderDate = New System.Windows.Forms.CheckBox()
        Me.cbShipper = New System.Windows.Forms.CheckBox()
        Me.cbShipStatus = New System.Windows.Forms.CheckBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbbShipper = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.dtOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.cbbShipStatus = New System.Windows.Forms.ComboBox()
        Me.dtShipDate = New System.Windows.Forms.DateTimePicker()
        Me.txtShipAddress = New System.Windows.Forms.TextBox()
        Me.txtOrderCode = New System.Windows.Forms.TextBox()
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
        Me.dgvSalesOrderSearch = New System.Windows.Forms.DataGridView()
        Me.OrderDetail = New LibraryDataset.OrderDetail()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OrderIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrivateDiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipperNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipperIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDeleteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.groupBox1.SuspendLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNav.SuspendLayout()
        CType(Me.dgvSalesOrderSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.White
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(28, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Order code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.White
        Me.label3.ForeColor = System.Drawing.Color.Blue
        Me.label3.Location = New System.Drawing.Point(453, 133)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Ship address"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.White
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(453, 88)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(77, 20)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Ship date"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.White
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(28, 88)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(122, 20)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Customer name"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.White
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(453, 174)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(89, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Ship status"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(367, 31)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(253, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "SALES ORDER"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbPaymentMethod)
        Me.groupBox1.Controls.Add(Me.cbbPaymentMethod)
        Me.groupBox1.Controls.Add(Me.cbShipDate)
        Me.groupBox1.Controls.Add(Me.cbOrderDate)
        Me.groupBox1.Controls.Add(Me.cbShipper)
        Me.groupBox1.Controls.Add(Me.cbShipStatus)
        Me.groupBox1.Controls.Add(Me.btnExport)
        Me.groupBox1.Controls.Add(Me.btnSearch)
        Me.groupBox1.Controls.Add(Me.Label12)
        Me.groupBox1.Controls.Add(Me.cbbShipper)
        Me.groupBox1.Controls.Add(Me.label15)
        Me.groupBox1.Controls.Add(Me.dtOrderDate)
        Me.groupBox1.Controls.Add(Me.label14)
        Me.groupBox1.Controls.Add(Me.txtCustomerName)
        Me.groupBox1.Controls.Add(Me.cbbShipStatus)
        Me.groupBox1.Controls.Add(Me.dtShipDate)
        Me.groupBox1.Controls.Add(Me.txtShipAddress)
        Me.groupBox1.Controls.Add(Me.txtOrderCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Location = New System.Drawing.Point(54, 97)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(853, 291)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail order"
        '
        'cbPaymentMethod
        '
        Me.cbPaymentMethod.AutoSize = True
        Me.cbPaymentMethod.Location = New System.Drawing.Point(6, 173)
        Me.cbPaymentMethod.Name = "cbPaymentMethod"
        Me.cbPaymentMethod.Size = New System.Drawing.Size(22, 21)
        Me.cbPaymentMethod.TabIndex = 39
        Me.cbPaymentMethod.UseVisualStyleBackColor = True
        '
        'cbbPaymentMethod
        '
        Me.cbbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPaymentMethod.Enabled = False
        Me.cbbPaymentMethod.FormattingEnabled = True
        Me.cbbPaymentMethod.Location = New System.Drawing.Point(164, 171)
        Me.cbbPaymentMethod.Name = "cbbPaymentMethod"
        Me.cbbPaymentMethod.Size = New System.Drawing.Size(233, 28)
        Me.cbbPaymentMethod.TabIndex = 38
        '
        'cbShipDate
        '
        Me.cbShipDate.AutoSize = True
        Me.cbShipDate.Location = New System.Drawing.Point(425, 87)
        Me.cbShipDate.Name = "cbShipDate"
        Me.cbShipDate.Size = New System.Drawing.Size(22, 21)
        Me.cbShipDate.TabIndex = 37
        Me.cbShipDate.UseVisualStyleBackColor = True
        '
        'cbOrderDate
        '
        Me.cbOrderDate.AutoSize = True
        Me.cbOrderDate.Location = New System.Drawing.Point(425, 41)
        Me.cbOrderDate.Name = "cbOrderDate"
        Me.cbOrderDate.Size = New System.Drawing.Size(22, 21)
        Me.cbOrderDate.TabIndex = 36
        Me.cbOrderDate.UseVisualStyleBackColor = True
        '
        'cbShipper
        '
        Me.cbShipper.AutoSize = True
        Me.cbShipper.Location = New System.Drawing.Point(6, 131)
        Me.cbShipper.Name = "cbShipper"
        Me.cbShipper.Size = New System.Drawing.Size(22, 21)
        Me.cbShipper.TabIndex = 35
        Me.cbShipper.UseVisualStyleBackColor = True
        '
        'cbShipStatus
        '
        Me.cbShipStatus.AutoSize = True
        Me.cbShipStatus.Location = New System.Drawing.Point(425, 174)
        Me.cbShipStatus.Name = "cbShipStatus"
        Me.cbShipStatus.Size = New System.Drawing.Size(22, 21)
        Me.cbShipStatus.TabIndex = 34
        Me.cbShipStatus.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.SandyBrown
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(448, 222)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnExport.Size = New System.Drawing.Size(139, 48)
        Me.btnExport.TabIndex = 25
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
        Me.btnSearch.Location = New System.Drawing.Point(265, 222)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSearch.Size = New System.Drawing.Size(139, 48)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(28, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Payment method"
        '
        'cbbShipper
        '
        Me.cbbShipper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbShipper.Enabled = False
        Me.cbbShipper.FormattingEnabled = True
        Me.cbbShipper.Location = New System.Drawing.Point(164, 130)
        Me.cbbShipper.Name = "cbbShipper"
        Me.cbbShipper.Size = New System.Drawing.Size(233, 28)
        Me.cbbShipper.TabIndex = 21
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.BackColor = System.Drawing.Color.White
        Me.label15.ForeColor = System.Drawing.Color.Blue
        Me.label15.Location = New System.Drawing.Point(28, 130)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(64, 20)
        Me.label15.TabIndex = 20
        Me.label15.Text = "Shipper"
        '
        'dtOrderDate
        '
        Me.dtOrderDate.CustomFormat = "dd/MM/yyyy"
        Me.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtOrderDate.Location = New System.Drawing.Point(586, 40)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(233, 26)
        Me.dtOrderDate.TabIndex = 19
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.Color.White
        Me.label14.ForeColor = System.Drawing.Color.Blue
        Me.label14.Location = New System.Drawing.Point(453, 42)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(85, 20)
        Me.label14.TabIndex = 18
        Me.label14.Text = "Order date"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(164, 85)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(233, 26)
        Me.txtCustomerName.TabIndex = 17
        '
        'cbbShipStatus
        '
        Me.cbbShipStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbShipStatus.FormattingEnabled = True
        Me.cbbShipStatus.Location = New System.Drawing.Point(586, 173)
        Me.cbbShipStatus.Name = "cbbShipStatus"
        Me.cbbShipStatus.Size = New System.Drawing.Size(233, 28)
        Me.cbbShipStatus.TabIndex = 16
        '
        'dtShipDate
        '
        Me.dtShipDate.CustomFormat = "dd/MM/yyyy"
        Me.dtShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtShipDate.Location = New System.Drawing.Point(586, 85)
        Me.dtShipDate.Name = "dtShipDate"
        Me.dtShipDate.Size = New System.Drawing.Size(233, 26)
        Me.dtShipDate.TabIndex = 15
        '
        'txtShipAddress
        '
        Me.txtShipAddress.Location = New System.Drawing.Point(586, 130)
        Me.txtShipAddress.Name = "txtShipAddress"
        Me.txtShipAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtShipAddress.TabIndex = 8
        '
        'txtOrderCode
        '
        Me.txtOrderCode.Location = New System.Drawing.Point(164, 39)
        Me.txtOrderCode.Name = "txtOrderCode"
        Me.txtOrderCode.Size = New System.Drawing.Size(150, 26)
        Me.txtOrderCode.TabIndex = 2
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
        Me.bindingNav.TabIndex = 31
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
        Me.bDelete.Location = New System.Drawing.Point(506, 763)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(150, 55)
        Me.bDelete.TabIndex = 33
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAdd.Location = New System.Drawing.Point(312, 763)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(150, 55)
        Me.bAdd.TabIndex = 32
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'dgvSalesOrderSearch
        '
        Me.dgvSalesOrderSearch.AllowUserToAddRows = False
        Me.dgvSalesOrderSearch.AllowUserToDeleteRows = False
        Me.dgvSalesOrderSearch.AutoGenerateColumns = False
        Me.dgvSalesOrderSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalesOrderSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesOrderSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBoxColumn, Me.OrderIdDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.OrderDateDataGridViewTextBoxColumn, Me.ShipDateDataGridViewTextBoxColumn, Me.ShipAddressDataGridViewTextBoxColumn, Me.ShipPriceDataGridViewTextBoxColumn, Me.PrivateDiscountDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn, Me.PaymentMethodNameDataGridViewTextBoxColumn, Me.ShipperNameDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.StatusNameDataGridViewTextBoxColumn, Me.ShipperIdDataGridViewTextBoxColumn, Me.StatusIdDataGridViewTextBoxColumn, Me.PaymentMethodIdDataGridViewTextBoxColumn, Me.IsDeleteDataGridViewCheckBoxColumn})
        Me.dgvSalesOrderSearch.DataMember = "SalesOrderView"
        Me.dgvSalesOrderSearch.DataSource = Me.OrderDetail
        Me.dgvSalesOrderSearch.Location = New System.Drawing.Point(54, 408)
        Me.dgvSalesOrderSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSalesOrderSearch.Name = "dgvSalesOrderSearch"
        Me.dgvSalesOrderSearch.ReadOnly = True
        Me.dgvSalesOrderSearch.RowHeadersVisible = False
        Me.dgvSalesOrderSearch.RowHeadersWidth = 62
        Me.dgvSalesOrderSearch.RowTemplate.Height = 33
        Me.dgvSalesOrderSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesOrderSearch.Size = New System.Drawing.Size(853, 302)
        Me.dgvSalesOrderSearch.TabIndex = 9
        '
        'OrderDetail
        '
        Me.OrderDetail.DataSetName = "OrderDetail"
        Me.OrderDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 48
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Order code"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustomerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "OrderDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Order date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ShipDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ship date"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ShipAddress"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ship address"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ShipPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ship price"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TotalPrice"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total price"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PrivateDiscount"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Private discount"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PaymentMethodName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PaymentMethodName"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ShipperName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ShipperName"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "StatusName"
        Me.DataGridViewTextBoxColumn12.HeaderText = "StatusName"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PaymentMethodId"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PaymentMethodId"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "StatusId"
        Me.DataGridViewTextBoxColumn14.HeaderText = "StatusId"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ShipperId"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ShipperId"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 150
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
        'OrderIdDataGridViewTextBoxColumn
        '
        Me.OrderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId"
        Me.OrderIdDataGridViewTextBoxColumn.HeaderText = "Order code"
        Me.OrderIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.OrderIdDataGridViewTextBoxColumn.Name = "OrderIdDataGridViewTextBoxColumn"
        Me.OrderIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderIdDataGridViewTextBoxColumn.Width = 150
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer name"
        Me.CustomerNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 150
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "Order date"
        Me.OrderDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        Me.OrderDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderDateDataGridViewTextBoxColumn.Width = 150
        '
        'ShipDateDataGridViewTextBoxColumn
        '
        Me.ShipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate"
        Me.ShipDateDataGridViewTextBoxColumn.HeaderText = "Ship date"
        Me.ShipDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ShipDateDataGridViewTextBoxColumn.Name = "ShipDateDataGridViewTextBoxColumn"
        Me.ShipDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShipDateDataGridViewTextBoxColumn.Width = 150
        '
        'ShipAddressDataGridViewTextBoxColumn
        '
        Me.ShipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress"
        Me.ShipAddressDataGridViewTextBoxColumn.HeaderText = "Ship address"
        Me.ShipAddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ShipAddressDataGridViewTextBoxColumn.Name = "ShipAddressDataGridViewTextBoxColumn"
        Me.ShipAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShipAddressDataGridViewTextBoxColumn.Width = 150
        '
        'ShipPriceDataGridViewTextBoxColumn
        '
        Me.ShipPriceDataGridViewTextBoxColumn.DataPropertyName = "ShipPrice"
        Me.ShipPriceDataGridViewTextBoxColumn.HeaderText = "Ship fee"
        Me.ShipPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ShipPriceDataGridViewTextBoxColumn.Name = "ShipPriceDataGridViewTextBoxColumn"
        Me.ShipPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShipPriceDataGridViewTextBoxColumn.Width = 150
        '
        'PrivateDiscountDataGridViewTextBoxColumn
        '
        Me.PrivateDiscountDataGridViewTextBoxColumn.DataPropertyName = "PrivateDiscount"
        Me.PrivateDiscountDataGridViewTextBoxColumn.HeaderText = "Private discount"
        Me.PrivateDiscountDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrivateDiscountDataGridViewTextBoxColumn.Name = "PrivateDiscountDataGridViewTextBoxColumn"
        Me.PrivateDiscountDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrivateDiscountDataGridViewTextBoxColumn.Width = 150
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "Total price"
        Me.TotalPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalPriceDataGridViewTextBoxColumn.Width = 150
        '
        'PaymentMethodNameDataGridViewTextBoxColumn
        '
        Me.PaymentMethodNameDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethodName"
        Me.PaymentMethodNameDataGridViewTextBoxColumn.HeaderText = "Payment method"
        Me.PaymentMethodNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PaymentMethodNameDataGridViewTextBoxColumn.Name = "PaymentMethodNameDataGridViewTextBoxColumn"
        Me.PaymentMethodNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentMethodNameDataGridViewTextBoxColumn.Width = 150
        '
        'ShipperNameDataGridViewTextBoxColumn
        '
        Me.ShipperNameDataGridViewTextBoxColumn.DataPropertyName = "ShipperName"
        Me.ShipperNameDataGridViewTextBoxColumn.HeaderText = "Shipper"
        Me.ShipperNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ShipperNameDataGridViewTextBoxColumn.Name = "ShipperNameDataGridViewTextBoxColumn"
        Me.ShipperNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShipperNameDataGridViewTextBoxColumn.Width = 150
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoteDataGridViewTextBoxColumn.Width = 150
        '
        'StatusNameDataGridViewTextBoxColumn
        '
        Me.StatusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName"
        Me.StatusNameDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StatusNameDataGridViewTextBoxColumn.Name = "StatusNameDataGridViewTextBoxColumn"
        Me.StatusNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusNameDataGridViewTextBoxColumn.Width = 150
        '
        'ShipperIdDataGridViewTextBoxColumn
        '
        Me.ShipperIdDataGridViewTextBoxColumn.DataPropertyName = "ShipperId"
        Me.ShipperIdDataGridViewTextBoxColumn.HeaderText = "ShipperId"
        Me.ShipperIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ShipperIdDataGridViewTextBoxColumn.Name = "ShipperIdDataGridViewTextBoxColumn"
        Me.ShipperIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShipperIdDataGridViewTextBoxColumn.Visible = False
        Me.ShipperIdDataGridViewTextBoxColumn.Width = 150
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
        'PaymentMethodIdDataGridViewTextBoxColumn
        '
        Me.PaymentMethodIdDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethodId"
        Me.PaymentMethodIdDataGridViewTextBoxColumn.HeaderText = "PaymentMethodId"
        Me.PaymentMethodIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PaymentMethodIdDataGridViewTextBoxColumn.Name = "PaymentMethodIdDataGridViewTextBoxColumn"
        Me.PaymentMethodIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentMethodIdDataGridViewTextBoxColumn.Visible = False
        Me.PaymentMethodIdDataGridViewTextBoxColumn.Width = 150
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
        'SalesOrderCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 840)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.bindingNav)
        Me.Controls.Add(Me.dgvSalesOrderSearch)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label7)
        Me.Name = "SalesOrderCategory"
        Me.Text = "Sales Order"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNav.ResumeLayout(False)
        Me.bindingNav.PerformLayout()
        CType(Me.dgvSalesOrderSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtShipAddress As System.Windows.Forms.TextBox
    Private txtOrderCode As System.Windows.Forms.TextBox
    Private WithEvents cbbShipper As System.Windows.Forms.ComboBox
    Private label15 As System.Windows.Forms.Label
    Private dtOrderDate As System.Windows.Forms.DateTimePicker
    Private label14 As System.Windows.Forms.Label
    Private txtCustomerName As System.Windows.Forms.TextBox
    Private WithEvents cbbShipStatus As System.Windows.Forms.ComboBox
    Private dtShipDate As System.Windows.Forms.DateTimePicker
    Private WithEvents Label12 As Label
    Private WithEvents btnExport As Button
    Private WithEvents btnSearch As Button
    Friend WithEvents dgvSalesOrderSearch As DataGridView
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
    Friend WithEvents OrderDetail As LibraryDataset.OrderDetail
    Friend WithEvents NumberOfProductsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceOfProductsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbShipStatus As CheckBox
    Friend WithEvents cbShipDate As CheckBox
    Friend WithEvents cbOrderDate As CheckBox
    Friend WithEvents cbShipper As CheckBox
    Private WithEvents cbbPaymentMethod As ComboBox
    Friend WithEvents cbPaymentMethod As CheckBox
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents OrderIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrivateDiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipperNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipperIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsDeleteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
