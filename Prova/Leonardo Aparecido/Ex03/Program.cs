using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o periodo do dia para ver qual remedio tomar:\n[manha], [tarde] ou [noite]:");
        string textDigitado = Console.ReadLine();

        if(textDigitado == "manha")
        {
            Console.WriteLine("Remedio A.");
        }
        else if (textDigitado == "tarde")
        {
            Console.WriteLine("Remedio B.");
        }        
        else if (textDigitado == "noite")
        {
            Console.WriteLine("Remedio C.");
        }
        else
        {
            Console.WriteLine("Entrada invalida, favor verifique e tente novamente.");
        }
        
    }
}