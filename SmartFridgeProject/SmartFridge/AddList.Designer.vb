<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddList
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
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.CancelAddButton = New System.Windows.Forms.Button()
        Me.ConfirmAddButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ItemName
        '
        Me.ItemName.Location = New System.Drawing.Point(26, 33)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(314, 20)
        Me.ItemName.TabIndex = 3
        '
        'CancelAddButton
        '
        Me.CancelAddButton.Location = New System.Drawing.Point(26, 145)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelAddButton.TabIndex = 5
        Me.CancelAddButton.Text = "Cancel"
        Me.CancelAddButton.UseVisualStyleBackColor = True
        '
        'ConfirmAddButton
        '
        Me.ConfirmAddButton.Location = New System.Drawing.Point(265, 145)
        Me.ConfirmAddButton.Name = "ConfirmAddButton"
        Me.ConfirmAddButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmAddButton.TabIndex = 4
        Me.ConfirmAddButton.Text = "Add"
        Me.ConfirmAddButton.UseVisualStyleBackColor = True
        '
        'AddList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 191)
        Me.Controls.Add(Me.CancelAddButton)
        Me.Controls.Add(Me.ConfirmAddButton)
        Me.Controls.Add(Me.ItemName)
        Me.Name = "AddList"
        Me.Text = "Create List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemName As TextBox
    Friend WithEvents CancelAddButton As Button
    Friend WithEvents ConfirmAddButton As Button
End Class
