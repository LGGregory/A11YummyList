Imports Newtonsoft.Json
Imports SmartFridge

Public Class SmartFridgeDisplay
    ' TODO Resizing
    ' TODO Replace Add Item with AllItemsPanel showing - note temp showing of allitemspanel overtop everything - see below
    ' TODO Shopping interface
    ' TODO stocking the fridge after shopping - server stuff? yeah, sending json fun






    Public CurrentListPanel As GroceryListPanel
    Public SavedListsPanel As ListOfListsPanel
    Public SavedRecipesPanel As ListOfListsPanel
    Public CurrentList As iListOfItems
    Public BaseList As GroceryList
    Public FridgeContents As GroceryList
    Public ListOfGLists As New List(Of GroceryList)
    Public ListOfRLists As New List(Of GroceryList) ' NYI: Recipe list as different
    Public dataListener As DataListener
    Public TopBar As TopBar
    Public NoBar As New Point(92, 0)
    Public WiBar As New Point(92, 40)
    Public Bot As New Point(465, 680)

    Public ItemsPanel As AllItemsPanel

    Public FridgeOrPhone As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FridgeOrPhone = True
        dataListener = New DataListenerFridge
        dataListener.formSet(Me)


    End Sub

    Public Sub New(fridge As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FridgeOrPhone = fridge
        If FridgeOrPhone Then
            dataListener = New DataListenerFridge
            dataListener.formSet(Me)
            Text = "Fridge"
        Else
            dataListener = New DataListenerPhone
            dataListener.formSet(Me)
            Text = "Phone"
        End If


    End Sub



    Private Sub SmartFridgeDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load

        FridgeContents = New GroceryList("Fridge", "The contents of the fridge." & vbNewLine & "Why do you have so many pickles?", False)
        FridgeContents.AddItem(New ItemInfo("Sweet Pickles", 700, "ct"))
        FridgeContents.AddItem(New ItemInfo("Dill Pickles", 320, "ct"))
        FridgeContents.AddItem(New ItemInfo("Kosher Sandwich Pickles", 20, "ct"))
        FridgeContents.AddItem(New ItemInfo("Cucumbers in Brine", 6, "kg"))

        ItemsPanel = New AllItemsPanel()
        Me.Controls.Add(ItemsPanel)
        ItemsPanel.Location = New Point(100, 60)
        ItemsPanel.Hide()

        SavedListsPanel = New ListOfListsPanel(Me, True)
        Me.Controls.Add(SavedListsPanel)
        SavedListsPanel.Location = NoBar
        SavedListsPanel.Hide()

        SavedRecipesPanel = New ListOfListsPanel(Me, False)
        Me.Controls.Add(SavedRecipesPanel)
        SavedRecipesPanel.Location = NoBar
        SavedRecipesPanel.Hide()


        CurrentList = New GroceryList("Current List", " ", False)
        CurrentList.AddItem(New ItemInfo("Cream Cheese", 1, "lbs"))
        BaseList = CurrentList

        CurrentListPanel = New GroceryListPanel(Me, CurrentList)
        If Not FridgeOrPhone Then
            CurrentListPanel.HideFridge()
        End If
        Me.Controls.Add(CurrentListPanel)
        CurrentListPanel.Location = NoBar
        CurrentListPanel.Size = Bot
        CurrentListPanel.Show()

        Dim GL1 As New GroceryList("Veggies", "Tasty, delicious, fresh.", False)
        GL1.AddItem(New ItemInfo("Broccoli", 3, "Kg"))
        GL1.AddItem(New ItemInfo("Mushrooms", 6, "lbs"))
        GL1.AddItem(New ItemInfo("Red Peppers", 4, "ct"))
        GL1.AddItem(New ItemInfo("Brussel Sprouts", 2, "Kg"))
        addGroceryList(GL1)

        Dim GL2 As New GroceryList("Junk Food", "Kids night in", False)
        GL2.AddItem(New ItemInfo("Salsa", 1, "L"))
        GL2.AddItem(New ItemInfo("Vanilla Ice Cream", 3, "Qt"))
        GL2.AddItem(New ItemInfo("Corn Chips", 4, "Bags"))
        GL2.AddItem(New ItemInfo("Dill Pickles", 2, "Kg"))
        GL2.AddItem(New ItemInfo("Mozzarella", 1, "lbs"))
        addGroceryList(GL2)

        Dim GL3 As New GroceryList("Breakfasts", "First meal best meal", False)
        GL3.AddItem(New ItemInfo("Bacon", 5, "lbs"))
        GL3.AddItem(New ItemInfo("Eggs", 24, "ct"))
        GL3.AddItem(New ItemInfo("Bread", 2, "ct"))
        GL3.AddItem(New ItemInfo("Raspberry Jam", 1, "Kg"))
        addGroceryList(GL3)

        Dim GL4 As New GroceryList("LCBO", "Alcomohol is love", False)
        GL4.AddItem(New ItemInfo("Sherry", 750, "mL"))
        GL4.AddItem(New ItemInfo("Kraken", 1250, "mL"))
        GL4.AddItem(New ItemInfo("Sibling Rivalry White 2009", 2, "ct"))
        addGroceryList(GL4)

        Dim RL1 As New GroceryList("Steak", "Grill till done." & vbNewLine & "Probably with less salt", False)
        RL1.AddItem(New ItemInfo("Grilling Steak", 1, "ct"))
        RL1.AddItem(New ItemInfo("Salt", 1, "Kg"))
        addRecipeList(RL1)

        Dim RL2 As New GroceryList("Mozzarella Pickles", "1. Heat oil in wok" & vbNewLine & "2. Grate cheese" & vbNewLine & "3. Cover pickles in cheese" & vbNewLine & "4. Immerse pickes in oil for 2 min" & vbNewLine & "5. Serve immediately with sauce of choice.", False)
        RL2.AddItem(New ItemInfo("Dill Pickles", 20, "ct"))
        RL2.AddItem(New ItemInfo("Mozzarella Cheese", 1, "lbs"))
        RL2.AddItem(New ItemInfo("BBQ sauce", 1, "Kg"))
        RL2.AddItem(New ItemInfo("Vegetable Oil", 1, "L"))
        addRecipeList(RL2)

        TopBar = New TopBar(Me)
        Me.Controls.Add(TopBar)
        TopBar.Location = New Point(5, 0)
        TopBar.Hide()

        ItemsPanel.Show() ' TODO get rid of this
    End Sub



    Private Sub addRecipeList(rList As iListOfItems)
        ListOfRLists.Add(rList)
        SavedRecipesPanel.AddNewList(rList)
    End Sub

    Public Sub addGroceryList(name As String, about As String)
        Dim NewGList As New GroceryList(name, about, True)
        ListOfGLists.Add(NewGList)
        SavedListsPanel.AddNewList(NewGList)

    End Sub

    Public Sub addGroceryList(gList As GroceryList)
        ListOfGLists.Add(gList)
        SavedListsPanel.AddNewList(gList)
    End Sub

    Friend Sub AddRecipeToList(list As iListOfItems)
        For Each item As ItemInfo In list.List
            If FridgeContents.hasSameItemByName(item) Then
                If BaseList.hasSameItemByName(item) Then
                    If item.Quantity > BaseList.getSameItemByName(item).Quantity + FridgeContents.getSameItemByName(item).Quantity Then
                        BaseList.getSameItemByName(item).Quantity = item.Quantity - FridgeContents.getSameItemByName(item).Quantity
                    End If
                Else
                    If item.Quantity > FridgeContents.getSameItemByName(item).Quantity Then
                        item.Quantity -= FridgeContents.getSameItemByName(item).Quantity
                        BaseList.AddItem(item)
                    End If
                End If
            Else
                If BaseList.hasSameItemByName(item) Then
                    If item.Quantity > BaseList.getSameItemByName(item).Quantity Then
                        BaseList.getSameItemByName(item).Quantity = item.Quantity
                    End If
                Else
                    BaseList.AddItem(item)
                End If
            End If
        Next
    End Sub

    Public Sub AddToSavedList(list As iListOfItems)
        For Each item As ItemInfo In list.List
            If BaseList.hasSameItemByName(item) Then
                BaseList.getSameItemByName(item).Quantity += item.Quantity
            Else
                BaseList.AddItem(item)
            End If
        Next
    End Sub

    Public Sub CopyToCurrentList(list As iListOfItems)
        BaseList.MatchList(list, False)

    End Sub

    Public Sub showSavedListsPanel()
        CurrentListPanel.Hide()
        SavedRecipesPanel.Hide()
        SavedListsPanel.Show()
        TopBar.Hide()
    End Sub

    Friend Sub showRecipesPanel()
        CurrentListPanel.Hide()
        SavedListsPanel.Hide()
        SavedRecipesPanel.Show()
        TopBar.Hide()
    End Sub

    Public Sub showCurrentListPanel()
        SavedRecipesPanel.Hide()
        SavedListsPanel.Hide()
        TopBar.Hide()
        CurrentListPanel.Show()
    End Sub

    Public Sub ShowList(list As iListOfItems, bar As Boolean, recipes As Boolean)
        SavedRecipesPanel.Hide()
        SavedListsPanel.Hide()
        CurrentList = list
        CurrentListPanel.LoadList(list)
        If bar Then
            If recipes Then
                TopBar.RecipeMode()
            Else
                TopBar.SavedMode()
            End If
            TopBar.Show()
            CurrentListPanel.Location = WiBar
        Else
            TopBar.Hide()
            CurrentListPanel.Location = NoBar
        End If
        CurrentListPanel.Show()
    End Sub

    Public Sub ShowRecipe(recipe As Recipe)
        SavedListsPanel.Hide()
        SavedRecipesPanel.Show()
        TopBar.Hide()

    End Sub

    Public Sub DimPanel()
        Me.BackColor = System.Drawing.Color.Silver
        CurrentListPanel.BackColor = System.Drawing.Color.Silver
        SavedListsPanel.BackColor = System.Drawing.Color.Silver
    End Sub

    Public Sub UnDimPanel()
        Me.BackColor = System.Drawing.Color.White
        CurrentListPanel.BackColor = System.Drawing.Color.White
        SavedListsPanel.BackColor = System.Drawing.Color.White
    End Sub



    'Private Sub GroceryListDefault_Load(sender As Object, e As EventArgs) Handles GroceryListDefault.Load

    'End Sub

    Private Sub SidePanel1_Load(sender As Object, e As EventArgs) Handles SidePanel1.Load
        SidePanel1.SetParent(Me)
    End Sub

    Public Sub InitNetwork(IPAddress As String, PortNumber As Integer)
        dataListener.formSet(Me)
        dataListener.Connect(IPAddress, PortNumber)
    End Sub

    Public Sub Send(data As String)
        dataListener.Send(data)
    End Sub
End Class
