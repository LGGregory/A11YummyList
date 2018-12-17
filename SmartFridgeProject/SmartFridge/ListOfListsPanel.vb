Public Class ListOfListsPanel
    Dim Fridge As SmartFridgeDisplay
    Dim ListOrRecipe As Boolean = True
    Public ListList As New List(Of iListOfItems)

    Private Sub AddListButton_Click(sender As Object, e As EventArgs) Handles AddListButton.Click
        If ListOrRecipe Then



        End If
        Dim f As New AddList(Me, ListOrRecipe)
        f.Show()
    End Sub

    Public Sub New(parent As SmartFridgeDisplay, lOrR As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Fridge = parent
        ListOrRecipe = lOrR
        If Not lOrR Then
            AddListButton.Text = "Add Recipe"

        End If


    End Sub

    Public Sub RemoveList(list As iListOfItems)
        Fridge.ListOfGLists.Remove(list)
        For Each bar As ListBar In FlowPanel.Controls
            If bar.List Is list Then
                FlowPanel.Controls.Remove(bar)
            End If
        Next
    End Sub

    Public Sub AddNewList(gList As iListOfItems)
        ListList.Add(gList)
        FlowPanel.Controls.Add(New ListBar(gList, Me))
    End Sub

    Public Sub AddNewList(name As String)
        Dim gList As New GroceryList(name, "New List", False)
        ListList.Add(gList)
        FlowPanel.Controls.Add(New ListBar(gList, Me))
    End Sub

    Public Sub AddNewRecipe(name As String)
        Dim rList As New Recipe With {
            .Name = name,
            .Text = "New recipe"
        }
        ListList.Add(rList)
        FlowPanel.Controls.Add(New ListBar(rList, Me))
    End Sub

    Public Sub ShowSavedList(List As iListOfItems)
        Fridge.ShowList(List, True, Not ListOrRecipe)
    End Sub

End Class
