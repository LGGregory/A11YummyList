Public Class TopBar
    Private Fridge As SmartFridgeDisplay

    Public Sub New(parent As SmartFridgeDisplay)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Fridge = parent
        ToolTip1.SetToolTip(AddButton, "Add contents to current shopping list")
        ToolTip1.SetToolTip(CopyButton, "Replace current shopping list with this list")
        ToolTip1.SetToolTip(ButtonAddRecipe, "Add unowned items to current shopping list")
        ButtonAddRecipe.Hide()
        ButtonAddRecipe.Location = New Point(481, 1)

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Fridge.AddToSavedList(Fridge.CurrentListPanel.UpdatingList)
        Fridge.CurrentListPanel.HideFridge()
        Fridge.CurrentListPanel.LoadList(Fridge.BaseList)
        Fridge.ShowList(Fridge.BaseList, False, False)
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Fridge.CopyToCurrentList(Fridge.CurrentListPanel.UpdatingList)
        Fridge.CurrentListPanel.HideFridge()
        Fridge.CurrentListPanel.LoadList(Fridge.BaseList)
        Fridge.ShowList(Fridge.BaseList, False, False)
    End Sub

    Private Sub ButtonAddRecipe_Click(sender As Object, e As EventArgs) Handles ButtonAddRecipe.Click
        Fridge.AddRecipeToList(Fridge.CurrentListPanel.UpdatingList)
        Fridge.CurrentListPanel.HideFridge()
        Fridge.CurrentListPanel.LoadList(Fridge.BaseList)
        Fridge.ShowList(Fridge.BaseList, False, False)
    End Sub

    Public Sub RecipeMode()
        ButtonAddRecipe.Show()
        AddButton.Hide()
        CopyButton.Hide()

    End Sub

    Public Sub SavedMode()
        ButtonAddRecipe.Hide()
        AddButton.Show()
        CopyButton.Show()

    End Sub

End Class
