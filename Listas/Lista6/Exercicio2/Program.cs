using System;

class Program
{
    static void Main(string[] args)
    {
        const int quantidadeNomes = 10;
        string[] nomes = new string[quantidadeNomes];

        for (int i = 0; i < quantidadeNomes; i++)
        {
            nomes[i] = Console.ReadLine();
        }

        for (int i = quantidadeNomes - 1; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}