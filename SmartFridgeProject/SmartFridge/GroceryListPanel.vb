﻿Imports Newtonsoft.Json
Imports SmartFridge

Public Class GroceryListPanel
    Implements ContentPanel
    Dim BoxVis As Boolean = True
    Private LName As String
    Private ItemCount As Integer
    Public Current As GroceryList
    Public UpdatingList As GroceryList
    Public Fridge As SmartFridgeDisplay
    Dim DetailsShowing As Boolean = True


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
        FlowPanel.Controls.Add(New ItemBar(info, Me, Not Fridge.FridgeOrPhone))
    End Sub

    Public Sub RemoveItem(ByRef info As ItemInfo)
        Current.List.Remove(info)
    End Sub

    Public Sub New(parent As SmartFridgeDisplay, name As String, text As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ListTitle.Text = name

        Current = New GroceryList
        Fridge = parent
        Dim ItemL As New GroceryList With {
            .Name = name,
            .Text = text
        }
        ItemL.AddItem(New ItemInfo("Broccoli", 3, "Lbs"))
        ItemL.AddItem(New ItemInfo("Milk", 4, "L"))
        ItemL.AddItem(New ItemInfo("Ground Beef", 2, "Kg"))


        LoadList(ItemL)
        EnableSend()
    End Sub

    Public Sub New(parent As SmartFridgeDisplay, list As GroceryList)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Fridge = parent
        LoadList(list)
        EnableSend()
    End Sub


    Public Sub LoadList(list As iListOfItems)
        UpdatingList = list
        UpdateList(list)
    End Sub

    Public Sub UpdateList(list As iListOfItems)

        FlowPanel.Controls.Clear()
        ListTitle.Text = list.Name
        DetailsBox.Text = list.Text

        ' And this is where Liam realized he dun goofed.
        Dim newList As New GroceryList With {
            .List = New List(Of ItemInfo)
        }

        For Each oldItem As ItemInfo In list.List
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
        Fridge.AddItem()
        ' Dim f As New AddItemForm(Me)
        ' f.Show()
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
        Dim aJson As New ActionJson With {
            .Type = "list",
            .Action = "updatelist"
        }
        Dim lbTemp As ListBar = UpdatingList.Bar
        UpdatingList.Bar = Nothing
        aJson.List = UpdatingList
        Fridge.Send(JsonConvert.SerializeObject(aJson))
        UpdatingList.Bar = lbTemp
    End Sub

    Public Sub SendToFridge(item As ItemInfo, All As Boolean)
        Dim aJson As New ActionJson With {
            .Type = "list",
            .Action = "updatefridge"
        }
        aJson.Item = item.Clone
        If Not All Then
            aJson.Item.Quantity = 1
        End If
        Fridge.Send(JsonConvert.SerializeObject(aJson))



    End Sub

    Private Sub EnableSend()
        If Fridge.FridgeOrPhone Then
            SendToPhoneButton.Show()
        Else
            SendToPhoneButton.Hide()
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

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        If BoxVis Then
            ShrinkDetailsAction()
        Else
            ExpandDetailsAction()
        End If
    End Sub

    Public Sub ExpandDetailsAction()
        Dim height As Integer = DetailsBox.Height
        FlowPanel.Height -= height
        DetailsBox.Show()
        BoxVis = True
    End Sub

    Public Sub ShrinkDetailsAction()
        Dim height As Integer = DetailsBox.Height
        DetailsBox.Hide()
        FlowPanel.Height += height
        BoxVis = False


    End Sub

    Public Sub EchoDim()
        AddItemButton.Image = My.Resources.addItemdim
        DetailsBox.BackColor = System.Drawing.Color.Silver
    End Sub

    Public Sub EchoUnDim()
        AddItemButton.Image = My.Resources.addItem
        DetailsBox.BackColor = System.Drawing.Color.White
    End Sub

    Dim EditingMode As Boolean = False

    Private Sub EditBox_Click(sender As Object, e As EventArgs) Handles EditBox.Click
        Editing()
    End Sub


    Public Sub Editing()
        If EditingMode Then
            If Not EditNameBox.Text.Trim = "" Then
                EditingMode = False
                If Not Current.Name = EditNameBox.Text Then
                    Current.Name = EditNameBox.Text
                    ListTitle.Text = Current.Name
                    UpdatingList.Name = Current.Name
                    If Not UpdatingList.Bar Is Nothing Then
                        UpdatingList.Bar.UpdateInfo()
                    End If

                End If
                EditNameBox.Hide()
                ListTitle.Show()
                If DetailsShowing Then
                    DetailsBox.Show()
                End If
                Keyboard1.Hide()
            End If
        Else

            EditingMode = True
            ListTitle.Hide()
            DetailsBox.Hide()
            Keyboard1.Show()
            EditNameBox.Text = ListTitle.Text
            EditNameBox.Show()
            EditNameBox.Focus()
        End If
    End Sub


    'Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
    'End Sub
End Class
