Public Class PlainPizza
    Implements IPizza


    Public Function getCost() As Double Implements IPizza.getCost
        Return 5.0
    End Function

    Public Function getDescription() As String Implements IPizza.getDescription
        Return "Thin dough"
    End Function

End Class
