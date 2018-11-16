Public Class GroceryListPanel
    Private LName As String
    Private ItemCount As Integer
    Public Current As GroceryList
    Public UpdatingList As GroceryList



    Public Sub AddItem(ByVal info As ItemInfo)
        Current.AddItem(info)
        FlowPanel.Controls.Add(New ItemBar(info, Me))
    End Sub

    Public Sub RemoveItem(ByRef info As ItemInfo)
        Current.GroceryList.Remove(info)

    End Sub


    Private Sub GroceryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sample Data
        Current = New GroceryList

        Dim ItemL As New GroceryList
        ItemL.Text = "This is the default list"
        ItemL.Name = "Default List"
        ItemL.AddItem(New ItemInfo("Broccoli", 3, "Lbs"))
        ItemL.AddItem(New ItemInfo("Milk", 4, "L"))
        ItemL.AddItem(New ItemInfo("Ground Beef", 2, "Kg"))
        LoadList(ItemL)
    End Sub

    Public Sub LoadList(list As GroceryList)
        UpdatingList = list
        UpdateList(list)
    End Sub



    Public Sub UpdateList(list As GroceryList)

        '       FlowPanel.SuspendLayout()
        For Each Control As Control In FlowPanel.Controls
            FlowPanel.Controls.Remove(Control)
        Next
        '        FlowPanel.ResumeLayout()


        Current.Name = list.Name
        Current.Text = list.Text
        Current.GroceryList = New List(Of ItemInfo)

        For Each toAdd In list.GroceryList
            Current.GroceryList.Add(toAdd)
            FlowPanel.Controls.Add(New ItemBar(toAdd, Me))
        Next

    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Dim f As New AddItemForm(Me)
        f.Show()
    End Sub

    Public Sub ListChanged()
        ' TODO handles items added/ removed/ whatever
        ' Enables Apply/Cancel Changes button
    End Sub

    Public Sub ApplyChanges()
        ' TODO apply changes from current list to saved list

    End Sub



    Private Sub DetailsBox_TextChanged(sender As Object, e As EventArgs) Handles DetailsBox.TextChanged
        ListChanged()
    End Sub

    Private Sub CancelChanges_Click(sender As Object, e As EventArgs) Handles CancelChanges.Click
        UpdateList(UpdatingList)
    End Sub
End Class
