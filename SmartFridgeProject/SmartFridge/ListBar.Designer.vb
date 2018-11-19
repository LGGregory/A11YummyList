<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ItemName = New System.Windows.Forms.Label()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(396, 12)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(27, 23)
        Me.RemoveButton.TabIndex = 1
        Me.RemoveButton.Text = "X"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ItemName
        '
        Me.ItemName.AutoSize = True
        Me.ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName.Location = New System.Drawing.Point(16, 12)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(57, 20)
        Me.ItemName.TabIndex = 2
        Me.ItemName.Text = "Label1"
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(363, 12)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(27, 23)
        Me.CopyButton.TabIndex = 3
        Me.CopyButton.Text = "C"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'ListBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.RemoveButton)
        Me.Name = "ListBar"
        Me.Size = New System.Drawing.Size(435, 46)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RemoveButton As Button
    Friend WithEvents ItemName As Label
    Friend WithEvents CopyButton As Button
End Class
