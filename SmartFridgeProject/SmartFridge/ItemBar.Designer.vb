<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemBar
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
        Me.RemoveItem = New System.Windows.Forms.Button()
        Me.ItemName = New System.Windows.Forms.Label()
        Me.ItemQuantity = New System.Windows.Forms.Label()
        Me.ItemUnit = New System.Windows.Forms.Label()
        Me.UpQuantityButton = New System.Windows.Forms.Button()
        Me.DownQuantityButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RemoveItem
        '
        Me.RemoveItem.Location = New System.Drawing.Point(396, 12)
        Me.RemoveItem.Name = "RemoveItem"
        Me.RemoveItem.Size = New System.Drawing.Size(27, 23)
        Me.RemoveItem.TabIndex = 0
        Me.RemoveItem.Text = "X"
        Me.RemoveItem.UseVisualStyleBackColor = True
        '
        'ItemName
        '
        Me.ItemName.AutoSize = True
        Me.ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName.Location = New System.Drawing.Point(137, 14)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(57, 20)
        Me.ItemName.TabIndex = 1
        Me.ItemName.Text = "Label1"
        '
        'ItemQuantity
        '
        Me.ItemQuantity.AutoSize = True
        Me.ItemQuantity.Location = New System.Drawing.Point(4, 17)
        Me.ItemQuantity.Name = "ItemQuantity"
        Me.ItemQuantity.Size = New System.Drawing.Size(14, 13)
        Me.ItemQuantity.TabIndex = 2
        Me.ItemQuantity.Text = "#"
        '
        'ItemUnit
        '
        Me.ItemUnit.AutoSize = True
        Me.ItemUnit.Location = New System.Drawing.Point(24, 17)
        Me.ItemUnit.Name = "ItemUnit"
        Me.ItemUnit.Size = New System.Drawing.Size(26, 13)
        Me.ItemUnit.TabIndex = 3
        Me.ItemUnit.Text = "Unit"
        '
        'UpQuantityButton
        '
        Me.UpQuantityButton.Location = New System.Drawing.Point(54, 12)
        Me.UpQuantityButton.Name = "UpQuantityButton"
        Me.UpQuantityButton.Size = New System.Drawing.Size(31, 23)
        Me.UpQuantityButton.TabIndex = 4
        Me.UpQuantityButton.Text = "^"
        Me.UpQuantityButton.UseVisualStyleBackColor = True
        '
        'DownQuantityButton
        '
        Me.DownQuantityButton.Location = New System.Drawing.Point(91, 12)
        Me.DownQuantityButton.Name = "DownQuantityButton"
        Me.DownQuantityButton.Size = New System.Drawing.Size(31, 23)
        Me.DownQuantityButton.TabIndex = 5
        Me.DownQuantityButton.Text = "v"
        Me.DownQuantityButton.UseVisualStyleBackColor = True
        '
        'ItemBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DownQuantityButton)
        Me.Controls.Add(Me.UpQuantityButton)
        Me.Controls.Add(Me.ItemUnit)
        Me.Controls.Add(Me.ItemQuantity)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.RemoveItem)
        Me.Name = "ItemBar"
        Me.Size = New System.Drawing.Size(435, 46)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RemoveItem As Button
    Friend WithEvents ItemName As Label
    Friend WithEvents ItemQuantity As Label
    Friend WithEvents ItemUnit As Label
    Friend WithEvents UpQuantityButton As Button
    Friend WithEvents DownQuantityButton As Button
End Class
