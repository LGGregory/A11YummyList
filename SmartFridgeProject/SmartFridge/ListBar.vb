Public Class ListBar
    Dim List As String
    Dim Panel As ListOfListsPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.List = "A Sample List"

        UpdateInfo()

    End Sub

    Public Sub New(list As String, ByRef panel As ListOfListsPanel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.List = list
        Me.Panel = panel

        UpdateInfo()

    End Sub

    Public Sub DeleteItem()
        List = "Deleted"

        UpdateInfo()
        ' Panel.RemoveItem(List) Figure out how to do this?
        Panel.FlowPanel.Controls.Remove(Me)

    End Sub

    Public Sub CopyItem()
        Panel.FlowPanel.Controls.Add(New ListBar(List + " Copy", Panel))
    End Sub


    Private Sub UpdateInfo()
        ItemName.Text = List
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        DeleteItem()
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        CopyItem()
    End Sub
End Class
