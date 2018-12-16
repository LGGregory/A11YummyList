Imports SmartFridge

Public Class ItemInfo
    Implements ICloneable
    Implements IComparable

    Public Name As String
    Public Quantity As Integer
    Public Unit As String = ""
    Private _information As String ' Click item name to open display

    Public Property Text As String
        Get
            Return _information
        End Get
        Set(value As String)
            _information = value
        End Set
    End Property

    Public Sub New(name As String, quantity As Integer, unit As String)
        Me.Name = name
        Me.Quantity = quantity
        Me.Unit = unit
    End Sub

    Public Function SameName(item As ItemInfo) As Boolean
        Return Name = item.Name
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim info = TryCast(obj, ItemInfo)
        Return info IsNot Nothing AndAlso
               Name = info.Name AndAlso
               Quantity = info.Quantity AndAlso
               Unit = info.Unit
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 1173589573
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Name)).GetHashCode()
        hashCode = (hashCode * -1521134295 + Quantity.GetHashCode()).GetHashCode()
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Unit)).GetHashCode()
        Return hashCode
    End Function

    Public Sub ModifyQuantity(value As Integer)
        Quantity = Quantity + value
    End Sub

    Public Function Clone() As Object
        Return New ItemInfo(Name, Quantity, Unit)
    End Function

    Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
        Throw New NotImplementedException()
    End Function

    Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
        Dim other As ItemInfo = CType(obj, ItemInfo)
        Return Name.CompareTo(other.Name)
    End Function
End Class
