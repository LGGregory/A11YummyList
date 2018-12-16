Public Class Keyboard
    Public FormParent As AllItemsPanel


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ' Done Handling
        If Not FormParent Is Nothing Then
            FormParent.HideKeyboard()
        End If
    End Sub
End Class
