using System;
class Program
{
    public static void Main(string[] args)
    {
        const string name = "Juca";
        const string password = "123senha";

        Console.WriteLine("Informe o usuario abaixo:");
        string userName = Console.ReadLine();

        Console.WriteLine("Informe a senha abaixo:");
        string  userPassword = Console.ReadLine();

        if (name == userName && password == userPassword)
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas!");
        }
    }
}