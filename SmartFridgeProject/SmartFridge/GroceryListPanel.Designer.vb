﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroceryListPanel
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
        Me.ListTitle = New System.Windows.Forms.Label()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CancelChanges = New System.Windows.Forms.Button()
        Me.ApplyChangesButton = New System.Windows.Forms.Button()
        Me.DetailsBox = New System.Windows.Forms.RichTextBox()
        Me.SendToPhoneButton = New System.Windows.Forms.Button()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.EditNameBox = New System.Windows.Forms.TextBox()
        Me.Keyboard1 = New SmartFridge.Keyboard()
        Me.AddItemButton = New System.Windows.Forms.PictureBox()
        Me.EditBox = New System.Windows.Forms.PictureBox()
        CType(Me.AddItemButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FlowPanel.AutoScroll = True
        Me.FlowPanel.Location = New System.Drawing.Point(0, 64)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(465, 391)
        Me.FlowPanel.TabIndex = 4
        '
        'CancelChanges
        '
        Me.CancelChanges.Location = New System.Drawing.Point(201, 607)
        Me.CancelChanges.Name = "CancelChanges"
        Me.CancelChanges.Size = New System.Drawing.Size(75, 23)
        Me.CancelChanges.TabIndex = 6
        Me.CancelChanges.Text = "Revert"
        Me.CancelChanges.UseVisualStyleBackColor = True
        '
        'ApplyChangesButton
        '
        Me.ApplyChangesButton.Location = New System.Drawing.Point(288, 607)
        Me.ApplyChangesButton.Name = "ApplyChangesButton"
        Me.ApplyChangesButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyChangesButton.TabIndex = 7
        Me.ApplyChangesButton.Text = "Save"
        Me.ApplyChangesButton.UseVisualStyleBackColor = True
        '
        'DetailsBox
        '
        Me.DetailsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsBox.Location = New System.Drawing.Point(15, 461)
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.Size = New System.Drawing.Size(435, 137)
        Me.DetailsBox.TabIndex = 9
        Me.DetailsBox.Text = ""
        '
        'SendToPhoneButton
        '
        Me.SendToPhoneButton.Location = New System.Drawing.Point(102, 607)
        Me.SendToPhoneButton.Name = "SendToPhoneButton"
        Me.SendToPhoneButton.Size = New System.Drawing.Size(87, 23)
        Me.SendToPhoneButton.TabIndex = 10
        Me.SendToPhoneButton.Text = "Send to Phone"
        Me.SendToPhoneButton.UseVisualStyleBackColor = True
        '
        'DetailsButton
        '
        Me.DetailsButton.Location = New System.Drawing.Point(15, 607)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(75, 23)
        Me.DetailsButton.TabIndex = 11
        Me.DetailsButton.Text = "Details"
        Me.DetailsButton.UseVisualStyleBackColor = True
        '
        'EditNameBox
        '
        Me.EditNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditNameBox.Location = New System.Drawing.Point(84, 9)
        Me.EditNameBox.Name = "EditNameBox"
        Me.EditNameBox.Size = New System.Drawing.Size(302, 38)
        Me.EditNameBox.TabIndex = 13
        Me.EditNameBox.Visible = False
        '
        'Keyboard1
        '
        Me.Keyboard1.Location = New System.Drawing.Point(55, 461)
        Me.Keyboard1.Name = "Keyboard1"
        Me.Keyboard1.Size = New System.Drawing.Size(354, 137)
        Me.Keyboard1.TabIndex = 0
        Me.Keyboard1.Visible = False
        '
        'AddItemButton
        '
        Me.AddItemButton.Image = Global.SmartFridge.My.Resources.Resources.addItem
        Me.AddItemButton.Location = New System.Drawing.Point(379, 604)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(71, 71)
        Me.AddItemButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddItemButton.TabIndex = 14
        Me.AddItemButton.TabStop = False
        '
        'EditBox
        '
        Me.EditBox.Image = Global.SmartFridge.My.Resources.Resources.Edit
        Me.EditBox.Location = New System.Drawing.Point(418, 13)
        Me.EditBox.Name = "EditBox"
        Me.EditBox.Size = New System.Drawing.Size(32, 32)
        Me.EditBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EditBox.TabIndex = 12
        Me.EditBox.TabStop = False
        '
        'GroceryListPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.Keyboard1)
        Me.Controls.Add(Me.EditNameBox)
        Me.Controls.Add(Me.EditBox)
        Me.Controls.Add(Me.DetailsButton)
        Me.Controls.Add(Me.SendToPhoneButton)
        Me.Controls.Add(Me.DetailsBox)
        Me.Controls.Add(Me.ApplyChangesButton)
        Me.Controls.Add(Me.CancelChanges)
        Me.Controls.Add(Me.FlowPanel)
        Me.Controls.Add(Me.ListTitle)
        Me.Name = "GroceryListPanel"
        Me.Size = New System.Drawing.Size(465, 710)
        CType(Me.AddItemButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListTitle As Label
    Friend WithEvents FlowPanel As FlowLayoutPanel
    Friend WithEvents CancelChanges As Button
    Friend WithEvents ApplyChangesButton As Button
    Friend WithEvents DetailsBox As RichTextBox
    Friend WithEvents SendToPhoneButton As Button
    Friend WithEvents DetailsButton As Button
    Friend WithEvents EditBox As PictureBox
    Friend WithEvents EditNameBox As TextBox
    Friend WithEvents Keyboard1 As Keyboard
    Friend WithEvents AddItemButton As PictureBox
End Class
