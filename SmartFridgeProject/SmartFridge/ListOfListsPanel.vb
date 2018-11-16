Public Class ListOfListsPanel
    Dim Fridge As SmartFridgeDisplay

    Private Sub AddListButton_Click(sender As Object, e As EventArgs) Handles AddListButton.Click
        Dim f As New AddList(Me)
        f.Show()
    End Sub

    Public Sub New(parent As SmartFridgeDisplay)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Fridge = parent
        For Each list As GroceryListPanel In Fridge.ListOfLists
            FlowPanel.Controls.Add(New ListBar(list, Me))
        Next
    End Sub

    Public Sub removeListBar(bar As ListBar, listPanel As GroceryListPanel)
        Fridge.ListOfLists.Remove(listPanel)
        FlowPanel.Controls.Remove(bar)
    End Sub

    Public Sub addNewList(name As String)
        Fridge.ListOfLists.Add(New GroceryListPanel(name, "A New List"))
        FlowPanel.Controls.Add(New ListBar(Fridge.ListOfLists.Last, Me))
    End Sub

    Public Sub setCurrentListPanel(panel As GroceryListPanel)
        Fridge.setCurrentListPanel(panel)
    End Sub

    Private Sub ListOfListsPanel_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
