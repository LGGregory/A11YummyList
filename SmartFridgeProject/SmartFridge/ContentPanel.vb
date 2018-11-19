Public Interface ContentPanel

    Property FlowPanel As FlowLayoutPanel
    Property WorkingList As GroceryList
    Sub ListChanged()
    Sub AddItem(list As GroceryList, ByVal info As ItemInfo)

End Interface
