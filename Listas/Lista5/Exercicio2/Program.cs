using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 10; i > 0 ; i--)
        {
            for(int i2 = 0 ; i2 <= 10 ; i2++)
            {
                Console.WriteLine(i + " x " + i2 + " = " + (i * i2));
            }
            Console.WriteLine();
        }
    }
}