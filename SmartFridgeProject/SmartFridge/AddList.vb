Public Class AddList
    Private Sub AddList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim ParentList As ListOfListsPanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



    End Sub

    Public Sub New(ByRef AddList As ListOfListsPanel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ParentList = AddList
        Me.Text = "Add New Saved List"

    End Sub

    Private Sub ConfirmAddButton_Click(sender As Object, e As EventArgs) Handles ConfirmAddButton.Click
        ParentList.AddNewList(ItemName.Text)
        Close()
    End Sub

    Private Sub ItemName_TextChanged(sender As Object, e As EventArgs) Handles ItemName.TextChanged
        ' TODO Check if name exists, activate or deactive Confirm
    End Sub

    Private Sub CancelAddButton_Click(sender As Object, e As EventArgs) Handles CancelAddButton.Click
        Close()
    End Sub
End Class