<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierInformation))
        Me.bSave = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.labTitle = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWebpage = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ds_Supplier = New LibraryDataset.Supplier()
        Me.groupBox1.SuspendLayout()
        CType(Me.ds_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(627, 468)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(150, 55)
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
        Me.bDelete.Location = New System.Drawing.Point(409, 468)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bDelete.Size = New System.Drawing.Size(150, 55)
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
        Me.bEdit.Location = New System.Drawing.Point(191, 468)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bEdit.Size = New System.Drawing.Size(150, 55)
        Me.bEdit.TabIndex = 4
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(30, 112)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(120, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Company name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(30, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(106, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Supplier code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Blue
        Me.label3.Location = New System.Drawing.Point(483, 269)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(78, 20)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Webpage"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(484, 115)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 20)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Phone"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(485, 187)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(68, 20)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Address"
        '
        'labTitle
        '
        Me.labTitle.AutoSize = True
        Me.labTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labTitle.ForeColor = System.Drawing.Color.Blue
        Me.labTitle.Location = New System.Drawing.Point(272, 36)
        Me.labTitle.Name = "labTitle"
        Me.labTitle.Size = New System.Drawing.Size(425, 37)
        Me.labTitle.TabIndex = 8
        Me.labTitle.Text = "SUPPLIER INFORMATION"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtDescription)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.txtWebpage)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.txtAddress)
        Me.groupBox1.Controls.Add(Me.txtPhone)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.txtCode)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.Label11)
        Me.groupBox1.Controls.Add(Me.Label12)
        Me.groupBox1.Controls.Add(Me.Label13)
        Me.groupBox1.Location = New System.Drawing.Point(54, 97)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(853, 345)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(166, 187)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(279, 72)
        Me.txtDescription.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(30, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Description"
        '
        'txtWebpage
        '
        Me.txtWebpage.Enabled = False
        Me.txtWebpage.Location = New System.Drawing.Point(573, 266)
        Me.txtWebpage.Name = "txtWebpage"
        Me.txtWebpage.Size = New System.Drawing.Size(233, 26)
        Me.txtWebpage.TabIndex = 17
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(574, 34)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(233, 26)
        Me.txtEmail.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(486, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Email"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(573, 187)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtAddress.TabIndex = 0
        '
        'txtPhone
        '
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(574, 112)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(233, 26)
        Me.txtPhone.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(166, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 26)
        Me.txtName.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(166, 34)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(103, 26)
        Me.txtCode.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(530, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(534, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 26)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(546, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 26)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(143, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 26)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "*"
        '
        'ds_Supplier
        '
        Me.ds_Supplier.DataSetName = "Supplier"
        Me.ds_Supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 550)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.labTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SupplierInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.ds_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bEdit As System.Windows.Forms.Button
    Private WithEvents bSave As System.Windows.Forms.Button
    Private WithEvents bDelete As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private labTitle As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtAddress As System.Windows.Forms.TextBox
    Private txtPhone As System.Windows.Forms.TextBox
    Private txtName As System.Windows.Forms.TextBox
    Private txtCode As System.Windows.Forms.TextBox
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents txtEmail As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents txtWebpage As TextBox
    Private WithEvents txtDescription As TextBox
    Private WithEvents Label4 As Label
    Friend WithEvents ds_Supplier As LibraryDataset.Supplier
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
