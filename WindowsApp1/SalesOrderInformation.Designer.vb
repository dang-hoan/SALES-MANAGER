<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesOrderInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesOrderInformation))
        Me.bSave = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.labTitle = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtShipFee = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotalCosts = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.cbbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
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
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.listBuyProduct = New System.Windows.Forms.DataGridView()
        Me.OrderDetail = New LibraryDataset.OrderDetail()
        Me.labWarning = New System.Windows.Forms.Label()
        Me.txtCosts = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.labRemove = New System.Windows.Forms.Label()
        Me.labUpdate = New System.Windows.Forms.Label()
        Me.pictureAdd = New System.Windows.Forms.PictureBox()
        Me.cbbProduct = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.pictureRemove = New System.Windows.Forms.PictureBox()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfProducts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceOfProducts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNav.SuspendLayout()
        CType(Me.listBuyProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(577, 759)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(139, 48)
        Me.bSave.TabIndex = 5
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bDelete
        '
        Me.bDelete.BackColor = System.Drawing.Color.SandyBrown
        Me.bDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDelete.Image = CType(resources.GetObject("bDelete.Image"), System.Drawing.Image)
        Me.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDelete.Location = New System.Drawing.Point(415, 759)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(139, 48)
        Me.bDelete.TabIndex = 3
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.White
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(31, 31)
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
        Me.label3.Location = New System.Drawing.Point(456, 119)
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
        Me.label4.Location = New System.Drawing.Point(456, 74)
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
        Me.label5.Location = New System.Drawing.Point(31, 74)
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
        Me.label6.Location = New System.Drawing.Point(456, 160)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(89, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Ship status"
        '
        'labTitle
        '
        Me.labTitle.AutoSize = True
        Me.labTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labTitle.ForeColor = System.Drawing.Color.Blue
        Me.labTitle.Location = New System.Drawing.Point(235, 31)
        Me.labTitle.Name = "labTitle"
        Me.labTitle.Size = New System.Drawing.Size(498, 37)
        Me.labTitle.TabIndex = 8
        Me.labTitle.Text = "SALES ORDER INFORMATION"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtShipFee)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.txtDiscount)
        Me.groupBox1.Controls.Add(Me.txtTotalCosts)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.cbbPaymentMethod)
        Me.groupBox1.Controls.Add(Me.label13)
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
        Me.groupBox1.Size = New System.Drawing.Size(853, 288)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail order"
        '
        'txtShipFee
        '
        Me.txtShipFee.Enabled = False
        Me.txtShipFee.Location = New System.Drawing.Point(166, 204)
        Me.txtShipFee.Name = "txtShipFee"
        Me.txtShipFee.Size = New System.Drawing.Size(233, 26)
        Me.txtShipFee.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(31, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Ship fee"
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(589, 204)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(233, 26)
        Me.txtDiscount.TabIndex = 40
        '
        'txtTotalCosts
        '
        Me.txtTotalCosts.Enabled = False
        Me.txtTotalCosts.Location = New System.Drawing.Point(589, 245)
        Me.txtTotalCosts.Name = "txtTotalCosts"
        Me.txtTotalCosts.Size = New System.Drawing.Size(233, 26)
        Me.txtTotalCosts.TabIndex = 42
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.White
        Me.label11.ForeColor = System.Drawing.Color.Blue
        Me.label11.Location = New System.Drawing.Point(458, 207)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(72, 20)
        Me.label11.TabIndex = 43
        Me.label11.Text = "Discount"
        '
        'cbbPaymentMethod
        '
        Me.cbbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPaymentMethod.Enabled = False
        Me.cbbPaymentMethod.FormattingEnabled = True
        Me.cbbPaymentMethod.Location = New System.Drawing.Point(166, 159)
        Me.cbbPaymentMethod.Name = "cbbPaymentMethod"
        Me.cbbPaymentMethod.Size = New System.Drawing.Size(233, 28)
        Me.cbbPaymentMethod.TabIndex = 39
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.BackColor = System.Drawing.Color.White
        Me.label13.ForeColor = System.Drawing.Color.Blue
        Me.label13.Location = New System.Drawing.Point(458, 248)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(86, 20)
        Me.label13.TabIndex = 41
        Me.label13.Text = "Total costs"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(31, 160)
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
        Me.cbbShipper.Location = New System.Drawing.Point(167, 116)
        Me.cbbShipper.Name = "cbbShipper"
        Me.cbbShipper.Size = New System.Drawing.Size(232, 28)
        Me.cbbShipper.TabIndex = 21
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.BackColor = System.Drawing.Color.White
        Me.label15.ForeColor = System.Drawing.Color.Blue
        Me.label15.Location = New System.Drawing.Point(31, 116)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(64, 20)
        Me.label15.TabIndex = 20
        Me.label15.Text = "Shipper"
        '
        'dtOrderDate
        '
        Me.dtOrderDate.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtOrderDate.Location = New System.Drawing.Point(589, 26)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(233, 26)
        Me.dtOrderDate.TabIndex = 19
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.Color.White
        Me.label14.ForeColor = System.Drawing.Color.Blue
        Me.label14.Location = New System.Drawing.Point(456, 28)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(85, 20)
        Me.label14.TabIndex = 18
        Me.label14.Text = "Order date"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(167, 71)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(232, 26)
        Me.txtCustomerName.TabIndex = 17
        '
        'cbbShipStatus
        '
        Me.cbbShipStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbShipStatus.FormattingEnabled = True
        Me.cbbShipStatus.Location = New System.Drawing.Point(589, 159)
        Me.cbbShipStatus.Name = "cbbShipStatus"
        Me.cbbShipStatus.Size = New System.Drawing.Size(233, 28)
        Me.cbbShipStatus.TabIndex = 16
        '
        'dtShipDate
        '
        Me.dtShipDate.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtShipDate.Location = New System.Drawing.Point(589, 71)
        Me.dtShipDate.Name = "dtShipDate"
        Me.dtShipDate.Size = New System.Drawing.Size(233, 26)
        Me.dtShipDate.TabIndex = 15
        '
        'txtShipAddress
        '
        Me.txtShipAddress.Enabled = False
        Me.txtShipAddress.Location = New System.Drawing.Point(589, 116)
        Me.txtShipAddress.Name = "txtShipAddress"
        Me.txtShipAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtShipAddress.TabIndex = 8
        '
        'txtOrderCode
        '
        Me.txtOrderCode.Enabled = False
        Me.txtOrderCode.Location = New System.Drawing.Point(167, 25)
        Me.txtOrderCode.Name = "txtOrderCode"
        Me.txtOrderCode.Size = New System.Drawing.Size(150, 26)
        Me.txtOrderCode.TabIndex = 2
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.bindingNav)
        Me.groupBox2.Controls.Add(Me.listBuyProduct)
        Me.groupBox2.Controls.Add(Me.labWarning)
        Me.groupBox2.Controls.Add(Me.txtCosts)
        Me.groupBox2.Controls.Add(Me.Label16)
        Me.groupBox2.Controls.Add(Me.txtNumber)
        Me.groupBox2.Controls.Add(Me.labRemove)
        Me.groupBox2.Controls.Add(Me.labUpdate)
        Me.groupBox2.Controls.Add(Me.pictureAdd)
        Me.groupBox2.Controls.Add(Me.cbbProduct)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.pictureRemove)
        Me.groupBox2.Location = New System.Drawing.Point(54, 391)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(853, 352)
        Me.groupBox2.TabIndex = 15
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "List products"
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
        Me.bindingNav.Location = New System.Drawing.Point(399, 309)
        Me.bindingNav.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bindingNav.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bindingNav.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bindingNav.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bindingNav.Name = "bindingNav"
        Me.bindingNav.PositionItem = Me.BindingNavigatorPositionItem
        Me.bindingNav.Size = New System.Drawing.Size(331, 31)
        Me.bindingNav.TabIndex = 32
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
        'listBuyProduct
        '
        Me.listBuyProduct.AllowUserToAddRows = False
        Me.listBuyProduct.AllowUserToDeleteRows = False
        Me.listBuyProduct.AutoGenerateColumns = False
        Me.listBuyProduct.BackgroundColor = System.Drawing.Color.White
        Me.listBuyProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listBuyProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBoxColumn, Me.ProductId, Me.ProductNameColumn, Me.NumberOfProducts, Me.TotalPriceOfProducts, Me.StatusName})
        Me.listBuyProduct.DataMember = "OrderDetail"
        Me.listBuyProduct.DataSource = Me.OrderDetail
        Me.listBuyProduct.Location = New System.Drawing.Point(299, 21)
        Me.listBuyProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listBuyProduct.Name = "listBuyProduct"
        Me.listBuyProduct.ReadOnly = True
        Me.listBuyProduct.RowHeadersVisible = False
        Me.listBuyProduct.RowHeadersWidth = 62
        Me.listBuyProduct.RowTemplate.Height = 33
        Me.listBuyProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listBuyProduct.Size = New System.Drawing.Size(537, 286)
        Me.listBuyProduct.TabIndex = 27
        '
        'OrderDetail
        '
        Me.OrderDetail.DataSetName = "OrderDetail"
        Me.OrderDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'labWarning
        '
        Me.labWarning.AutoSize = True
        Me.labWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labWarning.ForeColor = System.Drawing.Color.Red
        Me.labWarning.Location = New System.Drawing.Point(14, 21)
        Me.labWarning.Name = "labWarning"
        Me.labWarning.Size = New System.Drawing.Size(58, 15)
        Me.labWarning.TabIndex = 26
        Me.labWarning.Text = "*Warning"
        '
        'txtCosts
        '
        Me.txtCosts.Enabled = False
        Me.txtCosts.Location = New System.Drawing.Point(94, 126)
        Me.txtCosts.Name = "txtCosts"
        Me.txtCosts.Size = New System.Drawing.Size(89, 26)
        Me.txtCosts.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(23, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 20)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Costs"
        '
        'txtNumber
        '
        Me.txtNumber.Enabled = False
        Me.txtNumber.Location = New System.Drawing.Point(94, 83)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(89, 26)
        Me.txtNumber.TabIndex = 22
        '
        'labRemove
        '
        Me.labRemove.AutoSize = True
        Me.labRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRemove.Location = New System.Drawing.Point(189, 141)
        Me.labRemove.Name = "labRemove"
        Me.labRemove.Size = New System.Drawing.Size(99, 15)
        Me.labRemove.TabIndex = 20
        Me.labRemove.Text = "Remove from list"
        '
        'labUpdate
        '
        Me.labUpdate.AutoSize = True
        Me.labUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labUpdate.Location = New System.Drawing.Point(197, 28)
        Me.labUpdate.Name = "labUpdate"
        Me.labUpdate.Size = New System.Drawing.Size(88, 15)
        Me.labUpdate.TabIndex = 18
        Me.labUpdate.Text = "Update into list"
        '
        'pictureAdd
        '
        Me.pictureAdd.BackColor = System.Drawing.Color.Transparent
        Me.pictureAdd.Image = CType(resources.GetObject("pictureAdd.Image"), System.Drawing.Image)
        Me.pictureAdd.Location = New System.Drawing.Point(214, 46)
        Me.pictureAdd.Name = "pictureAdd"
        Me.pictureAdd.Size = New System.Drawing.Size(48, 50)
        Me.pictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureAdd.TabIndex = 17
        Me.pictureAdd.TabStop = False
        '
        'cbbProduct
        '
        Me.cbbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProduct.Enabled = False
        Me.cbbProduct.FormattingEnabled = True
        Me.cbbProduct.Location = New System.Drawing.Point(94, 41)
        Me.cbbProduct.Name = "cbbProduct"
        Me.cbbProduct.Size = New System.Drawing.Size(89, 28)
        Me.cbbProduct.TabIndex = 15
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.White
        Me.label8.ForeColor = System.Drawing.Color.Blue
        Me.label8.Location = New System.Drawing.Point(24, 41)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(64, 20)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Product"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.White
        Me.label10.ForeColor = System.Drawing.Color.Blue
        Me.label10.Location = New System.Drawing.Point(23, 86)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(65, 20)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Number"
        '
        'pictureRemove
        '
        Me.pictureRemove.BackColor = System.Drawing.Color.Transparent
        Me.pictureRemove.Image = CType(resources.GetObject("pictureRemove.Image"), System.Drawing.Image)
        Me.pictureRemove.Location = New System.Drawing.Point(214, 88)
        Me.pictureRemove.Name = "pictureRemove"
        Me.pictureRemove.Size = New System.Drawing.Size(48, 50)
        Me.pictureRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureRemove.TabIndex = 19
        Me.pictureRemove.TabStop = False
        '
        'bEdit
        '
        Me.bEdit.BackColor = System.Drawing.Color.SandyBrown
        Me.bEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEdit.Image = CType(resources.GetObject("bEdit.Image"), System.Drawing.Image)
        Me.bEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEdit.Location = New System.Drawing.Point(253, 759)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bEdit.Size = New System.Drawing.Size(139, 48)
        Me.bEdit.TabIndex = 17
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 48
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product code"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumberOfProducts"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Number of products"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalPriceOfProducts"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total price of products"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "StatusName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'CheckBoxColumn
        '
        Me.CheckBoxColumn.HeaderText = ""
        Me.CheckBoxColumn.MinimumWidth = 8
        Me.CheckBoxColumn.Name = "CheckBoxColumn"
        Me.CheckBoxColumn.ReadOnly = True
        Me.CheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CheckBoxColumn.Visible = False
        Me.CheckBoxColumn.Width = 48
        '
        'ProductId
        '
        Me.ProductId.DataPropertyName = "ProductId"
        Me.ProductId.HeaderText = "Product code"
        Me.ProductId.MinimumWidth = 8
        Me.ProductId.Name = "ProductId"
        Me.ProductId.ReadOnly = True
        Me.ProductId.Width = 150
        '
        'ProductNameColumn
        '
        Me.ProductNameColumn.DataPropertyName = "ProductName"
        Me.ProductNameColumn.HeaderText = "Product name"
        Me.ProductNameColumn.MinimumWidth = 8
        Me.ProductNameColumn.Name = "ProductNameColumn"
        Me.ProductNameColumn.ReadOnly = True
        Me.ProductNameColumn.Width = 150
        '
        'NumberOfProducts
        '
        Me.NumberOfProducts.DataPropertyName = "NumberOfProducts"
        Me.NumberOfProducts.HeaderText = "Number of products"
        Me.NumberOfProducts.MinimumWidth = 8
        Me.NumberOfProducts.Name = "NumberOfProducts"
        Me.NumberOfProducts.ReadOnly = True
        Me.NumberOfProducts.Width = 150
        '
        'TotalPriceOfProducts
        '
        Me.TotalPriceOfProducts.DataPropertyName = "TotalPriceOfProducts"
        Me.TotalPriceOfProducts.HeaderText = "Total price of products"
        Me.TotalPriceOfProducts.MinimumWidth = 8
        Me.TotalPriceOfProducts.Name = "TotalPriceOfProducts"
        Me.TotalPriceOfProducts.ReadOnly = True
        Me.TotalPriceOfProducts.Width = 150
        '
        'StatusName
        '
        Me.StatusName.DataPropertyName = "StatusName"
        Me.StatusName.HeaderText = "Status"
        Me.StatusName.MinimumWidth = 8
        Me.StatusName.Name = "StatusName"
        Me.StatusName.ReadOnly = True
        Me.StatusName.Width = 150
        '
        'SalesOrderInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 828)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.labTitle)
        Me.Name = "SalesOrderInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Order"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNav.ResumeLayout(False)
        Me.bindingNav.PerformLayout()
        CType(Me.listBuyProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bSave As System.Windows.Forms.Button
    Private WithEvents bDelete As System.Windows.Forms.Button
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private WithEvents labTitle As System.Windows.Forms.Label
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
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private label8 As System.Windows.Forms.Label
    Private label10 As System.Windows.Forms.Label
    Private WithEvents cbbProduct As System.Windows.Forms.ComboBox
    Private WithEvents bEdit As Button
    Private WithEvents txtNumber As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtCosts As TextBox
    Private WithEvents Label16 As Label
    Friend WithEvents labWarning As Label
    Friend WithEvents labRemove As Label
    Friend WithEvents labUpdate As Label
    Friend WithEvents pictureAdd As PictureBox
    Friend WithEvents pictureRemove As PictureBox
    Friend WithEvents listBuyProduct As DataGridView
    Friend WithEvents OrderDetail As LibraryDataset.OrderDetail
    Friend WithEvents OrderIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Private WithEvents cbbPaymentMethod As ComboBox
    Private WithEvents txtShipFee As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtDiscount As TextBox
    Private WithEvents txtTotalCosts As TextBox
    Private WithEvents label13 As Label
    Private WithEvents label11 As Label
    Friend WithEvents CategoryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProductId As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfProducts As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceOfProducts As DataGridViewTextBoxColumn
    Friend WithEvents StatusName As DataGridViewTextBoxColumn
End Class
