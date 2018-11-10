<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemForm
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
        Me.ConfirmAddButton = New System.Windows.Forms.Button()
        Me.CancelAddButton = New System.Windows.Forms.Button()
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.UnitList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ConfirmAddButton
        '
        Me.ConfirmAddButton.Location = New System.Drawing.Point(265, 145)
        Me.ConfirmAddButton.Name = "ConfirmAddButton"
        Me.ConfirmAddButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmAddButton.TabIndex = 0
        Me.ConfirmAddButton.Text = "Add"
        Me.ConfirmAddButton.UseVisualStyleBackColor = True
        '
        'CancelAddButton
        '
        Me.CancelAddButton.Location = New System.Drawing.Point(26, 145)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelAddButton.TabIndex = 1
        Me.CancelAddButton.Text = "Cancel"
        Me.CancelAddButton.UseVisualStyleBackColor = True
        '
        'ItemName
        '
        Me.ItemName.Location = New System.Drawing.Point(26, 33)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(314, 20)
        Me.ItemName.TabIndex = 2
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(219, 91)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(54, 20)
        Me.Quantity.TabIndex = 3
        '
        'UnitList
        '
        Me.UnitList.FormattingEnabled = True
        Me.UnitList.Items.AddRange(New Object() {"Ct", "Grams", "Lbs", "Pieces", "Thingies"})
        Me.UnitList.Location = New System.Drawing.Point(279, 90)
        Me.UnitList.Name = "UnitList"
        Me.UnitList.Size = New System.Drawing.Size(61, 21)
        Me.UnitList.TabIndex = 4
        '
        'AddItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 195)
        Me.Controls.Add(Me.UnitList)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.CancelAddButton)
        Me.Controls.Add(Me.ConfirmAddButton)
        Me.Name = "AddItemForm"
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmAddButton As Button
    Friend WithEvents CancelAddButton As Button
    Friend WithEvents ItemName As TextBox
    Friend WithEvents Quantity As TextBox
    Friend WithEvents UnitList As ComboBox
End Class
