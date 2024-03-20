using System;

class Prgram
{
    static void Main(string[] args)
    {
        int numeroDigitado = 0;
        int somatorio = 0;

        do
        {
            Console.WriteLine("Digite um numero inteiro positivo:");
            numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado > 0 && numeroDigitado % 2 != 0)
            {
                somatorio = somatorio + numeroDigitado;
            }

        }
        while (numeroDigitado >= 0);

        Console.WriteLine("\nO somatorio de impares eh: " + somatorio);
    }
}