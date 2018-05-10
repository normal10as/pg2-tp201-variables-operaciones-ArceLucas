Module Eje1_17
    Enum DiasSemana
        Domingo = 0
        Lunes = 1
        Martes = 2
        Miercoles = 3
        Jueves = 4
        Viernes = 5
        Sabado = 6
    End Enum

    Sub main()
        Dim fecha As Date
        Dim numDias As Byte

        Console.Write("Ingrese una fecha DD,MM,AAAA: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese el numero de dias para agregar: ")
        numDias = Console.ReadLine()

        fecha = fecha.AddDays(numDias)

        Console.WriteLine("Fecha Resultado: " & fecha)

        Dim diaSemana As DiasSemana = fecha.DayOfWeek
        Console.WriteLine("Dia correspondiente: " & diaSemana.ToString) 'toString para ver la etiqueta de la unumeraion

        Console.ReadKey()
    End Sub
End Module
