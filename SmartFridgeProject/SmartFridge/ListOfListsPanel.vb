Public Class ListOfListsPanel
    Dim Fridge As SmartFridgeDisplay
    Public ListList As New List(Of GroceryList)

    Private Sub AddListButton_Click(sender As Object, e As EventArgs) Handles AddListButton.Click
        Dim f As New AddList(Me)
        f.Show()
    End Sub

    Public Sub New(parent As SmartFridgeDisplay)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Fridge = parent


    End Sub

    Public Sub RemoveList(list As GroceryList)
        Fridge.ListOfGLists.Remove(list)
        For Each bar As ListBar In FlowPanel.Controls
            If bar.List Is list Then
                FlowPanel.Controls.Remove(bar)
            End If
        Next
    End Sub

    Public Sub AddNewList(gList As GroceryList)
        ListList.Add(gList)
        FlowPanel.Controls.Add(New ListBar(gList, Me))
    End Sub

    Public Sub AddNewList(name As String)
        Dim gList As New GroceryList(name, "New List", False)
        ListList.Add(gList)
        FlowPanel.Controls.Add(New ListBar(gList, Me))
    End Sub

    Public Sub ShowSavedList(List As GroceryList)
        Fridge.ShowList(List, True)
    End Sub

    Private Sub ListOfListsPanel_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
