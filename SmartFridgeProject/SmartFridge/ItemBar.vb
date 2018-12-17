Public Class ItemBar


    Dim Info As ItemInfo
    Dim List As GroceryListPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Info = New ItemInfo("Item", 1, "")

        UpdateInfo()

    End Sub



    Public Sub New(info As ItemInfo, ByRef list As ContentPanel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Info = info
        Me.List = list

        UpdateInfo()

    End Sub

    Public Sub New(info As ItemInfo, ByRef list As ContentPanel, onPhone As Boolean)
        Me.New(info, list)
        If onPhone Then
            RemoveItem.Hide()
            BuyOne.Show()
            BuyAll.Show()


        End If
    End Sub

    Public Sub DeleteItem()
        Info.Name = "Deleted"

        UpdateInfo()
        List.RemoveItem(Info)
        List.FlowPanel.Controls.Remove(Me)
        List.ListChanged()


    End Sub

    Private Sub UpdateInfo()
        ItemName.Text = Info.Name
        ItemQuantity.Text = Info.Quantity
        ItemUnit.Text = Info.Unit
        List.ListChanged()
    End Sub

    Private Sub UpQuantityButton_Click(sender As Object, e As EventArgs) Handles UpQuantityButton.Click
        Info.ModifyQuantity(1)
        UpdateInfo()

    End Sub

    Private Sub DownQuantityButton_Click(sender As Object, e As EventArgs) Handles DownQuantityButton.Click
        Info.ModifyQuantity(-1)
        If (Info.Quantity < 1) Then
            DeleteItem()
        End If
        UpdateInfo()
    End Sub

    Private Sub RemoveItem_Click(sender As Object, e As EventArgs) Handles RemoveItem.Click
        DeleteItem()

    End Sub

    Private Sub BuyOne_Click(sender As Object, e As EventArgs) Handles BuyOne.Click
        List.SendToFridge(Info, False)
        DownQuantityButton_Click(sender, e)
        List.ApplyChanges()
    End Sub

    Private Sub BuyAll_Click(sender As Object, e As EventArgs) Handles BuyAll.Click
        List.SendToFridge(Info, True)
        DeleteItem()
        List.ApplyChanges()

    End Sub
End Class
