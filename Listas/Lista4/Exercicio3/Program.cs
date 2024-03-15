using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();         

        for(int i = 0; i < 8; i ++)
        {
            Tabuleiro.Adicionar(0, i, "s");
            Tabuleiro.Adicionar(i, 0, "s");
            Tabuleiro.Adicionar(i, 7, "s");
            Tabuleiro.Adicionar(7, i, "s");
        }

        Tabuleiro.ImprimeTabuleiro();
         
    }
}