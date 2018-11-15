Public Class AddList
    Private Sub AddList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub ConfirmAddButton_Click(sender As Object, e As EventArgs) Handles ConfirmAddButton.Click

    End Sub

    Private Sub ItemName_TextChanged(sender As Object, e As EventArgs) Handles ItemName.TextChanged
        ' TODO Check if name exists, activate or deactive Confirm
    End Sub

    Private Sub CancelAddButton_Click(sender As Object, e As EventArgs) Handles CancelAddButton.Click
        Close()
    End Sub
End Class