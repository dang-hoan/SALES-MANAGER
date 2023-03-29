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
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.label14 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.comboBox3 = New System.Windows.Forms.ComboBox()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.comboBox4 = New System.Windows.Forms.ComboBox()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.textBox9 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(570, 866)
        Me.bSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(154, 60)
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
        Me.bCancel.Location = New System.Drawing.Point(330, 866)
        Me.bCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bCancel.Size = New System.Drawing.Size(154, 60)
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
        Me.bPrint.Location = New System.Drawing.Point(810, 866)
        Me.bPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bPrint.Size = New System.Drawing.Size(154, 60)
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
        Me.bAdd.Location = New System.Drawing.Point(112, 866)
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
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.ForeColor = System.Drawing.Color.Blue
        Me.label1.Location = New System.Drawing.Point(31, 114)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(133, 25)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Customer code"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.White
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(31, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(102, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Order code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.White
        Me.label3.ForeColor = System.Drawing.Color.Blue
        Me.label3.Location = New System.Drawing.Point(503, 168)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(114, 25)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Ship address"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.White
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(503, 114)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(87, 25)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Ship date"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.White
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(31, 168)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(138, 25)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Customer name"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.White
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(503, 218)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(99, 25)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Ship status"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label7.ForeColor = System.Drawing.Color.Blue
        Me.label7.Location = New System.Drawing.Point(408, 39)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(253, 37)
        Me.label7.TabIndex = 8
        Me.label7.Text = "SALES ORDER"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.comboBox1)
        Me.groupBox1.Controls.Add(Me.label15)
        Me.groupBox1.Controls.Add(Me.dateTimePicker2)
        Me.groupBox1.Controls.Add(Me.label14)
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Controls.Add(Me.comboBox3)
        Me.groupBox1.Controls.Add(Me.dateTimePicker1)
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
        Me.groupBox1.Size = New System.Drawing.Size(948, 268)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail order"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(182, 218)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(166, 33)
        Me.comboBox1.TabIndex = 21
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.BackColor = System.Drawing.Color.White
        Me.label15.ForeColor = System.Drawing.Color.Blue
        Me.label15.Location = New System.Drawing.Point(31, 221)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(134, 25)
        Me.label15.TabIndex = 20
        Me.label15.Text = "Employee code"
        '
        'dateTimePicker2
        '
        Me.dateTimePicker2.Location = New System.Drawing.Point(651, 49)
        Me.dateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateTimePicker2.Name = "dateTimePicker2"
        Me.dateTimePicker2.Size = New System.Drawing.Size(258, 31)
        Me.dateTimePicker2.TabIndex = 19
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.Color.White
        Me.label14.ForeColor = System.Drawing.Color.Blue
        Me.label14.Location = New System.Drawing.Point(503, 56)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(98, 25)
        Me.label14.TabIndex = 18
        Me.label14.Text = "Order date"
        '
        'textBox2
        '
        Me.textBox2.Enabled = False
        Me.textBox2.Location = New System.Drawing.Point(182, 168)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(166, 31)
        Me.textBox2.TabIndex = 17
        '
        'comboBox3
        '
        Me.comboBox3.FormattingEnabled = True
        Me.comboBox3.Location = New System.Drawing.Point(651, 216)
        Me.comboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBox3.Name = "comboBox3"
        Me.comboBox3.Size = New System.Drawing.Size(173, 33)
        Me.comboBox3.TabIndex = 16
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(651, 109)
        Me.dateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(258, 31)
        Me.dateTimePicker1.TabIndex = 15
        '
        'textBox5
        '
        Me.textBox5.Enabled = False
        Me.textBox5.Location = New System.Drawing.Point(651, 162)
        Me.textBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(258, 31)
        Me.textBox5.TabIndex = 8
        '
        'textBox3
        '
        Me.textBox3.Enabled = False
        Me.textBox3.Location = New System.Drawing.Point(182, 110)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(166, 31)
        Me.textBox3.TabIndex = 6
        '
        'textBox1
        '
        Me.textBox1.Enabled = False
        Me.textBox1.Location = New System.Drawing.Point(182, 56)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(166, 31)
        Me.textBox1.TabIndex = 2
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.comboBox4)
        Me.groupBox2.Controls.Add(Me.comboBox2)
        Me.groupBox2.Controls.Add(Me.textBox4)
        Me.groupBox2.Controls.Add(Me.textBox7)
        Me.groupBox2.Controls.Add(Me.textBox8)
        Me.groupBox2.Controls.Add(Me.textBox9)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Location = New System.Drawing.Point(60, 406)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Size = New System.Drawing.Size(948, 156)
        Me.groupBox2.TabIndex = 15
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Detail products"
        '
        'comboBox4
        '
        Me.comboBox4.FormattingEnabled = True
        Me.comboBox4.Location = New System.Drawing.Point(153, 41)
        Me.comboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBox4.Name = "comboBox4"
        Me.comboBox4.Size = New System.Drawing.Size(98, 33)
        Me.comboBox4.TabIndex = 15
        '
        'comboBox2
        '
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(153, 99)
        Me.comboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(98, 33)
        Me.comboBox2.TabIndex = 14
        '
        'textBox4
        '
        Me.textBox4.Enabled = False
        Me.textBox4.Location = New System.Drawing.Point(754, 45)
        Me.textBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(164, 31)
        Me.textBox4.TabIndex = 13
        '
        'textBox7
        '
        Me.textBox7.Enabled = False
        Me.textBox7.Location = New System.Drawing.Point(424, 99)
        Me.textBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(164, 31)
        Me.textBox7.TabIndex = 0
        '
        'textBox8
        '
        Me.textBox8.Enabled = False
        Me.textBox8.Location = New System.Drawing.Point(754, 99)
        Me.textBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New System.Drawing.Size(164, 31)
        Me.textBox8.TabIndex = 8
        '
        'textBox9
        '
        Me.textBox9.Enabled = False
        Me.textBox9.Location = New System.Drawing.Point(424, 45)
        Me.textBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New System.Drawing.Size(164, 31)
        Me.textBox9.TabIndex = 6
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.White
        Me.label8.ForeColor = System.Drawing.Color.Blue
        Me.label8.Location = New System.Drawing.Point(20, 49)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(118, 25)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Product code"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.White
        Me.label9.ForeColor = System.Drawing.Color.Blue
        Me.label9.Location = New System.Drawing.Point(298, 49)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(123, 25)
        Me.label9.TabIndex = 5
        Me.label9.Text = "Product name"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.White
        Me.label10.ForeColor = System.Drawing.Color.Blue
        Me.label10.Location = New System.Drawing.Point(20, 102)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(77, 25)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Number"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.White
        Me.label11.ForeColor = System.Drawing.Color.Blue
        Me.label11.Location = New System.Drawing.Point(298, 102)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(82, 25)
        Me.label11.TabIndex = 12
        Me.label11.Text = "Discount"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.BackColor = System.Drawing.Color.White
        Me.label12.ForeColor = System.Drawing.Color.Blue
        Me.label12.Location = New System.Drawing.Point(633, 45)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(117, 25)
        Me.label12.TabIndex = 3
        Me.label12.Text = "Product price"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.BackColor = System.Drawing.Color.White
        Me.label13.ForeColor = System.Drawing.Color.Blue
        Me.label13.Location = New System.Drawing.Point(633, 99)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(92, 25)
        Me.label13.TabIndex = 7
        Me.label13.Text = "Total price"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(60, 589)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(948, 250)
        Me.DataGridView1.TabIndex = 16
        '
        'SalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1077, 958)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.bPrint)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.label7)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SalesOrder"
        Me.Text = "Sales Order"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private bAdd As System.Windows.Forms.Button
        Private bPrint As System.Windows.Forms.Button
        Private bSave As System.Windows.Forms.Button
        Private bCancel As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private textBox5 As System.Windows.Forms.TextBox
    Private textBox3 As System.Windows.Forms.TextBox
    Private textBox1 As System.Windows.Forms.TextBox
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label15 As System.Windows.Forms.Label
    Private dateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private label14 As System.Windows.Forms.Label
    Private textBox2 As System.Windows.Forms.TextBox
    Private comboBox3 As System.Windows.Forms.ComboBox
    Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private comboBox2 As System.Windows.Forms.ComboBox
    Private textBox4 As System.Windows.Forms.TextBox
    Private textBox7 As System.Windows.Forms.TextBox
    Private textBox8 As System.Windows.Forms.TextBox
    Private textBox9 As System.Windows.Forms.TextBox
    Private label8 As System.Windows.Forms.Label
    Private label9 As System.Windows.Forms.Label
    Private label10 As System.Windows.Forms.Label
    Private label11 As System.Windows.Forms.Label
    Private label12 As System.Windows.Forms.Label
    Private label13 As System.Windows.Forms.Label
    Private comboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
