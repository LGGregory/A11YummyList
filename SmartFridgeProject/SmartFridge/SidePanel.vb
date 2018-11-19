Public Class SidePanel
    Dim Fridge As SmartFridgeDisplay = Nothing
    Public ExpandedWidth As Integer = 380
    Public ShrunkWidth As Integer = 70

    Dim ExpandedBoolean As Boolean = True


    Private Sub SidePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Need to load parent in here somehow

        BurgerExpand.Visible = False
        BurgerShrink_Click(Nothing, Nothing)
    End Sub

    ' Shrinking the SidePanel
    Private Sub BurgerShrink_Click(sender As Object, e As EventArgs) Handles BurgerShrink.Click

        BurgerShrinkAction()

    End Sub

    ' Expanding the SidePanel
    Private Sub BurgerExpand_Click(sender As Object, e As EventArgs) Handles BurgerExpand.Click
        If Not Fridge Is Nothing Then
            Fridge.DimPanel()
        End If

        BurgerExpand.Visible = False
        BurgerShrink.Visible = True
        MenuPanel.Visible = True
        Do While Width < ExpandedWidth
            Width = Width + 5
        Loop

    End Sub

    Private Sub BurgerShrinkAction()
        If Not Fridge Is Nothing Then
            Fridge.UnDimPanel()
        End If

        BurgerShrink.Visible = False
        BurgerExpand.Visible = True
        MenuPanel.Visible = False
        Do While Width > ShrunkWidth
            Width = Width - 5
        Loop

    End Sub

    Public Sub SetParent(parent As SmartFridgeDisplay)
        Fridge = parent
    End Sub

    ' Switch to Main List
    Private Sub CurrentListButton_Click(sender As Object, e As EventArgs) Handles CurrentListButton.Click
        Fridge.CurrentListPanel.HideFridge()
        Fridge.CurrentListPanel.LoadList(Fridge.BaseList)
        Fridge.ShowList(Fridge.BaseList, False)
        BurgerShrinkAction()
    End Sub

    ' Switch to List of Recurring (Saved) List
    Private Sub SavedListButton_Click(sender As Object, e As EventArgs) Handles SavedListButton.Click
        Fridge.CurrentListPanel.HideFridge()
        Fridge.showSavedListsPanel()
        BurgerShrinkAction()

    End Sub

    ' Switch to Recipe Display
    Private Sub RecipesButton_Click(sender As Object, e As EventArgs) Handles RecipesButton.Click

        Fridge.CurrentListPanel.HideFridge()
        Fridge.CurrentListPanel.LoadList(Fridge.BaseList)
        Fridge.ShowList(Fridge.BaseList, False)
        BurgerShrinkAction()
        'TODO : currently returns to home page
    End Sub

    ' Switch to Fridge Contents List
    Private Sub FridgeContentsButton_Click(sender As Object, e As EventArgs) Handles FridgeContentsButton.Click
        Fridge.ShowList(Fridge.FridgeContents, False)
        Fridge.CurrentListPanel.ShowFridge()

        BurgerShrinkAction()
    End Sub
End Class
