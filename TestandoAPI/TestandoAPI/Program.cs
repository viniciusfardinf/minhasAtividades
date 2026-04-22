    try
    {
    Console.WriteLine("Informe o primeiro número: ");
    double a = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe o segundo número: ");
    double b = double.Parse(Console.ReadLine()!);

    if (b == 0)
        {
            Console.WriteLine("Não é possível dividir um número por 0");
        }
        else
        {
            double divisao = a / b;
            Console.WriteLine($"A divisão é {divisao}");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida! Digite apenas números.");
    }







