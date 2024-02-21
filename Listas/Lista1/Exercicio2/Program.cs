using System;

class Program
{
    public static void Main (string[] args)
    {
        
        Console.WriteLine("Bem-vindo ao sistema de cálculo da área de triangulo.");

        Console.WriteLine("Digite a base:");
        double trianguloBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a alutra:");
        double trianguloAltura = double.Parse(Console.ReadLine());

        double resultado = (trianguloAltura + trianguloBase) / 2;
        bool Maiorde20 = (resultado >20);

        Console.WriteLine("A média é maior de 20?\n" + Maiorde20);


    }
}