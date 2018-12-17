<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopBar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopBar))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddNeeded = New System.Windows.Forms.PictureBox()
        Me.AddAll = New System.Windows.Forms.PictureBox()
        CType(Me.AddNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddNeeded
        '
        Me.AddNeeded.Image = Global.SmartFridge.My.Resources.Resources.AddNeeded
        Me.AddNeeded.Location = New System.Drawing.Point(435, 2)
        Me.AddNeeded.Name = "AddNeeded"
        Me.AddNeeded.Size = New System.Drawing.Size(65, 37)
        Me.AddNeeded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddNeeded.TabIndex = 0
        Me.AddNeeded.TabStop = False
        '
        'AddAll
        '
        Me.AddAll.Image = CType(resources.GetObject("AddAll.Image"), System.Drawing.Image)
        Me.AddAll.Location = New System.Drawing.Point(506, 2)
        Me.AddAll.Name = "AddAll"
        Me.AddAll.Size = New System.Drawing.Size(65, 37)
        Me.AddAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddAll.TabIndex = 1
        Me.AddAll.TabStop = False
        '
        'TopBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.AddAll)
        Me.Controls.Add(Me.AddNeeded)
        Me.Name = "TopBar"
        Me.Size = New System.Drawing.Size(590, 40)
        CType(Me.AddNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AddNeeded As PictureBox
    Friend WithEvents AddAll As PictureBox
End Class
