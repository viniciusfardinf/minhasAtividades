class ContaBancaria
{
    public int id;
    public string titular;
    public double saldo;
    public string senha;


    public void DadosDaConta()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Senha: {senha}");
    }
}