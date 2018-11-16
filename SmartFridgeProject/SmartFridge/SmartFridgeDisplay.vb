Public Class SmartFridgeDisplay
    Public CurrentListPanel As GroceryListPanel
    Public SavedListsPanel As ListOfListsPanel
    Public ListOfLists As New List(Of GroceryListPanel)

    Private Sub SmartFridgeDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load
        CurrentListPanel = New GroceryListPanel
        Me.Controls.Add(CurrentListPanel)
        CurrentListPanel.Left = 92
        CurrentListPanel.Top = 0
        CurrentListPanel.Show()
        SavedListsPanel = New ListOfListsPanel
        Me.Controls.Add(SavedListsPanel)
        SavedListsPanel.Left = 92
        SavedListsPanel.Top = 0
        SavedListsPanel.Hide()




    End Sub

    Public Sub showSavedListsPanel()
        CurrentListPanel.Hide()
        SavedListsPanel.Show()
    End Sub

    Public Sub showCurrentListPanel()
        SavedListsPanel.Hide()
        CurrentListPanel.Show()
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

    'Private Sub GroceryListDefault_Load(sender As Object, e As EventArgs) Handles GroceryListDefault.Load

    'End Sub

    Private Sub SidePanel1_Load(sender As Object, e As EventArgs) Handles SidePanel1.Load
        SidePanel1.SetParent(Me)
    End Sub
End Class
