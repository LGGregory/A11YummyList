<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SmallItemBar
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditNameBox = New System.Windows.Forms.TextBox()
        Me.EditBox = New System.Windows.Forms.PictureBox()
        CType(Me.EditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(14, 11)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(0, 25)
        Me.NameLabel.TabIndex = 0
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(257, 7)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(32, 32)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "X"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditNameBox
        '
        Me.EditNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditNameBox.Location = New System.Drawing.Point(14, 9)
        Me.EditNameBox.Name = "EditNameBox"
        Me.EditNameBox.Size = New System.Drawing.Size(199, 31)
        Me.EditNameBox.TabIndex = 3
        '
        'EditBox
        '
        Me.EditBox.Image = Global.SmartFridge.My.Resources.Resources.Edit
        Me.EditBox.Location = New System.Drawing.Point(219, 7)
        Me.EditBox.Name = "EditBox"
        Me.EditBox.Size = New System.Drawing.Size(32, 32)
        Me.EditBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EditBox.TabIndex = 2
        Me.EditBox.TabStop = False
        '
        'SmallItemBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EditNameBox)
        Me.Controls.Add(Me.EditBox)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "SmallItemBar"
        Me.Size = New System.Drawing.Size(292, 48)
        CType(Me.EditBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditBox As PictureBox
    Friend WithEvents EditNameBox As TextBox
End Class