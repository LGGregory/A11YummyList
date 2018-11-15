Public Class SmartFridgeDisplay
    Public ActivePanel As GroceryListPanel
    Public ListOfLists As New List(Of GroceryListPanel)

    Private Sub SmartFridgeDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load
        ActivePanel = GroceryListDefault
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Dim f As New AddItemForm(ActivePanel)
        f.Show()
    End Sub

    Public Sub DimPanel()

    End Sub

    Public Sub UnDimPanel()

    End Sub

    ' Adds a new Grocery List
    ' Possible TODO: Rewrite GroceryListPanel as a seperate class from the Panel
    ' That way porting it to Phone interpretation is easier
    Public Sub AddList(ByRef List As GroceryListPanel)
        ' TODO
    End Sub
End Class
