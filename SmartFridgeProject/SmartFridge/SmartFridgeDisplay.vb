Public Class SmartFridgeDisplay
    Public CurrentListPanel As GroceryListPanel
    Public SavedListsPanel As ListOfListsPanel
    Public CurrentList As GroceryList
    Public BaseList As GroceryList
    Public ListOfGLists As New List(Of GroceryList)
    Public dataListener As DataListener
    Public TopBar As TopBar
    Public NoBar As New Point(92, 0)
    Public WiBar As New Point(92, 40)
    Public Bot As New Point(465, 670)

    Public FridgeOrPhone As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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

        SavedListsPanel = New ListOfListsPanel(Me)
        Me.Controls.Add(SavedListsPanel)
        SavedListsPanel.Location = NoBar
        SavedListsPanel.Hide()

        CurrentList = New GroceryList(True)
        BaseList = CurrentList

        CurrentListPanel = New GroceryListPanel(CurrentList)
        Me.Controls.Add(CurrentListPanel)
        CurrentListPanel.Location = NoBar
        CurrentListPanel.Size = Bot
        CurrentListPanel.Show()

        addGroceryList("Sample List 1", "A Sample List")
        addGroceryList("Sample List 2", "A Sample List")
        addGroceryList("Sample List 3", "A Sample List")
        addGroceryList("Sample List 4", "A Sample List")

        TopBar = New TopBar(Me)
        Me.Controls.Add(TopBar)
        TopBar.Location = New Point(5, 0)
        TopBar.Hide()


    End Sub

    Public Sub addGroceryList(name As String, about As String)
        Dim NewGList As New GroceryList(name, about)
        ListOfGLists.Add(NewGList)
        SavedListsPanel.AddNewList(NewGList)


        '    Dim NewList As GroceryListPanel
        '    NewList = New GroceryListPanel(name, about)
        '    Me.Controls.Add(NewList)
        '    NewList.Location = New Point(92, 40)
        '    NewList.Size = New Point(465, 670)
        '    NewList.Hide()
        '    ListOfLists.Add(NewList)
    End Sub

    Public Sub AddToSavedList(list As GroceryList)
        For Each item As ItemInfo In list.GroceryList
            If BaseList.hasSameItemByName(item) Then
                BaseList.getSameItemByName(item).Quantity += item.Quantity
            Else
                BaseList.AddItem(item)
            End If
        Next
    End Sub

    Public Sub CopyToCurrentList(list As GroceryList)
        BaseList = list
    End Sub

    Public Sub showSavedListsPanel()
        CurrentListPanel.Hide()
        SavedListsPanel.Show()
        TopBar.Hide()
    End Sub

    Public Sub showCurrentListPanel()
        SavedListsPanel.Hide()
        TopBar.Hide()
        CurrentListPanel.Show()
    End Sub

    Public Sub ShowList(list As GroceryList, bar As Boolean)
        SavedListsPanel.Hide()
        CurrentList = list
        CurrentListPanel.LoadList(list)
        If bar Then
            TopBar.Show()
            CurrentListPanel.Location = WiBar
        Else
            TopBar.Hide()
            CurrentListPanel.Location = NoBar
        End If
        CurrentListPanel.Show()
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
        dataListener.FormSet(Me)

        dataListener.Connect(IPAddress, PortNumber)
    End Sub

End Class
