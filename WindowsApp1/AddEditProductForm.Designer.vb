<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEditProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditProductForm))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.labTitle = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUnitDiscount = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbbWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbStatus = New System.Windows.Forms.ComboBox()
        Me.cbbCategory = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bClearAll = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(43, 183)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(108, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Product name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(43, 115)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Product code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(423, 55)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Product price"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(43, 251)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 20)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Category"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(423, 116)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(112, 20)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Product status"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(423, 182)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(130, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Discount percent"
        '
        'labTitle
        '
        Me.labTitle.AutoSize = True
        Me.labTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTitle.ForeColor = System.Drawing.Color.Red
        Me.labTitle.Location = New System.Drawing.Point(322, 36)
        Me.labTitle.Name = "labTitle"
        Me.labTitle.Size = New System.Drawing.Size(325, 46)
        Me.labTitle.TabIndex = 8
        Me.labTitle.Text = "ADD PRODUCT"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtUnitDiscount)
        Me.groupBox1.Controls.Add(Me.txtNumber)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.cbbWarehouse)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.cbbSupplier)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.cbbStatus)
        Me.groupBox1.Controls.Add(Me.cbbCategory)
        Me.groupBox1.Controls.Add(Me.txtPrice)
        Me.groupBox1.Controls.Add(Me.txtUnitPrice)
        Me.groupBox1.Controls.Add(Me.txtDiscount)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.txtCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Location = New System.Drawing.Point(55, 110)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(854, 385)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail"
        '
        'txtUnitDiscount
        '
        Me.txtUnitDiscount.Enabled = False
        Me.txtUnitDiscount.Location = New System.Drawing.Point(750, 183)
        Me.txtUnitDiscount.Name = "txtUnitDiscount"
        Me.txtUnitDiscount.Size = New System.Drawing.Size(53, 26)
        Me.txtUnitDiscount.TabIndex = 22
        Me.txtUnitDiscount.Text = "$"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(570, 249)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(164, 26)
        Me.txtNumber.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(423, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Number"
        '
        'cbbWarehouse
        '
        Me.cbbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbWarehouse.FormattingEnabled = True
        Me.cbbWarehouse.Location = New System.Drawing.Point(172, 51)
        Me.cbbWarehouse.Name = "cbbWarehouse"
        Me.cbbWarehouse.Size = New System.Drawing.Size(164, 28)
        Me.cbbWarehouse.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Warehouse"
        '
        'cbbSupplier
        '
        Me.cbbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSupplier.FormattingEnabled = True
        Me.cbbSupplier.Location = New System.Drawing.Point(172, 318)
        Me.cbbSupplier.Name = "cbbSupplier"
        Me.cbbSupplier.Size = New System.Drawing.Size(172, 28)
        Me.cbbSupplier.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Supplier"
        '
        'cbbStatus
        '
        Me.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbStatus.FormattingEnabled = True
        Me.cbbStatus.Location = New System.Drawing.Point(570, 115)
        Me.cbbStatus.Name = "cbbStatus"
        Me.cbbStatus.Size = New System.Drawing.Size(164, 28)
        Me.cbbStatus.TabIndex = 15
        '
        'cbbCategory
        '
        Me.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbCategory.FormattingEnabled = True
        Me.cbbCategory.Location = New System.Drawing.Point(172, 249)
        Me.cbbCategory.Name = "cbbCategory"
        Me.cbbCategory.Size = New System.Drawing.Size(172, 28)
        Me.cbbCategory.TabIndex = 14
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(570, 54)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(164, 26)
        Me.txtPrice.TabIndex = 13
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Enabled = False
        Me.txtUnitPrice.Location = New System.Drawing.Point(750, 55)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(53, 26)
        Me.txtUnitPrice.TabIndex = 15
        Me.txtUnitPrice.Text = "$"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(570, 183)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(164, 26)
        Me.txtDiscount.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(172, 182)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(172, 115)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(103, 26)
        Me.txtCode.TabIndex = 2
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(549, 522)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(150, 55)
        Me.bSave.TabIndex = 19
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bClearAll
        '
        Me.bClearAll.BackColor = System.Drawing.Color.SandyBrown
        Me.bClearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bClearAll.Image = CType(resources.GetObject("bClearAll.Image"), System.Drawing.Image)
        Me.bClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bClearAll.Location = New System.Drawing.Point(330, 522)
        Me.bClearAll.Name = "bClearAll"
        Me.bClearAll.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bClearAll.Size = New System.Drawing.Size(150, 55)
        Me.bClearAll.TabIndex = 20
        Me.bClearAll.Text = "Clear all"
        Me.bClearAll.UseVisualStyleBackColor = False
        '
        'AddEditProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 589)
        Me.Controls.Add(Me.bClearAll)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.labTitle)
        Me.Name = "AddEditProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Category"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private labTitle As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtDiscount As System.Windows.Forms.TextBox
    Private txtName As System.Windows.Forms.TextBox
    Private txtCode As System.Windows.Forms.TextBox
    Private cbbCategory As System.Windows.Forms.ComboBox
    Private txtPrice As System.Windows.Forms.TextBox
    Private WithEvents txtUnitPrice As TextBox
    Private WithEvents cbbStatus As ComboBox
    Private WithEvents bSave As Button
    Private WithEvents cbbSupplier As ComboBox
    Private WithEvents Label8 As Label
    Private WithEvents txtNumber As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents cbbWarehouse As ComboBox
    Private WithEvents Label9 As Label
    Private WithEvents txtUnitDiscount As TextBox
    Private WithEvents bClearAll As Button
End Class
