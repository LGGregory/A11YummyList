﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FridgePanelObsolete
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
        Me.ListTitle = New System.Windows.Forms.Label()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CancelChanges = New System.Windows.Forms.Button()
        Me.ApplyChangesButton = New System.Windows.Forms.Button()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.DetailsBox = New System.Windows.Forms.RichTextBox()
        Me.SendToPhoneButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListTitle
        '
        Me.ListTitle.AutoSize = True
        Me.ListTitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTitle.Location = New System.Drawing.Point(78, 13)
        Me.ListTitle.Name = "ListTitle"
        Me.ListTitle.Size = New System.Drawing.Size(308, 32)
        Me.ListTitle.TabIndex = 3
        Me.ListTitle.Text = "Current Shopping List"
        '
        'FlowPanel
        '
        Me.FlowPanel.Location = New System.Drawing.Point(0, 64)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(465, 391)
        Me.FlowPanel.TabIndex = 4
        '
        'CancelChanges
        '
        Me.CancelChanges.Location = New System.Drawing.Point(135, 650)
        Me.CancelChanges.Name = "CancelChanges"
        Me.CancelChanges.Size = New System.Drawing.Size(75, 23)
        Me.CancelChanges.TabIndex = 6
        Me.CancelChanges.Text = "Revert"
        Me.CancelChanges.UseVisualStyleBackColor = True
        '
        'ApplyChangesButton
        '
        Me.ApplyChangesButton.Location = New System.Drawing.Point(255, 650)
        Me.ApplyChangesButton.Name = "ApplyChangesButton"
        Me.ApplyChangesButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyChangesButton.TabIndex = 7
        Me.ApplyChangesButton.Text = "Update"
        Me.ApplyChangesButton.UseVisualStyleBackColor = True
        '
        'AddItemButton
        '
        Me.AddItemButton.Location = New System.Drawing.Point(375, 650)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(75, 23)
        Me.AddItemButton.TabIndex = 8
        Me.AddItemButton.Text = "Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'DetailsBox
        '
        Me.DetailsBox.Location = New System.Drawing.Point(15, 461)
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.Size = New System.Drawing.Size(435, 183)
        Me.DetailsBox.TabIndex = 9
        Me.DetailsBox.Text = ""
        '
        'SendToPhoneButton
        '
        Me.SendToPhoneButton.Location = New System.Drawing.Point(15, 650)
        Me.SendToPhoneButton.Name = "SendToPhoneButton"
        Me.SendToPhoneButton.Size = New System.Drawing.Size(87, 23)
        Me.SendToPhoneButton.TabIndex = 10
        Me.SendToPhoneButton.Text = "Send to Phone"
        Me.SendToPhoneButton.UseVisualStyleBackColor = True
        '
        'GroceryListPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SendToPhoneButton)
        Me.Controls.Add(Me.DetailsBox)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.ApplyChangesButton)
        Me.Controls.Add(Me.CancelChanges)
        Me.Controls.Add(Me.FlowPanel)
        Me.Controls.Add(Me.ListTitle)
        Me.Name = "GroceryListPanel"
        Me.Size = New System.Drawing.Size(465, 710)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListTitle As Label
    Friend WithEvents FlowPanel As FlowLayoutPanel
    Friend WithEvents CancelChanges As Button
    Friend WithEvents ApplyChangesButton As Button
    Friend WithEvents AddItemButton As Button
    Friend WithEvents DetailsBox As RichTextBox
    Friend WithEvents SendToPhoneButton As Button
End Class
