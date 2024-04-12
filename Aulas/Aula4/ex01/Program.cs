using System;

class Program
{
    static void Main(string[] args)
    {

        /*
        const double precoDaDuzia = 14.99; // const é valor fixo que não pode ser mudado ao longo do programa

        int quantidadeDeLaranjas = int.Parse(Console.ReadLine());

        int duzias = quantidadeDeLaranjas / 12;

        double resto = quantidadeDeLaranjas % 12;

        double precoFinal = (precoDaDuzia * duzias) + ((resto / 12) * precoDaDuzia);

        Console.WriteLine("Preco final eh: " + precoFinal);*/

        /*
        Console.WriteLine("Digite seu sexo representado por uma letra, exempplo M ou F");
        string sexo = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        bool debutante = (idade >= 15) && (sexo == "F");

        Console.WriteLine("Festa de debutante: " +  debutante) ;*/

        /*
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Sua nascionalidade é Xurupitense? Digite TRUE para sim e FALSE para não.");
        bool nascionalidade = bool.Parse(Console.ReadLine());

        Console.WriteLine("Você é graduado em economia?");
        bool graduadoEconomia = bool.Parse(Console.ReadLine());

        Console.WriteLine("Você é graduado em Gestão de políticas públicas?  Digite TRUE para sim e FALSE para não.");
        bool graduadoGestao = bool.Parse(Console.ReadLine());

        bool resultado = idade >= 30 && nascionalidade == true && (graduadoEconomia == true || graduadoGestao == true);

        Console.WriteLine("Você pode se candidatar a presidencia?\n" + resultado);
        */

        Console.WriteLine("A lampada esta ligada?");
        bool lampada = bool.Parse(Console.ReadLine());

        lampada = !lampada; // o ! inverte o valor da váriavel

        Console.WriteLine("A lampada esta ligada? " + lampada);




    }
}