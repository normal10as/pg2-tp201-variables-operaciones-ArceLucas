﻿Module variables

    Public nombre As String

    Friend tipo_documento As String
    Friend numero_documento As Integer
    Friend fecha_nacimiento As Date

    Private edad As Byte

    Sub Main()
        Dim localidad As String
        Dim altura_corporal As Single
        Dim estado_civil As String
        Dim es_argentino As Boolean

        Console.Write("Ingrese su nombre: ")
        nombre = Console.ReadLine()

        Console.Write("Ingrese su tipo de documento: ")
        tipo_documento = Console.ReadLine()

        Console.Write("Ingrese su numero de documento: ")
        numero_documento = Console.ReadLine()

        Console.Write("Ingrese su localidad: ")
        localidad = Console.ReadLine()

        Console.Write("Ingrese su fecha de nacimiento: ")
        fecha_nacimiento = Console.ReadLine()

        edad = Today.Year - fecha_nacimiento.Year

        Console.Write("Ingrese su altura corporal: ")
        altura_corporal = Console.ReadLine()

        Console.Write("Ingrese su estado civil: ")
        estado_civil = Console.ReadLine()

        Console.Write("Es argentino? TRUE or FALSE: ")
        es_argentino = Console.ReadLine()

        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Tipo de documento: " & tipo_documento)
        Console.WriteLine("Numero de documento: " & numero_documento)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Fecha de nacimiento: " & fecha_nacimiento)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura corporal: " & altura_corporal)
        Console.WriteLine("Estado civil: " & estado_civil)
        Console.WriteLine("Es argentino?: " & es_argentino)

        Console.ReadKey()

    End Sub

End Module
