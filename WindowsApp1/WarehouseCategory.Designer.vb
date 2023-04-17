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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseCategory))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtNumberOfImport = New System.Windows.Forms.TextBox()
        Me.txtNumberOfExport = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.bAddProduct = New System.Windows.Forms.Button()
        Me.ProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.groupBox1.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.groupBox1.Size = New System.Drawing.Size(832, 182)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(193, 129)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtAddress.TabIndex = 24
        '
        'txtNumberOfImport
        '
        Me.txtNumberOfImport.Enabled = False
        Me.txtNumberOfImport.Location = New System.Drawing.Point(615, 35)
        Me.txtNumberOfImport.Name = "txtNumberOfImport"
        Me.txtNumberOfImport.Size = New System.Drawing.Size(164, 26)
        Me.txtNumberOfImport.TabIndex = 22
        Me.txtNumberOfImport.Text = "0"
        '
        'txtNumberOfExport
        '
        Me.txtNumberOfExport.Enabled = False
        Me.txtNumberOfExport.Location = New System.Drawing.Point(615, 84)
        Me.txtNumberOfExport.Name = "txtNumberOfExport"
        Me.txtNumberOfExport.Size = New System.Drawing.Size(164, 26)
        Me.txtNumberOfExport.TabIndex = 21
        Me.txtNumberOfExport.Text = "0"
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
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(193, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(193, 38)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(117, 26)
        Me.txtCode.TabIndex = 2
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(734, 755)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(150, 55)
        Me.bSave.TabIndex = 19
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bDelete
        '
        Me.bDelete.BackColor = System.Drawing.Color.SandyBrown
        Me.bDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDelete.Image = CType(resources.GetObject("bDelete.Image"), System.Drawing.Image)
        Me.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDelete.Location = New System.Drawing.Point(516, 755)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(150, 55)
        Me.bDelete.TabIndex = 17
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bEdit
        '
        Me.bEdit.BackColor = System.Drawing.Color.SandyBrown
        Me.bEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEdit.Image = CType(resources.GetObject("bEdit.Image"), System.Drawing.Image)
        Me.bEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEdit.Location = New System.Drawing.Point(298, 755)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bEdit.Size = New System.Drawing.Size(150, 55)
        Me.bEdit.TabIndex = 18
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAdd.Location = New System.Drawing.Point(80, 755)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(150, 55)
        Me.bAdd.TabIndex = 16
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'dgvCategory
        '
        Me.dgvCategory.AllowUserToAddRows = False
        Me.dgvCategory.AllowUserToDeleteRows = False
        Me.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Location = New System.Drawing.Point(70, 496)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.RowHeadersWidth = 62
        Me.dgvCategory.RowTemplate.Height = 28
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.Size = New System.Drawing.Size(832, 238)
        Me.dgvCategory.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bAddProduct)
        Me.GroupBox2.Controls.Add(Me.dgvProduct)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 213)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List products of warehouse"
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductId, Me.Column2, Me.Column3, Me.Edit, Me.Delete})
        Me.dgvProduct.Location = New System.Drawing.Point(6, 25)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersWidth = 62
        Me.dgvProduct.RowTemplate.Height = 28
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(820, 147)
        Me.dgvProduct.TabIndex = 0
        '
        'bAddProduct
        '
        Me.bAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddProduct.ForeColor = System.Drawing.Color.Green
        Me.bAddProduct.Image = CType(resources.GetObject("bAddProduct.Image"), System.Drawing.Image)
        Me.bAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAddProduct.Location = New System.Drawing.Point(10, 178)
        Me.bAddProduct.Name = "bAddProduct"
        Me.bAddProduct.Size = New System.Drawing.Size(150, 29)
        Me.bAddProduct.TabIndex = 1
        Me.bAddProduct.Text = "Add product"
        Me.bAddProduct.UseVisualStyleBackColor = True
        '
        'ProductId
        '
        Me.ProductId.HeaderText = "Product code"
        Me.ProductId.MinimumWidth = 8
        Me.ProductId.Name = "ProductId"
        Me.ProductId.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product name"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Number of products"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'Edit
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle15
        Me.Edit.HeaderText = ""
        Me.Edit.MinimumWidth = 8
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        Me.Edit.Width = 50
        '
        'Delete
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle16
        Me.Delete.HeaderText = ""
        Me.Delete.MinimumWidth = 8
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Width = 50
        '
        'WarehouseCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 837)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.dgvCategory)
        Me.Controls.Add(Me.label7)
        Me.Name = "WarehouseCategory"
        Me.Text = "Product Category"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtName As System.Windows.Forms.TextBox
    Private txtCode As System.Windows.Forms.TextBox
    Private WithEvents bSave As Button
    Private WithEvents bDelete As Button
    Private WithEvents bEdit As Button
    Private WithEvents bAdd As Button
    Private WithEvents Label8 As Label
    Private WithEvents txtNumberOfExport As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Private WithEvents txtNumberOfImport As TextBox
    Private WithEvents txtAddress As TextBox
    Private WithEvents dgvCategory As DataGridView
    Private WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents bAddProduct As Button
    Friend WithEvents ProductId As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
