Public Class TopBar
    Private Fridge As SmartFridgeDisplay

    Public Sub New(parent As SmartFridgeDisplay)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Fridge = parent
        ToolTip1.SetToolTip(AddButton, "Add contents to shopping list")
        ToolTip1.SetToolTip(CopyButton, "Replace shopping list with this one")

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Fridge.AddToSavedList(Fridge.CurrentListPanel.UpdatingList)
        Fridge.CurrentListPanel.HideFridge()
        Fridge.CurrentListPanel.LoadList(Fridge.BaseList)
        Fridge.ShowList(Fridge.BaseList, False)
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Fridge.CopyToCurrentList(Fridge.CurrentListPanel.UpdatingList)
        Fridge.CurrentListPanel.HideFridge()
        Fridge.CurrentListPanel.LoadList(Fridge.BaseList)
        Fridge.ShowList(Fridge.BaseList, False)
    End Sub

End Class
