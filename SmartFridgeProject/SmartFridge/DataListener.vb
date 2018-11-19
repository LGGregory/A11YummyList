Public Interface DataListener
    Event AddData(iInfo As ItemInfo)
    Event ChangeList(gList As GroceryList)
    Sub Read(ByVal ar As IAsyncResult)
    Sub Connect(IPAddress As String, PortNumber As Integer)
    Sub Send(data As String)
    Sub formSet(form As SmartFridgeDisplay)


End Interface
