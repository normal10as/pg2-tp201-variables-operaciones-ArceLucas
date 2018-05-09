Imports System.Math
Module Eje1_13
    Sub main()
        Dim num1 As Byte
        Dim num2 As Byte
        Dim num3 As Byte

        Console.Write("Ingrese 1er numero: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese 2do numero: ")
        num2 = Console.ReadLine()
        Console.Write("Ingrese 3er numero: ")
        num3 = Console.ReadLine()

        Console.WriteLine("El mayor es: " & Math.Max(num1, Math.Max(num2, num3)))

        Console.ReadKey()
    End Sub
End Module
