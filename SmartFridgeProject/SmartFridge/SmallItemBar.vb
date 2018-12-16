Public Class SmallItemBar


    Public ItemName As String
    Public ParentItemPanel As AllItemsPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = "Blank"
        EditBox1.Hide()
        NameLabel.Text = ItemName
    End Sub

    Public Sub New(name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = name
        EditBox1.Hide()
        NameLabel.Text = ItemName
    End Sub

    Dim EditingMode As Boolean = False

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles EditBox.Click
        ' TODO Edit Mode - Replace the label with textbox, let it be modified, then turn it back into a label
        If EditingMode Then
            If Not EditBox1.Text.Trim = "" Then
                EditingMode = False
                ItemName = EditBox1.Text
                NameLabel.Text = ItemName
                EditBox1.Hide()
                NameLabel.Show()
            End If
        Else
            EditingMode = True
            NameLabel.Hide()
            EditBox1.Text = NameLabel.Text
            EditBox1.Show()
        End If

        ' TODO talk to keyboard? Done key? Look in keyboard definition
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ParentItemPanel.DeleteItem(Me)

    End Sub

End Class
