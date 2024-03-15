using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroDigitado = 0;

        Console.WriteLine("Digite um valor inteiro de 1 a 9:");
        numeroDigitado = int.Parse(Console.ReadLine());

        while (numeroDigitado < 1 || numeroDigitado > 9)
        {
            Console.WriteLine("Altura invalida, insira uma altura entre 1 e 9:");
            numeroDigitado = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("");

        for (int i1 = 1; i1 <= numeroDigitado; i1++)
        {
            for (int i2 = 1; i2 <= i1; i2++)
            {
                Console.Write(i2);
            }

            Console.WriteLine("");
        }
    }
}