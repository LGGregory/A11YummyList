Imports SmartFridge

Public Interface iListOfItems
    Property Name As String
    Property Text As String
    Property List As List(Of ItemInfo)
    Property Bar As ListBar
    Sub AddItem(item As ItemInfo)
    Sub RemoveItem(item As ItemInfo)
    Sub MatchList(other As iListOfItems)
    Sub MatchList(other As iListOfItems, rename As Boolean)
End Interface
