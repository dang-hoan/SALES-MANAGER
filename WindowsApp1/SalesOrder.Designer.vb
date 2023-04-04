<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesOrder
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesOrder))
        Me.bSave = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bPrint = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbEmployeeCode = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.dtOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.cbbShipStatus = New System.Windows.Forms.ComboBox()
        Me.dtShipDate = New System.Windows.Forms.DateTimePicker()
        Me.txtShipAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.txtOrderCode = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbbProductCode = New System.Windows.Forms.ComboBox()
        Me.cbbNumber = New System.Windows.Forms.ComboBox()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.SalesOrderTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderTableAdapterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderTableAdapterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(567, 693)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(139, 48)
        Me.bSave.TabIndex = 5
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bCancel
        '
        Me.bCancel.BackColor = System.Drawing.Color.SandyBrown
        Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCancel.Image = CType(resources.GetObject("bCancel.Image"), System.Drawing.Image)
        Me.bCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancel.Location = New System.Drawing.Point(243, 693)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bCancel.Size = New System.Drawing.Size(139, 48)
        Me.bCancel.TabIndex = 3
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = False
        '
        'bPrint
        '
        Me.bPrint.BackColor = System.Drawing.Color.SandyBrown
        Me.bPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPrint.Image = CType(resources.GetObject("bPrint.Image"), System.Drawing.Image)
        Me.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPrint.Location = New System.Drawing.Point(729, 693)
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
        Me.bAdd.Location = New System.Drawing.Point(101, 693)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(119, 48)
        Me.bAdd.TabIndex = 2
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(28, 91)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Customer code"
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
        Me.label3.Location = New System.Drawing.Point(453, 134)
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
        Me.label4.Location = New System.Drawing.Point(453, 91)
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
        Me.label5.Location = New System.Drawing.Point(28, 134)
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
        Me.groupBox1.Controls.Add(Me.cbbEmployeeCode)
        Me.groupBox1.Controls.Add(Me.label15)
        Me.groupBox1.Controls.Add(Me.dtOrderDate)
        Me.groupBox1.Controls.Add(Me.label14)
        Me.groupBox1.Controls.Add(Me.txtCustomerName)
        Me.groupBox1.Controls.Add(Me.cbbShipStatus)
        Me.groupBox1.Controls.Add(Me.dtShipDate)
        Me.groupBox1.Controls.Add(Me.txtShipAddress)
        Me.groupBox1.Controls.Add(Me.txtCustomerCode)
        Me.groupBox1.Controls.Add(Me.txtOrderCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
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
        'cbbEmployeeCode
        '
        Me.cbbEmployeeCode.Enabled = False
        Me.cbbEmployeeCode.FormattingEnabled = True
        Me.cbbEmployeeCode.Location = New System.Drawing.Point(164, 174)
        Me.cbbEmployeeCode.Name = "cbbEmployeeCode"
        Me.cbbEmployeeCode.Size = New System.Drawing.Size(150, 28)
        Me.cbbEmployeeCode.TabIndex = 21
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.BackColor = System.Drawing.Color.White
        Me.label15.ForeColor = System.Drawing.Color.Blue
        Me.label15.Location = New System.Drawing.Point(28, 177)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(118, 20)
        Me.label15.TabIndex = 20
        Me.label15.Text = "Employee code"
        '
        'dtOrderDate
        '
        Me.dtOrderDate.Location = New System.Drawing.Point(586, 39)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(233, 26)
        Me.dtOrderDate.TabIndex = 19
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.Color.White
        Me.label14.ForeColor = System.Drawing.Color.Blue
        Me.label14.Location = New System.Drawing.Point(453, 45)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(85, 20)
        Me.label14.TabIndex = 18
        Me.label14.Text = "Order date"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(164, 134)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(150, 26)
        Me.txtCustomerName.TabIndex = 17
        '
        'cbbShipStatus
        '
        Me.cbbShipStatus.FormattingEnabled = True
        Me.cbbShipStatus.Location = New System.Drawing.Point(586, 173)
        Me.cbbShipStatus.Name = "cbbShipStatus"
        Me.cbbShipStatus.Size = New System.Drawing.Size(156, 28)
        Me.cbbShipStatus.TabIndex = 16
        '
        'dtShipDate
        '
        Me.dtShipDate.Location = New System.Drawing.Point(586, 87)
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
        'txtCustomerCode
        '
        Me.txtCustomerCode.Enabled = False
        Me.txtCustomerCode.Location = New System.Drawing.Point(164, 88)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.Size = New System.Drawing.Size(150, 26)
        Me.txtCustomerCode.TabIndex = 6
        '
        'txtOrderCode
        '
        Me.txtOrderCode.Enabled = False
        Me.txtOrderCode.Location = New System.Drawing.Point(164, 45)
        Me.txtOrderCode.Name = "txtOrderCode"
        Me.txtOrderCode.Size = New System.Drawing.Size(150, 26)
        Me.txtOrderCode.TabIndex = 2
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cbbProductCode)
        Me.groupBox2.Controls.Add(Me.cbbNumber)
        Me.groupBox2.Controls.Add(Me.txtProductPrice)
        Me.groupBox2.Controls.Add(Me.txtDiscount)
        Me.groupBox2.Controls.Add(Me.txtTotalPrice)
        Me.groupBox2.Controls.Add(Me.txtProductName)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Location = New System.Drawing.Point(54, 325)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(853, 125)
        Me.groupBox2.TabIndex = 15
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Detail products"
        '
        'cbbProductCode
        '
        Me.cbbProductCode.Enabled = False
        Me.cbbProductCode.FormattingEnabled = True
        Me.cbbProductCode.Location = New System.Drawing.Point(138, 33)
        Me.cbbProductCode.Name = "cbbProductCode"
        Me.cbbProductCode.Size = New System.Drawing.Size(89, 28)
        Me.cbbProductCode.TabIndex = 15
        '
        'cbbNumber
        '
        Me.cbbNumber.FormattingEnabled = True
        Me.cbbNumber.Location = New System.Drawing.Point(138, 79)
        Me.cbbNumber.Name = "cbbNumber"
        Me.cbbNumber.Size = New System.Drawing.Size(89, 28)
        Me.cbbNumber.TabIndex = 14
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Enabled = False
        Me.txtProductPrice.Location = New System.Drawing.Point(679, 36)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(148, 26)
        Me.txtProductPrice.TabIndex = 13
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(382, 79)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(148, 26)
        Me.txtDiscount.TabIndex = 0
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(679, 79)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(148, 26)
        Me.txtTotalPrice.TabIndex = 8
        '
        'txtProductName
        '
        Me.txtProductName.Enabled = False
        Me.txtProductName.Location = New System.Drawing.Point(382, 36)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(148, 26)
        Me.txtProductName.TabIndex = 6
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.White
        Me.label8.ForeColor = System.Drawing.Color.Blue
        Me.label8.Location = New System.Drawing.Point(18, 39)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(103, 20)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Product code"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.White
        Me.label9.ForeColor = System.Drawing.Color.Blue
        Me.label9.Location = New System.Drawing.Point(268, 39)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(108, 20)
        Me.label9.TabIndex = 5
        Me.label9.Text = "Product name"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.White
        Me.label10.ForeColor = System.Drawing.Color.Blue
        Me.label10.Location = New System.Drawing.Point(18, 82)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(65, 20)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Number"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.White
        Me.label11.ForeColor = System.Drawing.Color.Blue
        Me.label11.Location = New System.Drawing.Point(268, 82)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(72, 20)
        Me.label11.TabIndex = 12
        Me.label11.Text = "Discount"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.BackColor = System.Drawing.Color.White
        Me.label12.ForeColor = System.Drawing.Color.Blue
        Me.label12.Location = New System.Drawing.Point(570, 36)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(102, 20)
        Me.label12.TabIndex = 3
        Me.label12.Text = "Product price"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.BackColor = System.Drawing.Color.White
        Me.label13.ForeColor = System.Drawing.Color.Blue
        Me.label13.Location = New System.Drawing.Point(570, 79)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(82, 20)
        Me.label13.TabIndex = 7
        Me.label13.Text = "Total price"
        '
        'dgvOrder
        '
        Me.dgvOrder.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Location = New System.Drawing.Point(54, 471)
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
        Me.bEdit.Location = New System.Drawing.Point(405, 693)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bEdit.Size = New System.Drawing.Size(139, 48)
        Me.bEdit.TabIndex = 17
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'SalesOrderTableAdapterBindingSource
        '
        Me.SalesOrderTableAdapterBindingSource.DataSource = GetType(LibraryDataset.OrderDetailTableAdapters.SalesOrderTableAdapter)
        '
        'SalesOrderTableAdapterBindingSource1
        '
        Me.SalesOrderTableAdapterBindingSource1.DataSource = GetType(LibraryDataset.OrderDetailTableAdapters.SalesOrderTableAdapter)
        '
        'SalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 766)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bCancel)
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
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderTableAdapterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private bAdd As System.Windows.Forms.Button
        Private bPrint As System.Windows.Forms.Button
        Private WithEvents bSave As System.Windows.Forms.Button
        Private bCancel As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtShipAddress As System.Windows.Forms.TextBox
    Private txtCustomerCode As System.Windows.Forms.TextBox
    Private txtOrderCode As System.Windows.Forms.TextBox
    Private cbbEmployeeCode As System.Windows.Forms.ComboBox
    Private label15 As System.Windows.Forms.Label
    Private dtOrderDate As System.Windows.Forms.DateTimePicker
    Private label14 As System.Windows.Forms.Label
    Private txtCustomerName As System.Windows.Forms.TextBox
    Private cbbShipStatus As System.Windows.Forms.ComboBox
    Private dtShipDate As System.Windows.Forms.DateTimePicker
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private cbbNumber As System.Windows.Forms.ComboBox
    Private txtProductPrice As System.Windows.Forms.TextBox
    Private txtDiscount As System.Windows.Forms.TextBox
    Private txtTotalPrice As System.Windows.Forms.TextBox
    Private txtProductName As System.Windows.Forms.TextBox
    Private label8 As System.Windows.Forms.Label
    Private label9 As System.Windows.Forms.Label
    Private label10 As System.Windows.Forms.Label
    Private label11 As System.Windows.Forms.Label
    Private label12 As System.Windows.Forms.Label
    Private label13 As System.Windows.Forms.Label
    Private cbbProductCode As System.Windows.Forms.ComboBox
    Friend WithEvents dgvOrder As DataGridView
    Private WithEvents bEdit As Button
    Friend WithEvents SalesOrderTableAdapterBindingSource As BindingSource
    Friend WithEvents SalesOrderTableAdapterBindingSource1 As BindingSource
End Class
