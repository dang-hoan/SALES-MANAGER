<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.categoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.employeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.productToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.orderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.supplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.inventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.salesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.AutoSize = False
        Me.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem2, Me.categoryToolStripMenuItem, Me.toolToolStripMenuItem, Me.reportToolStripMenuItem, Me.logoutToolStripMenuItem})
        Me.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(98, 958)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.AutoSize = False
        Me.toolStripMenuItem2.BackgroundImage = CType(resources.GetObject("toolStripMenuItem2.BackgroundImage"), System.Drawing.Image)
        Me.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.toolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1})
        Me.toolStripMenuItem2.Margin = New System.Windows.Forms.Padding(15)
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(70, 54)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(267, 6)
        '
        'categoryToolStripMenuItem
        '
        Me.categoryToolStripMenuItem.AutoSize = False
        Me.categoryToolStripMenuItem.BackgroundImage = CType(resources.GetObject("categoryToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.categoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.categoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.employeeToolStripMenuItem, Me.clientToolStripMenuItem, Me.toolStripMenuItem1, Me.productToolStripMenuItem, Me.orderToolStripMenuItem, Me.supplierToolStripMenuItem})
        Me.categoryToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15)
        Me.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem"
        Me.categoryToolStripMenuItem.Size = New System.Drawing.Size(70, 54)
        '
        'employeeToolStripMenuItem
        '
        Me.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem"
        Me.employeeToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.employeeToolStripMenuItem.Text = "Employee"
        '
        'clientToolStripMenuItem
        '
        Me.clientToolStripMenuItem.Name = "clientToolStripMenuItem"
        Me.clientToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.clientToolStripMenuItem.Text = "Client"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(267, 6)
        '
        'productToolStripMenuItem
        '
        Me.productToolStripMenuItem.Name = "productToolStripMenuItem"
        Me.productToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.productToolStripMenuItem.Text = "Product"
        '
        'orderToolStripMenuItem
        '
        Me.orderToolStripMenuItem.Name = "orderToolStripMenuItem"
        Me.orderToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.orderToolStripMenuItem.Text = "Order"
        '
        'supplierToolStripMenuItem
        '
        Me.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem"
        Me.supplierToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.supplierToolStripMenuItem.Text = "Supplier"
        '
        'toolToolStripMenuItem
        '
        Me.toolToolStripMenuItem.AutoSize = False
        Me.toolToolStripMenuItem.BackgroundImage = CType(resources.GetObject("toolToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.toolToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.toolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.searchToolStripMenuItem})
        Me.toolToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15)
        Me.toolToolStripMenuItem.Name = "toolToolStripMenuItem"
        Me.toolToolStripMenuItem.Size = New System.Drawing.Size(70, 54)
        '
        'searchToolStripMenuItem
        '
        Me.searchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.searchClientToolStripMenuItem, Me.searchProductToolStripMenuItem, Me.searchToolStripMenuItem1})
        Me.searchToolStripMenuItem.Name = "searchToolStripMenuItem"
        Me.searchToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
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
        'reportToolStripMenuItem
        '
        Me.reportToolStripMenuItem.AutoSize = False
        Me.reportToolStripMenuItem.BackgroundImage = CType(resources.GetObject("reportToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.reportToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.reportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inventoryToolStripMenuItem, Me.salesToolStripMenuItem})
        Me.reportToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15)
        Me.reportToolStripMenuItem.Name = "reportToolStripMenuItem"
        Me.reportToolStripMenuItem.Size = New System.Drawing.Size(70, 54)
        Me.reportToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'inventoryToolStripMenuItem
        '
        Me.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem"
        Me.inventoryToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.inventoryToolStripMenuItem.Text = "Inventory"
        '
        'salesToolStripMenuItem
        '
        Me.salesToolStripMenuItem.Name = "salesToolStripMenuItem"
        Me.salesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.salesToolStripMenuItem.Text = "Sales"
        '
        'logoutToolStripMenuItem
        '
        Me.logoutToolStripMenuItem.AutoSize = False
        Me.logoutToolStripMenuItem.BackgroundImage = CType(resources.GetObject("logoutToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.logoutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoutToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 520, 15, 15)
        Me.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem"
        Me.logoutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30)
        Me.logoutToolStripMenuItem.Size = New System.Drawing.Size(70, 54)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1077, 958)
        Me.Controls.Add(Me.menuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private menuStrip1 As System.Windows.Forms.MenuStrip
        Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private categoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private employeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private clientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Private productToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private orderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private supplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private toolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private searchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private searchClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private searchProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private searchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Private reportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private inventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private salesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private logoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
