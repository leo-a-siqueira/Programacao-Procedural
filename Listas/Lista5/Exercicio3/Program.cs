using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura:");
        int linha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a base:");
        int coluna = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        for(int i = 0 ; i < linha ; i ++)
        {
            for(int i2 = 0 ; i2 < coluna ; i2++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}