Public Class GroceryListPanel
    Private LName As String
    Private ItemCount As Integer
    Public Items As New List(Of ItemInfo)


    Public Property ListName As String
        Get
            Return LName
        End Get
        Set(value As String)
            LName = value
        End Set
    End Property

    Public Sub AddItem(ByVal info As ItemInfo)
        Items.Add(info)
        FlowLayoutPanel1.Controls.Add(New ItemBar(info, Me))


    End Sub

    Private Sub GroceryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sample Data
        AddItem(New ItemInfo("Broccoli", 3, "Lbs"))
        AddItem(New ItemInfo("Milk", 4, "L"))
        AddItem(New ItemInfo("Ground Beef", 2, "Kg"))
    End Sub
End Class
