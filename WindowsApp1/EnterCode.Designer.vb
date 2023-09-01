<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnterCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterCode))
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.bConfirm = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bBack = New System.Windows.Forms.Button()
        Me.bResent = New System.Windows.Forms.Button()
        Me.labNotice = New System.Windows.Forms.Label()
        Me.labCount = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.Red
        Me.label7.Location = New System.Drawing.Point(128, 21)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(236, 37)
        Me.label7.TabIndex = 9
        Me.label7.Text = "ENTER CODE"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(141, 105)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(334, 26)
        Me.txtCode.TabIndex = 10
        '
        'bConfirm
        '
        Me.bConfirm.BackColor = System.Drawing.Color.SandyBrown
        Me.bConfirm.Image = CType(resources.GetObject("bConfirm.Image"), System.Drawing.Image)
        Me.bConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bConfirm.Location = New System.Drawing.Point(152, 158)
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
        Me.bCancel.Location = New System.Drawing.Point(323, 158)
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
        Me.Label1.Location = New System.Drawing.Point(137, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "*Enter code we sent to your email"
        '
        'bBack
        '
        Me.bBack.BackColor = System.Drawing.Color.Transparent
        Me.bBack.Image = CType(resources.GetObject("bBack.Image"), System.Drawing.Image)
        Me.bBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBack.Location = New System.Drawing.Point(12, 23)
        Me.bBack.Name = "bBack"
        Me.bBack.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bBack.Size = New System.Drawing.Size(86, 35)
        Me.bBack.TabIndex = 15
        Me.bBack.Text = "Back"
        Me.bBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBack.UseVisualStyleBackColor = False
        '
        'bResent
        '
        Me.bResent.BackColor = System.Drawing.Color.Transparent
        Me.bResent.Image = CType(resources.GetObject("bResent.Image"), System.Drawing.Image)
        Me.bResent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bResent.Location = New System.Drawing.Point(481, 101)
        Me.bResent.Name = "bResent"
        Me.bResent.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.bResent.Size = New System.Drawing.Size(102, 35)
        Me.bResent.TabIndex = 16
        Me.bResent.Text = "Resent"
        Me.bResent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bResent.UseVisualStyleBackColor = False
        '
        'labNotice
        '
        Me.labNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNotice.ForeColor = System.Drawing.Color.Orange
        Me.labNotice.Location = New System.Drawing.Point(469, 50)
        Me.labNotice.Name = "labNotice"
        Me.labNotice.Size = New System.Drawing.Size(137, 43)
        Me.labNotice.TabIndex = 17
        Me.labNotice.Text = "We sent to your mail new code!"
        '
        'labCount
        '
        Me.labCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCount.ForeColor = System.Drawing.Color.Red
        Me.labCount.Location = New System.Drawing.Point(481, 101)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(125, 43)
        Me.labCount.TabIndex = 18
        Me.labCount.Text = "Resent next after 3 seconds"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'EnterCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 244)
        Me.Controls.Add(Me.labNotice)
        Me.Controls.Add(Me.bResent)
        Me.Controls.Add(Me.bBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bConfirm)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.labCount)
        Me.KeyPreview = True
        Me.Name = "EnterCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forget password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents bConfirm As Button
    Friend WithEvents bCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bBack As Button
    Friend WithEvents bResent As Button
    Friend WithEvents labNotice As Label
    Friend WithEvents labCount As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
