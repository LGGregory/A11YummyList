Public Class ListOfListsPanel
    Private Sub AddListButton_Click(sender As Object, e As EventArgs) Handles AddListButton.Click

    End Sub

    Private Sub ListOfListsPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        FlowPanel.Controls.Add(New ListBar("List One", Me))
        FlowPanel.Controls.Add(New ListBar("List Two", Me))
        FlowPanel.Controls.Add(New ListBar("List Three", Me))
        FlowPanel.Controls.Add(New ListBar("List Four", Me))
    End Sub
End Class
