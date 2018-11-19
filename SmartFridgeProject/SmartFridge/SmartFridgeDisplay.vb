Public Class SmartFridgeDisplay
    Public CurrentListPanel As GroceryListPanel
    Public SavedListsPanel As ListOfListsPanel
    Public CurrentSavedListPanel As GroceryListPanel
    Public ListOfLists As New List(Of GroceryListPanel)
    Public dataListener As New DataListenerFridge(Me)
    Public TopBar As TopBar

    Private Sub SmartFridgeDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load

        addGroceryList("Sample List 1", "A Sample List")
        addGroceryList("Sample List 2", "A Sample List")
        addGroceryList("Sample List 3", "A Sample List")
        addGroceryList("Sample List 4", "A Sample List")

        CurrentSavedListPanel = ListOfLists.First()

        CurrentListPanel = New GroceryListPanel("Current List", "Your Current List")
        Me.Controls.Add(CurrentListPanel)
        CurrentListPanel.Location = New Point(92, 0)
        CurrentListPanel.Show()
        SavedListsPanel = New ListOfListsPanel(Me)
        Me.Controls.Add(SavedListsPanel)
        SavedListsPanel.Location = New Point(92, 0)
        SavedListsPanel.Hide()

        TopBar = New TopBar(Me)
        Me.Controls.Add(TopBar)
        TopBar.Location = New Point(5, 0)
        TopBar.Hide()


    End Sub

    Public Sub addGroceryList(name As String, about As String)
        Dim NewList As GroceryListPanel
        NewList = New GroceryListPanel(name, about)
        Me.Controls.Add(NewList)
        NewList.Location = New Point(92, 40)
        NewList.Size = New Point(465, 670)
        NewList.Hide()
        ListOfLists.Add(NewList)
    End Sub

    Public Sub AddToSavedList(list As GroceryListPanel)
        For Each item As ItemInfo In list.Current.GroceryList
            If CurrentListPanel.Current.hasSameItemByName(item) Then
                CurrentListPanel.Current.getSameItemByName(item).Quantity += item.Quantity
            Else
                CurrentListPanel.AddItem(CurrentListPanel.Current, item)
            End If
            CurrentListPanel.ApplyChanges()
        Next
    End Sub

    Public Sub CopyToCurrentList(list As GroceryListPanel)
        CurrentListPanel.LoadList(list.Current)
    End Sub

    Public Sub showSavedListsPanel()
        CurrentSavedListPanel.Hide()
        CurrentListPanel.Hide()
        SavedListsPanel.Show()
        TopBar.Hide()
    End Sub

    Public Sub showCurrentListPanel()
        CurrentSavedListPanel.Hide()
        SavedListsPanel.Hide()
        TopBar.Hide()
        CurrentListPanel.Show()
    End Sub

    Public Sub setCurrentSavedListPanel(panel As GroceryListPanel)
        CurrentListPanel.Hide()
        SavedListsPanel.Hide()
        TopBar.Show()
        CurrentSavedListPanel.Hide()
        CurrentSavedListPanel = panel
        CurrentSavedListPanel.Show()

    End Sub

    Public Sub DimPanel()
        Me.BackColor = System.Drawing.Color.Silver
        CurrentListPanel.BackColor = System.Drawing.Color.Silver
        SavedListsPanel.BackColor = System.Drawing.Color.Silver
        CurrentSavedListPanel.BackColor = System.Drawing.Color.Silver
    End Sub

    Public Sub UnDimPanel()
        Me.BackColor = System.Drawing.Color.White
        CurrentListPanel.BackColor = System.Drawing.Color.White
        CurrentSavedListPanel.BackColor = System.Drawing.Color.White
        SavedListsPanel.BackColor = System.Drawing.Color.White
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

    Public Sub InitNetwork(IPAddress As String, PortNumber As Integer)
        dataListener.Connect(IPAddress, PortNumber)
    End Sub
End Class
