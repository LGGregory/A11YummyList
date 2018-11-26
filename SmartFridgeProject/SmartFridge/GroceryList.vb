Imports SmartFridge

Public Class GroceryList
    Implements iListOfItems

    Dim _List As New List(Of ItemInfo)
    Dim ListInfo As String
    Dim ListName As String
    Shared count As Integer = 0

    Public Sub New(name As String, about As String, gen As Boolean)
        Me.New(gen)
        Me.Name = name
        Text = about
    End Sub

    Public Sub New(from As GroceryList)
        For Each item As ItemInfo In from.List
            List.Add(item.Clone)
        Next
        Name = from.Name
        Text = from.Text
    End Sub

    Public Sub New(gen As Boolean)
        If gen Then
            Name = "List " & count
            Text = "Default List Number " & count
            count = count + 1

        End If
    End Sub
    Public Sub New()

    End Sub

    Public Sub New(Name As String)
        Me.New(Name, "", False)
    End Sub

    Public Function hasSameItemByName(item As ItemInfo) As Boolean
        For Each checkingItem As ItemInfo In List
            If item.SameName(checkingItem) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function getSameItemByName(item As ItemInfo) As ItemInfo
        For Each checkingItem As ItemInfo In List
            If item.SameName(checkingItem) Then
                Return checkingItem
            End If
        Next
        Return New ItemInfo("Nothing", 0, "Nada")
    End Function

    Public Property List As List(Of ItemInfo) Implements iListOfItems.List
        Get
            Return _List
        End Get
        Set(value As List(Of ItemInfo))
            If value Is Nothing Then
                Throw New ArgumentNullException(NameOf(value))
            End If
            _List = value
        End Set
    End Property

    Public Property Text As String Implements iListOfItems.Text
        Get
            Return ListInfo
        End Get
        Set(value As String)
            ListInfo = value
        End Set
    End Property

    Public Property Name As String Implements iListOfItems.Name
        Get
            Return ListName
        End Get
        Set(value As String)
            ListName = value
        End Set
    End Property

    Public Sub AddItem(item As ItemInfo) Implements iListOfItems.AddItem
        List.Add(item)
    End Sub

    Public Sub RemoveItem(item As ItemInfo) Implements iListOfItems.RemoveItem
        List.Remove(item)
    End Sub


    Public Sub MatchList(other As iListOfItems) Implements iListOfItems.MatchList
        MatchList(other, True)
    End Sub

    Public Sub MatchList(other As iListOfItems, rename As Boolean) Implements iListOfItems.MatchList
        If rename Then
            Name = other.Name
        End If
        Text = other.Text
        List = New List(Of ItemInfo)
        For Each item As ItemInfo In other.List
            AddItem(item.Clone)
        Next
    End Sub
End Class
