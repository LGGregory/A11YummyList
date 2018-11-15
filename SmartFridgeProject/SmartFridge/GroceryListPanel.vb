Public Class GroceryListPanel
    Private LName As String
    Private ItemCount As Integer
    Public Items As GroceryList
    Public UpdatingList As GroceryList

    Public Property ListName As String
        Get
            Return Items.Name
        End Get
        Set(value As String)
            Items.Name = value
        End Set
    End Property

    Public Sub AddItem(ByVal info As ItemInfo)
        Items.AddItem(info)
        FlowPanel.Controls.Add(New ItemBar(info, Me))
    End Sub

    Public Sub RemoveItem(ByRef info As ItemInfo)
        Items.GroceryList.Remove(info)

    End Sub


    Private Sub GroceryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sample Data
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




End Class
