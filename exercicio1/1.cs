// Escrever uma função que a partir de dois números de ponto flutuante a e b 
// exiba no console o resultado de suas quatro operações básicas 
// (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

void Operacoes()
{
    Console.WriteLine("Informe o valor do primeiro número:");
    float a = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe o valor do segundo número");
    float b = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"A soma dos números é: {a + b}");
    Console.WriteLine($"A subtração dos números é: {a - b}");
    Console.WriteLine($"A multiplicação dos números é: {a * b}");
    Console.WriteLine($"A divisão dos números é: {a / b}");
}

Operacoes();

Bandas.Executar;


