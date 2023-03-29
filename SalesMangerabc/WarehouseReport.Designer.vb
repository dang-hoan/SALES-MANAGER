<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WarehouseReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseReport))
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(219, 142)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Warehouse"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(343, 74)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(134, 33)
        Me.comboBox1.TabIndex = 1
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(223, 30)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(103, 104)
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImage = CType(resources.GetObject("pictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(609, 41)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(81, 79)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'comboBox2
        '
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(723, 74)
        Me.comboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(134, 33)
        Me.comboBox2.TabIndex = 6
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(619, 142)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(74, 25)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Product"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(41, 104)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(162, 26)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Total products"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(82, 24)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(91, 64)
        Me.label4.TabIndex = 9
        Me.label4.Text = "17"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1.Location = New System.Drawing.Point(76, 190)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(264, 161)
        Me.panel1.TabIndex = 14
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.label9)
        Me.panel2.Controls.Add(Me.label10)
        Me.panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel2.Location = New System.Drawing.Point(412, 190)
        Me.panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(264, 161)
        Me.panel2.TabIndex = 15
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label9.ForeColor = System.Drawing.Color.Red
        Me.label9.Location = New System.Drawing.Point(82, 24)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(91, 64)
        Me.label9.TabIndex = 9
        Me.label9.Text = "17"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label10.ForeColor = System.Drawing.Color.Red
        Me.label10.Location = New System.Drawing.Point(26, 104)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(192, 26)
        Me.label10.TabIndex = 8
        Me.label10.Text = "Remain products"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Controls.Add(Me.label11)
        Me.panel3.Controls.Add(Me.label12)
        Me.panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel3.Location = New System.Drawing.Point(737, 190)
        Me.panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(264, 161)
        Me.panel3.TabIndex = 15
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(82, 24)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(91, 64)
        Me.label11.TabIndex = 9
        Me.label11.Text = "17"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label12.Location = New System.Drawing.Point(62, 104)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(127, 26)
        Me.label12.TabIndex = 8
        Me.label12.Text = "Total sales"
        '
        'WarehouseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 958)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WarehouseReport"
        Me.Text = "Warehouse report"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private label1 As System.Windows.Forms.Label
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Private pictureBox2 As System.Windows.Forms.PictureBox
    Private comboBox2 As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private panel1 As System.Windows.Forms.Panel
    Private panel2 As System.Windows.Forms.Panel
    Private label9 As System.Windows.Forms.Label
    Private label10 As System.Windows.Forms.Label
    Private panel3 As System.Windows.Forms.Panel
    Private label11 As System.Windows.Forms.Label
    Private label12 As System.Windows.Forms.Label
End Class
