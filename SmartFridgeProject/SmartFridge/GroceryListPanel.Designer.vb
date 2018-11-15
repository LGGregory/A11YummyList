<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'ListTitle
        '
        Me.ListTitle.AutoSize = True
        Me.ListTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTitle.Location = New System.Drawing.Point(133, 22)
        Me.ListTitle.Name = "ListTitle"
        Me.ListTitle.Size = New System.Drawing.Size(220, 25)
        Me.ListTitle.TabIndex = 3
        Me.ListTitle.Text = "Current Shopping List"
        '
        'FlowPanel
        '
        Me.FlowPanel.Location = New System.Drawing.Point(0, 64)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(445, 571)
        Me.FlowPanel.TabIndex = 4
        '
        'GroceryListPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowPanel)
        Me.Controls.Add(Me.ListTitle)
        Me.Name = "GroceryListPanel"
        Me.Size = New System.Drawing.Size(445, 635)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListTitle As Label
    Friend WithEvents FlowPanel As FlowLayoutPanel
End Class
