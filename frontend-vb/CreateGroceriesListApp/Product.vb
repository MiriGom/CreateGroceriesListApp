Public Class Product
    Public Property name As String
    Public Property quantity As Integer
    Public Property price As Double

    ' This property controls what shows in the ListBox
    Public ReadOnly Property DisplayName As String
        Get
            Return $"{name} - Qty: {quantity} - Price: ${price:F2}"
        End Get
    End Property

    Public Overrides Function ToString() As String
        ' ListBox will automatically call ToString, so this ensures proper display
        Return DisplayName
    End Function
End Class