Module Semanas
    Sub main()
        Const dias_del_año As Integer = 365
        Const dias_laborables As Byte = 6
        Const dias_de_la_semana As Byte = 7

        Console.WriteLine("Cuantas semanas tiene el año: " & dias_del_año / dias_de_la_semana)
        Console.WriteLine("Cuantas Semanas son laborables: ")

        Console.ReadKey()
    End Sub

End Module
