Module Eje1_16
    Sub main()
        Dim fecha As Date
        Dim numDias As Byte

        Console.Write("Ingrese una fecha DD,MM,AAAA: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese el numero de dias para agregar: ")
        numDias = Console.ReadLine()

        Console.WriteLine("Fecha Resultado: " & fecha.AddDays(numDias))

        Console.ReadKey()
    End Sub
End Module
