Imports SmartFridge

Public Class Recipe
    Implements iListOfItems
    Dim _List As List(Of ItemInfo)
    Dim _Name As String
    Dim _Instructions As String

    Public Sub New()
        List = New List(Of ItemInfo)
    End Sub
    Public Sub New(name As String, inst As String)
        Me.New()
        Me.Name = name
        Me.Text = inst
    End Sub


    Public Property Text As String Implements iListOfItems.Text
        Get
            Return _Instructions
        End Get
        Set(value As String)
            _Instructions = value
        End Set
    End Property

    Public Property List As List(Of ItemInfo) Implements iListOfItems.List
        Get
            Return _List
        End Get
        Set(value As List(Of ItemInfo))
            _List = value
        End Set
    End Property

    Public Property Name As String Implements iListOfItems.Name
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
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
