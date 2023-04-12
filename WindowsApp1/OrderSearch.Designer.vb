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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSearchByShipDate = New System.Windows.Forms.CheckBox()
        Me.cbSearchByOrderDate = New System.Windows.Forms.CheckBox()
        Me.txtPaymentMethod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbbShipper = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.dtOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.cbbShipStatus = New System.Windows.Forms.ComboBox()
        Me.dtShipDate = New System.Windows.Forms.DateTimePicker()
        Me.txtShipAddress = New System.Windows.Forms.TextBox()
        Me.txtOrderCode = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.dgvOrderSearch = New System.Windows.Forms.DataGridView()
        Me.groupBox1.SuspendLayout()
        CType(Me.dgvOrderSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(357, 256)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSearch.Size = New System.Drawing.Size(139, 48)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbSearchByShipDate)
        Me.groupBox1.Controls.Add(Me.cbSearchByOrderDate)
        Me.groupBox1.Controls.Add(Me.txtPaymentMethod)
        Me.groupBox1.Controls.Add(Me.Label12)
        Me.groupBox1.Controls.Add(Me.cbbShipper)
        Me.groupBox1.Controls.Add(Me.label15)
        Me.groupBox1.Controls.Add(Me.dtOrderDate)
        Me.groupBox1.Controls.Add(Me.label14)
        Me.groupBox1.Controls.Add(Me.txtCustomerName)
        Me.groupBox1.Controls.Add(Me.cbbShipStatus)
        Me.groupBox1.Controls.Add(Me.dtShipDate)
        Me.groupBox1.Controls.Add(Me.txtShipAddress)
        Me.groupBox1.Controls.Add(Me.txtOrderCode)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.btnSearch)
        Me.groupBox1.Location = New System.Drawing.Point(54, 41)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(853, 323)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Search"
        '
        'cbSearchByShipDate
        '
        Me.cbSearchByShipDate.AutoSize = True
        Me.cbSearchByShipDate.Location = New System.Drawing.Point(466, 99)
        Me.cbSearchByShipDate.Name = "cbSearchByShipDate"
        Me.cbSearchByShipDate.Size = New System.Drawing.Size(106, 24)
        Me.cbSearchByShipDate.TabIndex = 41
        Me.cbSearchByShipDate.Text = "Search by"
        Me.cbSearchByShipDate.UseVisualStyleBackColor = True
        '
        'cbSearchByOrderDate
        '
        Me.cbSearchByOrderDate.AutoSize = True
        Me.cbSearchByOrderDate.Location = New System.Drawing.Point(466, 28)
        Me.cbSearchByOrderDate.Name = "cbSearchByOrderDate"
        Me.cbSearchByOrderDate.Size = New System.Drawing.Size(106, 24)
        Me.cbSearchByOrderDate.TabIndex = 40
        Me.cbSearchByOrderDate.Text = "Search by"
        Me.cbSearchByOrderDate.UseVisualStyleBackColor = True
        '
        'txtPaymentMethod
        '
        Me.txtPaymentMethod.Location = New System.Drawing.Point(165, 203)
        Me.txtPaymentMethod.Name = "txtPaymentMethod"
        Me.txtPaymentMethod.Size = New System.Drawing.Size(233, 26)
        Me.txtPaymentMethod.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(29, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 20)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Payment method"
        '
        'cbbShipper
        '
        Me.cbbShipper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbShipper.FormattingEnabled = True
        Me.cbbShipper.Location = New System.Drawing.Point(165, 162)
        Me.cbbShipper.Name = "cbbShipper"
        Me.cbbShipper.Size = New System.Drawing.Size(150, 28)
        Me.cbbShipper.TabIndex = 37
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.BackColor = System.Drawing.Color.White
        Me.label15.ForeColor = System.Drawing.Color.Blue
        Me.label15.Location = New System.Drawing.Point(29, 162)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(64, 20)
        Me.label15.TabIndex = 36
        Me.label15.Text = "Shipper"
        '
        'dtOrderDate
        '
        Me.dtOrderDate.Enabled = False
        Me.dtOrderDate.Location = New System.Drawing.Point(595, 53)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(233, 26)
        Me.dtOrderDate.TabIndex = 35
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.Color.White
        Me.label14.ForeColor = System.Drawing.Color.Blue
        Me.label14.Location = New System.Drawing.Point(462, 55)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(85, 20)
        Me.label14.TabIndex = 34
        Me.label14.Text = "Order date"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(165, 117)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(233, 26)
        Me.txtCustomerName.TabIndex = 33
        '
        'cbbShipStatus
        '
        Me.cbbShipStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbShipStatus.FormattingEnabled = True
        Me.cbbShipStatus.Location = New System.Drawing.Point(595, 207)
        Me.cbbShipStatus.Name = "cbbShipStatus"
        Me.cbbShipStatus.Size = New System.Drawing.Size(156, 28)
        Me.cbbShipStatus.TabIndex = 32
        '
        'dtShipDate
        '
        Me.dtShipDate.Enabled = False
        Me.dtShipDate.Location = New System.Drawing.Point(595, 119)
        Me.dtShipDate.Name = "dtShipDate"
        Me.dtShipDate.Size = New System.Drawing.Size(233, 26)
        Me.dtShipDate.TabIndex = 31
        '
        'txtShipAddress
        '
        Me.txtShipAddress.Location = New System.Drawing.Point(595, 164)
        Me.txtShipAddress.Name = "txtShipAddress"
        Me.txtShipAddress.Size = New System.Drawing.Size(233, 26)
        Me.txtShipAddress.TabIndex = 28
        '
        'txtOrderCode
        '
        Me.txtOrderCode.Location = New System.Drawing.Point(165, 71)
        Me.txtOrderCode.Name = "txtOrderCode"
        Me.txtOrderCode.Size = New System.Drawing.Size(150, 26)
        Me.txtOrderCode.TabIndex = 25
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.White
        Me.label2.ForeColor = System.Drawing.Color.Blue
        Me.label2.Location = New System.Drawing.Point(29, 77)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 20)
        Me.label2.TabIndex = 24
        Me.label2.Text = "Order code"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.White
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(462, 122)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(77, 20)
        Me.label4.TabIndex = 29
        Me.label4.Text = "Ship date"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.White
        Me.label6.ForeColor = System.Drawing.Color.Blue
        Me.label6.Location = New System.Drawing.Point(462, 208)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(89, 20)
        Me.label6.TabIndex = 30
        Me.label6.Text = "Ship status"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.White
        Me.label3.ForeColor = System.Drawing.Color.Blue
        Me.label3.Location = New System.Drawing.Point(462, 167)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 20)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Ship address"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.White
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(29, 120)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(122, 20)
        Me.label5.TabIndex = 27
        Me.label5.Text = "Customer name"
        '
        'dgvOrderSearch
        '
        Me.dgvOrderSearch.AllowUserToAddRows = False
        Me.dgvOrderSearch.AllowUserToDeleteRows = False
        Me.dgvOrderSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrderSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderSearch.Location = New System.Drawing.Point(54, 401)
        Me.dgvOrderSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvOrderSearch.Name = "dgvOrderSearch"
        Me.dgvOrderSearch.ReadOnly = True
        Me.dgvOrderSearch.RowHeadersWidth = 62
        Me.dgvOrderSearch.RowTemplate.Height = 33
        Me.dgvOrderSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderSearch.Size = New System.Drawing.Size(853, 369)
        Me.dgvOrderSearch.TabIndex = 1
        '
        'OrderSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 818)
        Me.Controls.Add(Me.dgvOrderSearch)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "OrderSearch"
        Me.Text = "Search Order"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dgvOrderSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSearch As System.Windows.Forms.Button
    Private groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOrderSearch As DataGridView
    Private WithEvents txtPaymentMethod As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents cbbShipper As ComboBox
    Private WithEvents label15 As Label
    Private WithEvents dtOrderDate As DateTimePicker
    Private WithEvents label14 As Label
    Private WithEvents txtCustomerName As TextBox
    Private WithEvents cbbShipStatus As ComboBox
    Private WithEvents dtShipDate As DateTimePicker
    Private WithEvents txtShipAddress As TextBox
    Private WithEvents txtOrderCode As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label4 As Label
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents label5 As Label
    Friend WithEvents cbSearchByOrderDate As CheckBox
    Friend WithEvents cbSearchByShipDate As CheckBox
End Class
