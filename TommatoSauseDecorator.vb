Public Class TommatoSauseDecorator
    Inherits ToppingDecortator

    Sub New(pizza As IPizza)
        MyBase.New(pizza)
    End Sub


    Public Overrides Function getCost() As Double
        Return thePizza.getCost() + 0.5
    End Function

    Public Overrides Function getDescription() As String
        Return thePizza.getDescription() & ", tomato sause"
    End Function

End Class
