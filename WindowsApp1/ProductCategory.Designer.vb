<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductCategory))
        Me.bSave = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductStatusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbCategory = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(724, 693)
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
        Me.bDelete.Location = New System.Drawing.Point(298, 693)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(139, 48)
        Me.bDelete.TabIndex = 3
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bEdit
        '
        Me.bEdit.BackColor = System.Drawing.Color.SandyBrown
        Me.bEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEdit.Image = CType(resources.GetObject("bEdit.Image"), System.Drawing.Image)
        Me.bEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEdit.Location = New System.Drawing.Point(511, 693)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bEdit.Size = New System.Drawing.Size(139, 48)
        Me.bEdit.TabIndex = 4
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.bAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAdd.Location = New System.Drawing.Point(105, 693)
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
        Me.label1.Location = New System.Drawing.Point(28, 88)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(108, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Product name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Product code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(439, 51)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Product price"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(28, 134)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 20)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Category"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(439, 94)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(112, 20)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Product status"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(439, 134)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(130, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Discount percent"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(314, 36)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(379, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "PRODUCT CATEGORY"
        '
        'dgvCategory
        '
        Me.dgvCategory.AutoGenerateColumns = False
        Me.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.SupplierIdDataGridViewTextBoxColumn, Me.CategoryIdDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.ProductStatusIdDataGridViewTextBoxColumn, Me.DiscountPercentDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn, Me.ImageIdDataGridViewTextBoxColumn})
        Me.dgvCategory.DataSource = Me.ProductBindingSource
        Me.dgvCategory.Location = New System.Drawing.Point(54, 302)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.RowHeadersWidth = 62
        Me.dgvCategory.RowTemplate.Height = 28
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.Size = New System.Drawing.Size(853, 370)
        Me.dgvCategory.TabIndex = 1
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
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 150
        '
        'SupplierIdDataGridViewTextBoxColumn
        '
        Me.SupplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId"
        Me.SupplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId"
        Me.SupplierIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SupplierIdDataGridViewTextBoxColumn.Name = "SupplierIdDataGridViewTextBoxColumn"
        Me.SupplierIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIdDataGridViewTextBoxColumn.Width = 150
        '
        'CategoryIdDataGridViewTextBoxColumn
        '
        Me.CategoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId"
        Me.CategoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId"
        Me.CategoryIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CategoryIdDataGridViewTextBoxColumn.Name = "CategoryIdDataGridViewTextBoxColumn"
        Me.CategoryIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryIdDataGridViewTextBoxColumn.Width = 150
        '
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        Me.ProductPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductPriceDataGridViewTextBoxColumn.Width = 150
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 150
        '
        'ProductStatusIdDataGridViewTextBoxColumn
        '
        Me.ProductStatusIdDataGridViewTextBoxColumn.DataPropertyName = "ProductStatusId"
        Me.ProductStatusIdDataGridViewTextBoxColumn.HeaderText = "ProductStatusId"
        Me.ProductStatusIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductStatusIdDataGridViewTextBoxColumn.Name = "ProductStatusIdDataGridViewTextBoxColumn"
        Me.ProductStatusIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductStatusIdDataGridViewTextBoxColumn.Width = 150
        '
        'DiscountPercentDataGridViewTextBoxColumn
        '
        Me.DiscountPercentDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercent"
        Me.DiscountPercentDataGridViewTextBoxColumn.HeaderText = "DiscountPercent"
        Me.DiscountPercentDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiscountPercentDataGridViewTextBoxColumn.Name = "DiscountPercentDataGridViewTextBoxColumn"
        Me.DiscountPercentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountPercentDataGridViewTextBoxColumn.Width = 150
        '
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        Me.RatingDataGridViewTextBoxColumn.ReadOnly = True
        Me.RatingDataGridViewTextBoxColumn.Width = 150
        '
        'ImageIdDataGridViewTextBoxColumn
        '
        Me.ImageIdDataGridViewTextBoxColumn.DataPropertyName = "ImageId"
        Me.ImageIdDataGridViewTextBoxColumn.HeaderText = "ImageId"
        Me.ImageIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ImageIdDataGridViewTextBoxColumn.Name = "ImageIdDataGridViewTextBoxColumn"
        Me.ImageIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImageIdDataGridViewTextBoxColumn.Width = 150
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = GetType(LibraryDataset.Product)
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbbCategory)
        Me.groupBox1.Controls.Add(Me.txtPrice)
        Me.groupBox1.Controls.Add(Me.txtDiscount)
        Me.groupBox1.Controls.Add(Me.txtStatus)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.txtCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Location = New System.Drawing.Point(54, 97)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(853, 188)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail"
        '
        'cbbCategory
        '
        Me.cbbCategory.FormattingEnabled = True
        Me.cbbCategory.Location = New System.Drawing.Point(142, 131)
        Me.cbbCategory.Name = "cbbCategory"
        Me.cbbCategory.Size = New System.Drawing.Size(172, 28)
        Me.cbbCategory.TabIndex = 14
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(586, 51)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(164, 26)
        Me.txtPrice.TabIndex = 13
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(586, 128)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(233, 26)
        Me.txtDiscount.TabIndex = 0
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(586, 88)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(233, 26)
        Me.txtStatus.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(142, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(142, 45)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(103, 26)
        Me.txtCode.TabIndex = 2
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Enabled = False
        Me.txtUnitPrice.Location = New System.Drawing.Point(820, 148)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(53, 26)
        Me.txtUnitPrice.TabIndex = 15
        '
        'ProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 766)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.dgvCategory)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.label7)
        Me.Name = "ProductCategory"
        Me.Text = "Product Category"
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents bAdd As System.Windows.Forms.Button
        Private WithEvents bEdit As System.Windows.Forms.Button
        Private WithEvents bSave As System.Windows.Forms.Button
        Private WithEvents bDelete As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private WithEvents dgvCategory As System.Windows.Forms.DataGridView
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private txtDiscount As System.Windows.Forms.TextBox
        Private txtStatus As System.Windows.Forms.TextBox
        Private txtName As System.Windows.Forms.TextBox
        Private txtCode As System.Windows.Forms.TextBox
        Private cbbCategory As System.Windows.Forms.ComboBox
        Private txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductStatusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBindingSource As BindingSource
    Private WithEvents txtUnitPrice As TextBox
End Class
