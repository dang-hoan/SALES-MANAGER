<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveFileNotification
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
        Me.bOpenFile = New System.Windows.Forms.Button()
        Me.labNotify = New System.Windows.Forms.Label()
        Me.bExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bOpenFile
        '
        Me.bOpenFile.Location = New System.Drawing.Point(109, 134)
        Me.bOpenFile.Name = "bOpenFile"
        Me.bOpenFile.Size = New System.Drawing.Size(114, 43)
        Me.bOpenFile.TabIndex = 0
        Me.bOpenFile.Text = "Open file"
        Me.bOpenFile.UseVisualStyleBackColor = True
        '
        'labNotify
        '
        Me.labNotify.Location = New System.Drawing.Point(26, 24)
        Me.labNotify.Name = "labNotify"
        Me.labNotify.Size = New System.Drawing.Size(481, 89)
        Me.labNotify.TabIndex = 1
        Me.labNotify.Text = "Export file successfully!!"
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(294, 134)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(114, 43)
        Me.bExit.TabIndex = 2
        Me.bExit.Text = "Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'SaveFileNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 200)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.labNotify)
        Me.Controls.Add(Me.bOpenFile)
        Me.Name = "SaveFileNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaveFileNotification"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bOpenFile As Button
    Friend WithEvents labNotify As Label
    Friend WithEvents bExit As Button
End Class
