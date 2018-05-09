Imports System.Math

Module Eje1_12
    Sub main()
        Dim num1 As Decimal

        Console.Write("Ingrese un numero: ")
        num1 = Console.ReadLine()

        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(num1))
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(num1))
        Console.WriteLine("Valor redondeado: " & Math.Round(num1))

        Console.ReadKey()
    End Sub
End Module
