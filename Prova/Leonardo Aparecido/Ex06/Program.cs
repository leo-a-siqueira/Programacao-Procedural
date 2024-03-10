using System;

class Program
{
    static void Main(string[] args)
    {
        double alturaDigitada = 0;
        double alturaFinal = 0;
        double maiorAltura = 0;
        int jogadores = 5;

        for(int jogador = 1; jogador <= jogadores; jogador ++)
        {
            Console.WriteLine("Digite a altura do " + jogador + "° jogador.");
             alturaDigitada = double.Parse(Console.ReadLine());
             alturaFinal += alturaDigitada;

            if (alturaDigitada > maiorAltura)
            {
                maiorAltura = alturaDigitada;
            }
        }
        double mediaAltura = (alturaFinal / jogadores);
        Console.WriteLine("\nA altura media do time eh: " + Math.Round(mediaAltura , 2));
        Console.WriteLine("A maior altura do time eh: " + maiorAltura);
    }
}