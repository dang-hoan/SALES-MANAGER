<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountInformation))
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.labShowPassword = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(255, 93)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(257, 26)
        Me.txtCode.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(105, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Employee code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(105, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(255, 141)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(257, 26)
        Me.txtPassword.TabIndex = 27
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'labShowPassword
        '
        Me.labShowPassword.BackColor = System.Drawing.Color.White
        Me.labShowPassword.Image = CType(resources.GetObject("labShowPassword.Image"), System.Drawing.Image)
        Me.labShowPassword.Location = New System.Drawing.Point(473, 144)
        Me.labShowPassword.Name = "labShowPassword"
        Me.labShowPassword.Size = New System.Drawing.Size(33, 22)
        Me.labShowPassword.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(165, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 29)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "EMPLOYEE ACCOUNT"
        '
        'cbbStatus
        '
        Me.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbStatus.FormattingEnabled = True
        Me.cbbStatus.Location = New System.Drawing.Point(255, 194)
        Me.cbbStatus.Name = "cbbStatus"
        Me.cbbStatus.Size = New System.Drawing.Size(121, 28)
        Me.cbbStatus.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(105, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Status"
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.SandyBrown
        Me.bSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSave.Location = New System.Drawing.Point(162, 255)
        Me.bSave.Name = "bSave"
        Me.bSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bSave.Size = New System.Drawing.Size(112, 43)
        Me.bSave.TabIndex = 34
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bCancel
        '
        Me.bCancel.BackColor = System.Drawing.Color.SandyBrown
        Me.bCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancel.Location = New System.Drawing.Point(339, 255)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bCancel.Size = New System.Drawing.Size(115, 43)
        Me.bCancel.TabIndex = 33
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = False
        '
        'AccountInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(616, 328)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbbStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labShowPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCode)
        Me.Name = "AccountInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCode As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents labShowPassword As Label
    Private WithEvents Label3 As Label
    Friend WithEvents cbbStatus As ComboBox
    Private WithEvents Label4 As Label
    Private WithEvents bSave As Button
    Private WithEvents bCancel As Button
End Class
