Public Class AllItemsPanel
    Dim Items As New AllItems()
    Public Fridge As SmartFridgeDisplay
    Public NIB As New NewItemBar(Me)

    Private Sub AllItemsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBox(Items.GetAllItems)

        HideKeyboard()
    End Sub

    Public Sub AddItem(item As ItemInfo)
        Fridge.ReturnItem(item)
    End Sub

    Public Sub Restart()
        SearchBox.Text = ""
        HideKeyboard()
    End Sub

    Private Sub SetBox(list As List(Of ItemInfo))
        FlowPanel.Controls.Clear()

        For Each item As ItemInfo In list
            Dim sib As New SmallItemBar(item.Name, item.Unit) With {
                .ParentItemPanel = Me
            }
            FlowPanel.Controls.Add(sib)
        Next
        FlowPanel.Controls.Add(NIB)
    End Sub

    Friend Sub NewItem()
        Dim sib As New SmallItemBar() With {
                .ParentItemPanel = Me
            }
        sib.StartEditing()
        FlowPanel.Controls.Remove(NIB)
        FlowPanel.Controls.Add(sib)
        FlowPanel.Controls.Add(NIB)
        sib.ItemUnit = "ct"

        sib.EditNameBox.Focus()
    End Sub

    Public Sub HideKeyboard()
        FlowPanel.Height = 329
        Keyboard1.Hide()
    End Sub

    Private Sub ShowKeyboard()
        FlowPanel.Height = 186
        Keyboard1.Show()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        SetBox(Items.AutoComplete(SearchBox.Text))
    End Sub

    Private Sub SearchBox_Enter(sender As Object, e As EventArgs) Handles SearchBox.Enter
        ShowKeyboard()
    End Sub


    Private Sub ItemsBox_DoubleClick(sender As Object, e As EventArgs)
        Me.Hide()
        HideKeyboard()
    End Sub

    Friend Sub DeleteItem(sib As SmallItemBar)
        FlowPanel.Controls.Remove(sib)
        Items.Remove(sib.ItemName)
    End Sub

    Public Sub AddItem(sib As SmallItemBar)
        Items.AddItem(New ItemInfo(sib.ItemName, 0, sib.ItemUnit))

    End Sub
    Private Sub Keyboard1_Load(sender As Object, e As EventArgs) Handles Keyboard1.Load
        Keyboard1.FormParent = Me
    End Sub

End Class