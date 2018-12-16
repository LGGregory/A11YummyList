Public Class SmallItemBar


    Public ItemName As String
    Public ItemUnit As String
    Public ParentItemPanel As AllItemsPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = "Blank"
        ItemUnit = "Units"
        EditBox1.Hide()
        NameLabel.Text = ItemName
        DeleteButton.Hide()
        EditBox.Hide()

    End Sub

    Public Sub New(name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = name
        ItemUnit = "Units"
        EditBox1.Hide()
        NameLabel.Text = ItemName
        DeleteButton.Hide()
        EditBox.Hide()
    End Sub

    Public Sub New(name As String, unit As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = name
        ItemUnit = unit
        EditBox1.Hide()
        NameLabel.Text = ItemName
        DeleteButton.Hide()
        EditBox.Hide()
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

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click
        ParentItemPanel.AddItem(New ItemInfo(ItemName, 1, ItemUnit))

    End Sub
End Class
