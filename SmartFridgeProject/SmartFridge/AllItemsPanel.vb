Public Class AllItemsPanel
    Dim Items As New AllItems()
    Private Sub AllItemsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBox(Items.GetAllItems)

        HideKeyboard()
    End Sub

    Private Sub SetBox(list As List(Of String))
        FlowPanel.Controls.Clear()

        For Each word As String In list
            Dim sib As New SmallItemBar(word) With {
                .ParentItemPanel = Me
            }
            FlowPanel.Controls.Add(sib)
        Next
        ' TODO Check this
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
        Items.DeleteItem(sib.ItemName)
    End Sub

    Private Sub Keyboard1_Load(sender As Object, e As EventArgs) Handles Keyboard1.Load
        Keyboard1.FormParent = Me
    End Sub
End Class
