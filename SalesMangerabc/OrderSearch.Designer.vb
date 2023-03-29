<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderSearch))
        Me.bSave = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.Image = CType(resources.GetObject("bSave.Image"), System.Drawing.Image)
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(393, 284)
        Me.bSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(154, 60)
        Me.bSave.TabIndex = 5
        Me.bSave.Text = "Search"
        Me.bSave.UseVisualStyleBackColor = False
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
        Me.label2.Size = New System.Drawing.Size(102, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Order code"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(488, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(138, 25)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Customer name"
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
        Me.label5.Size = New System.Drawing.Size(98, 25)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Order date"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(488, 225)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(99, 25)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Ship status"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.dateTimePicker2)
        Me.groupBox1.Controls.Add(Me.dateTimePicker1)
        Me.groupBox1.Controls.Add(Me.textBox7)
        Me.groupBox1.Controls.Add(Me.bSave)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.comboBox1)
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
        Me.groupBox1.Location = New System.Drawing.Point(60, 49)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Size = New System.Drawing.Size(948, 369)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Search"
        '
        'dateTimePicker2
        '
        Me.dateTimePicker2.Location = New System.Drawing.Point(651, 168)
        Me.dateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateTimePicker2.Name = "dateTimePicker2"
        Me.dateTimePicker2.Size = New System.Drawing.Size(242, 31)
        Me.dateTimePicker2.TabIndex = 19
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(651, 118)
        Me.dateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(242, 31)
        Me.dateTimePicker1.TabIndex = 2
        '
        'textBox7
        '
        Me.textBox7.Enabled = False
        Me.textBox7.Location = New System.Drawing.Point(180, 218)
        Me.textBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(241, 31)
        Me.textBox7.TabIndex = 18
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(488, 171)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(87, 25)
        Me.label8.TabIndex = 16
        Me.label8.Text = "Ship date"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(31, 225)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(139, 25)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Employee name"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(180, 164)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(191, 33)
        Me.comboBox1.TabIndex = 14
        '
        'textBox6
        '
        Me.textBox6.Enabled = False
        Me.textBox6.Location = New System.Drawing.Point(651, 218)
        Me.textBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(242, 31)
        Me.textBox6.TabIndex = 0
        '
        'textBox5
        '
        Me.textBox5.Enabled = False
        Me.textBox5.Location = New System.Drawing.Point(651, 64)
        Me.textBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(242, 31)
        Me.textBox5.TabIndex = 8
        '
        'textBox3
        '
        Me.textBox3.Enabled = False
        Me.textBox3.Location = New System.Drawing.Point(180, 110)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(241, 31)
        Me.textBox3.TabIndex = 6
        '
        'textBox1
        '
        Me.textBox1.Enabled = False
        Me.textBox1.Location = New System.Drawing.Point(180, 56)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(114, 31)
        Me.textBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(60, 446)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(948, 461)
        Me.DataGridView1.TabIndex = 1
        '
        'OrderSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1077, 958)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.groupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrderSearch"
        Me.Text = "Search Order"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private bSave As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private textBox6 As System.Windows.Forms.TextBox
    Private textBox3 As System.Windows.Forms.TextBox
    Private textBox1 As System.Windows.Forms.TextBox
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label8 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label
    Private textBox7 As System.Windows.Forms.TextBox
    Private dateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private textBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
