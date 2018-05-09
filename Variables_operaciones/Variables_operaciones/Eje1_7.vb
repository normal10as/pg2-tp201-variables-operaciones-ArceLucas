Module Eje1_7
    Sub main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim num4 As Integer
        Dim media As Integer

        Console.Write("Ingrese 1er num: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese 2do num: ")
        num2 = Console.ReadLine()
        Console.Write("Ingrese 3er num: ")
        num3 = Console.ReadLine()
        Console.Write("Ingrese 4to num: ")
        num4 = Console.ReadLine()

        media = num1 + num2 + num3 + num4

        Console.WriteLine("La sumatoria es: " & media)
        Console.WriteLine("La media es: " & media / 4)

        Console.ReadKey()

    End Sub

End Module
