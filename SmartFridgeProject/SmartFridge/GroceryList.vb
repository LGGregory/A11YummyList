Imports SmartFridge

Public Class GroceryList
    Dim List As New List(Of ItemInfo)
    Dim ListInfo As String
    Dim ListName As String


    Public Sub New()
        'TODO
    End Sub

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
End Class
