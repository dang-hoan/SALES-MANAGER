<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesOrder))
        Me.bSave = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bPrint = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPaymentMethod = New System.Windows.Forms.TextBox()
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
        Me.txtShipFee = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.labWarning = New System.Windows.Forms.Label()
        Me.txtCosts = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.listBuyProduct = New System.Windows.Forms.ListView()
        Me.labRemove = New System.Windows.Forms.Label()
        Me.labUpdate = New System.Windows.Forms.Label()
        Me.pictureAdd = New System.Windows.Forms.PictureBox()
        Me.cbbProduct = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.pictureRemove = New System.Windows.Forms.PictureBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotalCosts = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.pictureAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(567, 738)
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
        Me.bDelete.Location = New System.Drawing.Point(243, 738)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(139, 48)
        Me.bDelete.TabIndex = 3
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bPrint
        '
        Me.bPrint.BackColor = System.Drawing.Color.SandyBrown
        Me.bPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPrint.Image = CType(resources.GetObject("bPrint.Image"), System.Drawing.Image)
        Me.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPrint.Location = New System.Drawing.Point(729, 738)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bPrint.Size = New System.Drawing.Size(139, 48)
        Me.bPrint.TabIndex = 4
        Me.bPrint.Text = "Print"
        Me.bPrint.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAdd.Location = New System.Drawing.Point(101, 738)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(119, 48)
        Me.bAdd.TabIndex = 2
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
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
        Me.groupBox1.Controls.Add(Me.txtPaymentMethod)
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
        Me.groupBox1.Size = New System.Drawing.Size(853, 214)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail order"
        '
        'txtPaymentMethod
        '
        Me.txtPaymentMethod.Enabled = False
        Me.txtPaymentMethod.Location = New System.Drawing.Point(164, 171)
        Me.txtPaymentMethod.Name = "txtPaymentMethod"
        Me.txtPaymentMethod.Size = New System.Drawing.Size(233, 26)
        Me.txtPaymentMethod.TabIndex = 23
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
        Me.cbbShipper.Size = New System.Drawing.Size(150, 28)
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
        Me.txtCustomerName.Enabled = False
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
        Me.cbbShipStatus.Size = New System.Drawing.Size(156, 28)
        Me.cbbShipStatus.TabIndex = 16
        '
        'dtShipDate
        '
        Me.dtShipDate.Location = New System.Drawing.Point(586, 85)
        Me.dtShipDate.Name = "dtShipDate"
        Me.dtShipDate.Size = New System.Drawing.Size(233, 26)
        Me.dtShipDate.TabIndex = 15
        '
        'txtShipAddress
        '
        Me.txtShipAddress.Enabled = False
        Me.txtShipAddress.Location = New System.Drawing.Point(586, 130)
        Me.txtShipAddress.Name = "txtShipAddress"
        Me.txtShipAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtShipAddress.TabIndex = 8
        '
        'txtOrderCode
        '
        Me.txtOrderCode.Enabled = False
        Me.txtOrderCode.Location = New System.Drawing.Point(164, 39)
        Me.txtOrderCode.Name = "txtOrderCode"
        Me.txtOrderCode.Size = New System.Drawing.Size(150, 26)
        Me.txtOrderCode.TabIndex = 2
        '
        'txtShipFee
        '
        Me.txtShipFee.Enabled = False
        Me.txtShipFee.Location = New System.Drawing.Point(111, 28)
        Me.txtShipFee.Name = "txtShipFee"
        Me.txtShipFee.Size = New System.Drawing.Size(139, 26)
        Me.txtShipFee.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Ship fee"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.labWarning)
        Me.groupBox2.Controls.Add(Me.txtCosts)
        Me.groupBox2.Controls.Add(Me.Label16)
        Me.groupBox2.Controls.Add(Me.txtNumber)
        Me.groupBox2.Controls.Add(Me.listBuyProduct)
        Me.groupBox2.Controls.Add(Me.labRemove)
        Me.groupBox2.Controls.Add(Me.labUpdate)
        Me.groupBox2.Controls.Add(Me.pictureAdd)
        Me.groupBox2.Controls.Add(Me.cbbProduct)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.pictureRemove)
        Me.groupBox2.Location = New System.Drawing.Point(54, 326)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(573, 177)
        Me.groupBox2.TabIndex = 15
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Detail products"
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
        'listBuyProduct
        '
        Me.listBuyProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBuyProduct.FullRowSelect = True
        Me.listBuyProduct.GridLines = True
        Me.listBuyProduct.HideSelection = False
        Me.listBuyProduct.Location = New System.Drawing.Point(291, 17)
        Me.listBuyProduct.Name = "listBuyProduct"
        Me.listBuyProduct.Size = New System.Drawing.Size(275, 154)
        Me.listBuyProduct.TabIndex = 21
        Me.listBuyProduct.UseCompatibleStateImageBehavior = False
        Me.listBuyProduct.View = System.Windows.Forms.View.Details
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
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(111, 74)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(139, 26)
        Me.txtDiscount.TabIndex = 0
        '
        'txtTotalCosts
        '
        Me.txtTotalCosts.Enabled = False
        Me.txtTotalCosts.Location = New System.Drawing.Point(111, 120)
        Me.txtTotalCosts.Name = "txtTotalCosts"
        Me.txtTotalCosts.Size = New System.Drawing.Size(139, 26)
        Me.txtTotalCosts.TabIndex = 8
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.White
        Me.label11.ForeColor = System.Drawing.Color.Blue
        Me.label11.Location = New System.Drawing.Point(17, 77)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(72, 20)
        Me.label11.TabIndex = 12
        Me.label11.Text = "Discount"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.BackColor = System.Drawing.Color.White
        Me.label13.ForeColor = System.Drawing.Color.Blue
        Me.label13.Location = New System.Drawing.Point(17, 123)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(86, 20)
        Me.label13.TabIndex = 7
        Me.label13.Text = "Total costs"
        '
        'dgvOrder
        '
        Me.dgvOrder.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Location = New System.Drawing.Point(54, 522)
        Me.dgvOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        Me.dgvOrder.RowHeadersWidth = 62
        Me.dgvOrder.RowTemplate.Height = 33
        Me.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrder.Size = New System.Drawing.Size(853, 200)
        Me.dgvOrder.TabIndex = 16
        '
        'bEdit
        '
        Me.bEdit.BackColor = System.Drawing.Color.SandyBrown
        Me.bEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEdit.Image = CType(resources.GetObject("bEdit.Image"), System.Drawing.Image)
        Me.bEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEdit.Location = New System.Drawing.Point(405, 738)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bEdit.Size = New System.Drawing.Size(139, 48)
        Me.bEdit.TabIndex = 17
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtShipFee)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtDiscount)
        Me.GroupBox3.Controls.Add(Me.txtTotalCosts)
        Me.GroupBox3.Controls.Add(Me.label13)
        Me.GroupBox3.Controls.Add(Me.label11)
        Me.GroupBox3.Location = New System.Drawing.Point(640, 326)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 177)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cost"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(134, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(700, 2)
        Me.Label9.TabIndex = 23
        '
        'SalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 827)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.label7)
        Me.Name = "SalesOrder"
        Me.Text = "Sales Order"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.pictureAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents bAdd As System.Windows.Forms.Button
    Private bPrint As System.Windows.Forms.Button
    Private WithEvents bSave As System.Windows.Forms.Button
    Private WithEvents bDelete As System.Windows.Forms.Button
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtShipAddress As System.Windows.Forms.TextBox
    Private txtOrderCode As System.Windows.Forms.TextBox
    Private cbbShipper As System.Windows.Forms.ComboBox
    Private label15 As System.Windows.Forms.Label
    Private dtOrderDate As System.Windows.Forms.DateTimePicker
    Private label14 As System.Windows.Forms.Label
    Private txtCustomerName As System.Windows.Forms.TextBox
    Private cbbShipStatus As System.Windows.Forms.ComboBox
    Private dtShipDate As System.Windows.Forms.DateTimePicker
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtDiscount As System.Windows.Forms.TextBox
    Private txtTotalCosts As System.Windows.Forms.TextBox
    Private label8 As System.Windows.Forms.Label
    Private label10 As System.Windows.Forms.Label
    Private label11 As System.Windows.Forms.Label
    Private label13 As System.Windows.Forms.Label
    Private WithEvents cbbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents dgvOrder As DataGridView
    Private WithEvents bEdit As Button
    Friend WithEvents labUpdate As Label
    Friend WithEvents pictureAdd As PictureBox
    Friend WithEvents pictureRemove As PictureBox
    Friend WithEvents labRemove As Label
    Friend WithEvents listBuyProduct As ListView
    Private WithEvents txtNumber As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Private WithEvents txtShipFee As TextBox
    Friend WithEvents Label9 As Label
    Private WithEvents txtPaymentMethod As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtCosts As TextBox
    Private WithEvents Label16 As Label
    Friend WithEvents labWarning As Label
End Class
