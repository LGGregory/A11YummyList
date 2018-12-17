<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllItemsPanel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Keyboard1 = New SmartFridge.Keyboard()
        Me.SuspendLayout()
        '
        'ListTitle
        '
        Me.ListTitle.AutoSize = True
        Me.ListTitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTitle.Location = New System.Drawing.Point(114, 4)
        Me.ListTitle.Name = "ListTitle"
        Me.ListTitle.Size = New System.Drawing.Size(131, 32)
        Me.ListTitle.TabIndex = 4
        Me.ListTitle.Text = "All Items"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search:"
        '
        'SearchBox
        '
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(126, 55)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(191, 29)
        Me.SearchBox.TabIndex = 6
        '
        'FlowPanel
        '
        Me.FlowPanel.AutoScroll = True
        Me.FlowPanel.Location = New System.Drawing.Point(4, 90)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(352, 205)
        Me.FlowPanel.TabIndex = 8
        '
        'Keyboard1
        '
        Me.Keyboard1.Location = New System.Drawing.Point(4, 301)
        Me.Keyboard1.Name = "Keyboard1"
        Me.Keyboard1.Size = New System.Drawing.Size(354, 137)
        Me.Keyboard1.TabIndex = 7
        '
        'AllItemsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.FlowPanel)
        Me.Controls.Add(Me.Keyboard1)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListTitle)
        Me.Name = "AllItemsPanel"
        Me.Size = New System.Drawing.Size(359, 436)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Keyboard1 As Keyboard
    Friend WithEvents FlowPanel As FlowLayoutPanel
End Class
