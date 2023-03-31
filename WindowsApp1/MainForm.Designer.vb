<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCategoryCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.productToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.orderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.supplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStatistic = New System.Windows.Forms.ToolStripMenuItem()
        Me.inventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.salesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.srcMain = New System.Windows.Forms.Panel()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.AutoSize = False
        Me.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHome, Me.btnCategory, Me.btnTool, Me.btnStatistic, Me.btnExit})
        Me.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(6, 20, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(109, 825)
        Me.menuStrip1.Stretch = False
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'btnHome
        '
        Me.btnHome.AutoSize = False
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1})
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHome.Margin = New System.Windows.Forms.Padding(15)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(70, 80)
        Me.btnHome.Text = "Home"
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(87, 6)
        '
        'btnCategory
        '
        Me.btnCategory.AutoSize = False
        Me.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCategory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCategoryCustomer, Me.ToolStripMenuItem2, Me.toolStripMenuItem1, Me.productToolStripMenuItem, Me.orderToolStripMenuItem, Me.supplierToolStripMenuItem})
        Me.btnCategory.Image = CType(resources.GetObject("btnCategory.Image"), System.Drawing.Image)
        Me.btnCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCategory.Margin = New System.Windows.Forms.Padding(15)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(70, 80)
        Me.btnCategory.Text = "Category"
        Me.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCategoryCustomer
        '
        Me.btnCategoryCustomer.Name = "btnCategoryCustomer"
        Me.btnCategoryCustomer.Size = New System.Drawing.Size(192, 34)
        Me.btnCategoryCustomer.Text = "Customer"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(192, 34)
        Me.ToolStripMenuItem2.Text = "Employee"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(189, 6)
        '
        'productToolStripMenuItem
        '
        Me.productToolStripMenuItem.Name = "productToolStripMenuItem"
        Me.productToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.productToolStripMenuItem.Text = "Product"
        '
        'orderToolStripMenuItem
        '
        Me.orderToolStripMenuItem.Name = "orderToolStripMenuItem"
        Me.orderToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.orderToolStripMenuItem.Text = "Order"
        '
        'supplierToolStripMenuItem
        '
        Me.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem"
        Me.supplierToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.supplierToolStripMenuItem.Text = "Supplier"
        '
        'btnTool
        '
        Me.btnTool.AutoSize = False
        Me.btnTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.searchToolStripMenuItem})
        Me.btnTool.Image = CType(resources.GetObject("btnTool.Image"), System.Drawing.Image)
        Me.btnTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTool.Margin = New System.Windows.Forms.Padding(15)
        Me.btnTool.Name = "btnTool"
        Me.btnTool.Size = New System.Drawing.Size(70, 80)
        Me.btnTool.Text = "Tool"
        Me.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'searchToolStripMenuItem
        '
        Me.searchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.searchClientToolStripMenuItem, Me.searchProductToolStripMenuItem, Me.searchToolStripMenuItem1})
        Me.searchToolStripMenuItem.Name = "searchToolStripMenuItem"
        Me.searchToolStripMenuItem.Size = New System.Drawing.Size(166, 34)
        Me.searchToolStripMenuItem.Text = "Search"
        '
        'searchClientToolStripMenuItem
        '
        Me.searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem"
        Me.searchClientToolStripMenuItem.Size = New System.Drawing.Size(234, 34)
        Me.searchClientToolStripMenuItem.Text = "Search client"
        '
        'searchProductToolStripMenuItem
        '
        Me.searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem"
        Me.searchProductToolStripMenuItem.Size = New System.Drawing.Size(234, 34)
        Me.searchProductToolStripMenuItem.Text = "Search product"
        '
        'searchToolStripMenuItem1
        '
        Me.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1"
        Me.searchToolStripMenuItem1.Size = New System.Drawing.Size(234, 34)
        Me.searchToolStripMenuItem1.Text = "Search order "
        '
        'btnStatistic
        '
        Me.btnStatistic.AutoSize = False
        Me.btnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStatistic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inventoryToolStripMenuItem, Me.salesToolStripMenuItem})
        Me.btnStatistic.Image = CType(resources.GetObject("btnStatistic.Image"), System.Drawing.Image)
        Me.btnStatistic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnStatistic.Margin = New System.Windows.Forms.Padding(15)
        Me.btnStatistic.Name = "btnStatistic"
        Me.btnStatistic.Size = New System.Drawing.Size(70, 80)
        Me.btnStatistic.Text = "Statistic"
        Me.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'inventoryToolStripMenuItem
        '
        Me.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem"
        Me.inventoryToolStripMenuItem.Size = New System.Drawing.Size(189, 34)
        Me.inventoryToolStripMenuItem.Text = "Inventory"
        '
        'salesToolStripMenuItem
        '
        Me.salesToolStripMenuItem.Name = "salesToolStripMenuItem"
        Me.salesToolStripMenuItem.Size = New System.Drawing.Size(189, 34)
        Me.salesToolStripMenuItem.Text = "Sales"
        '
        'btnExit
        '
        Me.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExit.AutoSize = False
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExit.Margin = New System.Windows.Forms.Padding(15, 90, 15, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(30)
        Me.btnExit.Size = New System.Drawing.Size(70, 80)
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'srcMain
        '
        Me.srcMain.AutoSize = True
        Me.srcMain.Location = New System.Drawing.Point(112, 0)
        Me.srcMain.Name = "srcMain"
        Me.srcMain.Size = New System.Drawing.Size(991, 822)
        Me.srcMain.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1106, 825)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.srcMain)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private menuStrip1 As System.Windows.Forms.MenuStrip
    Private btnHome As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private btnCategory As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private productToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private orderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private supplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private btnTool As System.Windows.Forms.ToolStripMenuItem
    Private searchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private searchClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private searchProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private searchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private btnStatistic As System.Windows.Forms.ToolStripMenuItem
    Private inventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private salesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private btnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents srcMain As Panel
    Private WithEvents btnCategoryCustomer As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
