Imports System.Math
Module Eje1_11
    'Ingresar un número por teclado y mostrar su valor absoluto, el resultado de elevarlo a la
    'décima potencia y su raíz cuadrada.
    Sub main()
        Dim num1 As Integer

        Console.Write("Ingrese un numero: ")
        num1 = Console.ReadLine()

        Console.WriteLine("Su valor absoluto es: " & Math.Abs(num1))
        Console.WriteLine("Elevado a la decima potencia: " & num1 ^ 10)
        Console.WriteLine("Su raiz cuadrada: " & Math.Sqrt(num1))

        Console.ReadKey()
    End Sub
End Module
