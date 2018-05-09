Module concatenacion

    Sub main()
        Dim nombre_empresa As String
        Dim nombre_calle As String
        Dim altura_calle As UShort
        Dim fecha_inicio_actividades As Date

        nombre_empresa = "Mi empresa "
        nombre_calle = "Colon "
        altura_calle = "1525 "
        fecha_inicio_actividades = Today

        Console.WriteLine(nombre_empresa & nombre_calle & altura_calle & fecha_inicio_actividades)

        Console.ReadKey()

    End Sub

End Module
