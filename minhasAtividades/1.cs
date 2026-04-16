Console.WriteLine("Bem vindo!");

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do {
    Console.WriteLine("Digite um número de 1 a 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto){
        Console.WriteLine("Parabéns, você acertou!!");
        break;
    } else if (chute > numeroSecreto)
    {
        Console.WriteLine("O número é menor");
    } else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior");
    }

} while (true);
