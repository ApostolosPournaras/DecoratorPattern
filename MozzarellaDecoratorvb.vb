Public Class MozzarellaDecorator
    Inherits ToppingDecortator

    Sub New(pizza As IPizza)
        MyBase.New(pizza)
    End Sub

    Public Overrides Function getCost() As Double
        Return thePizza.getCost() + 1.5
    End Function

    Public Overrides Function getDescription() As String
        Return thePizza.getDescription() & ", mozzarella"
    End Function

End Class

