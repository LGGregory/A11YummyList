﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneDisplay
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
        Me.SidePanel1 = New SmartFridge.SidePanel()
        Me.SuspendLayout()
        '
        'SidePanel1
        '
        Me.SidePanel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.SidePanel1.Location = New System.Drawing.Point(0, 0)
        Me.SidePanel1.Name = "SidePanel1"
        Me.SidePanel1.Size = New System.Drawing.Size(69, 518)
        Me.SidePanel1.TabIndex = 0
        '
        'PhoneDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 518)
        Me.Controls.Add(Me.SidePanel1)
        Me.Name = "PhoneDisplay"
        Me.Text = "Phone"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SidePanel1 As SidePanel
End Class
