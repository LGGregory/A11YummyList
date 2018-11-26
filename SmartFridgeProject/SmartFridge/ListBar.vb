Public Class ListBar
    Public List As iListOfItems
    Dim Panel As ListOfListsPanel


    Public Sub New(list As iListOfItems, ByRef panel As ListOfListsPanel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CopyButton.Hide()
        Me.List = list
        Me.Panel = panel

        UpdateInfo()

    End Sub

    Public Sub DeleteItem()
        Panel.RemoveList(List)
    End Sub

    Public Sub CopyItem()
        'Panel.FlowPanel.Controls.Add(New ListBar(List, Panel))
    End Sub

    Private Sub UpdateInfo()
        ItemName.Text = List.Name
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        DeleteItem()
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        CopyItem()
    End Sub

    Private Sub ItemName_Click(sender As Object, e As EventArgs) Handles ItemName.Click
        Panel.ShowSavedList(List)
    End Sub
End Class
