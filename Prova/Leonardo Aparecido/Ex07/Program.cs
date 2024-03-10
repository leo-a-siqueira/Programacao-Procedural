using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero inteiro positivo:");
        int numero = int.Parse(Console.ReadLine());

        while (numero <= 0)
        {
            Console.WriteLine("O numero precisa ser maior que 0!\n");
            Console.WriteLine("Digite um numero inteiro positivo:");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("");

        for (int i = 0; i < numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
        }
    }
}