using System;

class Program
{
    static void Main(string[] args)
    {
        ContadorNumeros(100);
    }

    static void ContadorNumeros(int numero)
    {
        if (numero > 0)
        {
            Console.WriteLine(numero);
            numero -= 3;
            ContadorNumeros(numero);
        }

    }
}