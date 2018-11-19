Imports SmartFridge

Public Class GroceryList
    Dim List As New List(Of ItemInfo)
    Dim ListInfo As String
    Dim ListName As String
    Shared count As Integer = 0

    Public Sub New(name As String, about As String)
        Me.New(True)
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
            AddItem(New ItemInfo("Broccoli", 3, "Lbs"))
            AddItem(New ItemInfo("Milk", 4, "L"))
            AddItem(New ItemInfo("Ground Beef", 2, "Kg"))
        End If
    End Sub
    Public Sub New()

    End Sub

    Public Sub New(Name As String)
        Me.New(Name, "")
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

    Public Property GroceryList As List(Of ItemInfo)
        Get
            Return List
        End Get
        Set(value As List(Of ItemInfo))
            If value Is Nothing Then
                Throw New ArgumentNullException(NameOf(value))
            End If
            List = value
        End Set
    End Property

    Public Property Text As String
        Get
            Return ListInfo
        End Get
        Set(value As String)
            ListInfo = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return ListName
        End Get
        Set(value As String)
            ListName = value
        End Set
    End Property

    Public Sub AddItem(ByRef item As ItemInfo)
        List.Add(item)
    End Sub

    Public Sub RemoveItem(ByRef item As ItemInfo)
        List.Remove(item)
    End Sub

    Public Sub MatchList(other As GroceryList)
        Name = other.Name
        Text = other.Text
        GroceryList = New List(Of ItemInfo)
        For Each item As ItemInfo In other.GroceryList
            AddItem(item.Clone)
        Next
    End Sub
End Class
