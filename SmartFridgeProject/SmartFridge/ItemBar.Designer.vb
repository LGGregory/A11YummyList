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
        Me.BuyAll = New System.Windows.Forms.PictureBox()
        Me.BuyOne = New System.Windows.Forms.PictureBox()
        CType(Me.BuyAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyOne, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName.Location = New System.Drawing.Point(127, 7)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(95, 31)
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
        Me.ItemUnit.Location = New System.Drawing.Point(26, 17)
        Me.ItemUnit.Name = "ItemUnit"
        Me.ItemUnit.Size = New System.Drawing.Size(26, 13)
        Me.ItemUnit.TabIndex = 3
        Me.ItemUnit.Text = "Unit"
        '
        'UpQuantityButton
        '
        Me.UpQuantityButton.Location = New System.Drawing.Point(62, 12)
        Me.UpQuantityButton.Name = "UpQuantityButton"
        Me.UpQuantityButton.Size = New System.Drawing.Size(31, 23)
        Me.UpQuantityButton.TabIndex = 4
        Me.UpQuantityButton.Text = "+"
        Me.UpQuantityButton.UseVisualStyleBackColor = True
        '
        'DownQuantityButton
        '
        Me.DownQuantityButton.Location = New System.Drawing.Point(99, 12)
        Me.DownQuantityButton.Name = "DownQuantityButton"
        Me.DownQuantityButton.Size = New System.Drawing.Size(31, 23)
        Me.DownQuantityButton.TabIndex = 5
        Me.DownQuantityButton.Text = "-"
        Me.DownQuantityButton.UseVisualStyleBackColor = True
        '
        'BuyAll
        '
        Me.BuyAll.Image = Global.SmartFridge.My.Resources.Resources.buyAll
        Me.BuyAll.Location = New System.Drawing.Point(384, 0)
        Me.BuyAll.Name = "BuyAll"
        Me.BuyAll.Size = New System.Drawing.Size(51, 47)
        Me.BuyAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuyAll.TabIndex = 7
        Me.BuyAll.TabStop = False
        Me.BuyAll.Visible = False
        '
        'BuyOne
        '
        Me.BuyOne.Image = Global.SmartFridge.My.Resources.Resources.buyOne
        Me.BuyOne.Location = New System.Drawing.Point(331, -1)
        Me.BuyOne.Name = "BuyOne"
        Me.BuyOne.Size = New System.Drawing.Size(51, 47)
        Me.BuyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuyOne.TabIndex = 6
        Me.BuyOne.TabStop = False
        Me.BuyOne.Visible = False
        '
        'ItemBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BuyAll)
        Me.Controls.Add(Me.BuyOne)
        Me.Controls.Add(Me.DownQuantityButton)
        Me.Controls.Add(Me.UpQuantityButton)
        Me.Controls.Add(Me.ItemUnit)
        Me.Controls.Add(Me.ItemQuantity)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.RemoveItem)
        Me.Name = "ItemBar"
        Me.Size = New System.Drawing.Size(435, 46)
        CType(Me.BuyAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RemoveItem As Button
    Friend WithEvents ItemName As Label
    Friend WithEvents ItemQuantity As Label
    Friend WithEvents ItemUnit As Label
    Friend WithEvents UpQuantityButton As Button
    Friend WithEvents DownQuantityButton As Button
    Friend WithEvents BuyOne As PictureBox
    Friend WithEvents BuyAll As PictureBox
End Class
