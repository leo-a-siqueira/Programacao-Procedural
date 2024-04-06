using System;

class Program
{
    static void Main(string[] args)
    {
        ClassificarNadador(Convert.ToInt32(Console.ReadLine()));
    }
    static void ClassificarNadador(int idade)
    {
        if (idade < 12)
        {
            Console.WriteLine("Infantil");
        }
        else if (idade >= 12 && idade <= 14)
        {
            Console.WriteLine("Juvenil A");
        }
        else if (idade >= 15 && idade <= 17)
        {
            Console.WriteLine("Juvenil B");
        }
        else
        {
            Console.WriteLine("Adulto");
        }
    }
}