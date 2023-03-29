<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.linkForget = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.linkRegister = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(141, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 196)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(58, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(194, 214)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(247, 26)
        Me.txtUsername.TabIndex = 1
        '
        'bLogin
        '
        Me.bLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bLogin.Location = New System.Drawing.Point(194, 334)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(122, 41)
        Me.bLogin.TabIndex = 4
        Me.bLogin.Text = "Login"
        Me.bLogin.UseVisualStyleBackColor = False
        '
        'linkForget
        '
        Me.linkForget.AutoSize = True
        Me.linkForget.BackColor = System.Drawing.Color.Transparent
        Me.linkForget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkForget.ForeColor = System.Drawing.Color.Lime
        Me.linkForget.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.linkForget.Location = New System.Drawing.Point(288, 390)
        Me.linkForget.Name = "linkForget"
        Me.linkForget.Size = New System.Drawing.Size(153, 20)
        Me.linkForget.TabIndex = 5
        Me.linkForget.TabStop = True
        Me.linkForget.Text = "Forget password?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(58, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(194, 277)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(247, 26)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'linkRegister
        '
        Me.linkRegister.AutoSize = True
        Me.linkRegister.BackColor = System.Drawing.Color.Transparent
        Me.linkRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkRegister.ForeColor = System.Drawing.Color.Lime
        Me.linkRegister.LinkColor = System.Drawing.Color.White
        Me.linkRegister.Location = New System.Drawing.Point(163, 439)
        Me.linkRegister.Name = "linkRegister"
        Me.linkRegister.Size = New System.Drawing.Size(198, 20)
        Me.linkRegister.TabIndex = 6
        Me.linkRegister.TabStop = True
        Me.linkRegister.Text = "Register a new account"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(498, 530)
        Me.Controls.Add(Me.linkRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.linkForget)
        Me.Controls.Add(Me.bLogin)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents bLogin As Button
    Friend WithEvents linkForget As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents linkRegister As LinkLabel
End Class
