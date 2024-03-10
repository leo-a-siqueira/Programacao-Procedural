using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de moedas de 1 centavo: ");
        int moedas = int.Parse(Console.ReadLine());

        int centavos = moedas % 100;
        int reais = moedas / 100;

        Console.WriteLine("O total em dinheiro eh: " + reais + " real(is) e " + centavos + " centavo(s).");

    }
}