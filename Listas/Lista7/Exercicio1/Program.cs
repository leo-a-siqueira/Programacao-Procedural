using System;

class Program
{
    static void Main(string[] args)
    {
        verificaPar(Convert.ToInt32(Console.ReadLine()));
    }
    static void verificaPar(int numero)
    {
        Console.WriteLine(numero % 2 == 0);
    }
}