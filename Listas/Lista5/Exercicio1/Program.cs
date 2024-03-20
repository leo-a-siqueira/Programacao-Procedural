using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1 = 0;
        int numero2 = 200;

        for(int i = 0 ; i <= 50 ; i++)
        {
            Console.WriteLine(numero1 + " - " + numero2);
            numero1 += 2; 
            numero2 -= 4;            
        }
    }
}