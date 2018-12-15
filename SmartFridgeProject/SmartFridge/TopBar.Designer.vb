<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonAddRecipe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(481, 1)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(78, 38)
        Me.CopyButton.TabIndex = 0
        Me.CopyButton.Text = "Copy to List"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(397, 1)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(78, 38)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add to List"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ButtonAddRecipe
        '
        Me.ButtonAddRecipe.Location = New System.Drawing.Point(313, 1)
        Me.ButtonAddRecipe.Name = "ButtonAddRecipe"
        Me.ButtonAddRecipe.Size = New System.Drawing.Size(78, 38)
        Me.ButtonAddRecipe.TabIndex = 2
        Me.ButtonAddRecipe.Text = "Add Needed"
        Me.ButtonAddRecipe.UseVisualStyleBackColor = True
        '
        'TopBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.ButtonAddRecipe)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CopyButton)
        Me.Name = "TopBar"
        Me.Size = New System.Drawing.Size(590, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CopyButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ButtonAddRecipe As Button
End Class
