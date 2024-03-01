using System;

class Program
{
    public static void Main(string [] args)
    {
        const string name1 = "Filomena";
        const string name2 = "Joselito";

        Console.WriteLine("Informe o nome da crianca: ");
        string userName = Console.ReadLine();

        if (userName == name1)
        {
            Console.WriteLine("Rotina de Filomena\n 1. Escola das 07h as 12h\n 2. Almoço das 12h as 13\n 3. Futebol das 14h as 16h\n 4. Dever de casa das 16h as 18h");
        }
        else if (userName == name2)
        {
            System.Console.WriteLine("Rotina de Joselito:\n 1. Escola das 07h as 12:30\n 2. Almoço das 13h as 14h\n 3. Natação das 14h as 16h\n 4. Reforço escolar das 16h as 19h");
        }
        else
        {
            System.Console.WriteLine("Nome inválido! Digite o nome correto da crianca.");
        }
    }
}