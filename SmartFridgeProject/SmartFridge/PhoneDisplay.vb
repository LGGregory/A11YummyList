Public Class PhoneDisplay
    Public CurrentListPanel As GroceryListPanel
    Public SavedListsPanel As ListOfListsPanel
    Public CurrentSavedListPanel As GroceryListPanel
    Public ListOfLists As New List(Of GroceryListPanel)
    Public dataListener As New DataListenerPhone
    Public TopBar As TopBar
    Public CurrentList As GroceryList
    Dim NestPoint As New Point(40, 0)




    Public Sub InitNetwork(IPAddress As String, PortNumber As Integer)
        DataListener.Connect(IPAddress, PortNumber)
    End Sub

    Private Sub PhoneDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SidePanel1.ExpandedWidth = Width

        CurrentList = New GroceryList()
        CurrentListPanel = New GroceryListPanel(CurrentList)
        Me.Controls.Add(CurrentListPanel)
        CurrentListPanel.Location = NestPoint
        CurrentListPanel.Dock = DockStyle.Fill
        CurrentListPanel.DockPadding.Left = 40







    End Sub
End Class