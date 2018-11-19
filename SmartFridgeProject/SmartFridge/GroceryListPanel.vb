Imports Newtonsoft.Json
Public Class GroceryListPanel
    Private LName As String
    Private ItemCount As Integer
    Public Current As GroceryList
    Public UpdatingList As GroceryList



    Public Sub AddItem(list As GroceryList, ByVal info As ItemInfo)
        list.AddItem(info)
        FlowPanel.Controls.Add(New ItemBar(info, Me))
    End Sub

    Public Sub RemoveItem(ByRef info As ItemInfo)
        Current.GroceryList.Remove(info)
    End Sub

    Public Sub New(name As String, text As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ListTitle.Text = name

        Current = New GroceryList

        Dim ItemL As New GroceryList
        ItemL.Name = name
        ItemL.Text = text
        ItemL.AddItem(New ItemInfo("Broccoli", 3, "Lbs"))
        ItemL.AddItem(New ItemInfo("Milk", 4, "L"))
        ItemL.AddItem(New ItemInfo("Ground Beef", 2, "Kg"))

        LoadList(ItemL)
    End Sub

    Public Sub New(list As GroceryList)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadList(list)

    End Sub


    Public Sub LoadList(list As GroceryList)
        UpdatingList = list
        UpdateList(list)
    End Sub

    Public Sub UpdateList(list As GroceryList)

        FlowPanel.Controls.Clear()
        ListTitle.Text = list.Name
        DetailsBox.Text = list.Text


        Dim newList As GroceryList = New GroceryList()
        newList.GroceryList = New List(Of ItemInfo)

        For Each oldItem As ItemInfo In list.GroceryList
            Dim newItem As ItemInfo = oldItem.Clone()
            AddItem(newList, newItem)
        Next
        Current = newList
        Current.Name = list.Name
        Current.Text = list.Text

        CancelChanges.Hide()
        ApplyChangesButton.Hide()
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Dim f As New AddItemForm(Me)
        f.Show()
    End Sub

    Public Sub ListChanged()
        ' TODO handles items added/ removed/ whatever
        ' Enables Apply/Cancel Changes button
        CancelChanges.Show()
        ApplyChangesButton.Show()

    End Sub

    Public Sub ApplyChanges()
        UpdatingList.MatchList(Current)
        LoadList(UpdatingList)
    End Sub

    Private Sub DetailsBox_TextChanged(sender As Object, e As EventArgs) Handles DetailsBox.TextChanged
        Current.Text = DetailsBox.Text
        ListChanged()
    End Sub

    Private Sub CancelChanges_Click(sender As Object, e As EventArgs) Handles CancelChanges.Click
        UpdateList(UpdatingList)
    End Sub

    Private Sub ApplyChangesButton_Click(sender As Object, e As EventArgs) Handles ApplyChangesButton.Click
        ApplyChanges()
    End Sub
End Class
