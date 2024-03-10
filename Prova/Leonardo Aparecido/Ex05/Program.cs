using System;

class Program
{
    static void Main(string[] args)
    {
        const string usuario = "admin";
        const int senha = 123;

        Console.WriteLine("Digite o usuario:");
        string usuarioDigitado = Console.ReadLine();

        Console.WriteLine("Digite a senha:");
        int senhaDigitada = int.Parse(Console.ReadLine());

        if (usuarioDigitado == usuario && senhaDigitada == senha)
        {
            Console.WriteLine("Login realidado com sucesso!");
        }
        else
        {
            Console.WriteLine("Falha no login!");
        }
        
    }
}