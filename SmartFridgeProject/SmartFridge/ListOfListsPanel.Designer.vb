<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOfListsPanel
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
        Me.PanelTitle = New System.Windows.Forms.Label()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddListButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.AutoSize = True
        Me.PanelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTitle.Location = New System.Drawing.Point(133, 22)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(124, 25)
        Me.PanelTitle.TabIndex = 4
        Me.PanelTitle.Text = "Saved Lists"
        '
        'FlowPanel
        '
        Me.FlowPanel.Location = New System.Drawing.Point(0, 64)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(465, 391)
        Me.FlowPanel.TabIndex = 5
        '
        'AddListButton
        '
        Me.AddListButton.Location = New System.Drawing.Point(332, 478)
        Me.AddListButton.Name = "AddListButton"
        Me.AddListButton.Size = New System.Drawing.Size(75, 23)
        Me.AddListButton.TabIndex = 11
        Me.AddListButton.Text = "Add List"
        Me.AddListButton.UseVisualStyleBackColor = True
        '
        'ListOfListsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddListButton)
        Me.Controls.Add(Me.FlowPanel)
        Me.Controls.Add(Me.PanelTitle)
        Me.Name = "ListOfListsPanel"
        Me.Size = New System.Drawing.Size(465, 710)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitle As Label
    Friend WithEvents FlowPanel As FlowLayoutPanel
    Friend WithEvents AddListButton As Button
End Class
