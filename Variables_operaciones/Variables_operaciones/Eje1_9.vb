Module Eje1_9
    Sub main()
        Console.WriteLine("--TABLE AND--")
        Console.WriteLine("V AND V = {0}", True And True)
        Console.WriteLine("V AND F = {0}", True And False)
        Console.WriteLine("F AND F = {0}", False And False)
        Console.WriteLine("F AND V = {0}", False And True)

        Console.WriteLine("--TABLE OR--")
        Console.WriteLine("V OR V = {0}", True Or True)
        Console.WriteLine("V OR F = {0}", True Or False)
        Console.WriteLine("F OR F = {0}", False Or False)
        Console.WriteLine("F OR V = {0}", False Or True)

        Console.WriteLine("--TABLE XOR--")
        Console.WriteLine("V XOR V = {0}", True Xor True)
        Console.WriteLine("V XOR F = {0}", True Xor False)
        Console.WriteLine("F XOR F = {0}", False Xor False)
        Console.WriteLine("F XOR V = {0}", False Xor True)

        Console.WriteLine("--TABLE NOT--")
        Console.WriteLine("NOT V = {0}", Not True)
        Console.WriteLine("NOT F = {0}", Not False)

        Console.ReadKey()
    End Sub
End Module
