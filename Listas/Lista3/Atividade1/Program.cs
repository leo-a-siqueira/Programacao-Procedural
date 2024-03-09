using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
         const int pessoas = 20;
         double salarioDigitado = 0;
         double salarioTotal = 0;
         double maiorSalario = 0;
         double filhos = 0;

        
         for(int i = 1 ; i <= pessoas ; i++)
         {
            
            Console.WriteLine("Digite o salario da " + i + "° pessoa:");
            salarioDigitado = Convert.ToDouble(Console.ReadLine());
            salarioTotal += salarioDigitado;

            Console.WriteLine("Digite a quantidade de filhos da " + i + "° pessoa:");
            filhos += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            if( salarioDigitado > maiorSalario )
            {
                maiorSalario = salarioDigitado;
            }
         }
         System.Console.WriteLine( filhos + " " + pessoas);
         double mediaFilhos = (filhos / pessoas);
         double mediaSalarios = (salarioTotal / pessoas);

         Console.WriteLine("Media salarial =  R$ " +  Math.Round(mediaSalarios, 2) + ".");
         Console.WriteLine("Media do numero de filhos por habitante = " + Math.Round(mediaFilhos, 2) + ".");
         Console.WriteLine("Maior salario = R$ " + maiorSalario + ".");
    }
}