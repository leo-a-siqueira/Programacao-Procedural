using System;

class Program
{
    static void Main(string[] args)
    {
        const int quatidadeDePessoas = 10;
        string[] nomes = new string[quatidadeDePessoas];
        bool resultadoPesquisa = false;

        for (int i = 0; i < quatidadeDePessoas; i++)
        {
            nomes[i] = Console.ReadLine();
        }

        string pesquisaNome = Console.ReadLine();

        for (int i = 0; i < quatidadeDePessoas; i++)
        {
            if (pesquisaNome == nomes[i])
            {
                resultadoPesquisa = true;
            }
        }

        if (resultadoPesquisa == true)
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NAO ACHEI");
        }

    }
}