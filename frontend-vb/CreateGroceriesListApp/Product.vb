Public Class Product

    Public Property id As Long
    Public Property userId As Long
    Public Property name As String
    Public Property quantity As Integer
    Public Property price As Double
    Public Property createdAt As DateTime


    Public Overrides Function ToString() As String
        ' This will be what shows in the ListBox
        Return $"{Name} - Qty: {Quantity}, Price: {Price:C}"
    End Function
End Class