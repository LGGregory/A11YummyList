<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TimeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPPortLabel = New System.Windows.Forms.Label()
        Me.ClientCountLabel = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server IP/Port:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client Count:"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeColumn, Me.InfoColumn})
        Me.DGV.Location = New System.Drawing.Point(1, 119)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(325, 331)
        Me.DGV.TabIndex = 2
        '
        'TimeColumn
        '
        Me.TimeColumn.HeaderText = "Time"
        Me.TimeColumn.Name = "TimeColumn"
        Me.TimeColumn.Width = 80
        '
        'InfoColumn
        '
        Me.InfoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InfoColumn.HeaderText = "Information"
        Me.InfoColumn.Name = "InfoColumn"
        '
        'IPPortLabel
        '
        Me.IPPortLabel.AutoSize = True
        Me.IPPortLabel.Location = New System.Drawing.Point(186, 23)
        Me.IPPortLabel.Name = "IPPortLabel"
        Me.IPPortLabel.Size = New System.Drawing.Size(39, 13)
        Me.IPPortLabel.TabIndex = 3
        Me.IPPortLabel.Text = "Label3"
        '
        'ClientCountLabel
        '
        Me.ClientCountLabel.AutoSize = True
        Me.ClientCountLabel.Location = New System.Drawing.Point(186, 55)
        Me.ClientCountLabel.Name = "ClientCountLabel"
        Me.ClientCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.ClientCountLabel.TabIndex = 4
        Me.ClientCountLabel.Text = "0"
        '
        'ServerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 450)
        Me.Controls.Add(Me.ClientCountLabel)
        Me.Controls.Add(Me.IPPortLabel)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ServerForm"
        Me.Text = "ServerForm"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TimeColumn As DataGridViewTextBoxColumn
    Friend WithEvents InfoColumn As DataGridViewTextBoxColumn
    Friend WithEvents IPPortLabel As Label
    Friend WithEvents ClientCountLabel As Label
End Class
