Public MustInherit Class ToppingDecortator
    Implements IPizza

    protected thePizza As IPizza

    Sub New(pizza As IPizza)
        Me.thePizza = pizza
    End Sub

    Public Overridable Function getCost() As Double Implements IPizza.getCost
        Return thePizza.getCost()
    End Function

    Public Overridable Function getDescription() As String Implements IPizza.getDescription
        Return thePizza.getDescription()
    End Function
End Class
