<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
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
        Me.FridgeButton = New System.Windows.Forms.Button()
        Me.PhoneButton = New System.Windows.Forms.Button()
        Me.ServerButton = New System.Windows.Forms.Button()
        Me.IPBox = New System.Windows.Forms.TextBox()
        Me.PortBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FridgeButton
        '
        Me.FridgeButton.Location = New System.Drawing.Point(109, 78)
        Me.FridgeButton.Name = "FridgeButton"
        Me.FridgeButton.Size = New System.Drawing.Size(75, 23)
        Me.FridgeButton.TabIndex = 0
        Me.FridgeButton.Text = "Fridge"
        Me.FridgeButton.UseVisualStyleBackColor = True
        '
        'PhoneButton
        '
        Me.PhoneButton.Location = New System.Drawing.Point(109, 127)
        Me.PhoneButton.Name = "PhoneButton"
        Me.PhoneButton.Size = New System.Drawing.Size(75, 23)
        Me.PhoneButton.TabIndex = 1
        Me.PhoneButton.Text = "Phone"
        Me.PhoneButton.UseVisualStyleBackColor = True
        '
        'ServerButton
        '
        Me.ServerButton.Location = New System.Drawing.Point(109, 176)
        Me.ServerButton.Name = "ServerButton"
        Me.ServerButton.Size = New System.Drawing.Size(75, 23)
        Me.ServerButton.TabIndex = 2
        Me.ServerButton.Text = "Server"
        Me.ServerButton.UseVisualStyleBackColor = True
        '
        'IPBox
        '
        Me.IPBox.Location = New System.Drawing.Point(128, 12)
        Me.IPBox.Name = "IPBox"
        Me.IPBox.Size = New System.Drawing.Size(100, 20)
        Me.IPBox.TabIndex = 3
        Me.IPBox.Text = "108.162.155.44"
        '
        'PortBox
        '
        Me.PortBox.Location = New System.Drawing.Point(128, 38)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(100, 20)
        Me.PortBox.TabIndex = 4
        Me.PortBox.Text = "9210"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IP Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Port:"
        '
        'LoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 221)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.IPBox)
        Me.Controls.Add(Me.ServerButton)
        Me.Controls.Add(Me.PhoneButton)
        Me.Controls.Add(Me.FridgeButton)
        Me.Name = "LoadingScreen"
        Me.Text = "YummyList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FridgeButton As Button
    Friend WithEvents PhoneButton As Button
    Friend WithEvents ServerButton As Button
    Friend WithEvents IPBox As TextBox
    Friend WithEvents PortBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
