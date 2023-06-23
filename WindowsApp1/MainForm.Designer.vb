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
        Me.bHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.bCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.bEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.bOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.bSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.bWarehouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.bDecentralize = New System.Windows.Forms.ToolStripMenuItem()
        Me.bStatistic = New System.Windows.Forms.ToolStripMenuItem()
        Me.bExit = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bHome, Me.bCategory, Me.bDecentralize, Me.bStatistic, Me.bExit})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.menuStrip.Size = New System.Drawing.Size(109, 825)
        Me.menuStrip.Stretch = False
        Me.menuStrip.TabIndex = 2
        Me.menuStrip.Text = "menuStrip1"
        '
        'bHome
        '
        Me.bHome.AutoSize = False
        Me.bHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1})
        Me.bHome.Image = CType(resources.GetObject("bHome.Image"), System.Drawing.Image)
        Me.bHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bHome.Name = "bHome"
        Me.bHome.Size = New System.Drawing.Size(80, 100)
        Me.bHome.Text = "Home"
        Me.bHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(267, 6)
        '
        'bCategory
        '
        Me.bCategory.AutoSize = False
        Me.bCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bCategory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bCustomer, Me.bEmployee, Me.toolStripMenuItem1, Me.bProduct, Me.bOrder, Me.bSupplier, Me.bWarehouse})
        Me.bCategory.Image = CType(resources.GetObject("bCategory.Image"), System.Drawing.Image)
        Me.bCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bCategory.Name = "bCategory"
        Me.bCategory.Size = New System.Drawing.Size(80, 100)
        Me.bCategory.Text = "Category"
        Me.bCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bCustomer
        '
        Me.bCustomer.Name = "bCustomer"
        Me.bCustomer.Size = New System.Drawing.Size(270, 34)
        Me.bCustomer.Text = "Customer"
        '
        'bEmployee
        '
        Me.bEmployee.Name = "bEmployee"
        Me.bEmployee.Size = New System.Drawing.Size(270, 34)
        Me.bEmployee.Text = "Employee"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(267, 6)
        '
        'bProduct
        '
        Me.bProduct.Name = "bProduct"
        Me.bProduct.Size = New System.Drawing.Size(270, 34)
        Me.bProduct.Text = "Product"
        '
        'bOrder
        '
        Me.bOrder.Name = "bOrder"
        Me.bOrder.Size = New System.Drawing.Size(270, 34)
        Me.bOrder.Text = "Order"
        '
        'bSupplier
        '
        Me.bSupplier.Name = "bSupplier"
        Me.bSupplier.Size = New System.Drawing.Size(270, 34)
        Me.bSupplier.Text = "Supplier"
        '
        'bWarehouse
        '
        Me.bWarehouse.Name = "bWarehouse"
        Me.bWarehouse.Size = New System.Drawing.Size(270, 34)
        Me.bWarehouse.Text = "Warehouse"
        '
        'bDecentralize
        '
        Me.bDecentralize.AutoSize = False
        Me.bDecentralize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bDecentralize.Image = CType(resources.GetObject("bDecentralize.Image"), System.Drawing.Image)
        Me.bDecentralize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bDecentralize.Name = "bDecentralize"
        Me.bDecentralize.Size = New System.Drawing.Size(80, 100)
        Me.bDecentralize.Text = "Decentralize"
        Me.bDecentralize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bDecentralize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bStatistic
        '
        Me.bStatistic.AutoSize = False
        Me.bStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bStatistic.Image = CType(resources.GetObject("bStatistic.Image"), System.Drawing.Image)
        Me.bStatistic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bStatistic.Name = "bStatistic"
        Me.bStatistic.Size = New System.Drawing.Size(80, 100)
        Me.bStatistic.Text = "Statistic"
        Me.bStatistic.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bExit
        '
        Me.bExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bExit.AutoSize = False
        Me.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bExit.Image = CType(resources.GetObject("bExit.Image"), System.Drawing.Image)
        Me.bExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(80, 100)
        Me.bExit.Text = "Exit"
        Me.bExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
    Private WithEvents bHome As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private bCategory As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents bProduct As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents bSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents srcMain As Panel
    Private WithEvents bCustomer As ToolStripMenuItem
    Private WithEvents bEmployee As ToolStripMenuItem
    Private WithEvents bOrder As ToolStripMenuItem
    Private WithEvents bDecentralize As ToolStripMenuItem
    Private WithEvents bStatistic As ToolStripMenuItem
    Private WithEvents bExit As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents pictureMain As PictureBox
    Friend WithEvents labHello As Label
    Friend WithEvents panelWelcome As Panel
    Friend WithEvents bWarehouse As ToolStripMenuItem
End Class
