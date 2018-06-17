Module Module1

    Sub Main()

        Dim aPizza As IPizza = New PlainPizza()
        Console.WriteLine("Description: " & aPizza.getDescription & vbNewLine & "Cost: " & aPizza.getCost & vbNewLine)

        aPizza = New TommatoSauseDecorator(aPizza)
        Console.WriteLine("Description: " & aPizza.getDescription & vbNewLine & "Cost: " & aPizza.getCost & vbNewLine)

        aPizza = New MozzarellaDecorator(aPizza)
        Console.WriteLine("Description: " & aPizza.getDescription & vbNewLine & "Cost: " & aPizza.getCost & vbNewLine)

        aPizza = New MozzarellaDecorator(aPizza)
        Console.WriteLine("Description: " & aPizza.getDescription & vbNewLine & "Cost: " & aPizza.getCost & vbNewLine)

        aPizza = New PeppersDecoratorvb(aPizza)
        Console.WriteLine("Description: " & aPizza.getDescription & vbNewLine & "Cost: " & aPizza.getCost & vbNewLine)

        Dim bPizza As IPizza = New PeppersDecoratorvb(New MozzarellaDecorator(New TommatoSauseDecorator(New PlainPizza)))
        Console.WriteLine("Description: " & bPizza.getDescription & vbNewLine & "Cost: " & bPizza.getCost & vbNewLine)

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
