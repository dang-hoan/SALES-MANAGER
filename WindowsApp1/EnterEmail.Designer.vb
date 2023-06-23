<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterEmail))
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.bConfirm = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Red
        Me.label7.Location = New System.Drawing.Point(136, 20)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(240, 37)
        Me.label7.TabIndex = 9
        Me.label7.Text = "ENTER EMAIL"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(149, 104)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(334, 26)
        Me.txtEmail.TabIndex = 10
        '
        'bConfirm
        '
        Me.bConfirm.BackColor = System.Drawing.Color.SandyBrown
        Me.bConfirm.Image = CType(resources.GetObject("bConfirm.Image"), System.Drawing.Image)
        Me.bConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConfirm.Location = New System.Drawing.Point(160, 157)
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
        Me.bCancel.Location = New System.Drawing.Point(331, 157)
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
        Me.Label1.Location = New System.Drawing.Point(145, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "*Enter your email to reset password"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'EnterEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 244)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bConfirm)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.label7)
        Me.KeyPreview = True
        Me.Name = "EnterEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forget password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents bConfirm As Button
    Friend WithEvents bCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
