<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResetPassword
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPassword))
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.bConfirm = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReEnterPassword = New System.Windows.Forms.TextBox()
        Me.labShowNewPassword = New System.Windows.Forms.Label()
        Me.labShowReEnterPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Red
        Me.label7.Location = New System.Drawing.Point(136, 30)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(331, 37)
        Me.label7.TabIndex = 9
        Me.label7.Text = "RESET PASSWORD"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(149, 114)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(334, 26)
        Me.txtNewPassword.TabIndex = 10
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'bConfirm
        '
        Me.bConfirm.BackColor = System.Drawing.Color.SandyBrown
        Me.bConfirm.Image = CType(resources.GetObject("bConfirm.Image"), System.Drawing.Image)
        Me.bConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConfirm.Location = New System.Drawing.Point(154, 238)
        Me.bConfirm.Name = "bConfirm"
        Me.bConfirm.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bConfirm.Size = New System.Drawing.Size(142, 52)
        Me.bConfirm.TabIndex = 11
        Me.bConfirm.Text = "Confirm"
        Me.bConfirm.UseVisualStyleBackColor = False
        '
        'bCancel
        '
        Me.bCancel.BackColor = System.Drawing.Color.SandyBrown
        Me.bCancel.Image = CType(resources.GetObject("bCancel.Image"), System.Drawing.Image)
        Me.bCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancel.Location = New System.Drawing.Point(325, 238)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bCancel.Size = New System.Drawing.Size(142, 52)
        Me.bCancel.TabIndex = 12
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(145, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "*Enter new password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(145, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "*Re-enter password"
        '
        'txtReEnterPassword
        '
        Me.txtReEnterPassword.Location = New System.Drawing.Point(149, 189)
        Me.txtReEnterPassword.Name = "txtReEnterPassword"
        Me.txtReEnterPassword.Size = New System.Drawing.Size(334, 26)
        Me.txtReEnterPassword.TabIndex = 14
        Me.txtReEnterPassword.UseSystemPasswordChar = True
        '
        'labShowNewPassword
        '
        Me.labShowNewPassword.BackColor = System.Drawing.Color.White
        Me.labShowNewPassword.Image = CType(resources.GetObject("labShowNewPassword.Image"), System.Drawing.Image)
        Me.labShowNewPassword.Location = New System.Drawing.Point(450, 117)
        Me.labShowNewPassword.Name = "labShowNewPassword"
        Me.labShowNewPassword.Size = New System.Drawing.Size(33, 22)
        Me.labShowNewPassword.TabIndex = 16
        Me.labShowNewPassword.Text = "s"
        '
        'labShowReEnterPassword
        '
        Me.labShowReEnterPassword.BackColor = System.Drawing.Color.White
        Me.labShowReEnterPassword.Image = CType(resources.GetObject("labShowReEnterPassword.Image"), System.Drawing.Image)
        Me.labShowReEnterPassword.Location = New System.Drawing.Point(450, 192)
        Me.labShowReEnterPassword.Name = "labShowReEnterPassword"
        Me.labShowReEnterPassword.Size = New System.Drawing.Size(33, 22)
        Me.labShowReEnterPassword.TabIndex = 17
        Me.labShowReEnterPassword.Text = "s"
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 311)
        Me.Controls.Add(Me.labShowReEnterPassword)
        Me.Controls.Add(Me.labShowNewPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReEnterPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bConfirm)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.label7)
        Me.KeyPreview = True
        Me.Name = "ResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forget password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents bConfirm As Button
    Friend WithEvents bCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReEnterPassword As TextBox
    Friend WithEvents labShowNewPassword As Label
    Friend WithEvents labShowReEnterPassword As Label
End Class
