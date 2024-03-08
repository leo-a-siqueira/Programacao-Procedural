using System;

class Program
{
    static void Main(string[] args)
    {
        const double freteGratis = 150;
        double valorCompra = 0;
        int i = 1;

        Console.WriteLine("Digite a quantidade de intens a comprar:");
        int quantidadeItens = int.Parse(Console.ReadLine());

        while (quantidadeItens >= i )
        {
            Console.WriteLine("Digite o valor do " + i + "° produto:" );
            valorCompra += double.Parse(Console.ReadLine());
            i++;
        }
        
        if( valorCompra > freteGratis )
        {
            Console.WriteLine("\nParabens! Voce ganhou frete gratis em sua compra de valor R$ " + Math.Round(valorCompra , 2) + ".");
        }
        else
        {
            Console.WriteLine("\nO valor da sua compra eh R$ " + Math.Round(valorCompra) + ".");
        }
        
    }
}