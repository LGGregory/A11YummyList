Public Class GroceryListPanel
    Private LName As String
    Private ItemCount As Integer
    Public Items As GroceryList
    Public UpdatingList As GroceryList



    Public Sub AddItem(ByVal info As ItemInfo)
        Items.AddItem(info)
        FlowPanel.Controls.Add(New ItemBar(info, Me))
    End Sub

    Public Sub RemoveItem(ByRef info As ItemInfo)
        Items.GroceryList.Remove(info)

    End Sub


    Private Sub GroceryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sample Data
        Items = New GroceryList()

        Items.Name = "Default List"
        AddItem(New ItemInfo("Broccoli", 3, "Lbs"))
        AddItem(New ItemInfo("Milk", 4, "L"))
        AddItem(New ItemInfo("Ground Beef", 2, "Kg"))
    End Sub

    Public Sub UpdateList(ByRef list As GroceryList)
        UpdatingList = list
        FlowPanel.SuspendLayout()

        For Each Control As Control In FlowPanel.Controls
            FlowPanel.Controls.Remove(Control)
        Next
        For Each Item As ItemInfo In list.GroceryList
            AddItem(Item)
        Next

        FlowPanel.ResumeLayout()


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

End Class
