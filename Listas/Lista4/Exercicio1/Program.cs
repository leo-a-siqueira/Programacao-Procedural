using System;

class Program
{
    static void Main(string[] args)
    {
        for(int numero1 = 1; numero1 <= 10; numero1++)
        {
            for(int numero2 = 1; numero2 <= 10; numero2++)
            {
                Console.WriteLine(numero1 + " x " + numero2 + " = " + (numero1 * numero2));
            }
            Console.WriteLine("");
        }
    }
}