Imports SmartFridge

Public Class AllItems
    Dim Words As New List(Of String)

    Public Sub New()
        Words.Add("Apples")
        Words.Add("Apple Juice")
        Words.Add("BBQ Sauce")
        Words.Add("Vegetable Oil")
        Words.Add("Grilling Steak")
        Words.Add("Eggs")
        Words.Add("Raspberry Jam")
        Words.Add("Sherry")
        Words.Add("Sweet Pickles")
        Words.Add("Kosher Sandwhich Pickles")
        Words.Add("Salt")
        Words.Add("Kraken")
        Words.Add("Sibling Rivalry White 2009")
        Words.Add("Bacon")
        Words.Add("Broccoli")
        Words.Add("Mushrooms")
        Words.Add("Red Peppers")
        Words.Add("Brussel Sprouts")
        Words.Add("Cucumbers")
        Words.Add("Chips")
        Words.Add("Cream Cheese")
        Words.Add("Dill Pickles")
        Words.Add("Vanilla Ice Cream")
        Words.Add("Mozzarella")
        Words.Add("Salsa")

        Words.Sort()


    End Sub

    Public Function GetAllItems() As List(Of String)
        Return Words
    End Function

    Public Function AutoComplete(typed As String) As List(Of String)
        ' Autocomplete using a trie
        Dim lower As String = typed.ToLower
        Return Words.Where(Function(x) x.ToLower.StartsWith(lower)).Select(Function(x) x).ToList()
    End Function

    Public Sub EditItem(oldName As String, newName As String)
        Words.Remove(oldName)
        Words.Add(newName)
        Words.Sort()
    End Sub

    Public Sub DeleteItem(name As String)
        Words.Remove(name)
    End Sub

End Class
