<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SmartFridgeDisplay
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
        Me.SidePanel1 = New SmartFridge.SidePanel()
        Me.GroceryListDefault = New SmartFridge.GroceryListPanel()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SidePanel1
        '
        Me.SidePanel1.BackColor = System.Drawing.Color.DarkGreen
        Me.SidePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SidePanel1.Name = "SidePanel1"
        Me.SidePanel1.Size = New System.Drawing.Size(70, 710)
        Me.SidePanel1.TabIndex = 0
        '
        'GroceryListDefault
        '
        Me.GroceryListDefault.ListName = Nothing
        Me.GroceryListDefault.Location = New System.Drawing.Point(114, 0)
        Me.GroceryListDefault.Name = "GroceryListDefault"
        Me.GroceryListDefault.Size = New System.Drawing.Size(465, 635)
        Me.GroceryListDefault.TabIndex = 1
        '
        'AddItemButton
        '
        Me.AddItemButton.Location = New System.Drawing.Point(492, 622)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(75, 23)
        Me.AddItemButton.TabIndex = 2
        Me.AddItemButton.Text = "Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'SmartFridgeDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 710)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.SidePanel1)
        Me.Controls.Add(Me.GroceryListDefault)
        Me.Name = "SmartFridgeDisplay"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SidePanel1 As SidePanel
    Friend WithEvents GroceryListDefault As GroceryListPanel
    Friend WithEvents AddItemButton As Button
End Class
