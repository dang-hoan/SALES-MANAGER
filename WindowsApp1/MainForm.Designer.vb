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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.btnHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnWarehouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEmployeeSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProductSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOrderSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDecentralization = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStatistic = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnInventoryReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalesReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.srcMain = New System.Windows.Forms.Panel()
        Me.panelWelcome = New System.Windows.Forms.Panel()
        Me.pictureMain = New System.Windows.Forms.PictureBox()
        Me.labHello = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menuStrip.SuspendLayout()
        Me.srcMain.SuspendLayout()
        Me.panelWelcome.SuspendLayout()
        CType(Me.pictureMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.AutoSize = False
        Me.menuStrip.BackColor = System.Drawing.Color.MediumAquamarine
        Me.menuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHome, Me.btnCategory, Me.btnTool, Me.btnStatistic, Me.btnExit})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.menuStrip.Size = New System.Drawing.Size(109, 825)
        Me.menuStrip.Stretch = False
        Me.menuStrip.TabIndex = 2
        Me.menuStrip.Text = "menuStrip1"
        '
        'btnHome
        '
        Me.btnHome.AutoSize = False
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1})
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(80, 100)
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.btnCategory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCustomer, Me.btnEmployee, Me.toolStripMenuItem1, Me.btnProduct, Me.btnOrder, Me.btnSupplier, Me.btnWarehouse})
        Me.btnCategory.Image = CType(resources.GetObject("btnCategory.Image"), System.Drawing.Image)
        Me.btnCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(80, 100)
        Me.btnCategory.Text = "Category"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCustomer
        '
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(202, 34)
        Me.btnCustomer.Text = "Customer"
        '
        'btnEmployee
        '
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(202, 34)
        Me.btnEmployee.Text = "Employee"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(199, 6)
        '
        'btnProduct
        '
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(202, 34)
        Me.btnProduct.Text = "Product"
        '
        'btnOrder
        '
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(202, 34)
        Me.btnOrder.Text = "Order"
        '
        'btnSupplier
        '
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(202, 34)
        Me.btnSupplier.Text = "Supplier"
        '
        'btnWarehouse
        '
        Me.btnWarehouse.Name = "btnWarehouse"
        Me.btnWarehouse.Size = New System.Drawing.Size(202, 34)
        Me.btnWarehouse.Text = "Warehouse"
        '
        'btnTool
        '
        Me.btnTool.AutoSize = False
        Me.btnTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.btnDecentralization})
        Me.btnTool.Image = CType(resources.GetObject("btnTool.Image"), System.Drawing.Image)
        Me.btnTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTool.Name = "btnTool"
        Me.btnTool.Size = New System.Drawing.Size(80, 100)
        Me.btnTool.Text = "Tool"
        Me.btnTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSearch
        '
        Me.btnSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEmployeeSearch, Me.btnProductSearch, Me.btnOrderSearch})
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(270, 34)
        Me.btnSearch.Text = "Search"
        '
        'btnEmployeeSearch
        '
        Me.btnEmployeeSearch.Name = "btnEmployeeSearch"
        Me.btnEmployeeSearch.Size = New System.Drawing.Size(270, 34)
        Me.btnEmployeeSearch.Text = "Search client"
        '
        'btnProductSearch
        '
        Me.btnProductSearch.Name = "btnProductSearch"
        Me.btnProductSearch.Size = New System.Drawing.Size(270, 34)
        Me.btnProductSearch.Text = "Search product"
        '
        'btnOrderSearch
        '
        Me.btnOrderSearch.Name = "btnOrderSearch"
        Me.btnOrderSearch.Size = New System.Drawing.Size(270, 34)
        Me.btnOrderSearch.Text = "Search order "
        '
        'btnDecentralization
        '
        Me.btnDecentralization.Name = "btnDecentralization"
        Me.btnDecentralization.Size = New System.Drawing.Size(270, 34)
        Me.btnDecentralization.Text = "Decentralization"
        '
        'btnStatistic
        '
        Me.btnStatistic.AutoSize = False
        Me.btnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStatistic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInventoryReport, Me.btnSalesReport})
        Me.btnStatistic.Image = CType(resources.GetObject("btnStatistic.Image"), System.Drawing.Image)
        Me.btnStatistic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnStatistic.Name = "btnStatistic"
        Me.btnStatistic.Size = New System.Drawing.Size(80, 100)
        Me.btnStatistic.Text = "Statistic"
        Me.btnStatistic.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnInventoryReport
        '
        Me.btnInventoryReport.Name = "btnInventoryReport"
        Me.btnInventoryReport.Size = New System.Drawing.Size(270, 34)
        Me.btnInventoryReport.Text = "Inventory"
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(270, 34)
        Me.btnSalesReport.Text = "Sales"
        '
        'btnExit
        '
        Me.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExit.AutoSize = False
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 100)
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'srcMain
        '
        Me.srcMain.AutoSize = True
        Me.srcMain.Controls.Add(Me.panelWelcome)
        Me.srcMain.Location = New System.Drawing.Point(112, 0)
        Me.srcMain.Name = "srcMain"
        Me.srcMain.Size = New System.Drawing.Size(995, 828)
        Me.srcMain.TabIndex = 3
        '
        'panelWelcome
        '
        Me.panelWelcome.Controls.Add(Me.pictureMain)
        Me.panelWelcome.Controls.Add(Me.labHello)
        Me.panelWelcome.Controls.Add(Me.Label1)
        Me.panelWelcome.Location = New System.Drawing.Point(0, 0)
        Me.panelWelcome.Name = "panelWelcome"
        Me.panelWelcome.Size = New System.Drawing.Size(992, 825)
        Me.panelWelcome.TabIndex = 3
        '
        'pictureMain
        '
        Me.pictureMain.Image = CType(resources.GetObject("pictureMain.Image"), System.Drawing.Image)
        Me.pictureMain.Location = New System.Drawing.Point(130, 173)
        Me.pictureMain.Name = "pictureMain"
        Me.pictureMain.Size = New System.Drawing.Size(725, 586)
        Me.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMain.TabIndex = 2
        Me.pictureMain.TabStop = False
        '
        'labHello
        '
        Me.labHello.AutoSize = True
        Me.labHello.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHello.ForeColor = System.Drawing.Color.Green
        Me.labHello.Location = New System.Drawing.Point(42, 41)
        Me.labHello.Name = "labHello"
        Me.labHello.Size = New System.Drawing.Size(204, 38)
        Me.labHello.TabIndex = 1
        Me.labHello.Text = "Hello Hoan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lemon", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(37, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(942, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to sales manager app!!"
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
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.srcMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.srcMain.ResumeLayout(False)
        Me.panelWelcome.ResumeLayout(False)
        Me.panelWelcome.PerformLayout()
        CType(Me.pictureMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private menuStrip As System.Windows.Forms.MenuStrip
    Private WithEvents btnHome As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private btnCategory As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnProduct As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents srcMain As Panel
    Private WithEvents btnCustomer As ToolStripMenuItem
    Private WithEvents btnEmployee As ToolStripMenuItem
    Private WithEvents btnOrder As ToolStripMenuItem
    Private WithEvents btnTool As ToolStripMenuItem
    Private WithEvents btnSearch As ToolStripMenuItem
    Private WithEvents btnEmployeeSearch As ToolStripMenuItem
    Private WithEvents btnProductSearch As ToolStripMenuItem
    Private WithEvents btnOrderSearch As ToolStripMenuItem
    Private WithEvents btnStatistic As ToolStripMenuItem
    Private WithEvents btnInventoryReport As ToolStripMenuItem
    Private WithEvents btnSalesReport As ToolStripMenuItem
    Private WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents pictureMain As PictureBox
    Friend WithEvents labHello As Label
    Friend WithEvents panelWelcome As Panel
    Friend WithEvents btnWarehouse As ToolStripMenuItem
    Friend WithEvents btnDecentralization As ToolStripMenuItem
End Class
