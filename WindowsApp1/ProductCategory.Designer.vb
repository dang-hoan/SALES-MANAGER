<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductCategory))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSupplier = New System.Windows.Forms.CheckBox()
        Me.cbCategory = New System.Windows.Forms.CheckBox()
        Me.cbProductStatus = New System.Windows.Forms.CheckBox()
        Me.cbWarehouse = New System.Windows.Forms.CheckBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.txtUnitDiscount = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbbWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbbSupplier = New System.Windows.Forms.ComboBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.cbbStatus = New System.Windows.Forms.ComboBox()
        Me.cbbCategory = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
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
        Me.dgvProductSearch = New System.Windows.Forms.DataGridView()
        Me.CheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WareHouseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WareHouseIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New LibraryDataset.Product()
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
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBox1.SuspendLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bindingNav.SuspendLayout()
        CType(Me.dgvProductSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(265, 257)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSearch.Size = New System.Drawing.Size(139, 48)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbSupplier)
        Me.groupBox1.Controls.Add(Me.cbCategory)
        Me.groupBox1.Controls.Add(Me.cbProductStatus)
        Me.groupBox1.Controls.Add(Me.cbWarehouse)
        Me.groupBox1.Controls.Add(Me.btnExport)
        Me.groupBox1.Controls.Add(Me.txtUnitDiscount)
        Me.groupBox1.Controls.Add(Me.txtNumber)
        Me.groupBox1.Controls.Add(Me.btnSearch)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.cbbWarehouse)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.cbbSupplier)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Controls.Add(Me.cbbStatus)
        Me.groupBox1.Controls.Add(Me.cbbCategory)
        Me.groupBox1.Controls.Add(Me.txtPrice)
        Me.groupBox1.Controls.Add(Me.txtUnitPrice)
        Me.groupBox1.Controls.Add(Me.txtDiscount)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.txtCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Location = New System.Drawing.Point(54, 107)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(853, 321)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Search information"
        '
        'cbSupplier
        '
        Me.cbSupplier.AutoSize = True
        Me.cbSupplier.Location = New System.Drawing.Point(17, 181)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(22, 21)
        Me.cbSupplier.TabIndex = 27
        Me.cbSupplier.UseVisualStyleBackColor = True
        '
        'cbCategory
        '
        Me.cbCategory.AutoSize = True
        Me.cbCategory.Location = New System.Drawing.Point(17, 141)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(22, 21)
        Me.cbCategory.TabIndex = 26
        Me.cbCategory.UseVisualStyleBackColor = True
        '
        'cbProductStatus
        '
        Me.cbProductStatus.AutoSize = True
        Me.cbProductStatus.Location = New System.Drawing.Point(411, 122)
        Me.cbProductStatus.Name = "cbProductStatus"
        Me.cbProductStatus.Size = New System.Drawing.Size(22, 21)
        Me.cbProductStatus.TabIndex = 25
        Me.cbProductStatus.UseVisualStyleBackColor = True
        '
        'cbWarehouse
        '
        Me.cbWarehouse.AutoSize = True
        Me.cbWarehouse.Location = New System.Drawing.Point(411, 29)
        Me.cbWarehouse.Name = "cbWarehouse"
        Me.cbWarehouse.Size = New System.Drawing.Size(22, 21)
        Me.cbWarehouse.TabIndex = 24
        Me.cbWarehouse.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.SandyBrown
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(448, 257)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnExport.Size = New System.Drawing.Size(139, 48)
        Me.btnExport.TabIndex = 23
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'txtUnitDiscount
        '
        Me.txtUnitDiscount.Enabled = False
        Me.txtUnitDiscount.Location = New System.Drawing.Point(766, 159)
        Me.txtUnitDiscount.Name = "txtUnitDiscount"
        Me.txtUnitDiscount.Size = New System.Drawing.Size(53, 26)
        Me.txtUnitDiscount.TabIndex = 22
        Me.txtUnitDiscount.Text = "%"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(586, 205)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(164, 26)
        Me.txtNumber.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(439, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total products"
        '
        'cbbWarehouse
        '
        Me.cbbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbWarehouse.FormattingEnabled = True
        Me.cbbWarehouse.Location = New System.Drawing.Point(586, 25)
        Me.cbbWarehouse.Name = "cbbWarehouse"
        Me.cbbWarehouse.Size = New System.Drawing.Size(164, 28)
        Me.cbbWarehouse.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(439, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Warehouse"
        '
        'cbbSupplier
        '
        Me.cbbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSupplier.FormattingEnabled = True
        Me.cbbSupplier.Location = New System.Drawing.Point(174, 177)
        Me.cbbSupplier.Name = "cbbSupplier"
        Me.cbbSupplier.Size = New System.Drawing.Size(172, 28)
        Me.cbbSupplier.TabIndex = 17
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(45, 180)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(67, 20)
        Me.label12.TabIndex = 16
        Me.label12.Text = "Supplier"
        '
        'cbbStatus
        '
        Me.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbStatus.FormattingEnabled = True
        Me.cbbStatus.Location = New System.Drawing.Point(586, 115)
        Me.cbbStatus.Name = "cbbStatus"
        Me.cbbStatus.Size = New System.Drawing.Size(164, 28)
        Me.cbbStatus.TabIndex = 15
        '
        'cbbCategory
        '
        Me.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbCategory.FormattingEnabled = True
        Me.cbbCategory.Location = New System.Drawing.Point(174, 137)
        Me.cbbCategory.Name = "cbbCategory"
        Me.cbbCategory.Size = New System.Drawing.Size(172, 28)
        Me.cbbCategory.TabIndex = 14
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(586, 71)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(164, 26)
        Me.txtPrice.TabIndex = 13
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Enabled = False
        Me.txtUnitPrice.Location = New System.Drawing.Point(766, 77)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(53, 26)
        Me.txtUnitPrice.TabIndex = 15
        Me.txtUnitPrice.Text = "$"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(586, 161)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(164, 26)
        Me.txtDiscount.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(174, 94)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(172, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(174, 51)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(103, 26)
        Me.txtCode.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(45, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Product code"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(45, 94)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(108, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Product name"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(45, 140)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(73, 20)
        Me.label11.TabIndex = 9
        Me.label11.Text = "Category"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(439, 169)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(130, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Discount percent"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(439, 75)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Product price"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(439, 122)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(112, 20)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Product status"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(295, 40)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(379, 37)
        Me.label7.TabIndex = 24
        Me.label7.Text = "PRODUCT CATEGORY"
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
        Me.bDelete.TabIndex = 29
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
        Me.bAdd.TabIndex = 28
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
        Me.bindingNav.Location = New System.Drawing.Point(319, 715)
        Me.bindingNav.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bindingNav.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bindingNav.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bindingNav.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bindingNav.Name = "bindingNav"
        Me.bindingNav.PositionItem = Me.BindingNavigatorPositionItem
        Me.bindingNav.Size = New System.Drawing.Size(331, 31)
        Me.bindingNav.TabIndex = 30
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
        'dgvProductSearch
        '
        Me.dgvProductSearch.AllowUserToAddRows = False
        Me.dgvProductSearch.AllowUserToDeleteRows = False
        Me.dgvProductSearch.AutoGenerateColumns = False
        Me.dgvProductSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.DiscountPercentDataGridViewTextBoxColumn, Me.CategoryNameDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.WareHouseNameDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.SellNumberDataGridViewTextBoxColumn, Me.StatusNameDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn, Me.ImageIdDataGridViewTextBoxColumn, Me.SupplierIdDataGridViewTextBoxColumn, Me.CategoryIdDataGridViewTextBoxColumn, Me.StatusIdDataGridViewTextBoxColumn, Me.WareHouseIdDataGridViewTextBoxColumn})
        Me.dgvProductSearch.DataMember = "ProductSalesDetail"
        Me.dgvProductSearch.DataSource = Me.Product
        Me.dgvProductSearch.Location = New System.Drawing.Point(54, 448)
        Me.dgvProductSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProductSearch.Name = "dgvProductSearch"
        Me.dgvProductSearch.ReadOnly = True
        Me.dgvProductSearch.RowHeadersVisible = False
        Me.dgvProductSearch.RowHeadersWidth = 62
        Me.dgvProductSearch.RowTemplate.Height = 33
        Me.dgvProductSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductSearch.Size = New System.Drawing.Size(853, 265)
        Me.dgvProductSearch.TabIndex = 1
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
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Product code"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product name"
        Me.ProductNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 150
        '
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "Product price"
        Me.ProductPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        Me.ProductPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductPriceDataGridViewTextBoxColumn.Width = 150
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Price unit"
        Me.UnitPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 150
        '
        'DiscountPercentDataGridViewTextBoxColumn
        '
        Me.DiscountPercentDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercent"
        Me.DiscountPercentDataGridViewTextBoxColumn.HeaderText = "Discount percent"
        Me.DiscountPercentDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiscountPercentDataGridViewTextBoxColumn.Name = "DiscountPercentDataGridViewTextBoxColumn"
        Me.DiscountPercentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountPercentDataGridViewTextBoxColumn.Width = 150
        '
        'CategoryNameDataGridViewTextBoxColumn
        '
        Me.CategoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn.HeaderText = "Category name"
        Me.CategoryNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CategoryNameDataGridViewTextBoxColumn.Name = "CategoryNameDataGridViewTextBoxColumn"
        Me.CategoryNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryNameDataGridViewTextBoxColumn.Width = 150
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
        'WareHouseNameDataGridViewTextBoxColumn
        '
        Me.WareHouseNameDataGridViewTextBoxColumn.DataPropertyName = "WareHouseName"
        Me.WareHouseNameDataGridViewTextBoxColumn.HeaderText = "Warehouse name"
        Me.WareHouseNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WareHouseNameDataGridViewTextBoxColumn.Name = "WareHouseNameDataGridViewTextBoxColumn"
        Me.WareHouseNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.WareHouseNameDataGridViewTextBoxColumn.Width = 150
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 150
        '
        'SellNumberDataGridViewTextBoxColumn
        '
        Me.SellNumberDataGridViewTextBoxColumn.DataPropertyName = "SellNumber"
        Me.SellNumberDataGridViewTextBoxColumn.HeaderText = "Sell number"
        Me.SellNumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SellNumberDataGridViewTextBoxColumn.Name = "SellNumberDataGridViewTextBoxColumn"
        Me.SellNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.SellNumberDataGridViewTextBoxColumn.Width = 150
        '
        'StatusNameDataGridViewTextBoxColumn
        '
        Me.StatusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName"
        Me.StatusNameDataGridViewTextBoxColumn.HeaderText = "Status name"
        Me.StatusNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StatusNameDataGridViewTextBoxColumn.Name = "StatusNameDataGridViewTextBoxColumn"
        Me.StatusNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusNameDataGridViewTextBoxColumn.Width = 150
        '
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        Me.RatingDataGridViewTextBoxColumn.ReadOnly = True
        Me.RatingDataGridViewTextBoxColumn.Visible = False
        Me.RatingDataGridViewTextBoxColumn.Width = 150
        '
        'ImageIdDataGridViewTextBoxColumn
        '
        Me.ImageIdDataGridViewTextBoxColumn.DataPropertyName = "ImageId"
        Me.ImageIdDataGridViewTextBoxColumn.HeaderText = "ImageId"
        Me.ImageIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ImageIdDataGridViewTextBoxColumn.Name = "ImageIdDataGridViewTextBoxColumn"
        Me.ImageIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImageIdDataGridViewTextBoxColumn.Visible = False
        Me.ImageIdDataGridViewTextBoxColumn.Width = 150
        '
        'SupplierIdDataGridViewTextBoxColumn
        '
        Me.SupplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId"
        Me.SupplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId"
        Me.SupplierIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SupplierIdDataGridViewTextBoxColumn.Name = "SupplierIdDataGridViewTextBoxColumn"
        Me.SupplierIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIdDataGridViewTextBoxColumn.Visible = False
        Me.SupplierIdDataGridViewTextBoxColumn.Width = 150
        '
        'CategoryIdDataGridViewTextBoxColumn
        '
        Me.CategoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId"
        Me.CategoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId"
        Me.CategoryIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CategoryIdDataGridViewTextBoxColumn.Name = "CategoryIdDataGridViewTextBoxColumn"
        Me.CategoryIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryIdDataGridViewTextBoxColumn.Visible = False
        Me.CategoryIdDataGridViewTextBoxColumn.Width = 150
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
        'WareHouseIdDataGridViewTextBoxColumn
        '
        Me.WareHouseIdDataGridViewTextBoxColumn.DataPropertyName = "WareHouseId"
        Me.WareHouseIdDataGridViewTextBoxColumn.HeaderText = "WareHouseId"
        Me.WareHouseIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WareHouseIdDataGridViewTextBoxColumn.Name = "WareHouseIdDataGridViewTextBoxColumn"
        Me.WareHouseIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.WareHouseIdDataGridViewTextBoxColumn.Visible = False
        Me.WareHouseIdDataGridViewTextBoxColumn.Width = 150
        '
        'Product
        '
        Me.Product.DataSetName = "Product"
        Me.Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductPrice"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductPrice"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DiscountPercent"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DiscountPercent"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CategoryName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CategoryName"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CompanyName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CompanyName"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "WareHouseName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "WareHouseName"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SellNumber"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SellNumber"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "StatusName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "StatusName"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Rating"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Rating"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ImageId"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ImageId"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SupplierId"
        Me.DataGridViewTextBoxColumn14.HeaderText = "SupplierId"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CategoryId"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CategoryId"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "StatusId"
        Me.DataGridViewTextBoxColumn16.HeaderText = "StatusId"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "WareHouseId"
        Me.DataGridViewTextBoxColumn17.HeaderText = "WareHouseId"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'ProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 840)
        Me.Controls.Add(Me.bindingNav)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.dgvProductSearch)
        Me.Name = "ProductCategory"
        Me.Text = "Search product"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.bindingNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bindingNav.ResumeLayout(False)
        Me.bindingNav.PerformLayout()
        CType(Me.dgvProductSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvProductSearch As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtUnitDiscount As TextBox
    Private WithEvents txtNumber As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents cbbWarehouse As ComboBox
    Private WithEvents Label9 As Label
    Private WithEvents cbbSupplier As ComboBox
    Private WithEvents label12 As Label
    Private WithEvents cbbStatus As ComboBox
    Private WithEvents cbbCategory As ComboBox
    Private WithEvents txtPrice As TextBox
    Private WithEvents txtUnitPrice As TextBox
    Private WithEvents txtDiscount As TextBox
    Private WithEvents txtName As TextBox
    Private WithEvents txtCode As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label11 As Label
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents label5 As Label
    Private WithEvents btnExport As Button
    Private WithEvents label7 As Label
    Friend WithEvents cbSupplier As CheckBox
    Friend WithEvents cbCategory As CheckBox
    Friend WithEvents cbProductStatus As CheckBox
    Friend WithEvents cbWarehouse As CheckBox
    Private WithEvents bDelete As Button
    Private WithEvents bAdd As Button
    Friend WithEvents Product As LibraryDataset.Product
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
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WareHouseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WareHouseIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
End Class
