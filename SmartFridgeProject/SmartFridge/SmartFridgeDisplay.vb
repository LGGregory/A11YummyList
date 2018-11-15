Public Class SmartFridgeDisplay
    Public ActivePanel As GroceryListPanel
    Public ListOfLists As New List(Of GroceryListPanel)

    Private Sub SmartFridgeDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load
        ActivePanel = GroceryListDefault
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
