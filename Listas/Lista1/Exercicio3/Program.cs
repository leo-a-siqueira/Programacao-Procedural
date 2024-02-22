using System;

class Program
{   
    public static void Main (string[] args)
    {
        Console.WriteLine("Bem vindo ao contador de moedas de 1 centavo!");
        Console.WriteLine("Digite a quantidade de moedas de 1 centavo:");
        int moedas = int.Parse(Console.ReadLine());
        
        int reais = moedas / 100;
        int centavos = moedas % 100;

        Console.WriteLine("O total é " + reais + " Real(is) e " + centavos + " Centavo(s).");
        
    }
}