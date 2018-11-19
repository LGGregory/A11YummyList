Public Class PhoneDisplay
    Public CurrentListPanel As GroceryListPanel
    Public SavedListsPanel As ListOfListsPanel
    Public CurrentSavedListPanel As GroceryListPanel
    Public ListOfLists As New List(Of GroceryListPanel)
    Public dataListener As New DataListenerPhone(Me)
    Public TopBar As TopBar



    Public Sub InitNetwork(IPAddress As String, PortNumber As Integer)
        DataListener.Connect(IPAddress, PortNumber)
    End Sub
End Class