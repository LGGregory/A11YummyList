Public Class LoadingScreen
    Private Sub ServerButton_Click(sender As Object, e As EventArgs) Handles ServerButton.Click
        Dim SFD As New ServerForm()
        SFD.Show()
        SFD.InitNetwork(PortBox.Text)
        Me.Close()
    End Sub

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FridgeButton_Click(sender As Object, e As EventArgs) Handles FridgeButton.Click
        Dim SFD As New SmartFridgeDisplay
        SFD.Show()
        SFD.InitNetwork(IPBox.Text, PortBox.Text)
        Me.Close()

    End Sub
End Class