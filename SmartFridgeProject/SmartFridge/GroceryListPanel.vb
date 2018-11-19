﻿Imports Newtonsoft.Json
Imports SmartFridge

Public Class GroceryListPanel
    Implements ContentPanel
    Private LName As String
    Private ItemCount As Integer
    Public Current As GroceryList
    Public UpdatingList As GroceryList
    Public Fridge As SmartFridgeDisplay

    Private Property ContentPanel_FlowPanel As FlowLayoutPanel Implements ContentPanel.FlowPanel
        Get
            Return FlowPanel
        End Get
        Set(value As FlowLayoutPanel)

        End Set
    End Property

    Public Property WorkingList As GroceryList Implements ContentPanel.WorkingList
        Get
            Return Current
        End Get
        Set(value As GroceryList)
            Current = value
        End Set
    End Property

    Public Sub AddItem(list As GroceryList, ByVal info As ItemInfo) Implements ContentPanel.AddItem
        list.AddItem(info)
        FlowPanel.Controls.Add(New ItemBar(info, Me))
    End Sub

    Public Sub RemoveItem(ByRef info As ItemInfo)
        Current.GroceryList.Remove(info)
    End Sub

    Public Sub New(parent As SmartFridgeDisplay, name As String, text As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ListTitle.Text = name

        Current = New GroceryList

        Dim ItemL As New GroceryList With {
            .Name = name,
            .Text = text
        }
        ItemL.AddItem(New ItemInfo("Broccoli", 3, "Lbs"))
        ItemL.AddItem(New ItemInfo("Milk", 4, "L"))
        ItemL.AddItem(New ItemInfo("Ground Beef", 2, "Kg"))

        Fridge = parent
        LoadList(ItemL)
    End Sub

    Public Sub New(parent As SmartFridgeDisplay, list As GroceryList)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Fridge = parent
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


        Dim newList As New GroceryList With {
            .GroceryList = New List(Of ItemInfo)
        }

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

    Public Sub ListChanged() Implements ContentPanel.ListChanged
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

    Private Sub SendToPhoneButton_Click(sender As Object, e As EventArgs) Handles SendToPhoneButton.Click
        Dim aJson As New ActionJson
        aJson.Type = "list"
        aJson.Action = "update"
        aJson.List = UpdatingList
        Fridge.Send(JsonConvert.SerializeObject(aJson))
    End Sub

    Private Sub EnableSend()
        If Fridge.FridgeOrPhone Then
            SendToPhoneButton.Show()
        End If

    End Sub

    Private Sub DisableSend()
        SendToPhoneButton.Hide()
    End Sub

    Public Sub ShowFridge()
        DisableSend()
        DetailsBox.Enabled = False
    End Sub

    Public Sub HideFridge()
        EnableSend()
        DetailsBox.Enabled = True
    End Sub

    'Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
    'End Sub
End Class
