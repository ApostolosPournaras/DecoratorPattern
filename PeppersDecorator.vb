Public Class PeppersDecoratorvb
    Inherits ToppingDecortator

    Sub New(pizza As IPizza)
        MyBase.New(pizza)
    End Sub

    Public Overrides Function getCost() As Double
        Return thePizza.getCost() + 0.7
    End Function

    Public Overrides Function getDescription() As String
        Return thePizza.getDescription() & ", peppers"
    End Function

End Class
