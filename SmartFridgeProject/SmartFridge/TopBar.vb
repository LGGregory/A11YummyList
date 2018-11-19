Public Class TopBar
    Private Fridge As SmartFridgeDisplay

    Public Sub New(parent As SmartFridgeDisplay)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Fridge = parent

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Fridge.AddToSavedList(Fridge.CurrentListPanel.UpdatingList)
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Fridge.CopyToCurrentList(Fridge.CurrentListPanel.UpdatingList)
    End Sub
End Class
