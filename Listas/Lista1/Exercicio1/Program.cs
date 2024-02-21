using System;

class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Seja muito bem-vindo ao sistema de cálculo de média das notas de aluno.\n Abaixo digite a 1° nota:");
        Double nota1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2° nota:");        
        Double nota2 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 3° nota:");
        Double nota3 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 4° nota:");
        Double nota4 = Double.Parse(Console.ReadLine());

        
        Double resultado = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("A média do aluno é " + resultado);

    }
}