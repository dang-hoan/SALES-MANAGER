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
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbCategory = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(804, 866)
        Me.bSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(154, 60)
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
        Me.bDelete.Location = New System.Drawing.Point(331, 866)
        Me.bDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(154, 60)
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
        Me.bEdit.Location = New System.Drawing.Point(568, 866)
        Me.bEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bEdit.Size = New System.Drawing.Size(154, 60)
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
        Me.bAdd.Location = New System.Drawing.Point(117, 866)
        Me.bAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bAdd.Size = New System.Drawing.Size(132, 60)
        Me.bAdd.TabIndex = 2
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(31, 110)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(123, 25)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Product name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(118, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Product code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(488, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(117, 25)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Product price"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(31, 168)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(84, 25)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Category"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(488, 118)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(126, 25)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Product status"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(488, 168)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(146, 25)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Discount percent"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(349, 45)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(379, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "PRODUCT CATEGORY"
        '
        'dataGridView1
        '
        Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(60, 378)
        Me.dataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 62
        Me.dataGridView1.RowTemplate.Height = 28
        Me.dataGridView1.Size = New System.Drawing.Size(948, 462)
        Me.dataGridView1.TabIndex = 1
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
        Me.groupBox1.Location = New System.Drawing.Point(60, 121)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Size = New System.Drawing.Size(948, 235)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail"
        '
        'cbbCategory
        '
        Me.cbbCategory.FormattingEnabled = True
        Me.cbbCategory.Location = New System.Drawing.Point(158, 164)
        Me.cbbCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbbCategory.Name = "cbbCategory"
        Me.cbbCategory.Size = New System.Drawing.Size(191, 33)
        Me.cbbCategory.TabIndex = 14
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(651, 64)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(258, 31)
        Me.txtPrice.TabIndex = 13
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(651, 160)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(258, 31)
        Me.txtDiscount.TabIndex = 0
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(651, 110)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(258, 31)
        Me.txtStatus.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(158, 110)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(258, 31)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(158, 56)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(114, 31)
        Me.txtCode.TabIndex = 2
        '
        'ProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1077, 958)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.label7)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProductCategory"
        Me.Text = "Product Category"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private bAdd As System.Windows.Forms.Button
        Private bEdit As System.Windows.Forms.Button
        Private bSave As System.Windows.Forms.Button
        Private bDelete As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private dataGridView1 As System.Windows.Forms.DataGridView
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private txtDiscount As System.Windows.Forms.TextBox
        Private txtStatus As System.Windows.Forms.TextBox
        Private txtName As System.Windows.Forms.TextBox
        Private txtCode As System.Windows.Forms.TextBox
        Private cbbCategory As System.Windows.Forms.ComboBox
        Private txtPrice As System.Windows.Forms.TextBox

    End Class
