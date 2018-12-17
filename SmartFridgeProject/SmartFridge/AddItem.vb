Public Class AddItemForm
    Dim ParentList As GroceryListPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



    End Sub

    Public Sub New(ByRef AddList As ContentPanel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ParentList = AddList
        Me.Text = "Add Item to " & ParentList.Current.Name

    End Sub

    Private Sub CancelAddButton_Click(sender As Object, e As EventArgs) Handles CancelAddButton.Click
        Close()
    End Sub

    Private Sub ConfirmAddButton_Click(sender As Object, e As EventArgs) Handles ConfirmAddButton.Click
        ParentList.AddItem(ParentList.Current, New ItemInfo(ItemName.Text, CInt(Quantity.Text), UnitList.SelectedItem))
        ParentList.ListChanged()
        Close()

    End Sub
End Class