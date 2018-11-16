Public Class TopBarButton
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click

    End Sub

    Private Bar As TopBar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(parent As TopBar)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Bar = parent
    End Sub

End Class
