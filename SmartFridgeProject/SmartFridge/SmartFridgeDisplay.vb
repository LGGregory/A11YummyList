Public Class SmartFridgeDisplay
    Public CurrentListPanel As GroceryListPanel
    Public SavedListsPanel As ListOfListsPanel
    Public ListOfLists As New List(Of GroceryListPanel)

    Private Sub SmartFridgeDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListOfLists.Add(New GroceryListPanel("Sample List 1", "A Sample List"))
        ListOfLists.Add(New GroceryListPanel("Sample List 2", "A Sample List"))
        ListOfLists.Add(New GroceryListPanel("Sample List 3", "A Sample List"))
        ListOfLists.Add(New GroceryListPanel("Sample List 4", "A Sample List"))
        ListOfLists.Add(New GroceryListPanel("Sample List 5", "A Sample List"))

        For Each panel As GroceryListPanel In ListOfLists
            Me.Controls.Add(panel)
            panel.Left = 92
            panel.Top = 0
            panel.Hide()
        Next

        CurrentListPanel = ListOfLists.ElementAt(0)
        CurrentListPanel.Show()
        SavedListsPanel = New ListOfListsPanel(Me)
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

    Public Sub setCurrentListPanel(panel As GroceryListPanel)
        CurrentListPanel.Hide()
        CurrentListPanel = panel
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
