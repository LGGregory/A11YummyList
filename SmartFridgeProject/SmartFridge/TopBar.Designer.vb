<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopBar
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
        Me.AddToCurrentListButton = New SmartFridge.TopBarButton()
        Me.CopyToCurrentListButton = New SmartFridge.TopBarButton()
        Me.SuspendLayout()
        '
        'AddToCurrentListButton
        '
        Me.AddToCurrentListButton.Location = New System.Drawing.Point(467, 0)
        Me.AddToCurrentListButton.Name = "AddToCurrentListButton"
        Me.AddToCurrentListButton.Size = New System.Drawing.Size(40, 40)
        Me.AddToCurrentListButton.TabIndex = 1
        '
        'CopyToCurrentListButton
        '
        Me.CopyToCurrentListButton.Location = New System.Drawing.Point(513, 0)
        Me.CopyToCurrentListButton.Name = "CopyToCurrentListButton"
        Me.CopyToCurrentListButton.Size = New System.Drawing.Size(40, 40)
        Me.CopyToCurrentListButton.TabIndex = 0
        '
        'TopBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.AddToCurrentListButton)
        Me.Controls.Add(Me.CopyToCurrentListButton)
        Me.Name = "TopBar"
        Me.Size = New System.Drawing.Size(590, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CopyToCurrentListButton As TopBarButton
    Friend WithEvents AddToCurrentListButton As TopBarButton
End Class
