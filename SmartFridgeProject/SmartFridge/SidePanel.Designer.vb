﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SidePanel
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
        Me.BurgerShrink = New System.Windows.Forms.PictureBox()
        Me.SlideButton = New System.Windows.Forms.PictureBox()
        Me.BurgerExpand = New System.Windows.Forms.PictureBox()
        Me.MenuPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CurrentListButton = New System.Windows.Forms.Label()
        Me.SavedListButton = New System.Windows.Forms.Label()
        Me.RecipesButton = New System.Windows.Forms.Label()
        Me.FridgeContentsButton = New System.Windows.Forms.Label()
        CType(Me.BurgerShrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurgerExpand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BurgerShrink
        '
        Me.BurgerShrink.Image = Global.SmartFridge.My.Resources.Resources.Hambuger
        Me.BurgerShrink.InitialImage = Global.SmartFridge.My.Resources.Resources.Hambuger
        Me.BurgerShrink.Location = New System.Drawing.Point(301, 3)
        Me.BurgerShrink.Name = "BurgerShrink"
        Me.BurgerShrink.Size = New System.Drawing.Size(60, 60)
        Me.BurgerShrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BurgerShrink.TabIndex = 0
        Me.BurgerShrink.TabStop = False
        '
        'SlideButton
        '
        Me.SlideButton.Location = New System.Drawing.Point(330, 251)
        Me.SlideButton.Name = "SlideButton"
        Me.SlideButton.Size = New System.Drawing.Size(31, 50)
        Me.SlideButton.TabIndex = 1
        Me.SlideButton.TabStop = False
        '
        'BurgerExpand
        '
        Me.BurgerExpand.Image = Global.SmartFridge.My.Resources.Resources.Hambuger
        Me.BurgerExpand.InitialImage = Global.SmartFridge.My.Resources.Resources.Hambuger
        Me.BurgerExpand.Location = New System.Drawing.Point(3, 3)
        Me.BurgerExpand.Name = "BurgerExpand"
        Me.BurgerExpand.Size = New System.Drawing.Size(60, 60)
        Me.BurgerExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BurgerExpand.TabIndex = 3
        Me.BurgerExpand.TabStop = False
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.CurrentListButton)
        Me.MenuPanel.Controls.Add(Me.SavedListButton)
        Me.MenuPanel.Controls.Add(Me.RecipesButton)
        Me.MenuPanel.Controls.Add(Me.FridgeContentsButton)
        Me.MenuPanel.Location = New System.Drawing.Point(69, 69)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(232, 487)
        Me.MenuPanel.TabIndex = 4
        '
        'CurrentListButton
        '
        Me.CurrentListButton.AutoSize = True
        Me.CurrentListButton.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentListButton.Location = New System.Drawing.Point(3, 0)
        Me.CurrentListButton.Name = "CurrentListButton"
        Me.CurrentListButton.Size = New System.Drawing.Size(213, 41)
        Me.CurrentListButton.TabIndex = 0
        Me.CurrentListButton.Text = "Current List"
        '
        'SavedListButton
        '
        Me.SavedListButton.AutoSize = True
        Me.SavedListButton.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavedListButton.Location = New System.Drawing.Point(3, 41)
        Me.SavedListButton.Name = "SavedListButton"
        Me.SavedListButton.Size = New System.Drawing.Size(209, 41)
        Me.SavedListButton.TabIndex = 1
        Me.SavedListButton.Text = "Saved Lists"
        '
        'RecipesButton
        '
        Me.RecipesButton.AutoSize = True
        Me.RecipesButton.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipesButton.Location = New System.Drawing.Point(3, 82)
        Me.RecipesButton.Name = "RecipesButton"
        Me.RecipesButton.Size = New System.Drawing.Size(149, 41)
        Me.RecipesButton.TabIndex = 2
        Me.RecipesButton.Text = "Recipes"
        '
        'FridgeContentsButton
        '
        Me.FridgeContentsButton.AutoSize = True
        Me.FridgeContentsButton.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FridgeContentsButton.Location = New System.Drawing.Point(3, 123)
        Me.FridgeContentsButton.Name = "FridgeContentsButton"
        Me.FridgeContentsButton.Size = New System.Drawing.Size(212, 41)
        Me.FridgeContentsButton.TabIndex = 3
        Me.FridgeContentsButton.Text = "Fridge View"
        '
        'SidePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.BurgerExpand)
        Me.Controls.Add(Me.SlideButton)
        Me.Controls.Add(Me.BurgerShrink)
        Me.Name = "SidePanel"
        Me.Size = New System.Drawing.Size(364, 556)
        CType(Me.BurgerShrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlideButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurgerExpand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BurgerShrink As PictureBox
    Friend WithEvents SlideButton As PictureBox
    Friend WithEvents BurgerExpand As PictureBox
    Friend WithEvents MenuPanel As FlowLayoutPanel
    Friend WithEvents CurrentListButton As Label
    Friend WithEvents SavedListButton As Label
    Friend WithEvents RecipesButton As Label
    Friend WithEvents FridgeContentsButton As Label
End Class
