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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbbWarehouse = New System.Windows.Forms.ComboBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbbProduct = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.labTotalProducts = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.labRemainProducts = New System.Windows.Forms.Label()
        Me.labelRemain = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.labTotalSales = New System.Windows.Forms.Label()
        Me.labelSales = New System.Windows.Forms.Label()
        Me.chartReport = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.chartReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(197, 114)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Warehouse"
        '
        'cbbWarehouse
        '
        Me.cbbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbWarehouse.FormattingEnabled = True
        Me.cbbWarehouse.Location = New System.Drawing.Point(309, 59)
        Me.cbbWarehouse.Name = "cbbWarehouse"
        Me.cbbWarehouse.Size = New System.Drawing.Size(188, 28)
        Me.cbbWarehouse.TabIndex = 1
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(201, 24)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(93, 83)
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImage = CType(resources.GetObject("pictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(548, 33)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(73, 63)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'cbbProduct
        '
        Me.cbbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProduct.FormattingEnabled = True
        Me.cbbProduct.Location = New System.Drawing.Point(651, 59)
        Me.cbbProduct.Name = "cbbProduct"
        Me.cbbProduct.Size = New System.Drawing.Size(196, 28)
        Me.cbbProduct.TabIndex = 6
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(557, 114)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 20)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Product"
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.labelTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelTotal.Location = New System.Drawing.Point(37, 74)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(162, 26)
        Me.labelTotal.TabIndex = 8
        Me.labelTotal.Text = "Total products"
        '
        'labTotalProducts
        '
        Me.labTotalProducts.AutoSize = True
        Me.labTotalProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labTotalProducts.Location = New System.Drawing.Point(74, 19)
        Me.labTotalProducts.Name = "labTotalProducts"
        Me.labTotalProducts.Size = New System.Drawing.Size(66, 46)
        Me.labTotalProducts.TabIndex = 9
        Me.labTotalProducts.Text = "17"
        Me.labTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.labTotalProducts)
        Me.panel1.Controls.Add(Me.labelTotal)
        Me.panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel1.Location = New System.Drawing.Point(68, 152)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(238, 129)
        Me.panel1.TabIndex = 14
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.labRemainProducts)
        Me.panel2.Controls.Add(Me.labelRemain)
        Me.panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel2.Location = New System.Drawing.Point(371, 152)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(238, 129)
        Me.panel2.TabIndex = 15
        '
        'labRemainProducts
        '
        Me.labRemainProducts.AutoSize = True
        Me.labRemainProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRemainProducts.ForeColor = System.Drawing.Color.Red
        Me.labRemainProducts.Location = New System.Drawing.Point(74, 19)
        Me.labRemainProducts.Name = "labRemainProducts"
        Me.labRemainProducts.Size = New System.Drawing.Size(66, 46)
        Me.labRemainProducts.TabIndex = 9
        Me.labRemainProducts.Text = "17"
        Me.labRemainProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelRemain
        '
        Me.labelRemain.AutoSize = True
        Me.labelRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.labelRemain.ForeColor = System.Drawing.Color.Red
        Me.labelRemain.Location = New System.Drawing.Point(22, 74)
        Me.labelRemain.Name = "labelRemain"
        Me.labelRemain.Size = New System.Drawing.Size(192, 26)
        Me.labelRemain.TabIndex = 8
        Me.labelRemain.Text = "Remain products"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Controls.Add(Me.labTotalSales)
        Me.panel3.Controls.Add(Me.labelSales)
        Me.panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel3.Location = New System.Drawing.Point(663, 152)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(238, 129)
        Me.panel3.TabIndex = 15
        '
        'labTotalSales
        '
        Me.labTotalSales.AutoSize = True
        Me.labTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labTotalSales.Location = New System.Drawing.Point(74, 19)
        Me.labTotalSales.Name = "labTotalSales"
        Me.labTotalSales.Size = New System.Drawing.Size(66, 46)
        Me.labTotalSales.TabIndex = 9
        Me.labTotalSales.Text = "17"
        Me.labTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelSales
        '
        Me.labelSales.AutoSize = True
        Me.labelSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.labelSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelSales.Location = New System.Drawing.Point(55, 74)
        Me.labelSales.Name = "labelSales"
        Me.labelSales.Size = New System.Drawing.Size(127, 26)
        Me.labelSales.TabIndex = 8
        Me.labelSales.Text = "Total sales"
        '
        'chartReport
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartReport.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartReport.Legends.Add(Legend1)
        Me.chartReport.Location = New System.Drawing.Point(68, 322)
        Me.chartReport.Name = "chartReport"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartReport.Series.Add(Series1)
        Me.chartReport.Size = New System.Drawing.Size(833, 388)
        Me.chartReport.TabIndex = 16
        Me.chartReport.Text = "Chart1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Location = New System.Drawing.Point(240, 739)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 32)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Chart showing sales over the years"
        '
        'WarehouseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 816)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chartReport)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.cbbProduct)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.cbbWarehouse)
        Me.Controls.Add(Me.label1)
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
        CType(Me.chartReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private label1 As System.Windows.Forms.Label
    Private WithEvents cbbWarehouse As System.Windows.Forms.ComboBox
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Private pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents cbbProduct As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private labelTotal As System.Windows.Forms.Label
    Private labTotalProducts As System.Windows.Forms.Label
    Private panel1 As System.Windows.Forms.Panel
    Private panel2 As System.Windows.Forms.Panel
    Private labRemainProducts As System.Windows.Forms.Label
    Private labelRemain As System.Windows.Forms.Label
    Private panel3 As System.Windows.Forms.Panel
    Private labTotalSales As System.Windows.Forms.Label
    Private labelSales As System.Windows.Forms.Label
    Friend WithEvents chartReport As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
End Class
