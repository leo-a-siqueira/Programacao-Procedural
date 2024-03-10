using System;

class Program
{
    static void Main(string[] args)
    {
        int somatoria = 0; 
        int numero = 0;    


        Console.WriteLine("Digite um numero inteiro positivo:");
        numero = int.Parse(Console.ReadLine());   

        while( numero <= 0 )
        {
            Console.WriteLine("O numero precisa ser maior que 0!\n");
            Console.WriteLine("Digite um numero inteiro positivo:");
            numero = int.Parse(Console.ReadLine());  
        }               
        
        for(int i = 0 ; i < numero ; i++)
        {
            if( i % 2 != 0)
            {
                somatoria = somatoria + i;
            }
        }

        System.Console.WriteLine("O valor total eh: " + somatoria);
    }
}