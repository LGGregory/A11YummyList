Public Class TopBar
    Private Fridge As SmartFridgeDisplay

    Public Sub New(parent As SmartFridgeDisplay)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Fridge = parent
    End Sub

    Private Sub AddToCurrentListButton_Load(sender As Object, e As EventArgs) Handles AddToCurrentListButton.Load

    End Sub

    Private Sub CopyToCurrentListButton_Load(sender As Object, e As EventArgs) Handles CopyToCurrentListButton.Load

    End Sub
End Class
