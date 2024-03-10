using System;

class Program
{   
    static void Main(string[] args)
    {
        const double notaDeCorte = 5;

        Console.WriteLine("Digite a 1° nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2° nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 3° nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 4° nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;
        
        if( media < notaDeCorte)
        {
            Console.WriteLine("Aluno Reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno Aprovado.");
        }
    }
}