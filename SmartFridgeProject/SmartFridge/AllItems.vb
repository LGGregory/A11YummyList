Imports SmartFridge

Public Class AllItems
    Dim Words As New List(Of ItemInfo)

    Public Sub New()
        Words.Add(New ItemInfo("Apples", 0, "Apples"))
        Words.Add(New ItemInfo("Apple Juice", 0, "Jars"))
        Words.Add(New ItemInfo("BBQ Sauce", 0, "Bottles"))
        Words.Add(New ItemInfo("Vegetable Oil", 0, "Bottles"))
        Words.Add(New ItemInfo("Grilling Steak", 0, "Steaks"))
        Words.Add(New ItemInfo("Eggs", 0, "Eggs"))
        Words.Add(New ItemInfo("Raspberry Jam", 0, "Jars"))
        Words.Add(New ItemInfo("Sherry", 0, "Bottles"))
        Words.Add(New ItemInfo("Sweet Pickles", 0, "Jars"))
        Words.Add(New ItemInfo("Kosher Sandwhich Pickles", 0, "Jars"))
        Words.Add(New ItemInfo("Salt", 0, "Boxes"))
        Words.Add(New ItemInfo("Kraken", 0, "Mistakes"))
        Words.Add(New ItemInfo("Sibling Rivalry White 2009", 0, "Cases"))
        Words.Add(New ItemInfo("Bacon", 0, "Rashers"))
        Words.Add(New ItemInfo("Broccoli", 0, "Heads"))
        Words.Add(New ItemInfo("Mushrooms", 0, "Mushrooms"))
        Words.Add(New ItemInfo("Red Peppers", 0, "Peppers"))
        Words.Add(New ItemInfo("Brussels Sprouts", 0, "Sprouts"))
        Words.Add(New ItemInfo("Cucumbers", 0, "Cucumbers"))
        Words.Add(New ItemInfo("Chips", 0, "Bags"))
        Words.Add(New ItemInfo("Cream Cheese", 0, "Containers"))
        Words.Add(New ItemInfo("Dill Pickles", 0, "Jars"))
        Words.Add(New ItemInfo("Vanilla Ice Cream", 0, "Tubs"))
        Words.Add(New ItemInfo("Mozzarella", 0, "Blocks"))
        Words.Add(New ItemInfo("Salsa", 0, "Jars"))

        Words.Sort()


    End Sub

    Public Function GetAllItems() As List(Of ItemInfo)
        Return Words
    End Function

    Public Function AutoComplete(typed As String) As List(Of ItemInfo)
        ' Autocomplete using a trie
        Dim lower As String = typed.ToLower
        Dim OutList As List(Of ItemInfo) = New List(Of ItemInfo)
        OutList.AddRange(Words.Where(Function(x) x.Name.ToLower.StartsWith(lower)).Select(Function(x) x).ToList())
        OutList.AddRange(Words.Where(Function(x) (x.Name.ToLower.Contains(lower) And Not x.Name.ToLower.StartsWith(lower))).Select(Function(x) x).ToList())

        Return OutList
    End Function

    Friend Sub Remove(itemName As String)
        For Each item As ItemInfo In Words
            If item.Name = itemName Then
                Words.Remove(item)
            End If
        Next
    End Sub

    Public Sub EditItem(oldName As String, newName As String)
        'Words.Remove(oldName)
        'Words.Add(newName)
        'Words.Sort()
    End Sub

    Public Sub DeleteItem(item As ItemInfo)
        Words.Remove(item)
    End Sub

End Class
