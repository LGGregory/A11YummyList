Public Class SmallItemBar

    Public ItemName As String
    Public ItemUnit As String
    Public ParentItemPanel As AllItemsPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = "New Item"
        ItemUnit = "Units"
        NameLabel.Text = ItemName
        EditNameBox.Hide()

    End Sub

    Public Sub New(name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = name
        ItemUnit = "Units"
        NameLabel.Text = ItemName
        EditNameBox.Hide()
    End Sub

    Public Sub New(name As String, unit As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemName = name
        ItemUnit = unit
        EditNameBox.Hide()
        NameLabel.Text = ItemName

    End Sub

    Dim EditingMode As Boolean = False

    Private Sub EditBox_Click(sender As Object, e As EventArgs) Handles EditBox.Click
        ' TODO Edit Mode - Replace the label with textbox, let it be modified, then turn it back into a label
        StartEditing()
        ' TODO talk to keyboard? Done key? Look in keyboard definition
    End Sub

    Public Sub StartEditing()
        If EditingMode Then
            If Not EditNameBox.Text.Trim = "" Then
                EditingMode = False
                ItemName = EditNameBox.Text
                NameLabel.Text = ItemName
                EditNameBox.Hide()
                NameLabel.Show()
            End If
        Else
            EditingMode = True
            NameLabel.Hide()
            EditNameBox.Text = NameLabel.Text
            EditNameBox.Show()
            EditNameBox.Focus()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ParentItemPanel.DeleteItem(Me)

    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click
        ParentItemPanel.AddItem(New ItemInfo(ItemName, 1, ItemUnit))

    End Sub

End Class
