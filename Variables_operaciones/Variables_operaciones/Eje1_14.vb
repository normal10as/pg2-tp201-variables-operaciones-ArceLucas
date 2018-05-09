Module Eje1_14
    Sub main()
        Dim fecha As Date = Now

        Console.WriteLine("Dia del a?o: " & fecha.DayOfYear)
        Console.WriteLine("Mes: " & fecha.Month)
        Console.WriteLine("Hora: " & fecha.Hour)
        Console.WriteLine("Minuto: " & fecha.Minute)

        Console.ReadKey()
    End Sub

End Module
