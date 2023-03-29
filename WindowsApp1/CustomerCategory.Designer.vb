<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerCategory
                                                                                                                             ))
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(38, 109)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(138, 25)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Customer name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(38, 55)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(133, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Customer code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Blue
        Me.label3.Location = New System.Drawing.Point(519, 62)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 25)
        Me.label3.TabIndex = 3
        Me.label3.Text = "BirthDay"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(38, 166)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(69, 25)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Gender"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(519, 120)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(62, 25)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Phone"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(519, 166)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(77, 25)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Address"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(316, 45)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(404, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "CUSTOMER CATEGORY"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rdFemale)
        Me.groupBox1.Controls.Add(Me.rdMale)
        Me.groupBox1.Controls.Add(Me.dateTimePicker1)
        Me.groupBox1.Controls.Add(Me.textBox6)
        Me.groupBox1.Controls.Add(Me.textBox5)
        Me.groupBox1.Controls.Add(Me.textBox3)
        Me.groupBox1.Controls.Add(Me.textBox1)
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
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.ForeColor = System.Drawing.Color.Blue
        Me.rdFemale.Location = New System.Drawing.Point(300, 164)
        Me.rdFemale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(93, 29)
        Me.rdFemale.TabIndex = 11
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.ForeColor = System.Drawing.Color.Blue
        Me.rdMale.Location = New System.Drawing.Point(189, 164)
        Me.rdMale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(75, 29)
        Me.rdMale.TabIndex = 10
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(619, 62)
        Me.dateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(258, 31)
        Me.dateTimePicker1.TabIndex = 4
        '
        'textBox6
        '
        Me.textBox6.Enabled = False
        Me.textBox6.Location = New System.Drawing.Point(619, 166)
        Me.textBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(258, 31)
        Me.textBox6.TabIndex = 0
        '
        'textBox5
        '
        Me.textBox5.Enabled = False
        Me.textBox5.Location = New System.Drawing.Point(619, 116)
        Me.textBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(258, 31)
        Me.textBox5.TabIndex = 8
        '
        'textBox3
        '
        Me.textBox3.Enabled = False
        Me.textBox3.Location = New System.Drawing.Point(189, 109)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(258, 31)
        Me.textBox3.TabIndex = 6
        '
        'textBox1
        '
        Me.textBox1.Enabled = False
        Me.textBox1.Location = New System.Drawing.Point(189, 55)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(114, 31)
        Me.textBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(60, 384)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(948, 442)
        Me.DataGridView1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1077, 958)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bDelete)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.label7)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private rdFemale As System.Windows.Forms.RadioButton
    Private rdMale As System.Windows.Forms.RadioButton
    Private textBox6 As System.Windows.Forms.TextBox
    Private textBox5 As System.Windows.Forms.TextBox
    Private textBox3 As System.Windows.Forms.TextBox
    Private textBox1 As System.Windows.Forms.TextBox
    Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
End Class
